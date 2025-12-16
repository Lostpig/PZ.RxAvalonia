using Avalonia;
using Avalonia.Threading;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace PZ.RxAvalonia;

internal class RxPropertyState<TControl, TValue> : RxPropertyState where TControl : AvaloniaObject
{
    protected readonly IObservable<TValue> _obs;
    protected readonly IObserver<TValue>? _changed;
    protected readonly TControl _control;
    protected readonly AvaloniaProperty<TValue>? _avap;
    protected readonly Action<TControl, TValue>? _setter;
    protected override List<IDisposable> _subscriptions { get; init; } = [];
    private TValue? _cacheValue;

    public RxPropertyState(TControl control, Action<TControl, TValue> setter, ISubject<TValue> subject)
        : this(control, subject, subject, setter, null) { }
    public RxPropertyState(TControl control, AvaloniaProperty<TValue> avap, ISubject<TValue> subject)
        : this(control, subject, subject, null, avap) {}
    public RxPropertyState(TControl control, Action<TControl, TValue> setter, IObservable<TValue> obs)
        : this(control, obs, null, setter, null) { }
    public RxPropertyState(TControl control, AvaloniaProperty<TValue> avap, IObservable<TValue> obs)
        : this(control, obs, null, null, avap) { }

    public RxPropertyState(
        TControl control,
        IObservable<TValue> obs,
        IObserver<TValue>? changed,
        Action<TControl, TValue>? setter,
        AvaloniaProperty<TValue>? avap)
    {
        _control = control;
        _obs = obs;
        _changed = changed;
        _setter = setter;
        _avap = avap;

        if (obs is BehaviorSubject<TValue> initValue)
        {
            SetValue(initValue.Value);
        }
        Activate();
    }

    public override void Activate()
    {
        if (IsActived) return;

        _subscriptions.Add(_obs.Subscribe(SetValue));
        if (_avap != null && _changed != null)
        {
            var avapObs = _control.GetObservable(_avap);
            _subscriptions.Add(avapObs.Subscribe(_changed));
        }
        IsActived = true;
    }

    protected void SetValue(TValue newValue)
    {
        if (Dispatcher.UIThread.CheckAccess())
        {
            // If on UI thread, proceed directly
            PerformSetValue(newValue);
        }
        else
        {
            // If not on UI thread, dispatch to UI thread
            Dispatcher.UIThread.Post(() => PerformSetValue(newValue), DispatcherPriority.Normal);
        }
    }

    protected void PerformSetValue(TValue newValue)
    {
        if (_avap != null)
        {
            var oldValue = _control.GetValue(_avap);
            if (!Equals(oldValue, newValue))
            {
                _control.SetValue(_avap, newValue);
            }
        }
        else if (_setter != null && !Equals(_cacheValue, newValue))
        {
            _cacheValue = newValue;
            _setter.Invoke(_control, newValue);
        }
    }
}

internal abstract class RxPropertyState
{
    protected bool IsActived { get; set; } = false;
    protected abstract List<IDisposable> _subscriptions { get; init; }

    public abstract void Activate();

    public virtual void DeActivate()
    {
        foreach (var subscription in _subscriptions) subscription.Dispose();
        IsActived = false;
    }
}
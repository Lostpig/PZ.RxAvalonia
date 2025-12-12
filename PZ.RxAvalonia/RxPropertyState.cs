using Avalonia;
using System.Reactive.Subjects;

namespace PZ.RxAvalonia;

internal class RxPropertyStateBackup<TControl, TValue>: RxPropertyState where TControl : AvaloniaObject
{
    protected readonly IRxProperty<TValue> _rxp;
    protected readonly TControl _control;
    protected readonly AvaloniaProperty<TValue>? _avap;
    protected readonly Action<TControl, TValue>? _setter;
    protected readonly IObserver<TValue>? _changed;
    protected override IDisposable _subscription { get; init; }

    private TValue? _cacheValue;

    public RxPropertyStateBackup(TControl control, TwoWayRxProperty<TValue> rxp, Action<TControl, TValue> setter)
        : this(control, rxp, setter, null) { _changed = rxp.Changed; }
    public RxPropertyStateBackup(TControl control, TwoWayRxProperty<TValue> rxp, AvaloniaProperty<TValue> avap)
        : this(control, rxp, null, avap) { _changed = rxp.Changed; }
    public RxPropertyStateBackup(TControl control, RxProperty<TValue> rxp, Action<TControl, TValue> setter)
        : this(control, rxp, setter, null) { }
    public RxPropertyStateBackup(TControl control, RxProperty<TValue> rxp, AvaloniaProperty<TValue> avap)
        : this(control, rxp, null, avap) { }

    private RxPropertyStateBackup(
        TControl control, 
        IRxProperty<TValue> rxp, 
        Action<TControl, TValue>? setter,
        AvaloniaProperty<TValue>? avap)
    {
        _control = control;
        _rxp = rxp;
        _setter = setter;
        _avap = avap;

        SetValue(rxp.Value);
        _subscription = rxp.Observable.Subscribe(SetValue);
    }

    protected void SetValue(TValue newValue)
    {
        if (_avap != null)
        {
            if (!Equals(_control.GetValue(_avap), newValue))
            {
                _control.SetValue(_avap, newValue);
                _changed?.OnNext(newValue);
            }
        }
        else if (_setter != null && !Equals(_cacheValue, newValue))
        {
            _cacheValue = newValue;
            _setter.Invoke(_control, newValue);
            _changed?.OnNext(newValue);
        }
    }
}

internal class RxPropertyState<TControl, TValue> : RxPropertyState where TControl : AvaloniaObject
{
    protected readonly IObservable<TValue> _obs;
    protected readonly IObserver<TValue>? _changed;
    protected readonly TControl _control;
    protected readonly AvaloniaProperty<TValue>? _avap;
    protected readonly Action<TControl, TValue>? _setter;
    protected override IDisposable _subscription { get; init; }
    private TValue? _cacheValue;

    public RxPropertyState(TControl control, Action<TControl, TValue> setter, ISubject<TValue> subject)
        : this(control, subject, subject, setter, null) { }
    public RxPropertyState(TControl control, AvaloniaProperty<TValue> avap, ISubject<TValue> subject)
        : this(control, subject, subject, null, avap) {}
    public RxPropertyState(TControl control, Action<TControl, TValue> setter, IObservable<TValue> obs)
        : this(control, obs, null, setter, null) { }
    public RxPropertyState(TControl control, AvaloniaProperty<TValue> avap, IObservable<TValue> obs)
        : this(control, obs, null, null, avap) { }

    private RxPropertyState(
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

        if (obs is BehaviorSubject<TValue> bs)
        {
            SetValue(bs.Value);
        }
        _subscription = obs.Subscribe(SetValue);
    }

    protected void SetValue(TValue newValue)
    {
        if (_avap != null)
        {
            if (!Equals(_control.GetValue(_avap), newValue))
            {
                _control.SetValue(_avap, newValue);
                _changed?.OnNext(newValue);
            }
        }
        else if (_setter != null && !Equals(_cacheValue, newValue))
        {
            _cacheValue = newValue;
            _setter.Invoke(_control, newValue);
            _changed?.OnNext(newValue);
        }
    }
}

internal abstract class RxPropertyState : IDisposable
{
    protected abstract IDisposable _subscription { get; init; }
    public virtual void Dispose()
    {
        _subscription.Dispose();
    }
}
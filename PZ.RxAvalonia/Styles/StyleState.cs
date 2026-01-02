using Avalonia;
using Avalonia.Styling;
using Avalonia.Threading;
using System.Diagnostics.CodeAnalysis;
using System.Reactive.Subjects;

namespace PZ.RxAvalonia.Styles;

internal class StyleState
{
    [MemberNotNullWhen(true, nameof(_obs))]
    [MemberNotNullWhen(false, nameof(_getter))]
    public bool IsRxState { get; set; }
    private readonly Style _style;
    private Func<object?>? _getter;
    private IObservable<object?>? _obs;
    private readonly AvaloniaProperty _avap;
    private readonly Setter _setter;
    private IDisposable? _subscription;
    private bool IsActived { get; set; } = false;

    public StyleState(
        Style style,
        Func<object?> getter,
        AvaloniaProperty avap)
    {
        _style = style;
        _getter = getter;
        _avap = avap;

        var value = getter();
        _setter = new Setter(_avap, value);
        _style.Setters.Add(_setter);
        IsRxState = false;
    }
    public StyleState(
        Style style,
        IObservable<object?> obs,
        AvaloniaProperty avap)
    {
        _style = style;
        _obs = obs;
        _avap = avap;


        if (_obs is BehaviorSubject<object?> bs)
        {
            var value = bs.Value;
            _setter = new Setter(_avap, value);
            _style.Setters.Add(_setter);
        } 
        else
        {
            _setter = new Setter(_avap, null);
            _style.Setters.Add(_setter);
        }


        IsRxState = true;
    }

    public void Activate()
    {
        if (IsActived || !IsRxState) return;

        _subscription = _obs.Subscribe(SetValue);
        IsActived = true;
    }
    public void DeActivate()
    {
        _subscription?.Dispose();
        IsActived = false;
    }

    internal void UpdateValue()
    {
        if (IsRxState)
        {
            return;
        }

        var newValue = _getter();
        SetValue(newValue);
    }
    protected void SetValue(object? newValue)
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
    protected void PerformSetValue(object? newValue)
    {
        var oldValue = _setter.Value;
        if (!Equals(oldValue, newValue))
        {
            _setter.Value = newValue;
        }
    }
}

using Avalonia;

namespace PZ.RxAvalonia;

internal class FuncPropertyState<TControl, TValue>: FuncPropertyState where TControl : AvaloniaObject
{
    private readonly TControl _control;
    private readonly Func<TValue> _getter;
    private readonly Action<TControl, TValue>? _setter;
    protected readonly AvaloniaProperty<TValue>? _avap;
    private TValue? _lastValue;

    public FuncPropertyState(TControl control, Func<TValue> getter, Action<TControl, TValue> setter) 
        : this(control, getter, setter, null) { }
    public FuncPropertyState(TControl control, Func<TValue> getter, AvaloniaProperty<TValue> avap)
        : this(control, getter, null, avap) { }

    private FuncPropertyState(
        TControl control,
        Func<TValue> getter,
        Action<TControl, TValue>? setter,
        AvaloniaProperty<TValue>? avap)
    {
        _control = control;
        _getter = getter;
        _setter = setter;
        _avap = avap;

        UpdateControlValue(true);
    }

    private void UpdateControlValue(bool isInitializing = false)
    {
        if (_control == null) return;

        TValue newValue = _getter();
        if (_avap != null)
        {
            if (isInitializing)
            {
                _control.SetValue(_avap, newValue);
                _lastValue = newValue;
            }
            else
            {
                var currentValue = _control.GetValue(_avap);
                if (!Equals(currentValue, newValue))
                {
                    _control.SetValue(_avap, newValue);
                    _lastValue = newValue;
                }
            }
        }
        else
        {
            if (isInitializing || !Equals(_lastValue, newValue))
            {
                _setter?.Invoke(_control, newValue);
                _lastValue = newValue;
            }
        }
    }
    internal override void UpdateValue()
    {
        UpdateControlValue();
    }
}

internal abstract class FuncPropertyState
{
    internal abstract void UpdateValue();
}

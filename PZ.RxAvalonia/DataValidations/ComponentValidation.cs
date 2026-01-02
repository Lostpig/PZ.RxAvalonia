using Avalonia;
using Avalonia.Controls;
using System.Runtime.CompilerServices;

namespace PZ.RxAvalonia.DataValidations;

public class ComponentValidation
{
    private static readonly ConditionalWeakTable<ComponentBase, ComponentValidation> _refs = [];
    public static void Register(ComponentBase component)
    {
        if (!_refs.TryGetValue(component, out _))
        {
            var formValidation = new ComponentValidation();
            _refs.Add(component, formValidation);
        }
    }
    public static ComponentValidation? Get(ComponentBase component)
    {
        if (_refs.TryGetValue(component, out ComponentValidation? value))
        {
            return value;
        }
        return null;
    }

    private readonly Dictionary<Control, IControlValidator> _validators = [];
    public ControlValidator<TControl, TValue> GetControlValidator<TControl, TValue>(TControl control, AvaloniaProperty<TValue> avap)
            where TControl : Control
    {
        if (_validators.TryGetValue(control, out IControlValidator? value))
        {
            if (value is ControlValidator<TControl, TValue> v) return v;
        }

        var validator = new ControlValidator<TControl, TValue>(control, avap);
        _validators.Add(control, validator);
        return validator;
    }
    public IControlValidator? GetControlValidator(Control control)
    {
        if (_validators.TryGetValue(control, out IControlValidator? value))
        {
            return value;
        }
        return null;
    }

    public bool IsValid()
    {
        return _validators.All(v => v.Value.IsValid);
    }
    public void ActivateAll()
    {
        foreach (var validator in _validators.Values)
        {
            validator.Activate();
        }
    }
    public void DeactivateAll()
    {
        foreach (var validator in _validators.Values)
        {
            validator.Deactivate();
        }
    }
}


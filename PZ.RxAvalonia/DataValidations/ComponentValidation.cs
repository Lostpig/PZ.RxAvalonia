using Avalonia;
using Avalonia.Controls;
using System.ComponentModel.DataAnnotations;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Runtime.CompilerServices;

namespace PZ.RxAvalonia.DataValidations;

public class ComponentValidation
{
    private static readonly ConditionalWeakTable<ComponentBase, ComponentValidation> _refs = [];
    public static ComponentValidation Register(ComponentBase component)
    {
        if (!_refs.TryGetValue(component, out var formValidation))
        {
            formValidation = new ComponentValidation();
            _refs.Add(component, formValidation);
        }

        return formValidation;
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

    private readonly Subject<bool> _isValidSubject = new();
    public IObservable<bool> IsValidObservable => _isValidSubject;
    private IDisposable? _subscription;
    public bool IsValid()
    {
        return _validators.All(v => v.Value.IsValid);
    }
    public void ActivateAll()
    {
        _subscription = Observable.CombineLatest(_validators.Values.Select(v => v.ObservableValid))
            .Select(results => results.All(r => r))
            .Subscribe(_isValidSubject);

        foreach (var validator in _validators.Values)
        {
            validator.Activate();
        }
    }
    public void DeactivateAll()
    {
        _subscription?.Dispose();
        foreach (var validator in _validators.Values)
        {
            validator.Deactivate();
        }
    }
}


using Avalonia;
using Avalonia.Controls;
using System.Reactive.Subjects;

namespace PZ.RxAvalonia.DataValidations;

public interface IControlValidator
{
    Control Control { get; }
    bool IsValid { get; }
    IObservable<bool> ObservableValid { get; }
    string ErrorMessage { get; }
    void Activate();
    void Deactivate();
}

public class ControlValidator<TControl, TValue> : IControlValidator where TControl : Control
{
    private readonly TControl _control;
    private readonly AvaloniaProperty<TValue> _avap;
    private readonly List<IDataValidation<TValue>> _validations = [];
    private IDisposable? subscription;
    private BehaviorSubject<bool> _validSubject = new(true);

    public Control Control => _control;
    public bool IsValid => _validSubject.Value;
    public IObservable<bool> ObservableValid => _validSubject;
    public string ErrorMessage { get; private set; } = string.Empty;

    public ControlValidator(TControl control, AvaloniaProperty<TValue> avap)
    {
        _control = control;
        _avap = avap;
    }
    public void Activate()
    {
        subscription = _control.GetObservable(_avap).Subscribe(value =>
        {
            var isValid = CheckValid(value);
            if (isValid)
            {
                _control.DataValidationErrors_Errors([]);
            }
            else
            {
                _control.DataValidationErrors_Errors([ErrorMessage]);
            }
            _validSubject.OnNext(isValid);
        });
    }
    public void Deactivate()
    {
        subscription?.Dispose();
        subscription = null;
    }
    public void ExcuteCheck()
    {
        var obj = _control.GetValue(_avap);
        if (obj is TValue value)
        {
            var isValid = CheckValid(value);
            if (isValid)
            {
                _control.DataValidationErrors_Errors([]);
            }
            else
            {
                _control.DataValidationErrors_Errors([ErrorMessage]);
            }
            _validSubject.OnNext(isValid);
        }
    }

    public void AddValidation(IDataValidation<TValue> validation)
    {
        _validations.Add(validation);
    }
    private bool CheckValid(TValue value)
    {
        foreach (var validation in _validations)
        {
            if (!validation.IsValid(value))
            {
                ErrorMessage = validation.ErrorMessage;
                return false;
            }
        }
        return true;
    }
}


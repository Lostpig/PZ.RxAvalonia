using Avalonia;
using Avalonia.Controls;

namespace PZ.RxAvalonia.DataValidations;

public interface IControlValidator
{
    Control Control { get; }
    bool IsValid { get; }
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

    public Control Control => _control;
    public bool IsValid { get; private set; } = true;
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
            IsValid = CheckValid(value);
            if (IsValid)
            {
                _control.DataValidationErrors_Errors([]);
            }
            else
            {
                _control.DataValidationErrors_Errors([ErrorMessage]);
            }
        });
    }
    public void Deactivate()
    {
        subscription?.Dispose();
        subscription = null;
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


using Avalonia;
using Avalonia.Controls;
using PZ.RxAvalonia.DataValidations;

namespace PZ.RxAvalonia.Extensions;

public static class DataValidationExtensions
{
    public static TextBox Validation(this TextBox control, IDataValidation<string?> validation)
    {
        var component = ComponentBuildContext.CurrentComponent ?? throw new InvalidOperationException("Current component is not set! ");
        var compValid = ComponentValidation.Get(component);

        compValid?.GetControlValidator(control, TextBox.TextProperty).AddValidation(validation);
        return control;
    }
    public static NumericUpDown Validation(this NumericUpDown control, IDataValidation<decimal?> validation)
    {
        var component = ComponentBuildContext.CurrentComponent ?? throw new InvalidOperationException("Current component is not set! ");
        var compValid = ComponentValidation.Get(component);

        compValid?.GetControlValidator(control, NumericUpDown.ValueProperty).AddValidation(validation);
        return control;
    }
    
    public static TControl SetValidation<TControl, TValue>(this TControl control, AvaloniaProperty<TValue> avap, IDataValidation<TValue> validation)
        where TControl : Control
    {
        var component = ComponentBuildContext.CurrentComponent ?? throw new InvalidOperationException("Current component is not set! ");
        var compValid = ComponentValidation.Get(component);

        compValid?.GetControlValidator(control, avap).AddValidation(validation);
        return control;
    }
}

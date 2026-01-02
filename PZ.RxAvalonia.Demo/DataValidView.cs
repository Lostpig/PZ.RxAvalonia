using Avalonia.Controls;
using Avalonia.Layout;
using PZ.RxAvalonia.Extensions;
using System.Reactive.Subjects;

namespace PZ.RxAvalonia.Demo;
using Valid = PZ.RxAvalonia.DataValidations.DataValidations;

internal class DataValidView : ComponentBase
{
    protected override void OnCreated()
    {
        base.OnCreated();
        RegisterDataValidation();
    }
    protected override Control Build()
    {
        var maxLenValid = Valid.MaxLength(5);
        maxLenValid.ErrorMessage = $"Custom max length error: {maxLenValid.MaxLength}";

        return new StackPanel()
            .Orientation(Orientation.Vertical)
            .Spacing(8)
            .Children(
                new StackPanel().Orientation(Orientation.Horizontal)
                    .Spacing(8)
                    .Children(
                        new TextBlock().Text("Name: "),
                        new TextBox().Width(200).Text(PName)
                            .Validation(Valid.Required())
                    ),
                new StackPanel().Orientation(Orientation.Horizontal)
                    .Spacing(8)
                    .Children(
                        new TextBlock().Text("Max 5 character: "),
                        new TextBox().Width(200).Text(LengthText)
                            .Validation(maxLenValid)
                    )
            );
    }

    private BehaviorSubject<string> PName = new("");
    private BehaviorSubject<string> LengthText = new("");
}

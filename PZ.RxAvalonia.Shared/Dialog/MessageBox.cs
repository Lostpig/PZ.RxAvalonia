using Avalonia.Controls;
using Avalonia.Media;
using Ursa.Controls;

namespace PZ.RxAvalonia.Shared.Dialog;

public sealed class MessageBox : DialogContentBase<int>
{
    private readonly string _message;
    public DialogButton[] BoxButtons;
    public MessageBox(string message) : base()
    {
        _message = message;
        MinWidth = 300;
        MaxWidth = 600;

        BoxButtons = [
            new (Service.TranslateService.GetBaseField("OK"), DialogResult.OK),
        ];

        Initialize();
    }

    protected override Control Build()
    {
        return Markup.PzText(_message)
            .TextWrapping(TextWrapping.Wrap)
            .Margin(8);
    }
    public override DialogButton[] Buttons() => BoxButtons;

    public override DialogReturn<int> GetReturn(DialogResult buttonValue)
    {
        return new(0, buttonValue);
    }
    override public bool Check(DialogResult buttonValue)
    {
        return true;
    }
}


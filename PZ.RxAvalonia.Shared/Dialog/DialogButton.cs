using Ursa.Controls;

namespace PZ.RxAvalonia.Shared.Dialog;
public class DialogButton(string text, DialogResult value)
{
    public string Text { get; set; } = text;
    public bool Validation { get; set; } = false;
    public string[] Styles { get; set; } = [];
    public DialogResult Value { get; set; } = value;

    static public DialogButton Danger(string text, DialogResult value)
    {
        return new DialogButton(text, value) { Styles = ["Danger"] };
    }
    static public DialogButton Success(string text, DialogResult value)
    {
        return new DialogButton(text, value) { Styles = ["Success"] };
    }
    static public DialogButton Tertiary(string text, DialogResult value)
    {
        return new DialogButton(text, value) { Styles = ["Tertiary"] };
    }
}

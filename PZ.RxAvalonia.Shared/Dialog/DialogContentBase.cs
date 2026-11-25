using Ursa.Controls;
using MIcon = Material.Icons.MaterialIconKind;

namespace PZ.RxAvalonia.Shared.Dialog;

public abstract class DialogContentBase<T> : ComponentBase
{
    public string Title { get; set; } = "";
    public MIcon Icon { get; set; } = MIcon.Dialogue;
    public abstract DialogReturn<T> GetReturn(DialogResult buttonValue);
    public abstract bool Check(DialogResult buttonValue);
    public abstract DialogButton[] Buttons();
    protected DialogContentBase(ViewInitializationStrategy strategy = ViewInitializationStrategy.Lazy) : base(strategy) { }
    public event Action<DialogResult>? OnClose;
    protected void Close(DialogResult result)
    {
        OnClose?.Invoke(result);
    }
}

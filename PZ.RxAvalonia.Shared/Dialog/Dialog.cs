using Avalonia.Controls;
using Avalonia.Styling;
using Irihi.Avalonia.Shared.Contracts;
using PZ.RxAvalonia.DataValidations;
using System.Reactive;
using Ursa.Controls;
using static PZ.RxAvalonia.Shared.Markup;

namespace PZ.RxAvalonia.Shared.Dialog;

public class Dialog<T> : ComponentBase, IDialogContext
{
    private readonly DialogContentBase<T> _content;
    private readonly AnonymousObserver<SizeChangedEventArgs> SizeChange;
    public Dialog(DialogContentBase<T> content, Window win) : base(ViewInitializationStrategy.Lazy)
    {
        _content = content;
        _content.OnClose += (result) => Close(result);

        Initialize();

        MaxHeight = win.Height * 0.8;
        SizeChange = new(e => MaxHeight = e.NewSize.Height * 0.8);
        win.RxSizeChanged(SizeChange);
    }
    protected override Control Build()
    {
        return PzGrid(rows: "auto, 1*, auto")
            .RowSpacing(16)
            .Children(
                BuildHeader().Row(0).Margin(24, 24, 24, 0),
                new ScrollViewer().Content(_content).Padding(24, 0).Row(1),
                BuildButtons().Row(2).Margin(24, 0, 24, 24)
            );
    }

    protected StackPanel BuildHeader()
    {
        return HStackPanel(Aligns.Left)
            .Spacing(8)
            .Children(
                MaterialIcon(_content.Icon),
                PzText(_content.Title, "H5")
                    .Theme(StaticResource<ControlTheme>("TitleTextBlock"))
            );
    }
    protected StackPanel BuildButtons()
    {
        ComponentValidation? Validation = null;
        if (_content.IsRegisterDataValidation)
        {
            Validation = ComponentValidation.Get(_content);
        }

        var buttonsPanel = HStackPanel(Aligns.Right).Spacing(8);

        foreach (var btn in _content.Buttons())
        {
            var button = PzButton(btn.Text, btn.Styles ?? [])
                .OnClick(_ => TryClose(btn));
            if (Validation != null && btn.Validation)
            {
                button.IsEnabled(Validation.IsValidObservable);
            }
            buttonsPanel.Children(button);
        }

        return buttonsPanel;
    }

    private void TryClose(DialogButton btn)
    {
        if (btn.Validation && !_content.Check(btn.Value)) return;

        Close(btn.Value);
    }
    public event EventHandler<object?>? RequestClose;
    public void Close(DialogResult result)
    {
        RequestClose?.Invoke(this, _content.GetReturn(result));
        SizeChange.Dispose();
    }
    public void Close()
    {
        Close(DialogResult.Cancel);
    }
}


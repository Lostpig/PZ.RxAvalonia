using Avalonia.Controls;
using Avalonia.Layout;

namespace PZ.RxAvalonia.Demo;

internal class MainView : ComponentBase
{
    private TabItem HotReloadTabItem()
    {
        return new TabItem()
            .Header("Hot reload")
            .Content(
                new StackPanel()
                    .Children(
                        new TextBlock()
                            .Ref(out var textBlock)
                            .Padding(12)
                            .FontSize(30)
                            .HorizontalAlignment(HorizontalAlignment.Center)
                            .Text("Hello Hot Reload!"),

                        new Button()
                            .Name("HotReloadButton", Scope)
                            .Content("click me!")
                            .HorizontalAlignment(HorizontalAlignment.Center)
                            .OnClick(_ =>
                            {
                                textBlock.Text("Button clicked!");

                                var button = this.FindControl<Button>("HotReloadButton");
                                if (button != null)
                                    button.Content = "Found by Name";
                            }),
                        new HyperlinkButton()
                            .HorizontalAlignment(HorizontalAlignment.Center)
                            .NavigateUri(new Uri("https://github.com/AvaloniaUI/Avalonia.Markup.Declarative"))
                            .Content("Open on github")
                    )
            );
    }

    protected override Control Build()
    {
        return new TabControl()
            .SelectedIndex(0)
            .TabStripPlacement(Dock.Left)
            .Items(
                HotReloadTabItem(),
                new TabItem()
                    .Header("Dock sample")
                    .Content(
                        new Border().Child(
                            new DockPanel()
                                .LastChildFill(true)
                                .Children(
                                    new TextBox().Text("Left1").Dock(Dock.Left),
                                    new TextBox().Text("Right").Dock(Dock.Right),
                                    new TextBox().Text("Left2").Dock(Dock.Left)))
                    ),
                new TabItem()
                    .Header("Rx")
                    .Content(new Border().Child(new RxDemoView()))
            );
    }
}

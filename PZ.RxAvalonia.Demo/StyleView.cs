using Avalonia;
using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Media;
using Avalonia.Styling;
using System.Reactive.Subjects;

namespace PZ.RxAvalonia.Demo;

internal class StyleView : ComponentBase
{
    protected override StyleGroup? BuildStyles()
    {
        return [
                new StyleGroup(x => x.Class("narrow").Descendant())
                {
                    new Style<StackPanel>(s => s.Name("SideBar"))
                        .IsVisible(false)
                },
                new Style<Panel>(x => x.Class("ColorPanel"))
                    .Setter(Panel.BackgroundProperty, Brushes.Purple),
                new Style(x => x.Class("ColorPanel").Class(":pointerover"))
                    .SetterEx(Panel.BackgroundProperty, () => ColorBrush)
            ];
    }

    protected override Control Build()
    {
        this.Resources.Add("SecondryColor", new SolidColorBrush(Color.FromArgb(255, 225, 225, 64)));
        this.Resources.Add("RandomColor", new SolidColorBrush(Color.FromArgb(255, 225, 225, 64)));

        return new Grid().Cols("150, *")
            .BindClass(() => Bounds.Width < 400, "narrow")
            .Children(
                new StackPanel().Col(0)
                    .Name("SideBar")
                    .Background(Brushes.CadetBlue)
                    .Children(
                        new TextBlock()
                            .Name("title")
                            .Margin(top: 16, left: 16) //partial margin defined with named arguments
                            .Text("Sidebar")
                    ),
                new StackPanel().Col(1)
                    .Orientation(Orientation.Vertical)
                    .VerticalAlignment(VerticalAlignment.Top)
                    .HorizontalAlignment(HorizontalAlignment.Left)
                    .Children(
                        new Panel()
                            .Height(100).Width(400)
                            .Classes("ColorPanel"),
                        new ComboBox()
                            .ItemsSource(colors)
                            .ItemTemplate<Color>(c => new TextBlock().Text(c.ToString()))
                            .SelectedItemEx(SelectedColor),
                        new StackPanel().Orientation(Orientation.Horizontal)
                            .Spacing(10)
                            .Children(
                                new TextBlock()
                                    .Text("Primary")
                                    .Foreground(StaticColor("PrimaryColor")),
                                new TextBlock()
                                    .Text("Secondry")
                                    .Foreground(StaticColor("SecondryColor")),
                                new TextBlock()
                                    .Text("Danger")
                                    .Foreground(StaticColor("DangerColor")),
                                new TextBlock()
                                    .Text("Secondry Global")
                                    .Foreground(StaticColor("SecondryColor", Application.Current!)),
                                new TextBlock()
                                    .Text("Random Static")
                                    .Foreground(StaticColor("RandomColor")),
                                new TextBlock()
                                    .Text("Random Dynamic")
                                    .Foreground(DynamicColor("RandomColor")),
                                new Panel()
                                    .Width(50).Height(50)
                                    .Background(DynamicColor("CardBackground", this))
                            ),
                        new StackPanel().Orientation(Orientation.Horizontal)
                            .Spacing(10)
                            .Children(
                                new Button()
                                    .Content("Toggle Theme")
                                    .OnClick(_ => ToggleTheme()),
                                new Button()
                                    .Content("Change Random Color")
                                    .OnClick(_ => RandomColor())
                            )

                    )
            );
    }

    private Color[] colors =
    {
        Colors.Red,
        Colors.Green,
        Colors.Blue,
        Colors.Black,
    };
    private BehaviorSubject<Color> SelectedColor = new(Colors.Red);
    private Brush ColorBrush = Colors.Red.ToBrush();
    protected override IEnumerable<IDisposable> WhenActivate()
    {
        return
        [
            SelectedColor.Subscribe(c => {
                ColorBrush = c.ToBrush();
                UpdateState();
            })
        ];
    }
    protected override void OnSizeChanged(SizeChangedEventArgs e)
    {
        //force recalculation on window width to check if it's Narrow state now
        UpdateState();
        base.OnSizeChanged(e);
    }

    protected void ToggleTheme()
    {
        var currentTheme = Application.Current!.ActualThemeVariant;
        if (currentTheme == ThemeVariant.Dark)
            Application.Current.RequestedThemeVariant = ThemeVariant.Light;
        else
            Application.Current.RequestedThemeVariant = ThemeVariant.Dark;
    }
    protected void RandomColor()
    {
        Random random = new();
        var buf = new byte[3];
        random.NextBytes(buf);

        this.Resources["RandomColor"] = new SolidColorBrush(Color.FromArgb(255, buf[0], buf[1], buf[2]));
    }
}

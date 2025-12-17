using Avalonia.Controls;
using Avalonia.Layout;
using PZ.RxAvalonia.Reactive;
using System.Data;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace PZ.RxAvalonia.Demo;

public class RxDemoView : ComponentBase
{
    RxDemoData data = new();

    private Control BuildTitle()
    {
        return new StackPanel()
            .Orientation(Orientation.Horizontal)
            .Spacing(10)
            .Children(
                new TextBlock()
                    .Text(() => data.Title),
                new Button()
                    .Content("Change Title")
                    .OnClick(_ => ChangeTitle())
            );
    }
    private Control BuildCounter()
    {
        var counterText = data.RxCounter.Select(i => i.ToString());
        return new StackPanel()
            .Orientation(Orientation.Horizontal)
            .Spacing(10)
            .Children(
                new TextBlock()
                    .Text(counterText),
                new Button()
                    .Content("Add Counter")
                    .OnClick(_ => data.RxCounter.Reducer(i => i + 1)),
                new ComboBox()
                    .ItemsSource(data.Numbers)
                    .ItemTemplate<int>(i => new TextBlock().Text(i.ToString()))
                    .SelectedItemEx(data.RxCounter)
            );
    }
    private Control BuildSwitch()
    {
        var counterText = data.RxCounter.Select(i => i.ToString());
        return new StackPanel()
            .Orientation(Orientation.Horizontal)
            .Spacing(10)
            .Children(
                new ToggleSwitch()
                    .IsCheckedEx(data.RxBoolean),
                new CheckBox()
                    .Content("Boolean")
                    .IsCheckedEx(data.RxBoolean),
                new TextBlock().Text(data.RxBoolean.Select(x => x.ToString()))
            );
    }
    private Control BuildNumber()
    {
        var counterText = data.RxCounter.Select(i => i.ToString());
        return new StackPanel()
            .Orientation(Orientation.Horizontal)
            .Spacing(10)
            .Children(
                new NumericUpDown().ValueEx(data.RxNumber).Increment(1),
                new TextBlock().Text(data.RxNumber.Select(x => x.ToString()))
            );
    }

    protected override Control Build()
    {
        UpdateState();

        return new StackPanel()
            .Orientation(Orientation.Vertical)
            .Spacing(10)
            .Children(
                BuildTitle(),
                BuildCounter(),
                BuildSwitch(),
                BuildNumber()
            );
    }

    // func property need call UpdateState to render
    void ChangeTitle()
    {
        UpdateState();
    }
}

public class RxDemoData
{
    public BehaviorSubject<bool> RxBoolean { get; init; } = new(false);
    public BehaviorSubject<int> RxNumber { get; init; } = new(0);

    public int[] Numbers = [1, 2, 3, 4, 5, 6, 7];
    public BehaviorSubject<int> RxCounter { get; init; }

    public string Title { get; set; } = "Hello world!";

    public RxDemoData()
    {
        RxCounter = new(1);
        

        RxCounter.Subscribe(i =>
        {
            Title = $"Hello world! {i}";
        });
    }
}

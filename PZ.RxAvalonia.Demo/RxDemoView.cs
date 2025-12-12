using Avalonia.Controls;
using System.Data;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace PZ.RxAvalonia.Demo;

public class RxDemoView : ComponentBase
{
    RxDemoData data = new();
    protected override Control Build()
    {
        UpdateState();

        return new StackPanel()
            .Children(
                new TextBlock()
                    .Text(() => data.Title),
                new TextBlock()
                    .Text(data.RxText),
                new Button()
                    .Content("Add Counter")
                    .OnClick(_ => data.RxNumber.Reducer(i => i + 1)),
                new Button()
                    .Content("Change Title")
                    .OnClick(_ => ChangeTitle())
            );
    }

    void ChangeTitle()
    {
        data.Title = "Title changed!";
        UpdateState();
    }
}

public class RxDemoData
{
    public BehaviorSubject<int> RxNumber { get; init; }
    public IObservable<string> RxText { get; init; }

    public string Title { get; set; } = "Hello world!";

    public RxDemoData()
    {
        RxNumber = new(1);
        RxText = RxNumber.Select(i => i.ToString());
    }
}

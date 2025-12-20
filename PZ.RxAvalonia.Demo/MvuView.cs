using Avalonia.Controls;
using Avalonia.Layout;

namespace PZ.RxAvalonia.Demo;

internal class MvuView : MvuComponentBase<MvuViewState>
{
    protected override Control Build()
    {
        return new StackPanel()
            .Orientation(Orientation.Vertical)
            .Spacing(10)
            .Children(
                new TextBlock()
                    .Text(() => State.Text),
                new Button()
                    .Content("Increase")
                    .OnClick(_ => Dispatch(MvuViewActions.Increase)),
                new Button()
                    .Content("Decrease")
                    .OnClick(_ => Dispatch(MvuViewActions.Decrease)),
                new TextBox()
                    .Text(() => State.Name)
                    .OnTextChanged(e => Dispatch(MvuViewActions.ChangeName, GetText(e)))
            );
    }

    protected override MvuViewState State { get; set; } = new();
    private static string GetText(TextChangedEventArgs e)
    {
        return ((TextBox)e.Source!).Text ?? "";
    }
}

public abstract class MvuComponentBase<TState> : ComponentBase
{
    protected abstract TState State { get; set; }
    protected virtual void Dispatch(Func<TState, TState> func)
    {
        State = func(State);
        UpdateState();
    }
    protected virtual void Dispatch<TPayload>(Func<TState, TPayload, TState> func, TPayload payload)
    {
        State = func(State, payload);
        UpdateState();
    }
}

internal record MvuViewState
{
    public int Count { get; init; } = 0;
    public string Name { get; init; } = "Mvu View";
    public string Text => $"{Name} {Count}";
}

internal static class MvuViewActions
{
    public static MvuViewState ChangeName(MvuViewState state, string name)
    {
        return state with { Name = name };
    }
    public static MvuViewState Increase(MvuViewState state)
    {
        return state with { Count = state.Count + 1 };
    }
    public static MvuViewState Decrease(MvuViewState state)
    {
        return state with { Count = state.Count - 1 };
    }
}

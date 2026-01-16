using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Styling;

namespace PZ.RxAvalonia;

public class FuncTemplete<T>(Func<T> Builder, ComponentBase Parent) : ITemplate<T> where T : Control
{
    public T Build()
    {
        using var context = new ComponentBuildContext(Parent);
        context.SetState(ComponentBuildState.ViewBuilding);
        var content = Builder();
        context.SetState(ComponentBuildState.None);

        return content;
    }

    object? ITemplate.Build()
    {
        return Build();
    }
}

public class FuncDataTemplete<TData, TControl>(Func<TData, TControl> Builder, ComponentBase Parent) : IDataTemplate where TControl: Control
{
    public TControl Build(TData d)
    {
        using var context = new ComponentBuildContext(Parent);
        context.SetState(ComponentBuildState.ViewBuilding);
        var content = Builder(d);
        context.SetState(ComponentBuildState.None);

        return content;
    }

    public bool Match(object? data)
    {
        return data is TData;
    }

    Control? ITemplate<object?, Control?>.Build(object? param)
    {
        if (param is not TData d) throw new InvalidOperationException("Templete param type invalid!");

        return Build(d);
    }
}
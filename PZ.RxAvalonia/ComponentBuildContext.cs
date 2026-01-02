using System;
using System.Collections.Generic;
using System.Text;

namespace PZ.RxAvalonia;

internal enum ComponentBuildState
{
    None,
    StyleBuilding,
    StyleSelectorUpdating,
    ViewBuilding
}

internal class ComponentBuildContext : IDisposable
{
    internal static readonly Stack<ComponentBuildContext> ComponentStack = new();
    internal static ComponentBuildContext? _currentContext;

    internal static ComponentBase? CurrentComponent => _currentContext?._component;
    internal static ComponentBuildState? CurrentState => _currentContext?._state;

    private readonly ComponentBase _component;
    private ComponentBuildState _state;
    public ComponentBase Component => _component;

    public ComponentBuildContext(ComponentBase component)
    {
        _component = component;

        if (_currentContext != null)
            ComponentStack.Push(_currentContext);

        _currentContext = this;
    }

    internal void SetState(ComponentBuildState state)
    {
        _state = state;
    }

    public void Dispose()
    {
        _currentContext = ComponentStack.Count > 0 ? ComponentStack.Pop() : null;
    }
}

public class ComponentBuildingException(string message, Exception innerException) : Exception(message, innerException);

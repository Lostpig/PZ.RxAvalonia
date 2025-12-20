using Avalonia;
using Avalonia.Controls;

namespace PZ.RxAvalonia;

public static class ControlEventExtensions
{
    public static TControl _setEvent<TControl, THandler>(this TControl control, THandler handler, Action<THandler> subscribe)
        where TControl : AvaloniaObject
    {
        subscribe?.Invoke(handler);
        return control;
    }
}

using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Styling;
using System.Reactive.Linq;

namespace PZ.RxAvalonia.Helpers;

public static class ResourceHelpers
{
    /// <summary></summary>
    /// <remarks>Cannot find parent resource before anchor attached to logictree</remarks>
    /// <param name="resourceKey"></param>
    /// <param name="anchor"></param>
    /// <param name="themeVariant"></param>
    /// <returns></returns>
    public static object StaticResource(object resourceKey, IResourceHost anchor, ThemeVariant? themeVariant = null) 
    {
        if (anchor.TryFindResource(resourceKey, themeVariant, out var v))
        {
            return v ?? AvaloniaProperty.UnsetValue;
        }
        
        return AvaloniaProperty.UnsetValue;
    }
    /// <summary></summary>
    /// <remarks>Cannot find parent resource before anchor attached to logictree</remarks>
    /// <param name="resourceKey"></param>
    /// <param name="anchor"></param>
    /// <param name="converter"></param>
    /// <param name="themeVariant"></param>
    /// <returns></returns>
    public static T StaticResource<T>(object resourceKey, IResourceHost anchor, Func<object?, T> converter, ThemeVariant? themeVariant = null)
    {
        if (anchor.TryFindResource(resourceKey, themeVariant, out var v))
        {
            if (v is T t) return t;
            return converter(v);
        }

        return converter(null);
    }
    public static IObservable<object?> DynamicResource(object resourceKey, IResourceHost anchor)
    {
        var obs = anchor.GetResourceObservable(resourceKey);
        return obs;
    }
    public static IObservable<T> DynamicResource<T>(object resourceKey, IResourceHost anchor, Func<object?, T> converter)
    {
        var obs = anchor.GetResourceObservable(resourceKey);
        return obs.Select(o =>
        {
            if (o is T t) return t;
            else return converter(o);
        });
    }


    public static IBrush BrushConverter(object? obj)
    {
        if (obj is IBrush b) return b;
        if (obj is Color c) return new SolidColorBrush(c);
        return Brushes.Transparent;
    }
    /// <summary></summary>
    /// <remarks>Cannot find parent resource before anchor attached to logictree</remarks>
    /// <param name="resourceKey"></param>
    /// <param name="anchor"></param>
    /// <param name="themeVariant"></param>
    /// <returns></returns>
    public static IBrush StaticColor(object resourceKey, IResourceHost anchor, ThemeVariant? themeVariant = null)
    {
        return StaticResource<IBrush>(resourceKey, anchor, BrushConverter, themeVariant);
    }
    public static IObservable<IBrush> DynamicColor(object resourceKey, IResourceHost anchor)
    {
        return DynamicResource<IBrush>(resourceKey, anchor, BrushConverter);
    }
}
using Avalonia.Controls;
using Avalonia.Media;
using System.Diagnostics;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace PZ.RxAvalonia;

public static class CommonExtensions
{
    public static Brush ToBrush(this Color color) => new SolidColorBrush(color);
    public static StackTrace GetDeeperStackTrace(int depth) =>
        depth > 0 ? GetDeeperStackTrace(depth - 1) : new StackTrace(0, true);

    public static NativeMenu Items(this NativeMenu menu, params NativeMenuItemBase[] items)
    {
        foreach (var item in items)
            menu.Items.Add(item);

        return menu;
    }

    public static NativeMenuItem Items(this NativeMenuItem menu, params NativeMenuItemBase[] items)
    {
        menu.Menu ??= [];
        foreach (var item in items)
            menu.Menu.Items.Add(item);

        return menu;
    }

    public static void Reducer<T>(this BehaviorSubject<T> subject, Func<T, T> reducer)
    {
        var newValue = reducer(subject.Value);
        subject.OnNext(newValue);
    }
}

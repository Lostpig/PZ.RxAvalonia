using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Styling;
using System.Collections;
using System.Reactive.Subjects;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace PZ.RxAvalonia;

public static class ControlPropertyExtensions
{
    #region _sets
    /// <summary>
    /// Creates reactive two way binding
    /// </summary>
    /// <typeparam name="TControl"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="control"></param>
    /// <param name="setter">Property setter action</param>
    /// <param name="subject">Property two way binding subject</param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public static TControl _set<TControl, TValue>(this TControl control, Action<TControl, TValue> setter, ISubject<TValue> subject)
        where TControl : AvaloniaObject
    {
        var component = ComponentBuildContext.CurrentComponent ?? throw new InvalidOperationException("Current component is not set! ");
        var state = new RxPropertyState<TControl, TValue>(control, setter, subject);
        component.AddRxPropertyState(state);

        return control;
    }
    /// <summary>
    /// Creates reactive two way binding
    /// </summary>
    /// <typeparam name="TControl"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="control"></param>
    /// <param name="avap">Avalonia property</param>
    /// <param name="subject">Property two way binding subject</param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public static TControl _set<TControl, TValue>(this TControl control, AvaloniaProperty<TValue> avap, ISubject<TValue> subject)
        where TControl : AvaloniaObject
    {
        var component = ComponentBuildContext.CurrentComponent ?? throw new InvalidOperationException("Current component is not set! ");
        var state = new RxPropertyState<TControl, TValue>(control, avap, subject);
        component.AddRxPropertyState(state);

        return control;
    }
    /// <summary>
    /// Creates reactive one way binding
    /// </summary>
    /// <typeparam name="TControl"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="control"></param>
    /// <param name="setter">Property setter action</param>
    /// <param name="obs">Property one way binding observable</param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public static TControl _set<TControl, TValue>(this TControl control, Action<TControl, TValue> setter, IObservable<TValue> obs)
        where TControl : AvaloniaObject
    {
        var component = ComponentBuildContext.CurrentComponent ?? throw new InvalidOperationException("Current component is not set! ");
        var state = new RxPropertyState<TControl, TValue>(control, setter, obs);
        component.AddRxPropertyState(state);

        return control;
    }
    /// <summary>
    /// Creates reactive one way binding
    /// </summary>
    /// <typeparam name="TControl"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="control"></param>
    /// <param name="avap">Avalonia property</param>
    /// <param name="obs">Property one way binding observable</param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public static TControl _set<TControl, TValue>(this TControl control, AvaloniaProperty<TValue> avap, IObservable<TValue> obs)
        where TControl : AvaloniaObject
    {
        var component = ComponentBuildContext.CurrentComponent ?? throw new InvalidOperationException("Current component is not set! ");
        var state = new RxPropertyState<TControl, TValue>(control, avap, obs);
        component.AddRxPropertyState(state);

        return control;
    }
    /// <summary>
    /// Creates reactive one way binding
    /// </summary>
    /// <typeparam name="TControl"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="control"></param>
    /// <param name="setter">Property setter action</param>
    /// <param name="getter">Property getter function</param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public static TControl _set<TControl, TValue>(this TControl control, Action<TControl, TValue> setter, Func<TValue> getter)
    where TControl : AvaloniaObject
    {
        var component = ComponentBuildContext.CurrentComponent ?? throw new InvalidOperationException("Current component is not set! ");
        var state = new FuncPropertyState<TControl, TValue>(control, getter, setter);
        component.AddFuncPropertyState(state);

        return control;
    }
    /// <summary>
    /// Creates reactive one way binding
    /// </summary>
    /// <typeparam name="TControl"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="control"></param>
    /// <param name="avap">Avalonia property</param>
    /// <param name="getter">Property getter function</param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public static TControl _set<TControl, TValue>(this TControl control, AvaloniaProperty<TValue> avap, Func<TValue> getter)
        where TControl : AvaloniaObject
    {
        var component = ComponentBuildContext.CurrentComponent ?? throw new InvalidOperationException("Current component is not set! ");
        var state = new FuncPropertyState<TControl, TValue>(control, getter, avap);
        component.AddFuncPropertyState(state);

        return control;
    }
    #endregion

    public static TElement Dock<TElement>(this TElement control, Dock dock)
        where TElement : Control
    {
        DockPanel.SetDock(control, dock);
        return control;
    }

    /// <summary>
    /// It's a shortcut for Grid_Column (in xaml: Grid.Column) extension 
    /// </summary>
    /// <typeparam name="TElement"></typeparam>
    /// <param name="control">Control for positioning</param>
    /// <param name="value">Grid.Column value</param>
    /// <returns></returns>
    public static TElement Col<TElement>(this TElement control, int value)
        where TElement : Control
    {
        Grid.SetColumn(control, value);
        return control;
    }
    /// <summary>
    /// It's a shortcut for Grid_Row (in xaml: Grid.Row) extension 
    /// </summary>
    /// <typeparam name="TElement">Control type</typeparam>
    /// <param name="control">Control for positioning</param>
    /// <param name="value">Grid.Row value</param>
    /// <returns></returns>
    public static TElement Row<TElement>(this TElement control, int value)
        where TElement : Control
    {
        Grid.SetRow(control, value);
        return control;
    }
    /// <summary>
    /// It's a shortcut for Grid_Column (in xaml: Grid.Column) and Grid_Row (in xaml: Grid.Row) extension 
    /// </summary>
    /// <typeparam name="TElement">Control type</typeparam>
    /// <param name="control">Control for positioning</param>
    /// <param name="col">Grid.Col value</param>
    /// <param name="row">Grid.Row value</param>
    /// <returns></returns>
    public static TElement Cell<TElement>(this TElement control, int col, int row)
        where TElement : Control
    {
        Grid.SetColumn(control, col);
        Grid.SetRow(control, row);
        return control;
    }

    /// <summary>
    /// It's a shortcut for Grid_ColumnDefinitions (in xaml: Grid.ColumnDefinitions) extension 
    /// </summary>
    /// <typeparam name="TElement">Grid</typeparam>
    /// <param name="control">Grid control</param>
    /// <param name="value">Grid.ColumnDefinitions value</param>
    /// <returns></returns>
    public static TElement Cols<TElement>(this TElement control, ColumnDefinitions value)
        where TElement : Grid
    {
        control.ColumnDefinitions = value;
        return control;
    }
    /// <summary>
    /// It's a shortcut for Grid_RowDefinitions (in xaml: Grid.RowDefinitions) extension 
    /// </summary>
    /// <typeparam name="TElement">Grid</typeparam>
    /// <param name="control">Grid control</param>
    /// <param name="value">Grid.RowDefinitions value</param>
    /// <returns></returns>
    public static TElement Rows<TElement>(this TElement control, RowDefinitions value)
        where TElement : Grid
    {
        control.RowDefinitions = value;
        return control;
    }
    /// <summary>
    /// It's a shortcut for Grid_ColumnDefinitions (in xaml: Grid.ColumnDefinitions) extension 
    /// </summary>
    /// <typeparam name="TElement">Grid</typeparam>
    /// <param name="control">Grid control</param>
    /// <param name="value">String representing ColumnDefinitions i.e. "0,*,30,Auto" </param>
    /// <returns></returns>
    public static TElement Cols<TElement>(this TElement control, string value)
        where TElement : Grid
    {
        control.ColumnDefinitions = ColumnDefinitions.Parse(value);
        return control;
    }
    /// <summary>
    /// It's a shortcut for Grid_RowDefinitions (in xaml: Grid.RowDefinitions) extension 
    /// </summary>
    /// <typeparam name="TElement">Grid</typeparam>
    /// <param name="control">Grid control</param>
    /// <param name="value">String representing RowDefinitions i.e. "0,*,30,Auto" </param>
    /// <returns></returns>
    public static TElement Rows<TElement>(this TElement control, string value)
        where TElement : Grid
    {
        control.RowDefinitions = RowDefinitions.Parse(value);
        return control;
    }
    /// <summary>
    /// It's a shortcut for Grid_ColumnSpan (in xaml: Grid.ColumnSpan) extension 
    /// </summary>
    /// <typeparam name="TElement">Control Type</typeparam>
    /// <param name="control">Control for positioning</param>
    /// <param name="value">Grid.ColumnSpan value</param>
    /// <returns></returns>
    public static TElement ColSpan<TElement>(this TElement control, int value)
        where TElement : Control
    {
        Grid.SetColumnSpan(control, value);
        return control;
    }
    /// <summary>
    /// It's a shortcut for Grid_RowSpan (in xaml: Grid.RowSpan) extension 
    /// </summary>
    /// <typeparam name="TElement">Control type</typeparam>
    /// <param name="control">Control for positioning</param>
    /// <param name="value">Grid.RowSpan value</param>
    /// <returns></returns>
    public static TElement RowSpan<TElement>(this TElement control, int value)
        where TElement : Control
    {
        Grid.SetRowSpan(control, value);
        return control;
    }

    public static TPanel Children<TPanel>(this TPanel container, params Control[] children)
        where TPanel : Panel
    {
        foreach (var child in children)
            container.Children.Add(child);
        return container;
    }
    public static TItemsControl Items<TItemsControl>(this TItemsControl container, params AvaloniaObject[] items)
        where TItemsControl : ItemsControl
    {
        if (container.Items is IList itemsCollection)
            foreach (var item in items)
                itemsCollection.Add(item);
        return container;
    }

    public static TabControl ItemTemplate<TItem>(this TabControl control, Func<TItem, Control> build)
    {
        return ItemTemplate<TItem, TabControl>(control, build);
    }
    public static SelectingItemsControl ItemTemplate<TItem>(
        this SelectingItemsControl control, Func<TItem, Control> build
        )
    {
        return ItemTemplate<TItem, SelectingItemsControl>(control, build);
    }
    public static TItemsControl ItemTemplate<TItem, TItemsControl>(
        this TItemsControl control,
        Func<TItem, Control> build) where TItemsControl : ItemsControl
    {
        control.ItemTemplate = new FuncDataTemplate<TItem>((val, _) => build(val));
        return control;
    }

    public static MenuFlyout ItemTemplate<TItem>(this MenuFlyout control, Func<TItem, Control> build)
    {
        control.ItemTemplate = new FuncDataTemplate<TItem>((val, _) => build(val));
        return control;
    }
    public static MenuItem ItemTemplate<TItem>(this MenuItem control, Func<TItem, Control> build)
    {
        control.ItemTemplate = new FuncDataTemplate<TItem>((val, _) => build(val));
        return control;
    }
    public static Menu ItemTemplate<TItem>(this Menu control, Func<TItem, Control> build)
    {
        control.ItemTemplate = new FuncDataTemplate<TItem>((val, _) => build(val));
        return control;
    }

    record PanelTemplate(Panel Panel) : ITemplate<Panel?>
    {
        public Panel Build() => Panel;
        object ITemplate.Build() => throw new NotImplementedException();
    }
    public static TItemsControl ItemsPanel<TItemsControl>(this TItemsControl control, Panel panel)
        where TItemsControl : ItemsControl
    {
        control.ItemsPanel = new PanelTemplate(panel);
        return control;
    }

    public static TElement With<TElement>(this TElement control, Action<TElement> process)
    {
        process?.Invoke(control);
        return control;
    }
    public static TElement Name<TElement>(this TElement control, string name, INameScope ns)
        where TElement : Control
    {
        ns?.Register(name, control);
        control.Name = name;
        return control;
    }

    public static TElement Styles<TElement>(this TElement control, params Style[] styles)
        where TElement : Control
    {
        foreach (var style in styles)
            control.Styles.Add(style);

        return control;
    }
    public static TElement Styles<TElement>(this TElement control, IEnumerable<Style> styles)
        where TElement : Control
    {
        foreach (var style in styles)
            control.Styles.Add(style);

        return control;
    }

    public static TElement Classes<TElement>(this TElement control, string className)
        where TElement : Control
    {
        control.Classes.Add(className);
        return control;
    }

    public static TElement BindClass<TElement>(this TElement control, IObservable<bool> obs, string className)
        where TElement : Control
    {
        void setter (TElement el, bool value)
        {
            el.Classes.Set(className, value);
        }
        return control._set(setter, obs);
    }
    public static TElement BindClass<TElement>(this TElement control, Func<bool> getter, string className)
        where TElement : Control
    {
        void setter(TElement el, bool value)
        {
            el.Classes.Set(className, value);
        }
        return control._set(setter, getter);
    }

    public static TElement DataTemplates<TElement>(this TElement control, params IDataTemplate[] dataTemplate)
        where TElement : Control
    {
        foreach (var template in dataTemplate)
            control.DataTemplates.Add(template);
        return control;
    }
    public static TElement SetProp<TElement, TValue>(this TElement control, Avalonia.AvaloniaProperty property,
        TValue value)
        where TElement : Control
    {
        if (value is IBinding binding)
        {
            control[!property] = binding;
        }
        else
        {
            control[property] = value;
        }

        return control;
    }

    public static TElement ToolTip<TElement, TValue>(this TElement control, TValue value)
        where TElement : Control
    {
        var prop = Avalonia.Controls.ToolTip.TipProperty;
        if (value is IBinding binding)
        {
            control[!prop] = binding;
        }
        else
        {
            control[prop] = value;
        }

        return control;
    }
    public static TElement ToolTip<TElement, TValue>(this TElement control, Func<TValue> func)
        where TElement : Control
    {
        static void setter(TElement c, TValue v) => c[Avalonia.Controls.ToolTip.TipProperty] = v;
        return control._set(setter, func);
    }

    /// <summary>
    /// Adds flyout to button and activates it on button click
    /// </summary>
    /// <typeparam name="TElement"></typeparam>
    /// <param name="control">target button</param>
    /// <param name="flyout">flyout to activate</param>
    /// <returns></returns>
    public static TElement AddFlyoutOnClick<TElement>(this TElement control, FlyoutBase flyout)
        where TElement : Button
    {
        control.OnClick(_ => flyout.ShowAt(control));
        return control;
    }
    /// <summary>
    /// Adds a menu item to the specified menu flyout.
    /// </summary>
    /// <typeparam name="TElement">The type of the menu flyout element.</typeparam>
    /// <param name="menuFlyout">The menu flyout to which the item will be added.</param>
    /// <param name="menuItem">The menu item to be added to the flyout.</param>
    /// <returns>The menu flyout with the added item.</returns>
    public static TElement AddItem<TElement>(this TElement menuFlyout, MenuItem menuItem)
        where TElement : MenuFlyout
    {
        menuFlyout.Items.Add(menuItem);
        return menuFlyout;
    }
    /// <summary>
    /// Adds item to MenuFlyout
    /// </summary>
    /// <typeparam name="TElement">MenuFlyout type</typeparam>
    /// <param name="menuFlyout">Target MenuFlyout control</param>
    /// <param name="text">Item text</param>
    /// <param name="command">Item command</param>
    /// <param name="commandParameter">Command parameter</param>
    /// <returns></returns>
    public static TElement AddItem<TElement>(this TElement menuFlyout, string text, ICommand command,
        object? commandParameter = null)
        where TElement : MenuFlyout
    {
        var item = new MenuItem() { Header = text, Command = command };
        if (commandParameter != null)
            item.CommandParameter = commandParameter;

        menuFlyout.Items.Add(item);
        return menuFlyout;
    }
    /// <summary>
    /// Sets control instance reference to field so it can be accessed later in Markup
    /// </summary>
    /// <typeparam name="TElement">Control Type</typeparam>
    /// <param name="control">Control instance</param>
    /// <param name="field">field that will accept reference to control</param>
    /// <returns></returns>
    public static TElement Ref<TElement>(this TElement control, out TElement field)
    {
        field = control;
        return control;
    }
}

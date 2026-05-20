#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Reactive.Subjects;
using System.Runtime.CompilerServices;

namespace PZ.RxAvalonia;
[global::System.CodeDom.Compiler.GeneratedCode("PZ.AvaloniaExtensionGenerator", "1.0.0.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class CommandBar_MarkupExtensions
{
//================= Properties ======================//
 // PrimaryCommands

/*ValueSetterGenerator*/
public static T PrimaryCommands<T>(this T control, System.Collections.Generic.IList<Avalonia.Controls.ICommandBarElement> value) where T : Avalonia.Controls.CommandBar 
{
    control.PrimaryCommands = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PrimaryCommands<T>(this T control, Func<System.Collections.Generic.IList<Avalonia.Controls.ICommandBarElement>> func) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.PrimaryCommandsProperty!, func);

/*SetterFromObservableGenerator*/
public static T PrimaryCommands<T>(this T control, IObservable<System.Collections.Generic.IList<Avalonia.Controls.ICommandBarElement>> obs) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.PrimaryCommandsProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PrimaryCommands<T>(this T control, ISubject<System.Collections.Generic.IList<Avalonia.Controls.ICommandBarElement>> subject) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.PrimaryCommandsProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T PrimaryCommands<T>(this T control, IObservable<System.Collections.Generic.IList<Avalonia.Controls.ICommandBarElement>> obs, IObserver<System.Collections.Generic.IList<Avalonia.Controls.ICommandBarElement>> changed) where T : Avalonia.Controls.CommandBar 
   => control._setEx(Avalonia.Controls.CommandBar.PrimaryCommandsProperty!, obs, changed);


 // SecondaryCommands

/*ValueSetterGenerator*/
public static T SecondaryCommands<T>(this T control, System.Collections.Generic.IList<Avalonia.Controls.ICommandBarElement> value) where T : Avalonia.Controls.CommandBar 
{
    control.SecondaryCommands = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SecondaryCommands<T>(this T control, Func<System.Collections.Generic.IList<Avalonia.Controls.ICommandBarElement>> func) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.SecondaryCommandsProperty!, func);

/*SetterFromObservableGenerator*/
public static T SecondaryCommands<T>(this T control, IObservable<System.Collections.Generic.IList<Avalonia.Controls.ICommandBarElement>> obs) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.SecondaryCommandsProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SecondaryCommands<T>(this T control, ISubject<System.Collections.Generic.IList<Avalonia.Controls.ICommandBarElement>> subject) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.SecondaryCommandsProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SecondaryCommands<T>(this T control, IObservable<System.Collections.Generic.IList<Avalonia.Controls.ICommandBarElement>> obs, IObserver<System.Collections.Generic.IList<Avalonia.Controls.ICommandBarElement>> changed) where T : Avalonia.Controls.CommandBar 
   => control._setEx(Avalonia.Controls.CommandBar.SecondaryCommandsProperty!, obs, changed);


 // Content

/*ValueSetterGenerator*/
public static T Content<T>(this T control, System.Object? value) where T : Avalonia.Controls.CommandBar 
{
    control.Content = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Content<T>(this T control, Func<System.Object?> func) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.ContentProperty!, func);

/*SetterFromObservableGenerator*/
public static T Content<T>(this T control, IObservable<System.Object?> obs) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.ContentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Content<T>(this T control, ISubject<System.Object?> subject) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.ContentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Content<T>(this T control, IObservable<System.Object?> obs, IObserver<System.Object?> changed) where T : Avalonia.Controls.CommandBar 
   => control._setEx(Avalonia.Controls.CommandBar.ContentProperty!, obs, changed);


 // DefaultLabelPosition

/*ValueSetterGenerator*/
public static T DefaultLabelPosition<T>(this T control, Avalonia.Controls.CommandBarDefaultLabelPosition value) where T : Avalonia.Controls.CommandBar 
{
    control.DefaultLabelPosition = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DefaultLabelPosition<T>(this T control, Func<Avalonia.Controls.CommandBarDefaultLabelPosition> func) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.DefaultLabelPositionProperty!, func);

/*SetterFromObservableGenerator*/
public static T DefaultLabelPosition<T>(this T control, IObservable<Avalonia.Controls.CommandBarDefaultLabelPosition> obs) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.DefaultLabelPositionProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DefaultLabelPosition<T>(this T control, ISubject<Avalonia.Controls.CommandBarDefaultLabelPosition> subject) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.DefaultLabelPositionProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DefaultLabelPosition<T>(this T control, IObservable<Avalonia.Controls.CommandBarDefaultLabelPosition> obs, IObserver<Avalonia.Controls.CommandBarDefaultLabelPosition> changed) where T : Avalonia.Controls.CommandBar 
   => control._setEx(Avalonia.Controls.CommandBar.DefaultLabelPositionProperty!, obs, changed);


 // IsDynamicOverflowEnabled

/*ValueSetterGenerator*/
public static T IsDynamicOverflowEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.CommandBar 
{
    control.IsDynamicOverflowEnabled = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsDynamicOverflowEnabled<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.IsDynamicOverflowEnabledProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsDynamicOverflowEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.IsDynamicOverflowEnabledProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsDynamicOverflowEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.IsDynamicOverflowEnabledProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsDynamicOverflowEnabled<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.CommandBar 
   => control._setEx(Avalonia.Controls.CommandBar.IsDynamicOverflowEnabledProperty!, obs, changed);


 // OverflowButtonVisibility

/*ValueSetterGenerator*/
public static T OverflowButtonVisibility<T>(this T control, Avalonia.Controls.CommandBarOverflowButtonVisibility value) where T : Avalonia.Controls.CommandBar 
{
    control.OverflowButtonVisibility = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T OverflowButtonVisibility<T>(this T control, Func<Avalonia.Controls.CommandBarOverflowButtonVisibility> func) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.OverflowButtonVisibilityProperty!, func);

/*SetterFromObservableGenerator*/
public static T OverflowButtonVisibility<T>(this T control, IObservable<Avalonia.Controls.CommandBarOverflowButtonVisibility> obs) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.OverflowButtonVisibilityProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T OverflowButtonVisibility<T>(this T control, ISubject<Avalonia.Controls.CommandBarOverflowButtonVisibility> subject) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.OverflowButtonVisibilityProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T OverflowButtonVisibility<T>(this T control, IObservable<Avalonia.Controls.CommandBarOverflowButtonVisibility> obs, IObserver<Avalonia.Controls.CommandBarOverflowButtonVisibility> changed) where T : Avalonia.Controls.CommandBar 
   => control._setEx(Avalonia.Controls.CommandBar.OverflowButtonVisibilityProperty!, obs, changed);


 // IsOpen

/*ValueSetterGenerator*/
public static T IsOpen<T>(this T control, System.Boolean value) where T : Avalonia.Controls.CommandBar 
{
    control.IsOpen = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsOpen<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.IsOpenProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsOpen<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.IsOpenProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsOpen<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.IsOpenProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsOpen<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.CommandBar 
   => control._setEx(Avalonia.Controls.CommandBar.IsOpenProperty!, obs, changed);


 // IsSticky

/*ValueSetterGenerator*/
public static T IsSticky<T>(this T control, System.Boolean value) where T : Avalonia.Controls.CommandBar 
{
    control.IsSticky = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsSticky<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.IsStickyProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsSticky<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.IsStickyProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsSticky<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.IsStickyProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsSticky<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.CommandBar 
   => control._setEx(Avalonia.Controls.CommandBar.IsStickyProperty!, obs, changed);


 // ItemWidthBottom

/*ValueSetterGenerator*/
public static T ItemWidthBottom<T>(this T control, System.Double value) where T : Avalonia.Controls.CommandBar 
{
    control.ItemWidthBottom = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ItemWidthBottom<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.ItemWidthBottomProperty!, func);

/*SetterFromObservableGenerator*/
public static T ItemWidthBottom<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.ItemWidthBottomProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ItemWidthBottom<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.ItemWidthBottomProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ItemWidthBottom<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.CommandBar 
   => control._setEx(Avalonia.Controls.CommandBar.ItemWidthBottomProperty!, obs, changed);


 // ItemWidthRight

/*ValueSetterGenerator*/
public static T ItemWidthRight<T>(this T control, System.Double value) where T : Avalonia.Controls.CommandBar 
{
    control.ItemWidthRight = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ItemWidthRight<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.ItemWidthRightProperty!, func);

/*SetterFromObservableGenerator*/
public static T ItemWidthRight<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.ItemWidthRightProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ItemWidthRight<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.ItemWidthRightProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ItemWidthRight<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.CommandBar 
   => control._setEx(Avalonia.Controls.CommandBar.ItemWidthRightProperty!, obs, changed);


 // ItemWidthCollapsed

/*ValueSetterGenerator*/
public static T ItemWidthCollapsed<T>(this T control, System.Double value) where T : Avalonia.Controls.CommandBar 
{
    control.ItemWidthCollapsed = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ItemWidthCollapsed<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.ItemWidthCollapsedProperty!, func);

/*SetterFromObservableGenerator*/
public static T ItemWidthCollapsed<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.ItemWidthCollapsedProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ItemWidthCollapsed<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.CommandBar 
   => control._set(Avalonia.Controls.CommandBar.ItemWidthCollapsedProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ItemWidthCollapsed<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.CommandBar 
   => control._setEx(Avalonia.Controls.CommandBar.ItemWidthCollapsedProperty!, obs, changed);



//================= Events ======================//
 // Opening

/*ActionToEventGenerator*/
public static T OnOpening<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.CommandBar 
{
  control.AddHandler(Avalonia.Controls.CommandBar.OpeningEvent, (_, args) => action(args), routes ?? Avalonia.Controls.CommandBar.OpeningEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxOpening<T>(this T control, IObserver<Avalonia.Interactivity.RoutedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.CommandBar 
{
  control.AddHandler(Avalonia.Controls.CommandBar.OpeningEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.CommandBar.OpeningEvent.RoutingStrategies);
  return control;
}



 // Opened

/*ActionToEventGenerator*/
public static T OnOpened<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.CommandBar 
{
  control.AddHandler(Avalonia.Controls.CommandBar.OpenedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.CommandBar.OpenedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxOpened<T>(this T control, IObserver<Avalonia.Interactivity.RoutedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.CommandBar 
{
  control.AddHandler(Avalonia.Controls.CommandBar.OpenedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.CommandBar.OpenedEvent.RoutingStrategies);
  return control;
}



 // Closing

/*ActionToEventGenerator*/
public static T OnClosing<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.CommandBar 
{
  control.AddHandler(Avalonia.Controls.CommandBar.ClosingEvent, (_, args) => action(args), routes ?? Avalonia.Controls.CommandBar.ClosingEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxClosing<T>(this T control, IObserver<Avalonia.Interactivity.RoutedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.CommandBar 
{
  control.AddHandler(Avalonia.Controls.CommandBar.ClosingEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.CommandBar.ClosingEvent.RoutingStrategies);
  return control;
}



 // Closed

/*ActionToEventGenerator*/
public static T OnClosed<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.CommandBar 
{
  control.AddHandler(Avalonia.Controls.CommandBar.ClosedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.CommandBar.ClosedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxClosed<T>(this T control, IObserver<Avalonia.Interactivity.RoutedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.CommandBar 
{
  control.AddHandler(Avalonia.Controls.CommandBar.ClosedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.CommandBar.ClosedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // PrimaryCommands

/*ValueStyleSetterGenerator*/
public static Style<T> PrimaryCommands<T>(this Style<T> style, System.Collections.Generic.IList<Avalonia.Controls.ICommandBarElement> value) where T : Avalonia.Controls.CommandBar 
=> style._addSetter(Avalonia.Controls.CommandBar.PrimaryCommandsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PrimaryCommands<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.CommandBar 
=> style._addSetter(Avalonia.Controls.CommandBar.PrimaryCommandsProperty, binding);


 // SecondaryCommands

/*ValueStyleSetterGenerator*/
public static Style<T> SecondaryCommands<T>(this Style<T> style, System.Collections.Generic.IList<Avalonia.Controls.ICommandBarElement> value) where T : Avalonia.Controls.CommandBar 
=> style._addSetter(Avalonia.Controls.CommandBar.SecondaryCommandsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SecondaryCommands<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.CommandBar 
=> style._addSetter(Avalonia.Controls.CommandBar.SecondaryCommandsProperty, binding);


 // Content

/*ValueStyleSetterGenerator*/
public static Style<T> Content<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.CommandBar 
=> style._addSetter(Avalonia.Controls.CommandBar.ContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Content<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.CommandBar 
=> style._addSetter(Avalonia.Controls.CommandBar.ContentProperty, binding);


 // DefaultLabelPosition

/*ValueStyleSetterGenerator*/
public static Style<T> DefaultLabelPosition<T>(this Style<T> style, Avalonia.Controls.CommandBarDefaultLabelPosition value) where T : Avalonia.Controls.CommandBar 
=> style._addSetter(Avalonia.Controls.CommandBar.DefaultLabelPositionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DefaultLabelPosition<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.CommandBar 
=> style._addSetter(Avalonia.Controls.CommandBar.DefaultLabelPositionProperty, binding);


 // IsDynamicOverflowEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsDynamicOverflowEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.CommandBar 
=> style._addSetter(Avalonia.Controls.CommandBar.IsDynamicOverflowEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDynamicOverflowEnabled<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.CommandBar 
=> style._addSetter(Avalonia.Controls.CommandBar.IsDynamicOverflowEnabledProperty, binding);


 // OverflowButtonVisibility

/*ValueStyleSetterGenerator*/
public static Style<T> OverflowButtonVisibility<T>(this Style<T> style, Avalonia.Controls.CommandBarOverflowButtonVisibility value) where T : Avalonia.Controls.CommandBar 
=> style._addSetter(Avalonia.Controls.CommandBar.OverflowButtonVisibilityProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> OverflowButtonVisibility<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.CommandBar 
=> style._addSetter(Avalonia.Controls.CommandBar.OverflowButtonVisibilityProperty, binding);


 // IsOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.CommandBar 
=> style._addSetter(Avalonia.Controls.CommandBar.IsOpenProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsOpen<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.CommandBar 
=> style._addSetter(Avalonia.Controls.CommandBar.IsOpenProperty, binding);


 // IsSticky

/*ValueStyleSetterGenerator*/
public static Style<T> IsSticky<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.CommandBar 
=> style._addSetter(Avalonia.Controls.CommandBar.IsStickyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsSticky<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.CommandBar 
=> style._addSetter(Avalonia.Controls.CommandBar.IsStickyProperty, binding);


 // ItemWidthBottom

/*ValueStyleSetterGenerator*/
public static Style<T> ItemWidthBottom<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.CommandBar 
=> style._addSetter(Avalonia.Controls.CommandBar.ItemWidthBottomProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemWidthBottom<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.CommandBar 
=> style._addSetter(Avalonia.Controls.CommandBar.ItemWidthBottomProperty, binding);


 // ItemWidthRight

/*ValueStyleSetterGenerator*/
public static Style<T> ItemWidthRight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.CommandBar 
=> style._addSetter(Avalonia.Controls.CommandBar.ItemWidthRightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemWidthRight<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.CommandBar 
=> style._addSetter(Avalonia.Controls.CommandBar.ItemWidthRightProperty, binding);


 // ItemWidthCollapsed

/*ValueStyleSetterGenerator*/
public static Style<T> ItemWidthCollapsed<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.CommandBar 
=> style._addSetter(Avalonia.Controls.CommandBar.ItemWidthCollapsedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemWidthCollapsed<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.CommandBar 
=> style._addSetter(Avalonia.Controls.CommandBar.ItemWidthCollapsedProperty, binding);



}

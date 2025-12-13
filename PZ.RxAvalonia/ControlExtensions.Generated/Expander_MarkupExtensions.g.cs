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
public static partial class Expander_MarkupExtensions
{
//================= Properties ======================//
 // ContentTransition

/*ValueSetterGenerator*/
public static T ContentTransition<T>(this T control, Avalonia.Animation.IPageTransition value) where T : Avalonia.Controls.Expander 
{
    control.ContentTransition = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ContentTransition<T>(this T control, Func<Avalonia.Animation.IPageTransition> func) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.ContentTransitionProperty!, func);

/*SetterFromObservableGenerator*/
public static T ContentTransition<T>(this T control, IObservable<Avalonia.Animation.IPageTransition> obs) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.ContentTransitionProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ContentTransition<T>(this T control, ISubject<Avalonia.Animation.IPageTransition> subject) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.ContentTransitionProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ContentTransition<T>(this T control, IObservable<Avalonia.Animation.IPageTransition> obs, IObserver<Avalonia.Animation.IPageTransition> changed) where T : Avalonia.Controls.Expander 
   => control._setEx(Avalonia.Controls.Expander.ContentTransitionProperty!, obs, changed);


 // ExpandDirection

/*ValueSetterGenerator*/
public static T ExpandDirection<T>(this T control, Avalonia.Controls.ExpandDirection value) where T : Avalonia.Controls.Expander 
{
    control.ExpandDirection = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ExpandDirection<T>(this T control, Func<Avalonia.Controls.ExpandDirection> func) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.ExpandDirectionProperty!, func);

/*SetterFromObservableGenerator*/
public static T ExpandDirection<T>(this T control, IObservable<Avalonia.Controls.ExpandDirection> obs) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.ExpandDirectionProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ExpandDirection<T>(this T control, ISubject<Avalonia.Controls.ExpandDirection> subject) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.ExpandDirectionProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ExpandDirection<T>(this T control, IObservable<Avalonia.Controls.ExpandDirection> obs, IObserver<Avalonia.Controls.ExpandDirection> changed) where T : Avalonia.Controls.Expander 
   => control._setEx(Avalonia.Controls.Expander.ExpandDirectionProperty!, obs, changed);


 // IsExpanded

/*ValueSetterGenerator*/
public static T IsExpanded<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Expander 
{
    control.IsExpanded = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsExpanded<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.IsExpandedProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsExpanded<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.IsExpandedProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsExpanded<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.IsExpandedProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsExpanded<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Expander 
   => control._setEx(Avalonia.Controls.Expander.IsExpandedProperty!, obs, changed);



//================= Events ======================//
 // Collapsed

/*ActionToEventGenerator*/
public static T OnCollapsed<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Expander 
{
  control.AddHandler(Avalonia.Controls.Expander.CollapsedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Expander.CollapsedEvent.RoutingStrategies);
  return control;
}



 // Collapsing

/*ActionToEventGenerator*/
public static T OnCollapsing<T>(this T control, Action<Avalonia.Interactivity.CancelRoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Expander 
{
  control.AddHandler(Avalonia.Controls.Expander.CollapsingEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Expander.CollapsingEvent.RoutingStrategies);
  return control;
}



 // Expanded

/*ActionToEventGenerator*/
public static T OnExpanded<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Expander 
{
  control.AddHandler(Avalonia.Controls.Expander.ExpandedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Expander.ExpandedEvent.RoutingStrategies);
  return control;
}



 // Expanding

/*ActionToEventGenerator*/
public static T OnExpanding<T>(this T control, Action<Avalonia.Interactivity.CancelRoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Expander 
{
  control.AddHandler(Avalonia.Controls.Expander.ExpandingEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Expander.ExpandingEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // ContentTransition

/*ValueStyleSetterGenerator*/
public static Style<T> ContentTransition<T>(this Style<T> style, Avalonia.Animation.IPageTransition value) where T : Avalonia.Controls.Expander 
=> style._addSetter(Avalonia.Controls.Expander.ContentTransitionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ContentTransition<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Expander 
=> style._addSetter(Avalonia.Controls.Expander.ContentTransitionProperty, binding);


 // ExpandDirection

/*ValueStyleSetterGenerator*/
public static Style<T> ExpandDirection<T>(this Style<T> style, Avalonia.Controls.ExpandDirection value) where T : Avalonia.Controls.Expander 
=> style._addSetter(Avalonia.Controls.Expander.ExpandDirectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ExpandDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Expander 
=> style._addSetter(Avalonia.Controls.Expander.ExpandDirectionProperty, binding);


 // IsExpanded

/*ValueStyleSetterGenerator*/
public static Style<T> IsExpanded<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Expander 
=> style._addSetter(Avalonia.Controls.Expander.IsExpandedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsExpanded<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Expander 
=> style._addSetter(Avalonia.Controls.Expander.IsExpandedProperty, binding);



}

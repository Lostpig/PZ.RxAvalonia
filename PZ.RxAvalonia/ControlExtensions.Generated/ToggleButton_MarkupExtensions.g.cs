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
public static partial class ToggleButton_MarkupExtensions
{
//================= Properties ======================//
 // IsChecked

/*ValueSetterGenerator*/
public static T IsChecked<T>(this T control, System.Nullable<System.Boolean> value) where T : Avalonia.Controls.Primitives.ToggleButton 
{
    control.IsChecked = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsChecked<T>(this T control, Func<System.Nullable<System.Boolean>> func) where T : Avalonia.Controls.Primitives.ToggleButton 
   => control._set(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsChecked<T>(this T control, IObservable<System.Nullable<System.Boolean>> obs) where T : Avalonia.Controls.Primitives.ToggleButton 
   => control._set(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsChecked<T>(this T control, ISubject<System.Nullable<System.Boolean>> subject) where T : Avalonia.Controls.Primitives.ToggleButton 
   => control._set(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsChecked<T>(this T control, IObservable<System.Nullable<System.Boolean>> obs, IObserver<System.Nullable<System.Boolean>> changed) where T : Avalonia.Controls.Primitives.ToggleButton 
   => control._setEx(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty!, obs, changed);


 // IsThreeState

/*ValueSetterGenerator*/
public static T IsThreeState<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.ToggleButton 
{
    control.IsThreeState = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsThreeState<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Primitives.ToggleButton 
   => control._set(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsThreeState<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Primitives.ToggleButton 
   => control._set(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsThreeState<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Primitives.ToggleButton 
   => control._set(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsThreeState<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Primitives.ToggleButton 
   => control._setEx(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty!, obs, changed);



//================= Events ======================//
 // Checked

/*ActionToEventGenerator*/
[Obsolete]public static T OnChecked<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Primitives.ToggleButton 
{
  control.AddHandler(Avalonia.Controls.Primitives.ToggleButton.CheckedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Primitives.ToggleButton.CheckedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
[Obsolete]public static T RxChecked<T>(this T control, IObserver<Avalonia.Interactivity.RoutedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Primitives.ToggleButton 
{
  control.AddHandler(Avalonia.Controls.Primitives.ToggleButton.CheckedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.Primitives.ToggleButton.CheckedEvent.RoutingStrategies);
  return control;
}



 // Unchecked

/*ActionToEventGenerator*/
[Obsolete]public static T OnUnchecked<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Primitives.ToggleButton 
{
  control.AddHandler(Avalonia.Controls.Primitives.ToggleButton.UncheckedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Primitives.ToggleButton.UncheckedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
[Obsolete]public static T RxUnchecked<T>(this T control, IObserver<Avalonia.Interactivity.RoutedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Primitives.ToggleButton 
{
  control.AddHandler(Avalonia.Controls.Primitives.ToggleButton.UncheckedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.Primitives.ToggleButton.UncheckedEvent.RoutingStrategies);
  return control;
}



 // Indeterminate

/*ActionToEventGenerator*/
[Obsolete]public static T OnIndeterminate<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Primitives.ToggleButton 
{
  control.AddHandler(Avalonia.Controls.Primitives.ToggleButton.IndeterminateEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Primitives.ToggleButton.IndeterminateEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
[Obsolete]public static T RxIndeterminate<T>(this T control, IObserver<Avalonia.Interactivity.RoutedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Primitives.ToggleButton 
{
  control.AddHandler(Avalonia.Controls.Primitives.ToggleButton.IndeterminateEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.Primitives.ToggleButton.IndeterminateEvent.RoutingStrategies);
  return control;
}



 // IsCheckedChanged

/*ActionToEventGenerator*/
public static T OnIsCheckedChanged<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Primitives.ToggleButton 
{
  control.AddHandler(Avalonia.Controls.Primitives.ToggleButton.IsCheckedChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Primitives.ToggleButton.IsCheckedChangedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxIsCheckedChanged<T>(this T control, IObserver<Avalonia.Interactivity.RoutedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Primitives.ToggleButton 
{
  control.AddHandler(Avalonia.Controls.Primitives.ToggleButton.IsCheckedChangedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.Primitives.ToggleButton.IsCheckedChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // IsChecked

/*ValueStyleSetterGenerator*/
public static Style<T> IsChecked<T>(this Style<T> style, System.Nullable<System.Boolean> value) where T : Avalonia.Controls.Primitives.ToggleButton 
=> style._addSetter(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsChecked<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ToggleButton 
=> style._addSetter(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty, binding);


 // IsThreeState

/*ValueStyleSetterGenerator*/
public static Style<T> IsThreeState<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.ToggleButton 
=> style._addSetter(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsThreeState<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ToggleButton 
=> style._addSetter(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty, binding);



}

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
public static partial class Control_MarkupExtensions
{
//================= Properties ======================//
 // FocusAdorner

/*ValueSetterGenerator*/
public static T FocusAdorner<T>(this T control, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value) where T : Avalonia.Controls.Control 
{
    control.FocusAdorner = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FocusAdorner<T>(this T control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> func) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.FocusAdornerProperty!, func);

/*SetterFromObservableGenerator*/
public static T FocusAdorner<T>(this T control, IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.FocusAdornerProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FocusAdorner<T>(this T control, ISubject<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.FocusAdornerProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T FocusAdorner<T>(this T control, IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> obs, IObserver<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> changed) where T : Avalonia.Controls.Control 
   => control._setEx(Avalonia.Controls.Control.FocusAdornerProperty!, obs, changed);


 // Tag

/*ValueSetterGenerator*/
public static T Tag<T>(this T control, System.Object? value) where T : Avalonia.Controls.Control 
{
    control.Tag = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Tag<T>(this T control, Func<System.Object?> func) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.TagProperty!, func);

/*SetterFromObservableGenerator*/
public static T Tag<T>(this T control, IObservable<System.Object?> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.TagProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Tag<T>(this T control, ISubject<System.Object?> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.TagProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Tag<T>(this T control, IObservable<System.Object?> obs, IObserver<System.Object?> changed) where T : Avalonia.Controls.Control 
   => control._setEx(Avalonia.Controls.Control.TagProperty!, obs, changed);


 // ContextMenu

/*ValueSetterGenerator*/
public static T ContextMenu<T>(this T control, Avalonia.Controls.ContextMenu? value) where T : Avalonia.Controls.Control 
{
    control.ContextMenu = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ContextMenu<T>(this T control, Func<Avalonia.Controls.ContextMenu?> func) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.ContextMenuProperty!, func);

/*SetterFromObservableGenerator*/
public static T ContextMenu<T>(this T control, IObservable<Avalonia.Controls.ContextMenu?> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.ContextMenuProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ContextMenu<T>(this T control, ISubject<Avalonia.Controls.ContextMenu?> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.ContextMenuProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ContextMenu<T>(this T control, IObservable<Avalonia.Controls.ContextMenu?> obs, IObserver<Avalonia.Controls.ContextMenu?> changed) where T : Avalonia.Controls.Control 
   => control._setEx(Avalonia.Controls.Control.ContextMenuProperty!, obs, changed);


 // ContextFlyout

/*ValueSetterGenerator*/
public static T ContextFlyout<T>(this T control, Avalonia.Controls.Primitives.FlyoutBase? value) where T : Avalonia.Controls.Control 
{
    control.ContextFlyout = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ContextFlyout<T>(this T control, Func<Avalonia.Controls.Primitives.FlyoutBase?> func) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.ContextFlyoutProperty!, func);

/*SetterFromObservableGenerator*/
public static T ContextFlyout<T>(this T control, IObservable<Avalonia.Controls.Primitives.FlyoutBase?> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.ContextFlyoutProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ContextFlyout<T>(this T control, ISubject<Avalonia.Controls.Primitives.FlyoutBase?> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.ContextFlyoutProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ContextFlyout<T>(this T control, IObservable<Avalonia.Controls.Primitives.FlyoutBase?> obs, IObserver<Avalonia.Controls.Primitives.FlyoutBase?> changed) where T : Avalonia.Controls.Control 
   => control._setEx(Avalonia.Controls.Control.ContextFlyoutProperty!, obs, changed);



//================= Events ======================//
 // ContextRequested

/*ActionToEventGenerator*/
public static T OnContextRequested<T>(this T control, Action<Avalonia.Controls.ContextRequestedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Control 
{
  control.AddHandler(Avalonia.Controls.Control.ContextRequestedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Control.ContextRequestedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxContextRequested<T>(this T control, IObserver<Avalonia.Controls.ContextRequestedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Control 
{
  control.AddHandler(Avalonia.Controls.Control.ContextRequestedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.Control.ContextRequestedEvent.RoutingStrategies);
  return control;
}



 // Loaded

/*ActionToEventGenerator*/
public static T OnLoaded<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Control 
{
  control.AddHandler(Avalonia.Controls.Control.LoadedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Control.LoadedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxLoaded<T>(this T control, IObserver<Avalonia.Interactivity.RoutedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Control 
{
  control.AddHandler(Avalonia.Controls.Control.LoadedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.Control.LoadedEvent.RoutingStrategies);
  return control;
}



 // Unloaded

/*ActionToEventGenerator*/
public static T OnUnloaded<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Control 
{
  control.AddHandler(Avalonia.Controls.Control.UnloadedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Control.UnloadedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxUnloaded<T>(this T control, IObserver<Avalonia.Interactivity.RoutedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Control 
{
  control.AddHandler(Avalonia.Controls.Control.UnloadedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.Control.UnloadedEvent.RoutingStrategies);
  return control;
}



 // SizeChanged

/*ActionToEventGenerator*/
public static T OnSizeChanged<T>(this T control, Action<Avalonia.Controls.SizeChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Control 
{
  control.AddHandler(Avalonia.Controls.Control.SizeChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Control.SizeChangedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxSizeChanged<T>(this T control, IObserver<Avalonia.Controls.SizeChangedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Control 
{
  control.AddHandler(Avalonia.Controls.Control.SizeChangedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.Control.SizeChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // FocusAdorner

/*ValueStyleSetterGenerator*/
public static Style<T> FocusAdorner<T>(this Style<T> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.FocusAdornerProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FocusAdorner<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.FocusAdornerProperty, binding);


 // Tag

/*ValueStyleSetterGenerator*/
public static Style<T> Tag<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.TagProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Tag<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.TagProperty, binding);


 // ContextMenu

/*ValueStyleSetterGenerator*/
public static Style<T> ContextMenu<T>(this Style<T> style, Avalonia.Controls.ContextMenu? value) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.ContextMenuProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ContextMenu<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.ContextMenuProperty, binding);


 // ContextFlyout

/*ValueStyleSetterGenerator*/
public static Style<T> ContextFlyout<T>(this Style<T> style, Avalonia.Controls.Primitives.FlyoutBase? value) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.ContextFlyoutProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ContextFlyout<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.ContextFlyoutProperty, binding);



}

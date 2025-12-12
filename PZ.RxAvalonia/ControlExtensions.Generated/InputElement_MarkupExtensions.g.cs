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
public static partial class InputElement_MarkupExtensions
{
//================= Properties ======================//
 // Focusable

/*ValueSetterGenerator*/
public static T Focusable<T>(this T control, System.Boolean value) where T : Avalonia.Input.InputElement 
{
    control.Focusable = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Focusable<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.FocusableProperty!, func);

/*SetterFromObservableGenerator*/
public static T Focusable<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.FocusableProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Focusable<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.FocusableProperty!, subject);


 // IsEnabled

/*ValueSetterGenerator*/
public static T IsEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Input.InputElement 
{
    control.IsEnabled = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsEnabled<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.IsEnabledProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.IsEnabledProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.IsEnabledProperty!, subject);


 // Cursor

/*ValueSetterGenerator*/
public static T Cursor<T>(this T control, Avalonia.Input.Cursor value) where T : Avalonia.Input.InputElement 
{
    control.Cursor = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Cursor<T>(this T control, Func<Avalonia.Input.Cursor> func) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.CursorProperty!, func);

/*SetterFromObservableGenerator*/
public static T Cursor<T>(this T control, IObservable<Avalonia.Input.Cursor> obs) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.CursorProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Cursor<T>(this T control, ISubject<Avalonia.Input.Cursor> subject) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.CursorProperty!, subject);


 // IsHitTestVisible

/*ValueSetterGenerator*/
public static T IsHitTestVisible<T>(this T control, System.Boolean value) where T : Avalonia.Input.InputElement 
{
    control.IsHitTestVisible = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsHitTestVisible<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.IsHitTestVisibleProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsHitTestVisible<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.IsHitTestVisibleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsHitTestVisible<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.IsHitTestVisibleProperty!, subject);


 // IsTabStop

/*ValueSetterGenerator*/
public static T IsTabStop<T>(this T control, System.Boolean value) where T : Avalonia.Input.InputElement 
{
    control.IsTabStop = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsTabStop<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.IsTabStopProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsTabStop<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.IsTabStopProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsTabStop<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.IsTabStopProperty!, subject);


 // TabIndex

/*ValueSetterGenerator*/
public static T TabIndex<T>(this T control, System.Int32 value) where T : Avalonia.Input.InputElement 
{
    control.TabIndex = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TabIndex<T>(this T control, Func<System.Int32> func) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.TabIndexProperty!, func);

/*SetterFromObservableGenerator*/
public static T TabIndex<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.TabIndexProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TabIndex<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.TabIndexProperty!, subject);



//================= Events ======================//
 // GotFocus

/*ActionToEventGenerator*/
public static T OnGotFocus<T>(this T control, Action<Avalonia.Input.GotFocusEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.GotFocusEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.GotFocusEvent.RoutingStrategies);
  return control;
}



 // LostFocus

/*ActionToEventGenerator*/
public static T OnLostFocus<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.LostFocusEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.LostFocusEvent.RoutingStrategies);
  return control;
}



 // KeyDown

/*ActionToEventGenerator*/
public static T OnKeyDown<T>(this T control, Action<Avalonia.Input.KeyEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.KeyDownEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.KeyDownEvent.RoutingStrategies);
  return control;
}



 // KeyUp

/*ActionToEventGenerator*/
public static T OnKeyUp<T>(this T control, Action<Avalonia.Input.KeyEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.KeyUpEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.KeyUpEvent.RoutingStrategies);
  return control;
}



 // TextInput

/*ActionToEventGenerator*/
public static T OnTextInput<T>(this T control, Action<Avalonia.Input.TextInputEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.TextInputEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.TextInputEvent.RoutingStrategies);
  return control;
}



 // TextInputMethodClientRequested

/*ActionToEventGenerator*/
public static T OnTextInputMethodClientRequested<T>(this T control, Action<Avalonia.Input.TextInput.TextInputMethodClientRequestedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.TextInputMethodClientRequestedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.TextInputMethodClientRequestedEvent.RoutingStrategies);
  return control;
}



 // PointerEntered

/*ActionToEventGenerator*/
public static T OnPointerEntered<T>(this T control, Action<Avalonia.Input.PointerEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerEnteredEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.PointerEnteredEvent.RoutingStrategies);
  return control;
}



 // PointerExited

/*ActionToEventGenerator*/
public static T OnPointerExited<T>(this T control, Action<Avalonia.Input.PointerEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerExitedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.PointerExitedEvent.RoutingStrategies);
  return control;
}



 // PointerMoved

/*ActionToEventGenerator*/
public static T OnPointerMoved<T>(this T control, Action<Avalonia.Input.PointerEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerMovedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.PointerMovedEvent.RoutingStrategies);
  return control;
}



 // PointerPressed

/*ActionToEventGenerator*/
public static T OnPointerPressed<T>(this T control, Action<Avalonia.Input.PointerPressedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerPressedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.PointerPressedEvent.RoutingStrategies);
  return control;
}



 // PointerReleased

/*ActionToEventGenerator*/
public static T OnPointerReleased<T>(this T control, Action<Avalonia.Input.PointerReleasedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerReleasedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.PointerReleasedEvent.RoutingStrategies);
  return control;
}



 // PointerCaptureLost

/*ActionToEventGenerator*/
public static T OnPointerCaptureLost<T>(this T control, Action<Avalonia.Input.PointerCaptureLostEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerCaptureLostEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.PointerCaptureLostEvent.RoutingStrategies);
  return control;
}



 // PointerWheelChanged

/*ActionToEventGenerator*/
public static T OnPointerWheelChanged<T>(this T control, Action<Avalonia.Input.PointerWheelEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerWheelChangedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.PointerWheelChangedEvent.RoutingStrategies);
  return control;
}



 // Tapped

/*ActionToEventGenerator*/
public static T OnTapped<T>(this T control, Action<Avalonia.Input.TappedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.TappedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.TappedEvent.RoutingStrategies);
  return control;
}



 // Holding

/*ActionToEventGenerator*/
public static T OnHolding<T>(this T control, Action<Avalonia.Input.HoldingRoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.HoldingEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.HoldingEvent.RoutingStrategies);
  return control;
}



 // DoubleTapped

/*ActionToEventGenerator*/
public static T OnDoubleTapped<T>(this T control, Action<Avalonia.Input.TappedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.DoubleTappedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.DoubleTappedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // Focusable

/*ValueStyleSetterGenerator*/
public static Style<T> Focusable<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.FocusableProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Focusable<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.FocusableProperty, binding);


 // IsEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.IsEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.IsEnabledProperty, binding);


 // Cursor

/*ValueStyleSetterGenerator*/
public static Style<T> Cursor<T>(this Style<T> style, Avalonia.Input.Cursor value) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.CursorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Cursor<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.CursorProperty, binding);


 // IsHitTestVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsHitTestVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.IsHitTestVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsHitTestVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.IsHitTestVisibleProperty, binding);


 // IsTabStop

/*ValueStyleSetterGenerator*/
public static Style<T> IsTabStop<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.IsTabStopProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTabStop<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.IsTabStopProperty, binding);


 // TabIndex

/*ValueStyleSetterGenerator*/
public static Style<T> TabIndex<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.TabIndexProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TabIndex<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.TabIndexProperty, binding);



}

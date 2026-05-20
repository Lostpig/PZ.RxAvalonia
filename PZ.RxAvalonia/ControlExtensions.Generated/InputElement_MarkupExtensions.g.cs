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

/*SetterFromTwoWayGenerator*/
public static T Focusable<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Input.InputElement 
   => control._setEx(Avalonia.Input.InputElement.FocusableProperty!, obs, changed);


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

/*SetterFromTwoWayGenerator*/
public static T IsEnabled<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Input.InputElement 
   => control._setEx(Avalonia.Input.InputElement.IsEnabledProperty!, obs, changed);


 // Cursor

/*ValueSetterGenerator*/
public static T Cursor<T>(this T control, Avalonia.Input.Cursor? value) where T : Avalonia.Input.InputElement 
{
    control.Cursor = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Cursor<T>(this T control, Func<Avalonia.Input.Cursor?> func) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.CursorProperty!, func);

/*SetterFromObservableGenerator*/
public static T Cursor<T>(this T control, IObservable<Avalonia.Input.Cursor?> obs) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.CursorProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Cursor<T>(this T control, ISubject<Avalonia.Input.Cursor?> subject) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.CursorProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Cursor<T>(this T control, IObservable<Avalonia.Input.Cursor?> obs, IObserver<Avalonia.Input.Cursor?> changed) where T : Avalonia.Input.InputElement 
   => control._setEx(Avalonia.Input.InputElement.CursorProperty!, obs, changed);


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

/*SetterFromTwoWayGenerator*/
public static T IsHitTestVisible<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Input.InputElement 
   => control._setEx(Avalonia.Input.InputElement.IsHitTestVisibleProperty!, obs, changed);


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

/*SetterFromTwoWayGenerator*/
public static T IsTabStop<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Input.InputElement 
   => control._setEx(Avalonia.Input.InputElement.IsTabStopProperty!, obs, changed);


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

/*SetterFromTwoWayGenerator*/
public static T TabIndex<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Input.InputElement 
   => control._setEx(Avalonia.Input.InputElement.TabIndexProperty!, obs, changed);



//================= Attached Properties ======================//
 // IsHoldingEnabled

/*AttachedPropertyFuncGenerator*/
public static T InputElement_IsHoldingEnabled<T>(this T control, Func<System.Boolean> getter) where T : Avalonia.StyledElement 
   => control._set(Avalonia.Input.InputElement.IsHoldingEnabledProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T InputElement_IsHoldingEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.StyledElement 
   => control._set(Avalonia.Input.InputElement.IsHoldingEnabledProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T InputElement_IsHoldingEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.StyledElement 
   => control._set(Avalonia.Input.InputElement.IsHoldingEnabledProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T InputElement_IsHoldingEnabled<T>(this T control, System.Boolean value) where T : Avalonia.StyledElement 
{
    control.SetValue(Avalonia.Input.InputElement.IsHoldingEnabledProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T InputElement_IsHoldingEnabled<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.StyledElement 
   => control._setEx(Avalonia.Input.InputElement.IsHoldingEnabledProperty!, obs, changed);


 // IsHoldWithMouseEnabled

/*AttachedPropertyFuncGenerator*/
public static T InputElement_IsHoldWithMouseEnabled<T>(this T control, Func<System.Boolean> getter) where T : Avalonia.StyledElement 
   => control._set(Avalonia.Input.InputElement.IsHoldWithMouseEnabledProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T InputElement_IsHoldWithMouseEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.StyledElement 
   => control._set(Avalonia.Input.InputElement.IsHoldWithMouseEnabledProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T InputElement_IsHoldWithMouseEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.StyledElement 
   => control._set(Avalonia.Input.InputElement.IsHoldWithMouseEnabledProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T InputElement_IsHoldWithMouseEnabled<T>(this T control, System.Boolean value) where T : Avalonia.StyledElement 
{
    control.SetValue(Avalonia.Input.InputElement.IsHoldWithMouseEnabledProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T InputElement_IsHoldWithMouseEnabled<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.StyledElement 
   => control._setEx(Avalonia.Input.InputElement.IsHoldWithMouseEnabledProperty!, obs, changed);



//================= Events ======================//
 // GotFocus

/*ActionToEventGenerator*/
public static T OnGotFocus<T>(this T control, Action<Avalonia.Input.FocusChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.GotFocusEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.GotFocusEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxGotFocus<T>(this T control, IObserver<Avalonia.Input.FocusChangedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.GotFocusEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.GotFocusEvent.RoutingStrategies);
  return control;
}



 // GettingFocus

/*ActionToEventGenerator*/
public static T OnGettingFocus<T>(this T control, Action<Avalonia.Input.FocusChangingEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.GettingFocusEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.GettingFocusEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxGettingFocus<T>(this T control, IObserver<Avalonia.Input.FocusChangingEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.GettingFocusEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.GettingFocusEvent.RoutingStrategies);
  return control;
}



 // LostFocus

/*ActionToEventGenerator*/
public static T OnLostFocus<T>(this T control, Action<Avalonia.Input.FocusChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.LostFocusEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.LostFocusEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxLostFocus<T>(this T control, IObserver<Avalonia.Input.FocusChangedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.LostFocusEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.LostFocusEvent.RoutingStrategies);
  return control;
}



 // LosingFocus

/*ActionToEventGenerator*/
public static T OnLosingFocus<T>(this T control, Action<Avalonia.Input.FocusChangingEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.LosingFocusEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.LosingFocusEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxLosingFocus<T>(this T control, IObserver<Avalonia.Input.FocusChangingEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.LosingFocusEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.LosingFocusEvent.RoutingStrategies);
  return control;
}



 // KeyDown

/*ActionToEventGenerator*/
public static T OnKeyDown<T>(this T control, Action<Avalonia.Input.KeyEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.KeyDownEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.KeyDownEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxKeyDown<T>(this T control, IObserver<Avalonia.Input.KeyEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.KeyDownEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.KeyDownEvent.RoutingStrategies);
  return control;
}



 // KeyUp

/*ActionToEventGenerator*/
public static T OnKeyUp<T>(this T control, Action<Avalonia.Input.KeyEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.KeyUpEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.KeyUpEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxKeyUp<T>(this T control, IObserver<Avalonia.Input.KeyEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.KeyUpEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.KeyUpEvent.RoutingStrategies);
  return control;
}



 // TextInput

/*ActionToEventGenerator*/
public static T OnTextInput<T>(this T control, Action<Avalonia.Input.TextInputEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.TextInputEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.TextInputEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxTextInput<T>(this T control, IObserver<Avalonia.Input.TextInputEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.TextInputEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.TextInputEvent.RoutingStrategies);
  return control;
}



 // TextInputMethodClientRequested

/*ActionToEventGenerator*/
public static T OnTextInputMethodClientRequested<T>(this T control, Action<Avalonia.Input.TextInput.TextInputMethodClientRequestedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.TextInputMethodClientRequestedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.TextInputMethodClientRequestedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxTextInputMethodClientRequested<T>(this T control, IObserver<Avalonia.Input.TextInput.TextInputMethodClientRequestedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.TextInputMethodClientRequestedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.TextInputMethodClientRequestedEvent.RoutingStrategies);
  return control;
}



 // PointerEntered

/*ActionToEventGenerator*/
public static T OnPointerEntered<T>(this T control, Action<Avalonia.Input.PointerEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerEnteredEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.PointerEnteredEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxPointerEntered<T>(this T control, IObserver<Avalonia.Input.PointerEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerEnteredEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.PointerEnteredEvent.RoutingStrategies);
  return control;
}



 // PointerExited

/*ActionToEventGenerator*/
public static T OnPointerExited<T>(this T control, Action<Avalonia.Input.PointerEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerExitedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.PointerExitedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxPointerExited<T>(this T control, IObserver<Avalonia.Input.PointerEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerExitedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.PointerExitedEvent.RoutingStrategies);
  return control;
}



 // PointerMoved

/*ActionToEventGenerator*/
public static T OnPointerMoved<T>(this T control, Action<Avalonia.Input.PointerEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerMovedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.PointerMovedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxPointerMoved<T>(this T control, IObserver<Avalonia.Input.PointerEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerMovedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.PointerMovedEvent.RoutingStrategies);
  return control;
}



 // PointerPressed

/*ActionToEventGenerator*/
public static T OnPointerPressed<T>(this T control, Action<Avalonia.Input.PointerPressedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerPressedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.PointerPressedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxPointerPressed<T>(this T control, IObserver<Avalonia.Input.PointerPressedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerPressedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.PointerPressedEvent.RoutingStrategies);
  return control;
}



 // PointerReleased

/*ActionToEventGenerator*/
public static T OnPointerReleased<T>(this T control, Action<Avalonia.Input.PointerReleasedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerReleasedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.PointerReleasedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxPointerReleased<T>(this T control, IObserver<Avalonia.Input.PointerReleasedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerReleasedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.PointerReleasedEvent.RoutingStrategies);
  return control;
}



 // PointerCaptureLost

/*ActionToEventGenerator*/
public static T OnPointerCaptureLost<T>(this T control, Action<Avalonia.Input.PointerCaptureLostEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerCaptureLostEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.PointerCaptureLostEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxPointerCaptureLost<T>(this T control, IObserver<Avalonia.Input.PointerCaptureLostEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerCaptureLostEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.PointerCaptureLostEvent.RoutingStrategies);
  return control;
}



 // PointerWheelChanged

/*ActionToEventGenerator*/
public static T OnPointerWheelChanged<T>(this T control, Action<Avalonia.Input.PointerWheelEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerWheelChangedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.PointerWheelChangedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxPointerWheelChanged<T>(this T control, IObserver<Avalonia.Input.PointerWheelEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerWheelChangedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.PointerWheelChangedEvent.RoutingStrategies);
  return control;
}



 // ContextRequested

/*ActionToEventGenerator*/
public static T OnContextRequested<T>(this T control, Action<Avalonia.Input.ContextRequestedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.ContextRequestedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.ContextRequestedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxContextRequested<T>(this T control, IObserver<Avalonia.Input.ContextRequestedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.ContextRequestedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.ContextRequestedEvent.RoutingStrategies);
  return control;
}



 // ContextCanceled

/*ActionToEventGenerator*/
public static T OnContextCanceled<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.ContextCanceledEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.ContextCanceledEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxContextCanceled<T>(this T control, IObserver<Avalonia.Interactivity.RoutedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.ContextCanceledEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.ContextCanceledEvent.RoutingStrategies);
  return control;
}



 // Pinch

/*ActionToEventGenerator*/
public static T OnPinch<T>(this T control, Action<Avalonia.Input.PinchEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PinchEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.PinchEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxPinch<T>(this T control, IObserver<Avalonia.Input.PinchEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PinchEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.PinchEvent.RoutingStrategies);
  return control;
}



 // PinchEnded

/*ActionToEventGenerator*/
public static T OnPinchEnded<T>(this T control, Action<Avalonia.Input.PinchEndedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PinchEndedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.PinchEndedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxPinchEnded<T>(this T control, IObserver<Avalonia.Input.PinchEndedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PinchEndedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.PinchEndedEvent.RoutingStrategies);
  return control;
}



 // PullGesture

/*ActionToEventGenerator*/
public static T OnPullGesture<T>(this T control, Action<Avalonia.Input.PullGestureEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PullGestureEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.PullGestureEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxPullGesture<T>(this T control, IObserver<Avalonia.Input.PullGestureEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PullGestureEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.PullGestureEvent.RoutingStrategies);
  return control;
}



 // PullGestureEnded

/*ActionToEventGenerator*/
public static T OnPullGestureEnded<T>(this T control, Action<Avalonia.Input.PullGestureEndedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PullGestureEndedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.PullGestureEndedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxPullGestureEnded<T>(this T control, IObserver<Avalonia.Input.PullGestureEndedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PullGestureEndedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.PullGestureEndedEvent.RoutingStrategies);
  return control;
}



 // ScrollGesture

/*ActionToEventGenerator*/
public static T OnScrollGesture<T>(this T control, Action<Avalonia.Input.ScrollGestureEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.ScrollGestureEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.ScrollGestureEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxScrollGesture<T>(this T control, IObserver<Avalonia.Input.ScrollGestureEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.ScrollGestureEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.ScrollGestureEvent.RoutingStrategies);
  return control;
}



 // ScrollGestureInertiaStarting

/*ActionToEventGenerator*/
public static T OnScrollGestureInertiaStarting<T>(this T control, Action<Avalonia.Input.ScrollGestureInertiaStartingEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.ScrollGestureInertiaStartingEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.ScrollGestureInertiaStartingEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxScrollGestureInertiaStarting<T>(this T control, IObserver<Avalonia.Input.ScrollGestureInertiaStartingEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.ScrollGestureInertiaStartingEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.ScrollGestureInertiaStartingEvent.RoutingStrategies);
  return control;
}



 // ScrollGestureEnded

/*ActionToEventGenerator*/
public static T OnScrollGestureEnded<T>(this T control, Action<Avalonia.Input.ScrollGestureEndedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.ScrollGestureEndedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.ScrollGestureEndedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxScrollGestureEnded<T>(this T control, IObserver<Avalonia.Input.ScrollGestureEndedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.ScrollGestureEndedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.ScrollGestureEndedEvent.RoutingStrategies);
  return control;
}



 // PointerTouchPadGestureMagnify

/*ActionToEventGenerator*/
public static T OnPointerTouchPadGestureMagnify<T>(this T control, Action<Avalonia.Input.PointerDeltaEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerTouchPadGestureMagnifyEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.PointerTouchPadGestureMagnifyEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxPointerTouchPadGestureMagnify<T>(this T control, IObserver<Avalonia.Input.PointerDeltaEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerTouchPadGestureMagnifyEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.PointerTouchPadGestureMagnifyEvent.RoutingStrategies);
  return control;
}



 // PointerTouchPadGestureRotate

/*ActionToEventGenerator*/
public static T OnPointerTouchPadGestureRotate<T>(this T control, Action<Avalonia.Input.PointerDeltaEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerTouchPadGestureRotateEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.PointerTouchPadGestureRotateEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxPointerTouchPadGestureRotate<T>(this T control, IObserver<Avalonia.Input.PointerDeltaEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerTouchPadGestureRotateEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.PointerTouchPadGestureRotateEvent.RoutingStrategies);
  return control;
}



 // SwipeGesture

/*ActionToEventGenerator*/
public static T OnSwipeGesture<T>(this T control, Action<Avalonia.Input.SwipeGestureEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.SwipeGestureEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.SwipeGestureEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxSwipeGesture<T>(this T control, IObserver<Avalonia.Input.SwipeGestureEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.SwipeGestureEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.SwipeGestureEvent.RoutingStrategies);
  return control;
}



 // SwipeGestureEnded

/*ActionToEventGenerator*/
public static T OnSwipeGestureEnded<T>(this T control, Action<Avalonia.Input.SwipeGestureEndedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.SwipeGestureEndedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.SwipeGestureEndedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxSwipeGestureEnded<T>(this T control, IObserver<Avalonia.Input.SwipeGestureEndedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.SwipeGestureEndedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.SwipeGestureEndedEvent.RoutingStrategies);
  return control;
}



 // PointerTouchPadGestureSwipe

/*ActionToEventGenerator*/
public static T OnPointerTouchPadGestureSwipe<T>(this T control, Action<Avalonia.Input.PointerDeltaEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerTouchPadGestureSwipeEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.PointerTouchPadGestureSwipeEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxPointerTouchPadGestureSwipe<T>(this T control, IObserver<Avalonia.Input.PointerDeltaEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerTouchPadGestureSwipeEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.PointerTouchPadGestureSwipeEvent.RoutingStrategies);
  return control;
}



 // Tapped

/*ActionToEventGenerator*/
public static T OnTapped<T>(this T control, Action<Avalonia.Input.TappedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.TappedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.TappedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxTapped<T>(this T control, IObserver<Avalonia.Input.TappedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.TappedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.TappedEvent.RoutingStrategies);
  return control;
}



 // RightTapped

/*ActionToEventGenerator*/
public static T OnRightTapped<T>(this T control, Action<Avalonia.Input.TappedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.RightTappedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.RightTappedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxRightTapped<T>(this T control, IObserver<Avalonia.Input.TappedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.RightTappedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.RightTappedEvent.RoutingStrategies);
  return control;
}



 // Holding

/*ActionToEventGenerator*/
public static T OnHolding<T>(this T control, Action<Avalonia.Input.HoldingRoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.HoldingEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.HoldingEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxHolding<T>(this T control, IObserver<Avalonia.Input.HoldingRoutedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.HoldingEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.HoldingEvent.RoutingStrategies);
  return control;
}



 // DoubleTapped

/*ActionToEventGenerator*/
public static T OnDoubleTapped<T>(this T control, Action<Avalonia.Input.TappedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.DoubleTappedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.DoubleTappedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxDoubleTapped<T>(this T control, IObserver<Avalonia.Input.TappedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.DoubleTappedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Input.InputElement.DoubleTappedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // Focusable

/*ValueStyleSetterGenerator*/
public static Style<T> Focusable<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.FocusableProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Focusable<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.FocusableProperty, binding);


 // IsEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.IsEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsEnabled<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.IsEnabledProperty, binding);


 // Cursor

/*ValueStyleSetterGenerator*/
public static Style<T> Cursor<T>(this Style<T> style, Avalonia.Input.Cursor? value) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.CursorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Cursor<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.CursorProperty, binding);


 // IsHitTestVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsHitTestVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.IsHitTestVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsHitTestVisible<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.IsHitTestVisibleProperty, binding);


 // IsTabStop

/*ValueStyleSetterGenerator*/
public static Style<T> IsTabStop<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.IsTabStopProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTabStop<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.IsTabStopProperty, binding);


 // TabIndex

/*ValueStyleSetterGenerator*/
public static Style<T> TabIndex<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.TabIndexProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TabIndex<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.TabIndexProperty, binding);



}

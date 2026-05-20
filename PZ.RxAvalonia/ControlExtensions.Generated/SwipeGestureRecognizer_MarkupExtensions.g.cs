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
public static partial class SwipeGestureRecognizer_MarkupExtensions
{
//================= Properties ======================//
 // CanHorizontallySwipe

/*ValueSetterGenerator*/
public static T CanHorizontallySwipe<T>(this T control, System.Boolean value) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
{
    control.CanHorizontallySwipe = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CanHorizontallySwipe<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.CanHorizontallySwipeProperty!, func);

/*SetterFromObservableGenerator*/
public static T CanHorizontallySwipe<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.CanHorizontallySwipeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CanHorizontallySwipe<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.CanHorizontallySwipeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T CanHorizontallySwipe<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
   => control._setEx(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.CanHorizontallySwipeProperty!, obs, changed);


 // CanVerticallySwipe

/*ValueSetterGenerator*/
public static T CanVerticallySwipe<T>(this T control, System.Boolean value) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
{
    control.CanVerticallySwipe = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CanVerticallySwipe<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.CanVerticallySwipeProperty!, func);

/*SetterFromObservableGenerator*/
public static T CanVerticallySwipe<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.CanVerticallySwipeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CanVerticallySwipe<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.CanVerticallySwipeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T CanVerticallySwipe<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
   => control._setEx(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.CanVerticallySwipeProperty!, obs, changed);


 // Threshold

/*ValueSetterGenerator*/
public static T Threshold<T>(this T control, System.Double value) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
{
    control.Threshold = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Threshold<T>(this T control, Func<System.Double> func) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.ThresholdProperty!, func);

/*SetterFromObservableGenerator*/
public static T Threshold<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.ThresholdProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Threshold<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.ThresholdProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Threshold<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
   => control._setEx(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.ThresholdProperty!, obs, changed);


 // IsMouseEnabled

/*ValueSetterGenerator*/
public static T IsMouseEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
{
    control.IsMouseEnabled = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsMouseEnabled<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.IsMouseEnabledProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsMouseEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.IsMouseEnabledProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsMouseEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.IsMouseEnabledProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsMouseEnabled<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
   => control._setEx(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.IsMouseEnabledProperty!, obs, changed);


 // IsEnabled

/*ValueSetterGenerator*/
public static T IsEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
{
    control.IsEnabled = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsEnabled<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.IsEnabledProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.IsEnabledProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.IsEnabledProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsEnabled<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
   => control._setEx(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.IsEnabledProperty!, obs, changed);



//================= Styles ======================//
 // CanHorizontallySwipe

/*ValueStyleSetterGenerator*/
public static Style<T> CanHorizontallySwipe<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
=> style._addSetter(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.CanHorizontallySwipeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CanHorizontallySwipe<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
=> style._addSetter(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.CanHorizontallySwipeProperty, binding);


 // CanVerticallySwipe

/*ValueStyleSetterGenerator*/
public static Style<T> CanVerticallySwipe<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
=> style._addSetter(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.CanVerticallySwipeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CanVerticallySwipe<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
=> style._addSetter(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.CanVerticallySwipeProperty, binding);


 // Threshold

/*ValueStyleSetterGenerator*/
public static Style<T> Threshold<T>(this Style<T> style, System.Double value) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
=> style._addSetter(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.ThresholdProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Threshold<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
=> style._addSetter(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.ThresholdProperty, binding);


 // IsMouseEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsMouseEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
=> style._addSetter(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.IsMouseEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsMouseEnabled<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
=> style._addSetter(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.IsMouseEnabledProperty, binding);


 // IsEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
=> style._addSetter(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.IsEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsEnabled<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer 
=> style._addSetter(Avalonia.Input.GestureRecognizers.SwipeGestureRecognizer.IsEnabledProperty, binding);



}

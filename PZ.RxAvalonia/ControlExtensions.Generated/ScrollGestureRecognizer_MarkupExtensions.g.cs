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
public static partial class ScrollGestureRecognizer_MarkupExtensions
{
//================= Properties ======================//
 // CanHorizontallyScroll

/*ValueSetterGenerator*/
public static T CanHorizontallyScroll<T>(this T control, System.Boolean value) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
{
    control.CanHorizontallyScroll = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CanHorizontallyScroll<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanHorizontallyScrollProperty!, func);

/*SetterFromObservableGenerator*/
public static T CanHorizontallyScroll<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanHorizontallyScrollProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CanHorizontallyScroll<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanHorizontallyScrollProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T CanHorizontallyScroll<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._setEx(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanHorizontallyScrollProperty!, obs, changed);


 // CanVerticallyScroll

/*ValueSetterGenerator*/
public static T CanVerticallyScroll<T>(this T control, System.Boolean value) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
{
    control.CanVerticallyScroll = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CanVerticallyScroll<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanVerticallyScrollProperty!, func);

/*SetterFromObservableGenerator*/
public static T CanVerticallyScroll<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanVerticallyScrollProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CanVerticallyScroll<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanVerticallyScrollProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T CanVerticallyScroll<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._setEx(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanVerticallyScrollProperty!, obs, changed);


 // IsScrollInertiaEnabled

/*ValueSetterGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
{
    control.IsScrollInertiaEnabled = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.IsScrollInertiaEnabledProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.IsScrollInertiaEnabledProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.IsScrollInertiaEnabledProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._setEx(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.IsScrollInertiaEnabledProperty!, obs, changed);


 // ScrollStartDistance

/*ValueSetterGenerator*/
public static T ScrollStartDistance<T>(this T control, System.Int32 value) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
{
    control.ScrollStartDistance = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ScrollStartDistance<T>(this T control, Func<System.Int32> func) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.ScrollStartDistanceProperty!, func);

/*SetterFromObservableGenerator*/
public static T ScrollStartDistance<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.ScrollStartDistanceProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ScrollStartDistance<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.ScrollStartDistanceProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ScrollStartDistance<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._setEx(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.ScrollStartDistanceProperty!, obs, changed);



}

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
public static partial class TransitionBase_MarkupExtensions
{
//================= Properties ======================//
 // Duration

/*ValueSetterGenerator*/
public static T Duration<T>(this T control, System.TimeSpan value) where T : Avalonia.Animation.TransitionBase 
{
    control.Duration = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Duration<T>(this T control, Func<System.TimeSpan> func) where T : Avalonia.Animation.TransitionBase 
   => control._set(Avalonia.Animation.TransitionBase.DurationProperty!, func);

/*SetterFromObservableGenerator*/
public static T Duration<T>(this T control, IObservable<System.TimeSpan> obs) where T : Avalonia.Animation.TransitionBase 
   => control._set(Avalonia.Animation.TransitionBase.DurationProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Duration<T>(this T control, ISubject<System.TimeSpan> subject) where T : Avalonia.Animation.TransitionBase 
   => control._set(Avalonia.Animation.TransitionBase.DurationProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Duration<T>(this T control, IObservable<System.TimeSpan> obs, IObserver<System.TimeSpan> changed) where T : Avalonia.Animation.TransitionBase 
   => control._setEx(Avalonia.Animation.TransitionBase.DurationProperty!, obs, changed);


 // Delay

/*ValueSetterGenerator*/
public static T Delay<T>(this T control, System.TimeSpan value) where T : Avalonia.Animation.TransitionBase 
{
    control.Delay = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Delay<T>(this T control, Func<System.TimeSpan> func) where T : Avalonia.Animation.TransitionBase 
   => control._set(Avalonia.Animation.TransitionBase.DelayProperty!, func);

/*SetterFromObservableGenerator*/
public static T Delay<T>(this T control, IObservable<System.TimeSpan> obs) where T : Avalonia.Animation.TransitionBase 
   => control._set(Avalonia.Animation.TransitionBase.DelayProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Delay<T>(this T control, ISubject<System.TimeSpan> subject) where T : Avalonia.Animation.TransitionBase 
   => control._set(Avalonia.Animation.TransitionBase.DelayProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Delay<T>(this T control, IObservable<System.TimeSpan> obs, IObserver<System.TimeSpan> changed) where T : Avalonia.Animation.TransitionBase 
   => control._setEx(Avalonia.Animation.TransitionBase.DelayProperty!, obs, changed);


 // Easing

/*ValueSetterGenerator*/
public static T Easing<T>(this T control, Avalonia.Animation.Easings.Easing value) where T : Avalonia.Animation.TransitionBase 
{
    control.Easing = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Easing<T>(this T control, Func<Avalonia.Animation.Easings.Easing> func) where T : Avalonia.Animation.TransitionBase 
   => control._set(Avalonia.Animation.TransitionBase.EasingProperty!, func);

/*SetterFromObservableGenerator*/
public static T Easing<T>(this T control, IObservable<Avalonia.Animation.Easings.Easing> obs) where T : Avalonia.Animation.TransitionBase 
   => control._set(Avalonia.Animation.TransitionBase.EasingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Easing<T>(this T control, ISubject<Avalonia.Animation.Easings.Easing> subject) where T : Avalonia.Animation.TransitionBase 
   => control._set(Avalonia.Animation.TransitionBase.EasingProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Easing<T>(this T control, IObservable<Avalonia.Animation.Easings.Easing> obs, IObserver<Avalonia.Animation.Easings.Easing> changed) where T : Avalonia.Animation.TransitionBase 
   => control._setEx(Avalonia.Animation.TransitionBase.EasingProperty!, obs, changed);



}

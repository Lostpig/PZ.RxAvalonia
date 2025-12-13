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
public static partial class Animation_MarkupExtensions
{
//================= Properties ======================//
 // Duration

/*ValueSetterGenerator*/
public static Avalonia.Animation.Animation Duration(this Avalonia.Animation.Animation control, System.TimeSpan value)  
{
    control.Duration = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Animation.Animation Duration(this Avalonia.Animation.Animation control, Func<System.TimeSpan> func)  
   => control._set(Avalonia.Animation.Animation.DurationProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Animation.Animation Duration(this Avalonia.Animation.Animation control, IObservable<System.TimeSpan> obs)  
   => control._set(Avalonia.Animation.Animation.DurationProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Animation.Animation Duration(this Avalonia.Animation.Animation control, ISubject<System.TimeSpan> subject)  
   => control._set(Avalonia.Animation.Animation.DurationProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Animation.Animation Duration(this Avalonia.Animation.Animation control, IObservable<System.TimeSpan> obs, IObserver<System.TimeSpan> changed)  
   => control._setEx(Avalonia.Animation.Animation.DurationProperty!, obs, changed);


 // IterationCount

/*ValueSetterGenerator*/
public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, Avalonia.Animation.IterationCount value)  
{
    control.IterationCount = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, System.UInt64 value = default!)  
{
    control.IterationCount = new Avalonia.Animation.IterationCount(value);
    return control;
}
public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, System.UInt64 value = default!, Avalonia.Animation.IterationType type = default!)  
{
    control.IterationCount = new Avalonia.Animation.IterationCount(value, type);
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, Func<Avalonia.Animation.IterationCount> func)  
   => control._set(Avalonia.Animation.Animation.IterationCountProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, IObservable<Avalonia.Animation.IterationCount> obs)  
   => control._set(Avalonia.Animation.Animation.IterationCountProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, ISubject<Avalonia.Animation.IterationCount> subject)  
   => control._set(Avalonia.Animation.Animation.IterationCountProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, IObservable<Avalonia.Animation.IterationCount> obs, IObserver<Avalonia.Animation.IterationCount> changed)  
   => control._setEx(Avalonia.Animation.Animation.IterationCountProperty!, obs, changed);


 // PlaybackDirection

/*ValueSetterGenerator*/
public static Avalonia.Animation.Animation PlaybackDirection(this Avalonia.Animation.Animation control, Avalonia.Animation.PlaybackDirection value)  
{
    control.PlaybackDirection = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Animation.Animation PlaybackDirection(this Avalonia.Animation.Animation control, Func<Avalonia.Animation.PlaybackDirection> func)  
   => control._set(Avalonia.Animation.Animation.PlaybackDirectionProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Animation.Animation PlaybackDirection(this Avalonia.Animation.Animation control, IObservable<Avalonia.Animation.PlaybackDirection> obs)  
   => control._set(Avalonia.Animation.Animation.PlaybackDirectionProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Animation.Animation PlaybackDirection(this Avalonia.Animation.Animation control, ISubject<Avalonia.Animation.PlaybackDirection> subject)  
   => control._set(Avalonia.Animation.Animation.PlaybackDirectionProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Animation.Animation PlaybackDirection(this Avalonia.Animation.Animation control, IObservable<Avalonia.Animation.PlaybackDirection> obs, IObserver<Avalonia.Animation.PlaybackDirection> changed)  
   => control._setEx(Avalonia.Animation.Animation.PlaybackDirectionProperty!, obs, changed);


 // FillMode

/*ValueSetterGenerator*/
public static Avalonia.Animation.Animation FillMode(this Avalonia.Animation.Animation control, Avalonia.Animation.FillMode value)  
{
    control.FillMode = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Animation.Animation FillMode(this Avalonia.Animation.Animation control, Func<Avalonia.Animation.FillMode> func)  
   => control._set(Avalonia.Animation.Animation.FillModeProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Animation.Animation FillMode(this Avalonia.Animation.Animation control, IObservable<Avalonia.Animation.FillMode> obs)  
   => control._set(Avalonia.Animation.Animation.FillModeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Animation.Animation FillMode(this Avalonia.Animation.Animation control, ISubject<Avalonia.Animation.FillMode> subject)  
   => control._set(Avalonia.Animation.Animation.FillModeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Animation.Animation FillMode(this Avalonia.Animation.Animation control, IObservable<Avalonia.Animation.FillMode> obs, IObserver<Avalonia.Animation.FillMode> changed)  
   => control._setEx(Avalonia.Animation.Animation.FillModeProperty!, obs, changed);


 // Easing

/*ValueSetterGenerator*/
public static Avalonia.Animation.Animation Easing(this Avalonia.Animation.Animation control, Avalonia.Animation.Easings.Easing value)  
{
    control.Easing = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Animation.Animation Easing(this Avalonia.Animation.Animation control, Func<Avalonia.Animation.Easings.Easing> func)  
   => control._set(Avalonia.Animation.Animation.EasingProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Animation.Animation Easing(this Avalonia.Animation.Animation control, IObservable<Avalonia.Animation.Easings.Easing> obs)  
   => control._set(Avalonia.Animation.Animation.EasingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Animation.Animation Easing(this Avalonia.Animation.Animation control, ISubject<Avalonia.Animation.Easings.Easing> subject)  
   => control._set(Avalonia.Animation.Animation.EasingProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Animation.Animation Easing(this Avalonia.Animation.Animation control, IObservable<Avalonia.Animation.Easings.Easing> obs, IObserver<Avalonia.Animation.Easings.Easing> changed)  
   => control._setEx(Avalonia.Animation.Animation.EasingProperty!, obs, changed);


 // Delay

/*ValueSetterGenerator*/
public static Avalonia.Animation.Animation Delay(this Avalonia.Animation.Animation control, System.TimeSpan value)  
{
    control.Delay = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Animation.Animation Delay(this Avalonia.Animation.Animation control, Func<System.TimeSpan> func)  
   => control._set(Avalonia.Animation.Animation.DelayProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Animation.Animation Delay(this Avalonia.Animation.Animation control, IObservable<System.TimeSpan> obs)  
   => control._set(Avalonia.Animation.Animation.DelayProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Animation.Animation Delay(this Avalonia.Animation.Animation control, ISubject<System.TimeSpan> subject)  
   => control._set(Avalonia.Animation.Animation.DelayProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Animation.Animation Delay(this Avalonia.Animation.Animation control, IObservable<System.TimeSpan> obs, IObserver<System.TimeSpan> changed)  
   => control._setEx(Avalonia.Animation.Animation.DelayProperty!, obs, changed);


 // DelayBetweenIterations

/*ValueSetterGenerator*/
public static Avalonia.Animation.Animation DelayBetweenIterations(this Avalonia.Animation.Animation control, System.TimeSpan value)  
{
    control.DelayBetweenIterations = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Animation.Animation DelayBetweenIterations(this Avalonia.Animation.Animation control, Func<System.TimeSpan> func)  
   => control._set(Avalonia.Animation.Animation.DelayBetweenIterationsProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Animation.Animation DelayBetweenIterations(this Avalonia.Animation.Animation control, IObservable<System.TimeSpan> obs)  
   => control._set(Avalonia.Animation.Animation.DelayBetweenIterationsProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Animation.Animation DelayBetweenIterations(this Avalonia.Animation.Animation control, ISubject<System.TimeSpan> subject)  
   => control._set(Avalonia.Animation.Animation.DelayBetweenIterationsProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Animation.Animation DelayBetweenIterations(this Avalonia.Animation.Animation control, IObservable<System.TimeSpan> obs, IObserver<System.TimeSpan> changed)  
   => control._setEx(Avalonia.Animation.Animation.DelayBetweenIterationsProperty!, obs, changed);


 // SpeedRatio

/*ValueSetterGenerator*/
public static Avalonia.Animation.Animation SpeedRatio(this Avalonia.Animation.Animation control, System.Double value)  
{
    control.SpeedRatio = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Animation.Animation SpeedRatio(this Avalonia.Animation.Animation control, Func<System.Double> func)  
   => control._set(Avalonia.Animation.Animation.SpeedRatioProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Animation.Animation SpeedRatio(this Avalonia.Animation.Animation control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Animation.Animation.SpeedRatioProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Animation.Animation SpeedRatio(this Avalonia.Animation.Animation control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Animation.Animation.SpeedRatioProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Animation.Animation SpeedRatio(this Avalonia.Animation.Animation control, IObservable<System.Double> obs, IObserver<System.Double> changed)  
   => control._setEx(Avalonia.Animation.Animation.SpeedRatioProperty!, obs, changed);



}

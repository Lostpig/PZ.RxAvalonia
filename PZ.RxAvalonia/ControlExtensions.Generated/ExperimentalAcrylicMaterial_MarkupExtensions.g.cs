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
public static partial class ExperimentalAcrylicMaterial_MarkupExtensions
{
//================= Properties ======================//
 // TintColor

/*ValueSetterGenerator*/
public static T TintColor<T>(this T control, Avalonia.Media.Color value) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
{
    control.TintColor = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TintColor<T>(this T control, Func<Avalonia.Media.Color> func) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.TintColorProperty!, func);

/*SetterFromObservableGenerator*/
public static T TintColor<T>(this T control, IObservable<Avalonia.Media.Color> obs) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.TintColorProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TintColor<T>(this T control, ISubject<Avalonia.Media.Color> subject) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.TintColorProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T TintColor<T>(this T control, IObservable<Avalonia.Media.Color> obs, IObserver<Avalonia.Media.Color> changed) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._setEx(Avalonia.Media.ExperimentalAcrylicMaterial.TintColorProperty!, obs, changed);


 // BackgroundSource

/*ValueSetterGenerator*/
public static T BackgroundSource<T>(this T control, Avalonia.Media.AcrylicBackgroundSource value) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
{
    control.BackgroundSource = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T BackgroundSource<T>(this T control, Func<Avalonia.Media.AcrylicBackgroundSource> func) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.BackgroundSourceProperty!, func);

/*SetterFromObservableGenerator*/
public static T BackgroundSource<T>(this T control, IObservable<Avalonia.Media.AcrylicBackgroundSource> obs) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.BackgroundSourceProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T BackgroundSource<T>(this T control, ISubject<Avalonia.Media.AcrylicBackgroundSource> subject) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.BackgroundSourceProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T BackgroundSource<T>(this T control, IObservable<Avalonia.Media.AcrylicBackgroundSource> obs, IObserver<Avalonia.Media.AcrylicBackgroundSource> changed) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._setEx(Avalonia.Media.ExperimentalAcrylicMaterial.BackgroundSourceProperty!, obs, changed);


 // TintOpacity

/*ValueSetterGenerator*/
public static T TintOpacity<T>(this T control, System.Double value) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
{
    control.TintOpacity = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TintOpacity<T>(this T control, Func<System.Double> func) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.TintOpacityProperty!, func);

/*SetterFromObservableGenerator*/
public static T TintOpacity<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.TintOpacityProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TintOpacity<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.TintOpacityProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T TintOpacity<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._setEx(Avalonia.Media.ExperimentalAcrylicMaterial.TintOpacityProperty!, obs, changed);


 // MaterialOpacity

/*ValueSetterGenerator*/
public static T MaterialOpacity<T>(this T control, System.Double value) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
{
    control.MaterialOpacity = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MaterialOpacity<T>(this T control, Func<System.Double> func) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.MaterialOpacityProperty!, func);

/*SetterFromObservableGenerator*/
public static T MaterialOpacity<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.MaterialOpacityProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MaterialOpacity<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.MaterialOpacityProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T MaterialOpacity<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._setEx(Avalonia.Media.ExperimentalAcrylicMaterial.MaterialOpacityProperty!, obs, changed);


 // PlatformTransparencyCompensationLevel

/*ValueSetterGenerator*/
public static T PlatformTransparencyCompensationLevel<T>(this T control, System.Double value) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
{
    control.PlatformTransparencyCompensationLevel = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PlatformTransparencyCompensationLevel<T>(this T control, Func<System.Double> func) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.PlatformTransparencyCompensationLevelProperty!, func);

/*SetterFromObservableGenerator*/
public static T PlatformTransparencyCompensationLevel<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.PlatformTransparencyCompensationLevelProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PlatformTransparencyCompensationLevel<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.PlatformTransparencyCompensationLevelProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T PlatformTransparencyCompensationLevel<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._setEx(Avalonia.Media.ExperimentalAcrylicMaterial.PlatformTransparencyCompensationLevelProperty!, obs, changed);


 // FallbackColor

/*ValueSetterGenerator*/
public static T FallbackColor<T>(this T control, Avalonia.Media.Color value) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
{
    control.FallbackColor = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FallbackColor<T>(this T control, Func<Avalonia.Media.Color> func) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.FallbackColorProperty!, func);

/*SetterFromObservableGenerator*/
public static T FallbackColor<T>(this T control, IObservable<Avalonia.Media.Color> obs) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.FallbackColorProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FallbackColor<T>(this T control, ISubject<Avalonia.Media.Color> subject) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(Avalonia.Media.ExperimentalAcrylicMaterial.FallbackColorProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T FallbackColor<T>(this T control, IObservable<Avalonia.Media.Color> obs, IObserver<Avalonia.Media.Color> changed) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._setEx(Avalonia.Media.ExperimentalAcrylicMaterial.FallbackColorProperty!, obs, changed);



//================= Events ======================//
 // Invalidated

/*ActionToEventGenerator*/
public static T OnInvalidated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Media.ExperimentalAcrylicMaterial  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Invalidated += h);

/*ReactiveEventGenerator*/
public static T RxInvalidated<T>(this T control, IObserver<System.EventArgs> observer) where T : Avalonia.Media.ExperimentalAcrylicMaterial  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => observer.OnNext((arg1))), h => control.Invalidated += h);



}

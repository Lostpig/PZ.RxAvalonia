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
public static partial class DropShadowEffectBase_MarkupExtensions
{
//================= Properties ======================//
 // BlurRadius

/*ValueSetterGenerator*/
public static T BlurRadius<T>(this T control, System.Double value) where T : Avalonia.Media.DropShadowEffectBase 
{
    control.BlurRadius = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T BlurRadius<T>(this T control, Func<System.Double> func) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.BlurRadiusProperty!, func);

/*SetterFromObservableGenerator*/
public static T BlurRadius<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.BlurRadiusProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T BlurRadius<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.BlurRadiusProperty!, subject);


 // Color

/*ValueSetterGenerator*/
public static T Color<T>(this T control, Avalonia.Media.Color value) where T : Avalonia.Media.DropShadowEffectBase 
{
    control.Color = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Color<T>(this T control, Func<Avalonia.Media.Color> func) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.ColorProperty!, func);

/*SetterFromObservableGenerator*/
public static T Color<T>(this T control, IObservable<Avalonia.Media.Color> obs) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.ColorProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Color<T>(this T control, ISubject<Avalonia.Media.Color> subject) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.ColorProperty!, subject);


 // Opacity

/*ValueSetterGenerator*/
public static T Opacity<T>(this T control, System.Double value) where T : Avalonia.Media.DropShadowEffectBase 
{
    control.Opacity = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Opacity<T>(this T control, Func<System.Double> func) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.OpacityProperty!, func);

/*SetterFromObservableGenerator*/
public static T Opacity<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.OpacityProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Opacity<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.OpacityProperty!, subject);



}

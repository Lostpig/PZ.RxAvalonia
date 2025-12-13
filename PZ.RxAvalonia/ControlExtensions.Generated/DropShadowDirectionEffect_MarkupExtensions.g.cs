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
public static partial class DropShadowDirectionEffect_MarkupExtensions
{
//================= Properties ======================//
 // ShadowDepth

/*ValueSetterGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect ShadowDepth(this Avalonia.Media.DropShadowDirectionEffect control, System.Double value)  
{
    control.ShadowDepth = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect ShadowDepth(this Avalonia.Media.DropShadowDirectionEffect control, Func<System.Double> func)  
   => control._set(Avalonia.Media.DropShadowDirectionEffect.ShadowDepthProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect ShadowDepth(this Avalonia.Media.DropShadowDirectionEffect control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Media.DropShadowDirectionEffect.ShadowDepthProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect ShadowDepth(this Avalonia.Media.DropShadowDirectionEffect control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Media.DropShadowDirectionEffect.ShadowDepthProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect ShadowDepth(this Avalonia.Media.DropShadowDirectionEffect control, IObservable<System.Double> obs, IObserver<System.Double> changed)  
   => control._setEx(Avalonia.Media.DropShadowDirectionEffect.ShadowDepthProperty!, obs, changed);


 // Direction

/*ValueSetterGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect Direction(this Avalonia.Media.DropShadowDirectionEffect control, System.Double value)  
{
    control.Direction = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect Direction(this Avalonia.Media.DropShadowDirectionEffect control, Func<System.Double> func)  
   => control._set(Avalonia.Media.DropShadowDirectionEffect.DirectionProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect Direction(this Avalonia.Media.DropShadowDirectionEffect control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Media.DropShadowDirectionEffect.DirectionProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect Direction(this Avalonia.Media.DropShadowDirectionEffect control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Media.DropShadowDirectionEffect.DirectionProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect Direction(this Avalonia.Media.DropShadowDirectionEffect control, IObservable<System.Double> obs, IObserver<System.Double> changed)  
   => control._setEx(Avalonia.Media.DropShadowDirectionEffect.DirectionProperty!, obs, changed);



}

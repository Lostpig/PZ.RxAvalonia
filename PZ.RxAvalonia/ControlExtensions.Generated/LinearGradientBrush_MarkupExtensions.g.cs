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
public static partial class LinearGradientBrush_MarkupExtensions
{
//================= Properties ======================//
 // StartPoint

/*ValueSetterGenerator*/
public static Avalonia.Media.LinearGradientBrush StartPoint(this Avalonia.Media.LinearGradientBrush control, Avalonia.RelativePoint value)  
{
    control.StartPoint = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Media.LinearGradientBrush StartPoint(this Avalonia.Media.LinearGradientBrush control, System.Double x = default!, System.Double y = default!, Avalonia.RelativeUnit unit = default!)  
{
    control.StartPoint = new Avalonia.RelativePoint(x, y, unit);
    return control;
}
public static Avalonia.Media.LinearGradientBrush StartPoint(this Avalonia.Media.LinearGradientBrush control, Avalonia.Point point = default!, Avalonia.RelativeUnit unit = default!)  
{
    control.StartPoint = new Avalonia.RelativePoint(point, unit);
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.LinearGradientBrush StartPoint(this Avalonia.Media.LinearGradientBrush control, Func<Avalonia.RelativePoint> func)  
   => control._set(Avalonia.Media.LinearGradientBrush.StartPointProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.LinearGradientBrush StartPoint(this Avalonia.Media.LinearGradientBrush control, IObservable<Avalonia.RelativePoint> obs)  
   => control._set(Avalonia.Media.LinearGradientBrush.StartPointProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.LinearGradientBrush StartPoint(this Avalonia.Media.LinearGradientBrush control, ISubject<Avalonia.RelativePoint> subject)  
   => control._set(Avalonia.Media.LinearGradientBrush.StartPointProperty!, subject);


 // EndPoint

/*ValueSetterGenerator*/
public static Avalonia.Media.LinearGradientBrush EndPoint(this Avalonia.Media.LinearGradientBrush control, Avalonia.RelativePoint value)  
{
    control.EndPoint = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Media.LinearGradientBrush EndPoint(this Avalonia.Media.LinearGradientBrush control, System.Double x = default!, System.Double y = default!, Avalonia.RelativeUnit unit = default!)  
{
    control.EndPoint = new Avalonia.RelativePoint(x, y, unit);
    return control;
}
public static Avalonia.Media.LinearGradientBrush EndPoint(this Avalonia.Media.LinearGradientBrush control, Avalonia.Point point = default!, Avalonia.RelativeUnit unit = default!)  
{
    control.EndPoint = new Avalonia.RelativePoint(point, unit);
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.LinearGradientBrush EndPoint(this Avalonia.Media.LinearGradientBrush control, Func<Avalonia.RelativePoint> func)  
   => control._set(Avalonia.Media.LinearGradientBrush.EndPointProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.LinearGradientBrush EndPoint(this Avalonia.Media.LinearGradientBrush control, IObservable<Avalonia.RelativePoint> obs)  
   => control._set(Avalonia.Media.LinearGradientBrush.EndPointProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.LinearGradientBrush EndPoint(this Avalonia.Media.LinearGradientBrush control, ISubject<Avalonia.RelativePoint> subject)  
   => control._set(Avalonia.Media.LinearGradientBrush.EndPointProperty!, subject);



}

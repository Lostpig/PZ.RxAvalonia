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
public static partial class ConicGradientBrush_MarkupExtensions
{
//================= Properties ======================//
 // Center

/*ValueSetterGenerator*/
public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, Avalonia.RelativePoint value)  
{
    control.Center = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, System.Double x = default!, System.Double y = default!, Avalonia.RelativeUnit unit = default!)  
{
    control.Center = new Avalonia.RelativePoint(x, y, unit);
    return control;
}
public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, Avalonia.Point point = default!, Avalonia.RelativeUnit unit = default!)  
{
    control.Center = new Avalonia.RelativePoint(point, unit);
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, Func<Avalonia.RelativePoint> func)  
   => control._set(Avalonia.Media.ConicGradientBrush.CenterProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, IObservable<Avalonia.RelativePoint> obs)  
   => control._set(Avalonia.Media.ConicGradientBrush.CenterProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, ISubject<Avalonia.RelativePoint> subject)  
   => control._set(Avalonia.Media.ConicGradientBrush.CenterProperty!, subject);


 // Angle

/*ValueSetterGenerator*/
public static Avalonia.Media.ConicGradientBrush Angle(this Avalonia.Media.ConicGradientBrush control, System.Double value)  
{
    control.Angle = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.ConicGradientBrush Angle(this Avalonia.Media.ConicGradientBrush control, Func<System.Double> func)  
   => control._set(Avalonia.Media.ConicGradientBrush.AngleProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.ConicGradientBrush Angle(this Avalonia.Media.ConicGradientBrush control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Media.ConicGradientBrush.AngleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.ConicGradientBrush Angle(this Avalonia.Media.ConicGradientBrush control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Media.ConicGradientBrush.AngleProperty!, subject);



}

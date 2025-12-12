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
public static partial class Pen_MarkupExtensions
{
//================= Properties ======================//
 // Brush

/*ValueSetterGenerator*/
public static Avalonia.Media.Pen Brush(this Avalonia.Media.Pen control, Avalonia.Media.IBrush value)  
{
    control.Brush = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.Pen Brush(this Avalonia.Media.Pen control, Func<Avalonia.Media.IBrush> func)  
   => control._set(Avalonia.Media.Pen.BrushProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.Pen Brush(this Avalonia.Media.Pen control, IObservable<Avalonia.Media.IBrush> obs)  
   => control._set(Avalonia.Media.Pen.BrushProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.Pen Brush(this Avalonia.Media.Pen control, ISubject<Avalonia.Media.IBrush> subject)  
   => control._set(Avalonia.Media.Pen.BrushProperty!, subject);


 // Thickness

/*ValueSetterGenerator*/
public static Avalonia.Media.Pen Thickness(this Avalonia.Media.Pen control, System.Double value)  
{
    control.Thickness = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.Pen Thickness(this Avalonia.Media.Pen control, Func<System.Double> func)  
   => control._set(Avalonia.Media.Pen.ThicknessProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.Pen Thickness(this Avalonia.Media.Pen control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Media.Pen.ThicknessProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.Pen Thickness(this Avalonia.Media.Pen control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Media.Pen.ThicknessProperty!, subject);


 // DashStyle

/*ValueSetterGenerator*/
public static Avalonia.Media.Pen DashStyle(this Avalonia.Media.Pen control, Avalonia.Media.IDashStyle value)  
{
    control.DashStyle = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.Pen DashStyle(this Avalonia.Media.Pen control, Func<Avalonia.Media.IDashStyle> func)  
   => control._set(Avalonia.Media.Pen.DashStyleProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.Pen DashStyle(this Avalonia.Media.Pen control, IObservable<Avalonia.Media.IDashStyle> obs)  
   => control._set(Avalonia.Media.Pen.DashStyleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.Pen DashStyle(this Avalonia.Media.Pen control, ISubject<Avalonia.Media.IDashStyle> subject)  
   => control._set(Avalonia.Media.Pen.DashStyleProperty!, subject);


 // LineCap

/*ValueSetterGenerator*/
public static Avalonia.Media.Pen LineCap(this Avalonia.Media.Pen control, Avalonia.Media.PenLineCap value)  
{
    control.LineCap = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.Pen LineCap(this Avalonia.Media.Pen control, Func<Avalonia.Media.PenLineCap> func)  
   => control._set(Avalonia.Media.Pen.LineCapProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.Pen LineCap(this Avalonia.Media.Pen control, IObservable<Avalonia.Media.PenLineCap> obs)  
   => control._set(Avalonia.Media.Pen.LineCapProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.Pen LineCap(this Avalonia.Media.Pen control, ISubject<Avalonia.Media.PenLineCap> subject)  
   => control._set(Avalonia.Media.Pen.LineCapProperty!, subject);


 // LineJoin

/*ValueSetterGenerator*/
public static Avalonia.Media.Pen LineJoin(this Avalonia.Media.Pen control, Avalonia.Media.PenLineJoin value)  
{
    control.LineJoin = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.Pen LineJoin(this Avalonia.Media.Pen control, Func<Avalonia.Media.PenLineJoin> func)  
   => control._set(Avalonia.Media.Pen.LineJoinProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.Pen LineJoin(this Avalonia.Media.Pen control, IObservable<Avalonia.Media.PenLineJoin> obs)  
   => control._set(Avalonia.Media.Pen.LineJoinProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.Pen LineJoin(this Avalonia.Media.Pen control, ISubject<Avalonia.Media.PenLineJoin> subject)  
   => control._set(Avalonia.Media.Pen.LineJoinProperty!, subject);


 // MiterLimit

/*ValueSetterGenerator*/
public static Avalonia.Media.Pen MiterLimit(this Avalonia.Media.Pen control, System.Double value)  
{
    control.MiterLimit = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.Pen MiterLimit(this Avalonia.Media.Pen control, Func<System.Double> func)  
   => control._set(Avalonia.Media.Pen.MiterLimitProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.Pen MiterLimit(this Avalonia.Media.Pen control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Media.Pen.MiterLimitProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.Pen MiterLimit(this Avalonia.Media.Pen control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Media.Pen.MiterLimitProperty!, subject);



}

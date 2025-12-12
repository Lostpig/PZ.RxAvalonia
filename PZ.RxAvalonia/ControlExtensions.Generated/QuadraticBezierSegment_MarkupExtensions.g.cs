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
public static partial class QuadraticBezierSegment_MarkupExtensions
{
//================= Properties ======================//
 // Point1

/*ValueSetterGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point1(this Avalonia.Media.QuadraticBezierSegment control, Avalonia.Point value)  
{
    control.Point1 = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point1(this Avalonia.Media.QuadraticBezierSegment control, Func<Avalonia.Point> func)  
   => control._set(Avalonia.Media.QuadraticBezierSegment.Point1Property!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point1(this Avalonia.Media.QuadraticBezierSegment control, IObservable<Avalonia.Point> obs)  
   => control._set(Avalonia.Media.QuadraticBezierSegment.Point1Property!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point1(this Avalonia.Media.QuadraticBezierSegment control, ISubject<Avalonia.Point> subject)  
   => control._set(Avalonia.Media.QuadraticBezierSegment.Point1Property!, subject);


 // Point2

/*ValueSetterGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point2(this Avalonia.Media.QuadraticBezierSegment control, Avalonia.Point value)  
{
    control.Point2 = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point2(this Avalonia.Media.QuadraticBezierSegment control, Func<Avalonia.Point> func)  
   => control._set(Avalonia.Media.QuadraticBezierSegment.Point2Property!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point2(this Avalonia.Media.QuadraticBezierSegment control, IObservable<Avalonia.Point> obs)  
   => control._set(Avalonia.Media.QuadraticBezierSegment.Point2Property!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point2(this Avalonia.Media.QuadraticBezierSegment control, ISubject<Avalonia.Point> subject)  
   => control._set(Avalonia.Media.QuadraticBezierSegment.Point2Property!, subject);



}

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
public static partial class BezierSegment_MarkupExtensions
{
//================= Properties ======================//
 // Point1

/*ValueSetterGenerator*/
public static Avalonia.Media.BezierSegment Point1(this Avalonia.Media.BezierSegment control, Avalonia.Point value)  
{
    control.Point1 = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.BezierSegment Point1(this Avalonia.Media.BezierSegment control, Func<Avalonia.Point> func)  
   => control._set(Avalonia.Media.BezierSegment.Point1Property!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.BezierSegment Point1(this Avalonia.Media.BezierSegment control, IObservable<Avalonia.Point> obs)  
   => control._set(Avalonia.Media.BezierSegment.Point1Property!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.BezierSegment Point1(this Avalonia.Media.BezierSegment control, ISubject<Avalonia.Point> subject)  
   => control._set(Avalonia.Media.BezierSegment.Point1Property!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.BezierSegment Point1(this Avalonia.Media.BezierSegment control, IObservable<Avalonia.Point> obs, IObserver<Avalonia.Point> changed)  
   => control._setEx(Avalonia.Media.BezierSegment.Point1Property!, obs, changed);


 // Point2

/*ValueSetterGenerator*/
public static Avalonia.Media.BezierSegment Point2(this Avalonia.Media.BezierSegment control, Avalonia.Point value)  
{
    control.Point2 = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.BezierSegment Point2(this Avalonia.Media.BezierSegment control, Func<Avalonia.Point> func)  
   => control._set(Avalonia.Media.BezierSegment.Point2Property!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.BezierSegment Point2(this Avalonia.Media.BezierSegment control, IObservable<Avalonia.Point> obs)  
   => control._set(Avalonia.Media.BezierSegment.Point2Property!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.BezierSegment Point2(this Avalonia.Media.BezierSegment control, ISubject<Avalonia.Point> subject)  
   => control._set(Avalonia.Media.BezierSegment.Point2Property!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.BezierSegment Point2(this Avalonia.Media.BezierSegment control, IObservable<Avalonia.Point> obs, IObserver<Avalonia.Point> changed)  
   => control._setEx(Avalonia.Media.BezierSegment.Point2Property!, obs, changed);


 // Point3

/*ValueSetterGenerator*/
public static Avalonia.Media.BezierSegment Point3(this Avalonia.Media.BezierSegment control, Avalonia.Point value)  
{
    control.Point3 = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.BezierSegment Point3(this Avalonia.Media.BezierSegment control, Func<Avalonia.Point> func)  
   => control._set(Avalonia.Media.BezierSegment.Point3Property!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.BezierSegment Point3(this Avalonia.Media.BezierSegment control, IObservable<Avalonia.Point> obs)  
   => control._set(Avalonia.Media.BezierSegment.Point3Property!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.BezierSegment Point3(this Avalonia.Media.BezierSegment control, ISubject<Avalonia.Point> subject)  
   => control._set(Avalonia.Media.BezierSegment.Point3Property!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.BezierSegment Point3(this Avalonia.Media.BezierSegment control, IObservable<Avalonia.Point> obs, IObserver<Avalonia.Point> changed)  
   => control._setEx(Avalonia.Media.BezierSegment.Point3Property!, obs, changed);



}

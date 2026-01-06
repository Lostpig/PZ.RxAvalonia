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
public static partial class PathFigure_MarkupExtensions
{
//================= Properties ======================//
 // IsClosed

/*ValueSetterGenerator*/
public static Avalonia.Media.PathFigure IsClosed(this Avalonia.Media.PathFigure control, System.Boolean value)  
{
    control.IsClosed = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.PathFigure IsClosed(this Avalonia.Media.PathFigure control, Func<System.Boolean> func)  
   => control._set(Avalonia.Media.PathFigure.IsClosedProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.PathFigure IsClosed(this Avalonia.Media.PathFigure control, IObservable<System.Boolean> obs)  
   => control._set(Avalonia.Media.PathFigure.IsClosedProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.PathFigure IsClosed(this Avalonia.Media.PathFigure control, ISubject<System.Boolean> subject)  
   => control._set(Avalonia.Media.PathFigure.IsClosedProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.PathFigure IsClosed(this Avalonia.Media.PathFigure control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed)  
   => control._setEx(Avalonia.Media.PathFigure.IsClosedProperty!, obs, changed);


 // IsFilled

/*ValueSetterGenerator*/
public static Avalonia.Media.PathFigure IsFilled(this Avalonia.Media.PathFigure control, System.Boolean value)  
{
    control.IsFilled = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.PathFigure IsFilled(this Avalonia.Media.PathFigure control, Func<System.Boolean> func)  
   => control._set(Avalonia.Media.PathFigure.IsFilledProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.PathFigure IsFilled(this Avalonia.Media.PathFigure control, IObservable<System.Boolean> obs)  
   => control._set(Avalonia.Media.PathFigure.IsFilledProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.PathFigure IsFilled(this Avalonia.Media.PathFigure control, ISubject<System.Boolean> subject)  
   => control._set(Avalonia.Media.PathFigure.IsFilledProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.PathFigure IsFilled(this Avalonia.Media.PathFigure control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed)  
   => control._setEx(Avalonia.Media.PathFigure.IsFilledProperty!, obs, changed);


 // Segments

/*ValueSetterGenerator*/
public static Avalonia.Media.PathFigure Segments(this Avalonia.Media.PathFigure control, Avalonia.Media.PathSegments? value)  
{
    control.Segments = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.PathFigure Segments(this Avalonia.Media.PathFigure control, Func<Avalonia.Media.PathSegments?> func)  
   => control._set(Avalonia.Media.PathFigure.SegmentsProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.PathFigure Segments(this Avalonia.Media.PathFigure control, IObservable<Avalonia.Media.PathSegments?> obs)  
   => control._set(Avalonia.Media.PathFigure.SegmentsProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.PathFigure Segments(this Avalonia.Media.PathFigure control, ISubject<Avalonia.Media.PathSegments?> subject)  
   => control._set(Avalonia.Media.PathFigure.SegmentsProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.PathFigure Segments(this Avalonia.Media.PathFigure control, IObservable<Avalonia.Media.PathSegments?> obs, IObserver<Avalonia.Media.PathSegments?> changed)  
   => control._setEx(Avalonia.Media.PathFigure.SegmentsProperty!, obs, changed);


 // StartPoint

/*ValueSetterGenerator*/
public static Avalonia.Media.PathFigure StartPoint(this Avalonia.Media.PathFigure control, Avalonia.Point value)  
{
    control.StartPoint = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.PathFigure StartPoint(this Avalonia.Media.PathFigure control, Func<Avalonia.Point> func)  
   => control._set(Avalonia.Media.PathFigure.StartPointProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.PathFigure StartPoint(this Avalonia.Media.PathFigure control, IObservable<Avalonia.Point> obs)  
   => control._set(Avalonia.Media.PathFigure.StartPointProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.PathFigure StartPoint(this Avalonia.Media.PathFigure control, ISubject<Avalonia.Point> subject)  
   => control._set(Avalonia.Media.PathFigure.StartPointProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.PathFigure StartPoint(this Avalonia.Media.PathFigure control, IObservable<Avalonia.Point> obs, IObserver<Avalonia.Point> changed)  
   => control._setEx(Avalonia.Media.PathFigure.StartPointProperty!, obs, changed);



}

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
public static partial class LineSegment_MarkupExtensions
{
//================= Properties ======================//
 // Point

/*ValueSetterGenerator*/
public static Avalonia.Media.LineSegment Point(this Avalonia.Media.LineSegment control, Avalonia.Point value)  
{
    control.Point = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.LineSegment Point(this Avalonia.Media.LineSegment control, Func<Avalonia.Point> func)  
   => control._set(Avalonia.Media.LineSegment.PointProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.LineSegment Point(this Avalonia.Media.LineSegment control, IObservable<Avalonia.Point> obs)  
   => control._set(Avalonia.Media.LineSegment.PointProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.LineSegment Point(this Avalonia.Media.LineSegment control, ISubject<Avalonia.Point> subject)  
   => control._set(Avalonia.Media.LineSegment.PointProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.LineSegment Point(this Avalonia.Media.LineSegment control, IObservable<Avalonia.Point> obs, IObserver<Avalonia.Point> changed)  
   => control._setEx(Avalonia.Media.LineSegment.PointProperty!, obs, changed);



}

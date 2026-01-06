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
public static partial class PolyBezierSegment_MarkupExtensions
{
//================= Properties ======================//
 // Points

/*ValueSetterGenerator*/
public static Avalonia.Media.PolyBezierSegment Points(this Avalonia.Media.PolyBezierSegment control, Avalonia.Points? value)  
{
    control.Points = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.PolyBezierSegment Points(this Avalonia.Media.PolyBezierSegment control, Func<Avalonia.Points?> func)  
   => control._set(Avalonia.Media.PolyBezierSegment.PointsProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.PolyBezierSegment Points(this Avalonia.Media.PolyBezierSegment control, IObservable<Avalonia.Points?> obs)  
   => control._set(Avalonia.Media.PolyBezierSegment.PointsProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.PolyBezierSegment Points(this Avalonia.Media.PolyBezierSegment control, ISubject<Avalonia.Points?> subject)  
   => control._set(Avalonia.Media.PolyBezierSegment.PointsProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.PolyBezierSegment Points(this Avalonia.Media.PolyBezierSegment control, IObservable<Avalonia.Points?> obs, IObserver<Avalonia.Points?> changed)  
   => control._setEx(Avalonia.Media.PolyBezierSegment.PointsProperty!, obs, changed);



}

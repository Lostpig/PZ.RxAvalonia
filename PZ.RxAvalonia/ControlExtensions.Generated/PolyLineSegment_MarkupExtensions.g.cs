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
public static partial class PolyLineSegment_MarkupExtensions
{
//================= Properties ======================//
 // Points

/*ValueSetterGenerator*/
public static Avalonia.Media.PolyLineSegment Points(this Avalonia.Media.PolyLineSegment control, System.Collections.Generic.IList<Avalonia.Point> value)  
{
    control.Points = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.PolyLineSegment Points(this Avalonia.Media.PolyLineSegment control, Func<System.Collections.Generic.IList<Avalonia.Point>> func)  
   => control._set(Avalonia.Media.PolyLineSegment.PointsProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.PolyLineSegment Points(this Avalonia.Media.PolyLineSegment control, IObservable<System.Collections.Generic.IList<Avalonia.Point>> obs)  
   => control._set(Avalonia.Media.PolyLineSegment.PointsProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.PolyLineSegment Points(this Avalonia.Media.PolyLineSegment control, ISubject<System.Collections.Generic.IList<Avalonia.Point>> subject)  
   => control._set(Avalonia.Media.PolyLineSegment.PointsProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.PolyLineSegment Points(this Avalonia.Media.PolyLineSegment control, IObservable<System.Collections.Generic.IList<Avalonia.Point>> obs, IObserver<System.Collections.Generic.IList<Avalonia.Point>> changed)  
   => control._setEx(Avalonia.Media.PolyLineSegment.PointsProperty!, obs, changed);



}

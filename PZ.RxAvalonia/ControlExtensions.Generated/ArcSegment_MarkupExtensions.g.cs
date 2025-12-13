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
public static partial class ArcSegment_MarkupExtensions
{
//================= Properties ======================//
 // IsLargeArc

/*ValueSetterGenerator*/
public static Avalonia.Media.ArcSegment IsLargeArc(this Avalonia.Media.ArcSegment control, System.Boolean value)  
{
    control.IsLargeArc = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.ArcSegment IsLargeArc(this Avalonia.Media.ArcSegment control, Func<System.Boolean> func)  
   => control._set(Avalonia.Media.ArcSegment.IsLargeArcProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.ArcSegment IsLargeArc(this Avalonia.Media.ArcSegment control, IObservable<System.Boolean> obs)  
   => control._set(Avalonia.Media.ArcSegment.IsLargeArcProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.ArcSegment IsLargeArc(this Avalonia.Media.ArcSegment control, ISubject<System.Boolean> subject)  
   => control._set(Avalonia.Media.ArcSegment.IsLargeArcProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.ArcSegment IsLargeArc(this Avalonia.Media.ArcSegment control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed)  
   => control._setEx(Avalonia.Media.ArcSegment.IsLargeArcProperty!, obs, changed);


 // Point

/*ValueSetterGenerator*/
public static Avalonia.Media.ArcSegment Point(this Avalonia.Media.ArcSegment control, Avalonia.Point value)  
{
    control.Point = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.ArcSegment Point(this Avalonia.Media.ArcSegment control, Func<Avalonia.Point> func)  
   => control._set(Avalonia.Media.ArcSegment.PointProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.ArcSegment Point(this Avalonia.Media.ArcSegment control, IObservable<Avalonia.Point> obs)  
   => control._set(Avalonia.Media.ArcSegment.PointProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.ArcSegment Point(this Avalonia.Media.ArcSegment control, ISubject<Avalonia.Point> subject)  
   => control._set(Avalonia.Media.ArcSegment.PointProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.ArcSegment Point(this Avalonia.Media.ArcSegment control, IObservable<Avalonia.Point> obs, IObserver<Avalonia.Point> changed)  
   => control._setEx(Avalonia.Media.ArcSegment.PointProperty!, obs, changed);


 // RotationAngle

/*ValueSetterGenerator*/
public static Avalonia.Media.ArcSegment RotationAngle(this Avalonia.Media.ArcSegment control, System.Double value)  
{
    control.RotationAngle = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.ArcSegment RotationAngle(this Avalonia.Media.ArcSegment control, Func<System.Double> func)  
   => control._set(Avalonia.Media.ArcSegment.RotationAngleProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.ArcSegment RotationAngle(this Avalonia.Media.ArcSegment control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Media.ArcSegment.RotationAngleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.ArcSegment RotationAngle(this Avalonia.Media.ArcSegment control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Media.ArcSegment.RotationAngleProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.ArcSegment RotationAngle(this Avalonia.Media.ArcSegment control, IObservable<System.Double> obs, IObserver<System.Double> changed)  
   => control._setEx(Avalonia.Media.ArcSegment.RotationAngleProperty!, obs, changed);


 // Size

/*ValueSetterGenerator*/
public static Avalonia.Media.ArcSegment Size(this Avalonia.Media.ArcSegment control, Avalonia.Size value)  
{
    control.Size = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Media.ArcSegment Size(this Avalonia.Media.ArcSegment control, System.Double width = default!, System.Double height = default!)  
{
    control.Size = new Avalonia.Size(width, height);
    return control;
}
public static Avalonia.Media.ArcSegment Size(this Avalonia.Media.ArcSegment control, System.Numerics.Vector2 vector2 = default!)  
{
    control.Size = new Avalonia.Size(vector2);
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.ArcSegment Size(this Avalonia.Media.ArcSegment control, Func<Avalonia.Size> func)  
   => control._set(Avalonia.Media.ArcSegment.SizeProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.ArcSegment Size(this Avalonia.Media.ArcSegment control, IObservable<Avalonia.Size> obs)  
   => control._set(Avalonia.Media.ArcSegment.SizeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.ArcSegment Size(this Avalonia.Media.ArcSegment control, ISubject<Avalonia.Size> subject)  
   => control._set(Avalonia.Media.ArcSegment.SizeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.ArcSegment Size(this Avalonia.Media.ArcSegment control, IObservable<Avalonia.Size> obs, IObserver<Avalonia.Size> changed)  
   => control._setEx(Avalonia.Media.ArcSegment.SizeProperty!, obs, changed);


 // SweepDirection

/*ValueSetterGenerator*/
public static Avalonia.Media.ArcSegment SweepDirection(this Avalonia.Media.ArcSegment control, Avalonia.Media.SweepDirection value)  
{
    control.SweepDirection = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.ArcSegment SweepDirection(this Avalonia.Media.ArcSegment control, Func<Avalonia.Media.SweepDirection> func)  
   => control._set(Avalonia.Media.ArcSegment.SweepDirectionProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.ArcSegment SweepDirection(this Avalonia.Media.ArcSegment control, IObservable<Avalonia.Media.SweepDirection> obs)  
   => control._set(Avalonia.Media.ArcSegment.SweepDirectionProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.ArcSegment SweepDirection(this Avalonia.Media.ArcSegment control, ISubject<Avalonia.Media.SweepDirection> subject)  
   => control._set(Avalonia.Media.ArcSegment.SweepDirectionProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.ArcSegment SweepDirection(this Avalonia.Media.ArcSegment control, IObservable<Avalonia.Media.SweepDirection> obs, IObserver<Avalonia.Media.SweepDirection> changed)  
   => control._setEx(Avalonia.Media.ArcSegment.SweepDirectionProperty!, obs, changed);



}

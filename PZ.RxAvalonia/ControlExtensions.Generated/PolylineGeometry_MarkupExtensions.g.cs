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
public static partial class PolylineGeometry_MarkupExtensions
{
//================= Properties ======================//
 // Points

/*ValueSetterGenerator*/
public static T Points<T>(this T control, System.Collections.Generic.IList<Avalonia.Point> value) where T : Avalonia.Media.PolylineGeometry 
{
    control.Points = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Points<T>(this T control, Func<System.Collections.Generic.IList<Avalonia.Point>> func) where T : Avalonia.Media.PolylineGeometry 
   => control._set(Avalonia.Media.PolylineGeometry.PointsProperty!, func);

/*SetterFromObservableGenerator*/
public static T Points<T>(this T control, IObservable<System.Collections.Generic.IList<Avalonia.Point>> obs) where T : Avalonia.Media.PolylineGeometry 
   => control._set(Avalonia.Media.PolylineGeometry.PointsProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Points<T>(this T control, ISubject<System.Collections.Generic.IList<Avalonia.Point>> subject) where T : Avalonia.Media.PolylineGeometry 
   => control._set(Avalonia.Media.PolylineGeometry.PointsProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Points<T>(this T control, IObservable<System.Collections.Generic.IList<Avalonia.Point>> obs, IObserver<System.Collections.Generic.IList<Avalonia.Point>> changed) where T : Avalonia.Media.PolylineGeometry 
   => control._setEx(Avalonia.Media.PolylineGeometry.PointsProperty!, obs, changed);


 // IsFilled

/*ValueSetterGenerator*/
public static T IsFilled<T>(this T control, System.Boolean value) where T : Avalonia.Media.PolylineGeometry 
{
    control.IsFilled = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsFilled<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Media.PolylineGeometry 
   => control._set(Avalonia.Media.PolylineGeometry.IsFilledProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsFilled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Media.PolylineGeometry 
   => control._set(Avalonia.Media.PolylineGeometry.IsFilledProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsFilled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Media.PolylineGeometry 
   => control._set(Avalonia.Media.PolylineGeometry.IsFilledProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsFilled<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Media.PolylineGeometry 
   => control._setEx(Avalonia.Media.PolylineGeometry.IsFilledProperty!, obs, changed);



}

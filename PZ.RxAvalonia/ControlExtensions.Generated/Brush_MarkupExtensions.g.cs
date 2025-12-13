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
public static partial class Brush_MarkupExtensions
{
//================= Properties ======================//
 // Opacity

/*ValueSetterGenerator*/
public static T Opacity<T>(this T control, System.Double value) where T : Avalonia.Media.Brush 
{
    control.Opacity = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Opacity<T>(this T control, Func<System.Double> func) where T : Avalonia.Media.Brush 
   => control._set(Avalonia.Media.Brush.OpacityProperty!, func);

/*SetterFromObservableGenerator*/
public static T Opacity<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Media.Brush 
   => control._set(Avalonia.Media.Brush.OpacityProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Opacity<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Media.Brush 
   => control._set(Avalonia.Media.Brush.OpacityProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Opacity<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Media.Brush 
   => control._setEx(Avalonia.Media.Brush.OpacityProperty!, obs, changed);


 // Transform

/*ValueSetterGenerator*/
public static T Transform<T>(this T control, Avalonia.Media.ITransform value) where T : Avalonia.Media.Brush 
{
    control.Transform = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Transform<T>(this T control, Func<Avalonia.Media.ITransform> func) where T : Avalonia.Media.Brush 
   => control._set(Avalonia.Media.Brush.TransformProperty!, func);

/*SetterFromObservableGenerator*/
public static T Transform<T>(this T control, IObservable<Avalonia.Media.ITransform> obs) where T : Avalonia.Media.Brush 
   => control._set(Avalonia.Media.Brush.TransformProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Transform<T>(this T control, ISubject<Avalonia.Media.ITransform> subject) where T : Avalonia.Media.Brush 
   => control._set(Avalonia.Media.Brush.TransformProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Transform<T>(this T control, IObservable<Avalonia.Media.ITransform> obs, IObserver<Avalonia.Media.ITransform> changed) where T : Avalonia.Media.Brush 
   => control._setEx(Avalonia.Media.Brush.TransformProperty!, obs, changed);


 // TransformOrigin

/*ValueSetterGenerator*/
public static T TransformOrigin<T>(this T control, Avalonia.RelativePoint value) where T : Avalonia.Media.Brush 
{
    control.TransformOrigin = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static T TransformOrigin<T>(this T control, System.Double x = default!, System.Double y = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.Brush 
{
    control.TransformOrigin = new Avalonia.RelativePoint(x, y, unit);
    return control;
}
public static T TransformOrigin<T>(this T control, Avalonia.Point point = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.Brush 
{
    control.TransformOrigin = new Avalonia.RelativePoint(point, unit);
    return control;
}

/*SetterFromFuncGenerator*/
public static T TransformOrigin<T>(this T control, Func<Avalonia.RelativePoint> func) where T : Avalonia.Media.Brush 
   => control._set(Avalonia.Media.Brush.TransformOriginProperty!, func);

/*SetterFromObservableGenerator*/
public static T TransformOrigin<T>(this T control, IObservable<Avalonia.RelativePoint> obs) where T : Avalonia.Media.Brush 
   => control._set(Avalonia.Media.Brush.TransformOriginProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TransformOrigin<T>(this T control, ISubject<Avalonia.RelativePoint> subject) where T : Avalonia.Media.Brush 
   => control._set(Avalonia.Media.Brush.TransformOriginProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T TransformOrigin<T>(this T control, IObservable<Avalonia.RelativePoint> obs, IObserver<Avalonia.RelativePoint> changed) where T : Avalonia.Media.Brush 
   => control._setEx(Avalonia.Media.Brush.TransformOriginProperty!, obs, changed);



}

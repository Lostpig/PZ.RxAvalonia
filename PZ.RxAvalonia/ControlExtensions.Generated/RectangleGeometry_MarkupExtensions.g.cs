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
public static partial class RectangleGeometry_MarkupExtensions
{
//================= Properties ======================//
 // RadiusX

/*ValueSetterGenerator*/
public static T RadiusX<T>(this T control, System.Double value) where T : Avalonia.Media.RectangleGeometry 
{
    control.RadiusX = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T RadiusX<T>(this T control, Func<System.Double> func) where T : Avalonia.Media.RectangleGeometry 
   => control._set(Avalonia.Media.RectangleGeometry.RadiusXProperty!, func);

/*SetterFromObservableGenerator*/
public static T RadiusX<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Media.RectangleGeometry 
   => control._set(Avalonia.Media.RectangleGeometry.RadiusXProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T RadiusX<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Media.RectangleGeometry 
   => control._set(Avalonia.Media.RectangleGeometry.RadiusXProperty!, subject);


 // RadiusY

/*ValueSetterGenerator*/
public static T RadiusY<T>(this T control, System.Double value) where T : Avalonia.Media.RectangleGeometry 
{
    control.RadiusY = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T RadiusY<T>(this T control, Func<System.Double> func) where T : Avalonia.Media.RectangleGeometry 
   => control._set(Avalonia.Media.RectangleGeometry.RadiusYProperty!, func);

/*SetterFromObservableGenerator*/
public static T RadiusY<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Media.RectangleGeometry 
   => control._set(Avalonia.Media.RectangleGeometry.RadiusYProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T RadiusY<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Media.RectangleGeometry 
   => control._set(Avalonia.Media.RectangleGeometry.RadiusYProperty!, subject);


 // Rect

/*ValueSetterGenerator*/
public static T Rect<T>(this T control, Avalonia.Rect value) where T : Avalonia.Media.RectangleGeometry 
{
    control.Rect = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static T Rect<T>(this T control, System.Double x = default!, System.Double y = default!, System.Double width = default!, System.Double height = default!) where T : Avalonia.Media.RectangleGeometry 
{
    control.Rect = new Avalonia.Rect(x, y, width, height);
    return control;
}
public static T Rect<T>(this T control, Avalonia.Size size = default!) where T : Avalonia.Media.RectangleGeometry 
{
    control.Rect = new Avalonia.Rect(size);
    return control;
}
public static T Rect<T>(this T control, Avalonia.Point position = default!, Avalonia.Size size = default!) where T : Avalonia.Media.RectangleGeometry 
{
    control.Rect = new Avalonia.Rect(position, size);
    return control;
}
public static T Rect<T>(this T control, Avalonia.Point topLeft = default!, Avalonia.Point bottomRight = default!) where T : Avalonia.Media.RectangleGeometry 
{
    control.Rect = new Avalonia.Rect(topLeft, bottomRight);
    return control;
}

/*SetterFromFuncGenerator*/
public static T Rect<T>(this T control, Func<Avalonia.Rect> func) where T : Avalonia.Media.RectangleGeometry 
   => control._set(Avalonia.Media.RectangleGeometry.RectProperty!, func);

/*SetterFromObservableGenerator*/
public static T Rect<T>(this T control, IObservable<Avalonia.Rect> obs) where T : Avalonia.Media.RectangleGeometry 
   => control._set(Avalonia.Media.RectangleGeometry.RectProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Rect<T>(this T control, ISubject<Avalonia.Rect> subject) where T : Avalonia.Media.RectangleGeometry 
   => control._set(Avalonia.Media.RectangleGeometry.RectProperty!, subject);



}

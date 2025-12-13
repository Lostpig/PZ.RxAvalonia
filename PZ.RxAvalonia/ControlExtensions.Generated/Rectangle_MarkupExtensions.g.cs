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
public static partial class Rectangle_MarkupExtensions
{
//================= Properties ======================//
 // RadiusX

/*ValueSetterGenerator*/
public static T RadiusX<T>(this T control, System.Double value) where T : Avalonia.Controls.Shapes.Rectangle 
{
    control.RadiusX = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T RadiusX<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Shapes.Rectangle 
   => control._set(Avalonia.Controls.Shapes.Rectangle.RadiusXProperty!, func);

/*SetterFromObservableGenerator*/
public static T RadiusX<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Shapes.Rectangle 
   => control._set(Avalonia.Controls.Shapes.Rectangle.RadiusXProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T RadiusX<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Shapes.Rectangle 
   => control._set(Avalonia.Controls.Shapes.Rectangle.RadiusXProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T RadiusX<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.Shapes.Rectangle 
   => control._setEx(Avalonia.Controls.Shapes.Rectangle.RadiusXProperty!, obs, changed);


 // RadiusY

/*ValueSetterGenerator*/
public static T RadiusY<T>(this T control, System.Double value) where T : Avalonia.Controls.Shapes.Rectangle 
{
    control.RadiusY = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T RadiusY<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Shapes.Rectangle 
   => control._set(Avalonia.Controls.Shapes.Rectangle.RadiusYProperty!, func);

/*SetterFromObservableGenerator*/
public static T RadiusY<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Shapes.Rectangle 
   => control._set(Avalonia.Controls.Shapes.Rectangle.RadiusYProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T RadiusY<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Shapes.Rectangle 
   => control._set(Avalonia.Controls.Shapes.Rectangle.RadiusYProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T RadiusY<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.Shapes.Rectangle 
   => control._setEx(Avalonia.Controls.Shapes.Rectangle.RadiusYProperty!, obs, changed);



//================= Styles ======================//
 // RadiusX

/*ValueStyleSetterGenerator*/
public static Style<T> RadiusX<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Rectangle 
=> style._addSetter(Avalonia.Controls.Shapes.Rectangle.RadiusXProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RadiusX<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Rectangle 
=> style._addSetter(Avalonia.Controls.Shapes.Rectangle.RadiusXProperty, binding);


 // RadiusY

/*ValueStyleSetterGenerator*/
public static Style<T> RadiusY<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Rectangle 
=> style._addSetter(Avalonia.Controls.Shapes.Rectangle.RadiusYProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RadiusY<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Rectangle 
=> style._addSetter(Avalonia.Controls.Shapes.Rectangle.RadiusYProperty, binding);



}

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
public static partial class Arc_MarkupExtensions
{
//================= Properties ======================//
 // StartAngle

/*ValueSetterGenerator*/
public static T StartAngle<T>(this T control, System.Double value) where T : Avalonia.Controls.Shapes.Arc 
{
    control.StartAngle = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T StartAngle<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Shapes.Arc 
   => control._set(Avalonia.Controls.Shapes.Arc.StartAngleProperty!, func);

/*SetterFromObservableGenerator*/
public static T StartAngle<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Shapes.Arc 
   => control._set(Avalonia.Controls.Shapes.Arc.StartAngleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T StartAngle<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Shapes.Arc 
   => control._set(Avalonia.Controls.Shapes.Arc.StartAngleProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T StartAngle<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.Shapes.Arc 
   => control._setEx(Avalonia.Controls.Shapes.Arc.StartAngleProperty!, obs, changed);


 // SweepAngle

/*ValueSetterGenerator*/
public static T SweepAngle<T>(this T control, System.Double value) where T : Avalonia.Controls.Shapes.Arc 
{
    control.SweepAngle = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SweepAngle<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Shapes.Arc 
   => control._set(Avalonia.Controls.Shapes.Arc.SweepAngleProperty!, func);

/*SetterFromObservableGenerator*/
public static T SweepAngle<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Shapes.Arc 
   => control._set(Avalonia.Controls.Shapes.Arc.SweepAngleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SweepAngle<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Shapes.Arc 
   => control._set(Avalonia.Controls.Shapes.Arc.SweepAngleProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SweepAngle<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.Shapes.Arc 
   => control._setEx(Avalonia.Controls.Shapes.Arc.SweepAngleProperty!, obs, changed);



//================= Styles ======================//
 // StartAngle

/*ValueStyleSetterGenerator*/
public static Style<T> StartAngle<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Arc 
=> style._addSetter(Avalonia.Controls.Shapes.Arc.StartAngleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StartAngle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Arc 
=> style._addSetter(Avalonia.Controls.Shapes.Arc.StartAngleProperty, binding);


 // SweepAngle

/*ValueStyleSetterGenerator*/
public static Style<T> SweepAngle<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Arc 
=> style._addSetter(Avalonia.Controls.Shapes.Arc.SweepAngleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SweepAngle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Arc 
=> style._addSetter(Avalonia.Controls.Shapes.Arc.SweepAngleProperty, binding);



}

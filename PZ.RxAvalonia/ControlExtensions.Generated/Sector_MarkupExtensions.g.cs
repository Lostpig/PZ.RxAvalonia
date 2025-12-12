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
public static partial class Sector_MarkupExtensions
{
//================= Properties ======================//
 // StartAngle

/*ValueSetterGenerator*/
public static T StartAngle<T>(this T control, System.Double value) where T : Avalonia.Controls.Shapes.Sector 
{
    control.StartAngle = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T StartAngle<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Shapes.Sector 
   => control._set(Avalonia.Controls.Shapes.Sector.StartAngleProperty!, func);

/*SetterFromObservableGenerator*/
public static T StartAngle<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Shapes.Sector 
   => control._set(Avalonia.Controls.Shapes.Sector.StartAngleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T StartAngle<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Shapes.Sector 
   => control._set(Avalonia.Controls.Shapes.Sector.StartAngleProperty!, subject);


 // SweepAngle

/*ValueSetterGenerator*/
public static T SweepAngle<T>(this T control, System.Double value) where T : Avalonia.Controls.Shapes.Sector 
{
    control.SweepAngle = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SweepAngle<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Shapes.Sector 
   => control._set(Avalonia.Controls.Shapes.Sector.SweepAngleProperty!, func);

/*SetterFromObservableGenerator*/
public static T SweepAngle<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Shapes.Sector 
   => control._set(Avalonia.Controls.Shapes.Sector.SweepAngleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SweepAngle<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Shapes.Sector 
   => control._set(Avalonia.Controls.Shapes.Sector.SweepAngleProperty!, subject);



//================= Styles ======================//
 // StartAngle

/*ValueStyleSetterGenerator*/
public static Style<T> StartAngle<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Sector 
=> style._addSetter(Avalonia.Controls.Shapes.Sector.StartAngleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StartAngle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Sector 
=> style._addSetter(Avalonia.Controls.Shapes.Sector.StartAngleProperty, binding);


 // SweepAngle

/*ValueStyleSetterGenerator*/
public static Style<T> SweepAngle<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Sector 
=> style._addSetter(Avalonia.Controls.Shapes.Sector.SweepAngleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SweepAngle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Sector 
=> style._addSetter(Avalonia.Controls.Shapes.Sector.SweepAngleProperty, binding);



}

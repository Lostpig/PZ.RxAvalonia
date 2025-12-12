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
public static partial class Shape_MarkupExtensions
{
//================= Properties ======================//
 // Fill

/*ValueSetterGenerator*/
public static T Fill<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Shapes.Shape 
{
    control.Fill = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Fill<T>(this T control, Func<Avalonia.Media.IBrush> func) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.FillProperty!, func);

/*SetterFromObservableGenerator*/
public static T Fill<T>(this T control, IObservable<Avalonia.Media.IBrush> obs) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.FillProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Fill<T>(this T control, ISubject<Avalonia.Media.IBrush> subject) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.FillProperty!, subject);


 // Stretch

/*ValueSetterGenerator*/
public static T Stretch<T>(this T control, Avalonia.Media.Stretch value) where T : Avalonia.Controls.Shapes.Shape 
{
    control.Stretch = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Stretch<T>(this T control, Func<Avalonia.Media.Stretch> func) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StretchProperty!, func);

/*SetterFromObservableGenerator*/
public static T Stretch<T>(this T control, IObservable<Avalonia.Media.Stretch> obs) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StretchProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Stretch<T>(this T control, ISubject<Avalonia.Media.Stretch> subject) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StretchProperty!, subject);


 // Stroke

/*ValueSetterGenerator*/
public static T Stroke<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Shapes.Shape 
{
    control.Stroke = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Stroke<T>(this T control, Func<Avalonia.Media.IBrush> func) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeProperty!, func);

/*SetterFromObservableGenerator*/
public static T Stroke<T>(this T control, IObservable<Avalonia.Media.IBrush> obs) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Stroke<T>(this T control, ISubject<Avalonia.Media.IBrush> subject) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeProperty!, subject);


 // StrokeDashArray

/*ValueSetterGenerator*/
public static T StrokeDashArray<T>(this T control, Avalonia.Collections.AvaloniaList<System.Double> value) where T : Avalonia.Controls.Shapes.Shape 
{
    control.StrokeDashArray = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T StrokeDashArray<T>(this T control, Func<Avalonia.Collections.AvaloniaList<System.Double>> func) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty!, func);

/*SetterFromObservableGenerator*/
public static T StrokeDashArray<T>(this T control, IObservable<Avalonia.Collections.AvaloniaList<System.Double>> obs) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T StrokeDashArray<T>(this T control, ISubject<Avalonia.Collections.AvaloniaList<System.Double>> subject) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty!, subject);


 // StrokeDashOffset

/*ValueSetterGenerator*/
public static T StrokeDashOffset<T>(this T control, System.Double value) where T : Avalonia.Controls.Shapes.Shape 
{
    control.StrokeDashOffset = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T StrokeDashOffset<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty!, func);

/*SetterFromObservableGenerator*/
public static T StrokeDashOffset<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T StrokeDashOffset<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty!, subject);


 // StrokeThickness

/*ValueSetterGenerator*/
public static T StrokeThickness<T>(this T control, System.Double value) where T : Avalonia.Controls.Shapes.Shape 
{
    control.StrokeThickness = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T StrokeThickness<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty!, func);

/*SetterFromObservableGenerator*/
public static T StrokeThickness<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T StrokeThickness<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty!, subject);


 // StrokeLineCap

/*ValueSetterGenerator*/
public static T StrokeLineCap<T>(this T control, Avalonia.Media.PenLineCap value) where T : Avalonia.Controls.Shapes.Shape 
{
    control.StrokeLineCap = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T StrokeLineCap<T>(this T control, Func<Avalonia.Media.PenLineCap> func) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty!, func);

/*SetterFromObservableGenerator*/
public static T StrokeLineCap<T>(this T control, IObservable<Avalonia.Media.PenLineCap> obs) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T StrokeLineCap<T>(this T control, ISubject<Avalonia.Media.PenLineCap> subject) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty!, subject);


 // StrokeJoin

/*ValueSetterGenerator*/
public static T StrokeJoin<T>(this T control, Avalonia.Media.PenLineJoin value) where T : Avalonia.Controls.Shapes.Shape 
{
    control.StrokeJoin = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T StrokeJoin<T>(this T control, Func<Avalonia.Media.PenLineJoin> func) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeJoinProperty!, func);

/*SetterFromObservableGenerator*/
public static T StrokeJoin<T>(this T control, IObservable<Avalonia.Media.PenLineJoin> obs) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeJoinProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T StrokeJoin<T>(this T control, ISubject<Avalonia.Media.PenLineJoin> subject) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(Avalonia.Controls.Shapes.Shape.StrokeJoinProperty!, subject);



//================= Styles ======================//
 // Fill

/*ValueStyleSetterGenerator*/
public static Style<T> Fill<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.FillProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Fill<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.FillProperty, binding);


 // Stretch

/*ValueStyleSetterGenerator*/
public static Style<T> Stretch<T>(this Style<T> style, Avalonia.Media.Stretch value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StretchProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Stretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StretchProperty, binding);


 // Stroke

/*ValueStyleSetterGenerator*/
public static Style<T> Stroke<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Stroke<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeProperty, binding);


 // StrokeDashArray

/*ValueStyleSetterGenerator*/
public static Style<T> StrokeDashArray<T>(this Style<T> style, Avalonia.Collections.AvaloniaList<System.Double> value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StrokeDashArray<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty, binding);


 // StrokeDashOffset

/*ValueStyleSetterGenerator*/
public static Style<T> StrokeDashOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StrokeDashOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty, binding);


 // StrokeThickness

/*ValueStyleSetterGenerator*/
public static Style<T> StrokeThickness<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StrokeThickness<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty, binding);


 // StrokeLineCap

/*ValueStyleSetterGenerator*/
public static Style<T> StrokeLineCap<T>(this Style<T> style, Avalonia.Media.PenLineCap value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StrokeLineCap<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty, binding);


 // StrokeJoin

/*ValueStyleSetterGenerator*/
public static Style<T> StrokeJoin<T>(this Style<T> style, Avalonia.Media.PenLineJoin value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeJoinProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StrokeJoin<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeJoinProperty, binding);



}

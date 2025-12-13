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
public static partial class TextDecoration_MarkupExtensions
{
//================= Properties ======================//
 // Location

/*ValueSetterGenerator*/
public static T Location<T>(this T control, Avalonia.Media.TextDecorationLocation value) where T : Avalonia.Media.TextDecoration 
{
    control.Location = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Location<T>(this T control, Func<Avalonia.Media.TextDecorationLocation> func) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.LocationProperty!, func);

/*SetterFromObservableGenerator*/
public static T Location<T>(this T control, IObservable<Avalonia.Media.TextDecorationLocation> obs) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.LocationProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Location<T>(this T control, ISubject<Avalonia.Media.TextDecorationLocation> subject) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.LocationProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Location<T>(this T control, IObservable<Avalonia.Media.TextDecorationLocation> obs, IObserver<Avalonia.Media.TextDecorationLocation> changed) where T : Avalonia.Media.TextDecoration 
   => control._setEx(Avalonia.Media.TextDecoration.LocationProperty!, obs, changed);


 // Stroke

/*ValueSetterGenerator*/
public static T Stroke<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Media.TextDecoration 
{
    control.Stroke = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Stroke<T>(this T control, Func<Avalonia.Media.IBrush> func) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeProperty!, func);

/*SetterFromObservableGenerator*/
public static T Stroke<T>(this T control, IObservable<Avalonia.Media.IBrush> obs) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Stroke<T>(this T control, ISubject<Avalonia.Media.IBrush> subject) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Stroke<T>(this T control, IObservable<Avalonia.Media.IBrush> obs, IObserver<Avalonia.Media.IBrush> changed) where T : Avalonia.Media.TextDecoration 
   => control._setEx(Avalonia.Media.TextDecoration.StrokeProperty!, obs, changed);


 // StrokeThicknessUnit

/*ValueSetterGenerator*/
public static T StrokeThicknessUnit<T>(this T control, Avalonia.Media.TextDecorationUnit value) where T : Avalonia.Media.TextDecoration 
{
    control.StrokeThicknessUnit = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T StrokeThicknessUnit<T>(this T control, Func<Avalonia.Media.TextDecorationUnit> func) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeThicknessUnitProperty!, func);

/*SetterFromObservableGenerator*/
public static T StrokeThicknessUnit<T>(this T control, IObservable<Avalonia.Media.TextDecorationUnit> obs) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeThicknessUnitProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T StrokeThicknessUnit<T>(this T control, ISubject<Avalonia.Media.TextDecorationUnit> subject) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeThicknessUnitProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T StrokeThicknessUnit<T>(this T control, IObservable<Avalonia.Media.TextDecorationUnit> obs, IObserver<Avalonia.Media.TextDecorationUnit> changed) where T : Avalonia.Media.TextDecoration 
   => control._setEx(Avalonia.Media.TextDecoration.StrokeThicknessUnitProperty!, obs, changed);


 // StrokeDashArray

/*ValueSetterGenerator*/
public static T StrokeDashArray<T>(this T control, Avalonia.Collections.AvaloniaList<System.Double> value) where T : Avalonia.Media.TextDecoration 
{
    control.StrokeDashArray = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T StrokeDashArray<T>(this T control, Func<Avalonia.Collections.AvaloniaList<System.Double>> func) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeDashArrayProperty!, func);

/*SetterFromObservableGenerator*/
public static T StrokeDashArray<T>(this T control, IObservable<Avalonia.Collections.AvaloniaList<System.Double>> obs) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeDashArrayProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T StrokeDashArray<T>(this T control, ISubject<Avalonia.Collections.AvaloniaList<System.Double>> subject) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeDashArrayProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T StrokeDashArray<T>(this T control, IObservable<Avalonia.Collections.AvaloniaList<System.Double>> obs, IObserver<Avalonia.Collections.AvaloniaList<System.Double>> changed) where T : Avalonia.Media.TextDecoration 
   => control._setEx(Avalonia.Media.TextDecoration.StrokeDashArrayProperty!, obs, changed);


 // StrokeDashOffset

/*ValueSetterGenerator*/
public static T StrokeDashOffset<T>(this T control, System.Double value) where T : Avalonia.Media.TextDecoration 
{
    control.StrokeDashOffset = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T StrokeDashOffset<T>(this T control, Func<System.Double> func) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeDashOffsetProperty!, func);

/*SetterFromObservableGenerator*/
public static T StrokeDashOffset<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeDashOffsetProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T StrokeDashOffset<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeDashOffsetProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T StrokeDashOffset<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Media.TextDecoration 
   => control._setEx(Avalonia.Media.TextDecoration.StrokeDashOffsetProperty!, obs, changed);


 // StrokeThickness

/*ValueSetterGenerator*/
public static T StrokeThickness<T>(this T control, System.Double value) where T : Avalonia.Media.TextDecoration 
{
    control.StrokeThickness = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T StrokeThickness<T>(this T control, Func<System.Double> func) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeThicknessProperty!, func);

/*SetterFromObservableGenerator*/
public static T StrokeThickness<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeThicknessProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T StrokeThickness<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeThicknessProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T StrokeThickness<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Media.TextDecoration 
   => control._setEx(Avalonia.Media.TextDecoration.StrokeThicknessProperty!, obs, changed);


 // StrokeLineCap

/*ValueSetterGenerator*/
public static T StrokeLineCap<T>(this T control, Avalonia.Media.PenLineCap value) where T : Avalonia.Media.TextDecoration 
{
    control.StrokeLineCap = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T StrokeLineCap<T>(this T control, Func<Avalonia.Media.PenLineCap> func) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeLineCapProperty!, func);

/*SetterFromObservableGenerator*/
public static T StrokeLineCap<T>(this T control, IObservable<Avalonia.Media.PenLineCap> obs) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeLineCapProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T StrokeLineCap<T>(this T control, ISubject<Avalonia.Media.PenLineCap> subject) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeLineCapProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T StrokeLineCap<T>(this T control, IObservable<Avalonia.Media.PenLineCap> obs, IObserver<Avalonia.Media.PenLineCap> changed) where T : Avalonia.Media.TextDecoration 
   => control._setEx(Avalonia.Media.TextDecoration.StrokeLineCapProperty!, obs, changed);


 // StrokeOffset

/*ValueSetterGenerator*/
public static T StrokeOffset<T>(this T control, System.Double value) where T : Avalonia.Media.TextDecoration 
{
    control.StrokeOffset = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T StrokeOffset<T>(this T control, Func<System.Double> func) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeOffsetProperty!, func);

/*SetterFromObservableGenerator*/
public static T StrokeOffset<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeOffsetProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T StrokeOffset<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeOffsetProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T StrokeOffset<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Media.TextDecoration 
   => control._setEx(Avalonia.Media.TextDecoration.StrokeOffsetProperty!, obs, changed);


 // StrokeOffsetUnit

/*ValueSetterGenerator*/
public static T StrokeOffsetUnit<T>(this T control, Avalonia.Media.TextDecorationUnit value) where T : Avalonia.Media.TextDecoration 
{
    control.StrokeOffsetUnit = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T StrokeOffsetUnit<T>(this T control, Func<Avalonia.Media.TextDecorationUnit> func) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeOffsetUnitProperty!, func);

/*SetterFromObservableGenerator*/
public static T StrokeOffsetUnit<T>(this T control, IObservable<Avalonia.Media.TextDecorationUnit> obs) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeOffsetUnitProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T StrokeOffsetUnit<T>(this T control, ISubject<Avalonia.Media.TextDecorationUnit> subject) where T : Avalonia.Media.TextDecoration 
   => control._set(Avalonia.Media.TextDecoration.StrokeOffsetUnitProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T StrokeOffsetUnit<T>(this T control, IObservable<Avalonia.Media.TextDecorationUnit> obs, IObserver<Avalonia.Media.TextDecorationUnit> changed) where T : Avalonia.Media.TextDecoration 
   => control._setEx(Avalonia.Media.TextDecoration.StrokeOffsetUnitProperty!, obs, changed);



}

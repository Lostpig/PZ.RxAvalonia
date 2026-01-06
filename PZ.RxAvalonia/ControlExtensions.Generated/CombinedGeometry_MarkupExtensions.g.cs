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
public static partial class CombinedGeometry_MarkupExtensions
{
//================= Properties ======================//
 // Geometry1

/*ValueSetterGenerator*/
public static T Geometry1<T>(this T control, Avalonia.Media.Geometry? value) where T : Avalonia.Media.CombinedGeometry 
{
    control.Geometry1 = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Geometry1<T>(this T control, Func<Avalonia.Media.Geometry?> func) where T : Avalonia.Media.CombinedGeometry 
   => control._set(Avalonia.Media.CombinedGeometry.Geometry1Property!, func);

/*SetterFromObservableGenerator*/
public static T Geometry1<T>(this T control, IObservable<Avalonia.Media.Geometry?> obs) where T : Avalonia.Media.CombinedGeometry 
   => control._set(Avalonia.Media.CombinedGeometry.Geometry1Property!, obs);

/*SetterFromSubjectGenerator*/
public static T Geometry1<T>(this T control, ISubject<Avalonia.Media.Geometry?> subject) where T : Avalonia.Media.CombinedGeometry 
   => control._set(Avalonia.Media.CombinedGeometry.Geometry1Property!, subject);

/*SetterFromTwoWayGenerator*/
public static T Geometry1<T>(this T control, IObservable<Avalonia.Media.Geometry?> obs, IObserver<Avalonia.Media.Geometry?> changed) where T : Avalonia.Media.CombinedGeometry 
   => control._setEx(Avalonia.Media.CombinedGeometry.Geometry1Property!, obs, changed);


 // Geometry2

/*ValueSetterGenerator*/
public static T Geometry2<T>(this T control, Avalonia.Media.Geometry? value) where T : Avalonia.Media.CombinedGeometry 
{
    control.Geometry2 = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Geometry2<T>(this T control, Func<Avalonia.Media.Geometry?> func) where T : Avalonia.Media.CombinedGeometry 
   => control._set(Avalonia.Media.CombinedGeometry.Geometry2Property!, func);

/*SetterFromObservableGenerator*/
public static T Geometry2<T>(this T control, IObservable<Avalonia.Media.Geometry?> obs) where T : Avalonia.Media.CombinedGeometry 
   => control._set(Avalonia.Media.CombinedGeometry.Geometry2Property!, obs);

/*SetterFromSubjectGenerator*/
public static T Geometry2<T>(this T control, ISubject<Avalonia.Media.Geometry?> subject) where T : Avalonia.Media.CombinedGeometry 
   => control._set(Avalonia.Media.CombinedGeometry.Geometry2Property!, subject);

/*SetterFromTwoWayGenerator*/
public static T Geometry2<T>(this T control, IObservable<Avalonia.Media.Geometry?> obs, IObserver<Avalonia.Media.Geometry?> changed) where T : Avalonia.Media.CombinedGeometry 
   => control._setEx(Avalonia.Media.CombinedGeometry.Geometry2Property!, obs, changed);


 // GeometryCombineMode

/*ValueSetterGenerator*/
public static T GeometryCombineMode<T>(this T control, Avalonia.Media.GeometryCombineMode value) where T : Avalonia.Media.CombinedGeometry 
{
    control.GeometryCombineMode = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T GeometryCombineMode<T>(this T control, Func<Avalonia.Media.GeometryCombineMode> func) where T : Avalonia.Media.CombinedGeometry 
   => control._set(Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty!, func);

/*SetterFromObservableGenerator*/
public static T GeometryCombineMode<T>(this T control, IObservable<Avalonia.Media.GeometryCombineMode> obs) where T : Avalonia.Media.CombinedGeometry 
   => control._set(Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T GeometryCombineMode<T>(this T control, ISubject<Avalonia.Media.GeometryCombineMode> subject) where T : Avalonia.Media.CombinedGeometry 
   => control._set(Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T GeometryCombineMode<T>(this T control, IObservable<Avalonia.Media.GeometryCombineMode> obs, IObserver<Avalonia.Media.GeometryCombineMode> changed) where T : Avalonia.Media.CombinedGeometry 
   => control._setEx(Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty!, obs, changed);



}

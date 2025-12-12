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
public static partial class GradientBrush_MarkupExtensions
{
//================= Properties ======================//
 // SpreadMethod

/*ValueSetterGenerator*/
public static T SpreadMethod<T>(this T control, Avalonia.Media.GradientSpreadMethod value) where T : Avalonia.Media.GradientBrush 
{
    control.SpreadMethod = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SpreadMethod<T>(this T control, Func<Avalonia.Media.GradientSpreadMethod> func) where T : Avalonia.Media.GradientBrush 
   => control._set(Avalonia.Media.GradientBrush.SpreadMethodProperty!, func);

/*SetterFromObservableGenerator*/
public static T SpreadMethod<T>(this T control, IObservable<Avalonia.Media.GradientSpreadMethod> obs) where T : Avalonia.Media.GradientBrush 
   => control._set(Avalonia.Media.GradientBrush.SpreadMethodProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SpreadMethod<T>(this T control, ISubject<Avalonia.Media.GradientSpreadMethod> subject) where T : Avalonia.Media.GradientBrush 
   => control._set(Avalonia.Media.GradientBrush.SpreadMethodProperty!, subject);


 // GradientStops

/*ValueSetterGenerator*/
public static T GradientStops<T>(this T control, Avalonia.Media.GradientStops value) where T : Avalonia.Media.GradientBrush 
{
    control.GradientStops = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T GradientStops<T>(this T control, Func<Avalonia.Media.GradientStops> func) where T : Avalonia.Media.GradientBrush 
   => control._set(Avalonia.Media.GradientBrush.GradientStopsProperty!, func);

/*SetterFromObservableGenerator*/
public static T GradientStops<T>(this T control, IObservable<Avalonia.Media.GradientStops> obs) where T : Avalonia.Media.GradientBrush 
   => control._set(Avalonia.Media.GradientBrush.GradientStopsProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T GradientStops<T>(this T control, ISubject<Avalonia.Media.GradientStops> subject) where T : Avalonia.Media.GradientBrush 
   => control._set(Avalonia.Media.GradientBrush.GradientStopsProperty!, subject);



}

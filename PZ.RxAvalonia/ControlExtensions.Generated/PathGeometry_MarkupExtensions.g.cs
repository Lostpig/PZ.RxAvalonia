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
public static partial class PathGeometry_MarkupExtensions
{
//================= Properties ======================//
 // Figures

/*ValueSetterGenerator*/
public static T Figures<T>(this T control, Avalonia.Media.PathFigures value) where T : Avalonia.Media.PathGeometry 
{
    control.Figures = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Figures<T>(this T control, Func<Avalonia.Media.PathFigures> func) where T : Avalonia.Media.PathGeometry 
   => control._set(Avalonia.Media.PathGeometry.FiguresProperty!, func);

/*SetterFromObservableGenerator*/
public static T Figures<T>(this T control, IObservable<Avalonia.Media.PathFigures> obs) where T : Avalonia.Media.PathGeometry 
   => control._set(Avalonia.Media.PathGeometry.FiguresProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Figures<T>(this T control, ISubject<Avalonia.Media.PathFigures> subject) where T : Avalonia.Media.PathGeometry 
   => control._set(Avalonia.Media.PathGeometry.FiguresProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Figures<T>(this T control, IObservable<Avalonia.Media.PathFigures> obs, IObserver<Avalonia.Media.PathFigures> changed) where T : Avalonia.Media.PathGeometry 
   => control._setEx(Avalonia.Media.PathGeometry.FiguresProperty!, obs, changed);


 // FillRule

/*ValueSetterGenerator*/
public static T FillRule<T>(this T control, Avalonia.Media.FillRule value) where T : Avalonia.Media.PathGeometry 
{
    control.FillRule = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FillRule<T>(this T control, Func<Avalonia.Media.FillRule> func) where T : Avalonia.Media.PathGeometry 
   => control._set(Avalonia.Media.PathGeometry.FillRuleProperty!, func);

/*SetterFromObservableGenerator*/
public static T FillRule<T>(this T control, IObservable<Avalonia.Media.FillRule> obs) where T : Avalonia.Media.PathGeometry 
   => control._set(Avalonia.Media.PathGeometry.FillRuleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FillRule<T>(this T control, ISubject<Avalonia.Media.FillRule> subject) where T : Avalonia.Media.PathGeometry 
   => control._set(Avalonia.Media.PathGeometry.FillRuleProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T FillRule<T>(this T control, IObservable<Avalonia.Media.FillRule> obs, IObserver<Avalonia.Media.FillRule> changed) where T : Avalonia.Media.PathGeometry 
   => control._setEx(Avalonia.Media.PathGeometry.FillRuleProperty!, obs, changed);



}

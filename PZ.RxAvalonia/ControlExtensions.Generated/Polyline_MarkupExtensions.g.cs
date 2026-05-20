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
public static partial class Polyline_MarkupExtensions
{
//================= Properties ======================//
 // Points

/*ValueSetterGenerator*/
public static T Points<T>(this T control, System.Collections.Generic.IList<Avalonia.Point> value) where T : Avalonia.Controls.Shapes.Polyline 
{
    control.Points = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Points<T>(this T control, Func<System.Collections.Generic.IList<Avalonia.Point>> func) where T : Avalonia.Controls.Shapes.Polyline 
   => control._set(Avalonia.Controls.Shapes.Polyline.PointsProperty!, func);

/*SetterFromObservableGenerator*/
public static T Points<T>(this T control, IObservable<System.Collections.Generic.IList<Avalonia.Point>> obs) where T : Avalonia.Controls.Shapes.Polyline 
   => control._set(Avalonia.Controls.Shapes.Polyline.PointsProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Points<T>(this T control, ISubject<System.Collections.Generic.IList<Avalonia.Point>> subject) where T : Avalonia.Controls.Shapes.Polyline 
   => control._set(Avalonia.Controls.Shapes.Polyline.PointsProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Points<T>(this T control, IObservable<System.Collections.Generic.IList<Avalonia.Point>> obs, IObserver<System.Collections.Generic.IList<Avalonia.Point>> changed) where T : Avalonia.Controls.Shapes.Polyline 
   => control._setEx(Avalonia.Controls.Shapes.Polyline.PointsProperty!, obs, changed);


 // FillRule

/*ValueSetterGenerator*/
public static T FillRule<T>(this T control, Avalonia.Media.FillRule value) where T : Avalonia.Controls.Shapes.Polyline 
{
    control.FillRule = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FillRule<T>(this T control, Func<Avalonia.Media.FillRule> func) where T : Avalonia.Controls.Shapes.Polyline 
   => control._set(Avalonia.Controls.Shapes.Polyline.FillRuleProperty!, func);

/*SetterFromObservableGenerator*/
public static T FillRule<T>(this T control, IObservable<Avalonia.Media.FillRule> obs) where T : Avalonia.Controls.Shapes.Polyline 
   => control._set(Avalonia.Controls.Shapes.Polyline.FillRuleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FillRule<T>(this T control, ISubject<Avalonia.Media.FillRule> subject) where T : Avalonia.Controls.Shapes.Polyline 
   => control._set(Avalonia.Controls.Shapes.Polyline.FillRuleProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T FillRule<T>(this T control, IObservable<Avalonia.Media.FillRule> obs, IObserver<Avalonia.Media.FillRule> changed) where T : Avalonia.Controls.Shapes.Polyline 
   => control._setEx(Avalonia.Controls.Shapes.Polyline.FillRuleProperty!, obs, changed);



//================= Styles ======================//
 // Points

/*ValueStyleSetterGenerator*/
public static Style<T> Points<T>(this Style<T> style, System.Collections.Generic.IList<Avalonia.Point> value) where T : Avalonia.Controls.Shapes.Polyline 
=> style._addSetter(Avalonia.Controls.Shapes.Polyline.PointsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Points<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.Shapes.Polyline 
=> style._addSetter(Avalonia.Controls.Shapes.Polyline.PointsProperty, binding);


 // FillRule

/*ValueStyleSetterGenerator*/
public static Style<T> FillRule<T>(this Style<T> style, Avalonia.Media.FillRule value) where T : Avalonia.Controls.Shapes.Polyline 
=> style._addSetter(Avalonia.Controls.Shapes.Polyline.FillRuleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FillRule<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.Shapes.Polyline 
=> style._addSetter(Avalonia.Controls.Shapes.Polyline.FillRuleProperty, binding);



}

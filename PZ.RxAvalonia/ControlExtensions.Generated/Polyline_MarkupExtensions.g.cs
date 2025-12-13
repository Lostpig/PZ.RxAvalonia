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



//================= Styles ======================//
 // Points

/*ValueStyleSetterGenerator*/
public static Style<T> Points<T>(this Style<T> style, System.Collections.Generic.IList<Avalonia.Point> value) where T : Avalonia.Controls.Shapes.Polyline 
=> style._addSetter(Avalonia.Controls.Shapes.Polyline.PointsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Points<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Polyline 
=> style._addSetter(Avalonia.Controls.Shapes.Polyline.PointsProperty, binding);



}

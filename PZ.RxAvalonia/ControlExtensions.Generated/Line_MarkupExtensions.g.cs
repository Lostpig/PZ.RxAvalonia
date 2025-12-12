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
public static partial class Line_MarkupExtensions
{
//================= Properties ======================//
 // StartPoint

/*ValueSetterGenerator*/
public static T StartPoint<T>(this T control, Avalonia.Point value) where T : Avalonia.Controls.Shapes.Line 
{
    control.StartPoint = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T StartPoint<T>(this T control, Func<Avalonia.Point> func) where T : Avalonia.Controls.Shapes.Line 
   => control._set(Avalonia.Controls.Shapes.Line.StartPointProperty!, func);

/*SetterFromObservableGenerator*/
public static T StartPoint<T>(this T control, IObservable<Avalonia.Point> obs) where T : Avalonia.Controls.Shapes.Line 
   => control._set(Avalonia.Controls.Shapes.Line.StartPointProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T StartPoint<T>(this T control, ISubject<Avalonia.Point> subject) where T : Avalonia.Controls.Shapes.Line 
   => control._set(Avalonia.Controls.Shapes.Line.StartPointProperty!, subject);


 // EndPoint

/*ValueSetterGenerator*/
public static T EndPoint<T>(this T control, Avalonia.Point value) where T : Avalonia.Controls.Shapes.Line 
{
    control.EndPoint = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T EndPoint<T>(this T control, Func<Avalonia.Point> func) where T : Avalonia.Controls.Shapes.Line 
   => control._set(Avalonia.Controls.Shapes.Line.EndPointProperty!, func);

/*SetterFromObservableGenerator*/
public static T EndPoint<T>(this T control, IObservable<Avalonia.Point> obs) where T : Avalonia.Controls.Shapes.Line 
   => control._set(Avalonia.Controls.Shapes.Line.EndPointProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T EndPoint<T>(this T control, ISubject<Avalonia.Point> subject) where T : Avalonia.Controls.Shapes.Line 
   => control._set(Avalonia.Controls.Shapes.Line.EndPointProperty!, subject);



//================= Styles ======================//
 // StartPoint

/*ValueStyleSetterGenerator*/
public static Style<T> StartPoint<T>(this Style<T> style, Avalonia.Point value) where T : Avalonia.Controls.Shapes.Line 
=> style._addSetter(Avalonia.Controls.Shapes.Line.StartPointProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StartPoint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Line 
=> style._addSetter(Avalonia.Controls.Shapes.Line.StartPointProperty, binding);


 // EndPoint

/*ValueStyleSetterGenerator*/
public static Style<T> EndPoint<T>(this Style<T> style, Avalonia.Point value) where T : Avalonia.Controls.Shapes.Line 
=> style._addSetter(Avalonia.Controls.Shapes.Line.EndPointProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> EndPoint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Line 
=> style._addSetter(Avalonia.Controls.Shapes.Line.EndPointProperty, binding);



}

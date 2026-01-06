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
public static partial class Path_MarkupExtensions
{
//================= Properties ======================//
 // Data

/*ValueSetterGenerator*/
public static T Data<T>(this T control, Avalonia.Media.Geometry? value) where T : Avalonia.Controls.Shapes.Path 
{
    control.Data = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Data<T>(this T control, Func<Avalonia.Media.Geometry?> func) where T : Avalonia.Controls.Shapes.Path 
   => control._set(Avalonia.Controls.Shapes.Path.DataProperty!, func);

/*SetterFromObservableGenerator*/
public static T Data<T>(this T control, IObservable<Avalonia.Media.Geometry?> obs) where T : Avalonia.Controls.Shapes.Path 
   => control._set(Avalonia.Controls.Shapes.Path.DataProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Data<T>(this T control, ISubject<Avalonia.Media.Geometry?> subject) where T : Avalonia.Controls.Shapes.Path 
   => control._set(Avalonia.Controls.Shapes.Path.DataProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Data<T>(this T control, IObservable<Avalonia.Media.Geometry?> obs, IObserver<Avalonia.Media.Geometry?> changed) where T : Avalonia.Controls.Shapes.Path 
   => control._setEx(Avalonia.Controls.Shapes.Path.DataProperty!, obs, changed);



//================= Styles ======================//
 // Data

/*ValueStyleSetterGenerator*/
public static Style<T> Data<T>(this Style<T> style, Avalonia.Media.Geometry? value) where T : Avalonia.Controls.Shapes.Path 
=> style._addSetter(Avalonia.Controls.Shapes.Path.DataProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Data<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Path 
=> style._addSetter(Avalonia.Controls.Shapes.Path.DataProperty, binding);



}

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
public static partial class PathIcon_MarkupExtensions
{
//================= Properties ======================//
 // Data

/*ValueSetterGenerator*/
public static T Data<T>(this T control, Avalonia.Media.Geometry? value) where T : Avalonia.Controls.PathIcon 
{
    control.Data = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Data<T>(this T control, Func<Avalonia.Media.Geometry?> func) where T : Avalonia.Controls.PathIcon 
   => control._set(Avalonia.Controls.PathIcon.DataProperty!, func);

/*SetterFromObservableGenerator*/
public static T Data<T>(this T control, IObservable<Avalonia.Media.Geometry?> obs) where T : Avalonia.Controls.PathIcon 
   => control._set(Avalonia.Controls.PathIcon.DataProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Data<T>(this T control, ISubject<Avalonia.Media.Geometry?> subject) where T : Avalonia.Controls.PathIcon 
   => control._set(Avalonia.Controls.PathIcon.DataProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Data<T>(this T control, IObservable<Avalonia.Media.Geometry?> obs, IObserver<Avalonia.Media.Geometry?> changed) where T : Avalonia.Controls.PathIcon 
   => control._setEx(Avalonia.Controls.PathIcon.DataProperty!, obs, changed);



//================= Styles ======================//
 // Data

/*ValueStyleSetterGenerator*/
public static Style<T> Data<T>(this Style<T> style, Avalonia.Media.Geometry? value) where T : Avalonia.Controls.PathIcon 
=> style._addSetter(Avalonia.Controls.PathIcon.DataProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Data<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.PathIcon 
=> style._addSetter(Avalonia.Controls.PathIcon.DataProperty, binding);



}

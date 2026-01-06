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
public static partial class Label_MarkupExtensions
{
//================= Properties ======================//
 // Target

/*ValueSetterGenerator*/
public static T Target<T>(this T control, Avalonia.Input.IInputElement? value) where T : Avalonia.Controls.Label 
{
    control.Target = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Target<T>(this T control, Func<Avalonia.Input.IInputElement?> func) where T : Avalonia.Controls.Label 
   => control._set(Avalonia.Controls.Label.TargetProperty!, func);

/*SetterFromObservableGenerator*/
public static T Target<T>(this T control, IObservable<Avalonia.Input.IInputElement?> obs) where T : Avalonia.Controls.Label 
   => control._set(Avalonia.Controls.Label.TargetProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Target<T>(this T control, ISubject<Avalonia.Input.IInputElement?> subject) where T : Avalonia.Controls.Label 
   => control._set(Avalonia.Controls.Label.TargetProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Target<T>(this T control, IObservable<Avalonia.Input.IInputElement?> obs, IObserver<Avalonia.Input.IInputElement?> changed) where T : Avalonia.Controls.Label 
   => control._setEx(Avalonia.Controls.Label.TargetProperty!, obs, changed);



//================= Styles ======================//
 // Target

/*ValueStyleSetterGenerator*/
public static Style<T> Target<T>(this Style<T> style, Avalonia.Input.IInputElement? value) where T : Avalonia.Controls.Label 
=> style._addSetter(Avalonia.Controls.Label.TargetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Target<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Label 
=> style._addSetter(Avalonia.Controls.Label.TargetProperty, binding);



}

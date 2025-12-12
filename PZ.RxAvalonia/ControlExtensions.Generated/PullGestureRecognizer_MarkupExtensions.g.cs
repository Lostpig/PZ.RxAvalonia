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
public static partial class PullGestureRecognizer_MarkupExtensions
{
//================= Properties ======================//
 // PullDirection

/*ValueSetterGenerator*/
public static T PullDirection<T>(this T control, Avalonia.Input.PullDirection value) where T : Avalonia.Input.PullGestureRecognizer 
{
    control.PullDirection = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PullDirection<T>(this T control, Func<Avalonia.Input.PullDirection> func) where T : Avalonia.Input.PullGestureRecognizer 
   => control._set(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty!, func);

/*SetterFromObservableGenerator*/
public static T PullDirection<T>(this T control, IObservable<Avalonia.Input.PullDirection> obs) where T : Avalonia.Input.PullGestureRecognizer 
   => control._set(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PullDirection<T>(this T control, ISubject<Avalonia.Input.PullDirection> subject) where T : Avalonia.Input.PullGestureRecognizer 
   => control._set(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty!, subject);



//================= Styles ======================//
 // PullDirection

/*ValueStyleSetterGenerator*/
public static Style<T> PullDirection<T>(this Style<T> style, Avalonia.Input.PullDirection value) where T : Avalonia.Input.PullGestureRecognizer 
=> style._addSetter(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PullDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.PullGestureRecognizer 
=> style._addSetter(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty, binding);



}

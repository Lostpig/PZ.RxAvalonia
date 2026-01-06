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
public static partial class Animatable_MarkupExtensions
{
//================= Properties ======================//
 // Transitions

/*ValueSetterGenerator*/
public static T Transitions<T>(this T control, Avalonia.Animation.Transitions? value) where T : Avalonia.Animation.Animatable 
{
    control.Transitions = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Transitions<T>(this T control, Func<Avalonia.Animation.Transitions?> func) where T : Avalonia.Animation.Animatable 
   => control._set(Avalonia.Animation.Animatable.TransitionsProperty!, func);

/*SetterFromObservableGenerator*/
public static T Transitions<T>(this T control, IObservable<Avalonia.Animation.Transitions?> obs) where T : Avalonia.Animation.Animatable 
   => control._set(Avalonia.Animation.Animatable.TransitionsProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Transitions<T>(this T control, ISubject<Avalonia.Animation.Transitions?> subject) where T : Avalonia.Animation.Animatable 
   => control._set(Avalonia.Animation.Animatable.TransitionsProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Transitions<T>(this T control, IObservable<Avalonia.Animation.Transitions?> obs, IObserver<Avalonia.Animation.Transitions?> changed) where T : Avalonia.Animation.Animatable 
   => control._setEx(Avalonia.Animation.Animatable.TransitionsProperty!, obs, changed);



}

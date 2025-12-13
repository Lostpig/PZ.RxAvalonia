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
public static partial class TransitioningContentControl_MarkupExtensions
{
//================= Properties ======================//
 // PageTransition

/*ValueSetterGenerator*/
public static T PageTransition<T>(this T control, Avalonia.Animation.IPageTransition value) where T : Avalonia.Controls.TransitioningContentControl 
{
    control.PageTransition = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PageTransition<T>(this T control, Func<Avalonia.Animation.IPageTransition> func) where T : Avalonia.Controls.TransitioningContentControl 
   => control._set(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty!, func);

/*SetterFromObservableGenerator*/
public static T PageTransition<T>(this T control, IObservable<Avalonia.Animation.IPageTransition> obs) where T : Avalonia.Controls.TransitioningContentControl 
   => control._set(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PageTransition<T>(this T control, ISubject<Avalonia.Animation.IPageTransition> subject) where T : Avalonia.Controls.TransitioningContentControl 
   => control._set(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T PageTransition<T>(this T control, IObservable<Avalonia.Animation.IPageTransition> obs, IObserver<Avalonia.Animation.IPageTransition> changed) where T : Avalonia.Controls.TransitioningContentControl 
   => control._setEx(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty!, obs, changed);


 // IsTransitionReversed

/*ValueSetterGenerator*/
public static T IsTransitionReversed<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TransitioningContentControl 
{
    control.IsTransitionReversed = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsTransitionReversed<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.TransitioningContentControl 
   => control._set(Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsTransitionReversed<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.TransitioningContentControl 
   => control._set(Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsTransitionReversed<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.TransitioningContentControl 
   => control._set(Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsTransitionReversed<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.TransitioningContentControl 
   => control._setEx(Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty!, obs, changed);



//================= Events ======================//
 // TransitionCompleted

/*ActionToEventGenerator*/
public static T OnTransitionCompleted<T>(this T control, Action<Avalonia.Controls.TransitionCompletedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TransitioningContentControl 
{
  control.AddHandler(Avalonia.Controls.TransitioningContentControl.TransitionCompletedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TransitioningContentControl.TransitionCompletedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // PageTransition

/*ValueStyleSetterGenerator*/
public static Style<T> PageTransition<T>(this Style<T> style, Avalonia.Animation.IPageTransition value) where T : Avalonia.Controls.TransitioningContentControl 
=> style._addSetter(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PageTransition<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TransitioningContentControl 
=> style._addSetter(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty, binding);


 // IsTransitionReversed

/*ValueStyleSetterGenerator*/
public static Style<T> IsTransitionReversed<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TransitioningContentControl 
=> style._addSetter(Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTransitionReversed<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TransitioningContentControl 
=> style._addSetter(Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty, binding);



}

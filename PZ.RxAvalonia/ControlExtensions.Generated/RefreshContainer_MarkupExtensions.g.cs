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
public static partial class RefreshContainer_MarkupExtensions
{
//================= Properties ======================//
 // Visualizer

/*ValueSetterGenerator*/
public static T Visualizer<T>(this T control, Avalonia.Controls.RefreshVisualizer? value) where T : Avalonia.Controls.RefreshContainer 
{
    control.Visualizer = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Visualizer<T>(this T control, Func<Avalonia.Controls.RefreshVisualizer?> func) where T : Avalonia.Controls.RefreshContainer 
   => control._set(Avalonia.Controls.RefreshContainer.VisualizerProperty!, func);

/*SetterFromObservableGenerator*/
public static T Visualizer<T>(this T control, IObservable<Avalonia.Controls.RefreshVisualizer?> obs) where T : Avalonia.Controls.RefreshContainer 
   => control._set(Avalonia.Controls.RefreshContainer.VisualizerProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Visualizer<T>(this T control, ISubject<Avalonia.Controls.RefreshVisualizer?> subject) where T : Avalonia.Controls.RefreshContainer 
   => control._set(Avalonia.Controls.RefreshContainer.VisualizerProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Visualizer<T>(this T control, IObservable<Avalonia.Controls.RefreshVisualizer?> obs, IObserver<Avalonia.Controls.RefreshVisualizer?> changed) where T : Avalonia.Controls.RefreshContainer 
   => control._setEx(Avalonia.Controls.RefreshContainer.VisualizerProperty!, obs, changed);


 // PullDirection

/*ValueSetterGenerator*/
public static T PullDirection<T>(this T control, Avalonia.Input.PullDirection value) where T : Avalonia.Controls.RefreshContainer 
{
    control.PullDirection = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PullDirection<T>(this T control, Func<Avalonia.Input.PullDirection> func) where T : Avalonia.Controls.RefreshContainer 
   => control._set(Avalonia.Controls.RefreshContainer.PullDirectionProperty!, func);

/*SetterFromObservableGenerator*/
public static T PullDirection<T>(this T control, IObservable<Avalonia.Input.PullDirection> obs) where T : Avalonia.Controls.RefreshContainer 
   => control._set(Avalonia.Controls.RefreshContainer.PullDirectionProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PullDirection<T>(this T control, ISubject<Avalonia.Input.PullDirection> subject) where T : Avalonia.Controls.RefreshContainer 
   => control._set(Avalonia.Controls.RefreshContainer.PullDirectionProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T PullDirection<T>(this T control, IObservable<Avalonia.Input.PullDirection> obs, IObserver<Avalonia.Input.PullDirection> changed) where T : Avalonia.Controls.RefreshContainer 
   => control._setEx(Avalonia.Controls.RefreshContainer.PullDirectionProperty!, obs, changed);



//================= Events ======================//
 // RefreshRequested

/*ActionToEventGenerator*/
public static T OnRefreshRequested<T>(this T control, Action<Avalonia.Controls.RefreshRequestedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.RefreshContainer 
{
  control.AddHandler(Avalonia.Controls.RefreshContainer.RefreshRequestedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.RefreshContainer.RefreshRequestedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxRefreshRequested<T>(this T control, IObserver<Avalonia.Controls.RefreshRequestedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.RefreshContainer 
{
  control.AddHandler(Avalonia.Controls.RefreshContainer.RefreshRequestedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.RefreshContainer.RefreshRequestedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // PullDirection

/*ValueStyleSetterGenerator*/
public static Style<T> PullDirection<T>(this Style<T> style, Avalonia.Input.PullDirection value) where T : Avalonia.Controls.RefreshContainer 
=> style._addSetter(Avalonia.Controls.RefreshContainer.PullDirectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PullDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.RefreshContainer 
=> style._addSetter(Avalonia.Controls.RefreshContainer.PullDirectionProperty, binding);



}

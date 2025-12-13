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
public static partial class RefreshVisualizer_MarkupExtensions
{
//================= Properties ======================//
 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Controls.RefreshVisualizerOrientation value) where T : Avalonia.Controls.RefreshVisualizer 
{
    control.Orientation = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Controls.RefreshVisualizerOrientation> func) where T : Avalonia.Controls.RefreshVisualizer 
   => control._set(Avalonia.Controls.RefreshVisualizer.OrientationProperty!, func);

/*SetterFromObservableGenerator*/
public static T Orientation<T>(this T control, IObservable<Avalonia.Controls.RefreshVisualizerOrientation> obs) where T : Avalonia.Controls.RefreshVisualizer 
   => control._set(Avalonia.Controls.RefreshVisualizer.OrientationProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Orientation<T>(this T control, ISubject<Avalonia.Controls.RefreshVisualizerOrientation> subject) where T : Avalonia.Controls.RefreshVisualizer 
   => control._set(Avalonia.Controls.RefreshVisualizer.OrientationProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Orientation<T>(this T control, IObservable<Avalonia.Controls.RefreshVisualizerOrientation> obs, IObserver<Avalonia.Controls.RefreshVisualizerOrientation> changed) where T : Avalonia.Controls.RefreshVisualizer 
   => control._setEx(Avalonia.Controls.RefreshVisualizer.OrientationProperty!, obs, changed);



//================= Events ======================//
 // RefreshRequested

/*ActionToEventGenerator*/
public static T OnRefreshRequested<T>(this T control, Action<Avalonia.Controls.RefreshRequestedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.RefreshVisualizer 
{
  control.AddHandler(Avalonia.Controls.RefreshVisualizer.RefreshRequestedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.RefreshVisualizer.RefreshRequestedEvent.RoutingStrategies);
  return control;
}




}

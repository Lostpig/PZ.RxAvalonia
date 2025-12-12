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
public static partial class Spinner_MarkupExtensions
{
//================= Properties ======================//
 // ValidSpinDirection

/*ValueSetterGenerator*/
public static T ValidSpinDirection<T>(this T control, Avalonia.Controls.ValidSpinDirections value) where T : Avalonia.Controls.Spinner 
{
    control.ValidSpinDirection = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ValidSpinDirection<T>(this T control, Func<Avalonia.Controls.ValidSpinDirections> func) where T : Avalonia.Controls.Spinner 
   => control._set(Avalonia.Controls.Spinner.ValidSpinDirectionProperty!, func);

/*SetterFromObservableGenerator*/
public static T ValidSpinDirection<T>(this T control, IObservable<Avalonia.Controls.ValidSpinDirections> obs) where T : Avalonia.Controls.Spinner 
   => control._set(Avalonia.Controls.Spinner.ValidSpinDirectionProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ValidSpinDirection<T>(this T control, ISubject<Avalonia.Controls.ValidSpinDirections> subject) where T : Avalonia.Controls.Spinner 
   => control._set(Avalonia.Controls.Spinner.ValidSpinDirectionProperty!, subject);



//================= Events ======================//
 // Spin

/*ActionToEventGenerator*/
public static T OnSpin<T>(this T control, Action<Avalonia.Controls.SpinEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Spinner 
{
  control.AddHandler(Avalonia.Controls.Spinner.SpinEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Spinner.SpinEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // ValidSpinDirection

/*ValueStyleSetterGenerator*/
public static Style<T> ValidSpinDirection<T>(this Style<T> style, Avalonia.Controls.ValidSpinDirections value) where T : Avalonia.Controls.Spinner 
=> style._addSetter(Avalonia.Controls.Spinner.ValidSpinDirectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ValidSpinDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Spinner 
=> style._addSetter(Avalonia.Controls.Spinner.ValidSpinDirectionProperty, binding);



}

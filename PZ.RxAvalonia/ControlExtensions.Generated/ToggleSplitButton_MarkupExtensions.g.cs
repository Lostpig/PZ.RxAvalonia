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
public static partial class ToggleSplitButton_MarkupExtensions
{
//================= Properties ======================//
 // IsChecked

/*ValueSetterGenerator*/
public static T IsChecked<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ToggleSplitButton 
{
    control.IsChecked = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsChecked<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.ToggleSplitButton 
   => control._set(Avalonia.Controls.ToggleSplitButton.IsCheckedProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsChecked<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.ToggleSplitButton 
   => control._set(Avalonia.Controls.ToggleSplitButton.IsCheckedProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsChecked<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.ToggleSplitButton 
   => control._set(Avalonia.Controls.ToggleSplitButton.IsCheckedProperty!, subject);



//================= Events ======================//
 // IsCheckedChanged

/*ActionToEventGenerator*/
public static T OnIsCheckedChanged<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.ToggleSplitButton 
{
  control.AddHandler(Avalonia.Controls.ToggleSplitButton.IsCheckedChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.ToggleSplitButton.IsCheckedChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // IsChecked

/*ValueStyleSetterGenerator*/
public static Style<T> IsChecked<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ToggleSplitButton 
=> style._addSetter(Avalonia.Controls.ToggleSplitButton.IsCheckedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsChecked<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ToggleSplitButton 
=> style._addSetter(Avalonia.Controls.ToggleSplitButton.IsCheckedProperty, binding);



}

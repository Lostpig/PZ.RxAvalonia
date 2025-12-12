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
public static partial class SplitButton_MarkupExtensions
{
//================= Properties ======================//
 // Command

/*ValueSetterGenerator*/
public static T Command<T>(this T control, System.Windows.Input.ICommand value) where T : Avalonia.Controls.SplitButton 
{
    control.Command = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand> func) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.CommandProperty!, func);

/*SetterFromObservableGenerator*/
public static T Command<T>(this T control, IObservable<System.Windows.Input.ICommand> obs) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.CommandProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Command<T>(this T control, ISubject<System.Windows.Input.ICommand> subject) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.CommandProperty!, subject);


 // CommandParameter

/*ValueSetterGenerator*/
public static T CommandParameter<T>(this T control, System.Object value) where T : Avalonia.Controls.SplitButton 
{
    control.CommandParameter = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CommandParameter<T>(this T control, Func<System.Object> func) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.CommandParameterProperty!, func);

/*SetterFromObservableGenerator*/
public static T CommandParameter<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.CommandParameterProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CommandParameter<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.CommandParameterProperty!, subject);


 // Flyout

/*ValueSetterGenerator*/
public static T Flyout<T>(this T control, Avalonia.Controls.Primitives.FlyoutBase value) where T : Avalonia.Controls.SplitButton 
{
    control.Flyout = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Flyout<T>(this T control, Func<Avalonia.Controls.Primitives.FlyoutBase> func) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.FlyoutProperty!, func);

/*SetterFromObservableGenerator*/
public static T Flyout<T>(this T control, IObservable<Avalonia.Controls.Primitives.FlyoutBase> obs) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.FlyoutProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Flyout<T>(this T control, ISubject<Avalonia.Controls.Primitives.FlyoutBase> subject) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.FlyoutProperty!, subject);


 // HotKey

/*ValueSetterGenerator*/
public static T HotKey<T>(this T control, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.SplitButton 
{
    control.HotKey = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T HotKey<T>(this T control, Func<Avalonia.Input.KeyGesture> func) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.HotKeyProperty!, func);

/*SetterFromObservableGenerator*/
public static T HotKey<T>(this T control, IObservable<Avalonia.Input.KeyGesture> obs) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.HotKeyProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T HotKey<T>(this T control, ISubject<Avalonia.Input.KeyGesture> subject) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.HotKeyProperty!, subject);



//================= Events ======================//
 // Click

/*ActionToEventGenerator*/
public static T OnClick<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.SplitButton 
{
  control.AddHandler(Avalonia.Controls.SplitButton.ClickEvent, (_, args) => action(args), routes ?? Avalonia.Controls.SplitButton.ClickEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // Command

/*ValueStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, System.Windows.Input.ICommand value) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.CommandProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.CommandProperty, binding);


 // CommandParameter

/*ValueStyleSetterGenerator*/
public static Style<T> CommandParameter<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.CommandParameterProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CommandParameter<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.CommandParameterProperty, binding);


 // Flyout

/*ValueStyleSetterGenerator*/
public static Style<T> Flyout<T>(this Style<T> style, Avalonia.Controls.Primitives.FlyoutBase value) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.FlyoutProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Flyout<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.FlyoutProperty, binding);


 // HotKey

/*ValueStyleSetterGenerator*/
public static Style<T> HotKey<T>(this Style<T> style, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.HotKeyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HotKey<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.HotKeyProperty, binding);



}

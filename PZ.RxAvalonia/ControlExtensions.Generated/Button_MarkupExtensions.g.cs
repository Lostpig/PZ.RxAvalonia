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
public static partial class Button_MarkupExtensions
{
//================= Properties ======================//
 // ClickMode

/*ValueSetterGenerator*/
public static T ClickMode<T>(this T control, Avalonia.Controls.ClickMode value) where T : Avalonia.Controls.Button 
{
    control.ClickMode = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ClickMode<T>(this T control, Func<Avalonia.Controls.ClickMode> func) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.ClickModeProperty!, func);

/*SetterFromObservableGenerator*/
public static T ClickMode<T>(this T control, IObservable<Avalonia.Controls.ClickMode> obs) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.ClickModeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ClickMode<T>(this T control, ISubject<Avalonia.Controls.ClickMode> subject) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.ClickModeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ClickMode<T>(this T control, IObservable<Avalonia.Controls.ClickMode> obs, IObserver<Avalonia.Controls.ClickMode> changed) where T : Avalonia.Controls.Button 
   => control._setEx(Avalonia.Controls.Button.ClickModeProperty!, obs, changed);


 // Command

/*ValueSetterGenerator*/
public static T Command<T>(this T control, System.Windows.Input.ICommand value) where T : Avalonia.Controls.Button 
{
    control.Command = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand> func) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.CommandProperty!, func);

/*SetterFromObservableGenerator*/
public static T Command<T>(this T control, IObservable<System.Windows.Input.ICommand> obs) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.CommandProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Command<T>(this T control, ISubject<System.Windows.Input.ICommand> subject) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.CommandProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Command<T>(this T control, IObservable<System.Windows.Input.ICommand> obs, IObserver<System.Windows.Input.ICommand> changed) where T : Avalonia.Controls.Button 
   => control._setEx(Avalonia.Controls.Button.CommandProperty!, obs, changed);


 // HotKey

/*ValueSetterGenerator*/
public static T HotKey<T>(this T control, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.Button 
{
    control.HotKey = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T HotKey<T>(this T control, Func<Avalonia.Input.KeyGesture> func) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.HotKeyProperty!, func);

/*SetterFromObservableGenerator*/
public static T HotKey<T>(this T control, IObservable<Avalonia.Input.KeyGesture> obs) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.HotKeyProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T HotKey<T>(this T control, ISubject<Avalonia.Input.KeyGesture> subject) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.HotKeyProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T HotKey<T>(this T control, IObservable<Avalonia.Input.KeyGesture> obs, IObserver<Avalonia.Input.KeyGesture> changed) where T : Avalonia.Controls.Button 
   => control._setEx(Avalonia.Controls.Button.HotKeyProperty!, obs, changed);


 // CommandParameter

/*ValueSetterGenerator*/
public static T CommandParameter<T>(this T control, System.Object value) where T : Avalonia.Controls.Button 
{
    control.CommandParameter = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CommandParameter<T>(this T control, Func<System.Object> func) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.CommandParameterProperty!, func);

/*SetterFromObservableGenerator*/
public static T CommandParameter<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.CommandParameterProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CommandParameter<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.CommandParameterProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T CommandParameter<T>(this T control, IObservable<System.Object> obs, IObserver<System.Object> changed) where T : Avalonia.Controls.Button 
   => control._setEx(Avalonia.Controls.Button.CommandParameterProperty!, obs, changed);


 // IsDefault

/*ValueSetterGenerator*/
public static T IsDefault<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Button 
{
    control.IsDefault = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsDefault<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.IsDefaultProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsDefault<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.IsDefaultProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsDefault<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.IsDefaultProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsDefault<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Button 
   => control._setEx(Avalonia.Controls.Button.IsDefaultProperty!, obs, changed);


 // IsCancel

/*ValueSetterGenerator*/
public static T IsCancel<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Button 
{
    control.IsCancel = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsCancel<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.IsCancelProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsCancel<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.IsCancelProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsCancel<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.IsCancelProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsCancel<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Button 
   => control._setEx(Avalonia.Controls.Button.IsCancelProperty!, obs, changed);


 // Flyout

/*ValueSetterGenerator*/
public static T Flyout<T>(this T control, Avalonia.Controls.Primitives.FlyoutBase value) where T : Avalonia.Controls.Button 
{
    control.Flyout = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Flyout<T>(this T control, Func<Avalonia.Controls.Primitives.FlyoutBase> func) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.FlyoutProperty!, func);

/*SetterFromObservableGenerator*/
public static T Flyout<T>(this T control, IObservable<Avalonia.Controls.Primitives.FlyoutBase> obs) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.FlyoutProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Flyout<T>(this T control, ISubject<Avalonia.Controls.Primitives.FlyoutBase> subject) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.FlyoutProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Flyout<T>(this T control, IObservable<Avalonia.Controls.Primitives.FlyoutBase> obs, IObserver<Avalonia.Controls.Primitives.FlyoutBase> changed) where T : Avalonia.Controls.Button 
   => control._setEx(Avalonia.Controls.Button.FlyoutProperty!, obs, changed);



//================= Events ======================//
 // Click

/*ActionToEventGenerator*/
public static T OnClick<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Button 
{
  control.AddHandler(Avalonia.Controls.Button.ClickEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Button.ClickEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // ClickMode

/*ValueStyleSetterGenerator*/
public static Style<T> ClickMode<T>(this Style<T> style, Avalonia.Controls.ClickMode value) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.ClickModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ClickMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.ClickModeProperty, binding);


 // Command

/*ValueStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, System.Windows.Input.ICommand value) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.CommandProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.CommandProperty, binding);


 // HotKey

/*ValueStyleSetterGenerator*/
public static Style<T> HotKey<T>(this Style<T> style, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.HotKeyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HotKey<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.HotKeyProperty, binding);


 // CommandParameter

/*ValueStyleSetterGenerator*/
public static Style<T> CommandParameter<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.CommandParameterProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CommandParameter<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.CommandParameterProperty, binding);


 // IsDefault

/*ValueStyleSetterGenerator*/
public static Style<T> IsDefault<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.IsDefaultProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDefault<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.IsDefaultProperty, binding);


 // IsCancel

/*ValueStyleSetterGenerator*/
public static Style<T> IsCancel<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.IsCancelProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsCancel<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.IsCancelProperty, binding);


 // Flyout

/*ValueStyleSetterGenerator*/
public static Style<T> Flyout<T>(this Style<T> style, Avalonia.Controls.Primitives.FlyoutBase value) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.FlyoutProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Flyout<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.FlyoutProperty, binding);



}

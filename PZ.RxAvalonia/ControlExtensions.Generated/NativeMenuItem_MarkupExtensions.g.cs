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
public static partial class NativeMenuItem_MarkupExtensions
{
//================= Properties ======================//
 // Menu

/*ValueSetterGenerator*/
public static T Menu<T>(this T control, Avalonia.Controls.NativeMenu value) where T : Avalonia.Controls.NativeMenuItem 
{
    control.Menu = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Menu<T>(this T control, Func<Avalonia.Controls.NativeMenu> func) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.MenuProperty!, func);

/*SetterFromObservableGenerator*/
public static T Menu<T>(this T control, IObservable<Avalonia.Controls.NativeMenu> obs) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.MenuProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Menu<T>(this T control, ISubject<Avalonia.Controls.NativeMenu> subject) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.MenuProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Menu<T>(this T control, IObservable<Avalonia.Controls.NativeMenu> obs, IObserver<Avalonia.Controls.NativeMenu> changed) where T : Avalonia.Controls.NativeMenuItem 
   => control._setEx(Avalonia.Controls.NativeMenuItem.MenuProperty!, obs, changed);


 // Icon

/*ValueSetterGenerator*/
public static T Icon<T>(this T control, Avalonia.Media.Imaging.Bitmap value) where T : Avalonia.Controls.NativeMenuItem 
{
    control.Icon = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Icon<T>(this T control, Func<Avalonia.Media.Imaging.Bitmap> func) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IconProperty!, func);

/*SetterFromObservableGenerator*/
public static T Icon<T>(this T control, IObservable<Avalonia.Media.Imaging.Bitmap> obs) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IconProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Icon<T>(this T control, ISubject<Avalonia.Media.Imaging.Bitmap> subject) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IconProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Icon<T>(this T control, IObservable<Avalonia.Media.Imaging.Bitmap> obs, IObserver<Avalonia.Media.Imaging.Bitmap> changed) where T : Avalonia.Controls.NativeMenuItem 
   => control._setEx(Avalonia.Controls.NativeMenuItem.IconProperty!, obs, changed);


 // Header

/*ValueSetterGenerator*/
public static T Header<T>(this T control, System.String value) where T : Avalonia.Controls.NativeMenuItem 
{
    control.Header = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Header<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.HeaderProperty!, func);

/*SetterFromObservableGenerator*/
public static T Header<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.HeaderProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Header<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.HeaderProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Header<T>(this T control, IObservable<System.String> obs, IObserver<System.String> changed) where T : Avalonia.Controls.NativeMenuItem 
   => control._setEx(Avalonia.Controls.NativeMenuItem.HeaderProperty!, obs, changed);


 // ToolTip

/*ValueSetterGenerator*/
public static T ToolTip<T>(this T control, System.String value) where T : Avalonia.Controls.NativeMenuItem 
{
    control.ToolTip = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ToolTip<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.ToolTipProperty!, func);

/*SetterFromObservableGenerator*/
public static T ToolTip<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.ToolTipProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ToolTip<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.ToolTipProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ToolTip<T>(this T control, IObservable<System.String> obs, IObserver<System.String> changed) where T : Avalonia.Controls.NativeMenuItem 
   => control._setEx(Avalonia.Controls.NativeMenuItem.ToolTipProperty!, obs, changed);


 // Gesture

/*ValueSetterGenerator*/
public static T Gesture<T>(this T control, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.NativeMenuItem 
{
    control.Gesture = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Gesture<T>(this T control, Func<Avalonia.Input.KeyGesture> func) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.GestureProperty!, func);

/*SetterFromObservableGenerator*/
public static T Gesture<T>(this T control, IObservable<Avalonia.Input.KeyGesture> obs) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.GestureProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Gesture<T>(this T control, ISubject<Avalonia.Input.KeyGesture> subject) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.GestureProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Gesture<T>(this T control, IObservable<Avalonia.Input.KeyGesture> obs, IObserver<Avalonia.Input.KeyGesture> changed) where T : Avalonia.Controls.NativeMenuItem 
   => control._setEx(Avalonia.Controls.NativeMenuItem.GestureProperty!, obs, changed);


 // IsChecked

/*ValueSetterGenerator*/
public static T IsChecked<T>(this T control, System.Boolean value) where T : Avalonia.Controls.NativeMenuItem 
{
    control.IsChecked = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsChecked<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsCheckedProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsChecked<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsCheckedProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsChecked<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsCheckedProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsChecked<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.NativeMenuItem 
   => control._setEx(Avalonia.Controls.NativeMenuItem.IsCheckedProperty!, obs, changed);


 // ToggleType

/*ValueSetterGenerator*/
public static T ToggleType<T>(this T control, Avalonia.Controls.NativeMenuItemToggleType value) where T : Avalonia.Controls.NativeMenuItem 
{
    control.ToggleType = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ToggleType<T>(this T control, Func<Avalonia.Controls.NativeMenuItemToggleType> func) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.ToggleTypeProperty!, func);

/*SetterFromObservableGenerator*/
public static T ToggleType<T>(this T control, IObservable<Avalonia.Controls.NativeMenuItemToggleType> obs) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.ToggleTypeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ToggleType<T>(this T control, ISubject<Avalonia.Controls.NativeMenuItemToggleType> subject) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.ToggleTypeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ToggleType<T>(this T control, IObservable<Avalonia.Controls.NativeMenuItemToggleType> obs, IObserver<Avalonia.Controls.NativeMenuItemToggleType> changed) where T : Avalonia.Controls.NativeMenuItem 
   => control._setEx(Avalonia.Controls.NativeMenuItem.ToggleTypeProperty!, obs, changed);


 // Command

/*ValueSetterGenerator*/
public static T Command<T>(this T control, System.Windows.Input.ICommand value) where T : Avalonia.Controls.NativeMenuItem 
{
    control.Command = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand> func) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.CommandProperty!, func);

/*SetterFromObservableGenerator*/
public static T Command<T>(this T control, IObservable<System.Windows.Input.ICommand> obs) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.CommandProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Command<T>(this T control, ISubject<System.Windows.Input.ICommand> subject) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.CommandProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Command<T>(this T control, IObservable<System.Windows.Input.ICommand> obs, IObserver<System.Windows.Input.ICommand> changed) where T : Avalonia.Controls.NativeMenuItem 
   => control._setEx(Avalonia.Controls.NativeMenuItem.CommandProperty!, obs, changed);


 // CommandParameter

/*ValueSetterGenerator*/
public static T CommandParameter<T>(this T control, System.Object value) where T : Avalonia.Controls.NativeMenuItem 
{
    control.CommandParameter = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CommandParameter<T>(this T control, Func<System.Object> func) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.CommandParameterProperty!, func);

/*SetterFromObservableGenerator*/
public static T CommandParameter<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.CommandParameterProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CommandParameter<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.CommandParameterProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T CommandParameter<T>(this T control, IObservable<System.Object> obs, IObserver<System.Object> changed) where T : Avalonia.Controls.NativeMenuItem 
   => control._setEx(Avalonia.Controls.NativeMenuItem.CommandParameterProperty!, obs, changed);


 // IsEnabled

/*ValueSetterGenerator*/
public static T IsEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.NativeMenuItem 
{
    control.IsEnabled = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsEnabled<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsEnabledProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsEnabledProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsEnabledProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsEnabled<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.NativeMenuItem 
   => control._setEx(Avalonia.Controls.NativeMenuItem.IsEnabledProperty!, obs, changed);


 // IsVisible

/*ValueSetterGenerator*/
public static T IsVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.NativeMenuItem 
{
    control.IsVisible = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsVisible<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsVisibleProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsVisible<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsVisibleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsVisible<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsVisibleProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsVisible<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.NativeMenuItem 
   => control._setEx(Avalonia.Controls.NativeMenuItem.IsVisibleProperty!, obs, changed);



//================= Events ======================//
 // Click

/*ActionToEventGenerator*/
public static T OnClick<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.NativeMenuItem  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Click += h);

/*ReactiveEventGenerator*/
public static T RxClick<T>(this T control, IObserver<System.EventArgs> observer) where T : Avalonia.Controls.NativeMenuItem  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => observer.OnNext((arg1))), h => control.Click += h);



}

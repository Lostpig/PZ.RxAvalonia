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
public static partial class KeyBinding_MarkupExtensions
{
//================= Properties ======================//
 // Command

/*ValueSetterGenerator*/
public static T Command<T>(this T control, System.Windows.Input.ICommand value) where T : Avalonia.Input.KeyBinding 
{
    control.Command = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand> func) where T : Avalonia.Input.KeyBinding 
   => control._set(Avalonia.Input.KeyBinding.CommandProperty!, func);

/*SetterFromObservableGenerator*/
public static T Command<T>(this T control, IObservable<System.Windows.Input.ICommand> obs) where T : Avalonia.Input.KeyBinding 
   => control._set(Avalonia.Input.KeyBinding.CommandProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Command<T>(this T control, ISubject<System.Windows.Input.ICommand> subject) where T : Avalonia.Input.KeyBinding 
   => control._set(Avalonia.Input.KeyBinding.CommandProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Command<T>(this T control, IObservable<System.Windows.Input.ICommand> obs, IObserver<System.Windows.Input.ICommand> changed) where T : Avalonia.Input.KeyBinding 
   => control._setEx(Avalonia.Input.KeyBinding.CommandProperty!, obs, changed);


 // CommandParameter

/*ValueSetterGenerator*/
public static T CommandParameter<T>(this T control, System.Object value) where T : Avalonia.Input.KeyBinding 
{
    control.CommandParameter = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CommandParameter<T>(this T control, Func<System.Object> func) where T : Avalonia.Input.KeyBinding 
   => control._set(Avalonia.Input.KeyBinding.CommandParameterProperty!, func);

/*SetterFromObservableGenerator*/
public static T CommandParameter<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.Input.KeyBinding 
   => control._set(Avalonia.Input.KeyBinding.CommandParameterProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CommandParameter<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.Input.KeyBinding 
   => control._set(Avalonia.Input.KeyBinding.CommandParameterProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T CommandParameter<T>(this T control, IObservable<System.Object> obs, IObserver<System.Object> changed) where T : Avalonia.Input.KeyBinding 
   => control._setEx(Avalonia.Input.KeyBinding.CommandParameterProperty!, obs, changed);


 // Gesture

/*ValueSetterGenerator*/
public static T Gesture<T>(this T control, Avalonia.Input.KeyGesture value) where T : Avalonia.Input.KeyBinding 
{
    control.Gesture = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Gesture<T>(this T control, Func<Avalonia.Input.KeyGesture> func) where T : Avalonia.Input.KeyBinding 
   => control._set(Avalonia.Input.KeyBinding.GestureProperty!, func);

/*SetterFromObservableGenerator*/
public static T Gesture<T>(this T control, IObservable<Avalonia.Input.KeyGesture> obs) where T : Avalonia.Input.KeyBinding 
   => control._set(Avalonia.Input.KeyBinding.GestureProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Gesture<T>(this T control, ISubject<Avalonia.Input.KeyGesture> subject) where T : Avalonia.Input.KeyBinding 
   => control._set(Avalonia.Input.KeyBinding.GestureProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Gesture<T>(this T control, IObservable<Avalonia.Input.KeyGesture> obs, IObserver<Avalonia.Input.KeyGesture> changed) where T : Avalonia.Input.KeyBinding 
   => control._setEx(Avalonia.Input.KeyBinding.GestureProperty!, obs, changed);



}

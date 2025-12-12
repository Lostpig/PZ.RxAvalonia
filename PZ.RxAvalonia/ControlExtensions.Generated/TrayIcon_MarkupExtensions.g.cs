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
public static partial class TrayIcon_MarkupExtensions
{
//================= Properties ======================//
 // Command

/*ValueSetterGenerator*/
public static T Command<T>(this T control, System.Windows.Input.ICommand value) where T : Avalonia.Controls.TrayIcon 
{
    control.Command = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand> func) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.CommandProperty!, func);

/*SetterFromObservableGenerator*/
public static T Command<T>(this T control, IObservable<System.Windows.Input.ICommand> obs) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.CommandProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Command<T>(this T control, ISubject<System.Windows.Input.ICommand> subject) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.CommandProperty!, subject);


 // CommandParameter

/*ValueSetterGenerator*/
public static T CommandParameter<T>(this T control, System.Object value) where T : Avalonia.Controls.TrayIcon 
{
    control.CommandParameter = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CommandParameter<T>(this T control, Func<System.Object> func) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.CommandParameterProperty!, func);

/*SetterFromObservableGenerator*/
public static T CommandParameter<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.CommandParameterProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CommandParameter<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.CommandParameterProperty!, subject);


 // Menu

/*ValueSetterGenerator*/
public static T Menu<T>(this T control, Avalonia.Controls.NativeMenu value) where T : Avalonia.Controls.TrayIcon 
{
    control.Menu = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Menu<T>(this T control, Func<Avalonia.Controls.NativeMenu> func) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.MenuProperty!, func);

/*SetterFromObservableGenerator*/
public static T Menu<T>(this T control, IObservable<Avalonia.Controls.NativeMenu> obs) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.MenuProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Menu<T>(this T control, ISubject<Avalonia.Controls.NativeMenu> subject) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.MenuProperty!, subject);


 // Icon

/*ValueSetterGenerator*/
public static T Icon<T>(this T control, Avalonia.Controls.WindowIcon value) where T : Avalonia.Controls.TrayIcon 
{
    control.Icon = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Icon<T>(this T control, Func<Avalonia.Controls.WindowIcon> func) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.IconProperty!, func);

/*SetterFromObservableGenerator*/
public static T Icon<T>(this T control, IObservable<Avalonia.Controls.WindowIcon> obs) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.IconProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Icon<T>(this T control, ISubject<Avalonia.Controls.WindowIcon> subject) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.IconProperty!, subject);


 // ToolTipText

/*ValueSetterGenerator*/
public static T ToolTipText<T>(this T control, System.String value) where T : Avalonia.Controls.TrayIcon 
{
    control.ToolTipText = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ToolTipText<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.ToolTipTextProperty!, func);

/*SetterFromObservableGenerator*/
public static T ToolTipText<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.ToolTipTextProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ToolTipText<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.ToolTipTextProperty!, subject);


 // IsVisible

/*ValueSetterGenerator*/
public static T IsVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TrayIcon 
{
    control.IsVisible = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsVisible<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.IsVisibleProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsVisible<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.IsVisibleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsVisible<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.IsVisibleProperty!, subject);



//================= Attached Properties ======================//
 // Icons

/*AttachedPropertyFuncGenerator*/
public static T TrayIcon_Icons<T>(this T control, Func<Avalonia.Controls.TrayIcons> getter) where T : Avalonia.Application 
   => control._set(Avalonia.Controls.TrayIcon.IconsProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T TrayIcon_Icons<T>(this T control, IObservable<Avalonia.Controls.TrayIcons> obs) where T : Avalonia.Application 
   => control._set(Avalonia.Controls.TrayIcon.IconsProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T TrayIcon_Icons<T>(this T control, ISubject<Avalonia.Controls.TrayIcons> subject) where T : Avalonia.Application 
   => control._set(Avalonia.Controls.TrayIcon.IconsProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T TrayIcon_Icons<T>(this T control, Avalonia.Controls.TrayIcons value) where T : Avalonia.Application 
{
    control.SetValue(Avalonia.Controls.TrayIcon.IconsProperty!, value);
    return control;
}



//================= Events ======================//
 // Clicked

/*ActionToEventGenerator*/
public static T OnClicked<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.TrayIcon  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Clicked += h);



}

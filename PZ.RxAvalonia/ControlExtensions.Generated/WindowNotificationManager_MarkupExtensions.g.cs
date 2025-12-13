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
public static partial class WindowNotificationManager_MarkupExtensions
{
//================= Properties ======================//
 // Position

/*ValueSetterGenerator*/
public static T Position<T>(this T control, Avalonia.Controls.Notifications.NotificationPosition value) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
{
    control.Position = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Position<T>(this T control, Func<Avalonia.Controls.Notifications.NotificationPosition> func) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
   => control._set(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty!, func);

/*SetterFromObservableGenerator*/
public static T Position<T>(this T control, IObservable<Avalonia.Controls.Notifications.NotificationPosition> obs) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
   => control._set(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Position<T>(this T control, ISubject<Avalonia.Controls.Notifications.NotificationPosition> subject) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
   => control._set(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Position<T>(this T control, IObservable<Avalonia.Controls.Notifications.NotificationPosition> obs, IObserver<Avalonia.Controls.Notifications.NotificationPosition> changed) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
   => control._setEx(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty!, obs, changed);


 // MaxItems

/*ValueSetterGenerator*/
public static T MaxItems<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
{
    control.MaxItems = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MaxItems<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
   => control._set(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty!, func);

/*SetterFromObservableGenerator*/
public static T MaxItems<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
   => control._set(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MaxItems<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
   => control._set(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T MaxItems<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
   => control._setEx(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty!, obs, changed);



//================= Styles ======================//
 // Position

/*ValueStyleSetterGenerator*/
public static Style<T> Position<T>(this Style<T> style, Avalonia.Controls.Notifications.NotificationPosition value) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
=> style._addSetter(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Position<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
=> style._addSetter(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty, binding);


 // MaxItems

/*ValueStyleSetterGenerator*/
public static Style<T> MaxItems<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
=> style._addSetter(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxItems<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
=> style._addSetter(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty, binding);



}

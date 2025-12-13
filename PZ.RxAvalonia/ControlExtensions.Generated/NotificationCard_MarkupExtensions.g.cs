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
public static partial class NotificationCard_MarkupExtensions
{
//================= Properties ======================//
 // IsClosed

/*ValueSetterGenerator*/
public static T IsClosed<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Notifications.NotificationCard 
{
    control.IsClosed = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsClosed<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Notifications.NotificationCard 
   => control._set(Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsClosed<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Notifications.NotificationCard 
   => control._set(Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsClosed<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Notifications.NotificationCard 
   => control._set(Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsClosed<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Notifications.NotificationCard 
   => control._setEx(Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty!, obs, changed);


 // NotificationType

/*ValueSetterGenerator*/
public static T NotificationType<T>(this T control, Avalonia.Controls.Notifications.NotificationType value) where T : Avalonia.Controls.Notifications.NotificationCard 
{
    control.NotificationType = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T NotificationType<T>(this T control, Func<Avalonia.Controls.Notifications.NotificationType> func) where T : Avalonia.Controls.Notifications.NotificationCard 
   => control._set(Avalonia.Controls.Notifications.NotificationCard.NotificationTypeProperty!, func);

/*SetterFromObservableGenerator*/
public static T NotificationType<T>(this T control, IObservable<Avalonia.Controls.Notifications.NotificationType> obs) where T : Avalonia.Controls.Notifications.NotificationCard 
   => control._set(Avalonia.Controls.Notifications.NotificationCard.NotificationTypeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T NotificationType<T>(this T control, ISubject<Avalonia.Controls.Notifications.NotificationType> subject) where T : Avalonia.Controls.Notifications.NotificationCard 
   => control._set(Avalonia.Controls.Notifications.NotificationCard.NotificationTypeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T NotificationType<T>(this T control, IObservable<Avalonia.Controls.Notifications.NotificationType> obs, IObserver<Avalonia.Controls.Notifications.NotificationType> changed) where T : Avalonia.Controls.Notifications.NotificationCard 
   => control._setEx(Avalonia.Controls.Notifications.NotificationCard.NotificationTypeProperty!, obs, changed);



//================= Attached Properties ======================//
 // CloseOnClick

/*AttachedPropertyFuncGenerator*/
public static T NotificationCard_CloseOnClick<T>(this T control, Func<System.Boolean> getter) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T NotificationCard_CloseOnClick<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T NotificationCard_CloseOnClick<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T NotificationCard_CloseOnClick<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Button 
{
    control.SetValue(Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T NotificationCard_CloseOnClick<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Button 
   => control._setEx(Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty!, obs, changed);



//================= Events ======================//
 // NotificationClosed

/*ActionToEventGenerator*/
public static T OnNotificationClosed<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Notifications.NotificationCard 
{
  control.AddHandler(Avalonia.Controls.Notifications.NotificationCard.NotificationClosedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Notifications.NotificationCard.NotificationClosedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // IsClosed

/*ValueStyleSetterGenerator*/
public static Style<T> IsClosed<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Notifications.NotificationCard 
=> style._addSetter(Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsClosed<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Notifications.NotificationCard 
=> style._addSetter(Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty, binding);


 // NotificationType

/*ValueStyleSetterGenerator*/
public static Style<T> NotificationType<T>(this Style<T> style, Avalonia.Controls.Notifications.NotificationType value) where T : Avalonia.Controls.Notifications.NotificationCard 
=> style._addSetter(Avalonia.Controls.Notifications.NotificationCard.NotificationTypeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> NotificationType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Notifications.NotificationCard 
=> style._addSetter(Avalonia.Controls.Notifications.NotificationCard.NotificationTypeProperty, binding);



}

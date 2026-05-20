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
public static partial class NavigationPage_MarkupExtensions
{
//================= Properties ======================//
 // Content

/*ValueSetterGenerator*/
public static T Content<T>(this T control, System.Object? value) where T : Avalonia.Controls.NavigationPage 
{
    control.Content = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Content<T>(this T control, Func<System.Object?> func) where T : Avalonia.Controls.NavigationPage 
   => control._set(Avalonia.Controls.NavigationPage.ContentProperty!, func);

/*SetterFromObservableGenerator*/
public static T Content<T>(this T control, IObservable<System.Object?> obs) where T : Avalonia.Controls.NavigationPage 
   => control._set(Avalonia.Controls.NavigationPage.ContentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Content<T>(this T control, ISubject<System.Object?> subject) where T : Avalonia.Controls.NavigationPage 
   => control._set(Avalonia.Controls.NavigationPage.ContentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Content<T>(this T control, IObservable<System.Object?> obs, IObserver<System.Object?> changed) where T : Avalonia.Controls.NavigationPage 
   => control._setEx(Avalonia.Controls.NavigationPage.ContentProperty!, obs, changed);


 // PageTransition

/*ValueSetterGenerator*/
public static T PageTransition<T>(this T control, Avalonia.Animation.IPageTransition? value) where T : Avalonia.Controls.NavigationPage 
{
    control.PageTransition = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PageTransition<T>(this T control, Func<Avalonia.Animation.IPageTransition?> func) where T : Avalonia.Controls.NavigationPage 
   => control._set(Avalonia.Controls.NavigationPage.PageTransitionProperty!, func);

/*SetterFromObservableGenerator*/
public static T PageTransition<T>(this T control, IObservable<Avalonia.Animation.IPageTransition?> obs) where T : Avalonia.Controls.NavigationPage 
   => control._set(Avalonia.Controls.NavigationPage.PageTransitionProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PageTransition<T>(this T control, ISubject<Avalonia.Animation.IPageTransition?> subject) where T : Avalonia.Controls.NavigationPage 
   => control._set(Avalonia.Controls.NavigationPage.PageTransitionProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T PageTransition<T>(this T control, IObservable<Avalonia.Animation.IPageTransition?> obs, IObserver<Avalonia.Animation.IPageTransition?> changed) where T : Avalonia.Controls.NavigationPage 
   => control._setEx(Avalonia.Controls.NavigationPage.PageTransitionProperty!, obs, changed);


 // ModalTransition

/*ValueSetterGenerator*/
public static T ModalTransition<T>(this T control, Avalonia.Animation.IPageTransition? value) where T : Avalonia.Controls.NavigationPage 
{
    control.ModalTransition = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ModalTransition<T>(this T control, Func<Avalonia.Animation.IPageTransition?> func) where T : Avalonia.Controls.NavigationPage 
   => control._set(Avalonia.Controls.NavigationPage.ModalTransitionProperty!, func);

/*SetterFromObservableGenerator*/
public static T ModalTransition<T>(this T control, IObservable<Avalonia.Animation.IPageTransition?> obs) where T : Avalonia.Controls.NavigationPage 
   => control._set(Avalonia.Controls.NavigationPage.ModalTransitionProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ModalTransition<T>(this T control, ISubject<Avalonia.Animation.IPageTransition?> subject) where T : Avalonia.Controls.NavigationPage 
   => control._set(Avalonia.Controls.NavigationPage.ModalTransitionProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ModalTransition<T>(this T control, IObservable<Avalonia.Animation.IPageTransition?> obs, IObserver<Avalonia.Animation.IPageTransition?> changed) where T : Avalonia.Controls.NavigationPage 
   => control._setEx(Avalonia.Controls.NavigationPage.ModalTransitionProperty!, obs, changed);


 // HasShadow

/*ValueSetterGenerator*/
public static T HasShadow<T>(this T control, System.Boolean value) where T : Avalonia.Controls.NavigationPage 
{
    control.HasShadow = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T HasShadow<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.NavigationPage 
   => control._set(Avalonia.Controls.NavigationPage.HasShadowProperty!, func);

/*SetterFromObservableGenerator*/
public static T HasShadow<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.NavigationPage 
   => control._set(Avalonia.Controls.NavigationPage.HasShadowProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T HasShadow<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.NavigationPage 
   => control._set(Avalonia.Controls.NavigationPage.HasShadowProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T HasShadow<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.NavigationPage 
   => control._setEx(Avalonia.Controls.NavigationPage.HasShadowProperty!, obs, changed);


 // BarHeight

/*ValueSetterGenerator*/
public static T BarHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.NavigationPage 
{
    control.BarHeight = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T BarHeight<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.NavigationPage 
   => control._set(Avalonia.Controls.NavigationPage.BarHeightProperty!, func);

/*SetterFromObservableGenerator*/
public static T BarHeight<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.NavigationPage 
   => control._set(Avalonia.Controls.NavigationPage.BarHeightProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T BarHeight<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.NavigationPage 
   => control._set(Avalonia.Controls.NavigationPage.BarHeightProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T BarHeight<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.NavigationPage 
   => control._setEx(Avalonia.Controls.NavigationPage.BarHeightProperty!, obs, changed);


 // IsBackButtonVisible

/*ValueSetterGenerator*/
public static T IsBackButtonVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.NavigationPage 
{
    control.IsBackButtonVisible = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsBackButtonVisible<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.NavigationPage 
   => control._set(Avalonia.Controls.NavigationPage.IsBackButtonVisibleProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsBackButtonVisible<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.NavigationPage 
   => control._set(Avalonia.Controls.NavigationPage.IsBackButtonVisibleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsBackButtonVisible<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.NavigationPage 
   => control._set(Avalonia.Controls.NavigationPage.IsBackButtonVisibleProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsBackButtonVisible<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.NavigationPage 
   => control._setEx(Avalonia.Controls.NavigationPage.IsBackButtonVisibleProperty!, obs, changed);


 // IsGestureEnabled

/*ValueSetterGenerator*/
public static T IsGestureEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.NavigationPage 
{
    control.IsGestureEnabled = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsGestureEnabled<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.NavigationPage 
   => control._set(Avalonia.Controls.NavigationPage.IsGestureEnabledProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsGestureEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.NavigationPage 
   => control._set(Avalonia.Controls.NavigationPage.IsGestureEnabledProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsGestureEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.NavigationPage 
   => control._set(Avalonia.Controls.NavigationPage.IsGestureEnabledProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsGestureEnabled<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.NavigationPage 
   => control._setEx(Avalonia.Controls.NavigationPage.IsGestureEnabledProperty!, obs, changed);



//================= Attached Properties ======================//
 // BarLayoutBehavior

/*AttachedPropertyFuncGenerator*/
public static T NavigationPage_BarLayoutBehavior<T>(this T control, Func<System.Nullable<Avalonia.Controls.BarLayoutBehavior>> getter) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.NavigationPage.BarLayoutBehaviorProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T NavigationPage_BarLayoutBehavior<T>(this T control, IObservable<System.Nullable<Avalonia.Controls.BarLayoutBehavior>> obs) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.NavigationPage.BarLayoutBehaviorProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T NavigationPage_BarLayoutBehavior<T>(this T control, ISubject<System.Nullable<Avalonia.Controls.BarLayoutBehavior>> subject) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.NavigationPage.BarLayoutBehaviorProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T NavigationPage_BarLayoutBehavior<T>(this T control, System.Nullable<Avalonia.Controls.BarLayoutBehavior> value) where T : Avalonia.Controls.Page 
{
    control.SetValue(Avalonia.Controls.NavigationPage.BarLayoutBehaviorProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T NavigationPage_BarLayoutBehavior<T>(this T control, IObservable<System.Nullable<Avalonia.Controls.BarLayoutBehavior>> obs, IObserver<System.Nullable<Avalonia.Controls.BarLayoutBehavior>> changed) where T : Avalonia.Controls.Page 
   => control._setEx(Avalonia.Controls.NavigationPage.BarLayoutBehaviorProperty!, obs, changed);


 // BarHeightOverride

/*AttachedPropertyFuncGenerator*/
public static T NavigationPage_BarHeightOverride<T>(this T control, Func<System.Nullable<System.Double>> getter) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.NavigationPage.BarHeightOverrideProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T NavigationPage_BarHeightOverride<T>(this T control, IObservable<System.Nullable<System.Double>> obs) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.NavigationPage.BarHeightOverrideProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T NavigationPage_BarHeightOverride<T>(this T control, ISubject<System.Nullable<System.Double>> subject) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.NavigationPage.BarHeightOverrideProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T NavigationPage_BarHeightOverride<T>(this T control, System.Nullable<System.Double> value) where T : Avalonia.Controls.Page 
{
    control.SetValue(Avalonia.Controls.NavigationPage.BarHeightOverrideProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T NavigationPage_BarHeightOverride<T>(this T control, IObservable<System.Nullable<System.Double>> obs, IObserver<System.Nullable<System.Double>> changed) where T : Avalonia.Controls.Page 
   => control._setEx(Avalonia.Controls.NavigationPage.BarHeightOverrideProperty!, obs, changed);


 // BackButtonContent

/*AttachedPropertyFuncGenerator*/
public static T NavigationPage_BackButtonContent<T>(this T control, Func<System.Object?> getter) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.NavigationPage.BackButtonContentProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T NavigationPage_BackButtonContent<T>(this T control, IObservable<System.Object?> obs) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.NavigationPage.BackButtonContentProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T NavigationPage_BackButtonContent<T>(this T control, ISubject<System.Object?> subject) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.NavigationPage.BackButtonContentProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T NavigationPage_BackButtonContent<T>(this T control, System.Object? value) where T : Avalonia.Controls.Page 
{
    control.SetValue(Avalonia.Controls.NavigationPage.BackButtonContentProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T NavigationPage_BackButtonContent<T>(this T control, IObservable<System.Object?> obs, IObserver<System.Object?> changed) where T : Avalonia.Controls.Page 
   => control._setEx(Avalonia.Controls.NavigationPage.BackButtonContentProperty!, obs, changed);


 // HasBackButton

/*AttachedPropertyFuncGenerator*/
public static T NavigationPage_HasBackButton<T>(this T control, Func<System.Boolean> getter) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.NavigationPage.HasBackButtonProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T NavigationPage_HasBackButton<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.NavigationPage.HasBackButtonProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T NavigationPage_HasBackButton<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.NavigationPage.HasBackButtonProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T NavigationPage_HasBackButton<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Page 
{
    control.SetValue(Avalonia.Controls.NavigationPage.HasBackButtonProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T NavigationPage_HasBackButton<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Page 
   => control._setEx(Avalonia.Controls.NavigationPage.HasBackButtonProperty!, obs, changed);


 // TopCommandBar

/*AttachedPropertyFuncGenerator*/
public static T NavigationPage_TopCommandBar<T>(this T control, Func<Avalonia.Controls.Control?> getter) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.NavigationPage.TopCommandBarProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T NavigationPage_TopCommandBar<T>(this T control, IObservable<Avalonia.Controls.Control?> obs) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.NavigationPage.TopCommandBarProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T NavigationPage_TopCommandBar<T>(this T control, ISubject<Avalonia.Controls.Control?> subject) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.NavigationPage.TopCommandBarProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T NavigationPage_TopCommandBar<T>(this T control, Avalonia.Controls.Control? value) where T : Avalonia.Controls.Page 
{
    control.SetValue(Avalonia.Controls.NavigationPage.TopCommandBarProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T NavigationPage_TopCommandBar<T>(this T control, IObservable<Avalonia.Controls.Control?> obs, IObserver<Avalonia.Controls.Control?> changed) where T : Avalonia.Controls.Page 
   => control._setEx(Avalonia.Controls.NavigationPage.TopCommandBarProperty!, obs, changed);


 // BottomCommandBar

/*AttachedPropertyFuncGenerator*/
public static T NavigationPage_BottomCommandBar<T>(this T control, Func<Avalonia.Controls.Control?> getter) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.NavigationPage.BottomCommandBarProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T NavigationPage_BottomCommandBar<T>(this T control, IObservable<Avalonia.Controls.Control?> obs) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.NavigationPage.BottomCommandBarProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T NavigationPage_BottomCommandBar<T>(this T control, ISubject<Avalonia.Controls.Control?> subject) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.NavigationPage.BottomCommandBarProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T NavigationPage_BottomCommandBar<T>(this T control, Avalonia.Controls.Control? value) where T : Avalonia.Controls.Page 
{
    control.SetValue(Avalonia.Controls.NavigationPage.BottomCommandBarProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T NavigationPage_BottomCommandBar<T>(this T control, IObservable<Avalonia.Controls.Control?> obs, IObserver<Avalonia.Controls.Control?> changed) where T : Avalonia.Controls.Page 
   => control._setEx(Avalonia.Controls.NavigationPage.BottomCommandBarProperty!, obs, changed);


 // HasNavigationBar

/*AttachedPropertyFuncGenerator*/
public static T NavigationPage_HasNavigationBar<T>(this T control, Func<System.Boolean> getter) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.NavigationPage.HasNavigationBarProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T NavigationPage_HasNavigationBar<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.NavigationPage.HasNavigationBarProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T NavigationPage_HasNavigationBar<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.NavigationPage.HasNavigationBarProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T NavigationPage_HasNavigationBar<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Page 
{
    control.SetValue(Avalonia.Controls.NavigationPage.HasNavigationBarProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T NavigationPage_HasNavigationBar<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Page 
   => control._setEx(Avalonia.Controls.NavigationPage.HasNavigationBarProperty!, obs, changed);


 // IsBackButtonEnabled

/*AttachedPropertyFuncGenerator*/
public static T NavigationPage_IsBackButtonEnabled<T>(this T control, Func<System.Boolean> getter) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.NavigationPage.IsBackButtonEnabledProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T NavigationPage_IsBackButtonEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.NavigationPage.IsBackButtonEnabledProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T NavigationPage_IsBackButtonEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.NavigationPage.IsBackButtonEnabledProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T NavigationPage_IsBackButtonEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Page 
{
    control.SetValue(Avalonia.Controls.NavigationPage.IsBackButtonEnabledProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T NavigationPage_IsBackButtonEnabled<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Page 
   => control._setEx(Avalonia.Controls.NavigationPage.IsBackButtonEnabledProperty!, obs, changed);



//================= Events ======================//
 // Pushed

/*ActionToEventGenerator*/
public static T OnPushed<T>(this T control, Action<Avalonia.Controls.NavigationEventArgs> action) where T : Avalonia.Controls.NavigationPage  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.NavigationEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Pushed += h);

/*ReactiveEventGenerator*/
public static T RxPushed<T>(this T control, IObserver<Avalonia.Controls.NavigationEventArgs> observer) where T : Avalonia.Controls.NavigationPage  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.NavigationEventArgs>) ((arg0, arg1) => observer.OnNext((arg1))), h => control.Pushed += h);


 // Popped

/*ActionToEventGenerator*/
public static T OnPopped<T>(this T control, Action<Avalonia.Controls.NavigationEventArgs> action) where T : Avalonia.Controls.NavigationPage  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.NavigationEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Popped += h);

/*ReactiveEventGenerator*/
public static T RxPopped<T>(this T control, IObserver<Avalonia.Controls.NavigationEventArgs> observer) where T : Avalonia.Controls.NavigationPage  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.NavigationEventArgs>) ((arg0, arg1) => observer.OnNext((arg1))), h => control.Popped += h);


 // PoppedToRoot

/*ActionToEventGenerator*/
public static T OnPoppedToRoot<T>(this T control, Action<Avalonia.Controls.NavigationEventArgs> action) where T : Avalonia.Controls.NavigationPage  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.NavigationEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PoppedToRoot += h);

/*ReactiveEventGenerator*/
public static T RxPoppedToRoot<T>(this T control, IObserver<Avalonia.Controls.NavigationEventArgs> observer) where T : Avalonia.Controls.NavigationPage  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.NavigationEventArgs>) ((arg0, arg1) => observer.OnNext((arg1))), h => control.PoppedToRoot += h);


 // PageInserted

/*ActionToEventGenerator*/
public static T OnPageInserted<T>(this T control, Action<Avalonia.Controls.PageInsertedEventArgs> action) where T : Avalonia.Controls.NavigationPage  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.PageInsertedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PageInserted += h);

/*ReactiveEventGenerator*/
public static T RxPageInserted<T>(this T control, IObserver<Avalonia.Controls.PageInsertedEventArgs> observer) where T : Avalonia.Controls.NavigationPage  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.PageInsertedEventArgs>) ((arg0, arg1) => observer.OnNext((arg1))), h => control.PageInserted += h);


 // PageRemoved

/*ActionToEventGenerator*/
public static T OnPageRemoved<T>(this T control, Action<Avalonia.Controls.PageRemovedEventArgs> action) where T : Avalonia.Controls.NavigationPage  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.PageRemovedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PageRemoved += h);

/*ReactiveEventGenerator*/
public static T RxPageRemoved<T>(this T control, IObserver<Avalonia.Controls.PageRemovedEventArgs> observer) where T : Avalonia.Controls.NavigationPage  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.PageRemovedEventArgs>) ((arg0, arg1) => observer.OnNext((arg1))), h => control.PageRemoved += h);


 // ModalPushed

/*ActionToEventGenerator*/
public static T OnModalPushed<T>(this T control, Action<Avalonia.Controls.ModalPushedEventArgs> action) where T : Avalonia.Controls.NavigationPage  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ModalPushedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ModalPushed += h);

/*ReactiveEventGenerator*/
public static T RxModalPushed<T>(this T control, IObserver<Avalonia.Controls.ModalPushedEventArgs> observer) where T : Avalonia.Controls.NavigationPage  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ModalPushedEventArgs>) ((arg0, arg1) => observer.OnNext((arg1))), h => control.ModalPushed += h);


 // ModalPopped

/*ActionToEventGenerator*/
public static T OnModalPopped<T>(this T control, Action<Avalonia.Controls.ModalPoppedEventArgs> action) where T : Avalonia.Controls.NavigationPage  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ModalPoppedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ModalPopped += h);

/*ReactiveEventGenerator*/
public static T RxModalPopped<T>(this T control, IObserver<Avalonia.Controls.ModalPoppedEventArgs> observer) where T : Avalonia.Controls.NavigationPage  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ModalPoppedEventArgs>) ((arg0, arg1) => observer.OnNext((arg1))), h => control.ModalPopped += h);



//================= Styles ======================//
 // Content

/*ValueStyleSetterGenerator*/
public static Style<T> Content<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.NavigationPage 
=> style._addSetter(Avalonia.Controls.NavigationPage.ContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Content<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.NavigationPage 
=> style._addSetter(Avalonia.Controls.NavigationPage.ContentProperty, binding);


 // PageTransition

/*ValueStyleSetterGenerator*/
public static Style<T> PageTransition<T>(this Style<T> style, Avalonia.Animation.IPageTransition? value) where T : Avalonia.Controls.NavigationPage 
=> style._addSetter(Avalonia.Controls.NavigationPage.PageTransitionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PageTransition<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.NavigationPage 
=> style._addSetter(Avalonia.Controls.NavigationPage.PageTransitionProperty, binding);


 // ModalTransition

/*ValueStyleSetterGenerator*/
public static Style<T> ModalTransition<T>(this Style<T> style, Avalonia.Animation.IPageTransition? value) where T : Avalonia.Controls.NavigationPage 
=> style._addSetter(Avalonia.Controls.NavigationPage.ModalTransitionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ModalTransition<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.NavigationPage 
=> style._addSetter(Avalonia.Controls.NavigationPage.ModalTransitionProperty, binding);


 // HasShadow

/*ValueStyleSetterGenerator*/
public static Style<T> HasShadow<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.NavigationPage 
=> style._addSetter(Avalonia.Controls.NavigationPage.HasShadowProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HasShadow<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.NavigationPage 
=> style._addSetter(Avalonia.Controls.NavigationPage.HasShadowProperty, binding);


 // BarHeight

/*ValueStyleSetterGenerator*/
public static Style<T> BarHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.NavigationPage 
=> style._addSetter(Avalonia.Controls.NavigationPage.BarHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BarHeight<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.NavigationPage 
=> style._addSetter(Avalonia.Controls.NavigationPage.BarHeightProperty, binding);


 // IsBackButtonVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsBackButtonVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.NavigationPage 
=> style._addSetter(Avalonia.Controls.NavigationPage.IsBackButtonVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsBackButtonVisible<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.NavigationPage 
=> style._addSetter(Avalonia.Controls.NavigationPage.IsBackButtonVisibleProperty, binding);


 // IsGestureEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsGestureEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.NavigationPage 
=> style._addSetter(Avalonia.Controls.NavigationPage.IsGestureEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsGestureEnabled<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.NavigationPage 
=> style._addSetter(Avalonia.Controls.NavigationPage.IsGestureEnabledProperty, binding);



}

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
public static partial class CarouselPage_MarkupExtensions
{
//================= Properties ======================//
 // ItemsPanel

/*ValueSetterGenerator*/
public static T ItemsPanel<T>(this T control, Avalonia.Controls.ITemplate<Avalonia.Controls.Panel> value) where T : Avalonia.Controls.CarouselPage 
{
    control.ItemsPanel = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ItemsPanel<T>(this T control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> func) where T : Avalonia.Controls.CarouselPage 
   => control._set(Avalonia.Controls.CarouselPage.ItemsPanelProperty!, func);

/*SetterFromObservableGenerator*/
public static T ItemsPanel<T>(this T control, IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> obs) where T : Avalonia.Controls.CarouselPage 
   => control._set(Avalonia.Controls.CarouselPage.ItemsPanelProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ItemsPanel<T>(this T control, ISubject<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> subject) where T : Avalonia.Controls.CarouselPage 
   => control._set(Avalonia.Controls.CarouselPage.ItemsPanelProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ItemsPanel<T>(this T control, IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> obs, IObserver<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> changed) where T : Avalonia.Controls.CarouselPage 
   => control._setEx(Avalonia.Controls.CarouselPage.ItemsPanelProperty!, obs, changed);


 // PageTransition

/*ValueSetterGenerator*/
public static T PageTransition<T>(this T control, Avalonia.Animation.IPageTransition? value) where T : Avalonia.Controls.CarouselPage 
{
    control.PageTransition = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PageTransition<T>(this T control, Func<Avalonia.Animation.IPageTransition?> func) where T : Avalonia.Controls.CarouselPage 
   => control._set(Avalonia.Controls.CarouselPage.PageTransitionProperty!, func);

/*SetterFromObservableGenerator*/
public static T PageTransition<T>(this T control, IObservable<Avalonia.Animation.IPageTransition?> obs) where T : Avalonia.Controls.CarouselPage 
   => control._set(Avalonia.Controls.CarouselPage.PageTransitionProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PageTransition<T>(this T control, ISubject<Avalonia.Animation.IPageTransition?> subject) where T : Avalonia.Controls.CarouselPage 
   => control._set(Avalonia.Controls.CarouselPage.PageTransitionProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T PageTransition<T>(this T control, IObservable<Avalonia.Animation.IPageTransition?> obs, IObserver<Avalonia.Animation.IPageTransition?> changed) where T : Avalonia.Controls.CarouselPage 
   => control._setEx(Avalonia.Controls.CarouselPage.PageTransitionProperty!, obs, changed);


 // IsGestureEnabled

/*ValueSetterGenerator*/
public static T IsGestureEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.CarouselPage 
{
    control.IsGestureEnabled = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsGestureEnabled<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.CarouselPage 
   => control._set(Avalonia.Controls.CarouselPage.IsGestureEnabledProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsGestureEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.CarouselPage 
   => control._set(Avalonia.Controls.CarouselPage.IsGestureEnabledProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsGestureEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.CarouselPage 
   => control._set(Avalonia.Controls.CarouselPage.IsGestureEnabledProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsGestureEnabled<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.CarouselPage 
   => control._setEx(Avalonia.Controls.CarouselPage.IsGestureEnabledProperty!, obs, changed);


 // IsKeyboardNavigationEnabled

/*ValueSetterGenerator*/
public static T IsKeyboardNavigationEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.CarouselPage 
{
    control.IsKeyboardNavigationEnabled = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsKeyboardNavigationEnabled<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.CarouselPage 
   => control._set(Avalonia.Controls.CarouselPage.IsKeyboardNavigationEnabledProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsKeyboardNavigationEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.CarouselPage 
   => control._set(Avalonia.Controls.CarouselPage.IsKeyboardNavigationEnabledProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsKeyboardNavigationEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.CarouselPage 
   => control._set(Avalonia.Controls.CarouselPage.IsKeyboardNavigationEnabledProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsKeyboardNavigationEnabled<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.CarouselPage 
   => control._setEx(Avalonia.Controls.CarouselPage.IsKeyboardNavigationEnabledProperty!, obs, changed);



//================= Styles ======================//
 // ItemsPanel

/*ValueStyleSetterGenerator*/
public static Style<T> ItemsPanel<T>(this Style<T> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Panel> value) where T : Avalonia.Controls.CarouselPage 
=> style._addSetter(Avalonia.Controls.CarouselPage.ItemsPanelProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemsPanel<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.CarouselPage 
=> style._addSetter(Avalonia.Controls.CarouselPage.ItemsPanelProperty, binding);


 // PageTransition

/*ValueStyleSetterGenerator*/
public static Style<T> PageTransition<T>(this Style<T> style, Avalonia.Animation.IPageTransition? value) where T : Avalonia.Controls.CarouselPage 
=> style._addSetter(Avalonia.Controls.CarouselPage.PageTransitionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PageTransition<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.CarouselPage 
=> style._addSetter(Avalonia.Controls.CarouselPage.PageTransitionProperty, binding);


 // IsGestureEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsGestureEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.CarouselPage 
=> style._addSetter(Avalonia.Controls.CarouselPage.IsGestureEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsGestureEnabled<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.CarouselPage 
=> style._addSetter(Avalonia.Controls.CarouselPage.IsGestureEnabledProperty, binding);


 // IsKeyboardNavigationEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsKeyboardNavigationEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.CarouselPage 
=> style._addSetter(Avalonia.Controls.CarouselPage.IsKeyboardNavigationEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsKeyboardNavigationEnabled<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.CarouselPage 
=> style._addSetter(Avalonia.Controls.CarouselPage.IsKeyboardNavigationEnabledProperty, binding);



}

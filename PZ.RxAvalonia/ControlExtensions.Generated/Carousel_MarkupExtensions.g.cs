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
public static partial class Carousel_MarkupExtensions
{
//================= Properties ======================//
 // PageTransition

/*ValueSetterGenerator*/
public static T PageTransition<T>(this T control, Avalonia.Animation.IPageTransition? value) where T : Avalonia.Controls.Carousel 
{
    control.PageTransition = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PageTransition<T>(this T control, Func<Avalonia.Animation.IPageTransition?> func) where T : Avalonia.Controls.Carousel 
   => control._set(Avalonia.Controls.Carousel.PageTransitionProperty!, func);

/*SetterFromObservableGenerator*/
public static T PageTransition<T>(this T control, IObservable<Avalonia.Animation.IPageTransition?> obs) where T : Avalonia.Controls.Carousel 
   => control._set(Avalonia.Controls.Carousel.PageTransitionProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PageTransition<T>(this T control, ISubject<Avalonia.Animation.IPageTransition?> subject) where T : Avalonia.Controls.Carousel 
   => control._set(Avalonia.Controls.Carousel.PageTransitionProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T PageTransition<T>(this T control, IObservable<Avalonia.Animation.IPageTransition?> obs, IObserver<Avalonia.Animation.IPageTransition?> changed) where T : Avalonia.Controls.Carousel 
   => control._setEx(Avalonia.Controls.Carousel.PageTransitionProperty!, obs, changed);


 // IsSwipeEnabled

/*ValueSetterGenerator*/
public static T IsSwipeEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Carousel 
{
    control.IsSwipeEnabled = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsSwipeEnabled<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Carousel 
   => control._set(Avalonia.Controls.Carousel.IsSwipeEnabledProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsSwipeEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Carousel 
   => control._set(Avalonia.Controls.Carousel.IsSwipeEnabledProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsSwipeEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Carousel 
   => control._set(Avalonia.Controls.Carousel.IsSwipeEnabledProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsSwipeEnabled<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Carousel 
   => control._setEx(Avalonia.Controls.Carousel.IsSwipeEnabledProperty!, obs, changed);


 // ViewportFraction

/*ValueSetterGenerator*/
public static T ViewportFraction<T>(this T control, System.Double value) where T : Avalonia.Controls.Carousel 
{
    control.ViewportFraction = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ViewportFraction<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Carousel 
   => control._set(Avalonia.Controls.Carousel.ViewportFractionProperty!, func);

/*SetterFromObservableGenerator*/
public static T ViewportFraction<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Carousel 
   => control._set(Avalonia.Controls.Carousel.ViewportFractionProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ViewportFraction<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Carousel 
   => control._set(Avalonia.Controls.Carousel.ViewportFractionProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ViewportFraction<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.Carousel 
   => control._setEx(Avalonia.Controls.Carousel.ViewportFractionProperty!, obs, changed);



//================= Styles ======================//
 // PageTransition

/*ValueStyleSetterGenerator*/
public static Style<T> PageTransition<T>(this Style<T> style, Avalonia.Animation.IPageTransition? value) where T : Avalonia.Controls.Carousel 
=> style._addSetter(Avalonia.Controls.Carousel.PageTransitionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PageTransition<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.Carousel 
=> style._addSetter(Avalonia.Controls.Carousel.PageTransitionProperty, binding);


 // IsSwipeEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsSwipeEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Carousel 
=> style._addSetter(Avalonia.Controls.Carousel.IsSwipeEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsSwipeEnabled<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.Carousel 
=> style._addSetter(Avalonia.Controls.Carousel.IsSwipeEnabledProperty, binding);


 // ViewportFraction

/*ValueStyleSetterGenerator*/
public static Style<T> ViewportFraction<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Carousel 
=> style._addSetter(Avalonia.Controls.Carousel.ViewportFractionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ViewportFraction<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.Carousel 
=> style._addSetter(Avalonia.Controls.Carousel.ViewportFractionProperty, binding);



}

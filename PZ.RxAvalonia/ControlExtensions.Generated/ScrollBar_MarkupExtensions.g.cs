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
public static partial class ScrollBar_MarkupExtensions
{
//================= Properties ======================//
 // ViewportSize

/*ValueSetterGenerator*/
public static T ViewportSize<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.ScrollBar 
{
    control.ViewportSize = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ViewportSize<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty!, func);

/*SetterFromObservableGenerator*/
public static T ViewportSize<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ViewportSize<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ViewportSize<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._setEx(Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty!, obs, changed);


 // Visibility

/*ValueSetterGenerator*/
public static T Visibility<T>(this T control, Avalonia.Controls.Primitives.ScrollBarVisibility value) where T : Avalonia.Controls.Primitives.ScrollBar 
{
    control.Visibility = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Visibility<T>(this T control, Func<Avalonia.Controls.Primitives.ScrollBarVisibility> func) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty!, func);

/*SetterFromObservableGenerator*/
public static T Visibility<T>(this T control, IObservable<Avalonia.Controls.Primitives.ScrollBarVisibility> obs) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Visibility<T>(this T control, ISubject<Avalonia.Controls.Primitives.ScrollBarVisibility> subject) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Visibility<T>(this T control, IObservable<Avalonia.Controls.Primitives.ScrollBarVisibility> obs, IObserver<Avalonia.Controls.Primitives.ScrollBarVisibility> changed) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._setEx(Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty!, obs, changed);


 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.Primitives.ScrollBar 
{
    control.Orientation = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.OrientationProperty!, func);

/*SetterFromObservableGenerator*/
public static T Orientation<T>(this T control, IObservable<Avalonia.Layout.Orientation> obs) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.OrientationProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Orientation<T>(this T control, ISubject<Avalonia.Layout.Orientation> subject) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.OrientationProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Orientation<T>(this T control, IObservable<Avalonia.Layout.Orientation> obs, IObserver<Avalonia.Layout.Orientation> changed) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._setEx(Avalonia.Controls.Primitives.ScrollBar.OrientationProperty!, obs, changed);


 // AllowAutoHide

/*ValueSetterGenerator*/
public static T AllowAutoHide<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.ScrollBar 
{
    control.AllowAutoHide = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T AllowAutoHide<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty!, func);

/*SetterFromObservableGenerator*/
public static T AllowAutoHide<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T AllowAutoHide<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T AllowAutoHide<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._setEx(Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty!, obs, changed);


 // HideDelay

/*ValueSetterGenerator*/
public static T HideDelay<T>(this T control, System.TimeSpan value) where T : Avalonia.Controls.Primitives.ScrollBar 
{
    control.HideDelay = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T HideDelay<T>(this T control, Func<System.TimeSpan> func) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty!, func);

/*SetterFromObservableGenerator*/
public static T HideDelay<T>(this T control, IObservable<System.TimeSpan> obs) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T HideDelay<T>(this T control, ISubject<System.TimeSpan> subject) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T HideDelay<T>(this T control, IObservable<System.TimeSpan> obs, IObserver<System.TimeSpan> changed) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._setEx(Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty!, obs, changed);


 // ShowDelay

/*ValueSetterGenerator*/
public static T ShowDelay<T>(this T control, System.TimeSpan value) where T : Avalonia.Controls.Primitives.ScrollBar 
{
    control.ShowDelay = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ShowDelay<T>(this T control, Func<System.TimeSpan> func) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty!, func);

/*SetterFromObservableGenerator*/
public static T ShowDelay<T>(this T control, IObservable<System.TimeSpan> obs) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ShowDelay<T>(this T control, ISubject<System.TimeSpan> subject) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ShowDelay<T>(this T control, IObservable<System.TimeSpan> obs, IObserver<System.TimeSpan> changed) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._setEx(Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty!, obs, changed);



//================= Events ======================//
 // Scroll

/*ActionToEventGenerator*/
public static T OnScroll<T>(this T control, Action<Avalonia.Controls.Primitives.ScrollEventArgs> action) where T : Avalonia.Controls.Primitives.ScrollBar  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.Primitives.ScrollEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Scroll += h);

/*ReactiveEventGenerator*/
public static T RxScroll<T>(this T control, IObserver<Avalonia.Controls.Primitives.ScrollEventArgs> observer) where T : Avalonia.Controls.Primitives.ScrollBar  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.Primitives.ScrollEventArgs>) ((arg0, arg1) => observer.OnNext((arg1))), h => control.Scroll += h);



//================= Styles ======================//
 // ViewportSize

/*ValueStyleSetterGenerator*/
public static Style<T> ViewportSize<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ViewportSize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty, binding);


 // Visibility

/*ValueStyleSetterGenerator*/
public static Style<T> Visibility<T>(this Style<T> style, Avalonia.Controls.Primitives.ScrollBarVisibility value) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Visibility<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty, binding);


 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.OrientationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.OrientationProperty, binding);


 // AllowAutoHide

/*ValueStyleSetterGenerator*/
public static Style<T> AllowAutoHide<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AllowAutoHide<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty, binding);


 // HideDelay

/*ValueStyleSetterGenerator*/
public static Style<T> HideDelay<T>(this Style<T> style, System.TimeSpan value) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HideDelay<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty, binding);


 // ShowDelay

/*ValueStyleSetterGenerator*/
public static Style<T> ShowDelay<T>(this Style<T> style, System.TimeSpan value) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowDelay<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty, binding);



}

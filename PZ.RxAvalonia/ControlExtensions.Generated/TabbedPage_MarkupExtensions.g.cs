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
public static partial class TabbedPage_MarkupExtensions
{
//================= Properties ======================//
 // TabPlacement

/*ValueSetterGenerator*/
public static T TabPlacement<T>(this T control, Avalonia.Controls.TabPlacement value) where T : Avalonia.Controls.TabbedPage 
{
    control.TabPlacement = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TabPlacement<T>(this T control, Func<Avalonia.Controls.TabPlacement> func) where T : Avalonia.Controls.TabbedPage 
   => control._set(Avalonia.Controls.TabbedPage.TabPlacementProperty!, func);

/*SetterFromObservableGenerator*/
public static T TabPlacement<T>(this T control, IObservable<Avalonia.Controls.TabPlacement> obs) where T : Avalonia.Controls.TabbedPage 
   => control._set(Avalonia.Controls.TabbedPage.TabPlacementProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TabPlacement<T>(this T control, ISubject<Avalonia.Controls.TabPlacement> subject) where T : Avalonia.Controls.TabbedPage 
   => control._set(Avalonia.Controls.TabbedPage.TabPlacementProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T TabPlacement<T>(this T control, IObservable<Avalonia.Controls.TabPlacement> obs, IObserver<Avalonia.Controls.TabPlacement> changed) where T : Avalonia.Controls.TabbedPage 
   => control._setEx(Avalonia.Controls.TabbedPage.TabPlacementProperty!, obs, changed);


 // IsKeyboardNavigationEnabled

/*ValueSetterGenerator*/
public static T IsKeyboardNavigationEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TabbedPage 
{
    control.IsKeyboardNavigationEnabled = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsKeyboardNavigationEnabled<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.TabbedPage 
   => control._set(Avalonia.Controls.TabbedPage.IsKeyboardNavigationEnabledProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsKeyboardNavigationEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.TabbedPage 
   => control._set(Avalonia.Controls.TabbedPage.IsKeyboardNavigationEnabledProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsKeyboardNavigationEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.TabbedPage 
   => control._set(Avalonia.Controls.TabbedPage.IsKeyboardNavigationEnabledProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsKeyboardNavigationEnabled<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.TabbedPage 
   => control._setEx(Avalonia.Controls.TabbedPage.IsKeyboardNavigationEnabledProperty!, obs, changed);


 // IsGestureEnabled

/*ValueSetterGenerator*/
public static T IsGestureEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TabbedPage 
{
    control.IsGestureEnabled = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsGestureEnabled<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.TabbedPage 
   => control._set(Avalonia.Controls.TabbedPage.IsGestureEnabledProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsGestureEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.TabbedPage 
   => control._set(Avalonia.Controls.TabbedPage.IsGestureEnabledProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsGestureEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.TabbedPage 
   => control._set(Avalonia.Controls.TabbedPage.IsGestureEnabledProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsGestureEnabled<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.TabbedPage 
   => control._setEx(Avalonia.Controls.TabbedPage.IsGestureEnabledProperty!, obs, changed);


 // PageTransition

/*ValueSetterGenerator*/
public static T PageTransition<T>(this T control, Avalonia.Animation.IPageTransition? value) where T : Avalonia.Controls.TabbedPage 
{
    control.PageTransition = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PageTransition<T>(this T control, Func<Avalonia.Animation.IPageTransition?> func) where T : Avalonia.Controls.TabbedPage 
   => control._set(Avalonia.Controls.TabbedPage.PageTransitionProperty!, func);

/*SetterFromObservableGenerator*/
public static T PageTransition<T>(this T control, IObservable<Avalonia.Animation.IPageTransition?> obs) where T : Avalonia.Controls.TabbedPage 
   => control._set(Avalonia.Controls.TabbedPage.PageTransitionProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PageTransition<T>(this T control, ISubject<Avalonia.Animation.IPageTransition?> subject) where T : Avalonia.Controls.TabbedPage 
   => control._set(Avalonia.Controls.TabbedPage.PageTransitionProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T PageTransition<T>(this T control, IObservable<Avalonia.Animation.IPageTransition?> obs, IObserver<Avalonia.Animation.IPageTransition?> changed) where T : Avalonia.Controls.TabbedPage 
   => control._setEx(Avalonia.Controls.TabbedPage.PageTransitionProperty!, obs, changed);


 // IndicatorTemplate

/*ValueSetterGenerator*/
public static T IndicatorTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.TabbedPage 
{
    control.IndicatorTemplate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IndicatorTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate?> func) where T : Avalonia.Controls.TabbedPage 
   => control._set(Avalonia.Controls.TabbedPage.IndicatorTemplateProperty!, func);

/*SetterFromObservableGenerator*/
public static T IndicatorTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs) where T : Avalonia.Controls.TabbedPage 
   => control._set(Avalonia.Controls.TabbedPage.IndicatorTemplateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IndicatorTemplate<T>(this T control, ISubject<Avalonia.Controls.Templates.IDataTemplate?> subject) where T : Avalonia.Controls.TabbedPage 
   => control._set(Avalonia.Controls.TabbedPage.IndicatorTemplateProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IndicatorTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs, IObserver<Avalonia.Controls.Templates.IDataTemplate?> changed) where T : Avalonia.Controls.TabbedPage 
   => control._setEx(Avalonia.Controls.TabbedPage.IndicatorTemplateProperty!, obs, changed);



//================= Attached Properties ======================//
 // IsTabEnabled

/*AttachedPropertyFuncGenerator*/
public static T TabbedPage_IsTabEnabled<T>(this T control, Func<System.Boolean> getter) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.TabbedPage.IsTabEnabledProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T TabbedPage_IsTabEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.TabbedPage.IsTabEnabledProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T TabbedPage_IsTabEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.TabbedPage.IsTabEnabledProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T TabbedPage_IsTabEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Page 
{
    control.SetValue(Avalonia.Controls.TabbedPage.IsTabEnabledProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T TabbedPage_IsTabEnabled<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Page 
   => control._setEx(Avalonia.Controls.TabbedPage.IsTabEnabledProperty!, obs, changed);



//================= Styles ======================//
 // TabPlacement

/*ValueStyleSetterGenerator*/
public static Style<T> TabPlacement<T>(this Style<T> style, Avalonia.Controls.TabPlacement value) where T : Avalonia.Controls.TabbedPage 
=> style._addSetter(Avalonia.Controls.TabbedPage.TabPlacementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TabPlacement<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.TabbedPage 
=> style._addSetter(Avalonia.Controls.TabbedPage.TabPlacementProperty, binding);


 // IsKeyboardNavigationEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsKeyboardNavigationEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TabbedPage 
=> style._addSetter(Avalonia.Controls.TabbedPage.IsKeyboardNavigationEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsKeyboardNavigationEnabled<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.TabbedPage 
=> style._addSetter(Avalonia.Controls.TabbedPage.IsKeyboardNavigationEnabledProperty, binding);


 // IsGestureEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsGestureEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TabbedPage 
=> style._addSetter(Avalonia.Controls.TabbedPage.IsGestureEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsGestureEnabled<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.TabbedPage 
=> style._addSetter(Avalonia.Controls.TabbedPage.IsGestureEnabledProperty, binding);


 // PageTransition

/*ValueStyleSetterGenerator*/
public static Style<T> PageTransition<T>(this Style<T> style, Avalonia.Animation.IPageTransition? value) where T : Avalonia.Controls.TabbedPage 
=> style._addSetter(Avalonia.Controls.TabbedPage.PageTransitionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PageTransition<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.TabbedPage 
=> style._addSetter(Avalonia.Controls.TabbedPage.PageTransitionProperty, binding);


 // IndicatorTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> IndicatorTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.TabbedPage 
=> style._addSetter(Avalonia.Controls.TabbedPage.IndicatorTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IndicatorTemplate<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.TabbedPage 
=> style._addSetter(Avalonia.Controls.TabbedPage.IndicatorTemplateProperty, binding);



}

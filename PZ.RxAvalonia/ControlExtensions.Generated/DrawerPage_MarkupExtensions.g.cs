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
public static partial class DrawerPage_MarkupExtensions
{
//================= Properties ======================//
 // Drawer

/*ValueSetterGenerator*/
public static T Drawer<T>(this T control, System.Object? value) where T : Avalonia.Controls.DrawerPage 
{
    control.Drawer = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Drawer<T>(this T control, Func<System.Object?> func) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerProperty!, func);

/*SetterFromObservableGenerator*/
public static T Drawer<T>(this T control, IObservable<System.Object?> obs) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Drawer<T>(this T control, ISubject<System.Object?> subject) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Drawer<T>(this T control, IObservable<System.Object?> obs, IObserver<System.Object?> changed) where T : Avalonia.Controls.DrawerPage 
   => control._setEx(Avalonia.Controls.DrawerPage.DrawerProperty!, obs, changed);


 // Content

/*ValueSetterGenerator*/
public static T Content<T>(this T control, System.Object? value) where T : Avalonia.Controls.DrawerPage 
{
    control.Content = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Content<T>(this T control, Func<System.Object?> func) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.ContentProperty!, func);

/*SetterFromObservableGenerator*/
public static T Content<T>(this T control, IObservable<System.Object?> obs) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.ContentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Content<T>(this T control, ISubject<System.Object?> subject) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.ContentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Content<T>(this T control, IObservable<System.Object?> obs, IObserver<System.Object?> changed) where T : Avalonia.Controls.DrawerPage 
   => control._setEx(Avalonia.Controls.DrawerPage.ContentProperty!, obs, changed);


 // IsOpen

/*ValueSetterGenerator*/
public static T IsOpen<T>(this T control, System.Boolean value) where T : Avalonia.Controls.DrawerPage 
{
    control.IsOpen = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsOpen<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.IsOpenProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsOpen<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.IsOpenProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsOpen<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.IsOpenProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsOpen<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.DrawerPage 
   => control._setEx(Avalonia.Controls.DrawerPage.IsOpenProperty!, obs, changed);


 // DrawerLength

/*ValueSetterGenerator*/
public static T DrawerLength<T>(this T control, System.Double value) where T : Avalonia.Controls.DrawerPage 
{
    control.DrawerLength = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DrawerLength<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerLengthProperty!, func);

/*SetterFromObservableGenerator*/
public static T DrawerLength<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerLengthProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DrawerLength<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerLengthProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DrawerLength<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.DrawerPage 
   => control._setEx(Avalonia.Controls.DrawerPage.DrawerLengthProperty!, obs, changed);


 // CompactDrawerLength

/*ValueSetterGenerator*/
public static T CompactDrawerLength<T>(this T control, System.Double value) where T : Avalonia.Controls.DrawerPage 
{
    control.CompactDrawerLength = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CompactDrawerLength<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.CompactDrawerLengthProperty!, func);

/*SetterFromObservableGenerator*/
public static T CompactDrawerLength<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.CompactDrawerLengthProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CompactDrawerLength<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.CompactDrawerLengthProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T CompactDrawerLength<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.DrawerPage 
   => control._setEx(Avalonia.Controls.DrawerPage.CompactDrawerLengthProperty!, obs, changed);


 // DrawerBreakpointLength

/*ValueSetterGenerator*/
public static T DrawerBreakpointLength<T>(this T control, System.Double value) where T : Avalonia.Controls.DrawerPage 
{
    control.DrawerBreakpointLength = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DrawerBreakpointLength<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerBreakpointLengthProperty!, func);

/*SetterFromObservableGenerator*/
public static T DrawerBreakpointLength<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerBreakpointLengthProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DrawerBreakpointLength<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerBreakpointLengthProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DrawerBreakpointLength<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.DrawerPage 
   => control._setEx(Avalonia.Controls.DrawerPage.DrawerBreakpointLengthProperty!, obs, changed);


 // IsGestureEnabled

/*ValueSetterGenerator*/
public static T IsGestureEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.DrawerPage 
{
    control.IsGestureEnabled = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsGestureEnabled<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.IsGestureEnabledProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsGestureEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.IsGestureEnabledProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsGestureEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.IsGestureEnabledProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsGestureEnabled<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.DrawerPage 
   => control._setEx(Avalonia.Controls.DrawerPage.IsGestureEnabledProperty!, obs, changed);


 // DrawerBehavior

/*ValueSetterGenerator*/
public static T DrawerBehavior<T>(this T control, Avalonia.Controls.DrawerBehavior value) where T : Avalonia.Controls.DrawerPage 
{
    control.DrawerBehavior = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DrawerBehavior<T>(this T control, Func<Avalonia.Controls.DrawerBehavior> func) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerBehaviorProperty!, func);

/*SetterFromObservableGenerator*/
public static T DrawerBehavior<T>(this T control, IObservable<Avalonia.Controls.DrawerBehavior> obs) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerBehaviorProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DrawerBehavior<T>(this T control, ISubject<Avalonia.Controls.DrawerBehavior> subject) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerBehaviorProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DrawerBehavior<T>(this T control, IObservable<Avalonia.Controls.DrawerBehavior> obs, IObserver<Avalonia.Controls.DrawerBehavior> changed) where T : Avalonia.Controls.DrawerPage 
   => control._setEx(Avalonia.Controls.DrawerPage.DrawerBehaviorProperty!, obs, changed);


 // DrawerLayoutBehavior

/*ValueSetterGenerator*/
public static T DrawerLayoutBehavior<T>(this T control, Avalonia.Controls.DrawerLayoutBehavior value) where T : Avalonia.Controls.DrawerPage 
{
    control.DrawerLayoutBehavior = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DrawerLayoutBehavior<T>(this T control, Func<Avalonia.Controls.DrawerLayoutBehavior> func) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerLayoutBehaviorProperty!, func);

/*SetterFromObservableGenerator*/
public static T DrawerLayoutBehavior<T>(this T control, IObservable<Avalonia.Controls.DrawerLayoutBehavior> obs) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerLayoutBehaviorProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DrawerLayoutBehavior<T>(this T control, ISubject<Avalonia.Controls.DrawerLayoutBehavior> subject) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerLayoutBehaviorProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DrawerLayoutBehavior<T>(this T control, IObservable<Avalonia.Controls.DrawerLayoutBehavior> obs, IObserver<Avalonia.Controls.DrawerLayoutBehavior> changed) where T : Avalonia.Controls.DrawerPage 
   => control._setEx(Avalonia.Controls.DrawerPage.DrawerLayoutBehaviorProperty!, obs, changed);


 // DrawerPlacement

/*ValueSetterGenerator*/
public static T DrawerPlacement<T>(this T control, Avalonia.Controls.DrawerPlacement value) where T : Avalonia.Controls.DrawerPage 
{
    control.DrawerPlacement = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DrawerPlacement<T>(this T control, Func<Avalonia.Controls.DrawerPlacement> func) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerPlacementProperty!, func);

/*SetterFromObservableGenerator*/
public static T DrawerPlacement<T>(this T control, IObservable<Avalonia.Controls.DrawerPlacement> obs) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerPlacementProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DrawerPlacement<T>(this T control, ISubject<Avalonia.Controls.DrawerPlacement> subject) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerPlacementProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DrawerPlacement<T>(this T control, IObservable<Avalonia.Controls.DrawerPlacement> obs, IObserver<Avalonia.Controls.DrawerPlacement> changed) where T : Avalonia.Controls.DrawerPage 
   => control._setEx(Avalonia.Controls.DrawerPage.DrawerPlacementProperty!, obs, changed);


 // DrawerHeader

/*ValueSetterGenerator*/
public static T DrawerHeader<T>(this T control, System.Object? value) where T : Avalonia.Controls.DrawerPage 
{
    control.DrawerHeader = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DrawerHeader<T>(this T control, Func<System.Object?> func) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerHeaderProperty!, func);

/*SetterFromObservableGenerator*/
public static T DrawerHeader<T>(this T control, IObservable<System.Object?> obs) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerHeaderProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DrawerHeader<T>(this T control, ISubject<System.Object?> subject) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerHeaderProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DrawerHeader<T>(this T control, IObservable<System.Object?> obs, IObserver<System.Object?> changed) where T : Avalonia.Controls.DrawerPage 
   => control._setEx(Avalonia.Controls.DrawerPage.DrawerHeaderProperty!, obs, changed);


 // DrawerFooter

/*ValueSetterGenerator*/
public static T DrawerFooter<T>(this T control, System.Object? value) where T : Avalonia.Controls.DrawerPage 
{
    control.DrawerFooter = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DrawerFooter<T>(this T control, Func<System.Object?> func) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerFooterProperty!, func);

/*SetterFromObservableGenerator*/
public static T DrawerFooter<T>(this T control, IObservable<System.Object?> obs) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerFooterProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DrawerFooter<T>(this T control, ISubject<System.Object?> subject) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerFooterProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DrawerFooter<T>(this T control, IObservable<System.Object?> obs, IObserver<System.Object?> changed) where T : Avalonia.Controls.DrawerPage 
   => control._setEx(Avalonia.Controls.DrawerPage.DrawerFooterProperty!, obs, changed);


 // DrawerHeaderTemplate

/*ValueSetterGenerator*/
public static T DrawerHeaderTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.DrawerPage 
{
    control.DrawerHeaderTemplate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DrawerHeaderTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate?> func) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerHeaderTemplateProperty!, func);

/*SetterFromObservableGenerator*/
public static T DrawerHeaderTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerHeaderTemplateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DrawerHeaderTemplate<T>(this T control, ISubject<Avalonia.Controls.Templates.IDataTemplate?> subject) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerHeaderTemplateProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DrawerHeaderTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs, IObserver<Avalonia.Controls.Templates.IDataTemplate?> changed) where T : Avalonia.Controls.DrawerPage 
   => control._setEx(Avalonia.Controls.DrawerPage.DrawerHeaderTemplateProperty!, obs, changed);


 // DrawerFooterTemplate

/*ValueSetterGenerator*/
public static T DrawerFooterTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.DrawerPage 
{
    control.DrawerFooterTemplate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DrawerFooterTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate?> func) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerFooterTemplateProperty!, func);

/*SetterFromObservableGenerator*/
public static T DrawerFooterTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerFooterTemplateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DrawerFooterTemplate<T>(this T control, ISubject<Avalonia.Controls.Templates.IDataTemplate?> subject) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerFooterTemplateProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DrawerFooterTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs, IObserver<Avalonia.Controls.Templates.IDataTemplate?> changed) where T : Avalonia.Controls.DrawerPage 
   => control._setEx(Avalonia.Controls.DrawerPage.DrawerFooterTemplateProperty!, obs, changed);


 // DrawerIcon

/*ValueSetterGenerator*/
public static T DrawerIcon<T>(this T control, System.Object? value) where T : Avalonia.Controls.DrawerPage 
{
    control.DrawerIcon = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DrawerIcon<T>(this T control, Func<System.Object?> func) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerIconProperty!, func);

/*SetterFromObservableGenerator*/
public static T DrawerIcon<T>(this T control, IObservable<System.Object?> obs) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerIconProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DrawerIcon<T>(this T control, ISubject<System.Object?> subject) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerIconProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DrawerIcon<T>(this T control, IObservable<System.Object?> obs, IObserver<System.Object?> changed) where T : Avalonia.Controls.DrawerPage 
   => control._setEx(Avalonia.Controls.DrawerPage.DrawerIconProperty!, obs, changed);


 // DrawerIconTemplate

/*ValueSetterGenerator*/
public static T DrawerIconTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.DrawerPage 
{
    control.DrawerIconTemplate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DrawerIconTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate?> func) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerIconTemplateProperty!, func);

/*SetterFromObservableGenerator*/
public static T DrawerIconTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerIconTemplateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DrawerIconTemplate<T>(this T control, ISubject<Avalonia.Controls.Templates.IDataTemplate?> subject) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerIconTemplateProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DrawerIconTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs, IObserver<Avalonia.Controls.Templates.IDataTemplate?> changed) where T : Avalonia.Controls.DrawerPage 
   => control._setEx(Avalonia.Controls.DrawerPage.DrawerIconTemplateProperty!, obs, changed);


 // DrawerTemplate

/*ValueSetterGenerator*/
public static T DrawerTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.DrawerPage 
{
    control.DrawerTemplate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DrawerTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate?> func) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerTemplateProperty!, func);

/*SetterFromObservableGenerator*/
public static T DrawerTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerTemplateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DrawerTemplate<T>(this T control, ISubject<Avalonia.Controls.Templates.IDataTemplate?> subject) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerTemplateProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DrawerTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs, IObserver<Avalonia.Controls.Templates.IDataTemplate?> changed) where T : Avalonia.Controls.DrawerPage 
   => control._setEx(Avalonia.Controls.DrawerPage.DrawerTemplateProperty!, obs, changed);


 // ContentTemplate

/*ValueSetterGenerator*/
public static T ContentTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.DrawerPage 
{
    control.ContentTemplate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ContentTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate?> func) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.ContentTemplateProperty!, func);

/*SetterFromObservableGenerator*/
public static T ContentTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.ContentTemplateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ContentTemplate<T>(this T control, ISubject<Avalonia.Controls.Templates.IDataTemplate?> subject) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.ContentTemplateProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ContentTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs, IObserver<Avalonia.Controls.Templates.IDataTemplate?> changed) where T : Avalonia.Controls.DrawerPage 
   => control._setEx(Avalonia.Controls.DrawerPage.ContentTemplateProperty!, obs, changed);


 // DrawerBackground

/*ValueSetterGenerator*/
public static T DrawerBackground<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.DrawerPage 
{
    control.DrawerBackground = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DrawerBackground<T>(this T control, Func<Avalonia.Media.IBrush?> func) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerBackgroundProperty!, func);

/*SetterFromObservableGenerator*/
public static T DrawerBackground<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerBackgroundProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DrawerBackground<T>(this T control, ISubject<Avalonia.Media.IBrush?> subject) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerBackgroundProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DrawerBackground<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs, IObserver<Avalonia.Media.IBrush?> changed) where T : Avalonia.Controls.DrawerPage 
   => control._setEx(Avalonia.Controls.DrawerPage.DrawerBackgroundProperty!, obs, changed);


 // DrawerHeaderBackground

/*ValueSetterGenerator*/
public static T DrawerHeaderBackground<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.DrawerPage 
{
    control.DrawerHeaderBackground = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DrawerHeaderBackground<T>(this T control, Func<Avalonia.Media.IBrush?> func) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerHeaderBackgroundProperty!, func);

/*SetterFromObservableGenerator*/
public static T DrawerHeaderBackground<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerHeaderBackgroundProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DrawerHeaderBackground<T>(this T control, ISubject<Avalonia.Media.IBrush?> subject) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerHeaderBackgroundProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DrawerHeaderBackground<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs, IObserver<Avalonia.Media.IBrush?> changed) where T : Avalonia.Controls.DrawerPage 
   => control._setEx(Avalonia.Controls.DrawerPage.DrawerHeaderBackgroundProperty!, obs, changed);


 // DrawerHeaderForeground

/*ValueSetterGenerator*/
public static T DrawerHeaderForeground<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.DrawerPage 
{
    control.DrawerHeaderForeground = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DrawerHeaderForeground<T>(this T control, Func<Avalonia.Media.IBrush?> func) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerHeaderForegroundProperty!, func);

/*SetterFromObservableGenerator*/
public static T DrawerHeaderForeground<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerHeaderForegroundProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DrawerHeaderForeground<T>(this T control, ISubject<Avalonia.Media.IBrush?> subject) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerHeaderForegroundProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DrawerHeaderForeground<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs, IObserver<Avalonia.Media.IBrush?> changed) where T : Avalonia.Controls.DrawerPage 
   => control._setEx(Avalonia.Controls.DrawerPage.DrawerHeaderForegroundProperty!, obs, changed);


 // DrawerFooterBackground

/*ValueSetterGenerator*/
public static T DrawerFooterBackground<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.DrawerPage 
{
    control.DrawerFooterBackground = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DrawerFooterBackground<T>(this T control, Func<Avalonia.Media.IBrush?> func) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerFooterBackgroundProperty!, func);

/*SetterFromObservableGenerator*/
public static T DrawerFooterBackground<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerFooterBackgroundProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DrawerFooterBackground<T>(this T control, ISubject<Avalonia.Media.IBrush?> subject) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerFooterBackgroundProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DrawerFooterBackground<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs, IObserver<Avalonia.Media.IBrush?> changed) where T : Avalonia.Controls.DrawerPage 
   => control._setEx(Avalonia.Controls.DrawerPage.DrawerFooterBackgroundProperty!, obs, changed);


 // DrawerFooterForeground

/*ValueSetterGenerator*/
public static T DrawerFooterForeground<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.DrawerPage 
{
    control.DrawerFooterForeground = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DrawerFooterForeground<T>(this T control, Func<Avalonia.Media.IBrush?> func) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerFooterForegroundProperty!, func);

/*SetterFromObservableGenerator*/
public static T DrawerFooterForeground<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerFooterForegroundProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DrawerFooterForeground<T>(this T control, ISubject<Avalonia.Media.IBrush?> subject) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DrawerFooterForegroundProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DrawerFooterForeground<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs, IObserver<Avalonia.Media.IBrush?> changed) where T : Avalonia.Controls.DrawerPage 
   => control._setEx(Avalonia.Controls.DrawerPage.DrawerFooterForegroundProperty!, obs, changed);


 // BackdropBrush

/*ValueSetterGenerator*/
public static T BackdropBrush<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.DrawerPage 
{
    control.BackdropBrush = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T BackdropBrush<T>(this T control, Func<Avalonia.Media.IBrush?> func) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.BackdropBrushProperty!, func);

/*SetterFromObservableGenerator*/
public static T BackdropBrush<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.BackdropBrushProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T BackdropBrush<T>(this T control, ISubject<Avalonia.Media.IBrush?> subject) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.BackdropBrushProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T BackdropBrush<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs, IObserver<Avalonia.Media.IBrush?> changed) where T : Avalonia.Controls.DrawerPage 
   => control._setEx(Avalonia.Controls.DrawerPage.BackdropBrushProperty!, obs, changed);


 // HorizontalContentAlignment

/*ValueSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.DrawerPage 
{
    control.HorizontalContentAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.HorizontalContentAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T HorizontalContentAlignment<T>(this T control, IObservable<Avalonia.Layout.HorizontalAlignment> obs) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.HorizontalContentAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T HorizontalContentAlignment<T>(this T control, ISubject<Avalonia.Layout.HorizontalAlignment> subject) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.HorizontalContentAlignmentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T HorizontalContentAlignment<T>(this T control, IObservable<Avalonia.Layout.HorizontalAlignment> obs, IObserver<Avalonia.Layout.HorizontalAlignment> changed) where T : Avalonia.Controls.DrawerPage 
   => control._setEx(Avalonia.Controls.DrawerPage.HorizontalContentAlignmentProperty!, obs, changed);


 // VerticalContentAlignment

/*ValueSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.DrawerPage 
{
    control.VerticalContentAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.VerticalContentAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T VerticalContentAlignment<T>(this T control, IObservable<Avalonia.Layout.VerticalAlignment> obs) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.VerticalContentAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T VerticalContentAlignment<T>(this T control, ISubject<Avalonia.Layout.VerticalAlignment> subject) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.VerticalContentAlignmentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T VerticalContentAlignment<T>(this T control, IObservable<Avalonia.Layout.VerticalAlignment> obs, IObserver<Avalonia.Layout.VerticalAlignment> changed) where T : Avalonia.Controls.DrawerPage 
   => control._setEx(Avalonia.Controls.DrawerPage.VerticalContentAlignmentProperty!, obs, changed);


 // DisplayMode

/*ValueSetterGenerator*/
public static T DisplayMode<T>(this T control, Avalonia.Controls.SplitViewDisplayMode value) where T : Avalonia.Controls.DrawerPage 
{
    control.DisplayMode = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DisplayMode<T>(this T control, Func<Avalonia.Controls.SplitViewDisplayMode> func) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DisplayModeProperty!, func);

/*SetterFromObservableGenerator*/
public static T DisplayMode<T>(this T control, IObservable<Avalonia.Controls.SplitViewDisplayMode> obs) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DisplayModeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DisplayMode<T>(this T control, ISubject<Avalonia.Controls.SplitViewDisplayMode> subject) where T : Avalonia.Controls.DrawerPage 
   => control._set(Avalonia.Controls.DrawerPage.DisplayModeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DisplayMode<T>(this T control, IObservable<Avalonia.Controls.SplitViewDisplayMode> obs, IObserver<Avalonia.Controls.SplitViewDisplayMode> changed) where T : Avalonia.Controls.DrawerPage 
   => control._setEx(Avalonia.Controls.DrawerPage.DisplayModeProperty!, obs, changed);



//================= Events ======================//
 // Opened

/*ActionToEventGenerator*/
public static T OnOpened<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.DrawerPage 
{
  control.AddHandler(Avalonia.Controls.DrawerPage.OpenedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.DrawerPage.OpenedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxOpened<T>(this T control, IObserver<Avalonia.Interactivity.RoutedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.DrawerPage 
{
  control.AddHandler(Avalonia.Controls.DrawerPage.OpenedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.DrawerPage.OpenedEvent.RoutingStrategies);
  return control;
}



 // Closing

/*ActionToEventGenerator*/
public static T OnClosing<T>(this T control, Action<Avalonia.Controls.DrawerClosingEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.DrawerPage 
{
  control.AddHandler(Avalonia.Controls.DrawerPage.ClosingEvent, (_, args) => action(args), routes ?? Avalonia.Controls.DrawerPage.ClosingEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxClosing<T>(this T control, IObserver<Avalonia.Controls.DrawerClosingEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.DrawerPage 
{
  control.AddHandler(Avalonia.Controls.DrawerPage.ClosingEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.DrawerPage.ClosingEvent.RoutingStrategies);
  return control;
}



 // Closed

/*ActionToEventGenerator*/
public static T OnClosed<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.DrawerPage 
{
  control.AddHandler(Avalonia.Controls.DrawerPage.ClosedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.DrawerPage.ClosedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxClosed<T>(this T control, IObserver<Avalonia.Interactivity.RoutedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.DrawerPage 
{
  control.AddHandler(Avalonia.Controls.DrawerPage.ClosedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.DrawerPage.ClosedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // Drawer

/*ValueStyleSetterGenerator*/
public static Style<T> Drawer<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Drawer<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerProperty, binding);


 // Content

/*ValueStyleSetterGenerator*/
public static Style<T> Content<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.ContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Content<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.ContentProperty, binding);


 // IsOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.IsOpenProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsOpen<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.IsOpenProperty, binding);


 // DrawerLength

/*ValueStyleSetterGenerator*/
public static Style<T> DrawerLength<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerLengthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DrawerLength<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerLengthProperty, binding);


 // CompactDrawerLength

/*ValueStyleSetterGenerator*/
public static Style<T> CompactDrawerLength<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.CompactDrawerLengthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CompactDrawerLength<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.CompactDrawerLengthProperty, binding);


 // DrawerBreakpointLength

/*ValueStyleSetterGenerator*/
public static Style<T> DrawerBreakpointLength<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerBreakpointLengthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DrawerBreakpointLength<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerBreakpointLengthProperty, binding);


 // IsGestureEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsGestureEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.IsGestureEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsGestureEnabled<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.IsGestureEnabledProperty, binding);


 // DrawerBehavior

/*ValueStyleSetterGenerator*/
public static Style<T> DrawerBehavior<T>(this Style<T> style, Avalonia.Controls.DrawerBehavior value) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerBehaviorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DrawerBehavior<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerBehaviorProperty, binding);


 // DrawerLayoutBehavior

/*ValueStyleSetterGenerator*/
public static Style<T> DrawerLayoutBehavior<T>(this Style<T> style, Avalonia.Controls.DrawerLayoutBehavior value) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerLayoutBehaviorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DrawerLayoutBehavior<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerLayoutBehaviorProperty, binding);


 // DrawerPlacement

/*ValueStyleSetterGenerator*/
public static Style<T> DrawerPlacement<T>(this Style<T> style, Avalonia.Controls.DrawerPlacement value) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerPlacementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DrawerPlacement<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerPlacementProperty, binding);


 // DrawerHeader

/*ValueStyleSetterGenerator*/
public static Style<T> DrawerHeader<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerHeaderProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DrawerHeader<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerHeaderProperty, binding);


 // DrawerFooter

/*ValueStyleSetterGenerator*/
public static Style<T> DrawerFooter<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerFooterProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DrawerFooter<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerFooterProperty, binding);


 // DrawerHeaderTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> DrawerHeaderTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerHeaderTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DrawerHeaderTemplate<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerHeaderTemplateProperty, binding);


 // DrawerFooterTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> DrawerFooterTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerFooterTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DrawerFooterTemplate<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerFooterTemplateProperty, binding);


 // DrawerIcon

/*ValueStyleSetterGenerator*/
public static Style<T> DrawerIcon<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerIconProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DrawerIcon<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerIconProperty, binding);


 // DrawerIconTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> DrawerIconTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerIconTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DrawerIconTemplate<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerIconTemplateProperty, binding);


 // DrawerTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> DrawerTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DrawerTemplate<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerTemplateProperty, binding);


 // ContentTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> ContentTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.ContentTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ContentTemplate<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.ContentTemplateProperty, binding);


 // DrawerBackground

/*ValueStyleSetterGenerator*/
public static Style<T> DrawerBackground<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerBackgroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DrawerBackground<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerBackgroundProperty, binding);


 // DrawerHeaderBackground

/*ValueStyleSetterGenerator*/
public static Style<T> DrawerHeaderBackground<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerHeaderBackgroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DrawerHeaderBackground<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerHeaderBackgroundProperty, binding);


 // DrawerHeaderForeground

/*ValueStyleSetterGenerator*/
public static Style<T> DrawerHeaderForeground<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerHeaderForegroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DrawerHeaderForeground<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerHeaderForegroundProperty, binding);


 // DrawerFooterBackground

/*ValueStyleSetterGenerator*/
public static Style<T> DrawerFooterBackground<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerFooterBackgroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DrawerFooterBackground<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerFooterBackgroundProperty, binding);


 // DrawerFooterForeground

/*ValueStyleSetterGenerator*/
public static Style<T> DrawerFooterForeground<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerFooterForegroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DrawerFooterForeground<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DrawerFooterForegroundProperty, binding);


 // BackdropBrush

/*ValueStyleSetterGenerator*/
public static Style<T> BackdropBrush<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.BackdropBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BackdropBrush<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.BackdropBrushProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.HorizontalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.VerticalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.VerticalContentAlignmentProperty, binding);


 // DisplayMode

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayMode<T>(this Style<T> style, Avalonia.Controls.SplitViewDisplayMode value) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DisplayModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayMode<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.DrawerPage 
=> style._addSetter(Avalonia.Controls.DrawerPage.DisplayModeProperty, binding);



}

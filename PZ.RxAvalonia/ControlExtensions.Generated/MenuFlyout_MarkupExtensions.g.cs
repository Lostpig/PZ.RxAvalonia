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
public static partial class MenuFlyout_MarkupExtensions
{
//================= Properties ======================//
 // ItemsSource

/*ValueSetterGenerator*/
public static T ItemsSource<T>(this T control, System.Collections.IEnumerable? value) where T : Avalonia.Controls.MenuFlyout 
{
    control.ItemsSource = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ItemsSource<T>(this T control, Func<System.Collections.IEnumerable?> func) where T : Avalonia.Controls.MenuFlyout 
   => control._set(Avalonia.Controls.MenuFlyout.ItemsSourceProperty!, func);

/*SetterFromObservableGenerator*/
public static T ItemsSource<T>(this T control, IObservable<System.Collections.IEnumerable?> obs) where T : Avalonia.Controls.MenuFlyout 
   => control._set(Avalonia.Controls.MenuFlyout.ItemsSourceProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ItemsSource<T>(this T control, ISubject<System.Collections.IEnumerable?> subject) where T : Avalonia.Controls.MenuFlyout 
   => control._set(Avalonia.Controls.MenuFlyout.ItemsSourceProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ItemsSource<T>(this T control, IObservable<System.Collections.IEnumerable?> obs, IObserver<System.Collections.IEnumerable?> changed) where T : Avalonia.Controls.MenuFlyout 
   => control._setEx(Avalonia.Controls.MenuFlyout.ItemsSourceProperty!, obs, changed);


 // ItemTemplate

/*ValueSetterGenerator*/
public static T ItemTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.MenuFlyout 
{
    control.ItemTemplate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ItemTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate?> func) where T : Avalonia.Controls.MenuFlyout 
   => control._set(Avalonia.Controls.MenuFlyout.ItemTemplateProperty!, func);

/*SetterFromObservableGenerator*/
public static T ItemTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs) where T : Avalonia.Controls.MenuFlyout 
   => control._set(Avalonia.Controls.MenuFlyout.ItemTemplateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ItemTemplate<T>(this T control, ISubject<Avalonia.Controls.Templates.IDataTemplate?> subject) where T : Avalonia.Controls.MenuFlyout 
   => control._set(Avalonia.Controls.MenuFlyout.ItemTemplateProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ItemTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs, IObserver<Avalonia.Controls.Templates.IDataTemplate?> changed) where T : Avalonia.Controls.MenuFlyout 
   => control._setEx(Avalonia.Controls.MenuFlyout.ItemTemplateProperty!, obs, changed);


 // ItemContainerTheme

/*ValueSetterGenerator*/
public static T ItemContainerTheme<T>(this T control, Avalonia.Styling.ControlTheme? value) where T : Avalonia.Controls.MenuFlyout 
{
    control.ItemContainerTheme = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ItemContainerTheme<T>(this T control, Func<Avalonia.Styling.ControlTheme?> func) where T : Avalonia.Controls.MenuFlyout 
   => control._set(Avalonia.Controls.MenuFlyout.ItemContainerThemeProperty!, func);

/*SetterFromObservableGenerator*/
public static T ItemContainerTheme<T>(this T control, IObservable<Avalonia.Styling.ControlTheme?> obs) where T : Avalonia.Controls.MenuFlyout 
   => control._set(Avalonia.Controls.MenuFlyout.ItemContainerThemeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ItemContainerTheme<T>(this T control, ISubject<Avalonia.Styling.ControlTheme?> subject) where T : Avalonia.Controls.MenuFlyout 
   => control._set(Avalonia.Controls.MenuFlyout.ItemContainerThemeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ItemContainerTheme<T>(this T control, IObservable<Avalonia.Styling.ControlTheme?> obs, IObserver<Avalonia.Styling.ControlTheme?> changed) where T : Avalonia.Controls.MenuFlyout 
   => control._setEx(Avalonia.Controls.MenuFlyout.ItemContainerThemeProperty!, obs, changed);


 // FlyoutPresenterTheme

/*ValueSetterGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, Avalonia.Styling.ControlTheme? value) where T : Avalonia.Controls.MenuFlyout 
{
    control.FlyoutPresenterTheme = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, Func<Avalonia.Styling.ControlTheme?> func) where T : Avalonia.Controls.MenuFlyout 
   => control._set(Avalonia.Controls.MenuFlyout.FlyoutPresenterThemeProperty!, func);

/*SetterFromObservableGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, IObservable<Avalonia.Styling.ControlTheme?> obs) where T : Avalonia.Controls.MenuFlyout 
   => control._set(Avalonia.Controls.MenuFlyout.FlyoutPresenterThemeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, ISubject<Avalonia.Styling.ControlTheme?> subject) where T : Avalonia.Controls.MenuFlyout 
   => control._set(Avalonia.Controls.MenuFlyout.FlyoutPresenterThemeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, IObservable<Avalonia.Styling.ControlTheme?> obs, IObserver<Avalonia.Styling.ControlTheme?> changed) where T : Avalonia.Controls.MenuFlyout 
   => control._setEx(Avalonia.Controls.MenuFlyout.FlyoutPresenterThemeProperty!, obs, changed);



}

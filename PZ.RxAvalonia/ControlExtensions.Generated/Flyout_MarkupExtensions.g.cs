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
public static partial class Flyout_MarkupExtensions
{
//================= Properties ======================//
 // Content

/*ValueSetterGenerator*/
public static T Content<T>(this T control, System.Object value) where T : Avalonia.Controls.Flyout 
{
    control.Content = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Content<T>(this T control, Func<System.Object> func) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.ContentProperty!, func);

/*SetterFromObservableGenerator*/
public static T Content<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.ContentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Content<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.ContentProperty!, subject);


 // ContentTemplate

/*ValueSetterGenerator*/
public static T ContentTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.Flyout 
{
    control.ContentTemplate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ContentTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.ContentTemplateProperty!, func);

/*SetterFromObservableGenerator*/
public static T ContentTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate> obs) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.ContentTemplateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ContentTemplate<T>(this T control, ISubject<Avalonia.Controls.Templates.IDataTemplate> subject) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.ContentTemplateProperty!, subject);


 // FlyoutPresenterTheme

/*ValueSetterGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, Avalonia.Styling.ControlTheme value) where T : Avalonia.Controls.Flyout 
{
    control.FlyoutPresenterTheme = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, Func<Avalonia.Styling.ControlTheme> func) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.FlyoutPresenterThemeProperty!, func);

/*SetterFromObservableGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, IObservable<Avalonia.Styling.ControlTheme> obs) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.FlyoutPresenterThemeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, ISubject<Avalonia.Styling.ControlTheme> subject) where T : Avalonia.Controls.Flyout 
   => control._set(Avalonia.Controls.Flyout.FlyoutPresenterThemeProperty!, subject);



}

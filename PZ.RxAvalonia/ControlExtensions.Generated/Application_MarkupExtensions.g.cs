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
public static partial class Application_MarkupExtensions
{
//================= Properties ======================//
 // DataContext

/*ValueSetterGenerator*/
public static T DataContext<T>(this T control, System.Object value) where T : Avalonia.Application 
{
    control.DataContext = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DataContext<T>(this T control, Func<System.Object> func) where T : Avalonia.Application 
   => control._set(Avalonia.Application.DataContextProperty!, func);

/*SetterFromObservableGenerator*/
public static T DataContext<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.Application 
   => control._set(Avalonia.Application.DataContextProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DataContext<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.Application 
   => control._set(Avalonia.Application.DataContextProperty!, subject);


 // RequestedThemeVariant

/*ValueSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, Avalonia.Styling.ThemeVariant value) where T : Avalonia.Application 
{
    control.RequestedThemeVariant = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T RequestedThemeVariant<T>(this T control, Func<Avalonia.Styling.ThemeVariant> func) where T : Avalonia.Application 
   => control._set(Avalonia.Application.RequestedThemeVariantProperty!, func);

/*SetterFromObservableGenerator*/
public static T RequestedThemeVariant<T>(this T control, IObservable<Avalonia.Styling.ThemeVariant> obs) where T : Avalonia.Application 
   => control._set(Avalonia.Application.RequestedThemeVariantProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T RequestedThemeVariant<T>(this T control, ISubject<Avalonia.Styling.ThemeVariant> subject) where T : Avalonia.Application 
   => control._set(Avalonia.Application.RequestedThemeVariantProperty!, subject);


 // Name

/*ValueSetterGenerator*/
public static T Name<T>(this T control, System.String value) where T : Avalonia.Application 
{
    control.Name = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Name<T>(this T control, Func<System.String> func) where T : Avalonia.Application 
   => control._set(Avalonia.Application.NameProperty!, func);

/*SetterFromObservableGenerator*/
public static T Name<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Application 
   => control._set(Avalonia.Application.NameProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Name<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Application 
   => control._set(Avalonia.Application.NameProperty!, subject);



//================= Events ======================//
 // ResourcesChanged

/*ActionToEventGenerator*/
public static T OnResourcesChanged<T>(this T control, Action<Avalonia.Controls.ResourcesChangedEventArgs> action) where T : Avalonia.Application  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ResourcesChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ResourcesChanged += h);


 // UrlsOpened

/*ActionToEventGenerator*/
[Obsolete]public static T OnUrlsOpened<T>(this T control, Action<Avalonia.UrlOpenedEventArgs> action) where T : Avalonia.Application  => 
 control._setEvent((System.EventHandler<Avalonia.UrlOpenedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.UrlsOpened += h);


 // ActualThemeVariantChanged

/*ActionToEventGenerator*/
public static T OnActualThemeVariantChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Application  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.ActualThemeVariantChanged += h);



}

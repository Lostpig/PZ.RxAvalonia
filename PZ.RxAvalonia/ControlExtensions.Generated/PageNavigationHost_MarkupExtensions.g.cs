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
public static partial class PageNavigationHost_MarkupExtensions
{
//================= Properties ======================//
 // Page

/*ValueSetterGenerator*/
public static T Page<T>(this T control, Avalonia.Controls.Page? value) where T : Avalonia.Controls.PageNavigationHost 
{
    control.Page = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Page<T>(this T control, Func<Avalonia.Controls.Page?> func) where T : Avalonia.Controls.PageNavigationHost 
   => control._set(Avalonia.Controls.PageNavigationHost.PageProperty!, func);

/*SetterFromObservableGenerator*/
public static T Page<T>(this T control, IObservable<Avalonia.Controls.Page?> obs) where T : Avalonia.Controls.PageNavigationHost 
   => control._set(Avalonia.Controls.PageNavigationHost.PageProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Page<T>(this T control, ISubject<Avalonia.Controls.Page?> subject) where T : Avalonia.Controls.PageNavigationHost 
   => control._set(Avalonia.Controls.PageNavigationHost.PageProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Page<T>(this T control, IObservable<Avalonia.Controls.Page?> obs, IObserver<Avalonia.Controls.Page?> changed) where T : Avalonia.Controls.PageNavigationHost 
   => control._setEx(Avalonia.Controls.PageNavigationHost.PageProperty!, obs, changed);



//================= Styles ======================//
 // Page

/*ValueStyleSetterGenerator*/
public static Style<T> Page<T>(this Style<T> style, Avalonia.Controls.Page? value) where T : Avalonia.Controls.PageNavigationHost 
=> style._addSetter(Avalonia.Controls.PageNavigationHost.PageProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Page<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.PageNavigationHost 
=> style._addSetter(Avalonia.Controls.PageNavigationHost.PageProperty, binding);



}

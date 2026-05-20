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
public static partial class MultiPage_MarkupExtensions
{
//================= Properties ======================//
 // Pages

/*ValueSetterGenerator*/
public static T Pages<T>(this T control, System.Collections.Generic.IEnumerable<Avalonia.Controls.Page> value) where T : Avalonia.Controls.MultiPage 
{
    control.Pages = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Pages<T>(this T control, Func<System.Collections.Generic.IEnumerable<Avalonia.Controls.Page>> func) where T : Avalonia.Controls.MultiPage 
   => control._set(Avalonia.Controls.MultiPage.PagesProperty!, func);

/*SetterFromObservableGenerator*/
public static T Pages<T>(this T control, IObservable<System.Collections.Generic.IEnumerable<Avalonia.Controls.Page>> obs) where T : Avalonia.Controls.MultiPage 
   => control._set(Avalonia.Controls.MultiPage.PagesProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Pages<T>(this T control, ISubject<System.Collections.Generic.IEnumerable<Avalonia.Controls.Page>> subject) where T : Avalonia.Controls.MultiPage 
   => control._set(Avalonia.Controls.MultiPage.PagesProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Pages<T>(this T control, IObservable<System.Collections.Generic.IEnumerable<Avalonia.Controls.Page>> obs, IObserver<System.Collections.Generic.IEnumerable<Avalonia.Controls.Page>> changed) where T : Avalonia.Controls.MultiPage 
   => control._setEx(Avalonia.Controls.MultiPage.PagesProperty!, obs, changed);


 // ItemsSource

/*ValueSetterGenerator*/
public static T ItemsSource<T>(this T control, System.Collections.IEnumerable? value) where T : Avalonia.Controls.MultiPage 
{
    control.ItemsSource = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ItemsSource<T>(this T control, Func<System.Collections.IEnumerable?> func) where T : Avalonia.Controls.MultiPage 
   => control._set(Avalonia.Controls.MultiPage.ItemsSourceProperty!, func);

/*SetterFromObservableGenerator*/
public static T ItemsSource<T>(this T control, IObservable<System.Collections.IEnumerable?> obs) where T : Avalonia.Controls.MultiPage 
   => control._set(Avalonia.Controls.MultiPage.ItemsSourceProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ItemsSource<T>(this T control, ISubject<System.Collections.IEnumerable?> subject) where T : Avalonia.Controls.MultiPage 
   => control._set(Avalonia.Controls.MultiPage.ItemsSourceProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ItemsSource<T>(this T control, IObservable<System.Collections.IEnumerable?> obs, IObserver<System.Collections.IEnumerable?> changed) where T : Avalonia.Controls.MultiPage 
   => control._setEx(Avalonia.Controls.MultiPage.ItemsSourceProperty!, obs, changed);


 // PageTemplate

/*ValueSetterGenerator*/
public static T PageTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.MultiPage 
{
    control.PageTemplate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PageTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate?> func) where T : Avalonia.Controls.MultiPage 
   => control._set(Avalonia.Controls.MultiPage.PageTemplateProperty!, func);

/*SetterFromObservableGenerator*/
public static T PageTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs) where T : Avalonia.Controls.MultiPage 
   => control._set(Avalonia.Controls.MultiPage.PageTemplateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PageTemplate<T>(this T control, ISubject<Avalonia.Controls.Templates.IDataTemplate?> subject) where T : Avalonia.Controls.MultiPage 
   => control._set(Avalonia.Controls.MultiPage.PageTemplateProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T PageTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs, IObserver<Avalonia.Controls.Templates.IDataTemplate?> changed) where T : Avalonia.Controls.MultiPage 
   => control._setEx(Avalonia.Controls.MultiPage.PageTemplateProperty!, obs, changed);



//================= Events ======================//
 // CurrentPageChanged

/*ActionToEventGenerator*/
public static T OnCurrentPageChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.MultiPage  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.CurrentPageChanged += h);

/*ReactiveEventGenerator*/
public static T RxCurrentPageChanged<T>(this T control, IObserver<System.EventArgs> observer) where T : Avalonia.Controls.MultiPage  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => observer.OnNext((arg1))), h => control.CurrentPageChanged += h);


 // PagesChanged

/*ActionToEventGenerator*/
public static T OnPagesChanged<T>(this T control, Action<System.Collections.Specialized.NotifyCollectionChangedEventArgs> action) where T : Avalonia.Controls.MultiPage  => 
 control._setEvent((System.EventHandler<System.Collections.Specialized.NotifyCollectionChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PagesChanged += h);

/*ReactiveEventGenerator*/
public static T RxPagesChanged<T>(this T control, IObserver<System.Collections.Specialized.NotifyCollectionChangedEventArgs> observer) where T : Avalonia.Controls.MultiPage  => 
 control._setEvent((System.EventHandler<System.Collections.Specialized.NotifyCollectionChangedEventArgs>) ((arg0, arg1) => observer.OnNext((arg1))), h => control.PagesChanged += h);



//================= Styles ======================//
 // Pages

/*ValueStyleSetterGenerator*/
public static Style<T> Pages<T>(this Style<T> style, System.Collections.Generic.IEnumerable<Avalonia.Controls.Page> value) where T : Avalonia.Controls.MultiPage 
=> style._addSetter(Avalonia.Controls.MultiPage.PagesProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Pages<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.MultiPage 
=> style._addSetter(Avalonia.Controls.MultiPage.PagesProperty, binding);


 // ItemsSource

/*ValueStyleSetterGenerator*/
public static Style<T> ItemsSource<T>(this Style<T> style, System.Collections.IEnumerable? value) where T : Avalonia.Controls.MultiPage 
=> style._addSetter(Avalonia.Controls.MultiPage.ItemsSourceProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemsSource<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.MultiPage 
=> style._addSetter(Avalonia.Controls.MultiPage.ItemsSourceProperty, binding);


 // PageTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> PageTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.MultiPage 
=> style._addSetter(Avalonia.Controls.MultiPage.PageTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PageTemplate<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.MultiPage 
=> style._addSetter(Avalonia.Controls.MultiPage.PageTemplateProperty, binding);



}

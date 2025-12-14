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
public static partial class TreeView_MarkupExtensions
{
//================= Properties ======================//
 // AutoScrollToSelectedItem

/*ValueSetterGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TreeView 
{
    control.AutoScrollToSelectedItem = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty!, func);

/*SetterFromObservableGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.TreeView 
   => control._setEx(Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty!, obs, changed);


 // SelectedItem

/*ValueSetterGenerator*/
public static T SelectedItem<T>(this T control, System.Object value) where T : Avalonia.Controls.TreeView 
{
    control.SelectedItem = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectedItem<T>(this T control, Func<System.Object> func) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectedItemProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectedItem<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectedItemProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectedItem<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectedItemProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SelectedItem<T>(this T control, IObservable<System.Object> obs, IObserver<System.Object> changed) where T : Avalonia.Controls.TreeView 
   => control._setEx(Avalonia.Controls.TreeView.SelectedItemProperty!, obs, changed);


 // SelectedItems

/*ValueSetterGenerator*/
public static T SelectedItems<T>(this T control, System.Collections.IList value) where T : Avalonia.Controls.TreeView 
{
    control.SelectedItems = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectedItems<T>(this T control, Func<System.Collections.IList> func) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectedItemsProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectedItems<T>(this T control, IObservable<System.Collections.IList> obs) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectedItemsProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectedItems<T>(this T control, ISubject<System.Collections.IList> subject) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectedItemsProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SelectedItems<T>(this T control, IObservable<System.Collections.IList> obs, IObserver<System.Collections.IList> changed) where T : Avalonia.Controls.TreeView 
   => control._setEx(Avalonia.Controls.TreeView.SelectedItemsProperty!, obs, changed);


 // SelectionMode

/*ValueSetterGenerator*/
public static T SelectionMode<T>(this T control, Avalonia.Controls.SelectionMode value) where T : Avalonia.Controls.TreeView 
{
    control.SelectionMode = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectionMode<T>(this T control, Func<Avalonia.Controls.SelectionMode> func) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectionModeProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectionMode<T>(this T control, IObservable<Avalonia.Controls.SelectionMode> obs) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectionModeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectionMode<T>(this T control, ISubject<Avalonia.Controls.SelectionMode> subject) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectionModeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SelectionMode<T>(this T control, IObservable<Avalonia.Controls.SelectionMode> obs, IObserver<Avalonia.Controls.SelectionMode> changed) where T : Avalonia.Controls.TreeView 
   => control._setEx(Avalonia.Controls.TreeView.SelectionModeProperty!, obs, changed);



//================= Events ======================//
 // SelectionChanged

/*ActionToEventGenerator*/
public static T OnSelectionChanged<T>(this T control, Action<Avalonia.Controls.SelectionChangedEventArgs> action) where T : Avalonia.Controls.TreeView  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.SelectionChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.SelectionChanged += h);

/*ReactiveEventGenerator*/
public static T RxSelectionChanged<T>(this T control, IObserver<Avalonia.Controls.SelectionChangedEventArgs> observer) where T : Avalonia.Controls.TreeView  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.SelectionChangedEventArgs>) ((arg0, arg1) => observer.OnNext((arg1))), h => control.SelectionChanged += h);



//================= Styles ======================//
 // AutoScrollToSelectedItem

/*ValueStyleSetterGenerator*/
public static Style<T> AutoScrollToSelectedItem<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TreeView 
=> style._addSetter(Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AutoScrollToSelectedItem<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TreeView 
=> style._addSetter(Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty, binding);


 // SelectionMode

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionMode<T>(this Style<T> style, Avalonia.Controls.SelectionMode value) where T : Avalonia.Controls.TreeView 
=> style._addSetter(Avalonia.Controls.TreeView.SelectionModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TreeView 
=> style._addSetter(Avalonia.Controls.TreeView.SelectionModeProperty, binding);



}

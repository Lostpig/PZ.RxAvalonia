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
public static partial class SelectingItemsControl_MarkupExtensions
{
//================= Properties ======================//
 // AutoScrollToSelectedItem

/*ValueSetterGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
{
    control.AutoScrollToSelectedItem = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty!, func);

/*SetterFromObservableGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty!, obs, changed);


 // SelectedIndex

/*ValueSetterGenerator*/
public static T SelectedIndex<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
{
    control.SelectedIndex = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectedIndex<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectedIndex<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectedIndex<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SelectedIndex<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty!, obs, changed);


 // SelectedItem

/*ValueSetterGenerator*/
public static T SelectedItem<T>(this T control, System.Object? value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
{
    control.SelectedItem = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectedItem<T>(this T control, Func<System.Object?> func) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectedItem<T>(this T control, IObservable<System.Object?> obs) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectedItem<T>(this T control, ISubject<System.Object?> subject) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SelectedItem<T>(this T control, IObservable<System.Object?> obs, IObserver<System.Object?> changed) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty!, obs, changed);


 // SelectedValue

/*ValueSetterGenerator*/
public static T SelectedValue<T>(this T control, System.Object? value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
{
    control.SelectedValue = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectedValue<T>(this T control, Func<System.Object?> func) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectedValue<T>(this T control, IObservable<System.Object?> obs) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectedValue<T>(this T control, ISubject<System.Object?> subject) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SelectedValue<T>(this T control, IObservable<System.Object?> obs, IObserver<System.Object?> changed) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty!, obs, changed);


 // SelectedValueBinding

/*ValueSetterGenerator*/
public static T SelectedValueBinding<T>(this T control, Avalonia.Data.IBinding? value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
{
    control.SelectedValueBinding = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectedValueBinding<T>(this T control, Func<Avalonia.Data.IBinding?> func) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueBindingProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectedValueBinding<T>(this T control, IObservable<Avalonia.Data.IBinding?> obs) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueBindingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectedValueBinding<T>(this T control, ISubject<Avalonia.Data.IBinding?> subject) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueBindingProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SelectedValueBinding<T>(this T control, IObservable<Avalonia.Data.IBinding?> obs, IObserver<Avalonia.Data.IBinding?> changed) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueBindingProperty!, obs, changed);


 // IsTextSearchEnabled

/*ValueSetterGenerator*/
public static T IsTextSearchEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
{
    control.IsTextSearchEnabled = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsTextSearchEnabled<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsTextSearchEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsTextSearchEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsTextSearchEnabled<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty!, obs, changed);


 // WrapSelection

/*ValueSetterGenerator*/
public static T WrapSelection<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
{
    control.WrapSelection = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T WrapSelection<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty!, func);

/*SetterFromObservableGenerator*/
public static T WrapSelection<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T WrapSelection<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T WrapSelection<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty!, obs, changed);



//================= Events ======================//
 // SelectionChanged

/*ActionToEventGenerator*/
public static T OnSelectionChanged<T>(this T control, Action<Avalonia.Controls.SelectionChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
{
  control.AddHandler(Avalonia.Controls.Primitives.SelectingItemsControl.SelectionChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Primitives.SelectingItemsControl.SelectionChangedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxSelectionChanged<T>(this T control, IObserver<Avalonia.Controls.SelectionChangedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
{
  control.AddHandler(Avalonia.Controls.Primitives.SelectingItemsControl.SelectionChangedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.Primitives.SelectingItemsControl.SelectionChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // AutoScrollToSelectedItem

/*ValueStyleSetterGenerator*/
public static Style<T> AutoScrollToSelectedItem<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AutoScrollToSelectedItem<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty, binding);


 // SelectedValue

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedValue<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedValue<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty, binding);


 // SelectedValueBinding

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedValueBinding<T>(this Style<T> style, Avalonia.Data.IBinding? value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueBindingProperty!, value!);

/*BindingStyleSetterGenerator*/
//Skipped SelectedValueBinding because already exist in value setters


 // IsTextSearchEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsTextSearchEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTextSearchEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty, binding);


 // WrapSelection

/*ValueStyleSetterGenerator*/
public static Style<T> WrapSelection<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> WrapSelection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty, binding);



}

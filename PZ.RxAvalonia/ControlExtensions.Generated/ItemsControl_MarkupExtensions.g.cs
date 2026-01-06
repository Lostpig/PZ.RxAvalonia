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
public static partial class ItemsControl_MarkupExtensions
{
//================= Properties ======================//
 // ItemContainerTheme

/*ValueSetterGenerator*/
public static T ItemContainerTheme<T>(this T control, Avalonia.Styling.ControlTheme? value) where T : Avalonia.Controls.ItemsControl 
{
    control.ItemContainerTheme = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ItemContainerTheme<T>(this T control, Func<Avalonia.Styling.ControlTheme?> func) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty!, func);

/*SetterFromObservableGenerator*/
public static T ItemContainerTheme<T>(this T control, IObservable<Avalonia.Styling.ControlTheme?> obs) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ItemContainerTheme<T>(this T control, ISubject<Avalonia.Styling.ControlTheme?> subject) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ItemContainerTheme<T>(this T control, IObservable<Avalonia.Styling.ControlTheme?> obs, IObserver<Avalonia.Styling.ControlTheme?> changed) where T : Avalonia.Controls.ItemsControl 
   => control._setEx(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty!, obs, changed);


 // ItemsPanel

/*ValueSetterGenerator*/
public static T ItemsPanel<T>(this T control, Avalonia.Controls.ITemplate<Avalonia.Controls.Panel> value) where T : Avalonia.Controls.ItemsControl 
{
    control.ItemsPanel = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ItemsPanel<T>(this T control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> func) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemsPanelProperty!, func);

/*SetterFromObservableGenerator*/
public static T ItemsPanel<T>(this T control, IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> obs) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemsPanelProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ItemsPanel<T>(this T control, ISubject<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> subject) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemsPanelProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ItemsPanel<T>(this T control, IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> obs, IObserver<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> changed) where T : Avalonia.Controls.ItemsControl 
   => control._setEx(Avalonia.Controls.ItemsControl.ItemsPanelProperty!, obs, changed);


 // ItemsSource

/*ValueSetterGenerator*/
public static T ItemsSource<T>(this T control, System.Collections.IEnumerable? value) where T : Avalonia.Controls.ItemsControl 
{
    control.ItemsSource = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ItemsSource<T>(this T control, Func<System.Collections.IEnumerable?> func) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemsSourceProperty!, func);

/*SetterFromObservableGenerator*/
public static T ItemsSource<T>(this T control, IObservable<System.Collections.IEnumerable?> obs) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemsSourceProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ItemsSource<T>(this T control, ISubject<System.Collections.IEnumerable?> subject) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemsSourceProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ItemsSource<T>(this T control, IObservable<System.Collections.IEnumerable?> obs, IObserver<System.Collections.IEnumerable?> changed) where T : Avalonia.Controls.ItemsControl 
   => control._setEx(Avalonia.Controls.ItemsControl.ItemsSourceProperty!, obs, changed);


 // ItemTemplate

/*ValueSetterGenerator*/
public static T ItemTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.ItemsControl 
{
    control.ItemTemplate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ItemTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate?> func) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemTemplateProperty!, func);

/*SetterFromObservableGenerator*/
public static T ItemTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemTemplateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ItemTemplate<T>(this T control, ISubject<Avalonia.Controls.Templates.IDataTemplate?> subject) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemTemplateProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ItemTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs, IObserver<Avalonia.Controls.Templates.IDataTemplate?> changed) where T : Avalonia.Controls.ItemsControl 
   => control._setEx(Avalonia.Controls.ItemsControl.ItemTemplateProperty!, obs, changed);


 // DisplayMemberBinding

/*ValueSetterGenerator*/
public static T DisplayMemberBinding<T>(this T control, Avalonia.Data.IBinding? value) where T : Avalonia.Controls.ItemsControl 
{
    control.DisplayMemberBinding = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DisplayMemberBinding<T>(this T control, Func<Avalonia.Data.IBinding?> func) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty!, func);

/*SetterFromObservableGenerator*/
public static T DisplayMemberBinding<T>(this T control, IObservable<Avalonia.Data.IBinding?> obs) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DisplayMemberBinding<T>(this T control, ISubject<Avalonia.Data.IBinding?> subject) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DisplayMemberBinding<T>(this T control, IObservable<Avalonia.Data.IBinding?> obs, IObserver<Avalonia.Data.IBinding?> changed) where T : Avalonia.Controls.ItemsControl 
   => control._setEx(Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty!, obs, changed);



//================= Events ======================//
 // PreparingContainer

/*ActionToEventGenerator*/
public static T OnPreparingContainer<T>(this T control, Action<Avalonia.Controls.ContainerPreparedEventArgs> action) where T : Avalonia.Controls.ItemsControl  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ContainerPreparedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PreparingContainer += h);

/*ReactiveEventGenerator*/
public static T RxPreparingContainer<T>(this T control, IObserver<Avalonia.Controls.ContainerPreparedEventArgs> observer) where T : Avalonia.Controls.ItemsControl  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ContainerPreparedEventArgs>) ((arg0, arg1) => observer.OnNext((arg1))), h => control.PreparingContainer += h);


 // ContainerPrepared

/*ActionToEventGenerator*/
public static T OnContainerPrepared<T>(this T control, Action<Avalonia.Controls.ContainerPreparedEventArgs> action) where T : Avalonia.Controls.ItemsControl  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ContainerPreparedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ContainerPrepared += h);

/*ReactiveEventGenerator*/
public static T RxContainerPrepared<T>(this T control, IObserver<Avalonia.Controls.ContainerPreparedEventArgs> observer) where T : Avalonia.Controls.ItemsControl  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ContainerPreparedEventArgs>) ((arg0, arg1) => observer.OnNext((arg1))), h => control.ContainerPrepared += h);


 // ContainerIndexChanged

/*ActionToEventGenerator*/
public static T OnContainerIndexChanged<T>(this T control, Action<Avalonia.Controls.ContainerIndexChangedEventArgs> action) where T : Avalonia.Controls.ItemsControl  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ContainerIndexChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ContainerIndexChanged += h);

/*ReactiveEventGenerator*/
public static T RxContainerIndexChanged<T>(this T control, IObserver<Avalonia.Controls.ContainerIndexChangedEventArgs> observer) where T : Avalonia.Controls.ItemsControl  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ContainerIndexChangedEventArgs>) ((arg0, arg1) => observer.OnNext((arg1))), h => control.ContainerIndexChanged += h);


 // ContainerClearing

/*ActionToEventGenerator*/
public static T OnContainerClearing<T>(this T control, Action<Avalonia.Controls.ContainerClearingEventArgs> action) where T : Avalonia.Controls.ItemsControl  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ContainerClearingEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ContainerClearing += h);

/*ReactiveEventGenerator*/
public static T RxContainerClearing<T>(this T control, IObserver<Avalonia.Controls.ContainerClearingEventArgs> observer) where T : Avalonia.Controls.ItemsControl  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ContainerClearingEventArgs>) ((arg0, arg1) => observer.OnNext((arg1))), h => control.ContainerClearing += h);



//================= Styles ======================//
 // ItemContainerTheme

/*ValueStyleSetterGenerator*/
public static Style<T> ItemContainerTheme<T>(this Style<T> style, Avalonia.Styling.ControlTheme? value) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemContainerTheme<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty, binding);


 // ItemsPanel

/*ValueStyleSetterGenerator*/
public static Style<T> ItemsPanel<T>(this Style<T> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Panel> value) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemsPanelProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemsPanel<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemsPanelProperty, binding);


 // ItemsSource

/*ValueStyleSetterGenerator*/
public static Style<T> ItemsSource<T>(this Style<T> style, System.Collections.IEnumerable? value) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemsSourceProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemsSource<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemsSourceProperty, binding);


 // ItemTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> ItemTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemTemplateProperty, binding);


 // DisplayMemberBinding

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayMemberBinding<T>(this Style<T> style, Avalonia.Data.IBinding? value) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty!, value!);

/*BindingStyleSetterGenerator*/
//Skipped DisplayMemberBinding because already exist in value setters



}

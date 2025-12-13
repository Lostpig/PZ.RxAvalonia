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
public static partial class DateTimePickerPanel_MarkupExtensions
{
//================= Properties ======================//
 // ItemHeight

/*ValueSetterGenerator*/
public static T ItemHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
{
    control.ItemHeight = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ItemHeight<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty!, func);

/*SetterFromObservableGenerator*/
public static T ItemHeight<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ItemHeight<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ItemHeight<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._setEx(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty!, obs, changed);


 // PanelType

/*ValueSetterGenerator*/
public static T PanelType<T>(this T control, Avalonia.Controls.Primitives.DateTimePickerPanelType value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
{
    control.PanelType = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PanelType<T>(this T control, Func<Avalonia.Controls.Primitives.DateTimePickerPanelType> func) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty!, func);

/*SetterFromObservableGenerator*/
public static T PanelType<T>(this T control, IObservable<Avalonia.Controls.Primitives.DateTimePickerPanelType> obs) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PanelType<T>(this T control, ISubject<Avalonia.Controls.Primitives.DateTimePickerPanelType> subject) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T PanelType<T>(this T control, IObservable<Avalonia.Controls.Primitives.DateTimePickerPanelType> obs, IObserver<Avalonia.Controls.Primitives.DateTimePickerPanelType> changed) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._setEx(Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty!, obs, changed);


 // ItemFormat

/*ValueSetterGenerator*/
public static T ItemFormat<T>(this T control, System.String value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
{
    control.ItemFormat = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ItemFormat<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty!, func);

/*SetterFromObservableGenerator*/
public static T ItemFormat<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ItemFormat<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ItemFormat<T>(this T control, IObservable<System.String> obs, IObserver<System.String> changed) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._setEx(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty!, obs, changed);


 // ShouldLoop

/*ValueSetterGenerator*/
public static T ShouldLoop<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
{
    control.ShouldLoop = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ShouldLoop<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty!, func);

/*SetterFromObservableGenerator*/
public static T ShouldLoop<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ShouldLoop<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ShouldLoop<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._setEx(Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty!, obs, changed);



//================= Events ======================//
 // ScrollInvalidated

/*ActionToEventGenerator*/
public static T OnScrollInvalidated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.DateTimePickerPanel  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.ScrollInvalidated += h);


 // SelectionChanged

/*ActionToEventGenerator*/
public static T OnSelectionChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.DateTimePickerPanel  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.SelectionChanged += h);



//================= Styles ======================//
 // ItemHeight

/*ValueStyleSetterGenerator*/
public static Style<T> ItemHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty, binding);


 // PanelType

/*ValueStyleSetterGenerator*/
public static Style<T> PanelType<T>(this Style<T> style, Avalonia.Controls.Primitives.DateTimePickerPanelType value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PanelType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty, binding);


 // ItemFormat

/*ValueStyleSetterGenerator*/
public static Style<T> ItemFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty, binding);


 // ShouldLoop

/*ValueStyleSetterGenerator*/
public static Style<T> ShouldLoop<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShouldLoop<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty, binding);



}

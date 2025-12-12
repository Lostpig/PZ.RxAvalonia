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
public static partial class RangeBase_MarkupExtensions
{
//================= Properties ======================//
 // Minimum

/*ValueSetterGenerator*/
public static T Minimum<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
{
    control.Minimum = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Minimum<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.MinimumProperty!, func);

/*SetterFromObservableGenerator*/
public static T Minimum<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.MinimumProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Minimum<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.MinimumProperty!, subject);


 // Maximum

/*ValueSetterGenerator*/
public static T Maximum<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
{
    control.Maximum = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Maximum<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.MaximumProperty!, func);

/*SetterFromObservableGenerator*/
public static T Maximum<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.MaximumProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Maximum<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.MaximumProperty!, subject);


 // Value

/*ValueSetterGenerator*/
public static T Value<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
{
    control.Value = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Value<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.ValueProperty!, func);

/*SetterFromObservableGenerator*/
public static T Value<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.ValueProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Value<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.ValueProperty!, subject);


 // SmallChange

/*ValueSetterGenerator*/
public static T SmallChange<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
{
    control.SmallChange = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SmallChange<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty!, func);

/*SetterFromObservableGenerator*/
public static T SmallChange<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SmallChange<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty!, subject);


 // LargeChange

/*ValueSetterGenerator*/
public static T LargeChange<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
{
    control.LargeChange = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T LargeChange<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty!, func);

/*SetterFromObservableGenerator*/
public static T LargeChange<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T LargeChange<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty!, subject);



//================= Events ======================//
 // ValueChanged

/*ActionToEventGenerator*/
public static T OnValueChanged<T>(this T control, Action<Avalonia.Controls.Primitives.RangeBaseValueChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Primitives.RangeBase 
{
  control.AddHandler(Avalonia.Controls.Primitives.RangeBase.ValueChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Primitives.RangeBase.ValueChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // Minimum

/*ValueStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.MinimumProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.MinimumProperty, binding);


 // Maximum

/*ValueStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.MaximumProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.MaximumProperty, binding);


 // Value

/*ValueStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.ValueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.ValueProperty, binding);


 // SmallChange

/*ValueStyleSetterGenerator*/
public static Style<T> SmallChange<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SmallChange<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty, binding);


 // LargeChange

/*ValueStyleSetterGenerator*/
public static Style<T> LargeChange<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LargeChange<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty, binding);



}

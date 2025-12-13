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
public static partial class RepeatButton_MarkupExtensions
{
//================= Properties ======================//
 // Interval

/*ValueSetterGenerator*/
public static T Interval<T>(this T control, System.Int32 value) where T : Avalonia.Controls.RepeatButton 
{
    control.Interval = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Interval<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.RepeatButton 
   => control._set(Avalonia.Controls.RepeatButton.IntervalProperty!, func);

/*SetterFromObservableGenerator*/
public static T Interval<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.RepeatButton 
   => control._set(Avalonia.Controls.RepeatButton.IntervalProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Interval<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.RepeatButton 
   => control._set(Avalonia.Controls.RepeatButton.IntervalProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Interval<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.RepeatButton 
   => control._setEx(Avalonia.Controls.RepeatButton.IntervalProperty!, obs, changed);


 // Delay

/*ValueSetterGenerator*/
public static T Delay<T>(this T control, System.Int32 value) where T : Avalonia.Controls.RepeatButton 
{
    control.Delay = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Delay<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.RepeatButton 
   => control._set(Avalonia.Controls.RepeatButton.DelayProperty!, func);

/*SetterFromObservableGenerator*/
public static T Delay<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.RepeatButton 
   => control._set(Avalonia.Controls.RepeatButton.DelayProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Delay<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.RepeatButton 
   => control._set(Avalonia.Controls.RepeatButton.DelayProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Delay<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.RepeatButton 
   => control._setEx(Avalonia.Controls.RepeatButton.DelayProperty!, obs, changed);



//================= Styles ======================//
 // Interval

/*ValueStyleSetterGenerator*/
public static Style<T> Interval<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.RepeatButton 
=> style._addSetter(Avalonia.Controls.RepeatButton.IntervalProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Interval<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.RepeatButton 
=> style._addSetter(Avalonia.Controls.RepeatButton.IntervalProperty, binding);


 // Delay

/*ValueStyleSetterGenerator*/
public static Style<T> Delay<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.RepeatButton 
=> style._addSetter(Avalonia.Controls.RepeatButton.DelayProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Delay<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.RepeatButton 
=> style._addSetter(Avalonia.Controls.RepeatButton.DelayProperty, binding);



}

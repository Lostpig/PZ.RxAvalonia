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
public static partial class TimePicker_MarkupExtensions
{
//================= Properties ======================//
 // MinuteIncrement

/*ValueSetterGenerator*/
public static T MinuteIncrement<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TimePicker 
{
    control.MinuteIncrement = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MinuteIncrement<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.MinuteIncrementProperty!, func);

/*SetterFromObservableGenerator*/
public static T MinuteIncrement<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.MinuteIncrementProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MinuteIncrement<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.MinuteIncrementProperty!, subject);


 // SecondIncrement

/*ValueSetterGenerator*/
public static T SecondIncrement<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TimePicker 
{
    control.SecondIncrement = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SecondIncrement<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.SecondIncrementProperty!, func);

/*SetterFromObservableGenerator*/
public static T SecondIncrement<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.SecondIncrementProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SecondIncrement<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.SecondIncrementProperty!, subject);


 // ClockIdentifier

/*ValueSetterGenerator*/
public static T ClockIdentifier<T>(this T control, System.String value) where T : Avalonia.Controls.TimePicker 
{
    control.ClockIdentifier = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ClockIdentifier<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.ClockIdentifierProperty!, func);

/*SetterFromObservableGenerator*/
public static T ClockIdentifier<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.ClockIdentifierProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ClockIdentifier<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.ClockIdentifierProperty!, subject);


 // UseSeconds

/*ValueSetterGenerator*/
public static T UseSeconds<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TimePicker 
{
    control.UseSeconds = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T UseSeconds<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.UseSecondsProperty!, func);

/*SetterFromObservableGenerator*/
public static T UseSeconds<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.UseSecondsProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T UseSeconds<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.UseSecondsProperty!, subject);


 // SelectedTime

/*ValueSetterGenerator*/
public static T SelectedTime<T>(this T control, System.Nullable<System.TimeSpan> value) where T : Avalonia.Controls.TimePicker 
{
    control.SelectedTime = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectedTime<T>(this T control, Func<System.Nullable<System.TimeSpan>> func) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.SelectedTimeProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectedTime<T>(this T control, IObservable<System.Nullable<System.TimeSpan>> obs) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.SelectedTimeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectedTime<T>(this T control, ISubject<System.Nullable<System.TimeSpan>> subject) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.SelectedTimeProperty!, subject);



//================= Events ======================//
 // SelectedTimeChanged

/*ActionToEventGenerator*/
public static T OnSelectedTimeChanged<T>(this T control, Action<Avalonia.Controls.TimePickerSelectedValueChangedEventArgs> action) where T : Avalonia.Controls.TimePicker  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.TimePickerSelectedValueChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.SelectedTimeChanged += h);



//================= Styles ======================//
 // MinuteIncrement

/*ValueStyleSetterGenerator*/
public static Style<T> MinuteIncrement<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.MinuteIncrementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinuteIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.MinuteIncrementProperty, binding);


 // SecondIncrement

/*ValueStyleSetterGenerator*/
public static Style<T> SecondIncrement<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.SecondIncrementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SecondIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.SecondIncrementProperty, binding);


 // ClockIdentifier

/*ValueStyleSetterGenerator*/
public static Style<T> ClockIdentifier<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.ClockIdentifierProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ClockIdentifier<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.ClockIdentifierProperty, binding);


 // UseSeconds

/*ValueStyleSetterGenerator*/
public static Style<T> UseSeconds<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.UseSecondsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UseSeconds<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.UseSecondsProperty, binding);


 // SelectedTime

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedTime<T>(this Style<T> style, System.Nullable<System.TimeSpan> value) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.SelectedTimeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedTime<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.SelectedTimeProperty, binding);



}

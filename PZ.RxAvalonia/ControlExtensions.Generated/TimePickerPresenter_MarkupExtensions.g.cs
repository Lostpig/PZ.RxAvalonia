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
public static partial class TimePickerPresenter_MarkupExtensions
{
//================= Properties ======================//
 // MinuteIncrement

/*ValueSetterGenerator*/
public static T MinuteIncrement<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TimePickerPresenter 
{
    control.MinuteIncrement = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MinuteIncrement<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty!, func);

/*SetterFromObservableGenerator*/
public static T MinuteIncrement<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MinuteIncrement<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T MinuteIncrement<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.TimePickerPresenter 
   => control._setEx(Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty!, obs, changed);


 // SecondIncrement

/*ValueSetterGenerator*/
public static T SecondIncrement<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TimePickerPresenter 
{
    control.SecondIncrement = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SecondIncrement<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.SecondIncrementProperty!, func);

/*SetterFromObservableGenerator*/
public static T SecondIncrement<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.SecondIncrementProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SecondIncrement<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.SecondIncrementProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SecondIncrement<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.TimePickerPresenter 
   => control._setEx(Avalonia.Controls.TimePickerPresenter.SecondIncrementProperty!, obs, changed);


 // ClockIdentifier

/*ValueSetterGenerator*/
public static T ClockIdentifier<T>(this T control, System.String value) where T : Avalonia.Controls.TimePickerPresenter 
{
    control.ClockIdentifier = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ClockIdentifier<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty!, func);

/*SetterFromObservableGenerator*/
public static T ClockIdentifier<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ClockIdentifier<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ClockIdentifier<T>(this T control, IObservable<System.String> obs, IObserver<System.String> changed) where T : Avalonia.Controls.TimePickerPresenter 
   => control._setEx(Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty!, obs, changed);


 // UseSeconds

/*ValueSetterGenerator*/
public static T UseSeconds<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TimePickerPresenter 
{
    control.UseSeconds = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T UseSeconds<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.UseSecondsProperty!, func);

/*SetterFromObservableGenerator*/
public static T UseSeconds<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.UseSecondsProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T UseSeconds<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.UseSecondsProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T UseSeconds<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.TimePickerPresenter 
   => control._setEx(Avalonia.Controls.TimePickerPresenter.UseSecondsProperty!, obs, changed);


 // Time

/*ValueSetterGenerator*/
public static T Time<T>(this T control, System.TimeSpan value) where T : Avalonia.Controls.TimePickerPresenter 
{
    control.Time = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Time<T>(this T control, Func<System.TimeSpan> func) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.TimeProperty!, func);

/*SetterFromObservableGenerator*/
public static T Time<T>(this T control, IObservable<System.TimeSpan> obs) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.TimeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Time<T>(this T control, ISubject<System.TimeSpan> subject) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.TimeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Time<T>(this T control, IObservable<System.TimeSpan> obs, IObserver<System.TimeSpan> changed) where T : Avalonia.Controls.TimePickerPresenter 
   => control._setEx(Avalonia.Controls.TimePickerPresenter.TimeProperty!, obs, changed);



//================= Styles ======================//
 // MinuteIncrement

/*ValueStyleSetterGenerator*/
public static Style<T> MinuteIncrement<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinuteIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty, binding);


 // SecondIncrement

/*ValueStyleSetterGenerator*/
public static Style<T> SecondIncrement<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.SecondIncrementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SecondIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.SecondIncrementProperty, binding);


 // ClockIdentifier

/*ValueStyleSetterGenerator*/
public static Style<T> ClockIdentifier<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ClockIdentifier<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty, binding);


 // UseSeconds

/*ValueStyleSetterGenerator*/
public static Style<T> UseSeconds<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.UseSecondsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UseSeconds<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.UseSecondsProperty, binding);


 // Time

/*ValueStyleSetterGenerator*/
public static Style<T> Time<T>(this Style<T> style, System.TimeSpan value) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.TimeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Time<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.TimeProperty, binding);



}

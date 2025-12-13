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
public static partial class DatePicker_MarkupExtensions
{
//================= Properties ======================//
 // DayFormat

/*ValueSetterGenerator*/
public static T DayFormat<T>(this T control, System.String value) where T : Avalonia.Controls.DatePicker 
{
    control.DayFormat = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DayFormat<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.DayFormatProperty!, func);

/*SetterFromObservableGenerator*/
public static T DayFormat<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.DayFormatProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DayFormat<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.DayFormatProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DayFormat<T>(this T control, IObservable<System.String> obs, IObserver<System.String> changed) where T : Avalonia.Controls.DatePicker 
   => control._setEx(Avalonia.Controls.DatePicker.DayFormatProperty!, obs, changed);


 // DayVisible

/*ValueSetterGenerator*/
public static T DayVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.DatePicker 
{
    control.DayVisible = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DayVisible<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.DayVisibleProperty!, func);

/*SetterFromObservableGenerator*/
public static T DayVisible<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.DayVisibleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DayVisible<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.DayVisibleProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DayVisible<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.DatePicker 
   => control._setEx(Avalonia.Controls.DatePicker.DayVisibleProperty!, obs, changed);


 // MaxYear

/*ValueSetterGenerator*/
public static T MaxYear<T>(this T control, System.DateTimeOffset value) where T : Avalonia.Controls.DatePicker 
{
    control.MaxYear = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MaxYear<T>(this T control, Func<System.DateTimeOffset> func) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MaxYearProperty!, func);

/*SetterFromObservableGenerator*/
public static T MaxYear<T>(this T control, IObservable<System.DateTimeOffset> obs) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MaxYearProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MaxYear<T>(this T control, ISubject<System.DateTimeOffset> subject) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MaxYearProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T MaxYear<T>(this T control, IObservable<System.DateTimeOffset> obs, IObserver<System.DateTimeOffset> changed) where T : Avalonia.Controls.DatePicker 
   => control._setEx(Avalonia.Controls.DatePicker.MaxYearProperty!, obs, changed);


 // MinYear

/*ValueSetterGenerator*/
public static T MinYear<T>(this T control, System.DateTimeOffset value) where T : Avalonia.Controls.DatePicker 
{
    control.MinYear = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MinYear<T>(this T control, Func<System.DateTimeOffset> func) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MinYearProperty!, func);

/*SetterFromObservableGenerator*/
public static T MinYear<T>(this T control, IObservable<System.DateTimeOffset> obs) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MinYearProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MinYear<T>(this T control, ISubject<System.DateTimeOffset> subject) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MinYearProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T MinYear<T>(this T control, IObservable<System.DateTimeOffset> obs, IObserver<System.DateTimeOffset> changed) where T : Avalonia.Controls.DatePicker 
   => control._setEx(Avalonia.Controls.DatePicker.MinYearProperty!, obs, changed);


 // MonthFormat

/*ValueSetterGenerator*/
public static T MonthFormat<T>(this T control, System.String value) where T : Avalonia.Controls.DatePicker 
{
    control.MonthFormat = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MonthFormat<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MonthFormatProperty!, func);

/*SetterFromObservableGenerator*/
public static T MonthFormat<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MonthFormatProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MonthFormat<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MonthFormatProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T MonthFormat<T>(this T control, IObservable<System.String> obs, IObserver<System.String> changed) where T : Avalonia.Controls.DatePicker 
   => control._setEx(Avalonia.Controls.DatePicker.MonthFormatProperty!, obs, changed);


 // MonthVisible

/*ValueSetterGenerator*/
public static T MonthVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.DatePicker 
{
    control.MonthVisible = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MonthVisible<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MonthVisibleProperty!, func);

/*SetterFromObservableGenerator*/
public static T MonthVisible<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MonthVisibleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MonthVisible<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MonthVisibleProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T MonthVisible<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.DatePicker 
   => control._setEx(Avalonia.Controls.DatePicker.MonthVisibleProperty!, obs, changed);


 // YearFormat

/*ValueSetterGenerator*/
public static T YearFormat<T>(this T control, System.String value) where T : Avalonia.Controls.DatePicker 
{
    control.YearFormat = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T YearFormat<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.YearFormatProperty!, func);

/*SetterFromObservableGenerator*/
public static T YearFormat<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.YearFormatProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T YearFormat<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.YearFormatProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T YearFormat<T>(this T control, IObservable<System.String> obs, IObserver<System.String> changed) where T : Avalonia.Controls.DatePicker 
   => control._setEx(Avalonia.Controls.DatePicker.YearFormatProperty!, obs, changed);


 // YearVisible

/*ValueSetterGenerator*/
public static T YearVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.DatePicker 
{
    control.YearVisible = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T YearVisible<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.YearVisibleProperty!, func);

/*SetterFromObservableGenerator*/
public static T YearVisible<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.YearVisibleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T YearVisible<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.YearVisibleProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T YearVisible<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.DatePicker 
   => control._setEx(Avalonia.Controls.DatePicker.YearVisibleProperty!, obs, changed);


 // SelectedDate

/*ValueSetterGenerator*/
public static T SelectedDate<T>(this T control, System.Nullable<System.DateTimeOffset> value) where T : Avalonia.Controls.DatePicker 
{
    control.SelectedDate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectedDate<T>(this T control, Func<System.Nullable<System.DateTimeOffset>> func) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.SelectedDateProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectedDate<T>(this T control, IObservable<System.Nullable<System.DateTimeOffset>> obs) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.SelectedDateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectedDate<T>(this T control, ISubject<System.Nullable<System.DateTimeOffset>> subject) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.SelectedDateProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SelectedDate<T>(this T control, IObservable<System.Nullable<System.DateTimeOffset>> obs, IObserver<System.Nullable<System.DateTimeOffset>> changed) where T : Avalonia.Controls.DatePicker 
   => control._setEx(Avalonia.Controls.DatePicker.SelectedDateProperty!, obs, changed);



//================= Events ======================//
 // SelectedDateChanged

/*ActionToEventGenerator*/
public static T OnSelectedDateChanged<T>(this T control, Action<Avalonia.Controls.DatePickerSelectedValueChangedEventArgs> action) where T : Avalonia.Controls.DatePicker  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.DatePickerSelectedValueChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.SelectedDateChanged += h);



//================= Styles ======================//
 // DayFormat

/*ValueStyleSetterGenerator*/
public static Style<T> DayFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.DayFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DayFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.DayFormatProperty, binding);


 // DayVisible

/*ValueStyleSetterGenerator*/
public static Style<T> DayVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.DayVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DayVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.DayVisibleProperty, binding);


 // MaxYear

/*ValueStyleSetterGenerator*/
public static Style<T> MaxYear<T>(this Style<T> style, System.DateTimeOffset value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MaxYearProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxYear<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MaxYearProperty, binding);


 // MinYear

/*ValueStyleSetterGenerator*/
public static Style<T> MinYear<T>(this Style<T> style, System.DateTimeOffset value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MinYearProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinYear<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MinYearProperty, binding);


 // MonthFormat

/*ValueStyleSetterGenerator*/
public static Style<T> MonthFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MonthFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MonthFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MonthFormatProperty, binding);


 // MonthVisible

/*ValueStyleSetterGenerator*/
public static Style<T> MonthVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MonthVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MonthVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MonthVisibleProperty, binding);


 // YearFormat

/*ValueStyleSetterGenerator*/
public static Style<T> YearFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.YearFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> YearFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.YearFormatProperty, binding);


 // YearVisible

/*ValueStyleSetterGenerator*/
public static Style<T> YearVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.YearVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> YearVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.YearVisibleProperty, binding);


 // SelectedDate

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedDate<T>(this Style<T> style, System.Nullable<System.DateTimeOffset> value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.SelectedDateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedDate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.SelectedDateProperty, binding);



}

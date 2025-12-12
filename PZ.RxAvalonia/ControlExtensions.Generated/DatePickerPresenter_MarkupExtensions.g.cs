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
public static partial class DatePickerPresenter_MarkupExtensions
{
//================= Properties ======================//
 // Date

/*ValueSetterGenerator*/
public static T Date<T>(this T control, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter 
{
    control.Date = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Date<T>(this T control, Func<System.DateTimeOffset> func) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DateProperty!, func);

/*SetterFromObservableGenerator*/
public static T Date<T>(this T control, IObservable<System.DateTimeOffset> obs) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Date<T>(this T control, ISubject<System.DateTimeOffset> subject) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DateProperty!, subject);


 // DayFormat

/*ValueSetterGenerator*/
public static T DayFormat<T>(this T control, System.String value) where T : Avalonia.Controls.DatePickerPresenter 
{
    control.DayFormat = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DayFormat<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DayFormatProperty!, func);

/*SetterFromObservableGenerator*/
public static T DayFormat<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DayFormatProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DayFormat<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DayFormatProperty!, subject);


 // DayVisible

/*ValueSetterGenerator*/
public static T DayVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter 
{
    control.DayVisible = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DayVisible<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty!, func);

/*SetterFromObservableGenerator*/
public static T DayVisible<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DayVisible<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty!, subject);


 // MaxYear

/*ValueSetterGenerator*/
public static T MaxYear<T>(this T control, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter 
{
    control.MaxYear = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MaxYear<T>(this T control, Func<System.DateTimeOffset> func) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MaxYearProperty!, func);

/*SetterFromObservableGenerator*/
public static T MaxYear<T>(this T control, IObservable<System.DateTimeOffset> obs) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MaxYearProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MaxYear<T>(this T control, ISubject<System.DateTimeOffset> subject) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MaxYearProperty!, subject);


 // MinYear

/*ValueSetterGenerator*/
public static T MinYear<T>(this T control, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter 
{
    control.MinYear = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MinYear<T>(this T control, Func<System.DateTimeOffset> func) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MinYearProperty!, func);

/*SetterFromObservableGenerator*/
public static T MinYear<T>(this T control, IObservable<System.DateTimeOffset> obs) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MinYearProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MinYear<T>(this T control, ISubject<System.DateTimeOffset> subject) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MinYearProperty!, subject);


 // MonthFormat

/*ValueSetterGenerator*/
public static T MonthFormat<T>(this T control, System.String value) where T : Avalonia.Controls.DatePickerPresenter 
{
    control.MonthFormat = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MonthFormat<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty!, func);

/*SetterFromObservableGenerator*/
public static T MonthFormat<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MonthFormat<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty!, subject);


 // MonthVisible

/*ValueSetterGenerator*/
public static T MonthVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter 
{
    control.MonthVisible = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MonthVisible<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty!, func);

/*SetterFromObservableGenerator*/
public static T MonthVisible<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MonthVisible<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty!, subject);


 // YearFormat

/*ValueSetterGenerator*/
public static T YearFormat<T>(this T control, System.String value) where T : Avalonia.Controls.DatePickerPresenter 
{
    control.YearFormat = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T YearFormat<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.YearFormatProperty!, func);

/*SetterFromObservableGenerator*/
public static T YearFormat<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.YearFormatProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T YearFormat<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.YearFormatProperty!, subject);


 // YearVisible

/*ValueSetterGenerator*/
public static T YearVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter 
{
    control.YearVisible = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T YearVisible<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty!, func);

/*SetterFromObservableGenerator*/
public static T YearVisible<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T YearVisible<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty!, subject);



//================= Styles ======================//
 // Date

/*ValueStyleSetterGenerator*/
public static Style<T> Date<T>(this Style<T> style, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Date<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DateProperty, binding);


 // DayFormat

/*ValueStyleSetterGenerator*/
public static Style<T> DayFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DayFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DayFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DayFormatProperty, binding);


 // DayVisible

/*ValueStyleSetterGenerator*/
public static Style<T> DayVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DayVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty, binding);


 // MaxYear

/*ValueStyleSetterGenerator*/
public static Style<T> MaxYear<T>(this Style<T> style, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MaxYearProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxYear<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MaxYearProperty, binding);


 // MinYear

/*ValueStyleSetterGenerator*/
public static Style<T> MinYear<T>(this Style<T> style, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MinYearProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinYear<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MinYearProperty, binding);


 // MonthFormat

/*ValueStyleSetterGenerator*/
public static Style<T> MonthFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MonthFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty, binding);


 // MonthVisible

/*ValueStyleSetterGenerator*/
public static Style<T> MonthVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MonthVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty, binding);


 // YearFormat

/*ValueStyleSetterGenerator*/
public static Style<T> YearFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.YearFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> YearFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.YearFormatProperty, binding);


 // YearVisible

/*ValueStyleSetterGenerator*/
public static Style<T> YearVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> YearVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty, binding);



}

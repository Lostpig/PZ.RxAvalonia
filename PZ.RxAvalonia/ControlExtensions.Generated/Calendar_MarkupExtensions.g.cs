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
public static partial class Calendar_MarkupExtensions
{
//================= Properties ======================//
 // FirstDayOfWeek

/*ValueSetterGenerator*/
public static T FirstDayOfWeek<T>(this T control, System.DayOfWeek value) where T : Avalonia.Controls.Calendar 
{
    control.FirstDayOfWeek = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FirstDayOfWeek<T>(this T control, Func<System.DayOfWeek> func) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.FirstDayOfWeekProperty!, func);

/*SetterFromObservableGenerator*/
public static T FirstDayOfWeek<T>(this T control, IObservable<System.DayOfWeek> obs) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.FirstDayOfWeekProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FirstDayOfWeek<T>(this T control, ISubject<System.DayOfWeek> subject) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.FirstDayOfWeekProperty!, subject);


 // IsTodayHighlighted

/*ValueSetterGenerator*/
public static T IsTodayHighlighted<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Calendar 
{
    control.IsTodayHighlighted = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsTodayHighlighted<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.IsTodayHighlightedProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsTodayHighlighted<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.IsTodayHighlightedProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsTodayHighlighted<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.IsTodayHighlightedProperty!, subject);


 // HeaderBackground

/*ValueSetterGenerator*/
public static T HeaderBackground<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Calendar 
{
    control.HeaderBackground = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T HeaderBackground<T>(this T control, Func<Avalonia.Media.IBrush> func) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.HeaderBackgroundProperty!, func);

/*SetterFromObservableGenerator*/
public static T HeaderBackground<T>(this T control, IObservable<Avalonia.Media.IBrush> obs) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.HeaderBackgroundProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T HeaderBackground<T>(this T control, ISubject<Avalonia.Media.IBrush> subject) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.HeaderBackgroundProperty!, subject);


 // DisplayMode

/*ValueSetterGenerator*/
public static T DisplayMode<T>(this T control, Avalonia.Controls.CalendarMode value) where T : Avalonia.Controls.Calendar 
{
    control.DisplayMode = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DisplayMode<T>(this T control, Func<Avalonia.Controls.CalendarMode> func) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.DisplayModeProperty!, func);

/*SetterFromObservableGenerator*/
public static T DisplayMode<T>(this T control, IObservable<Avalonia.Controls.CalendarMode> obs) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.DisplayModeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DisplayMode<T>(this T control, ISubject<Avalonia.Controls.CalendarMode> subject) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.DisplayModeProperty!, subject);


 // SelectionMode

/*ValueSetterGenerator*/
public static T SelectionMode<T>(this T control, Avalonia.Controls.CalendarSelectionMode value) where T : Avalonia.Controls.Calendar 
{
    control.SelectionMode = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectionMode<T>(this T control, Func<Avalonia.Controls.CalendarSelectionMode> func) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.SelectionModeProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectionMode<T>(this T control, IObservable<Avalonia.Controls.CalendarSelectionMode> obs) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.SelectionModeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectionMode<T>(this T control, ISubject<Avalonia.Controls.CalendarSelectionMode> subject) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.SelectionModeProperty!, subject);


 // AllowTapRangeSelection

/*ValueSetterGenerator*/
public static T AllowTapRangeSelection<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Calendar 
{
    control.AllowTapRangeSelection = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T AllowTapRangeSelection<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.AllowTapRangeSelectionProperty!, func);

/*SetterFromObservableGenerator*/
public static T AllowTapRangeSelection<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.AllowTapRangeSelectionProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T AllowTapRangeSelection<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.AllowTapRangeSelectionProperty!, subject);


 // SelectedDate

/*ValueSetterGenerator*/
public static T SelectedDate<T>(this T control, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.Calendar 
{
    control.SelectedDate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectedDate<T>(this T control, Func<System.Nullable<System.DateTime>> func) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.SelectedDateProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectedDate<T>(this T control, IObservable<System.Nullable<System.DateTime>> obs) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.SelectedDateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectedDate<T>(this T control, ISubject<System.Nullable<System.DateTime>> subject) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.SelectedDateProperty!, subject);


 // DisplayDate

/*ValueSetterGenerator*/
public static T DisplayDate<T>(this T control, System.DateTime value) where T : Avalonia.Controls.Calendar 
{
    control.DisplayDate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DisplayDate<T>(this T control, Func<System.DateTime> func) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.DisplayDateProperty!, func);

/*SetterFromObservableGenerator*/
public static T DisplayDate<T>(this T control, IObservable<System.DateTime> obs) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.DisplayDateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DisplayDate<T>(this T control, ISubject<System.DateTime> subject) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.DisplayDateProperty!, subject);


 // DisplayDateStart

/*ValueSetterGenerator*/
public static T DisplayDateStart<T>(this T control, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.Calendar 
{
    control.DisplayDateStart = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DisplayDateStart<T>(this T control, Func<System.Nullable<System.DateTime>> func) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.DisplayDateStartProperty!, func);

/*SetterFromObservableGenerator*/
public static T DisplayDateStart<T>(this T control, IObservable<System.Nullable<System.DateTime>> obs) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.DisplayDateStartProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DisplayDateStart<T>(this T control, ISubject<System.Nullable<System.DateTime>> subject) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.DisplayDateStartProperty!, subject);


 // DisplayDateEnd

/*ValueSetterGenerator*/
public static T DisplayDateEnd<T>(this T control, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.Calendar 
{
    control.DisplayDateEnd = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DisplayDateEnd<T>(this T control, Func<System.Nullable<System.DateTime>> func) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.DisplayDateEndProperty!, func);

/*SetterFromObservableGenerator*/
public static T DisplayDateEnd<T>(this T control, IObservable<System.Nullable<System.DateTime>> obs) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.DisplayDateEndProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DisplayDateEnd<T>(this T control, ISubject<System.Nullable<System.DateTime>> subject) where T : Avalonia.Controls.Calendar 
   => control._set(Avalonia.Controls.Calendar.DisplayDateEndProperty!, subject);



//================= Events ======================//
 // SelectedDatesChanged

/*ActionToEventGenerator*/
public static T OnSelectedDatesChanged<T>(this T control, Action<Avalonia.Controls.SelectionChangedEventArgs> action) where T : Avalonia.Controls.Calendar  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.SelectionChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.SelectedDatesChanged += h);


 // DisplayDateChanged

/*ActionToEventGenerator*/
public static T OnDisplayDateChanged<T>(this T control, Action<Avalonia.Controls.CalendarDateChangedEventArgs> action) where T : Avalonia.Controls.Calendar  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.CalendarDateChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DisplayDateChanged += h);


 // DisplayModeChanged

/*ActionToEventGenerator*/
public static T OnDisplayModeChanged<T>(this T control, Action<Avalonia.Controls.CalendarModeChangedEventArgs> action) where T : Avalonia.Controls.Calendar  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.CalendarModeChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DisplayModeChanged += h);



//================= Styles ======================//
 // FirstDayOfWeek

/*ValueStyleSetterGenerator*/
public static Style<T> FirstDayOfWeek<T>(this Style<T> style, System.DayOfWeek value) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.FirstDayOfWeekProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FirstDayOfWeek<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, binding);


 // IsTodayHighlighted

/*ValueStyleSetterGenerator*/
public static Style<T> IsTodayHighlighted<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.IsTodayHighlightedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTodayHighlighted<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, binding);


 // HeaderBackground

/*ValueStyleSetterGenerator*/
public static Style<T> HeaderBackground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.HeaderBackgroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HeaderBackground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.HeaderBackgroundProperty, binding);


 // DisplayMode

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayMode<T>(this Style<T> style, Avalonia.Controls.CalendarMode value) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.DisplayModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.DisplayModeProperty, binding);


 // SelectionMode

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionMode<T>(this Style<T> style, Avalonia.Controls.CalendarSelectionMode value) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.SelectionModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.SelectionModeProperty, binding);


 // AllowTapRangeSelection

/*ValueStyleSetterGenerator*/
public static Style<T> AllowTapRangeSelection<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.AllowTapRangeSelectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AllowTapRangeSelection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.AllowTapRangeSelectionProperty, binding);


 // SelectedDate

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedDate<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.SelectedDateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedDate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.SelectedDateProperty, binding);


 // DisplayDate

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayDate<T>(this Style<T> style, System.DateTime value) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayDate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateProperty, binding);


 // DisplayDateStart

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayDateStart<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateStartProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayDateStart<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateStartProperty, binding);


 // DisplayDateEnd

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayDateEnd<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateEndProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayDateEnd<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateEndProperty, binding);



}

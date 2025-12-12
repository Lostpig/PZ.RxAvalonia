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
public static partial class CalendarDatePicker_MarkupExtensions
{
//================= Properties ======================//
 // DisplayDate

/*ValueSetterGenerator*/
public static T DisplayDate<T>(this T control, System.DateTime value) where T : Avalonia.Controls.CalendarDatePicker 
{
    control.DisplayDate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DisplayDate<T>(this T control, Func<System.DateTime> func) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty!, func);

/*SetterFromObservableGenerator*/
public static T DisplayDate<T>(this T control, IObservable<System.DateTime> obs) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DisplayDate<T>(this T control, ISubject<System.DateTime> subject) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty!, subject);


 // DisplayDateStart

/*ValueSetterGenerator*/
public static T DisplayDateStart<T>(this T control, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.CalendarDatePicker 
{
    control.DisplayDateStart = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DisplayDateStart<T>(this T control, Func<System.Nullable<System.DateTime>> func) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty!, func);

/*SetterFromObservableGenerator*/
public static T DisplayDateStart<T>(this T control, IObservable<System.Nullable<System.DateTime>> obs) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DisplayDateStart<T>(this T control, ISubject<System.Nullable<System.DateTime>> subject) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty!, subject);


 // DisplayDateEnd

/*ValueSetterGenerator*/
public static T DisplayDateEnd<T>(this T control, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.CalendarDatePicker 
{
    control.DisplayDateEnd = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DisplayDateEnd<T>(this T control, Func<System.Nullable<System.DateTime>> func) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty!, func);

/*SetterFromObservableGenerator*/
public static T DisplayDateEnd<T>(this T control, IObservable<System.Nullable<System.DateTime>> obs) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DisplayDateEnd<T>(this T control, ISubject<System.Nullable<System.DateTime>> subject) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty!, subject);


 // FirstDayOfWeek

/*ValueSetterGenerator*/
public static T FirstDayOfWeek<T>(this T control, System.DayOfWeek value) where T : Avalonia.Controls.CalendarDatePicker 
{
    control.FirstDayOfWeek = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FirstDayOfWeek<T>(this T control, Func<System.DayOfWeek> func) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty!, func);

/*SetterFromObservableGenerator*/
public static T FirstDayOfWeek<T>(this T control, IObservable<System.DayOfWeek> obs) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FirstDayOfWeek<T>(this T control, ISubject<System.DayOfWeek> subject) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty!, subject);


 // IsDropDownOpen

/*ValueSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, System.Boolean value) where T : Avalonia.Controls.CalendarDatePicker 
{
    control.IsDropDownOpen = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsDropDownOpen<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsDropDownOpen<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsDropDownOpen<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty!, subject);


 // IsTodayHighlighted

/*ValueSetterGenerator*/
public static T IsTodayHighlighted<T>(this T control, System.Boolean value) where T : Avalonia.Controls.CalendarDatePicker 
{
    control.IsTodayHighlighted = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsTodayHighlighted<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsTodayHighlighted<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsTodayHighlighted<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty!, subject);


 // SelectedDate

/*ValueSetterGenerator*/
public static T SelectedDate<T>(this T control, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.CalendarDatePicker 
{
    control.SelectedDate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectedDate<T>(this T control, Func<System.Nullable<System.DateTime>> func) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectedDate<T>(this T control, IObservable<System.Nullable<System.DateTime>> obs) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectedDate<T>(this T control, ISubject<System.Nullable<System.DateTime>> subject) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty!, subject);


 // SelectedDateFormat

/*ValueSetterGenerator*/
public static T SelectedDateFormat<T>(this T control, Avalonia.Controls.CalendarDatePickerFormat value) where T : Avalonia.Controls.CalendarDatePicker 
{
    control.SelectedDateFormat = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectedDateFormat<T>(this T control, Func<Avalonia.Controls.CalendarDatePickerFormat> func) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectedDateFormat<T>(this T control, IObservable<Avalonia.Controls.CalendarDatePickerFormat> obs) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectedDateFormat<T>(this T control, ISubject<Avalonia.Controls.CalendarDatePickerFormat> subject) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty!, subject);


 // CustomDateFormatString

/*ValueSetterGenerator*/
public static T CustomDateFormatString<T>(this T control, System.String value) where T : Avalonia.Controls.CalendarDatePicker 
{
    control.CustomDateFormatString = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CustomDateFormatString<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty!, func);

/*SetterFromObservableGenerator*/
public static T CustomDateFormatString<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CustomDateFormatString<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty!, subject);


 // Text

/*ValueSetterGenerator*/
public static T Text<T>(this T control, System.String value) where T : Avalonia.Controls.CalendarDatePicker 
{
    control.Text = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Text<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.TextProperty!, func);

/*SetterFromObservableGenerator*/
public static T Text<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.TextProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Text<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.TextProperty!, subject);


 // Watermark

/*ValueSetterGenerator*/
public static T Watermark<T>(this T control, System.String value) where T : Avalonia.Controls.CalendarDatePicker 
{
    control.Watermark = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Watermark<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.WatermarkProperty!, func);

/*SetterFromObservableGenerator*/
public static T Watermark<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.WatermarkProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Watermark<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.WatermarkProperty!, subject);


 // UseFloatingWatermark

/*ValueSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control, System.Boolean value) where T : Avalonia.Controls.CalendarDatePicker 
{
    control.UseFloatingWatermark = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T UseFloatingWatermark<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty!, func);

/*SetterFromObservableGenerator*/
public static T UseFloatingWatermark<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T UseFloatingWatermark<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty!, subject);


 // HorizontalContentAlignment

/*ValueSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.CalendarDatePicker 
{
    control.HorizontalContentAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T HorizontalContentAlignment<T>(this T control, IObservable<Avalonia.Layout.HorizontalAlignment> obs) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T HorizontalContentAlignment<T>(this T control, ISubject<Avalonia.Layout.HorizontalAlignment> subject) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty!, subject);


 // VerticalContentAlignment

/*ValueSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.CalendarDatePicker 
{
    control.VerticalContentAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T VerticalContentAlignment<T>(this T control, IObservable<Avalonia.Layout.VerticalAlignment> obs) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T VerticalContentAlignment<T>(this T control, ISubject<Avalonia.Layout.VerticalAlignment> subject) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty!, subject);



//================= Events ======================//
 // CalendarClosed

/*ActionToEventGenerator*/
public static T OnCalendarClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.CalendarDatePicker  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.CalendarClosed += h);


 // CalendarOpened

/*ActionToEventGenerator*/
public static T OnCalendarOpened<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.CalendarDatePicker  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.CalendarOpened += h);


 // DateValidationError

/*ActionToEventGenerator*/
public static T OnDateValidationError<T>(this T control, Action<Avalonia.Controls.CalendarDatePickerDateValidationErrorEventArgs> action) where T : Avalonia.Controls.CalendarDatePicker  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.CalendarDatePickerDateValidationErrorEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DateValidationError += h);


 // SelectedDateChanged

/*ActionToEventGenerator*/
public static T OnSelectedDateChanged<T>(this T control, Action<Avalonia.Controls.SelectionChangedEventArgs> action) where T : Avalonia.Controls.CalendarDatePicker  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.SelectionChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.SelectedDateChanged += h);



//================= Styles ======================//
 // DisplayDate

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayDate<T>(this Style<T> style, System.DateTime value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayDate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty, binding);


 // DisplayDateStart

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayDateStart<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayDateStart<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty, binding);


 // DisplayDateEnd

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayDateEnd<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayDateEnd<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty, binding);


 // FirstDayOfWeek

/*ValueStyleSetterGenerator*/
public static Style<T> FirstDayOfWeek<T>(this Style<T> style, System.DayOfWeek value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FirstDayOfWeek<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty, binding);


 // IsDropDownOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsDropDownOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDropDownOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty, binding);


 // IsTodayHighlighted

/*ValueStyleSetterGenerator*/
public static Style<T> IsTodayHighlighted<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTodayHighlighted<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty, binding);


 // SelectedDate

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedDate<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedDate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty, binding);


 // SelectedDateFormat

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedDateFormat<T>(this Style<T> style, Avalonia.Controls.CalendarDatePickerFormat value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedDateFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty, binding);


 // CustomDateFormatString

/*ValueStyleSetterGenerator*/
public static Style<T> CustomDateFormatString<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CustomDateFormatString<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty, binding);


 // Text

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.TextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.TextProperty, binding);


 // Watermark

/*ValueStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.WatermarkProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.WatermarkProperty, binding);


 // UseFloatingWatermark

/*ValueStyleSetterGenerator*/
public static Style<T> UseFloatingWatermark<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UseFloatingWatermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty, binding);



}

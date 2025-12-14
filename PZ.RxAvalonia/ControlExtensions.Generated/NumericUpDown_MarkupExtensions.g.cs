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
public static partial class NumericUpDown_MarkupExtensions
{
//================= Properties ======================//
 // AllowSpin

/*ValueSetterGenerator*/
public static T AllowSpin<T>(this T control, System.Boolean value) where T : Avalonia.Controls.NumericUpDown 
{
    control.AllowSpin = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T AllowSpin<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.AllowSpinProperty!, func);

/*SetterFromObservableGenerator*/
public static T AllowSpin<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.AllowSpinProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T AllowSpin<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.AllowSpinProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T AllowSpin<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.NumericUpDown 
   => control._setEx(Avalonia.Controls.NumericUpDown.AllowSpinProperty!, obs, changed);


 // ButtonSpinnerLocation

/*ValueSetterGenerator*/
public static T ButtonSpinnerLocation<T>(this T control, Avalonia.Controls.Location value) where T : Avalonia.Controls.NumericUpDown 
{
    control.ButtonSpinnerLocation = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ButtonSpinnerLocation<T>(this T control, Func<Avalonia.Controls.Location> func) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty!, func);

/*SetterFromObservableGenerator*/
public static T ButtonSpinnerLocation<T>(this T control, IObservable<Avalonia.Controls.Location> obs) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ButtonSpinnerLocation<T>(this T control, ISubject<Avalonia.Controls.Location> subject) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ButtonSpinnerLocation<T>(this T control, IObservable<Avalonia.Controls.Location> obs, IObserver<Avalonia.Controls.Location> changed) where T : Avalonia.Controls.NumericUpDown 
   => control._setEx(Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty!, obs, changed);


 // ShowButtonSpinner

/*ValueSetterGenerator*/
public static T ShowButtonSpinner<T>(this T control, System.Boolean value) where T : Avalonia.Controls.NumericUpDown 
{
    control.ShowButtonSpinner = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ShowButtonSpinner<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty!, func);

/*SetterFromObservableGenerator*/
public static T ShowButtonSpinner<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ShowButtonSpinner<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ShowButtonSpinner<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.NumericUpDown 
   => control._setEx(Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty!, obs, changed);


 // ClipValueToMinMax

/*ValueSetterGenerator*/
public static T ClipValueToMinMax<T>(this T control, System.Boolean value) where T : Avalonia.Controls.NumericUpDown 
{
    control.ClipValueToMinMax = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ClipValueToMinMax<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty!, func);

/*SetterFromObservableGenerator*/
public static T ClipValueToMinMax<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ClipValueToMinMax<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ClipValueToMinMax<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.NumericUpDown 
   => control._setEx(Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty!, obs, changed);


 // NumberFormat

/*ValueSetterGenerator*/
public static T NumberFormat<T>(this T control, System.Globalization.NumberFormatInfo value) where T : Avalonia.Controls.NumericUpDown 
{
    control.NumberFormat = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T NumberFormat<T>(this T control, Func<System.Globalization.NumberFormatInfo> func) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.NumberFormatProperty!, func);

/*SetterFromObservableGenerator*/
public static T NumberFormat<T>(this T control, IObservable<System.Globalization.NumberFormatInfo> obs) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.NumberFormatProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T NumberFormat<T>(this T control, ISubject<System.Globalization.NumberFormatInfo> subject) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.NumberFormatProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T NumberFormat<T>(this T control, IObservable<System.Globalization.NumberFormatInfo> obs, IObserver<System.Globalization.NumberFormatInfo> changed) where T : Avalonia.Controls.NumericUpDown 
   => control._setEx(Avalonia.Controls.NumericUpDown.NumberFormatProperty!, obs, changed);


 // FormatString

/*ValueSetterGenerator*/
public static T FormatString<T>(this T control, System.String value) where T : Avalonia.Controls.NumericUpDown 
{
    control.FormatString = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FormatString<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.FormatStringProperty!, func);

/*SetterFromObservableGenerator*/
public static T FormatString<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.FormatStringProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FormatString<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.FormatStringProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T FormatString<T>(this T control, IObservable<System.String> obs, IObserver<System.String> changed) where T : Avalonia.Controls.NumericUpDown 
   => control._setEx(Avalonia.Controls.NumericUpDown.FormatStringProperty!, obs, changed);


 // Increment

/*ValueSetterGenerator*/
public static T Increment<T>(this T control, System.Decimal value) where T : Avalonia.Controls.NumericUpDown 
{
    control.Increment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Increment<T>(this T control, Func<System.Decimal> func) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.IncrementProperty!, func);

/*SetterFromObservableGenerator*/
public static T Increment<T>(this T control, IObservable<System.Decimal> obs) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.IncrementProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Increment<T>(this T control, ISubject<System.Decimal> subject) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.IncrementProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Increment<T>(this T control, IObservable<System.Decimal> obs, IObserver<System.Decimal> changed) where T : Avalonia.Controls.NumericUpDown 
   => control._setEx(Avalonia.Controls.NumericUpDown.IncrementProperty!, obs, changed);


 // IsReadOnly

/*ValueSetterGenerator*/
public static T IsReadOnly<T>(this T control, System.Boolean value) where T : Avalonia.Controls.NumericUpDown 
{
    control.IsReadOnly = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsReadOnly<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.IsReadOnlyProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsReadOnly<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.IsReadOnlyProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsReadOnly<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.IsReadOnlyProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsReadOnly<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.NumericUpDown 
   => control._setEx(Avalonia.Controls.NumericUpDown.IsReadOnlyProperty!, obs, changed);


 // Maximum

/*ValueSetterGenerator*/
public static T Maximum<T>(this T control, System.Decimal value) where T : Avalonia.Controls.NumericUpDown 
{
    control.Maximum = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Maximum<T>(this T control, Func<System.Decimal> func) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.MaximumProperty!, func);

/*SetterFromObservableGenerator*/
public static T Maximum<T>(this T control, IObservable<System.Decimal> obs) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.MaximumProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Maximum<T>(this T control, ISubject<System.Decimal> subject) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.MaximumProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Maximum<T>(this T control, IObservable<System.Decimal> obs, IObserver<System.Decimal> changed) where T : Avalonia.Controls.NumericUpDown 
   => control._setEx(Avalonia.Controls.NumericUpDown.MaximumProperty!, obs, changed);


 // Minimum

/*ValueSetterGenerator*/
public static T Minimum<T>(this T control, System.Decimal value) where T : Avalonia.Controls.NumericUpDown 
{
    control.Minimum = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Minimum<T>(this T control, Func<System.Decimal> func) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.MinimumProperty!, func);

/*SetterFromObservableGenerator*/
public static T Minimum<T>(this T control, IObservable<System.Decimal> obs) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.MinimumProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Minimum<T>(this T control, ISubject<System.Decimal> subject) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.MinimumProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Minimum<T>(this T control, IObservable<System.Decimal> obs, IObserver<System.Decimal> changed) where T : Avalonia.Controls.NumericUpDown 
   => control._setEx(Avalonia.Controls.NumericUpDown.MinimumProperty!, obs, changed);


 // ParsingNumberStyle

/*ValueSetterGenerator*/
public static T ParsingNumberStyle<T>(this T control, System.Globalization.NumberStyles value) where T : Avalonia.Controls.NumericUpDown 
{
    control.ParsingNumberStyle = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ParsingNumberStyle<T>(this T control, Func<System.Globalization.NumberStyles> func) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty!, func);

/*SetterFromObservableGenerator*/
public static T ParsingNumberStyle<T>(this T control, IObservable<System.Globalization.NumberStyles> obs) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ParsingNumberStyle<T>(this T control, ISubject<System.Globalization.NumberStyles> subject) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ParsingNumberStyle<T>(this T control, IObservable<System.Globalization.NumberStyles> obs, IObserver<System.Globalization.NumberStyles> changed) where T : Avalonia.Controls.NumericUpDown 
   => control._setEx(Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty!, obs, changed);


 // Text

/*ValueSetterGenerator*/
public static T Text<T>(this T control, System.String value) where T : Avalonia.Controls.NumericUpDown 
{
    control.Text = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Text<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.TextProperty!, func);

/*SetterFromObservableGenerator*/
public static T Text<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.TextProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Text<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.TextProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Text<T>(this T control, IObservable<System.String> obs, IObserver<System.String> changed) where T : Avalonia.Controls.NumericUpDown 
   => control._setEx(Avalonia.Controls.NumericUpDown.TextProperty!, obs, changed);


 // TextConverter

/*ValueSetterGenerator*/
public static T TextConverter<T>(this T control, Avalonia.Data.Converters.IValueConverter value) where T : Avalonia.Controls.NumericUpDown 
{
    control.TextConverter = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TextConverter<T>(this T control, Func<Avalonia.Data.Converters.IValueConverter> func) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.TextConverterProperty!, func);

/*SetterFromObservableGenerator*/
public static T TextConverter<T>(this T control, IObservable<Avalonia.Data.Converters.IValueConverter> obs) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.TextConverterProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TextConverter<T>(this T control, ISubject<Avalonia.Data.Converters.IValueConverter> subject) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.TextConverterProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T TextConverter<T>(this T control, IObservable<Avalonia.Data.Converters.IValueConverter> obs, IObserver<Avalonia.Data.Converters.IValueConverter> changed) where T : Avalonia.Controls.NumericUpDown 
   => control._setEx(Avalonia.Controls.NumericUpDown.TextConverterProperty!, obs, changed);


 // Value

/*ValueSetterGenerator*/
public static T Value<T>(this T control, System.Nullable<System.Decimal> value) where T : Avalonia.Controls.NumericUpDown 
{
    control.Value = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Value<T>(this T control, Func<System.Nullable<System.Decimal>> func) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ValueProperty!, func);

/*SetterFromObservableGenerator*/
public static T Value<T>(this T control, IObservable<System.Nullable<System.Decimal>> obs) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ValueProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Value<T>(this T control, ISubject<System.Nullable<System.Decimal>> subject) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ValueProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Value<T>(this T control, IObservable<System.Nullable<System.Decimal>> obs, IObserver<System.Nullable<System.Decimal>> changed) where T : Avalonia.Controls.NumericUpDown 
   => control._setEx(Avalonia.Controls.NumericUpDown.ValueProperty!, obs, changed);


 // Watermark

/*ValueSetterGenerator*/
public static T Watermark<T>(this T control, System.String value) where T : Avalonia.Controls.NumericUpDown 
{
    control.Watermark = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Watermark<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.WatermarkProperty!, func);

/*SetterFromObservableGenerator*/
public static T Watermark<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.WatermarkProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Watermark<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.WatermarkProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Watermark<T>(this T control, IObservable<System.String> obs, IObserver<System.String> changed) where T : Avalonia.Controls.NumericUpDown 
   => control._setEx(Avalonia.Controls.NumericUpDown.WatermarkProperty!, obs, changed);


 // HorizontalContentAlignment

/*ValueSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.NumericUpDown 
{
    control.HorizontalContentAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T HorizontalContentAlignment<T>(this T control, IObservable<Avalonia.Layout.HorizontalAlignment> obs) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T HorizontalContentAlignment<T>(this T control, ISubject<Avalonia.Layout.HorizontalAlignment> subject) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T HorizontalContentAlignment<T>(this T control, IObservable<Avalonia.Layout.HorizontalAlignment> obs, IObserver<Avalonia.Layout.HorizontalAlignment> changed) where T : Avalonia.Controls.NumericUpDown 
   => control._setEx(Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty!, obs, changed);


 // VerticalContentAlignment

/*ValueSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.NumericUpDown 
{
    control.VerticalContentAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T VerticalContentAlignment<T>(this T control, IObservable<Avalonia.Layout.VerticalAlignment> obs) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T VerticalContentAlignment<T>(this T control, ISubject<Avalonia.Layout.VerticalAlignment> subject) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T VerticalContentAlignment<T>(this T control, IObservable<Avalonia.Layout.VerticalAlignment> obs, IObserver<Avalonia.Layout.VerticalAlignment> changed) where T : Avalonia.Controls.NumericUpDown 
   => control._setEx(Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty!, obs, changed);


 // TextAlignment

/*ValueSetterGenerator*/
public static T TextAlignment<T>(this T control, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.NumericUpDown 
{
    control.TextAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TextAlignment<T>(this T control, Func<Avalonia.Media.TextAlignment> func) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.TextAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T TextAlignment<T>(this T control, IObservable<Avalonia.Media.TextAlignment> obs) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.TextAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TextAlignment<T>(this T control, ISubject<Avalonia.Media.TextAlignment> subject) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.TextAlignmentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T TextAlignment<T>(this T control, IObservable<Avalonia.Media.TextAlignment> obs, IObserver<Avalonia.Media.TextAlignment> changed) where T : Avalonia.Controls.NumericUpDown 
   => control._setEx(Avalonia.Controls.NumericUpDown.TextAlignmentProperty!, obs, changed);


 // InnerLeftContent

/*ValueSetterGenerator*/
public static T InnerLeftContent<T>(this T control, System.Object value) where T : Avalonia.Controls.NumericUpDown 
{
    control.InnerLeftContent = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T InnerLeftContent<T>(this T control, Func<System.Object> func) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.InnerLeftContentProperty!, func);

/*SetterFromObservableGenerator*/
public static T InnerLeftContent<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.InnerLeftContentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T InnerLeftContent<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.InnerLeftContentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T InnerLeftContent<T>(this T control, IObservable<System.Object> obs, IObserver<System.Object> changed) where T : Avalonia.Controls.NumericUpDown 
   => control._setEx(Avalonia.Controls.NumericUpDown.InnerLeftContentProperty!, obs, changed);


 // InnerRightContent

/*ValueSetterGenerator*/
public static T InnerRightContent<T>(this T control, System.Object value) where T : Avalonia.Controls.NumericUpDown 
{
    control.InnerRightContent = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T InnerRightContent<T>(this T control, Func<System.Object> func) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.InnerRightContentProperty!, func);

/*SetterFromObservableGenerator*/
public static T InnerRightContent<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.InnerRightContentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T InnerRightContent<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.InnerRightContentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T InnerRightContent<T>(this T control, IObservable<System.Object> obs, IObserver<System.Object> changed) where T : Avalonia.Controls.NumericUpDown 
   => control._setEx(Avalonia.Controls.NumericUpDown.InnerRightContentProperty!, obs, changed);



//================= Events ======================//
 // Spinned

/*ActionToEventGenerator*/
public static T OnSpinned<T>(this T control, Action<Avalonia.Controls.SpinEventArgs> action) where T : Avalonia.Controls.NumericUpDown  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.SpinEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Spinned += h);

/*ReactiveEventGenerator*/
public static T RxSpinned<T>(this T control, IObserver<Avalonia.Controls.SpinEventArgs> observer) where T : Avalonia.Controls.NumericUpDown  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.SpinEventArgs>) ((arg0, arg1) => observer.OnNext((arg1))), h => control.Spinned += h);


 // ValueChanged

/*ActionToEventGenerator*/
public static T OnValueChanged<T>(this T control, Action<Avalonia.Controls.NumericUpDownValueChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.NumericUpDown 
{
  control.AddHandler(Avalonia.Controls.NumericUpDown.ValueChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.NumericUpDown.ValueChangedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxValueChanged<T>(this T control, IObserver<Avalonia.Controls.NumericUpDownValueChangedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.NumericUpDown 
{
  control.AddHandler(Avalonia.Controls.NumericUpDown.ValueChangedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.NumericUpDown.ValueChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // AllowSpin

/*ValueStyleSetterGenerator*/
public static Style<T> AllowSpin<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.AllowSpinProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AllowSpin<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.AllowSpinProperty, binding);


 // ButtonSpinnerLocation

/*ValueStyleSetterGenerator*/
public static Style<T> ButtonSpinnerLocation<T>(this Style<T> style, Avalonia.Controls.Location value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ButtonSpinnerLocation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty, binding);


 // ShowButtonSpinner

/*ValueStyleSetterGenerator*/
public static Style<T> ShowButtonSpinner<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowButtonSpinner<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty, binding);


 // ClipValueToMinMax

/*ValueStyleSetterGenerator*/
public static Style<T> ClipValueToMinMax<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ClipValueToMinMax<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty, binding);


 // NumberFormat

/*ValueStyleSetterGenerator*/
public static Style<T> NumberFormat<T>(this Style<T> style, System.Globalization.NumberFormatInfo value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.NumberFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> NumberFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.NumberFormatProperty, binding);


 // FormatString

/*ValueStyleSetterGenerator*/
public static Style<T> FormatString<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.FormatStringProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FormatString<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.FormatStringProperty, binding);


 // Increment

/*ValueStyleSetterGenerator*/
public static Style<T> Increment<T>(this Style<T> style, System.Decimal value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.IncrementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Increment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.IncrementProperty, binding);


 // IsReadOnly

/*ValueStyleSetterGenerator*/
public static Style<T> IsReadOnly<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.IsReadOnlyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsReadOnly<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.IsReadOnlyProperty, binding);


 // Maximum

/*ValueStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, System.Decimal value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.MaximumProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.MaximumProperty, binding);


 // Minimum

/*ValueStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, System.Decimal value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.MinimumProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.MinimumProperty, binding);


 // ParsingNumberStyle

/*ValueStyleSetterGenerator*/
public static Style<T> ParsingNumberStyle<T>(this Style<T> style, System.Globalization.NumberStyles value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ParsingNumberStyle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty, binding);


 // Text

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.TextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.TextProperty, binding);


 // TextConverter

/*ValueStyleSetterGenerator*/
public static Style<T> TextConverter<T>(this Style<T> style, Avalonia.Data.Converters.IValueConverter value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.TextConverterProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextConverter<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.TextConverterProperty, binding);


 // Value

/*ValueStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, System.Nullable<System.Decimal> value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ValueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ValueProperty, binding);


 // Watermark

/*ValueStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.WatermarkProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.WatermarkProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty, binding);


 // TextAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.TextAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.TextAlignmentProperty, binding);


 // InnerLeftContent

/*ValueStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.InnerLeftContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.InnerLeftContentProperty, binding);


 // InnerRightContent

/*ValueStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.InnerRightContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.InnerRightContentProperty, binding);



}

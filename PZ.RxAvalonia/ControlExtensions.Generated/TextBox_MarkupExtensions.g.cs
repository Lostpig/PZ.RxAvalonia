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
public static partial class TextBox_MarkupExtensions
{
//================= Properties ======================//
 // IsInactiveSelectionHighlightEnabled

/*ValueSetterGenerator*/
public static T IsInactiveSelectionHighlightEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TextBox 
{
    control.IsInactiveSelectionHighlightEnabled = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsInactiveSelectionHighlightEnabled<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsInactiveSelectionHighlightEnabledProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsInactiveSelectionHighlightEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsInactiveSelectionHighlightEnabledProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsInactiveSelectionHighlightEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsInactiveSelectionHighlightEnabledProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsInactiveSelectionHighlightEnabled<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.IsInactiveSelectionHighlightEnabledProperty!, obs, changed);


 // ClearSelectionOnLostFocus

/*ValueSetterGenerator*/
public static T ClearSelectionOnLostFocus<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TextBox 
{
    control.ClearSelectionOnLostFocus = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ClearSelectionOnLostFocus<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.ClearSelectionOnLostFocusProperty!, func);

/*SetterFromObservableGenerator*/
public static T ClearSelectionOnLostFocus<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.ClearSelectionOnLostFocusProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ClearSelectionOnLostFocus<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.ClearSelectionOnLostFocusProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ClearSelectionOnLostFocus<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.ClearSelectionOnLostFocusProperty!, obs, changed);


 // AcceptsReturn

/*ValueSetterGenerator*/
public static T AcceptsReturn<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TextBox 
{
    control.AcceptsReturn = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T AcceptsReturn<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.AcceptsReturnProperty!, func);

/*SetterFromObservableGenerator*/
public static T AcceptsReturn<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.AcceptsReturnProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T AcceptsReturn<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.AcceptsReturnProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T AcceptsReturn<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.AcceptsReturnProperty!, obs, changed);


 // AcceptsTab

/*ValueSetterGenerator*/
public static T AcceptsTab<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TextBox 
{
    control.AcceptsTab = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T AcceptsTab<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.AcceptsTabProperty!, func);

/*SetterFromObservableGenerator*/
public static T AcceptsTab<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.AcceptsTabProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T AcceptsTab<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.AcceptsTabProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T AcceptsTab<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.AcceptsTabProperty!, obs, changed);


 // CaretIndex

/*ValueSetterGenerator*/
public static T CaretIndex<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TextBox 
{
    control.CaretIndex = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CaretIndex<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretIndexProperty!, func);

/*SetterFromObservableGenerator*/
public static T CaretIndex<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretIndexProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CaretIndex<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretIndexProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T CaretIndex<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.CaretIndexProperty!, obs, changed);


 // IsReadOnly

/*ValueSetterGenerator*/
public static T IsReadOnly<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TextBox 
{
    control.IsReadOnly = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsReadOnly<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsReadOnlyProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsReadOnly<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsReadOnlyProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsReadOnly<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsReadOnlyProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsReadOnly<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.IsReadOnlyProperty!, obs, changed);


 // PasswordChar

/*ValueSetterGenerator*/
public static T PasswordChar<T>(this T control, System.Char value) where T : Avalonia.Controls.TextBox 
{
    control.PasswordChar = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PasswordChar<T>(this T control, Func<System.Char> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.PasswordCharProperty!, func);

/*SetterFromObservableGenerator*/
public static T PasswordChar<T>(this T control, IObservable<System.Char> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.PasswordCharProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PasswordChar<T>(this T control, ISubject<System.Char> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.PasswordCharProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T PasswordChar<T>(this T control, IObservable<System.Char> obs, IObserver<System.Char> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.PasswordCharProperty!, obs, changed);


 // SelectionBrush

/*ValueSetterGenerator*/
public static T SelectionBrush<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.TextBox 
{
    control.SelectionBrush = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectionBrush<T>(this T control, Func<Avalonia.Media.IBrush?> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionBrushProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectionBrush<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionBrushProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectionBrush<T>(this T control, ISubject<Avalonia.Media.IBrush?> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionBrushProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SelectionBrush<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs, IObserver<Avalonia.Media.IBrush?> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.SelectionBrushProperty!, obs, changed);


 // SelectionForegroundBrush

/*ValueSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.TextBox 
{
    control.SelectionForegroundBrush = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectionForegroundBrush<T>(this T control, Func<Avalonia.Media.IBrush?> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectionForegroundBrush<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectionForegroundBrush<T>(this T control, ISubject<Avalonia.Media.IBrush?> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SelectionForegroundBrush<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs, IObserver<Avalonia.Media.IBrush?> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty!, obs, changed);


 // CaretBrush

/*ValueSetterGenerator*/
public static T CaretBrush<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.TextBox 
{
    control.CaretBrush = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CaretBrush<T>(this T control, Func<Avalonia.Media.IBrush?> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretBrushProperty!, func);

/*SetterFromObservableGenerator*/
public static T CaretBrush<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretBrushProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CaretBrush<T>(this T control, ISubject<Avalonia.Media.IBrush?> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretBrushProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T CaretBrush<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs, IObserver<Avalonia.Media.IBrush?> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.CaretBrushProperty!, obs, changed);


 // CaretBlinkInterval

/*ValueSetterGenerator*/
public static T CaretBlinkInterval<T>(this T control, System.TimeSpan value) where T : Avalonia.Controls.TextBox 
{
    control.CaretBlinkInterval = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CaretBlinkInterval<T>(this T control, Func<System.TimeSpan> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty!, func);

/*SetterFromObservableGenerator*/
public static T CaretBlinkInterval<T>(this T control, IObservable<System.TimeSpan> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CaretBlinkInterval<T>(this T control, ISubject<System.TimeSpan> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T CaretBlinkInterval<T>(this T control, IObservable<System.TimeSpan> obs, IObserver<System.TimeSpan> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty!, obs, changed);


 // SelectionStart

/*ValueSetterGenerator*/
public static T SelectionStart<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TextBox 
{
    control.SelectionStart = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectionStart<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionStartProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectionStart<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionStartProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectionStart<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionStartProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SelectionStart<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.SelectionStartProperty!, obs, changed);


 // SelectionEnd

/*ValueSetterGenerator*/
public static T SelectionEnd<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TextBox 
{
    control.SelectionEnd = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectionEnd<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionEndProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectionEnd<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionEndProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectionEnd<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.SelectionEndProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SelectionEnd<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.SelectionEndProperty!, obs, changed);


 // MaxLength

/*ValueSetterGenerator*/
public static T MaxLength<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TextBox 
{
    control.MaxLength = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MaxLength<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MaxLengthProperty!, func);

/*SetterFromObservableGenerator*/
public static T MaxLength<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MaxLengthProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MaxLength<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MaxLengthProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T MaxLength<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.MaxLengthProperty!, obs, changed);


 // MaxLines

/*ValueSetterGenerator*/
public static T MaxLines<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TextBox 
{
    control.MaxLines = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MaxLines<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MaxLinesProperty!, func);

/*SetterFromObservableGenerator*/
public static T MaxLines<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MaxLinesProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MaxLines<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MaxLinesProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T MaxLines<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.MaxLinesProperty!, obs, changed);


 // MinLines

/*ValueSetterGenerator*/
public static T MinLines<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TextBox 
{
    control.MinLines = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MinLines<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MinLinesProperty!, func);

/*SetterFromObservableGenerator*/
public static T MinLines<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MinLinesProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MinLines<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.MinLinesProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T MinLines<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.MinLinesProperty!, obs, changed);


 // Text

/*ValueSetterGenerator*/
public static T Text<T>(this T control, System.String? value) where T : Avalonia.Controls.TextBox 
{
    control.Text = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Text<T>(this T control, Func<System.String?> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextProperty!, func);

/*SetterFromObservableGenerator*/
public static T Text<T>(this T control, IObservable<System.String?> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Text<T>(this T control, ISubject<System.String?> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Text<T>(this T control, IObservable<System.String?> obs, IObserver<System.String?> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.TextProperty!, obs, changed);


 // TextAlignment

/*ValueSetterGenerator*/
public static T TextAlignment<T>(this T control, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.TextBox 
{
    control.TextAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TextAlignment<T>(this T control, Func<Avalonia.Media.TextAlignment> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T TextAlignment<T>(this T control, IObservable<Avalonia.Media.TextAlignment> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TextAlignment<T>(this T control, ISubject<Avalonia.Media.TextAlignment> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextAlignmentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T TextAlignment<T>(this T control, IObservable<Avalonia.Media.TextAlignment> obs, IObserver<Avalonia.Media.TextAlignment> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.TextAlignmentProperty!, obs, changed);


 // HorizontalContentAlignment

/*ValueSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.TextBox 
{
    control.HorizontalContentAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T HorizontalContentAlignment<T>(this T control, IObservable<Avalonia.Layout.HorizontalAlignment> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T HorizontalContentAlignment<T>(this T control, ISubject<Avalonia.Layout.HorizontalAlignment> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T HorizontalContentAlignment<T>(this T control, IObservable<Avalonia.Layout.HorizontalAlignment> obs, IObserver<Avalonia.Layout.HorizontalAlignment> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty!, obs, changed);


 // VerticalContentAlignment

/*ValueSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.TextBox 
{
    control.VerticalContentAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T VerticalContentAlignment<T>(this T control, IObservable<Avalonia.Layout.VerticalAlignment> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T VerticalContentAlignment<T>(this T control, ISubject<Avalonia.Layout.VerticalAlignment> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T VerticalContentAlignment<T>(this T control, IObservable<Avalonia.Layout.VerticalAlignment> obs, IObserver<Avalonia.Layout.VerticalAlignment> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty!, obs, changed);


 // TextWrapping

/*ValueSetterGenerator*/
public static T TextWrapping<T>(this T control, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.TextBox 
{
    control.TextWrapping = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TextWrapping<T>(this T control, Func<Avalonia.Media.TextWrapping> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextWrappingProperty!, func);

/*SetterFromObservableGenerator*/
public static T TextWrapping<T>(this T control, IObservable<Avalonia.Media.TextWrapping> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextWrappingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TextWrapping<T>(this T control, ISubject<Avalonia.Media.TextWrapping> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.TextWrappingProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T TextWrapping<T>(this T control, IObservable<Avalonia.Media.TextWrapping> obs, IObserver<Avalonia.Media.TextWrapping> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.TextWrappingProperty!, obs, changed);


 // LineHeight

/*ValueSetterGenerator*/
public static T LineHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.TextBox 
{
    control.LineHeight = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T LineHeight<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.LineHeightProperty!, func);

/*SetterFromObservableGenerator*/
public static T LineHeight<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.LineHeightProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T LineHeight<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.LineHeightProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T LineHeight<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.LineHeightProperty!, obs, changed);


 // LetterSpacing

/*ValueSetterGenerator*/
public static T LetterSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.TextBox 
{
    control.LetterSpacing = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T LetterSpacing<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.LetterSpacingProperty!, func);

/*SetterFromObservableGenerator*/
public static T LetterSpacing<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.LetterSpacingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T LetterSpacing<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.LetterSpacingProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T LetterSpacing<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.LetterSpacingProperty!, obs, changed);


 // Watermark

/*ValueSetterGenerator*/
public static T Watermark<T>(this T control, System.String? value) where T : Avalonia.Controls.TextBox 
{
    control.Watermark = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Watermark<T>(this T control, Func<System.String?> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.WatermarkProperty!, func);

/*SetterFromObservableGenerator*/
public static T Watermark<T>(this T control, IObservable<System.String?> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.WatermarkProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Watermark<T>(this T control, ISubject<System.String?> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.WatermarkProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Watermark<T>(this T control, IObservable<System.String?> obs, IObserver<System.String?> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.WatermarkProperty!, obs, changed);


 // UseFloatingWatermark

/*ValueSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TextBox 
{
    control.UseFloatingWatermark = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T UseFloatingWatermark<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty!, func);

/*SetterFromObservableGenerator*/
public static T UseFloatingWatermark<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T UseFloatingWatermark<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T UseFloatingWatermark<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty!, obs, changed);


 // NewLine

/*ValueSetterGenerator*/
public static T NewLine<T>(this T control, System.String value) where T : Avalonia.Controls.TextBox 
{
    control.NewLine = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T NewLine<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.NewLineProperty!, func);

/*SetterFromObservableGenerator*/
public static T NewLine<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.NewLineProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T NewLine<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.NewLineProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T NewLine<T>(this T control, IObservable<System.String> obs, IObserver<System.String> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.NewLineProperty!, obs, changed);


 // InnerLeftContent

/*ValueSetterGenerator*/
public static T InnerLeftContent<T>(this T control, System.Object? value) where T : Avalonia.Controls.TextBox 
{
    control.InnerLeftContent = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T InnerLeftContent<T>(this T control, Func<System.Object?> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.InnerLeftContentProperty!, func);

/*SetterFromObservableGenerator*/
public static T InnerLeftContent<T>(this T control, IObservable<System.Object?> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.InnerLeftContentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T InnerLeftContent<T>(this T control, ISubject<System.Object?> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.InnerLeftContentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T InnerLeftContent<T>(this T control, IObservable<System.Object?> obs, IObserver<System.Object?> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.InnerLeftContentProperty!, obs, changed);


 // InnerRightContent

/*ValueSetterGenerator*/
public static T InnerRightContent<T>(this T control, System.Object? value) where T : Avalonia.Controls.TextBox 
{
    control.InnerRightContent = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T InnerRightContent<T>(this T control, Func<System.Object?> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.InnerRightContentProperty!, func);

/*SetterFromObservableGenerator*/
public static T InnerRightContent<T>(this T control, IObservable<System.Object?> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.InnerRightContentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T InnerRightContent<T>(this T control, ISubject<System.Object?> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.InnerRightContentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T InnerRightContent<T>(this T control, IObservable<System.Object?> obs, IObserver<System.Object?> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.InnerRightContentProperty!, obs, changed);


 // RevealPassword

/*ValueSetterGenerator*/
public static T RevealPassword<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TextBox 
{
    control.RevealPassword = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T RevealPassword<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.RevealPasswordProperty!, func);

/*SetterFromObservableGenerator*/
public static T RevealPassword<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.RevealPasswordProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T RevealPassword<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.RevealPasswordProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T RevealPassword<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.RevealPasswordProperty!, obs, changed);


 // IsUndoEnabled

/*ValueSetterGenerator*/
public static T IsUndoEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TextBox 
{
    control.IsUndoEnabled = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsUndoEnabled<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsUndoEnabledProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsUndoEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsUndoEnabledProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsUndoEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.IsUndoEnabledProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsUndoEnabled<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.IsUndoEnabledProperty!, obs, changed);


 // UndoLimit

/*ValueSetterGenerator*/
public static T UndoLimit<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TextBox 
{
    control.UndoLimit = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T UndoLimit<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.UndoLimitProperty!, func);

/*SetterFromObservableGenerator*/
public static T UndoLimit<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.UndoLimitProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T UndoLimit<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.TextBox 
   => control._set(Avalonia.Controls.TextBox.UndoLimitProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T UndoLimit<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.TextBox 
   => control._setEx(Avalonia.Controls.TextBox.UndoLimitProperty!, obs, changed);



//================= Events ======================//
 // CopyingToClipboard

/*ActionToEventGenerator*/
public static T OnCopyingToClipboard<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TextBox 
{
  control.AddHandler(Avalonia.Controls.TextBox.CopyingToClipboardEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TextBox.CopyingToClipboardEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxCopyingToClipboard<T>(this T control, IObserver<Avalonia.Interactivity.RoutedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TextBox 
{
  control.AddHandler(Avalonia.Controls.TextBox.CopyingToClipboardEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.TextBox.CopyingToClipboardEvent.RoutingStrategies);
  return control;
}



 // CuttingToClipboard

/*ActionToEventGenerator*/
public static T OnCuttingToClipboard<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TextBox 
{
  control.AddHandler(Avalonia.Controls.TextBox.CuttingToClipboardEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TextBox.CuttingToClipboardEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxCuttingToClipboard<T>(this T control, IObserver<Avalonia.Interactivity.RoutedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TextBox 
{
  control.AddHandler(Avalonia.Controls.TextBox.CuttingToClipboardEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.TextBox.CuttingToClipboardEvent.RoutingStrategies);
  return control;
}



 // PastingFromClipboard

/*ActionToEventGenerator*/
public static T OnPastingFromClipboard<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TextBox 
{
  control.AddHandler(Avalonia.Controls.TextBox.PastingFromClipboardEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TextBox.PastingFromClipboardEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxPastingFromClipboard<T>(this T control, IObserver<Avalonia.Interactivity.RoutedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TextBox 
{
  control.AddHandler(Avalonia.Controls.TextBox.PastingFromClipboardEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.TextBox.PastingFromClipboardEvent.RoutingStrategies);
  return control;
}



 // TextChanged

/*ActionToEventGenerator*/
public static T OnTextChanged<T>(this T control, Action<Avalonia.Controls.TextChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TextBox 
{
  control.AddHandler(Avalonia.Controls.TextBox.TextChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TextBox.TextChangedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxTextChanged<T>(this T control, IObserver<Avalonia.Controls.TextChangedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TextBox 
{
  control.AddHandler(Avalonia.Controls.TextBox.TextChangedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.TextBox.TextChangedEvent.RoutingStrategies);
  return control;
}



 // TextChanging

/*ActionToEventGenerator*/
public static T OnTextChanging<T>(this T control, Action<Avalonia.Controls.TextChangingEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TextBox 
{
  control.AddHandler(Avalonia.Controls.TextBox.TextChangingEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TextBox.TextChangingEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxTextChanging<T>(this T control, IObserver<Avalonia.Controls.TextChangingEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TextBox 
{
  control.AddHandler(Avalonia.Controls.TextBox.TextChangingEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.TextBox.TextChangingEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // IsInactiveSelectionHighlightEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsInactiveSelectionHighlightEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.IsInactiveSelectionHighlightEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsInactiveSelectionHighlightEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.IsInactiveSelectionHighlightEnabledProperty, binding);


 // ClearSelectionOnLostFocus

/*ValueStyleSetterGenerator*/
public static Style<T> ClearSelectionOnLostFocus<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.ClearSelectionOnLostFocusProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ClearSelectionOnLostFocus<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.ClearSelectionOnLostFocusProperty, binding);


 // AcceptsReturn

/*ValueStyleSetterGenerator*/
public static Style<T> AcceptsReturn<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.AcceptsReturnProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AcceptsReturn<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.AcceptsReturnProperty, binding);


 // AcceptsTab

/*ValueStyleSetterGenerator*/
public static Style<T> AcceptsTab<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.AcceptsTabProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AcceptsTab<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.AcceptsTabProperty, binding);


 // CaretIndex

/*ValueStyleSetterGenerator*/
public static Style<T> CaretIndex<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.CaretIndexProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CaretIndex<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.CaretIndexProperty, binding);


 // IsReadOnly

/*ValueStyleSetterGenerator*/
public static Style<T> IsReadOnly<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.IsReadOnlyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsReadOnly<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.IsReadOnlyProperty, binding);


 // PasswordChar

/*ValueStyleSetterGenerator*/
public static Style<T> PasswordChar<T>(this Style<T> style, System.Char value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.PasswordCharProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PasswordChar<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.PasswordCharProperty, binding);


 // SelectionBrush

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionBrush<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionBrushProperty, binding);


 // SelectionForegroundBrush

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty, binding);


 // CaretBrush

/*ValueStyleSetterGenerator*/
public static Style<T> CaretBrush<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.CaretBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CaretBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.CaretBrushProperty, binding);


 // CaretBlinkInterval

/*ValueStyleSetterGenerator*/
public static Style<T> CaretBlinkInterval<T>(this Style<T> style, System.TimeSpan value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CaretBlinkInterval<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty, binding);


 // SelectionStart

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionStart<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionStartProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionStart<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionStartProperty, binding);


 // SelectionEnd

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionEnd<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionEndProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionEnd<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionEndProperty, binding);


 // MaxLength

/*ValueStyleSetterGenerator*/
public static Style<T> MaxLength<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.MaxLengthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxLength<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.MaxLengthProperty, binding);


 // MaxLines

/*ValueStyleSetterGenerator*/
public static Style<T> MaxLines<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.MaxLinesProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxLines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.MaxLinesProperty, binding);


 // MinLines

/*ValueStyleSetterGenerator*/
public static Style<T> MinLines<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.MinLinesProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinLines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.MinLinesProperty, binding);


 // Text

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String? value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.TextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.TextProperty, binding);


 // TextAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.TextAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.TextAlignmentProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty, binding);


 // TextWrapping

/*ValueStyleSetterGenerator*/
public static Style<T> TextWrapping<T>(this Style<T> style, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.TextWrappingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextWrapping<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.TextWrappingProperty, binding);


 // LineHeight

/*ValueStyleSetterGenerator*/
public static Style<T> LineHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.LineHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LineHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.LineHeightProperty, binding);


 // LetterSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> LetterSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.LetterSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LetterSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.LetterSpacingProperty, binding);


 // Watermark

/*ValueStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, System.String? value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.WatermarkProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.WatermarkProperty, binding);


 // UseFloatingWatermark

/*ValueStyleSetterGenerator*/
public static Style<T> UseFloatingWatermark<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UseFloatingWatermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty, binding);


 // NewLine

/*ValueStyleSetterGenerator*/
public static Style<T> NewLine<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.NewLineProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> NewLine<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.NewLineProperty, binding);


 // InnerLeftContent

/*ValueStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.InnerLeftContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.InnerLeftContentProperty, binding);


 // InnerRightContent

/*ValueStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.InnerRightContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.InnerRightContentProperty, binding);


 // RevealPassword

/*ValueStyleSetterGenerator*/
public static Style<T> RevealPassword<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.RevealPasswordProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RevealPassword<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.RevealPasswordProperty, binding);


 // IsUndoEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsUndoEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.IsUndoEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsUndoEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.IsUndoEnabledProperty, binding);


 // UndoLimit

/*ValueStyleSetterGenerator*/
public static Style<T> UndoLimit<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.UndoLimitProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UndoLimit<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.UndoLimitProperty, binding);



}

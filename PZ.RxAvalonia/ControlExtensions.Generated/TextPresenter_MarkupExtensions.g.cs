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
public static partial class TextPresenter_MarkupExtensions
{
//================= Properties ======================//
 // ShowSelectionHighlight

/*ValueSetterGenerator*/
public static T ShowSelectionHighlight<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Presenters.TextPresenter 
{
    control.ShowSelectionHighlight = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ShowSelectionHighlight<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.ShowSelectionHighlightProperty!, func);

/*SetterFromObservableGenerator*/
public static T ShowSelectionHighlight<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.ShowSelectionHighlightProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ShowSelectionHighlight<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.ShowSelectionHighlightProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ShowSelectionHighlight<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._setEx(Avalonia.Controls.Presenters.TextPresenter.ShowSelectionHighlightProperty!, obs, changed);


 // CaretIndex

/*ValueSetterGenerator*/
public static T CaretIndex<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Presenters.TextPresenter 
{
    control.CaretIndex = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CaretIndex<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty!, func);

/*SetterFromObservableGenerator*/
public static T CaretIndex<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CaretIndex<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T CaretIndex<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._setEx(Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty!, obs, changed);


 // RevealPassword

/*ValueSetterGenerator*/
public static T RevealPassword<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Presenters.TextPresenter 
{
    control.RevealPassword = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T RevealPassword<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty!, func);

/*SetterFromObservableGenerator*/
public static T RevealPassword<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T RevealPassword<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T RevealPassword<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._setEx(Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty!, obs, changed);


 // PasswordChar

/*ValueSetterGenerator*/
public static T PasswordChar<T>(this T control, System.Char value) where T : Avalonia.Controls.Presenters.TextPresenter 
{
    control.PasswordChar = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PasswordChar<T>(this T control, Func<System.Char> func) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty!, func);

/*SetterFromObservableGenerator*/
public static T PasswordChar<T>(this T control, IObservable<System.Char> obs) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PasswordChar<T>(this T control, ISubject<System.Char> subject) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T PasswordChar<T>(this T control, IObservable<System.Char> obs, IObserver<System.Char> changed) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._setEx(Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty!, obs, changed);


 // SelectionBrush

/*ValueSetterGenerator*/
public static T SelectionBrush<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.Presenters.TextPresenter 
{
    control.SelectionBrush = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectionBrush<T>(this T control, Func<Avalonia.Media.IBrush?> func) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectionBrush<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectionBrush<T>(this T control, ISubject<Avalonia.Media.IBrush?> subject) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SelectionBrush<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs, IObserver<Avalonia.Media.IBrush?> changed) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._setEx(Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty!, obs, changed);


 // SelectionForegroundBrush

/*ValueSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.Presenters.TextPresenter 
{
    control.SelectionForegroundBrush = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectionForegroundBrush<T>(this T control, Func<Avalonia.Media.IBrush?> func) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectionForegroundBrush<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectionForegroundBrush<T>(this T control, ISubject<Avalonia.Media.IBrush?> subject) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SelectionForegroundBrush<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs, IObserver<Avalonia.Media.IBrush?> changed) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._setEx(Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty!, obs, changed);


 // CaretBrush

/*ValueSetterGenerator*/
public static T CaretBrush<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.Presenters.TextPresenter 
{
    control.CaretBrush = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CaretBrush<T>(this T control, Func<Avalonia.Media.IBrush?> func) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty!, func);

/*SetterFromObservableGenerator*/
public static T CaretBrush<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CaretBrush<T>(this T control, ISubject<Avalonia.Media.IBrush?> subject) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T CaretBrush<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs, IObserver<Avalonia.Media.IBrush?> changed) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._setEx(Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty!, obs, changed);


 // CaretBlinkInterval

/*ValueSetterGenerator*/
public static T CaretBlinkInterval<T>(this T control, System.TimeSpan value) where T : Avalonia.Controls.Presenters.TextPresenter 
{
    control.CaretBlinkInterval = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CaretBlinkInterval<T>(this T control, Func<System.TimeSpan> func) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.CaretBlinkIntervalProperty!, func);

/*SetterFromObservableGenerator*/
public static T CaretBlinkInterval<T>(this T control, IObservable<System.TimeSpan> obs) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.CaretBlinkIntervalProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CaretBlinkInterval<T>(this T control, ISubject<System.TimeSpan> subject) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.CaretBlinkIntervalProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T CaretBlinkInterval<T>(this T control, IObservable<System.TimeSpan> obs, IObserver<System.TimeSpan> changed) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._setEx(Avalonia.Controls.Presenters.TextPresenter.CaretBlinkIntervalProperty!, obs, changed);


 // SelectionStart

/*ValueSetterGenerator*/
public static T SelectionStart<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Presenters.TextPresenter 
{
    control.SelectionStart = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectionStart<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectionStart<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectionStart<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SelectionStart<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._setEx(Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty!, obs, changed);


 // SelectionEnd

/*ValueSetterGenerator*/
public static T SelectionEnd<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Presenters.TextPresenter 
{
    control.SelectionEnd = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectionEnd<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectionEnd<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectionEnd<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SelectionEnd<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._setEx(Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty!, obs, changed);


 // Text

/*ValueSetterGenerator*/
public static T Text<T>(this T control, System.String? value) where T : Avalonia.Controls.Presenters.TextPresenter 
{
    control.Text = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Text<T>(this T control, Func<System.String?> func) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.TextProperty!, func);

/*SetterFromObservableGenerator*/
public static T Text<T>(this T control, IObservable<System.String?> obs) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.TextProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Text<T>(this T control, ISubject<System.String?> subject) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.TextProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Text<T>(this T control, IObservable<System.String?> obs, IObserver<System.String?> changed) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._setEx(Avalonia.Controls.Presenters.TextPresenter.TextProperty!, obs, changed);


 // PreeditText

/*ValueSetterGenerator*/
public static T PreeditText<T>(this T control, System.String? value) where T : Avalonia.Controls.Presenters.TextPresenter 
{
    control.PreeditText = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PreeditText<T>(this T control, Func<System.String?> func) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.PreeditTextProperty!, func);

/*SetterFromObservableGenerator*/
public static T PreeditText<T>(this T control, IObservable<System.String?> obs) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.PreeditTextProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PreeditText<T>(this T control, ISubject<System.String?> subject) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.PreeditTextProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T PreeditText<T>(this T control, IObservable<System.String?> obs, IObserver<System.String?> changed) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._setEx(Avalonia.Controls.Presenters.TextPresenter.PreeditTextProperty!, obs, changed);


 // PreeditTextCursorPosition

/*ValueSetterGenerator*/
public static T PreeditTextCursorPosition<T>(this T control, System.Nullable<System.Int32> value) where T : Avalonia.Controls.Presenters.TextPresenter 
{
    control.PreeditTextCursorPosition = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PreeditTextCursorPosition<T>(this T control, Func<System.Nullable<System.Int32>> func) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.PreeditTextCursorPositionProperty!, func);

/*SetterFromObservableGenerator*/
public static T PreeditTextCursorPosition<T>(this T control, IObservable<System.Nullable<System.Int32>> obs) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.PreeditTextCursorPositionProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PreeditTextCursorPosition<T>(this T control, ISubject<System.Nullable<System.Int32>> subject) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.PreeditTextCursorPositionProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T PreeditTextCursorPosition<T>(this T control, IObservable<System.Nullable<System.Int32>> obs, IObserver<System.Nullable<System.Int32>> changed) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._setEx(Avalonia.Controls.Presenters.TextPresenter.PreeditTextCursorPositionProperty!, obs, changed);


 // TextAlignment

/*ValueSetterGenerator*/
public static T TextAlignment<T>(this T control, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.Presenters.TextPresenter 
{
    control.TextAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TextAlignment<T>(this T control, Func<Avalonia.Media.TextAlignment> func) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.TextAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T TextAlignment<T>(this T control, IObservable<Avalonia.Media.TextAlignment> obs) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.TextAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TextAlignment<T>(this T control, ISubject<Avalonia.Media.TextAlignment> subject) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.TextAlignmentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T TextAlignment<T>(this T control, IObservable<Avalonia.Media.TextAlignment> obs, IObserver<Avalonia.Media.TextAlignment> changed) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._setEx(Avalonia.Controls.Presenters.TextPresenter.TextAlignmentProperty!, obs, changed);


 // TextWrapping

/*ValueSetterGenerator*/
public static T TextWrapping<T>(this T control, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.Presenters.TextPresenter 
{
    control.TextWrapping = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TextWrapping<T>(this T control, Func<Avalonia.Media.TextWrapping> func) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.TextWrappingProperty!, func);

/*SetterFromObservableGenerator*/
public static T TextWrapping<T>(this T control, IObservable<Avalonia.Media.TextWrapping> obs) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.TextWrappingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TextWrapping<T>(this T control, ISubject<Avalonia.Media.TextWrapping> subject) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.TextWrappingProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T TextWrapping<T>(this T control, IObservable<Avalonia.Media.TextWrapping> obs, IObserver<Avalonia.Media.TextWrapping> changed) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._setEx(Avalonia.Controls.Presenters.TextPresenter.TextWrappingProperty!, obs, changed);


 // LineHeight

/*ValueSetterGenerator*/
public static T LineHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.Presenters.TextPresenter 
{
    control.LineHeight = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T LineHeight<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.LineHeightProperty!, func);

/*SetterFromObservableGenerator*/
public static T LineHeight<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.LineHeightProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T LineHeight<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.LineHeightProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T LineHeight<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._setEx(Avalonia.Controls.Presenters.TextPresenter.LineHeightProperty!, obs, changed);


 // LetterSpacing

/*ValueSetterGenerator*/
public static T LetterSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.Presenters.TextPresenter 
{
    control.LetterSpacing = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T LetterSpacing<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.LetterSpacingProperty!, func);

/*SetterFromObservableGenerator*/
public static T LetterSpacing<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.LetterSpacingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T LetterSpacing<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.LetterSpacingProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T LetterSpacing<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._setEx(Avalonia.Controls.Presenters.TextPresenter.LetterSpacingProperty!, obs, changed);


 // Background

/*ValueSetterGenerator*/
public static T Background<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.Presenters.TextPresenter 
{
    control.Background = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Background<T>(this T control, Func<Avalonia.Media.IBrush?> func) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.BackgroundProperty!, func);

/*SetterFromObservableGenerator*/
public static T Background<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.BackgroundProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Background<T>(this T control, ISubject<Avalonia.Media.IBrush?> subject) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(Avalonia.Controls.Presenters.TextPresenter.BackgroundProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Background<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs, IObserver<Avalonia.Media.IBrush?> changed) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._setEx(Avalonia.Controls.Presenters.TextPresenter.BackgroundProperty!, obs, changed);



//================= Events ======================//
 // CaretBoundsChanged

/*ActionToEventGenerator*/
public static T OnCaretBoundsChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Presenters.TextPresenter  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.CaretBoundsChanged += h);

/*ReactiveEventGenerator*/
public static T RxCaretBoundsChanged<T>(this T control, IObserver<System.EventArgs> observer) where T : Avalonia.Controls.Presenters.TextPresenter  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => observer.OnNext((arg1))), h => control.CaretBoundsChanged += h);



//================= Styles ======================//
 // ShowSelectionHighlight

/*ValueStyleSetterGenerator*/
public static Style<T> ShowSelectionHighlight<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.ShowSelectionHighlightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowSelectionHighlight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.ShowSelectionHighlightProperty, binding);


 // CaretIndex

/*ValueStyleSetterGenerator*/
public static Style<T> CaretIndex<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CaretIndex<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty, binding);


 // RevealPassword

/*ValueStyleSetterGenerator*/
public static Style<T> RevealPassword<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RevealPassword<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty, binding);


 // PasswordChar

/*ValueStyleSetterGenerator*/
public static Style<T> PasswordChar<T>(this Style<T> style, System.Char value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PasswordChar<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty, binding);


 // SelectionBrush

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionBrush<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty, binding);


 // SelectionForegroundBrush

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty, binding);


 // CaretBrush

/*ValueStyleSetterGenerator*/
public static Style<T> CaretBrush<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CaretBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty, binding);


 // CaretBlinkInterval

/*ValueStyleSetterGenerator*/
public static Style<T> CaretBlinkInterval<T>(this Style<T> style, System.TimeSpan value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.CaretBlinkIntervalProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CaretBlinkInterval<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.CaretBlinkIntervalProperty, binding);


 // SelectionStart

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionStart<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionStart<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty, binding);


 // SelectionEnd

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionEnd<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionEnd<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty, binding);


 // Text

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String? value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.TextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.TextProperty, binding);


 // PreeditText

/*ValueStyleSetterGenerator*/
public static Style<T> PreeditText<T>(this Style<T> style, System.String? value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.PreeditTextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PreeditText<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.PreeditTextProperty, binding);


 // PreeditTextCursorPosition

/*ValueStyleSetterGenerator*/
public static Style<T> PreeditTextCursorPosition<T>(this Style<T> style, System.Nullable<System.Int32> value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.PreeditTextCursorPositionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PreeditTextCursorPosition<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.PreeditTextCursorPositionProperty, binding);


 // TextAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.TextAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.TextAlignmentProperty, binding);


 // TextWrapping

/*ValueStyleSetterGenerator*/
public static Style<T> TextWrapping<T>(this Style<T> style, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.TextWrappingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextWrapping<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.TextWrappingProperty, binding);


 // LineHeight

/*ValueStyleSetterGenerator*/
public static Style<T> LineHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.LineHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LineHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.LineHeightProperty, binding);


 // LetterSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> LetterSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.LetterSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LetterSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.LetterSpacingProperty, binding);


 // Background

/*ValueStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.BackgroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.BackgroundProperty, binding);



}

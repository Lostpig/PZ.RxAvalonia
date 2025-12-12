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
public static partial class TextBlock_MarkupExtensions
{
//================= Properties ======================//
 // Background

/*ValueSetterGenerator*/
public static T Background<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBlock 
{
    control.Background = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Background<T>(this T control, Func<Avalonia.Media.IBrush> func) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.BackgroundProperty!, func);

/*SetterFromObservableGenerator*/
public static T Background<T>(this T control, IObservable<Avalonia.Media.IBrush> obs) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.BackgroundProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Background<T>(this T control, ISubject<Avalonia.Media.IBrush> subject) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.BackgroundProperty!, subject);


 // Padding

/*ValueSetterGenerator*/
public static T Padding<T>(this T control, Avalonia.Thickness value) where T : Avalonia.Controls.TextBlock 
{
    control.Padding = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static T Padding<T>(this T control, System.Double uniformLength = default!) where T : Avalonia.Controls.TextBlock 
{
    control.Padding = new Avalonia.Thickness(uniformLength);
    return control;
}
public static T Padding<T>(this T control, System.Double horizontal = default!, System.Double vertical = default!) where T : Avalonia.Controls.TextBlock 
{
    control.Padding = new Avalonia.Thickness(horizontal, vertical);
    return control;
}
public static T Padding<T>(this T control, System.Double left = default!, System.Double top = default!, System.Double right = default!, System.Double bottom = default!) where T : Avalonia.Controls.TextBlock 
{
    control.Padding = new Avalonia.Thickness(left, top, right, bottom);
    return control;
}

/*SetterFromFuncGenerator*/
public static T Padding<T>(this T control, Func<Avalonia.Thickness> func) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.PaddingProperty!, func);

/*SetterFromObservableGenerator*/
public static T Padding<T>(this T control, IObservable<Avalonia.Thickness> obs) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.PaddingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Padding<T>(this T control, ISubject<Avalonia.Thickness> subject) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.PaddingProperty!, subject);


 // FontFamily

/*ValueSetterGenerator*/
public static T FontFamily<T>(this T control, Avalonia.Media.FontFamily value) where T : Avalonia.Controls.TextBlock 
{
    control.FontFamily = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FontFamily<T>(this T control, Func<Avalonia.Media.FontFamily> func) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontFamilyProperty!, func);

/*SetterFromObservableGenerator*/
public static T FontFamily<T>(this T control, IObservable<Avalonia.Media.FontFamily> obs) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontFamilyProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FontFamily<T>(this T control, ISubject<Avalonia.Media.FontFamily> subject) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontFamilyProperty!, subject);


 // FontSize

/*ValueSetterGenerator*/
public static T FontSize<T>(this T control, System.Double value) where T : Avalonia.Controls.TextBlock 
{
    control.FontSize = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FontSize<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontSizeProperty!, func);

/*SetterFromObservableGenerator*/
public static T FontSize<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontSizeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FontSize<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontSizeProperty!, subject);


 // FontStyle

/*ValueSetterGenerator*/
public static T FontStyle<T>(this T control, Avalonia.Media.FontStyle value) where T : Avalonia.Controls.TextBlock 
{
    control.FontStyle = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FontStyle<T>(this T control, Func<Avalonia.Media.FontStyle> func) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontStyleProperty!, func);

/*SetterFromObservableGenerator*/
public static T FontStyle<T>(this T control, IObservable<Avalonia.Media.FontStyle> obs) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontStyleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FontStyle<T>(this T control, ISubject<Avalonia.Media.FontStyle> subject) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontStyleProperty!, subject);


 // FontWeight

/*ValueSetterGenerator*/
public static T FontWeight<T>(this T control, Avalonia.Media.FontWeight value) where T : Avalonia.Controls.TextBlock 
{
    control.FontWeight = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FontWeight<T>(this T control, Func<Avalonia.Media.FontWeight> func) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontWeightProperty!, func);

/*SetterFromObservableGenerator*/
public static T FontWeight<T>(this T control, IObservable<Avalonia.Media.FontWeight> obs) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontWeightProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FontWeight<T>(this T control, ISubject<Avalonia.Media.FontWeight> subject) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontWeightProperty!, subject);


 // FontStretch

/*ValueSetterGenerator*/
public static T FontStretch<T>(this T control, Avalonia.Media.FontStretch value) where T : Avalonia.Controls.TextBlock 
{
    control.FontStretch = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FontStretch<T>(this T control, Func<Avalonia.Media.FontStretch> func) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontStretchProperty!, func);

/*SetterFromObservableGenerator*/
public static T FontStretch<T>(this T control, IObservable<Avalonia.Media.FontStretch> obs) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontStretchProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FontStretch<T>(this T control, ISubject<Avalonia.Media.FontStretch> subject) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontStretchProperty!, subject);


 // Foreground

/*ValueSetterGenerator*/
public static T Foreground<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBlock 
{
    control.Foreground = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Foreground<T>(this T control, Func<Avalonia.Media.IBrush> func) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.ForegroundProperty!, func);

/*SetterFromObservableGenerator*/
public static T Foreground<T>(this T control, IObservable<Avalonia.Media.IBrush> obs) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.ForegroundProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Foreground<T>(this T control, ISubject<Avalonia.Media.IBrush> subject) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.ForegroundProperty!, subject);


 // BaselineOffset

/*ValueSetterGenerator*/
public static T BaselineOffset<T>(this T control, System.Double value) where T : Avalonia.Controls.TextBlock 
{
    control.BaselineOffset = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T BaselineOffset<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.BaselineOffsetProperty!, func);

/*SetterFromObservableGenerator*/
public static T BaselineOffset<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.BaselineOffsetProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T BaselineOffset<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.BaselineOffsetProperty!, subject);


 // LineHeight

/*ValueSetterGenerator*/
public static T LineHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.TextBlock 
{
    control.LineHeight = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T LineHeight<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.LineHeightProperty!, func);

/*SetterFromObservableGenerator*/
public static T LineHeight<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.LineHeightProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T LineHeight<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.LineHeightProperty!, subject);


 // LineSpacing

/*ValueSetterGenerator*/
public static T LineSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.TextBlock 
{
    control.LineSpacing = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T LineSpacing<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.LineSpacingProperty!, func);

/*SetterFromObservableGenerator*/
public static T LineSpacing<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.LineSpacingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T LineSpacing<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.LineSpacingProperty!, subject);


 // LetterSpacing

/*ValueSetterGenerator*/
public static T LetterSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.TextBlock 
{
    control.LetterSpacing = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T LetterSpacing<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.LetterSpacingProperty!, func);

/*SetterFromObservableGenerator*/
public static T LetterSpacing<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.LetterSpacingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T LetterSpacing<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.LetterSpacingProperty!, subject);


 // MaxLines

/*ValueSetterGenerator*/
public static T MaxLines<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TextBlock 
{
    control.MaxLines = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MaxLines<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.MaxLinesProperty!, func);

/*SetterFromObservableGenerator*/
public static T MaxLines<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.MaxLinesProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MaxLines<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.MaxLinesProperty!, subject);


 // Text

/*ValueSetterGenerator*/
public static T Text<T>(this T control, System.String value) where T : Avalonia.Controls.TextBlock 
{
    control.Text = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Text<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextProperty!, func);

/*SetterFromObservableGenerator*/
public static T Text<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Text<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextProperty!, subject);


 // TextAlignment

/*ValueSetterGenerator*/
public static T TextAlignment<T>(this T control, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.TextBlock 
{
    control.TextAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TextAlignment<T>(this T control, Func<Avalonia.Media.TextAlignment> func) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T TextAlignment<T>(this T control, IObservable<Avalonia.Media.TextAlignment> obs) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TextAlignment<T>(this T control, ISubject<Avalonia.Media.TextAlignment> subject) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextAlignmentProperty!, subject);


 // TextWrapping

/*ValueSetterGenerator*/
public static T TextWrapping<T>(this T control, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.TextBlock 
{
    control.TextWrapping = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TextWrapping<T>(this T control, Func<Avalonia.Media.TextWrapping> func) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextWrappingProperty!, func);

/*SetterFromObservableGenerator*/
public static T TextWrapping<T>(this T control, IObservable<Avalonia.Media.TextWrapping> obs) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextWrappingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TextWrapping<T>(this T control, ISubject<Avalonia.Media.TextWrapping> subject) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextWrappingProperty!, subject);


 // TextTrimming

/*ValueSetterGenerator*/
public static T TextTrimming<T>(this T control, Avalonia.Media.TextTrimming value) where T : Avalonia.Controls.TextBlock 
{
    control.TextTrimming = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TextTrimming<T>(this T control, Func<Avalonia.Media.TextTrimming> func) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextTrimmingProperty!, func);

/*SetterFromObservableGenerator*/
public static T TextTrimming<T>(this T control, IObservable<Avalonia.Media.TextTrimming> obs) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextTrimmingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TextTrimming<T>(this T control, ISubject<Avalonia.Media.TextTrimming> subject) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextTrimmingProperty!, subject);


 // TextDecorations

/*ValueSetterGenerator*/
public static T TextDecorations<T>(this T control, Avalonia.Media.TextDecorationCollection value) where T : Avalonia.Controls.TextBlock 
{
    control.TextDecorations = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TextDecorations<T>(this T control, Func<Avalonia.Media.TextDecorationCollection> func) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextDecorationsProperty!, func);

/*SetterFromObservableGenerator*/
public static T TextDecorations<T>(this T control, IObservable<Avalonia.Media.TextDecorationCollection> obs) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextDecorationsProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TextDecorations<T>(this T control, ISubject<Avalonia.Media.TextDecorationCollection> subject) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.TextDecorationsProperty!, subject);


 // FontFeatures

/*ValueSetterGenerator*/
public static T FontFeatures<T>(this T control, Avalonia.Media.FontFeatureCollection value) where T : Avalonia.Controls.TextBlock 
{
    control.FontFeatures = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FontFeatures<T>(this T control, Func<Avalonia.Media.FontFeatureCollection> func) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontFeaturesProperty!, func);

/*SetterFromObservableGenerator*/
public static T FontFeatures<T>(this T control, IObservable<Avalonia.Media.FontFeatureCollection> obs) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontFeaturesProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FontFeatures<T>(this T control, ISubject<Avalonia.Media.FontFeatureCollection> subject) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.FontFeaturesProperty!, subject);


 // Inlines

/*ValueSetterGenerator*/
public static T Inlines<T>(this T control, Avalonia.Controls.Documents.InlineCollection value) where T : Avalonia.Controls.TextBlock 
{
    control.Inlines = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Inlines<T>(this T control, Func<Avalonia.Controls.Documents.InlineCollection> func) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.InlinesProperty!, func);

/*SetterFromObservableGenerator*/
public static T Inlines<T>(this T control, IObservable<Avalonia.Controls.Documents.InlineCollection> obs) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.InlinesProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Inlines<T>(this T control, ISubject<Avalonia.Controls.Documents.InlineCollection> subject) where T : Avalonia.Controls.TextBlock 
   => control._set(Avalonia.Controls.TextBlock.InlinesProperty!, subject);



//================= Attached Properties ======================//
 // BaselineOffset

/*AttachedPropertyFuncGenerator*/
public static T TextBlock_BaselineOffset<T>(this T control, Func<System.Double> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TextBlock.BaselineOffsetProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T TextBlock_BaselineOffset<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TextBlock.BaselineOffsetProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T TextBlock_BaselineOffset<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TextBlock.BaselineOffsetProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T TextBlock_BaselineOffset<T>(this T control, System.Double value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.TextBlock.BaselineOffsetProperty!, value);
    return control;
}


 // LineHeight

/*AttachedPropertyFuncGenerator*/
public static T TextBlock_LineHeight<T>(this T control, Func<System.Double> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TextBlock.LineHeightProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T TextBlock_LineHeight<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TextBlock.LineHeightProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T TextBlock_LineHeight<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TextBlock.LineHeightProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T TextBlock_LineHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.TextBlock.LineHeightProperty!, value);
    return control;
}


 // LetterSpacing

/*AttachedPropertyFuncGenerator*/
public static T TextBlock_LetterSpacing<T>(this T control, Func<System.Double> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TextBlock.LetterSpacingProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T TextBlock_LetterSpacing<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TextBlock.LetterSpacingProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T TextBlock_LetterSpacing<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TextBlock.LetterSpacingProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T TextBlock_LetterSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.TextBlock.LetterSpacingProperty!, value);
    return control;
}


 // MaxLines

/*AttachedPropertyFuncGenerator*/
public static T TextBlock_MaxLines<T>(this T control, Func<System.Int32> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TextBlock.MaxLinesProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T TextBlock_MaxLines<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TextBlock.MaxLinesProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T TextBlock_MaxLines<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TextBlock.MaxLinesProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T TextBlock_MaxLines<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.TextBlock.MaxLinesProperty!, value);
    return control;
}


 // TextAlignment

/*AttachedPropertyFuncGenerator*/
public static T TextBlock_TextAlignment<T>(this T control, Func<Avalonia.Media.TextAlignment> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TextBlock.TextAlignmentProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T TextBlock_TextAlignment<T>(this T control, IObservable<Avalonia.Media.TextAlignment> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TextBlock.TextAlignmentProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T TextBlock_TextAlignment<T>(this T control, ISubject<Avalonia.Media.TextAlignment> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TextBlock.TextAlignmentProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T TextBlock_TextAlignment<T>(this T control, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.TextBlock.TextAlignmentProperty!, value);
    return control;
}


 // TextWrapping

/*AttachedPropertyFuncGenerator*/
public static T TextBlock_TextWrapping<T>(this T control, Func<Avalonia.Media.TextWrapping> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TextBlock.TextWrappingProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T TextBlock_TextWrapping<T>(this T control, IObservable<Avalonia.Media.TextWrapping> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TextBlock.TextWrappingProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T TextBlock_TextWrapping<T>(this T control, ISubject<Avalonia.Media.TextWrapping> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TextBlock.TextWrappingProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T TextBlock_TextWrapping<T>(this T control, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.TextBlock.TextWrappingProperty!, value);
    return control;
}


 // TextTrimming

/*AttachedPropertyFuncGenerator*/
public static T TextBlock_TextTrimming<T>(this T control, Func<Avalonia.Media.TextTrimming> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TextBlock.TextTrimmingProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T TextBlock_TextTrimming<T>(this T control, IObservable<Avalonia.Media.TextTrimming> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TextBlock.TextTrimmingProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T TextBlock_TextTrimming<T>(this T control, ISubject<Avalonia.Media.TextTrimming> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TextBlock.TextTrimmingProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T TextBlock_TextTrimming<T>(this T control, Avalonia.Media.TextTrimming value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.TextBlock.TextTrimmingProperty!, value);
    return control;
}



//================= Styles ======================//
 // Background

/*ValueStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.BackgroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.BackgroundProperty, binding);


 // Padding

/*ValueStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.PaddingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.PaddingProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, System.Double uniformLength) where T : Avalonia.Controls.TextBlock 
   => style._addSetter(Avalonia.Controls.TextBlock.PaddingProperty, new Avalonia.Thickness(uniformLength));public static Style<T> Padding<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Avalonia.Controls.TextBlock 
   => style._addSetter(Avalonia.Controls.TextBlock.PaddingProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> Padding<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Avalonia.Controls.TextBlock 
   => style._addSetter(Avalonia.Controls.TextBlock.PaddingProperty, new Avalonia.Thickness(left, top, right, bottom));


 // FontFamily

/*ValueStyleSetterGenerator*/
public static Style<T> FontFamily<T>(this Style<T> style, Avalonia.Media.FontFamily value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontFamilyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontFamily<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontFamilyProperty, binding);


 // FontSize

/*ValueStyleSetterGenerator*/
public static Style<T> FontSize<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontSizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontSize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontSizeProperty, binding);


 // FontStyle

/*ValueStyleSetterGenerator*/
public static Style<T> FontStyle<T>(this Style<T> style, Avalonia.Media.FontStyle value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontStyleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontStyle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontStyleProperty, binding);


 // FontWeight

/*ValueStyleSetterGenerator*/
public static Style<T> FontWeight<T>(this Style<T> style, Avalonia.Media.FontWeight value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontWeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontWeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontWeightProperty, binding);


 // FontStretch

/*ValueStyleSetterGenerator*/
public static Style<T> FontStretch<T>(this Style<T> style, Avalonia.Media.FontStretch value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontStretchProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontStretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontStretchProperty, binding);


 // Foreground

/*ValueStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.ForegroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.ForegroundProperty, binding);


 // BaselineOffset

/*ValueStyleSetterGenerator*/
public static Style<T> BaselineOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.BaselineOffsetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BaselineOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.BaselineOffsetProperty, binding);


 // LineHeight

/*ValueStyleSetterGenerator*/
public static Style<T> LineHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.LineHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LineHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.LineHeightProperty, binding);


 // LineSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> LineSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.LineSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LineSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.LineSpacingProperty, binding);


 // LetterSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> LetterSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.LetterSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LetterSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.LetterSpacingProperty, binding);


 // MaxLines

/*ValueStyleSetterGenerator*/
public static Style<T> MaxLines<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.MaxLinesProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxLines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.MaxLinesProperty, binding);


 // Text

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextProperty, binding);


 // TextAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextAlignmentProperty, binding);


 // TextWrapping

/*ValueStyleSetterGenerator*/
public static Style<T> TextWrapping<T>(this Style<T> style, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextWrappingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextWrapping<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextWrappingProperty, binding);


 // TextTrimming

/*ValueStyleSetterGenerator*/
public static Style<T> TextTrimming<T>(this Style<T> style, Avalonia.Media.TextTrimming value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextTrimmingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextTrimming<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextTrimmingProperty, binding);


 // TextDecorations

/*ValueStyleSetterGenerator*/
public static Style<T> TextDecorations<T>(this Style<T> style, Avalonia.Media.TextDecorationCollection value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextDecorationsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextDecorations<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextDecorationsProperty, binding);


 // FontFeatures

/*ValueStyleSetterGenerator*/
public static Style<T> FontFeatures<T>(this Style<T> style, Avalonia.Media.FontFeatureCollection value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontFeaturesProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontFeatures<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontFeaturesProperty, binding);



}

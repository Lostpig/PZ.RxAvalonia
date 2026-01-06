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
public static partial class ContentPresenter_MarkupExtensions
{
//================= Properties ======================//
 // Background

/*ValueSetterGenerator*/
public static T Background<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.Background = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Background<T>(this T control, Func<Avalonia.Media.IBrush?> func) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty!, func);

/*SetterFromObservableGenerator*/
public static T Background<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Background<T>(this T control, ISubject<Avalonia.Media.IBrush?> subject) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Background<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs, IObserver<Avalonia.Media.IBrush?> changed) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._setEx(Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty!, obs, changed);


 // BackgroundSizing

/*ValueSetterGenerator*/
public static T BackgroundSizing<T>(this T control, Avalonia.Media.BackgroundSizing value) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.BackgroundSizing = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T BackgroundSizing<T>(this T control, Func<Avalonia.Media.BackgroundSizing> func) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BackgroundSizingProperty!, func);

/*SetterFromObservableGenerator*/
public static T BackgroundSizing<T>(this T control, IObservable<Avalonia.Media.BackgroundSizing> obs) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BackgroundSizingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T BackgroundSizing<T>(this T control, ISubject<Avalonia.Media.BackgroundSizing> subject) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BackgroundSizingProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T BackgroundSizing<T>(this T control, IObservable<Avalonia.Media.BackgroundSizing> obs, IObserver<Avalonia.Media.BackgroundSizing> changed) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._setEx(Avalonia.Controls.Presenters.ContentPresenter.BackgroundSizingProperty!, obs, changed);


 // BorderBrush

/*ValueSetterGenerator*/
public static T BorderBrush<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.BorderBrush = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T BorderBrush<T>(this T control, Func<Avalonia.Media.IBrush?> func) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty!, func);

/*SetterFromObservableGenerator*/
public static T BorderBrush<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T BorderBrush<T>(this T control, ISubject<Avalonia.Media.IBrush?> subject) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T BorderBrush<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs, IObserver<Avalonia.Media.IBrush?> changed) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._setEx(Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty!, obs, changed);


 // BorderThickness

/*ValueSetterGenerator*/
public static T BorderThickness<T>(this T control, Avalonia.Thickness value) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.BorderThickness = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static T BorderThickness<T>(this T control, System.Double uniformLength = default!) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.BorderThickness = new Avalonia.Thickness(uniformLength);
    return control;
}
public static T BorderThickness<T>(this T control, System.Double horizontal = default!, System.Double vertical = default!) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.BorderThickness = new Avalonia.Thickness(horizontal, vertical);
    return control;
}
public static T BorderThickness<T>(this T control, System.Double left = default!, System.Double top = default!, System.Double right = default!, System.Double bottom = default!) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.BorderThickness = new Avalonia.Thickness(left, top, right, bottom);
    return control;
}

/*SetterFromFuncGenerator*/
public static T BorderThickness<T>(this T control, Func<Avalonia.Thickness> func) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty!, func);

/*SetterFromObservableGenerator*/
public static T BorderThickness<T>(this T control, IObservable<Avalonia.Thickness> obs) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T BorderThickness<T>(this T control, ISubject<Avalonia.Thickness> subject) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T BorderThickness<T>(this T control, IObservable<Avalonia.Thickness> obs, IObserver<Avalonia.Thickness> changed) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._setEx(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty!, obs, changed);


 // CornerRadius

/*ValueSetterGenerator*/
public static T CornerRadius<T>(this T control, Avalonia.CornerRadius value) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.CornerRadius = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static T CornerRadius<T>(this T control, System.Double uniformRadius = default!) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.CornerRadius = new Avalonia.CornerRadius(uniformRadius);
    return control;
}
public static T CornerRadius<T>(this T control, System.Double top = default!, System.Double bottom = default!) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.CornerRadius = new Avalonia.CornerRadius(top, bottom);
    return control;
}
public static T CornerRadius<T>(this T control, System.Double topLeft = default!, System.Double topRight = default!, System.Double bottomRight = default!, System.Double bottomLeft = default!) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.CornerRadius = new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft);
    return control;
}

/*SetterFromFuncGenerator*/
public static T CornerRadius<T>(this T control, Func<Avalonia.CornerRadius> func) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty!, func);

/*SetterFromObservableGenerator*/
public static T CornerRadius<T>(this T control, IObservable<Avalonia.CornerRadius> obs) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CornerRadius<T>(this T control, ISubject<Avalonia.CornerRadius> subject) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T CornerRadius<T>(this T control, IObservable<Avalonia.CornerRadius> obs, IObserver<Avalonia.CornerRadius> changed) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._setEx(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty!, obs, changed);


 // BoxShadow

/*ValueSetterGenerator*/
public static T BoxShadow<T>(this T control, Avalonia.Media.BoxShadows value) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.BoxShadow = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static T BoxShadow<T>(this T control, Avalonia.Media.BoxShadow shadow = default!) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.BoxShadow = new Avalonia.Media.BoxShadows(shadow);
    return control;
}
public static T BoxShadow<T>(this T control, Avalonia.Media.BoxShadow first = default!, Avalonia.Media.BoxShadow[] rest = default!) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.BoxShadow = new Avalonia.Media.BoxShadows(first, rest);
    return control;
}

/*SetterFromFuncGenerator*/
public static T BoxShadow<T>(this T control, Func<Avalonia.Media.BoxShadows> func) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty!, func);

/*SetterFromObservableGenerator*/
public static T BoxShadow<T>(this T control, IObservable<Avalonia.Media.BoxShadows> obs) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T BoxShadow<T>(this T control, ISubject<Avalonia.Media.BoxShadows> subject) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T BoxShadow<T>(this T control, IObservable<Avalonia.Media.BoxShadows> obs, IObserver<Avalonia.Media.BoxShadows> changed) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._setEx(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty!, obs, changed);


 // Foreground

/*ValueSetterGenerator*/
public static T Foreground<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.Foreground = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Foreground<T>(this T control, Func<Avalonia.Media.IBrush?> func) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.ForegroundProperty!, func);

/*SetterFromObservableGenerator*/
public static T Foreground<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.ForegroundProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Foreground<T>(this T control, ISubject<Avalonia.Media.IBrush?> subject) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.ForegroundProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Foreground<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs, IObserver<Avalonia.Media.IBrush?> changed) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._setEx(Avalonia.Controls.Presenters.ContentPresenter.ForegroundProperty!, obs, changed);


 // FontFamily

/*ValueSetterGenerator*/
public static T FontFamily<T>(this T control, Avalonia.Media.FontFamily value) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.FontFamily = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FontFamily<T>(this T control, Func<Avalonia.Media.FontFamily> func) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontFamilyProperty!, func);

/*SetterFromObservableGenerator*/
public static T FontFamily<T>(this T control, IObservable<Avalonia.Media.FontFamily> obs) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontFamilyProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FontFamily<T>(this T control, ISubject<Avalonia.Media.FontFamily> subject) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontFamilyProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T FontFamily<T>(this T control, IObservable<Avalonia.Media.FontFamily> obs, IObserver<Avalonia.Media.FontFamily> changed) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._setEx(Avalonia.Controls.Presenters.ContentPresenter.FontFamilyProperty!, obs, changed);


 // FontSize

/*ValueSetterGenerator*/
public static T FontSize<T>(this T control, System.Double value) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.FontSize = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FontSize<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontSizeProperty!, func);

/*SetterFromObservableGenerator*/
public static T FontSize<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontSizeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FontSize<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontSizeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T FontSize<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._setEx(Avalonia.Controls.Presenters.ContentPresenter.FontSizeProperty!, obs, changed);


 // FontStyle

/*ValueSetterGenerator*/
public static T FontStyle<T>(this T control, Avalonia.Media.FontStyle value) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.FontStyle = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FontStyle<T>(this T control, Func<Avalonia.Media.FontStyle> func) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontStyleProperty!, func);

/*SetterFromObservableGenerator*/
public static T FontStyle<T>(this T control, IObservable<Avalonia.Media.FontStyle> obs) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontStyleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FontStyle<T>(this T control, ISubject<Avalonia.Media.FontStyle> subject) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontStyleProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T FontStyle<T>(this T control, IObservable<Avalonia.Media.FontStyle> obs, IObserver<Avalonia.Media.FontStyle> changed) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._setEx(Avalonia.Controls.Presenters.ContentPresenter.FontStyleProperty!, obs, changed);


 // FontWeight

/*ValueSetterGenerator*/
public static T FontWeight<T>(this T control, Avalonia.Media.FontWeight value) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.FontWeight = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FontWeight<T>(this T control, Func<Avalonia.Media.FontWeight> func) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontWeightProperty!, func);

/*SetterFromObservableGenerator*/
public static T FontWeight<T>(this T control, IObservable<Avalonia.Media.FontWeight> obs) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontWeightProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FontWeight<T>(this T control, ISubject<Avalonia.Media.FontWeight> subject) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontWeightProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T FontWeight<T>(this T control, IObservable<Avalonia.Media.FontWeight> obs, IObserver<Avalonia.Media.FontWeight> changed) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._setEx(Avalonia.Controls.Presenters.ContentPresenter.FontWeightProperty!, obs, changed);


 // FontStretch

/*ValueSetterGenerator*/
public static T FontStretch<T>(this T control, Avalonia.Media.FontStretch value) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.FontStretch = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FontStretch<T>(this T control, Func<Avalonia.Media.FontStretch> func) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontStretchProperty!, func);

/*SetterFromObservableGenerator*/
public static T FontStretch<T>(this T control, IObservable<Avalonia.Media.FontStretch> obs) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontStretchProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FontStretch<T>(this T control, ISubject<Avalonia.Media.FontStretch> subject) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.FontStretchProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T FontStretch<T>(this T control, IObservable<Avalonia.Media.FontStretch> obs, IObserver<Avalonia.Media.FontStretch> changed) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._setEx(Avalonia.Controls.Presenters.ContentPresenter.FontStretchProperty!, obs, changed);


 // TextAlignment

/*ValueSetterGenerator*/
public static T TextAlignment<T>(this T control, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.TextAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TextAlignment<T>(this T control, Func<Avalonia.Media.TextAlignment> func) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.TextAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T TextAlignment<T>(this T control, IObservable<Avalonia.Media.TextAlignment> obs) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.TextAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TextAlignment<T>(this T control, ISubject<Avalonia.Media.TextAlignment> subject) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.TextAlignmentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T TextAlignment<T>(this T control, IObservable<Avalonia.Media.TextAlignment> obs, IObserver<Avalonia.Media.TextAlignment> changed) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._setEx(Avalonia.Controls.Presenters.ContentPresenter.TextAlignmentProperty!, obs, changed);


 // TextWrapping

/*ValueSetterGenerator*/
public static T TextWrapping<T>(this T control, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.TextWrapping = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TextWrapping<T>(this T control, Func<Avalonia.Media.TextWrapping> func) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.TextWrappingProperty!, func);

/*SetterFromObservableGenerator*/
public static T TextWrapping<T>(this T control, IObservable<Avalonia.Media.TextWrapping> obs) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.TextWrappingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TextWrapping<T>(this T control, ISubject<Avalonia.Media.TextWrapping> subject) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.TextWrappingProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T TextWrapping<T>(this T control, IObservable<Avalonia.Media.TextWrapping> obs, IObserver<Avalonia.Media.TextWrapping> changed) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._setEx(Avalonia.Controls.Presenters.ContentPresenter.TextWrappingProperty!, obs, changed);


 // TextTrimming

/*ValueSetterGenerator*/
public static T TextTrimming<T>(this T control, Avalonia.Media.TextTrimming value) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.TextTrimming = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TextTrimming<T>(this T control, Func<Avalonia.Media.TextTrimming> func) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.TextTrimmingProperty!, func);

/*SetterFromObservableGenerator*/
public static T TextTrimming<T>(this T control, IObservable<Avalonia.Media.TextTrimming> obs) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.TextTrimmingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TextTrimming<T>(this T control, ISubject<Avalonia.Media.TextTrimming> subject) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.TextTrimmingProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T TextTrimming<T>(this T control, IObservable<Avalonia.Media.TextTrimming> obs, IObserver<Avalonia.Media.TextTrimming> changed) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._setEx(Avalonia.Controls.Presenters.ContentPresenter.TextTrimmingProperty!, obs, changed);


 // LineHeight

/*ValueSetterGenerator*/
public static T LineHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.LineHeight = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T LineHeight<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.LineHeightProperty!, func);

/*SetterFromObservableGenerator*/
public static T LineHeight<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.LineHeightProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T LineHeight<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.LineHeightProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T LineHeight<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._setEx(Avalonia.Controls.Presenters.ContentPresenter.LineHeightProperty!, obs, changed);


 // MaxLines

/*ValueSetterGenerator*/
public static T MaxLines<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.MaxLines = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MaxLines<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.MaxLinesProperty!, func);

/*SetterFromObservableGenerator*/
public static T MaxLines<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.MaxLinesProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MaxLines<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.MaxLinesProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T MaxLines<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._setEx(Avalonia.Controls.Presenters.ContentPresenter.MaxLinesProperty!, obs, changed);


 // Content

/*ValueSetterGenerator*/
public static T Content<T>(this T control, System.Object? value) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.Content = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Content<T>(this T control, Func<System.Object?> func) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.ContentProperty!, func);

/*SetterFromObservableGenerator*/
public static T Content<T>(this T control, IObservable<System.Object?> obs) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.ContentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Content<T>(this T control, ISubject<System.Object?> subject) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.ContentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Content<T>(this T control, IObservable<System.Object?> obs, IObserver<System.Object?> changed) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._setEx(Avalonia.Controls.Presenters.ContentPresenter.ContentProperty!, obs, changed);


 // ContentTemplate

/*ValueSetterGenerator*/
public static T ContentTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.ContentTemplate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ContentTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate?> func) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty!, func);

/*SetterFromObservableGenerator*/
public static T ContentTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ContentTemplate<T>(this T control, ISubject<Avalonia.Controls.Templates.IDataTemplate?> subject) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ContentTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs, IObserver<Avalonia.Controls.Templates.IDataTemplate?> changed) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._setEx(Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty!, obs, changed);


 // HorizontalContentAlignment

/*ValueSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.HorizontalContentAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T HorizontalContentAlignment<T>(this T control, IObservable<Avalonia.Layout.HorizontalAlignment> obs) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T HorizontalContentAlignment<T>(this T control, ISubject<Avalonia.Layout.HorizontalAlignment> subject) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T HorizontalContentAlignment<T>(this T control, IObservable<Avalonia.Layout.HorizontalAlignment> obs, IObserver<Avalonia.Layout.HorizontalAlignment> changed) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._setEx(Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty!, obs, changed);


 // VerticalContentAlignment

/*ValueSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.VerticalContentAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T VerticalContentAlignment<T>(this T control, IObservable<Avalonia.Layout.VerticalAlignment> obs) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T VerticalContentAlignment<T>(this T control, ISubject<Avalonia.Layout.VerticalAlignment> subject) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T VerticalContentAlignment<T>(this T control, IObservable<Avalonia.Layout.VerticalAlignment> obs, IObserver<Avalonia.Layout.VerticalAlignment> changed) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._setEx(Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty!, obs, changed);


 // Padding

/*ValueSetterGenerator*/
public static T Padding<T>(this T control, Avalonia.Thickness value) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.Padding = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static T Padding<T>(this T control, System.Double uniformLength = default!) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.Padding = new Avalonia.Thickness(uniformLength);
    return control;
}
public static T Padding<T>(this T control, System.Double horizontal = default!, System.Double vertical = default!) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.Padding = new Avalonia.Thickness(horizontal, vertical);
    return control;
}
public static T Padding<T>(this T control, System.Double left = default!, System.Double top = default!, System.Double right = default!, System.Double bottom = default!) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.Padding = new Avalonia.Thickness(left, top, right, bottom);
    return control;
}

/*SetterFromFuncGenerator*/
public static T Padding<T>(this T control, Func<Avalonia.Thickness> func) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty!, func);

/*SetterFromObservableGenerator*/
public static T Padding<T>(this T control, IObservable<Avalonia.Thickness> obs) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Padding<T>(this T control, ISubject<Avalonia.Thickness> subject) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Padding<T>(this T control, IObservable<Avalonia.Thickness> obs, IObserver<Avalonia.Thickness> changed) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._setEx(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty!, obs, changed);


 // RecognizesAccessKey

/*ValueSetterGenerator*/
public static T RecognizesAccessKey<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Presenters.ContentPresenter 
{
    control.RecognizesAccessKey = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T RecognizesAccessKey<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty!, func);

/*SetterFromObservableGenerator*/
public static T RecognizesAccessKey<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T RecognizesAccessKey<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T RecognizesAccessKey<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._setEx(Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty!, obs, changed);



//================= Styles ======================//
 // Background

/*ValueStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty, binding);


 // BackgroundSizing

/*ValueStyleSetterGenerator*/
public static Style<T> BackgroundSizing<T>(this Style<T> style, Avalonia.Media.BackgroundSizing value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BackgroundSizingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BackgroundSizing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BackgroundSizingProperty, binding);


 // BorderBrush

/*ValueStyleSetterGenerator*/
public static Style<T> BorderBrush<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BorderBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty, binding);


 // BorderThickness

/*ValueStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, System.Double uniformLength) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty, new Avalonia.Thickness(uniformLength));public static Style<T> BorderThickness<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> BorderThickness<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty, new Avalonia.Thickness(left, top, right, bottom));


 // CornerRadius

/*ValueStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, Avalonia.CornerRadius value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, System.Double uniformRadius) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty, new Avalonia.CornerRadius(uniformRadius));public static Style<T> CornerRadius<T>(this Style<T> style, System.Double top, System.Double bottom) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty, new Avalonia.CornerRadius(top, bottom));public static Style<T> CornerRadius<T>(this Style<T> style, System.Double topLeft, System.Double topRight, System.Double bottomRight, System.Double bottomLeft) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty, new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft));


 // BoxShadow

/*ValueStyleSetterGenerator*/
public static Style<T> BoxShadow<T>(this Style<T> style, Avalonia.Media.BoxShadows value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BoxShadow<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> BoxShadow<T>(this Style<T> style, Avalonia.Media.BoxShadow shadow) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty, new Avalonia.Media.BoxShadows(shadow));public static Style<T> BoxShadow<T>(this Style<T> style, Avalonia.Media.BoxShadow first, Avalonia.Media.BoxShadow[] rest) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty, new Avalonia.Media.BoxShadows(first, rest));


 // Foreground

/*ValueStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.ForegroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.ForegroundProperty, binding);


 // FontFamily

/*ValueStyleSetterGenerator*/
public static Style<T> FontFamily<T>(this Style<T> style, Avalonia.Media.FontFamily value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontFamilyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontFamily<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontFamilyProperty, binding);


 // FontSize

/*ValueStyleSetterGenerator*/
public static Style<T> FontSize<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontSizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontSize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontSizeProperty, binding);


 // FontStyle

/*ValueStyleSetterGenerator*/
public static Style<T> FontStyle<T>(this Style<T> style, Avalonia.Media.FontStyle value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontStyleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontStyle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontStyleProperty, binding);


 // FontWeight

/*ValueStyleSetterGenerator*/
public static Style<T> FontWeight<T>(this Style<T> style, Avalonia.Media.FontWeight value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontWeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontWeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontWeightProperty, binding);


 // FontStretch

/*ValueStyleSetterGenerator*/
public static Style<T> FontStretch<T>(this Style<T> style, Avalonia.Media.FontStretch value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontStretchProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontStretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontStretchProperty, binding);


 // TextAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.TextAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.TextAlignmentProperty, binding);


 // TextWrapping

/*ValueStyleSetterGenerator*/
public static Style<T> TextWrapping<T>(this Style<T> style, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.TextWrappingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextWrapping<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.TextWrappingProperty, binding);


 // TextTrimming

/*ValueStyleSetterGenerator*/
public static Style<T> TextTrimming<T>(this Style<T> style, Avalonia.Media.TextTrimming value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.TextTrimmingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextTrimming<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.TextTrimmingProperty, binding);


 // LineHeight

/*ValueStyleSetterGenerator*/
public static Style<T> LineHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.LineHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LineHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.LineHeightProperty, binding);


 // MaxLines

/*ValueStyleSetterGenerator*/
public static Style<T> MaxLines<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.MaxLinesProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxLines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.MaxLinesProperty, binding);


 // Content

/*ValueStyleSetterGenerator*/
public static Style<T> Content<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.ContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Content<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.ContentProperty, binding);


 // ContentTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> ContentTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ContentTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty, binding);


 // Padding

/*ValueStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, System.Double uniformLength) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty, new Avalonia.Thickness(uniformLength));public static Style<T> Padding<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> Padding<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty, new Avalonia.Thickness(left, top, right, bottom));


 // RecognizesAccessKey

/*ValueStyleSetterGenerator*/
public static Style<T> RecognizesAccessKey<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RecognizesAccessKey<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty, binding);



}

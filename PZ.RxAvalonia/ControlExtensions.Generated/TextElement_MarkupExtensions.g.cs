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
public static partial class TextElement_MarkupExtensions
{
//================= Properties ======================//
 // Background

/*ValueSetterGenerator*/
public static T Background<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Documents.TextElement 
{
    control.Background = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Background<T>(this T control, Func<Avalonia.Media.IBrush> func) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.BackgroundProperty!, func);

/*SetterFromObservableGenerator*/
public static T Background<T>(this T control, IObservable<Avalonia.Media.IBrush> obs) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.BackgroundProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Background<T>(this T control, ISubject<Avalonia.Media.IBrush> subject) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.BackgroundProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Background<T>(this T control, IObservable<Avalonia.Media.IBrush> obs, IObserver<Avalonia.Media.IBrush> changed) where T : Avalonia.Controls.Documents.TextElement 
   => control._setEx(Avalonia.Controls.Documents.TextElement.BackgroundProperty!, obs, changed);


 // FontFamily

/*ValueSetterGenerator*/
public static T FontFamily<T>(this T control, Avalonia.Media.FontFamily value) where T : Avalonia.Controls.Documents.TextElement 
{
    control.FontFamily = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FontFamily<T>(this T control, Func<Avalonia.Media.FontFamily> func) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontFamilyProperty!, func);

/*SetterFromObservableGenerator*/
public static T FontFamily<T>(this T control, IObservable<Avalonia.Media.FontFamily> obs) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontFamilyProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FontFamily<T>(this T control, ISubject<Avalonia.Media.FontFamily> subject) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontFamilyProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T FontFamily<T>(this T control, IObservable<Avalonia.Media.FontFamily> obs, IObserver<Avalonia.Media.FontFamily> changed) where T : Avalonia.Controls.Documents.TextElement 
   => control._setEx(Avalonia.Controls.Documents.TextElement.FontFamilyProperty!, obs, changed);


 // FontFeatures

/*ValueSetterGenerator*/
public static T FontFeatures<T>(this T control, Avalonia.Media.FontFeatureCollection value) where T : Avalonia.Controls.Documents.TextElement 
{
    control.FontFeatures = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FontFeatures<T>(this T control, Func<Avalonia.Media.FontFeatureCollection> func) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty!, func);

/*SetterFromObservableGenerator*/
public static T FontFeatures<T>(this T control, IObservable<Avalonia.Media.FontFeatureCollection> obs) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FontFeatures<T>(this T control, ISubject<Avalonia.Media.FontFeatureCollection> subject) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T FontFeatures<T>(this T control, IObservable<Avalonia.Media.FontFeatureCollection> obs, IObserver<Avalonia.Media.FontFeatureCollection> changed) where T : Avalonia.Controls.Documents.TextElement 
   => control._setEx(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty!, obs, changed);


 // FontSize

/*ValueSetterGenerator*/
public static T FontSize<T>(this T control, System.Double value) where T : Avalonia.Controls.Documents.TextElement 
{
    control.FontSize = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FontSize<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontSizeProperty!, func);

/*SetterFromObservableGenerator*/
public static T FontSize<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontSizeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FontSize<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontSizeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T FontSize<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.Documents.TextElement 
   => control._setEx(Avalonia.Controls.Documents.TextElement.FontSizeProperty!, obs, changed);


 // FontStyle

/*ValueSetterGenerator*/
public static T FontStyle<T>(this T control, Avalonia.Media.FontStyle value) where T : Avalonia.Controls.Documents.TextElement 
{
    control.FontStyle = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FontStyle<T>(this T control, Func<Avalonia.Media.FontStyle> func) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontStyleProperty!, func);

/*SetterFromObservableGenerator*/
public static T FontStyle<T>(this T control, IObservable<Avalonia.Media.FontStyle> obs) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontStyleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FontStyle<T>(this T control, ISubject<Avalonia.Media.FontStyle> subject) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontStyleProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T FontStyle<T>(this T control, IObservable<Avalonia.Media.FontStyle> obs, IObserver<Avalonia.Media.FontStyle> changed) where T : Avalonia.Controls.Documents.TextElement 
   => control._setEx(Avalonia.Controls.Documents.TextElement.FontStyleProperty!, obs, changed);


 // FontWeight

/*ValueSetterGenerator*/
public static T FontWeight<T>(this T control, Avalonia.Media.FontWeight value) where T : Avalonia.Controls.Documents.TextElement 
{
    control.FontWeight = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FontWeight<T>(this T control, Func<Avalonia.Media.FontWeight> func) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontWeightProperty!, func);

/*SetterFromObservableGenerator*/
public static T FontWeight<T>(this T control, IObservable<Avalonia.Media.FontWeight> obs) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontWeightProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FontWeight<T>(this T control, ISubject<Avalonia.Media.FontWeight> subject) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontWeightProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T FontWeight<T>(this T control, IObservable<Avalonia.Media.FontWeight> obs, IObserver<Avalonia.Media.FontWeight> changed) where T : Avalonia.Controls.Documents.TextElement 
   => control._setEx(Avalonia.Controls.Documents.TextElement.FontWeightProperty!, obs, changed);


 // FontStretch

/*ValueSetterGenerator*/
public static T FontStretch<T>(this T control, Avalonia.Media.FontStretch value) where T : Avalonia.Controls.Documents.TextElement 
{
    control.FontStretch = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FontStretch<T>(this T control, Func<Avalonia.Media.FontStretch> func) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontStretchProperty!, func);

/*SetterFromObservableGenerator*/
public static T FontStretch<T>(this T control, IObservable<Avalonia.Media.FontStretch> obs) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontStretchProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FontStretch<T>(this T control, ISubject<Avalonia.Media.FontStretch> subject) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.FontStretchProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T FontStretch<T>(this T control, IObservable<Avalonia.Media.FontStretch> obs, IObserver<Avalonia.Media.FontStretch> changed) where T : Avalonia.Controls.Documents.TextElement 
   => control._setEx(Avalonia.Controls.Documents.TextElement.FontStretchProperty!, obs, changed);


 // Foreground

/*ValueSetterGenerator*/
public static T Foreground<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Documents.TextElement 
{
    control.Foreground = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Foreground<T>(this T control, Func<Avalonia.Media.IBrush> func) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.ForegroundProperty!, func);

/*SetterFromObservableGenerator*/
public static T Foreground<T>(this T control, IObservable<Avalonia.Media.IBrush> obs) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.ForegroundProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Foreground<T>(this T control, ISubject<Avalonia.Media.IBrush> subject) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(Avalonia.Controls.Documents.TextElement.ForegroundProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Foreground<T>(this T control, IObservable<Avalonia.Media.IBrush> obs, IObserver<Avalonia.Media.IBrush> changed) where T : Avalonia.Controls.Documents.TextElement 
   => control._setEx(Avalonia.Controls.Documents.TextElement.ForegroundProperty!, obs, changed);



//================= Attached Properties ======================//
 // FontFamily

/*AttachedPropertyFuncGenerator*/
public static T TextElement_FontFamily<T>(this T control, Func<Avalonia.Media.FontFamily> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Documents.TextElement.FontFamilyProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T TextElement_FontFamily<T>(this T control, IObservable<Avalonia.Media.FontFamily> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Documents.TextElement.FontFamilyProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T TextElement_FontFamily<T>(this T control, ISubject<Avalonia.Media.FontFamily> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Documents.TextElement.FontFamilyProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T TextElement_FontFamily<T>(this T control, Avalonia.Media.FontFamily value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.Documents.TextElement.FontFamilyProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T TextElement_FontFamily<T>(this T control, IObservable<Avalonia.Media.FontFamily> obs, IObserver<Avalonia.Media.FontFamily> changed) where T : Avalonia.Controls.Control 
   => control._setEx(Avalonia.Controls.Documents.TextElement.FontFamilyProperty!, obs, changed);


 // FontFeatures

/*AttachedPropertyFuncGenerator*/
public static T TextElement_FontFeatures<T>(this T control, Func<Avalonia.Media.FontFeatureCollection> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T TextElement_FontFeatures<T>(this T control, IObservable<Avalonia.Media.FontFeatureCollection> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T TextElement_FontFeatures<T>(this T control, ISubject<Avalonia.Media.FontFeatureCollection> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T TextElement_FontFeatures<T>(this T control, Avalonia.Media.FontFeatureCollection value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T TextElement_FontFeatures<T>(this T control, IObservable<Avalonia.Media.FontFeatureCollection> obs, IObserver<Avalonia.Media.FontFeatureCollection> changed) where T : Avalonia.Controls.Control 
   => control._setEx(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty!, obs, changed);


 // FontSize

/*AttachedPropertyFuncGenerator*/
public static T TextElement_FontSize<T>(this T control, Func<System.Double> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Documents.TextElement.FontSizeProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T TextElement_FontSize<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Documents.TextElement.FontSizeProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T TextElement_FontSize<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Documents.TextElement.FontSizeProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T TextElement_FontSize<T>(this T control, System.Double value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.Documents.TextElement.FontSizeProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T TextElement_FontSize<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.Control 
   => control._setEx(Avalonia.Controls.Documents.TextElement.FontSizeProperty!, obs, changed);


 // FontStyle

/*AttachedPropertyFuncGenerator*/
public static T TextElement_FontStyle<T>(this T control, Func<Avalonia.Media.FontStyle> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Documents.TextElement.FontStyleProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T TextElement_FontStyle<T>(this T control, IObservable<Avalonia.Media.FontStyle> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Documents.TextElement.FontStyleProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T TextElement_FontStyle<T>(this T control, ISubject<Avalonia.Media.FontStyle> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Documents.TextElement.FontStyleProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T TextElement_FontStyle<T>(this T control, Avalonia.Media.FontStyle value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.Documents.TextElement.FontStyleProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T TextElement_FontStyle<T>(this T control, IObservable<Avalonia.Media.FontStyle> obs, IObserver<Avalonia.Media.FontStyle> changed) where T : Avalonia.Controls.Control 
   => control._setEx(Avalonia.Controls.Documents.TextElement.FontStyleProperty!, obs, changed);


 // FontWeight

/*AttachedPropertyFuncGenerator*/
public static T TextElement_FontWeight<T>(this T control, Func<Avalonia.Media.FontWeight> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Documents.TextElement.FontWeightProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T TextElement_FontWeight<T>(this T control, IObservable<Avalonia.Media.FontWeight> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Documents.TextElement.FontWeightProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T TextElement_FontWeight<T>(this T control, ISubject<Avalonia.Media.FontWeight> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Documents.TextElement.FontWeightProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T TextElement_FontWeight<T>(this T control, Avalonia.Media.FontWeight value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.Documents.TextElement.FontWeightProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T TextElement_FontWeight<T>(this T control, IObservable<Avalonia.Media.FontWeight> obs, IObserver<Avalonia.Media.FontWeight> changed) where T : Avalonia.Controls.Control 
   => control._setEx(Avalonia.Controls.Documents.TextElement.FontWeightProperty!, obs, changed);


 // FontStretch

/*AttachedPropertyFuncGenerator*/
public static T TextElement_FontStretch<T>(this T control, Func<Avalonia.Media.FontStretch> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Documents.TextElement.FontStretchProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T TextElement_FontStretch<T>(this T control, IObservable<Avalonia.Media.FontStretch> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Documents.TextElement.FontStretchProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T TextElement_FontStretch<T>(this T control, ISubject<Avalonia.Media.FontStretch> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Documents.TextElement.FontStretchProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T TextElement_FontStretch<T>(this T control, Avalonia.Media.FontStretch value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.Documents.TextElement.FontStretchProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T TextElement_FontStretch<T>(this T control, IObservable<Avalonia.Media.FontStretch> obs, IObserver<Avalonia.Media.FontStretch> changed) where T : Avalonia.Controls.Control 
   => control._setEx(Avalonia.Controls.Documents.TextElement.FontStretchProperty!, obs, changed);


 // Foreground

/*AttachedPropertyFuncGenerator*/
public static T TextElement_Foreground<T>(this T control, Func<Avalonia.Media.IBrush> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Documents.TextElement.ForegroundProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T TextElement_Foreground<T>(this T control, IObservable<Avalonia.Media.IBrush> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Documents.TextElement.ForegroundProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T TextElement_Foreground<T>(this T control, ISubject<Avalonia.Media.IBrush> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Documents.TextElement.ForegroundProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T TextElement_Foreground<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.Documents.TextElement.ForegroundProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T TextElement_Foreground<T>(this T control, IObservable<Avalonia.Media.IBrush> obs, IObserver<Avalonia.Media.IBrush> changed) where T : Avalonia.Controls.Control 
   => control._setEx(Avalonia.Controls.Documents.TextElement.ForegroundProperty!, obs, changed);



//================= Styles ======================//
 // Background

/*ValueStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.BackgroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.BackgroundProperty, binding);


 // FontFamily

/*ValueStyleSetterGenerator*/
public static Style<T> FontFamily<T>(this Style<T> style, Avalonia.Media.FontFamily value) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontFamilyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontFamily<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontFamilyProperty, binding);


 // FontFeatures

/*ValueStyleSetterGenerator*/
public static Style<T> FontFeatures<T>(this Style<T> style, Avalonia.Media.FontFeatureCollection value) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontFeatures<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty, binding);


 // FontSize

/*ValueStyleSetterGenerator*/
public static Style<T> FontSize<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontSizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontSize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontSizeProperty, binding);


 // FontStyle

/*ValueStyleSetterGenerator*/
public static Style<T> FontStyle<T>(this Style<T> style, Avalonia.Media.FontStyle value) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontStyleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontStyle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontStyleProperty, binding);


 // FontWeight

/*ValueStyleSetterGenerator*/
public static Style<T> FontWeight<T>(this Style<T> style, Avalonia.Media.FontWeight value) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontWeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontWeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontWeightProperty, binding);


 // FontStretch

/*ValueStyleSetterGenerator*/
public static Style<T> FontStretch<T>(this Style<T> style, Avalonia.Media.FontStretch value) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontStretchProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontStretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontStretchProperty, binding);


 // Foreground

/*ValueStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.ForegroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.ForegroundProperty, binding);



}

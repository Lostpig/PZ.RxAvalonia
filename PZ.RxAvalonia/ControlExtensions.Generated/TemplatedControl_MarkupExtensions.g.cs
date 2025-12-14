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
public static partial class TemplatedControl_MarkupExtensions
{
//================= Properties ======================//
 // Background

/*ValueSetterGenerator*/
public static T Background<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Primitives.TemplatedControl 
{
    control.Background = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Background<T>(this T control, Func<Avalonia.Media.IBrush> func) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty!, func);

/*SetterFromObservableGenerator*/
public static T Background<T>(this T control, IObservable<Avalonia.Media.IBrush> obs) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Background<T>(this T control, ISubject<Avalonia.Media.IBrush> subject) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Background<T>(this T control, IObservable<Avalonia.Media.IBrush> obs, IObserver<Avalonia.Media.IBrush> changed) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._setEx(Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty!, obs, changed);


 // BackgroundSizing

/*ValueSetterGenerator*/
public static T BackgroundSizing<T>(this T control, Avalonia.Media.BackgroundSizing value) where T : Avalonia.Controls.Primitives.TemplatedControl 
{
    control.BackgroundSizing = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T BackgroundSizing<T>(this T control, Func<Avalonia.Media.BackgroundSizing> func) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.BackgroundSizingProperty!, func);

/*SetterFromObservableGenerator*/
public static T BackgroundSizing<T>(this T control, IObservable<Avalonia.Media.BackgroundSizing> obs) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.BackgroundSizingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T BackgroundSizing<T>(this T control, ISubject<Avalonia.Media.BackgroundSizing> subject) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.BackgroundSizingProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T BackgroundSizing<T>(this T control, IObservable<Avalonia.Media.BackgroundSizing> obs, IObserver<Avalonia.Media.BackgroundSizing> changed) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._setEx(Avalonia.Controls.Primitives.TemplatedControl.BackgroundSizingProperty!, obs, changed);


 // BorderBrush

/*ValueSetterGenerator*/
public static T BorderBrush<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Primitives.TemplatedControl 
{
    control.BorderBrush = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T BorderBrush<T>(this T control, Func<Avalonia.Media.IBrush> func) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.BorderBrushProperty!, func);

/*SetterFromObservableGenerator*/
public static T BorderBrush<T>(this T control, IObservable<Avalonia.Media.IBrush> obs) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.BorderBrushProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T BorderBrush<T>(this T control, ISubject<Avalonia.Media.IBrush> subject) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.BorderBrushProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T BorderBrush<T>(this T control, IObservable<Avalonia.Media.IBrush> obs, IObserver<Avalonia.Media.IBrush> changed) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._setEx(Avalonia.Controls.Primitives.TemplatedControl.BorderBrushProperty!, obs, changed);


 // BorderThickness

/*ValueSetterGenerator*/
public static T BorderThickness<T>(this T control, Avalonia.Thickness value) where T : Avalonia.Controls.Primitives.TemplatedControl 
{
    control.BorderThickness = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static T BorderThickness<T>(this T control, System.Double uniformLength = default!) where T : Avalonia.Controls.Primitives.TemplatedControl 
{
    control.BorderThickness = new Avalonia.Thickness(uniformLength);
    return control;
}
public static T BorderThickness<T>(this T control, System.Double horizontal = default!, System.Double vertical = default!) where T : Avalonia.Controls.Primitives.TemplatedControl 
{
    control.BorderThickness = new Avalonia.Thickness(horizontal, vertical);
    return control;
}
public static T BorderThickness<T>(this T control, System.Double left = default!, System.Double top = default!, System.Double right = default!, System.Double bottom = default!) where T : Avalonia.Controls.Primitives.TemplatedControl 
{
    control.BorderThickness = new Avalonia.Thickness(left, top, right, bottom);
    return control;
}

/*SetterFromFuncGenerator*/
public static T BorderThickness<T>(this T control, Func<Avalonia.Thickness> func) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty!, func);

/*SetterFromObservableGenerator*/
public static T BorderThickness<T>(this T control, IObservable<Avalonia.Thickness> obs) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T BorderThickness<T>(this T control, ISubject<Avalonia.Thickness> subject) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T BorderThickness<T>(this T control, IObservable<Avalonia.Thickness> obs, IObserver<Avalonia.Thickness> changed) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._setEx(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty!, obs, changed);


 // CornerRadius

/*ValueSetterGenerator*/
public static T CornerRadius<T>(this T control, Avalonia.CornerRadius value) where T : Avalonia.Controls.Primitives.TemplatedControl 
{
    control.CornerRadius = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static T CornerRadius<T>(this T control, System.Double uniformRadius = default!) where T : Avalonia.Controls.Primitives.TemplatedControl 
{
    control.CornerRadius = new Avalonia.CornerRadius(uniformRadius);
    return control;
}
public static T CornerRadius<T>(this T control, System.Double top = default!, System.Double bottom = default!) where T : Avalonia.Controls.Primitives.TemplatedControl 
{
    control.CornerRadius = new Avalonia.CornerRadius(top, bottom);
    return control;
}
public static T CornerRadius<T>(this T control, System.Double topLeft = default!, System.Double topRight = default!, System.Double bottomRight = default!, System.Double bottomLeft = default!) where T : Avalonia.Controls.Primitives.TemplatedControl 
{
    control.CornerRadius = new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft);
    return control;
}

/*SetterFromFuncGenerator*/
public static T CornerRadius<T>(this T control, Func<Avalonia.CornerRadius> func) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty!, func);

/*SetterFromObservableGenerator*/
public static T CornerRadius<T>(this T control, IObservable<Avalonia.CornerRadius> obs) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CornerRadius<T>(this T control, ISubject<Avalonia.CornerRadius> subject) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T CornerRadius<T>(this T control, IObservable<Avalonia.CornerRadius> obs, IObserver<Avalonia.CornerRadius> changed) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._setEx(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty!, obs, changed);


 // FontFamily

/*ValueSetterGenerator*/
public static T FontFamily<T>(this T control, Avalonia.Media.FontFamily value) where T : Avalonia.Controls.Primitives.TemplatedControl 
{
    control.FontFamily = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FontFamily<T>(this T control, Func<Avalonia.Media.FontFamily> func) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontFamilyProperty!, func);

/*SetterFromObservableGenerator*/
public static T FontFamily<T>(this T control, IObservable<Avalonia.Media.FontFamily> obs) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontFamilyProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FontFamily<T>(this T control, ISubject<Avalonia.Media.FontFamily> subject) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontFamilyProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T FontFamily<T>(this T control, IObservable<Avalonia.Media.FontFamily> obs, IObserver<Avalonia.Media.FontFamily> changed) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._setEx(Avalonia.Controls.Primitives.TemplatedControl.FontFamilyProperty!, obs, changed);


 // FontFeatures

/*ValueSetterGenerator*/
public static T FontFeatures<T>(this T control, Avalonia.Media.FontFeatureCollection value) where T : Avalonia.Controls.Primitives.TemplatedControl 
{
    control.FontFeatures = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FontFeatures<T>(this T control, Func<Avalonia.Media.FontFeatureCollection> func) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontFeaturesProperty!, func);

/*SetterFromObservableGenerator*/
public static T FontFeatures<T>(this T control, IObservable<Avalonia.Media.FontFeatureCollection> obs) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontFeaturesProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FontFeatures<T>(this T control, ISubject<Avalonia.Media.FontFeatureCollection> subject) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontFeaturesProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T FontFeatures<T>(this T control, IObservable<Avalonia.Media.FontFeatureCollection> obs, IObserver<Avalonia.Media.FontFeatureCollection> changed) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._setEx(Avalonia.Controls.Primitives.TemplatedControl.FontFeaturesProperty!, obs, changed);


 // FontSize

/*ValueSetterGenerator*/
public static T FontSize<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.TemplatedControl 
{
    control.FontSize = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FontSize<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontSizeProperty!, func);

/*SetterFromObservableGenerator*/
public static T FontSize<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontSizeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FontSize<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontSizeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T FontSize<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._setEx(Avalonia.Controls.Primitives.TemplatedControl.FontSizeProperty!, obs, changed);


 // FontStyle

/*ValueSetterGenerator*/
public static T FontStyle<T>(this T control, Avalonia.Media.FontStyle value) where T : Avalonia.Controls.Primitives.TemplatedControl 
{
    control.FontStyle = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FontStyle<T>(this T control, Func<Avalonia.Media.FontStyle> func) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontStyleProperty!, func);

/*SetterFromObservableGenerator*/
public static T FontStyle<T>(this T control, IObservable<Avalonia.Media.FontStyle> obs) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontStyleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FontStyle<T>(this T control, ISubject<Avalonia.Media.FontStyle> subject) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontStyleProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T FontStyle<T>(this T control, IObservable<Avalonia.Media.FontStyle> obs, IObserver<Avalonia.Media.FontStyle> changed) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._setEx(Avalonia.Controls.Primitives.TemplatedControl.FontStyleProperty!, obs, changed);


 // FontWeight

/*ValueSetterGenerator*/
public static T FontWeight<T>(this T control, Avalonia.Media.FontWeight value) where T : Avalonia.Controls.Primitives.TemplatedControl 
{
    control.FontWeight = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FontWeight<T>(this T control, Func<Avalonia.Media.FontWeight> func) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontWeightProperty!, func);

/*SetterFromObservableGenerator*/
public static T FontWeight<T>(this T control, IObservable<Avalonia.Media.FontWeight> obs) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontWeightProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FontWeight<T>(this T control, ISubject<Avalonia.Media.FontWeight> subject) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontWeightProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T FontWeight<T>(this T control, IObservable<Avalonia.Media.FontWeight> obs, IObserver<Avalonia.Media.FontWeight> changed) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._setEx(Avalonia.Controls.Primitives.TemplatedControl.FontWeightProperty!, obs, changed);


 // FontStretch

/*ValueSetterGenerator*/
public static T FontStretch<T>(this T control, Avalonia.Media.FontStretch value) where T : Avalonia.Controls.Primitives.TemplatedControl 
{
    control.FontStretch = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FontStretch<T>(this T control, Func<Avalonia.Media.FontStretch> func) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontStretchProperty!, func);

/*SetterFromObservableGenerator*/
public static T FontStretch<T>(this T control, IObservable<Avalonia.Media.FontStretch> obs) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontStretchProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FontStretch<T>(this T control, ISubject<Avalonia.Media.FontStretch> subject) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.FontStretchProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T FontStretch<T>(this T control, IObservable<Avalonia.Media.FontStretch> obs, IObserver<Avalonia.Media.FontStretch> changed) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._setEx(Avalonia.Controls.Primitives.TemplatedControl.FontStretchProperty!, obs, changed);


 // Foreground

/*ValueSetterGenerator*/
public static T Foreground<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Primitives.TemplatedControl 
{
    control.Foreground = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Foreground<T>(this T control, Func<Avalonia.Media.IBrush> func) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.ForegroundProperty!, func);

/*SetterFromObservableGenerator*/
public static T Foreground<T>(this T control, IObservable<Avalonia.Media.IBrush> obs) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.ForegroundProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Foreground<T>(this T control, ISubject<Avalonia.Media.IBrush> subject) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.ForegroundProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Foreground<T>(this T control, IObservable<Avalonia.Media.IBrush> obs, IObserver<Avalonia.Media.IBrush> changed) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._setEx(Avalonia.Controls.Primitives.TemplatedControl.ForegroundProperty!, obs, changed);


 // Padding

/*ValueSetterGenerator*/
public static T Padding<T>(this T control, Avalonia.Thickness value) where T : Avalonia.Controls.Primitives.TemplatedControl 
{
    control.Padding = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static T Padding<T>(this T control, System.Double uniformLength = default!) where T : Avalonia.Controls.Primitives.TemplatedControl 
{
    control.Padding = new Avalonia.Thickness(uniformLength);
    return control;
}
public static T Padding<T>(this T control, System.Double horizontal = default!, System.Double vertical = default!) where T : Avalonia.Controls.Primitives.TemplatedControl 
{
    control.Padding = new Avalonia.Thickness(horizontal, vertical);
    return control;
}
public static T Padding<T>(this T control, System.Double left = default!, System.Double top = default!, System.Double right = default!, System.Double bottom = default!) where T : Avalonia.Controls.Primitives.TemplatedControl 
{
    control.Padding = new Avalonia.Thickness(left, top, right, bottom);
    return control;
}

/*SetterFromFuncGenerator*/
public static T Padding<T>(this T control, Func<Avalonia.Thickness> func) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty!, func);

/*SetterFromObservableGenerator*/
public static T Padding<T>(this T control, IObservable<Avalonia.Thickness> obs) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Padding<T>(this T control, ISubject<Avalonia.Thickness> subject) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Padding<T>(this T control, IObservable<Avalonia.Thickness> obs, IObserver<Avalonia.Thickness> changed) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._setEx(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty!, obs, changed);


 // Template

/*ValueSetterGenerator*/
public static T Template<T>(this T control, Avalonia.Controls.Templates.IControlTemplate value) where T : Avalonia.Controls.Primitives.TemplatedControl 
{
    control.Template = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Template<T>(this T control, Func<Avalonia.Controls.Templates.IControlTemplate> func) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty!, func);

/*SetterFromObservableGenerator*/
public static T Template<T>(this T control, IObservable<Avalonia.Controls.Templates.IControlTemplate> obs) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Template<T>(this T control, ISubject<Avalonia.Controls.Templates.IControlTemplate> subject) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Template<T>(this T control, IObservable<Avalonia.Controls.Templates.IControlTemplate> obs, IObserver<Avalonia.Controls.Templates.IControlTemplate> changed) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._setEx(Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty!, obs, changed);



//================= Attached Properties ======================//
 // IsTemplateFocusTarget

/*AttachedPropertyFuncGenerator*/
public static T TemplatedControl_IsTemplateFocusTarget<T>(this T control, Func<System.Boolean> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.IsTemplateFocusTargetProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T TemplatedControl_IsTemplateFocusTarget<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.IsTemplateFocusTargetProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T TemplatedControl_IsTemplateFocusTarget<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Primitives.TemplatedControl.IsTemplateFocusTargetProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T TemplatedControl_IsTemplateFocusTarget<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.Primitives.TemplatedControl.IsTemplateFocusTargetProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T TemplatedControl_IsTemplateFocusTarget<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Control 
   => control._setEx(Avalonia.Controls.Primitives.TemplatedControl.IsTemplateFocusTargetProperty!, obs, changed);



//================= Events ======================//
 // TemplateApplied

/*ActionToEventGenerator*/
public static T OnTemplateApplied<T>(this T control, Action<Avalonia.Controls.Primitives.TemplateAppliedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
{
  control.AddHandler(Avalonia.Controls.Primitives.TemplatedControl.TemplateAppliedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Primitives.TemplatedControl.TemplateAppliedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxTemplateApplied<T>(this T control, IObserver<Avalonia.Controls.Primitives.TemplateAppliedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
{
  control.AddHandler(Avalonia.Controls.Primitives.TemplatedControl.TemplateAppliedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.Primitives.TemplatedControl.TemplateAppliedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // Background

/*ValueStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty, binding);


 // BackgroundSizing

/*ValueStyleSetterGenerator*/
public static Style<T> BackgroundSizing<T>(this Style<T> style, Avalonia.Media.BackgroundSizing value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BackgroundSizingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BackgroundSizing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BackgroundSizingProperty, binding);


 // BorderBrush

/*ValueStyleSetterGenerator*/
public static Style<T> BorderBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BorderBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BorderBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BorderBrushProperty, binding);


 // BorderThickness

/*ValueStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, System.Double uniformLength) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty, new Avalonia.Thickness(uniformLength));public static Style<T> BorderThickness<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> BorderThickness<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty, new Avalonia.Thickness(left, top, right, bottom));


 // CornerRadius

/*ValueStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, Avalonia.CornerRadius value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, System.Double uniformRadius) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty, new Avalonia.CornerRadius(uniformRadius));public static Style<T> CornerRadius<T>(this Style<T> style, System.Double top, System.Double bottom) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty, new Avalonia.CornerRadius(top, bottom));public static Style<T> CornerRadius<T>(this Style<T> style, System.Double topLeft, System.Double topRight, System.Double bottomRight, System.Double bottomLeft) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty, new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft));


 // FontFamily

/*ValueStyleSetterGenerator*/
public static Style<T> FontFamily<T>(this Style<T> style, Avalonia.Media.FontFamily value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontFamilyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontFamily<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontFamilyProperty, binding);


 // FontFeatures

/*ValueStyleSetterGenerator*/
public static Style<T> FontFeatures<T>(this Style<T> style, Avalonia.Media.FontFeatureCollection value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontFeaturesProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontFeatures<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontFeaturesProperty, binding);


 // FontSize

/*ValueStyleSetterGenerator*/
public static Style<T> FontSize<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontSizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontSize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontSizeProperty, binding);


 // FontStyle

/*ValueStyleSetterGenerator*/
public static Style<T> FontStyle<T>(this Style<T> style, Avalonia.Media.FontStyle value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontStyleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontStyle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontStyleProperty, binding);


 // FontWeight

/*ValueStyleSetterGenerator*/
public static Style<T> FontWeight<T>(this Style<T> style, Avalonia.Media.FontWeight value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontWeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontWeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontWeightProperty, binding);


 // FontStretch

/*ValueStyleSetterGenerator*/
public static Style<T> FontStretch<T>(this Style<T> style, Avalonia.Media.FontStretch value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontStretchProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontStretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontStretchProperty, binding);


 // Foreground

/*ValueStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.ForegroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.ForegroundProperty, binding);


 // Padding

/*ValueStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, System.Double uniformLength) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty, new Avalonia.Thickness(uniformLength));public static Style<T> Padding<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> Padding<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty, new Avalonia.Thickness(left, top, right, bottom));


 // Template

/*ValueStyleSetterGenerator*/
public static Style<T> Template<T>(this Style<T> style, Avalonia.Controls.Templates.IControlTemplate value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Template<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty, binding);



}

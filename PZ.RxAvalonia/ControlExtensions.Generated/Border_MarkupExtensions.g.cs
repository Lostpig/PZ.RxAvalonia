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
public static partial class Border_MarkupExtensions
{
//================= Properties ======================//
 // Background

/*ValueSetterGenerator*/
public static T Background<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.Border 
{
    control.Background = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Background<T>(this T control, Func<Avalonia.Media.IBrush?> func) where T : Avalonia.Controls.Border 
   => control._set(Avalonia.Controls.Border.BackgroundProperty!, func);

/*SetterFromObservableGenerator*/
public static T Background<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs) where T : Avalonia.Controls.Border 
   => control._set(Avalonia.Controls.Border.BackgroundProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Background<T>(this T control, ISubject<Avalonia.Media.IBrush?> subject) where T : Avalonia.Controls.Border 
   => control._set(Avalonia.Controls.Border.BackgroundProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Background<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs, IObserver<Avalonia.Media.IBrush?> changed) where T : Avalonia.Controls.Border 
   => control._setEx(Avalonia.Controls.Border.BackgroundProperty!, obs, changed);


 // BackgroundSizing

/*ValueSetterGenerator*/
public static T BackgroundSizing<T>(this T control, Avalonia.Media.BackgroundSizing value) where T : Avalonia.Controls.Border 
{
    control.BackgroundSizing = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T BackgroundSizing<T>(this T control, Func<Avalonia.Media.BackgroundSizing> func) where T : Avalonia.Controls.Border 
   => control._set(Avalonia.Controls.Border.BackgroundSizingProperty!, func);

/*SetterFromObservableGenerator*/
public static T BackgroundSizing<T>(this T control, IObservable<Avalonia.Media.BackgroundSizing> obs) where T : Avalonia.Controls.Border 
   => control._set(Avalonia.Controls.Border.BackgroundSizingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T BackgroundSizing<T>(this T control, ISubject<Avalonia.Media.BackgroundSizing> subject) where T : Avalonia.Controls.Border 
   => control._set(Avalonia.Controls.Border.BackgroundSizingProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T BackgroundSizing<T>(this T control, IObservable<Avalonia.Media.BackgroundSizing> obs, IObserver<Avalonia.Media.BackgroundSizing> changed) where T : Avalonia.Controls.Border 
   => control._setEx(Avalonia.Controls.Border.BackgroundSizingProperty!, obs, changed);


 // BorderBrush

/*ValueSetterGenerator*/
public static T BorderBrush<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.Border 
{
    control.BorderBrush = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T BorderBrush<T>(this T control, Func<Avalonia.Media.IBrush?> func) where T : Avalonia.Controls.Border 
   => control._set(Avalonia.Controls.Border.BorderBrushProperty!, func);

/*SetterFromObservableGenerator*/
public static T BorderBrush<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs) where T : Avalonia.Controls.Border 
   => control._set(Avalonia.Controls.Border.BorderBrushProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T BorderBrush<T>(this T control, ISubject<Avalonia.Media.IBrush?> subject) where T : Avalonia.Controls.Border 
   => control._set(Avalonia.Controls.Border.BorderBrushProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T BorderBrush<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs, IObserver<Avalonia.Media.IBrush?> changed) where T : Avalonia.Controls.Border 
   => control._setEx(Avalonia.Controls.Border.BorderBrushProperty!, obs, changed);


 // BorderThickness

/*ValueSetterGenerator*/
public static T BorderThickness<T>(this T control, Avalonia.Thickness value) where T : Avalonia.Controls.Border 
{
    control.BorderThickness = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static T BorderThickness<T>(this T control, System.Double uniformLength = default!) where T : Avalonia.Controls.Border 
{
    control.BorderThickness = new Avalonia.Thickness(uniformLength);
    return control;
}
public static T BorderThickness<T>(this T control, System.Double horizontal = default!, System.Double vertical = default!) where T : Avalonia.Controls.Border 
{
    control.BorderThickness = new Avalonia.Thickness(horizontal, vertical);
    return control;
}
public static T BorderThickness<T>(this T control, System.Double left = default!, System.Double top = default!, System.Double right = default!, System.Double bottom = default!) where T : Avalonia.Controls.Border 
{
    control.BorderThickness = new Avalonia.Thickness(left, top, right, bottom);
    return control;
}

/*SetterFromFuncGenerator*/
public static T BorderThickness<T>(this T control, Func<Avalonia.Thickness> func) where T : Avalonia.Controls.Border 
   => control._set(Avalonia.Controls.Border.BorderThicknessProperty!, func);

/*SetterFromObservableGenerator*/
public static T BorderThickness<T>(this T control, IObservable<Avalonia.Thickness> obs) where T : Avalonia.Controls.Border 
   => control._set(Avalonia.Controls.Border.BorderThicknessProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T BorderThickness<T>(this T control, ISubject<Avalonia.Thickness> subject) where T : Avalonia.Controls.Border 
   => control._set(Avalonia.Controls.Border.BorderThicknessProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T BorderThickness<T>(this T control, IObservable<Avalonia.Thickness> obs, IObserver<Avalonia.Thickness> changed) where T : Avalonia.Controls.Border 
   => control._setEx(Avalonia.Controls.Border.BorderThicknessProperty!, obs, changed);


 // CornerRadius

/*ValueSetterGenerator*/
public static T CornerRadius<T>(this T control, Avalonia.CornerRadius value) where T : Avalonia.Controls.Border 
{
    control.CornerRadius = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static T CornerRadius<T>(this T control, System.Double uniformRadius = default!) where T : Avalonia.Controls.Border 
{
    control.CornerRadius = new Avalonia.CornerRadius(uniformRadius);
    return control;
}
public static T CornerRadius<T>(this T control, System.Double top = default!, System.Double bottom = default!) where T : Avalonia.Controls.Border 
{
    control.CornerRadius = new Avalonia.CornerRadius(top, bottom);
    return control;
}
public static T CornerRadius<T>(this T control, System.Double topLeft = default!, System.Double topRight = default!, System.Double bottomRight = default!, System.Double bottomLeft = default!) where T : Avalonia.Controls.Border 
{
    control.CornerRadius = new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft);
    return control;
}

/*SetterFromFuncGenerator*/
public static T CornerRadius<T>(this T control, Func<Avalonia.CornerRadius> func) where T : Avalonia.Controls.Border 
   => control._set(Avalonia.Controls.Border.CornerRadiusProperty!, func);

/*SetterFromObservableGenerator*/
public static T CornerRadius<T>(this T control, IObservable<Avalonia.CornerRadius> obs) where T : Avalonia.Controls.Border 
   => control._set(Avalonia.Controls.Border.CornerRadiusProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CornerRadius<T>(this T control, ISubject<Avalonia.CornerRadius> subject) where T : Avalonia.Controls.Border 
   => control._set(Avalonia.Controls.Border.CornerRadiusProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T CornerRadius<T>(this T control, IObservable<Avalonia.CornerRadius> obs, IObserver<Avalonia.CornerRadius> changed) where T : Avalonia.Controls.Border 
   => control._setEx(Avalonia.Controls.Border.CornerRadiusProperty!, obs, changed);


 // BoxShadow

/*ValueSetterGenerator*/
public static T BoxShadow<T>(this T control, Avalonia.Media.BoxShadows value) where T : Avalonia.Controls.Border 
{
    control.BoxShadow = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static T BoxShadow<T>(this T control, Avalonia.Media.BoxShadow shadow = default!) where T : Avalonia.Controls.Border 
{
    control.BoxShadow = new Avalonia.Media.BoxShadows(shadow);
    return control;
}
public static T BoxShadow<T>(this T control, Avalonia.Media.BoxShadow first = default!, Avalonia.Media.BoxShadow[] rest = default!) where T : Avalonia.Controls.Border 
{
    control.BoxShadow = new Avalonia.Media.BoxShadows(first, rest);
    return control;
}

/*SetterFromFuncGenerator*/
public static T BoxShadow<T>(this T control, Func<Avalonia.Media.BoxShadows> func) where T : Avalonia.Controls.Border 
   => control._set(Avalonia.Controls.Border.BoxShadowProperty!, func);

/*SetterFromObservableGenerator*/
public static T BoxShadow<T>(this T control, IObservable<Avalonia.Media.BoxShadows> obs) where T : Avalonia.Controls.Border 
   => control._set(Avalonia.Controls.Border.BoxShadowProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T BoxShadow<T>(this T control, ISubject<Avalonia.Media.BoxShadows> subject) where T : Avalonia.Controls.Border 
   => control._set(Avalonia.Controls.Border.BoxShadowProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T BoxShadow<T>(this T control, IObservable<Avalonia.Media.BoxShadows> obs, IObserver<Avalonia.Media.BoxShadows> changed) where T : Avalonia.Controls.Border 
   => control._setEx(Avalonia.Controls.Border.BoxShadowProperty!, obs, changed);



//================= Styles ======================//
 // Background

/*ValueStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.Border 
=> style._addSetter(Avalonia.Controls.Border.BackgroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Border 
=> style._addSetter(Avalonia.Controls.Border.BackgroundProperty, binding);


 // BackgroundSizing

/*ValueStyleSetterGenerator*/
public static Style<T> BackgroundSizing<T>(this Style<T> style, Avalonia.Media.BackgroundSizing value) where T : Avalonia.Controls.Border 
=> style._addSetter(Avalonia.Controls.Border.BackgroundSizingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BackgroundSizing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Border 
=> style._addSetter(Avalonia.Controls.Border.BackgroundSizingProperty, binding);


 // BorderBrush

/*ValueStyleSetterGenerator*/
public static Style<T> BorderBrush<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.Border 
=> style._addSetter(Avalonia.Controls.Border.BorderBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BorderBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Border 
=> style._addSetter(Avalonia.Controls.Border.BorderBrushProperty, binding);


 // BorderThickness

/*ValueStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.Border 
=> style._addSetter(Avalonia.Controls.Border.BorderThicknessProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Border 
=> style._addSetter(Avalonia.Controls.Border.BorderThicknessProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, System.Double uniformLength) where T : Avalonia.Controls.Border 
   => style._addSetter(Avalonia.Controls.Border.BorderThicknessProperty, new Avalonia.Thickness(uniformLength));public static Style<T> BorderThickness<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Avalonia.Controls.Border 
   => style._addSetter(Avalonia.Controls.Border.BorderThicknessProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> BorderThickness<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Avalonia.Controls.Border 
   => style._addSetter(Avalonia.Controls.Border.BorderThicknessProperty, new Avalonia.Thickness(left, top, right, bottom));


 // CornerRadius

/*ValueStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, Avalonia.CornerRadius value) where T : Avalonia.Controls.Border 
=> style._addSetter(Avalonia.Controls.Border.CornerRadiusProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Border 
=> style._addSetter(Avalonia.Controls.Border.CornerRadiusProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, System.Double uniformRadius) where T : Avalonia.Controls.Border 
   => style._addSetter(Avalonia.Controls.Border.CornerRadiusProperty, new Avalonia.CornerRadius(uniformRadius));public static Style<T> CornerRadius<T>(this Style<T> style, System.Double top, System.Double bottom) where T : Avalonia.Controls.Border 
   => style._addSetter(Avalonia.Controls.Border.CornerRadiusProperty, new Avalonia.CornerRadius(top, bottom));public static Style<T> CornerRadius<T>(this Style<T> style, System.Double topLeft, System.Double topRight, System.Double bottomRight, System.Double bottomLeft) where T : Avalonia.Controls.Border 
   => style._addSetter(Avalonia.Controls.Border.CornerRadiusProperty, new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft));


 // BoxShadow

/*ValueStyleSetterGenerator*/
public static Style<T> BoxShadow<T>(this Style<T> style, Avalonia.Media.BoxShadows value) where T : Avalonia.Controls.Border 
=> style._addSetter(Avalonia.Controls.Border.BoxShadowProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BoxShadow<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Border 
=> style._addSetter(Avalonia.Controls.Border.BoxShadowProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> BoxShadow<T>(this Style<T> style, Avalonia.Media.BoxShadow shadow) where T : Avalonia.Controls.Border 
   => style._addSetter(Avalonia.Controls.Border.BoxShadowProperty, new Avalonia.Media.BoxShadows(shadow));public static Style<T> BoxShadow<T>(this Style<T> style, Avalonia.Media.BoxShadow first, Avalonia.Media.BoxShadow[] rest) where T : Avalonia.Controls.Border 
   => style._addSetter(Avalonia.Controls.Border.BoxShadowProperty, new Avalonia.Media.BoxShadows(first, rest));



}

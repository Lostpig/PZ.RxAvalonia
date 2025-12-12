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
public static partial class TopLevel_MarkupExtensions
{
//================= Properties ======================//
 // TransparencyLevelHint

/*ValueSetterGenerator*/
public static T TransparencyLevelHint<T>(this T control, System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel> value) where T : Avalonia.Controls.TopLevel 
{
    control.TransparencyLevelHint = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TransparencyLevelHint<T>(this T control, Func<System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel>> func) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty!, func);

/*SetterFromObservableGenerator*/
public static T TransparencyLevelHint<T>(this T control, IObservable<System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel>> obs) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TransparencyLevelHint<T>(this T control, ISubject<System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel>> subject) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty!, subject);


 // TransparencyBackgroundFallback

/*ValueSetterGenerator*/
public static T TransparencyBackgroundFallback<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TopLevel 
{
    control.TransparencyBackgroundFallback = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TransparencyBackgroundFallback<T>(this T control, Func<Avalonia.Media.IBrush> func) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty!, func);

/*SetterFromObservableGenerator*/
public static T TransparencyBackgroundFallback<T>(this T control, IObservable<Avalonia.Media.IBrush> obs) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TransparencyBackgroundFallback<T>(this T control, ISubject<Avalonia.Media.IBrush> subject) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty!, subject);


 // RequestedThemeVariant

/*ValueSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, Avalonia.Styling.ThemeVariant value) where T : Avalonia.Controls.TopLevel 
{
    control.RequestedThemeVariant = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T RequestedThemeVariant<T>(this T control, Func<Avalonia.Styling.ThemeVariant> func) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty!, func);

/*SetterFromObservableGenerator*/
public static T RequestedThemeVariant<T>(this T control, IObservable<Avalonia.Styling.ThemeVariant> obs) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T RequestedThemeVariant<T>(this T control, ISubject<Avalonia.Styling.ThemeVariant> subject) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty!, subject);



//================= Attached Properties ======================//
 // SystemBarColor

/*AttachedPropertyFuncGenerator*/
public static T TopLevel_SystemBarColor<T>(this T control, Func<Avalonia.Media.SolidColorBrush> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TopLevel.SystemBarColorProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T TopLevel_SystemBarColor<T>(this T control, IObservable<Avalonia.Media.SolidColorBrush> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TopLevel.SystemBarColorProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T TopLevel_SystemBarColor<T>(this T control, ISubject<Avalonia.Media.SolidColorBrush> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TopLevel.SystemBarColorProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T TopLevel_SystemBarColor<T>(this T control, Avalonia.Media.SolidColorBrush value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.TopLevel.SystemBarColorProperty!, value);
    return control;
}


 // AutoSafeAreaPadding

/*AttachedPropertyFuncGenerator*/
public static T TopLevel_AutoSafeAreaPadding<T>(this T control, Func<System.Boolean> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TopLevel.AutoSafeAreaPaddingProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T TopLevel_AutoSafeAreaPadding<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TopLevel.AutoSafeAreaPaddingProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T TopLevel_AutoSafeAreaPadding<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TopLevel.AutoSafeAreaPaddingProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T TopLevel_AutoSafeAreaPadding<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.TopLevel.AutoSafeAreaPaddingProperty!, value);
    return control;
}



//================= Events ======================//
 // Opened

/*ActionToEventGenerator*/
public static T OnOpened<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.TopLevel  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Opened += h);


 // Closed

/*ActionToEventGenerator*/
public static T OnClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.TopLevel  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Closed += h);


 // ScalingChanged

/*ActionToEventGenerator*/
public static T OnScalingChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.TopLevel  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.ScalingChanged += h);


 // BackRequested

/*ActionToEventGenerator*/
public static T OnBackRequested<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TopLevel 
{
  control.AddHandler(Avalonia.Controls.TopLevel.BackRequestedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TopLevel.BackRequestedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // TransparencyLevelHint

/*ValueStyleSetterGenerator*/
public static Style<T> TransparencyLevelHint<T>(this Style<T> style, System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel> value) where T : Avalonia.Controls.TopLevel 
=> style._addSetter(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TransparencyLevelHint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TopLevel 
=> style._addSetter(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty, binding);


 // TransparencyBackgroundFallback

/*ValueStyleSetterGenerator*/
public static Style<T> TransparencyBackgroundFallback<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TopLevel 
=> style._addSetter(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TransparencyBackgroundFallback<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TopLevel 
=> style._addSetter(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty, binding);


 // RequestedThemeVariant

/*ValueStyleSetterGenerator*/
public static Style<T> RequestedThemeVariant<T>(this Style<T> style, Avalonia.Styling.ThemeVariant value) where T : Avalonia.Controls.TopLevel 
=> style._addSetter(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RequestedThemeVariant<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TopLevel 
=> style._addSetter(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty, binding);



}

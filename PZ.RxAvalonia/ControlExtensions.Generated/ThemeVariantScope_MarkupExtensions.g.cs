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
public static partial class ThemeVariantScope_MarkupExtensions
{
//================= Properties ======================//
 // RequestedThemeVariant

/*ValueSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, Avalonia.Styling.ThemeVariant value) where T : Avalonia.Controls.ThemeVariantScope 
{
    control.RequestedThemeVariant = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T RequestedThemeVariant<T>(this T control, Func<Avalonia.Styling.ThemeVariant> func) where T : Avalonia.Controls.ThemeVariantScope 
   => control._set(Avalonia.Controls.ThemeVariantScope.RequestedThemeVariantProperty!, func);

/*SetterFromObservableGenerator*/
public static T RequestedThemeVariant<T>(this T control, IObservable<Avalonia.Styling.ThemeVariant> obs) where T : Avalonia.Controls.ThemeVariantScope 
   => control._set(Avalonia.Controls.ThemeVariantScope.RequestedThemeVariantProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T RequestedThemeVariant<T>(this T control, ISubject<Avalonia.Styling.ThemeVariant> subject) where T : Avalonia.Controls.ThemeVariantScope 
   => control._set(Avalonia.Controls.ThemeVariantScope.RequestedThemeVariantProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T RequestedThemeVariant<T>(this T control, IObservable<Avalonia.Styling.ThemeVariant> obs, IObserver<Avalonia.Styling.ThemeVariant> changed) where T : Avalonia.Controls.ThemeVariantScope 
   => control._setEx(Avalonia.Controls.ThemeVariantScope.RequestedThemeVariantProperty!, obs, changed);



//================= Styles ======================//
 // RequestedThemeVariant

/*ValueStyleSetterGenerator*/
public static Style<T> RequestedThemeVariant<T>(this Style<T> style, Avalonia.Styling.ThemeVariant value) where T : Avalonia.Controls.ThemeVariantScope 
=> style._addSetter(Avalonia.Controls.ThemeVariantScope.RequestedThemeVariantProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RequestedThemeVariant<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ThemeVariantScope 
=> style._addSetter(Avalonia.Controls.ThemeVariantScope.RequestedThemeVariantProperty, binding);



}

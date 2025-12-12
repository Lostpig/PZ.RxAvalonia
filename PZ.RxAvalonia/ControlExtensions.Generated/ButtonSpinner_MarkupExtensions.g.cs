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
public static partial class ButtonSpinner_MarkupExtensions
{
//================= Properties ======================//
 // AllowSpin

/*ValueSetterGenerator*/
public static T AllowSpin<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ButtonSpinner 
{
    control.AllowSpin = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T AllowSpin<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.ButtonSpinner 
   => control._set(Avalonia.Controls.ButtonSpinner.AllowSpinProperty!, func);

/*SetterFromObservableGenerator*/
public static T AllowSpin<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.ButtonSpinner 
   => control._set(Avalonia.Controls.ButtonSpinner.AllowSpinProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T AllowSpin<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.ButtonSpinner 
   => control._set(Avalonia.Controls.ButtonSpinner.AllowSpinProperty!, subject);


 // ShowButtonSpinner

/*ValueSetterGenerator*/
public static T ShowButtonSpinner<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ButtonSpinner 
{
    control.ShowButtonSpinner = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ShowButtonSpinner<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.ButtonSpinner 
   => control._set(Avalonia.Controls.ButtonSpinner.ShowButtonSpinnerProperty!, func);

/*SetterFromObservableGenerator*/
public static T ShowButtonSpinner<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.ButtonSpinner 
   => control._set(Avalonia.Controls.ButtonSpinner.ShowButtonSpinnerProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ShowButtonSpinner<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.ButtonSpinner 
   => control._set(Avalonia.Controls.ButtonSpinner.ShowButtonSpinnerProperty!, subject);


 // ButtonSpinnerLocation

/*ValueSetterGenerator*/
public static T ButtonSpinnerLocation<T>(this T control, Avalonia.Controls.Location value) where T : Avalonia.Controls.ButtonSpinner 
{
    control.ButtonSpinnerLocation = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ButtonSpinnerLocation<T>(this T control, Func<Avalonia.Controls.Location> func) where T : Avalonia.Controls.ButtonSpinner 
   => control._set(Avalonia.Controls.ButtonSpinner.ButtonSpinnerLocationProperty!, func);

/*SetterFromObservableGenerator*/
public static T ButtonSpinnerLocation<T>(this T control, IObservable<Avalonia.Controls.Location> obs) where T : Avalonia.Controls.ButtonSpinner 
   => control._set(Avalonia.Controls.ButtonSpinner.ButtonSpinnerLocationProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ButtonSpinnerLocation<T>(this T control, ISubject<Avalonia.Controls.Location> subject) where T : Avalonia.Controls.ButtonSpinner 
   => control._set(Avalonia.Controls.ButtonSpinner.ButtonSpinnerLocationProperty!, subject);



//================= Styles ======================//
 // AllowSpin

/*ValueStyleSetterGenerator*/
public static Style<T> AllowSpin<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ButtonSpinner 
=> style._addSetter(Avalonia.Controls.ButtonSpinner.AllowSpinProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AllowSpin<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ButtonSpinner 
=> style._addSetter(Avalonia.Controls.ButtonSpinner.AllowSpinProperty, binding);


 // ShowButtonSpinner

/*ValueStyleSetterGenerator*/
public static Style<T> ShowButtonSpinner<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ButtonSpinner 
=> style._addSetter(Avalonia.Controls.ButtonSpinner.ShowButtonSpinnerProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowButtonSpinner<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ButtonSpinner 
=> style._addSetter(Avalonia.Controls.ButtonSpinner.ShowButtonSpinnerProperty, binding);


 // ButtonSpinnerLocation

/*ValueStyleSetterGenerator*/
public static Style<T> ButtonSpinnerLocation<T>(this Style<T> style, Avalonia.Controls.Location value) where T : Avalonia.Controls.ButtonSpinner 
=> style._addSetter(Avalonia.Controls.ButtonSpinner.ButtonSpinnerLocationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ButtonSpinnerLocation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ButtonSpinner 
=> style._addSetter(Avalonia.Controls.ButtonSpinner.ButtonSpinnerLocationProperty, binding);



}

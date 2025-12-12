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
public static partial class ProgressBar_MarkupExtensions
{
//================= Properties ======================//
 // IsIndeterminate

/*ValueSetterGenerator*/
public static T IsIndeterminate<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ProgressBar 
{
    control.IsIndeterminate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsIndeterminate<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.ProgressBar 
   => control._set(Avalonia.Controls.ProgressBar.IsIndeterminateProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsIndeterminate<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.ProgressBar 
   => control._set(Avalonia.Controls.ProgressBar.IsIndeterminateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsIndeterminate<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.ProgressBar 
   => control._set(Avalonia.Controls.ProgressBar.IsIndeterminateProperty!, subject);


 // ShowProgressText

/*ValueSetterGenerator*/
public static T ShowProgressText<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ProgressBar 
{
    control.ShowProgressText = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ShowProgressText<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.ProgressBar 
   => control._set(Avalonia.Controls.ProgressBar.ShowProgressTextProperty!, func);

/*SetterFromObservableGenerator*/
public static T ShowProgressText<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.ProgressBar 
   => control._set(Avalonia.Controls.ProgressBar.ShowProgressTextProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ShowProgressText<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.ProgressBar 
   => control._set(Avalonia.Controls.ProgressBar.ShowProgressTextProperty!, subject);


 // ProgressTextFormat

/*ValueSetterGenerator*/
public static T ProgressTextFormat<T>(this T control, System.String value) where T : Avalonia.Controls.ProgressBar 
{
    control.ProgressTextFormat = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ProgressTextFormat<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.ProgressBar 
   => control._set(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty!, func);

/*SetterFromObservableGenerator*/
public static T ProgressTextFormat<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.ProgressBar 
   => control._set(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ProgressTextFormat<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.ProgressBar 
   => control._set(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty!, subject);


 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.ProgressBar 
{
    control.Orientation = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func) where T : Avalonia.Controls.ProgressBar 
   => control._set(Avalonia.Controls.ProgressBar.OrientationProperty!, func);

/*SetterFromObservableGenerator*/
public static T Orientation<T>(this T control, IObservable<Avalonia.Layout.Orientation> obs) where T : Avalonia.Controls.ProgressBar 
   => control._set(Avalonia.Controls.ProgressBar.OrientationProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Orientation<T>(this T control, ISubject<Avalonia.Layout.Orientation> subject) where T : Avalonia.Controls.ProgressBar 
   => control._set(Avalonia.Controls.ProgressBar.OrientationProperty!, subject);



//================= Styles ======================//
 // IsIndeterminate

/*ValueStyleSetterGenerator*/
public static Style<T> IsIndeterminate<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ProgressBar 
=> style._addSetter(Avalonia.Controls.ProgressBar.IsIndeterminateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsIndeterminate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ProgressBar 
=> style._addSetter(Avalonia.Controls.ProgressBar.IsIndeterminateProperty, binding);


 // ShowProgressText

/*ValueStyleSetterGenerator*/
public static Style<T> ShowProgressText<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ProgressBar 
=> style._addSetter(Avalonia.Controls.ProgressBar.ShowProgressTextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowProgressText<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ProgressBar 
=> style._addSetter(Avalonia.Controls.ProgressBar.ShowProgressTextProperty, binding);


 // ProgressTextFormat

/*ValueStyleSetterGenerator*/
public static Style<T> ProgressTextFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.ProgressBar 
=> style._addSetter(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ProgressTextFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ProgressBar 
=> style._addSetter(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty, binding);


 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.ProgressBar 
=> style._addSetter(Avalonia.Controls.ProgressBar.OrientationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ProgressBar 
=> style._addSetter(Avalonia.Controls.ProgressBar.OrientationProperty, binding);



}

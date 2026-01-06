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
public static partial class LayoutTransformControl_MarkupExtensions
{
//================= Properties ======================//
 // LayoutTransform

/*ValueSetterGenerator*/
public static T LayoutTransform<T>(this T control, Avalonia.Media.ITransform? value) where T : Avalonia.Controls.LayoutTransformControl 
{
    control.LayoutTransform = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T LayoutTransform<T>(this T control, Func<Avalonia.Media.ITransform?> func) where T : Avalonia.Controls.LayoutTransformControl 
   => control._set(Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty!, func);

/*SetterFromObservableGenerator*/
public static T LayoutTransform<T>(this T control, IObservable<Avalonia.Media.ITransform?> obs) where T : Avalonia.Controls.LayoutTransformControl 
   => control._set(Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T LayoutTransform<T>(this T control, ISubject<Avalonia.Media.ITransform?> subject) where T : Avalonia.Controls.LayoutTransformControl 
   => control._set(Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T LayoutTransform<T>(this T control, IObservable<Avalonia.Media.ITransform?> obs, IObserver<Avalonia.Media.ITransform?> changed) where T : Avalonia.Controls.LayoutTransformControl 
   => control._setEx(Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty!, obs, changed);


 // UseRenderTransform

/*ValueSetterGenerator*/
public static T UseRenderTransform<T>(this T control, System.Boolean value) where T : Avalonia.Controls.LayoutTransformControl 
{
    control.UseRenderTransform = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T UseRenderTransform<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.LayoutTransformControl 
   => control._set(Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty!, func);

/*SetterFromObservableGenerator*/
public static T UseRenderTransform<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.LayoutTransformControl 
   => control._set(Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T UseRenderTransform<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.LayoutTransformControl 
   => control._set(Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T UseRenderTransform<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.LayoutTransformControl 
   => control._setEx(Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty!, obs, changed);



//================= Styles ======================//
 // LayoutTransform

/*ValueStyleSetterGenerator*/
public static Style<T> LayoutTransform<T>(this Style<T> style, Avalonia.Media.ITransform? value) where T : Avalonia.Controls.LayoutTransformControl 
=> style._addSetter(Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LayoutTransform<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.LayoutTransformControl 
=> style._addSetter(Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty, binding);


 // UseRenderTransform

/*ValueStyleSetterGenerator*/
public static Style<T> UseRenderTransform<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.LayoutTransformControl 
=> style._addSetter(Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UseRenderTransform<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.LayoutTransformControl 
=> style._addSetter(Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty, binding);



}

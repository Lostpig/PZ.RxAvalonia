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
public static partial class Decorator_MarkupExtensions
{
//================= Properties ======================//
 // Child

/*ValueSetterGenerator*/
public static T Child<T>(this T control, Avalonia.Controls.Control value) where T : Avalonia.Controls.Decorator 
{
    control.Child = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Child<T>(this T control, Func<Avalonia.Controls.Control> func) where T : Avalonia.Controls.Decorator 
   => control._set(Avalonia.Controls.Decorator.ChildProperty!, func);

/*SetterFromObservableGenerator*/
public static T Child<T>(this T control, IObservable<Avalonia.Controls.Control> obs) where T : Avalonia.Controls.Decorator 
   => control._set(Avalonia.Controls.Decorator.ChildProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Child<T>(this T control, ISubject<Avalonia.Controls.Control> subject) where T : Avalonia.Controls.Decorator 
   => control._set(Avalonia.Controls.Decorator.ChildProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Child<T>(this T control, IObservable<Avalonia.Controls.Control> obs, IObserver<Avalonia.Controls.Control> changed) where T : Avalonia.Controls.Decorator 
   => control._setEx(Avalonia.Controls.Decorator.ChildProperty!, obs, changed);


 // Padding

/*ValueSetterGenerator*/
public static T Padding<T>(this T control, Avalonia.Thickness value) where T : Avalonia.Controls.Decorator 
{
    control.Padding = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static T Padding<T>(this T control, System.Double uniformLength = default!) where T : Avalonia.Controls.Decorator 
{
    control.Padding = new Avalonia.Thickness(uniformLength);
    return control;
}
public static T Padding<T>(this T control, System.Double horizontal = default!, System.Double vertical = default!) where T : Avalonia.Controls.Decorator 
{
    control.Padding = new Avalonia.Thickness(horizontal, vertical);
    return control;
}
public static T Padding<T>(this T control, System.Double left = default!, System.Double top = default!, System.Double right = default!, System.Double bottom = default!) where T : Avalonia.Controls.Decorator 
{
    control.Padding = new Avalonia.Thickness(left, top, right, bottom);
    return control;
}

/*SetterFromFuncGenerator*/
public static T Padding<T>(this T control, Func<Avalonia.Thickness> func) where T : Avalonia.Controls.Decorator 
   => control._set(Avalonia.Controls.Decorator.PaddingProperty!, func);

/*SetterFromObservableGenerator*/
public static T Padding<T>(this T control, IObservable<Avalonia.Thickness> obs) where T : Avalonia.Controls.Decorator 
   => control._set(Avalonia.Controls.Decorator.PaddingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Padding<T>(this T control, ISubject<Avalonia.Thickness> subject) where T : Avalonia.Controls.Decorator 
   => control._set(Avalonia.Controls.Decorator.PaddingProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Padding<T>(this T control, IObservable<Avalonia.Thickness> obs, IObserver<Avalonia.Thickness> changed) where T : Avalonia.Controls.Decorator 
   => control._setEx(Avalonia.Controls.Decorator.PaddingProperty!, obs, changed);



//================= Styles ======================//
 // Child

/*ValueStyleSetterGenerator*/
public static Style<T> Child<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Avalonia.Controls.Decorator 
=> style._addSetter(Avalonia.Controls.Decorator.ChildProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Child<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Decorator 
=> style._addSetter(Avalonia.Controls.Decorator.ChildProperty, binding);


 // Padding

/*ValueStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.Decorator 
=> style._addSetter(Avalonia.Controls.Decorator.PaddingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Decorator 
=> style._addSetter(Avalonia.Controls.Decorator.PaddingProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, System.Double uniformLength) where T : Avalonia.Controls.Decorator 
   => style._addSetter(Avalonia.Controls.Decorator.PaddingProperty, new Avalonia.Thickness(uniformLength));public static Style<T> Padding<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Avalonia.Controls.Decorator 
   => style._addSetter(Avalonia.Controls.Decorator.PaddingProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> Padding<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Avalonia.Controls.Decorator 
   => style._addSetter(Avalonia.Controls.Decorator.PaddingProperty, new Avalonia.Thickness(left, top, right, bottom));



}

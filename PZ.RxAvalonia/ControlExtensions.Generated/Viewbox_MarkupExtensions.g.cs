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
public static partial class Viewbox_MarkupExtensions
{
//================= Properties ======================//
 // Stretch

/*ValueSetterGenerator*/
public static T Stretch<T>(this T control, Avalonia.Media.Stretch value) where T : Avalonia.Controls.Viewbox 
{
    control.Stretch = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Stretch<T>(this T control, Func<Avalonia.Media.Stretch> func) where T : Avalonia.Controls.Viewbox 
   => control._set(Avalonia.Controls.Viewbox.StretchProperty!, func);

/*SetterFromObservableGenerator*/
public static T Stretch<T>(this T control, IObservable<Avalonia.Media.Stretch> obs) where T : Avalonia.Controls.Viewbox 
   => control._set(Avalonia.Controls.Viewbox.StretchProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Stretch<T>(this T control, ISubject<Avalonia.Media.Stretch> subject) where T : Avalonia.Controls.Viewbox 
   => control._set(Avalonia.Controls.Viewbox.StretchProperty!, subject);


 // StretchDirection

/*ValueSetterGenerator*/
public static T StretchDirection<T>(this T control, Avalonia.Media.StretchDirection value) where T : Avalonia.Controls.Viewbox 
{
    control.StretchDirection = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T StretchDirection<T>(this T control, Func<Avalonia.Media.StretchDirection> func) where T : Avalonia.Controls.Viewbox 
   => control._set(Avalonia.Controls.Viewbox.StretchDirectionProperty!, func);

/*SetterFromObservableGenerator*/
public static T StretchDirection<T>(this T control, IObservable<Avalonia.Media.StretchDirection> obs) where T : Avalonia.Controls.Viewbox 
   => control._set(Avalonia.Controls.Viewbox.StretchDirectionProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T StretchDirection<T>(this T control, ISubject<Avalonia.Media.StretchDirection> subject) where T : Avalonia.Controls.Viewbox 
   => control._set(Avalonia.Controls.Viewbox.StretchDirectionProperty!, subject);


 // Child

/*ValueSetterGenerator*/
public static T Child<T>(this T control, Avalonia.Controls.Control value) where T : Avalonia.Controls.Viewbox 
{
    control.Child = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Child<T>(this T control, Func<Avalonia.Controls.Control> func) where T : Avalonia.Controls.Viewbox 
   => control._set(Avalonia.Controls.Viewbox.ChildProperty!, func);

/*SetterFromObservableGenerator*/
public static T Child<T>(this T control, IObservable<Avalonia.Controls.Control> obs) where T : Avalonia.Controls.Viewbox 
   => control._set(Avalonia.Controls.Viewbox.ChildProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Child<T>(this T control, ISubject<Avalonia.Controls.Control> subject) where T : Avalonia.Controls.Viewbox 
   => control._set(Avalonia.Controls.Viewbox.ChildProperty!, subject);



//================= Styles ======================//
 // Stretch

/*ValueStyleSetterGenerator*/
public static Style<T> Stretch<T>(this Style<T> style, Avalonia.Media.Stretch value) where T : Avalonia.Controls.Viewbox 
=> style._addSetter(Avalonia.Controls.Viewbox.StretchProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Stretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Viewbox 
=> style._addSetter(Avalonia.Controls.Viewbox.StretchProperty, binding);


 // StretchDirection

/*ValueStyleSetterGenerator*/
public static Style<T> StretchDirection<T>(this Style<T> style, Avalonia.Media.StretchDirection value) where T : Avalonia.Controls.Viewbox 
=> style._addSetter(Avalonia.Controls.Viewbox.StretchDirectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StretchDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Viewbox 
=> style._addSetter(Avalonia.Controls.Viewbox.StretchDirectionProperty, binding);


 // Child

/*ValueStyleSetterGenerator*/
public static Style<T> Child<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Avalonia.Controls.Viewbox 
=> style._addSetter(Avalonia.Controls.Viewbox.ChildProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Child<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Viewbox 
=> style._addSetter(Avalonia.Controls.Viewbox.ChildProperty, binding);



}

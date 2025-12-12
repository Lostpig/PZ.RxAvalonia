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
public static partial class Image_MarkupExtensions
{
//================= Properties ======================//
 // Source

/*ValueSetterGenerator*/
public static T Source<T>(this T control, Avalonia.Media.IImage value) where T : Avalonia.Controls.Image 
{
    control.Source = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Source<T>(this T control, Func<Avalonia.Media.IImage> func) where T : Avalonia.Controls.Image 
   => control._set(Avalonia.Controls.Image.SourceProperty!, func);

/*SetterFromObservableGenerator*/
public static T Source<T>(this T control, IObservable<Avalonia.Media.IImage> obs) where T : Avalonia.Controls.Image 
   => control._set(Avalonia.Controls.Image.SourceProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Source<T>(this T control, ISubject<Avalonia.Media.IImage> subject) where T : Avalonia.Controls.Image 
   => control._set(Avalonia.Controls.Image.SourceProperty!, subject);


 // BlendMode

/*ValueSetterGenerator*/
public static T BlendMode<T>(this T control, Avalonia.Media.Imaging.BitmapBlendingMode value) where T : Avalonia.Controls.Image 
{
    control.BlendMode = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T BlendMode<T>(this T control, Func<Avalonia.Media.Imaging.BitmapBlendingMode> func) where T : Avalonia.Controls.Image 
   => control._set(Avalonia.Controls.Image.BlendModeProperty!, func);

/*SetterFromObservableGenerator*/
public static T BlendMode<T>(this T control, IObservable<Avalonia.Media.Imaging.BitmapBlendingMode> obs) where T : Avalonia.Controls.Image 
   => control._set(Avalonia.Controls.Image.BlendModeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T BlendMode<T>(this T control, ISubject<Avalonia.Media.Imaging.BitmapBlendingMode> subject) where T : Avalonia.Controls.Image 
   => control._set(Avalonia.Controls.Image.BlendModeProperty!, subject);


 // Stretch

/*ValueSetterGenerator*/
public static T Stretch<T>(this T control, Avalonia.Media.Stretch value) where T : Avalonia.Controls.Image 
{
    control.Stretch = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Stretch<T>(this T control, Func<Avalonia.Media.Stretch> func) where T : Avalonia.Controls.Image 
   => control._set(Avalonia.Controls.Image.StretchProperty!, func);

/*SetterFromObservableGenerator*/
public static T Stretch<T>(this T control, IObservable<Avalonia.Media.Stretch> obs) where T : Avalonia.Controls.Image 
   => control._set(Avalonia.Controls.Image.StretchProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Stretch<T>(this T control, ISubject<Avalonia.Media.Stretch> subject) where T : Avalonia.Controls.Image 
   => control._set(Avalonia.Controls.Image.StretchProperty!, subject);


 // StretchDirection

/*ValueSetterGenerator*/
public static T StretchDirection<T>(this T control, Avalonia.Media.StretchDirection value) where T : Avalonia.Controls.Image 
{
    control.StretchDirection = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T StretchDirection<T>(this T control, Func<Avalonia.Media.StretchDirection> func) where T : Avalonia.Controls.Image 
   => control._set(Avalonia.Controls.Image.StretchDirectionProperty!, func);

/*SetterFromObservableGenerator*/
public static T StretchDirection<T>(this T control, IObservable<Avalonia.Media.StretchDirection> obs) where T : Avalonia.Controls.Image 
   => control._set(Avalonia.Controls.Image.StretchDirectionProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T StretchDirection<T>(this T control, ISubject<Avalonia.Media.StretchDirection> subject) where T : Avalonia.Controls.Image 
   => control._set(Avalonia.Controls.Image.StretchDirectionProperty!, subject);



//================= Styles ======================//
 // Source

/*ValueStyleSetterGenerator*/
public static Style<T> Source<T>(this Style<T> style, Avalonia.Media.IImage value) where T : Avalonia.Controls.Image 
=> style._addSetter(Avalonia.Controls.Image.SourceProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Source<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Image 
=> style._addSetter(Avalonia.Controls.Image.SourceProperty, binding);


 // BlendMode

/*ValueStyleSetterGenerator*/
public static Style<T> BlendMode<T>(this Style<T> style, Avalonia.Media.Imaging.BitmapBlendingMode value) where T : Avalonia.Controls.Image 
=> style._addSetter(Avalonia.Controls.Image.BlendModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BlendMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Image 
=> style._addSetter(Avalonia.Controls.Image.BlendModeProperty, binding);


 // Stretch

/*ValueStyleSetterGenerator*/
public static Style<T> Stretch<T>(this Style<T> style, Avalonia.Media.Stretch value) where T : Avalonia.Controls.Image 
=> style._addSetter(Avalonia.Controls.Image.StretchProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Stretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Image 
=> style._addSetter(Avalonia.Controls.Image.StretchProperty, binding);


 // StretchDirection

/*ValueStyleSetterGenerator*/
public static Style<T> StretchDirection<T>(this Style<T> style, Avalonia.Media.StretchDirection value) where T : Avalonia.Controls.Image 
=> style._addSetter(Avalonia.Controls.Image.StretchDirectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StretchDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Image 
=> style._addSetter(Avalonia.Controls.Image.StretchDirectionProperty, binding);



}

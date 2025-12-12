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
public static partial class Inline_MarkupExtensions
{
//================= Properties ======================//
 // TextDecorations

/*ValueSetterGenerator*/
public static T TextDecorations<T>(this T control, Avalonia.Media.TextDecorationCollection value) where T : Avalonia.Controls.Documents.Inline 
{
    control.TextDecorations = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TextDecorations<T>(this T control, Func<Avalonia.Media.TextDecorationCollection> func) where T : Avalonia.Controls.Documents.Inline 
   => control._set(Avalonia.Controls.Documents.Inline.TextDecorationsProperty!, func);

/*SetterFromObservableGenerator*/
public static T TextDecorations<T>(this T control, IObservable<Avalonia.Media.TextDecorationCollection> obs) where T : Avalonia.Controls.Documents.Inline 
   => control._set(Avalonia.Controls.Documents.Inline.TextDecorationsProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TextDecorations<T>(this T control, ISubject<Avalonia.Media.TextDecorationCollection> subject) where T : Avalonia.Controls.Documents.Inline 
   => control._set(Avalonia.Controls.Documents.Inline.TextDecorationsProperty!, subject);


 // BaselineAlignment

/*ValueSetterGenerator*/
public static T BaselineAlignment<T>(this T control, Avalonia.Media.BaselineAlignment value) where T : Avalonia.Controls.Documents.Inline 
{
    control.BaselineAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T BaselineAlignment<T>(this T control, Func<Avalonia.Media.BaselineAlignment> func) where T : Avalonia.Controls.Documents.Inline 
   => control._set(Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T BaselineAlignment<T>(this T control, IObservable<Avalonia.Media.BaselineAlignment> obs) where T : Avalonia.Controls.Documents.Inline 
   => control._set(Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T BaselineAlignment<T>(this T control, ISubject<Avalonia.Media.BaselineAlignment> subject) where T : Avalonia.Controls.Documents.Inline 
   => control._set(Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty!, subject);



//================= Styles ======================//
 // TextDecorations

/*ValueStyleSetterGenerator*/
public static Style<T> TextDecorations<T>(this Style<T> style, Avalonia.Media.TextDecorationCollection value) where T : Avalonia.Controls.Documents.Inline 
=> style._addSetter(Avalonia.Controls.Documents.Inline.TextDecorationsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextDecorations<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.Inline 
=> style._addSetter(Avalonia.Controls.Documents.Inline.TextDecorationsProperty, binding);


 // BaselineAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> BaselineAlignment<T>(this Style<T> style, Avalonia.Media.BaselineAlignment value) where T : Avalonia.Controls.Documents.Inline 
=> style._addSetter(Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BaselineAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.Inline 
=> style._addSetter(Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty, binding);



}

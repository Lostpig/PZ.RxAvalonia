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
public static partial class MaskedTextBox_MarkupExtensions
{
//================= Properties ======================//
 // AsciiOnly

/*ValueSetterGenerator*/
public static T AsciiOnly<T>(this T control, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox 
{
    control.AsciiOnly = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T AsciiOnly<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty!, func);

/*SetterFromObservableGenerator*/
public static T AsciiOnly<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T AsciiOnly<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty!, subject);


 // Culture

/*ValueSetterGenerator*/
public static T Culture<T>(this T control, System.Globalization.CultureInfo value) where T : Avalonia.Controls.MaskedTextBox 
{
    control.Culture = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Culture<T>(this T control, Func<System.Globalization.CultureInfo> func) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.CultureProperty!, func);

/*SetterFromObservableGenerator*/
public static T Culture<T>(this T control, IObservable<System.Globalization.CultureInfo> obs) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.CultureProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Culture<T>(this T control, ISubject<System.Globalization.CultureInfo> subject) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.CultureProperty!, subject);


 // HidePromptOnLeave

/*ValueSetterGenerator*/
public static T HidePromptOnLeave<T>(this T control, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox 
{
    control.HidePromptOnLeave = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T HidePromptOnLeave<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty!, func);

/*SetterFromObservableGenerator*/
public static T HidePromptOnLeave<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T HidePromptOnLeave<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty!, subject);


 // Mask

/*ValueSetterGenerator*/
public static T Mask<T>(this T control, System.String value) where T : Avalonia.Controls.MaskedTextBox 
{
    control.Mask = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Mask<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.MaskProperty!, func);

/*SetterFromObservableGenerator*/
public static T Mask<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.MaskProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Mask<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.MaskProperty!, subject);


 // PromptChar

/*ValueSetterGenerator*/
public static T PromptChar<T>(this T control, System.Char value) where T : Avalonia.Controls.MaskedTextBox 
{
    control.PromptChar = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PromptChar<T>(this T control, Func<System.Char> func) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.PromptCharProperty!, func);

/*SetterFromObservableGenerator*/
public static T PromptChar<T>(this T control, IObservable<System.Char> obs) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.PromptCharProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PromptChar<T>(this T control, ISubject<System.Char> subject) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.PromptCharProperty!, subject);


 // ResetOnPrompt

/*ValueSetterGenerator*/
public static T ResetOnPrompt<T>(this T control, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox 
{
    control.ResetOnPrompt = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ResetOnPrompt<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty!, func);

/*SetterFromObservableGenerator*/
public static T ResetOnPrompt<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ResetOnPrompt<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty!, subject);


 // ResetOnSpace

/*ValueSetterGenerator*/
public static T ResetOnSpace<T>(this T control, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox 
{
    control.ResetOnSpace = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ResetOnSpace<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty!, func);

/*SetterFromObservableGenerator*/
public static T ResetOnSpace<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ResetOnSpace<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty!, subject);



//================= Styles ======================//
 // AsciiOnly

/*ValueStyleSetterGenerator*/
public static Style<T> AsciiOnly<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AsciiOnly<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty, binding);


 // Culture

/*ValueStyleSetterGenerator*/
public static Style<T> Culture<T>(this Style<T> style, System.Globalization.CultureInfo value) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.CultureProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Culture<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.CultureProperty, binding);


 // HidePromptOnLeave

/*ValueStyleSetterGenerator*/
public static Style<T> HidePromptOnLeave<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HidePromptOnLeave<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty, binding);


 // Mask

/*ValueStyleSetterGenerator*/
public static Style<T> Mask<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.MaskProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Mask<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.MaskProperty, binding);


 // PromptChar

/*ValueStyleSetterGenerator*/
public static Style<T> PromptChar<T>(this Style<T> style, System.Char value) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.PromptCharProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PromptChar<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.PromptCharProperty, binding);


 // ResetOnPrompt

/*ValueStyleSetterGenerator*/
public static Style<T> ResetOnPrompt<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ResetOnPrompt<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty, binding);


 // ResetOnSpace

/*ValueStyleSetterGenerator*/
public static Style<T> ResetOnSpace<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ResetOnSpace<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty, binding);



}

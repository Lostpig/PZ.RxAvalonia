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
public static partial class ContentControl_MarkupExtensions
{
//================= Properties ======================//
 // Content

/*ValueSetterGenerator*/
public static T Content<T>(this T control, System.Object value) where T : Avalonia.Controls.ContentControl 
{
    control.Content = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Content<T>(this T control, Func<System.Object> func) where T : Avalonia.Controls.ContentControl 
   => control._set(Avalonia.Controls.ContentControl.ContentProperty!, func);

/*SetterFromObservableGenerator*/
public static T Content<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.Controls.ContentControl 
   => control._set(Avalonia.Controls.ContentControl.ContentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Content<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.Controls.ContentControl 
   => control._set(Avalonia.Controls.ContentControl.ContentProperty!, subject);


 // ContentTemplate

/*ValueSetterGenerator*/
public static T ContentTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ContentControl 
{
    control.ContentTemplate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ContentTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func) where T : Avalonia.Controls.ContentControl 
   => control._set(Avalonia.Controls.ContentControl.ContentTemplateProperty!, func);

/*SetterFromObservableGenerator*/
public static T ContentTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate> obs) where T : Avalonia.Controls.ContentControl 
   => control._set(Avalonia.Controls.ContentControl.ContentTemplateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ContentTemplate<T>(this T control, ISubject<Avalonia.Controls.Templates.IDataTemplate> subject) where T : Avalonia.Controls.ContentControl 
   => control._set(Avalonia.Controls.ContentControl.ContentTemplateProperty!, subject);


 // HorizontalContentAlignment

/*ValueSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.ContentControl 
{
    control.HorizontalContentAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func) where T : Avalonia.Controls.ContentControl 
   => control._set(Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T HorizontalContentAlignment<T>(this T control, IObservable<Avalonia.Layout.HorizontalAlignment> obs) where T : Avalonia.Controls.ContentControl 
   => control._set(Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T HorizontalContentAlignment<T>(this T control, ISubject<Avalonia.Layout.HorizontalAlignment> subject) where T : Avalonia.Controls.ContentControl 
   => control._set(Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty!, subject);


 // VerticalContentAlignment

/*ValueSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.ContentControl 
{
    control.VerticalContentAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func) where T : Avalonia.Controls.ContentControl 
   => control._set(Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T VerticalContentAlignment<T>(this T control, IObservable<Avalonia.Layout.VerticalAlignment> obs) where T : Avalonia.Controls.ContentControl 
   => control._set(Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T VerticalContentAlignment<T>(this T control, ISubject<Avalonia.Layout.VerticalAlignment> subject) where T : Avalonia.Controls.ContentControl 
   => control._set(Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty!, subject);



//================= Styles ======================//
 // Content

/*ValueStyleSetterGenerator*/
public static Style<T> Content<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.ContentControl 
=> style._addSetter(Avalonia.Controls.ContentControl.ContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Content<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContentControl 
=> style._addSetter(Avalonia.Controls.ContentControl.ContentProperty, binding);


 // ContentTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> ContentTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ContentControl 
=> style._addSetter(Avalonia.Controls.ContentControl.ContentTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ContentTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContentControl 
=> style._addSetter(Avalonia.Controls.ContentControl.ContentTemplateProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.ContentControl 
=> style._addSetter(Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContentControl 
=> style._addSetter(Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.ContentControl 
=> style._addSetter(Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContentControl 
=> style._addSetter(Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty, binding);



}

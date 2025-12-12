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
public static partial class TabControl_MarkupExtensions
{
//================= Properties ======================//
 // TabStripPlacement

/*ValueSetterGenerator*/
public static T TabStripPlacement<T>(this T control, Avalonia.Controls.Dock value) where T : Avalonia.Controls.TabControl 
{
    control.TabStripPlacement = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TabStripPlacement<T>(this T control, Func<Avalonia.Controls.Dock> func) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.TabStripPlacementProperty!, func);

/*SetterFromObservableGenerator*/
public static T TabStripPlacement<T>(this T control, IObservable<Avalonia.Controls.Dock> obs) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.TabStripPlacementProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TabStripPlacement<T>(this T control, ISubject<Avalonia.Controls.Dock> subject) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.TabStripPlacementProperty!, subject);


 // HorizontalContentAlignment

/*ValueSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.TabControl 
{
    control.HorizontalContentAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T HorizontalContentAlignment<T>(this T control, IObservable<Avalonia.Layout.HorizontalAlignment> obs) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T HorizontalContentAlignment<T>(this T control, ISubject<Avalonia.Layout.HorizontalAlignment> subject) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty!, subject);


 // VerticalContentAlignment

/*ValueSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.TabControl 
{
    control.VerticalContentAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.VerticalContentAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T VerticalContentAlignment<T>(this T control, IObservable<Avalonia.Layout.VerticalAlignment> obs) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.VerticalContentAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T VerticalContentAlignment<T>(this T control, ISubject<Avalonia.Layout.VerticalAlignment> subject) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.VerticalContentAlignmentProperty!, subject);


 // ContentTemplate

/*ValueSetterGenerator*/
public static T ContentTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.TabControl 
{
    control.ContentTemplate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ContentTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.ContentTemplateProperty!, func);

/*SetterFromObservableGenerator*/
public static T ContentTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate> obs) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.ContentTemplateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ContentTemplate<T>(this T control, ISubject<Avalonia.Controls.Templates.IDataTemplate> subject) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.ContentTemplateProperty!, subject);



//================= Styles ======================//
 // TabStripPlacement

/*ValueStyleSetterGenerator*/
public static Style<T> TabStripPlacement<T>(this Style<T> style, Avalonia.Controls.Dock value) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.TabStripPlacementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TabStripPlacement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.TabStripPlacementProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.VerticalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.VerticalContentAlignmentProperty, binding);


 // ContentTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> ContentTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.ContentTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ContentTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.ContentTemplateProperty, binding);



}

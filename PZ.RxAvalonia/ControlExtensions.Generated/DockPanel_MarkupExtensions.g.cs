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
public static partial class DockPanel_MarkupExtensions
{
//================= Properties ======================//
 // LastChildFill

/*ValueSetterGenerator*/
public static T LastChildFill<T>(this T control, System.Boolean value) where T : Avalonia.Controls.DockPanel 
{
    control.LastChildFill = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T LastChildFill<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.DockPanel 
   => control._set(Avalonia.Controls.DockPanel.LastChildFillProperty!, func);

/*SetterFromObservableGenerator*/
public static T LastChildFill<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.DockPanel 
   => control._set(Avalonia.Controls.DockPanel.LastChildFillProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T LastChildFill<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.DockPanel 
   => control._set(Avalonia.Controls.DockPanel.LastChildFillProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T LastChildFill<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.DockPanel 
   => control._setEx(Avalonia.Controls.DockPanel.LastChildFillProperty!, obs, changed);


 // HorizontalSpacing

/*ValueSetterGenerator*/
public static T HorizontalSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.DockPanel 
{
    control.HorizontalSpacing = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T HorizontalSpacing<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.DockPanel 
   => control._set(Avalonia.Controls.DockPanel.HorizontalSpacingProperty!, func);

/*SetterFromObservableGenerator*/
public static T HorizontalSpacing<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.DockPanel 
   => control._set(Avalonia.Controls.DockPanel.HorizontalSpacingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T HorizontalSpacing<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.DockPanel 
   => control._set(Avalonia.Controls.DockPanel.HorizontalSpacingProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T HorizontalSpacing<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.DockPanel 
   => control._setEx(Avalonia.Controls.DockPanel.HorizontalSpacingProperty!, obs, changed);


 // VerticalSpacing

/*ValueSetterGenerator*/
public static T VerticalSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.DockPanel 
{
    control.VerticalSpacing = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T VerticalSpacing<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.DockPanel 
   => control._set(Avalonia.Controls.DockPanel.VerticalSpacingProperty!, func);

/*SetterFromObservableGenerator*/
public static T VerticalSpacing<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.DockPanel 
   => control._set(Avalonia.Controls.DockPanel.VerticalSpacingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T VerticalSpacing<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.DockPanel 
   => control._set(Avalonia.Controls.DockPanel.VerticalSpacingProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T VerticalSpacing<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.DockPanel 
   => control._setEx(Avalonia.Controls.DockPanel.VerticalSpacingProperty!, obs, changed);



//================= Attached Properties ======================//
 // Dock

/*AttachedPropertyFuncGenerator*/
public static T DockPanel_Dock<T>(this T control, Func<Avalonia.Controls.Dock> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.DockPanel.DockProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T DockPanel_Dock<T>(this T control, IObservable<Avalonia.Controls.Dock> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.DockPanel.DockProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T DockPanel_Dock<T>(this T control, ISubject<Avalonia.Controls.Dock> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.DockPanel.DockProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T DockPanel_Dock<T>(this T control, Avalonia.Controls.Dock value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.DockPanel.DockProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T DockPanel_Dock<T>(this T control, IObservable<Avalonia.Controls.Dock> obs, IObserver<Avalonia.Controls.Dock> changed) where T : Avalonia.Controls.Control 
   => control._setEx(Avalonia.Controls.DockPanel.DockProperty!, obs, changed);



//================= Styles ======================//
 // LastChildFill

/*ValueStyleSetterGenerator*/
public static Style<T> LastChildFill<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DockPanel 
=> style._addSetter(Avalonia.Controls.DockPanel.LastChildFillProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LastChildFill<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DockPanel 
=> style._addSetter(Avalonia.Controls.DockPanel.LastChildFillProperty, binding);


 // HorizontalSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.DockPanel 
=> style._addSetter(Avalonia.Controls.DockPanel.HorizontalSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DockPanel 
=> style._addSetter(Avalonia.Controls.DockPanel.HorizontalSpacingProperty, binding);


 // VerticalSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.DockPanel 
=> style._addSetter(Avalonia.Controls.DockPanel.VerticalSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DockPanel 
=> style._addSetter(Avalonia.Controls.DockPanel.VerticalSpacingProperty, binding);



}

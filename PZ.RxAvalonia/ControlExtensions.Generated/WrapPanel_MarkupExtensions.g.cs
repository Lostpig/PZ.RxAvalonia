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
public static partial class WrapPanel_MarkupExtensions
{
//================= Properties ======================//
 // ItemSpacing

/*ValueSetterGenerator*/
public static T ItemSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.WrapPanel 
{
    control.ItemSpacing = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ItemSpacing<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemSpacingProperty!, func);

/*SetterFromObservableGenerator*/
public static T ItemSpacing<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemSpacingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ItemSpacing<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemSpacingProperty!, subject);


 // LineSpacing

/*ValueSetterGenerator*/
public static T LineSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.WrapPanel 
{
    control.LineSpacing = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T LineSpacing<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.LineSpacingProperty!, func);

/*SetterFromObservableGenerator*/
public static T LineSpacing<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.LineSpacingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T LineSpacing<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.LineSpacingProperty!, subject);


 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.WrapPanel 
{
    control.Orientation = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.OrientationProperty!, func);

/*SetterFromObservableGenerator*/
public static T Orientation<T>(this T control, IObservable<Avalonia.Layout.Orientation> obs) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.OrientationProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Orientation<T>(this T control, ISubject<Avalonia.Layout.Orientation> subject) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.OrientationProperty!, subject);


 // ItemsAlignment

/*ValueSetterGenerator*/
public static T ItemsAlignment<T>(this T control, Avalonia.Controls.WrapPanelItemsAlignment value) where T : Avalonia.Controls.WrapPanel 
{
    control.ItemsAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ItemsAlignment<T>(this T control, Func<Avalonia.Controls.WrapPanelItemsAlignment> func) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemsAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T ItemsAlignment<T>(this T control, IObservable<Avalonia.Controls.WrapPanelItemsAlignment> obs) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemsAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ItemsAlignment<T>(this T control, ISubject<Avalonia.Controls.WrapPanelItemsAlignment> subject) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemsAlignmentProperty!, subject);


 // ItemWidth

/*ValueSetterGenerator*/
public static T ItemWidth<T>(this T control, System.Double value) where T : Avalonia.Controls.WrapPanel 
{
    control.ItemWidth = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ItemWidth<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemWidthProperty!, func);

/*SetterFromObservableGenerator*/
public static T ItemWidth<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemWidthProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ItemWidth<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemWidthProperty!, subject);


 // ItemHeight

/*ValueSetterGenerator*/
public static T ItemHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.WrapPanel 
{
    control.ItemHeight = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ItemHeight<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemHeightProperty!, func);

/*SetterFromObservableGenerator*/
public static T ItemHeight<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemHeightProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ItemHeight<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemHeightProperty!, subject);



//================= Styles ======================//
 // ItemSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> ItemSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemSpacingProperty, binding);


 // LineSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> LineSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.LineSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LineSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.LineSpacingProperty, binding);


 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.OrientationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.OrientationProperty, binding);


 // ItemsAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> ItemsAlignment<T>(this Style<T> style, Avalonia.Controls.WrapPanelItemsAlignment value) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemsAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemsAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemsAlignmentProperty, binding);


 // ItemWidth

/*ValueStyleSetterGenerator*/
public static Style<T> ItemWidth<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemWidthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemWidth<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemWidthProperty, binding);


 // ItemHeight

/*ValueStyleSetterGenerator*/
public static Style<T> ItemHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemHeightProperty, binding);



}

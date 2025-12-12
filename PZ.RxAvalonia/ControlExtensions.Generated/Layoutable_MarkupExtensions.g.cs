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
public static partial class Layoutable_MarkupExtensions
{
//================= Properties ======================//
 // Width

/*ValueSetterGenerator*/
public static T Width<T>(this T control, System.Double value) where T : Avalonia.Layout.Layoutable 
{
    control.Width = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Width<T>(this T control, Func<System.Double> func) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.WidthProperty!, func);

/*SetterFromObservableGenerator*/
public static T Width<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.WidthProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Width<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.WidthProperty!, subject);


 // Height

/*ValueSetterGenerator*/
public static T Height<T>(this T control, System.Double value) where T : Avalonia.Layout.Layoutable 
{
    control.Height = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Height<T>(this T control, Func<System.Double> func) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.HeightProperty!, func);

/*SetterFromObservableGenerator*/
public static T Height<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.HeightProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Height<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.HeightProperty!, subject);


 // MinWidth

/*ValueSetterGenerator*/
public static T MinWidth<T>(this T control, System.Double value) where T : Avalonia.Layout.Layoutable 
{
    control.MinWidth = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MinWidth<T>(this T control, Func<System.Double> func) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MinWidthProperty!, func);

/*SetterFromObservableGenerator*/
public static T MinWidth<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MinWidthProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MinWidth<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MinWidthProperty!, subject);


 // MaxWidth

/*ValueSetterGenerator*/
public static T MaxWidth<T>(this T control, System.Double value) where T : Avalonia.Layout.Layoutable 
{
    control.MaxWidth = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MaxWidth<T>(this T control, Func<System.Double> func) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MaxWidthProperty!, func);

/*SetterFromObservableGenerator*/
public static T MaxWidth<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MaxWidthProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MaxWidth<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MaxWidthProperty!, subject);


 // MinHeight

/*ValueSetterGenerator*/
public static T MinHeight<T>(this T control, System.Double value) where T : Avalonia.Layout.Layoutable 
{
    control.MinHeight = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MinHeight<T>(this T control, Func<System.Double> func) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MinHeightProperty!, func);

/*SetterFromObservableGenerator*/
public static T MinHeight<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MinHeightProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MinHeight<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MinHeightProperty!, subject);


 // MaxHeight

/*ValueSetterGenerator*/
public static T MaxHeight<T>(this T control, System.Double value) where T : Avalonia.Layout.Layoutable 
{
    control.MaxHeight = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MaxHeight<T>(this T control, Func<System.Double> func) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MaxHeightProperty!, func);

/*SetterFromObservableGenerator*/
public static T MaxHeight<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MaxHeightProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MaxHeight<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MaxHeightProperty!, subject);


 // Margin

/*ValueSetterGenerator*/
public static T Margin<T>(this T control, Avalonia.Thickness value) where T : Avalonia.Layout.Layoutable 
{
    control.Margin = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static T Margin<T>(this T control, System.Double uniformLength = default!) where T : Avalonia.Layout.Layoutable 
{
    control.Margin = new Avalonia.Thickness(uniformLength);
    return control;
}
public static T Margin<T>(this T control, System.Double horizontal = default!, System.Double vertical = default!) where T : Avalonia.Layout.Layoutable 
{
    control.Margin = new Avalonia.Thickness(horizontal, vertical);
    return control;
}
public static T Margin<T>(this T control, System.Double left = default!, System.Double top = default!, System.Double right = default!, System.Double bottom = default!) where T : Avalonia.Layout.Layoutable 
{
    control.Margin = new Avalonia.Thickness(left, top, right, bottom);
    return control;
}

/*SetterFromFuncGenerator*/
public static T Margin<T>(this T control, Func<Avalonia.Thickness> func) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MarginProperty!, func);

/*SetterFromObservableGenerator*/
public static T Margin<T>(this T control, IObservable<Avalonia.Thickness> obs) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MarginProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Margin<T>(this T control, ISubject<Avalonia.Thickness> subject) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.MarginProperty!, subject);


 // HorizontalAlignment

/*ValueSetterGenerator*/
public static T HorizontalAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Layout.Layoutable 
{
    control.HorizontalAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T HorizontalAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.HorizontalAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T HorizontalAlignment<T>(this T control, IObservable<Avalonia.Layout.HorizontalAlignment> obs) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.HorizontalAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T HorizontalAlignment<T>(this T control, ISubject<Avalonia.Layout.HorizontalAlignment> subject) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.HorizontalAlignmentProperty!, subject);


 // VerticalAlignment

/*ValueSetterGenerator*/
public static T VerticalAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Layout.Layoutable 
{
    control.VerticalAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T VerticalAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.VerticalAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T VerticalAlignment<T>(this T control, IObservable<Avalonia.Layout.VerticalAlignment> obs) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.VerticalAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T VerticalAlignment<T>(this T control, ISubject<Avalonia.Layout.VerticalAlignment> subject) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.VerticalAlignmentProperty!, subject);


 // UseLayoutRounding

/*ValueSetterGenerator*/
public static T UseLayoutRounding<T>(this T control, System.Boolean value) where T : Avalonia.Layout.Layoutable 
{
    control.UseLayoutRounding = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T UseLayoutRounding<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.UseLayoutRoundingProperty!, func);

/*SetterFromObservableGenerator*/
public static T UseLayoutRounding<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.UseLayoutRoundingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T UseLayoutRounding<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Layout.Layoutable 
   => control._set(Avalonia.Layout.Layoutable.UseLayoutRoundingProperty!, subject);



//================= Events ======================//
 // EffectiveViewportChanged

/*ActionToEventGenerator*/
public static T OnEffectiveViewportChanged<T>(this T control, Action<Avalonia.Layout.EffectiveViewportChangedEventArgs> action) where T : Avalonia.Layout.Layoutable  => 
 control._setEvent((System.EventHandler<Avalonia.Layout.EffectiveViewportChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.EffectiveViewportChanged += h);


 // LayoutUpdated

/*ActionToEventGenerator*/
public static T OnLayoutUpdated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Layout.Layoutable  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.LayoutUpdated += h);



//================= Styles ======================//
 // Width

/*ValueStyleSetterGenerator*/
public static Style<T> Width<T>(this Style<T> style, System.Double value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.WidthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Width<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.WidthProperty, binding);


 // Height

/*ValueStyleSetterGenerator*/
public static Style<T> Height<T>(this Style<T> style, System.Double value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.HeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Height<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.HeightProperty, binding);


 // MinWidth

/*ValueStyleSetterGenerator*/
public static Style<T> MinWidth<T>(this Style<T> style, System.Double value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MinWidthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinWidth<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MinWidthProperty, binding);


 // MaxWidth

/*ValueStyleSetterGenerator*/
public static Style<T> MaxWidth<T>(this Style<T> style, System.Double value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MaxWidthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxWidth<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MaxWidthProperty, binding);


 // MinHeight

/*ValueStyleSetterGenerator*/
public static Style<T> MinHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MinHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MinHeightProperty, binding);


 // MaxHeight

/*ValueStyleSetterGenerator*/
public static Style<T> MaxHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MaxHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MaxHeightProperty, binding);


 // Margin

/*ValueStyleSetterGenerator*/
public static Style<T> Margin<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MarginProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Margin<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MarginProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> Margin<T>(this Style<T> style, System.Double uniformLength) where T : Avalonia.Layout.Layoutable 
   => style._addSetter(Avalonia.Layout.Layoutable.MarginProperty, new Avalonia.Thickness(uniformLength));public static Style<T> Margin<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Avalonia.Layout.Layoutable 
   => style._addSetter(Avalonia.Layout.Layoutable.MarginProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> Margin<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Avalonia.Layout.Layoutable 
   => style._addSetter(Avalonia.Layout.Layoutable.MarginProperty, new Avalonia.Thickness(left, top, right, bottom));


 // HorizontalAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.HorizontalAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.HorizontalAlignmentProperty, binding);


 // VerticalAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.VerticalAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.VerticalAlignmentProperty, binding);


 // UseLayoutRounding

/*ValueStyleSetterGenerator*/
public static Style<T> UseLayoutRounding<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.UseLayoutRoundingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UseLayoutRounding<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.UseLayoutRoundingProperty, binding);



}

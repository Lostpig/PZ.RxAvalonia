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
public static partial class Slider_MarkupExtensions
{
//================= Properties ======================//
 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.Slider 
{
    control.Orientation = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.OrientationProperty!, func);

/*SetterFromObservableGenerator*/
public static T Orientation<T>(this T control, IObservable<Avalonia.Layout.Orientation> obs) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.OrientationProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Orientation<T>(this T control, ISubject<Avalonia.Layout.Orientation> subject) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.OrientationProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Orientation<T>(this T control, IObservable<Avalonia.Layout.Orientation> obs, IObserver<Avalonia.Layout.Orientation> changed) where T : Avalonia.Controls.Slider 
   => control._setEx(Avalonia.Controls.Slider.OrientationProperty!, obs, changed);


 // IsDirectionReversed

/*ValueSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Slider 
{
    control.IsDirectionReversed = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsDirectionReversed<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.IsDirectionReversedProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsDirectionReversed<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.IsDirectionReversedProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsDirectionReversed<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.IsDirectionReversedProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsDirectionReversed<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Slider 
   => control._setEx(Avalonia.Controls.Slider.IsDirectionReversedProperty!, obs, changed);


 // IsSnapToTickEnabled

/*ValueSetterGenerator*/
public static T IsSnapToTickEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Slider 
{
    control.IsSnapToTickEnabled = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsSnapToTickEnabled<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsSnapToTickEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsSnapToTickEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsSnapToTickEnabled<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Slider 
   => control._setEx(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty!, obs, changed);


 // TickFrequency

/*ValueSetterGenerator*/
public static T TickFrequency<T>(this T control, System.Double value) where T : Avalonia.Controls.Slider 
{
    control.TickFrequency = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TickFrequency<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TickFrequencyProperty!, func);

/*SetterFromObservableGenerator*/
public static T TickFrequency<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TickFrequencyProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TickFrequency<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TickFrequencyProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T TickFrequency<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.Slider 
   => control._setEx(Avalonia.Controls.Slider.TickFrequencyProperty!, obs, changed);


 // TickPlacement

/*ValueSetterGenerator*/
public static T TickPlacement<T>(this T control, Avalonia.Controls.TickPlacement value) where T : Avalonia.Controls.Slider 
{
    control.TickPlacement = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TickPlacement<T>(this T control, Func<Avalonia.Controls.TickPlacement> func) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TickPlacementProperty!, func);

/*SetterFromObservableGenerator*/
public static T TickPlacement<T>(this T control, IObservable<Avalonia.Controls.TickPlacement> obs) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TickPlacementProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TickPlacement<T>(this T control, ISubject<Avalonia.Controls.TickPlacement> subject) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TickPlacementProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T TickPlacement<T>(this T control, IObservable<Avalonia.Controls.TickPlacement> obs, IObserver<Avalonia.Controls.TickPlacement> changed) where T : Avalonia.Controls.Slider 
   => control._setEx(Avalonia.Controls.Slider.TickPlacementProperty!, obs, changed);


 // Ticks

/*ValueSetterGenerator*/
public static T Ticks<T>(this T control, Avalonia.Collections.AvaloniaList<System.Double> value) where T : Avalonia.Controls.Slider 
{
    control.Ticks = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Ticks<T>(this T control, Func<Avalonia.Collections.AvaloniaList<System.Double>> func) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TicksProperty!, func);

/*SetterFromObservableGenerator*/
public static T Ticks<T>(this T control, IObservable<Avalonia.Collections.AvaloniaList<System.Double>> obs) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TicksProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Ticks<T>(this T control, ISubject<Avalonia.Collections.AvaloniaList<System.Double>> subject) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TicksProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Ticks<T>(this T control, IObservable<Avalonia.Collections.AvaloniaList<System.Double>> obs, IObserver<Avalonia.Collections.AvaloniaList<System.Double>> changed) where T : Avalonia.Controls.Slider 
   => control._setEx(Avalonia.Controls.Slider.TicksProperty!, obs, changed);



//================= Styles ======================//
 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.OrientationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.OrientationProperty, binding);


 // IsDirectionReversed

/*ValueStyleSetterGenerator*/
public static Style<T> IsDirectionReversed<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.IsDirectionReversedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDirectionReversed<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.IsDirectionReversedProperty, binding);


 // IsSnapToTickEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsSnapToTickEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsSnapToTickEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty, binding);


 // TickFrequency

/*ValueStyleSetterGenerator*/
public static Style<T> TickFrequency<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.TickFrequencyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TickFrequency<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.TickFrequencyProperty, binding);


 // TickPlacement

/*ValueStyleSetterGenerator*/
public static Style<T> TickPlacement<T>(this Style<T> style, Avalonia.Controls.TickPlacement value) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.TickPlacementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TickPlacement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.TickPlacementProperty, binding);


 // Ticks

/*ValueStyleSetterGenerator*/
public static Style<T> Ticks<T>(this Style<T> style, Avalonia.Collections.AvaloniaList<System.Double> value) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.TicksProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Ticks<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.TicksProperty, binding);



}

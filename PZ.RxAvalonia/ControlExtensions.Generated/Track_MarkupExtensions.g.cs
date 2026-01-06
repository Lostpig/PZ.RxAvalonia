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
public static partial class Track_MarkupExtensions
{
//================= Properties ======================//
 // Minimum

/*ValueSetterGenerator*/
public static T Minimum<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.Track 
{
    control.Minimum = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Minimum<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.MinimumProperty!, func);

/*SetterFromObservableGenerator*/
public static T Minimum<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.MinimumProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Minimum<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.MinimumProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Minimum<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.Primitives.Track 
   => control._setEx(Avalonia.Controls.Primitives.Track.MinimumProperty!, obs, changed);


 // Maximum

/*ValueSetterGenerator*/
public static T Maximum<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.Track 
{
    control.Maximum = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Maximum<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.MaximumProperty!, func);

/*SetterFromObservableGenerator*/
public static T Maximum<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.MaximumProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Maximum<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.MaximumProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Maximum<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.Primitives.Track 
   => control._setEx(Avalonia.Controls.Primitives.Track.MaximumProperty!, obs, changed);


 // Value

/*ValueSetterGenerator*/
public static T Value<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.Track 
{
    control.Value = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Value<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ValueProperty!, func);

/*SetterFromObservableGenerator*/
public static T Value<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ValueProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Value<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ValueProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Value<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.Primitives.Track 
   => control._setEx(Avalonia.Controls.Primitives.Track.ValueProperty!, obs, changed);


 // ViewportSize

/*ValueSetterGenerator*/
public static T ViewportSize<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.Track 
{
    control.ViewportSize = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ViewportSize<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ViewportSizeProperty!, func);

/*SetterFromObservableGenerator*/
public static T ViewportSize<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ViewportSizeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ViewportSize<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ViewportSizeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ViewportSize<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.Primitives.Track 
   => control._setEx(Avalonia.Controls.Primitives.Track.ViewportSizeProperty!, obs, changed);


 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.Primitives.Track 
{
    control.Orientation = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.OrientationProperty!, func);

/*SetterFromObservableGenerator*/
public static T Orientation<T>(this T control, IObservable<Avalonia.Layout.Orientation> obs) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.OrientationProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Orientation<T>(this T control, ISubject<Avalonia.Layout.Orientation> subject) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.OrientationProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Orientation<T>(this T control, IObservable<Avalonia.Layout.Orientation> obs, IObserver<Avalonia.Layout.Orientation> changed) where T : Avalonia.Controls.Primitives.Track 
   => control._setEx(Avalonia.Controls.Primitives.Track.OrientationProperty!, obs, changed);


 // Thumb

/*ValueSetterGenerator*/
public static T Thumb<T>(this T control, Avalonia.Controls.Primitives.Thumb? value) where T : Avalonia.Controls.Primitives.Track 
{
    control.Thumb = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Thumb<T>(this T control, Func<Avalonia.Controls.Primitives.Thumb?> func) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ThumbProperty!, func);

/*SetterFromObservableGenerator*/
public static T Thumb<T>(this T control, IObservable<Avalonia.Controls.Primitives.Thumb?> obs) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ThumbProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Thumb<T>(this T control, ISubject<Avalonia.Controls.Primitives.Thumb?> subject) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ThumbProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Thumb<T>(this T control, IObservable<Avalonia.Controls.Primitives.Thumb?> obs, IObserver<Avalonia.Controls.Primitives.Thumb?> changed) where T : Avalonia.Controls.Primitives.Track 
   => control._setEx(Avalonia.Controls.Primitives.Track.ThumbProperty!, obs, changed);


 // IncreaseButton

/*ValueSetterGenerator*/
public static T IncreaseButton<T>(this T control, Avalonia.Controls.Button? value) where T : Avalonia.Controls.Primitives.Track 
{
    control.IncreaseButton = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IncreaseButton<T>(this T control, Func<Avalonia.Controls.Button?> func) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IncreaseButtonProperty!, func);

/*SetterFromObservableGenerator*/
public static T IncreaseButton<T>(this T control, IObservable<Avalonia.Controls.Button?> obs) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IncreaseButtonProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IncreaseButton<T>(this T control, ISubject<Avalonia.Controls.Button?> subject) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IncreaseButtonProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IncreaseButton<T>(this T control, IObservable<Avalonia.Controls.Button?> obs, IObserver<Avalonia.Controls.Button?> changed) where T : Avalonia.Controls.Primitives.Track 
   => control._setEx(Avalonia.Controls.Primitives.Track.IncreaseButtonProperty!, obs, changed);


 // DecreaseButton

/*ValueSetterGenerator*/
public static T DecreaseButton<T>(this T control, Avalonia.Controls.Button? value) where T : Avalonia.Controls.Primitives.Track 
{
    control.DecreaseButton = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DecreaseButton<T>(this T control, Func<Avalonia.Controls.Button?> func) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.DecreaseButtonProperty!, func);

/*SetterFromObservableGenerator*/
public static T DecreaseButton<T>(this T control, IObservable<Avalonia.Controls.Button?> obs) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.DecreaseButtonProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DecreaseButton<T>(this T control, ISubject<Avalonia.Controls.Button?> subject) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.DecreaseButtonProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DecreaseButton<T>(this T control, IObservable<Avalonia.Controls.Button?> obs, IObserver<Avalonia.Controls.Button?> changed) where T : Avalonia.Controls.Primitives.Track 
   => control._setEx(Avalonia.Controls.Primitives.Track.DecreaseButtonProperty!, obs, changed);


 // IsDirectionReversed

/*ValueSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Track 
{
    control.IsDirectionReversed = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsDirectionReversed<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsDirectionReversed<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsDirectionReversed<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsDirectionReversed<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Primitives.Track 
   => control._setEx(Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty!, obs, changed);


 // IgnoreThumbDrag

/*ValueSetterGenerator*/
public static T IgnoreThumbDrag<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Track 
{
    control.IgnoreThumbDrag = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IgnoreThumbDrag<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty!, func);

/*SetterFromObservableGenerator*/
public static T IgnoreThumbDrag<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IgnoreThumbDrag<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IgnoreThumbDrag<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Primitives.Track 
   => control._setEx(Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty!, obs, changed);


 // DeferThumbDrag

/*ValueSetterGenerator*/
public static T DeferThumbDrag<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Track 
{
    control.DeferThumbDrag = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DeferThumbDrag<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.DeferThumbDragProperty!, func);

/*SetterFromObservableGenerator*/
public static T DeferThumbDrag<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.DeferThumbDragProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DeferThumbDrag<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.DeferThumbDragProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DeferThumbDrag<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Primitives.Track 
   => control._setEx(Avalonia.Controls.Primitives.Track.DeferThumbDragProperty!, obs, changed);



//================= Styles ======================//
 // Minimum

/*ValueStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.MinimumProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.MinimumProperty, binding);


 // Maximum

/*ValueStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.MaximumProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.MaximumProperty, binding);


 // Value

/*ValueStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.ValueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.ValueProperty, binding);


 // ViewportSize

/*ValueStyleSetterGenerator*/
public static Style<T> ViewportSize<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.ViewportSizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ViewportSize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.ViewportSizeProperty, binding);


 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.OrientationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.OrientationProperty, binding);


 // Thumb

/*ValueStyleSetterGenerator*/
public static Style<T> Thumb<T>(this Style<T> style, Avalonia.Controls.Primitives.Thumb? value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.ThumbProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Thumb<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.ThumbProperty, binding);


 // IncreaseButton

/*ValueStyleSetterGenerator*/
public static Style<T> IncreaseButton<T>(this Style<T> style, Avalonia.Controls.Button? value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.IncreaseButtonProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IncreaseButton<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.IncreaseButtonProperty, binding);


 // DecreaseButton

/*ValueStyleSetterGenerator*/
public static Style<T> DecreaseButton<T>(this Style<T> style, Avalonia.Controls.Button? value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.DecreaseButtonProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DecreaseButton<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.DecreaseButtonProperty, binding);


 // IsDirectionReversed

/*ValueStyleSetterGenerator*/
public static Style<T> IsDirectionReversed<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDirectionReversed<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty, binding);


 // IgnoreThumbDrag

/*ValueStyleSetterGenerator*/
public static Style<T> IgnoreThumbDrag<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IgnoreThumbDrag<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty, binding);


 // DeferThumbDrag

/*ValueStyleSetterGenerator*/
public static Style<T> DeferThumbDrag<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.DeferThumbDragProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DeferThumbDrag<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.DeferThumbDragProperty, binding);



}

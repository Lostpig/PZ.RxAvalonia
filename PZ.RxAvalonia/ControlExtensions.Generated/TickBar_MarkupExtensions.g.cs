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
public static partial class TickBar_MarkupExtensions
{
//================= Properties ======================//
 // Fill

/*ValueSetterGenerator*/
public static T Fill<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.TickBar 
{
    control.Fill = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Fill<T>(this T control, Func<Avalonia.Media.IBrush?> func) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.FillProperty!, func);

/*SetterFromObservableGenerator*/
public static T Fill<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.FillProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Fill<T>(this T control, ISubject<Avalonia.Media.IBrush?> subject) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.FillProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Fill<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs, IObserver<Avalonia.Media.IBrush?> changed) where T : Avalonia.Controls.TickBar 
   => control._setEx(Avalonia.Controls.TickBar.FillProperty!, obs, changed);


 // Minimum

/*ValueSetterGenerator*/
public static T Minimum<T>(this T control, System.Double value) where T : Avalonia.Controls.TickBar 
{
    control.Minimum = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Minimum<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.MinimumProperty!, func);

/*SetterFromObservableGenerator*/
public static T Minimum<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.MinimumProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Minimum<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.MinimumProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Minimum<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.TickBar 
   => control._setEx(Avalonia.Controls.TickBar.MinimumProperty!, obs, changed);


 // Maximum

/*ValueSetterGenerator*/
public static T Maximum<T>(this T control, System.Double value) where T : Avalonia.Controls.TickBar 
{
    control.Maximum = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Maximum<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.MaximumProperty!, func);

/*SetterFromObservableGenerator*/
public static T Maximum<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.MaximumProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Maximum<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.MaximumProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Maximum<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.TickBar 
   => control._setEx(Avalonia.Controls.TickBar.MaximumProperty!, obs, changed);


 // TickFrequency

/*ValueSetterGenerator*/
public static T TickFrequency<T>(this T control, System.Double value) where T : Avalonia.Controls.TickBar 
{
    control.TickFrequency = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TickFrequency<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.TickFrequencyProperty!, func);

/*SetterFromObservableGenerator*/
public static T TickFrequency<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.TickFrequencyProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TickFrequency<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.TickFrequencyProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T TickFrequency<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.TickBar 
   => control._setEx(Avalonia.Controls.TickBar.TickFrequencyProperty!, obs, changed);


 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.TickBar 
{
    control.Orientation = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.OrientationProperty!, func);

/*SetterFromObservableGenerator*/
public static T Orientation<T>(this T control, IObservable<Avalonia.Layout.Orientation> obs) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.OrientationProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Orientation<T>(this T control, ISubject<Avalonia.Layout.Orientation> subject) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.OrientationProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Orientation<T>(this T control, IObservable<Avalonia.Layout.Orientation> obs, IObserver<Avalonia.Layout.Orientation> changed) where T : Avalonia.Controls.TickBar 
   => control._setEx(Avalonia.Controls.TickBar.OrientationProperty!, obs, changed);


 // Ticks

/*ValueSetterGenerator*/
public static T Ticks<T>(this T control, Avalonia.Collections.AvaloniaList<System.Double> value) where T : Avalonia.Controls.TickBar 
{
    control.Ticks = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Ticks<T>(this T control, Func<Avalonia.Collections.AvaloniaList<System.Double>> func) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.TicksProperty!, func);

/*SetterFromObservableGenerator*/
public static T Ticks<T>(this T control, IObservable<Avalonia.Collections.AvaloniaList<System.Double>> obs) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.TicksProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Ticks<T>(this T control, ISubject<Avalonia.Collections.AvaloniaList<System.Double>> subject) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.TicksProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Ticks<T>(this T control, IObservable<Avalonia.Collections.AvaloniaList<System.Double>> obs, IObserver<Avalonia.Collections.AvaloniaList<System.Double>> changed) where T : Avalonia.Controls.TickBar 
   => control._setEx(Avalonia.Controls.TickBar.TicksProperty!, obs, changed);


 // IsDirectionReversed

/*ValueSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TickBar 
{
    control.IsDirectionReversed = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsDirectionReversed<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.IsDirectionReversedProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsDirectionReversed<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.IsDirectionReversedProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsDirectionReversed<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.IsDirectionReversedProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsDirectionReversed<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.TickBar 
   => control._setEx(Avalonia.Controls.TickBar.IsDirectionReversedProperty!, obs, changed);


 // Placement

/*ValueSetterGenerator*/
public static T Placement<T>(this T control, Avalonia.Controls.TickBarPlacement value) where T : Avalonia.Controls.TickBar 
{
    control.Placement = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Placement<T>(this T control, Func<Avalonia.Controls.TickBarPlacement> func) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.PlacementProperty!, func);

/*SetterFromObservableGenerator*/
public static T Placement<T>(this T control, IObservable<Avalonia.Controls.TickBarPlacement> obs) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.PlacementProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Placement<T>(this T control, ISubject<Avalonia.Controls.TickBarPlacement> subject) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.PlacementProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Placement<T>(this T control, IObservable<Avalonia.Controls.TickBarPlacement> obs, IObserver<Avalonia.Controls.TickBarPlacement> changed) where T : Avalonia.Controls.TickBar 
   => control._setEx(Avalonia.Controls.TickBar.PlacementProperty!, obs, changed);


 // ReservedSpace

/*ValueSetterGenerator*/
public static T ReservedSpace<T>(this T control, Avalonia.Rect value) where T : Avalonia.Controls.TickBar 
{
    control.ReservedSpace = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static T ReservedSpace<T>(this T control, System.Double x = default!, System.Double y = default!, System.Double width = default!, System.Double height = default!) where T : Avalonia.Controls.TickBar 
{
    control.ReservedSpace = new Avalonia.Rect(x, y, width, height);
    return control;
}
public static T ReservedSpace<T>(this T control, Avalonia.Size size = default!) where T : Avalonia.Controls.TickBar 
{
    control.ReservedSpace = new Avalonia.Rect(size);
    return control;
}
public static T ReservedSpace<T>(this T control, Avalonia.Point position = default!, Avalonia.Size size = default!) where T : Avalonia.Controls.TickBar 
{
    control.ReservedSpace = new Avalonia.Rect(position, size);
    return control;
}
public static T ReservedSpace<T>(this T control, Avalonia.Point topLeft = default!, Avalonia.Point bottomRight = default!) where T : Avalonia.Controls.TickBar 
{
    control.ReservedSpace = new Avalonia.Rect(topLeft, bottomRight);
    return control;
}

/*SetterFromFuncGenerator*/
public static T ReservedSpace<T>(this T control, Func<Avalonia.Rect> func) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.ReservedSpaceProperty!, func);

/*SetterFromObservableGenerator*/
public static T ReservedSpace<T>(this T control, IObservable<Avalonia.Rect> obs) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.ReservedSpaceProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ReservedSpace<T>(this T control, ISubject<Avalonia.Rect> subject) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.ReservedSpaceProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ReservedSpace<T>(this T control, IObservable<Avalonia.Rect> obs, IObserver<Avalonia.Rect> changed) where T : Avalonia.Controls.TickBar 
   => control._setEx(Avalonia.Controls.TickBar.ReservedSpaceProperty!, obs, changed);



//================= Styles ======================//
 // Fill

/*ValueStyleSetterGenerator*/
public static Style<T> Fill<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.FillProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Fill<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.FillProperty, binding);


 // Minimum

/*ValueStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.MinimumProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.MinimumProperty, binding);


 // Maximum

/*ValueStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.MaximumProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.MaximumProperty, binding);


 // TickFrequency

/*ValueStyleSetterGenerator*/
public static Style<T> TickFrequency<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.TickFrequencyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TickFrequency<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.TickFrequencyProperty, binding);


 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.OrientationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.OrientationProperty, binding);


 // Ticks

/*ValueStyleSetterGenerator*/
public static Style<T> Ticks<T>(this Style<T> style, Avalonia.Collections.AvaloniaList<System.Double> value) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.TicksProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Ticks<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.TicksProperty, binding);


 // IsDirectionReversed

/*ValueStyleSetterGenerator*/
public static Style<T> IsDirectionReversed<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.IsDirectionReversedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDirectionReversed<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.IsDirectionReversedProperty, binding);


 // Placement

/*ValueStyleSetterGenerator*/
public static Style<T> Placement<T>(this Style<T> style, Avalonia.Controls.TickBarPlacement value) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.PlacementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Placement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.PlacementProperty, binding);


 // ReservedSpace

/*ValueStyleSetterGenerator*/
public static Style<T> ReservedSpace<T>(this Style<T> style, Avalonia.Rect value) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.ReservedSpaceProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ReservedSpace<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.ReservedSpaceProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> ReservedSpace<T>(this Style<T> style, System.Double x, System.Double y, System.Double width, System.Double height) where T : Avalonia.Controls.TickBar 
   => style._addSetter(Avalonia.Controls.TickBar.ReservedSpaceProperty, new Avalonia.Rect(x, y, width, height));public static Style<T> ReservedSpace<T>(this Style<T> style, Avalonia.Size size) where T : Avalonia.Controls.TickBar 
   => style._addSetter(Avalonia.Controls.TickBar.ReservedSpaceProperty, new Avalonia.Rect(size));public static Style<T> ReservedSpace<T>(this Style<T> style, Avalonia.Point position, Avalonia.Size size) where T : Avalonia.Controls.TickBar 
   => style._addSetter(Avalonia.Controls.TickBar.ReservedSpaceProperty, new Avalonia.Rect(position, size));public static Style<T> ReservedSpace<T>(this Style<T> style, Avalonia.Point topLeft, Avalonia.Point bottomRight) where T : Avalonia.Controls.TickBar 
   => style._addSetter(Avalonia.Controls.TickBar.ReservedSpaceProperty, new Avalonia.Rect(topLeft, bottomRight));



}

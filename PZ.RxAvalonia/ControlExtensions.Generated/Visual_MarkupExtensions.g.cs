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
public static partial class Visual_MarkupExtensions
{
//================= Properties ======================//
 // ClipToBounds

/*ValueSetterGenerator*/
public static T ClipToBounds<T>(this T control, System.Boolean value) where T : Avalonia.Visual 
{
    control.ClipToBounds = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ClipToBounds<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ClipToBoundsProperty!, func);

/*SetterFromObservableGenerator*/
public static T ClipToBounds<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ClipToBoundsProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ClipToBounds<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ClipToBoundsProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ClipToBounds<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Visual 
   => control._setEx(Avalonia.Visual.ClipToBoundsProperty!, obs, changed);


 // Clip

/*ValueSetterGenerator*/
public static T Clip<T>(this T control, Avalonia.Media.Geometry value) where T : Avalonia.Visual 
{
    control.Clip = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Clip<T>(this T control, Func<Avalonia.Media.Geometry> func) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ClipProperty!, func);

/*SetterFromObservableGenerator*/
public static T Clip<T>(this T control, IObservable<Avalonia.Media.Geometry> obs) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ClipProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Clip<T>(this T control, ISubject<Avalonia.Media.Geometry> subject) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ClipProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Clip<T>(this T control, IObservable<Avalonia.Media.Geometry> obs, IObserver<Avalonia.Media.Geometry> changed) where T : Avalonia.Visual 
   => control._setEx(Avalonia.Visual.ClipProperty!, obs, changed);


 // IsVisible

/*ValueSetterGenerator*/
public static T IsVisible<T>(this T control, System.Boolean value) where T : Avalonia.Visual 
{
    control.IsVisible = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsVisible<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.IsVisibleProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsVisible<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.IsVisibleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsVisible<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.IsVisibleProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsVisible<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Visual 
   => control._setEx(Avalonia.Visual.IsVisibleProperty!, obs, changed);


 // Opacity

/*ValueSetterGenerator*/
public static T Opacity<T>(this T control, System.Double value) where T : Avalonia.Visual 
{
    control.Opacity = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Opacity<T>(this T control, Func<System.Double> func) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.OpacityProperty!, func);

/*SetterFromObservableGenerator*/
public static T Opacity<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.OpacityProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Opacity<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.OpacityProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Opacity<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Visual 
   => control._setEx(Avalonia.Visual.OpacityProperty!, obs, changed);


 // OpacityMask

/*ValueSetterGenerator*/
public static T OpacityMask<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Visual 
{
    control.OpacityMask = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T OpacityMask<T>(this T control, Func<Avalonia.Media.IBrush> func) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.OpacityMaskProperty!, func);

/*SetterFromObservableGenerator*/
public static T OpacityMask<T>(this T control, IObservable<Avalonia.Media.IBrush> obs) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.OpacityMaskProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T OpacityMask<T>(this T control, ISubject<Avalonia.Media.IBrush> subject) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.OpacityMaskProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T OpacityMask<T>(this T control, IObservable<Avalonia.Media.IBrush> obs, IObserver<Avalonia.Media.IBrush> changed) where T : Avalonia.Visual 
   => control._setEx(Avalonia.Visual.OpacityMaskProperty!, obs, changed);


 // Effect

/*ValueSetterGenerator*/
public static T Effect<T>(this T control, Avalonia.Media.IEffect value) where T : Avalonia.Visual 
{
    control.Effect = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Effect<T>(this T control, Func<Avalonia.Media.IEffect> func) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.EffectProperty!, func);

/*SetterFromObservableGenerator*/
public static T Effect<T>(this T control, IObservable<Avalonia.Media.IEffect> obs) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.EffectProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Effect<T>(this T control, ISubject<Avalonia.Media.IEffect> subject) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.EffectProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Effect<T>(this T control, IObservable<Avalonia.Media.IEffect> obs, IObserver<Avalonia.Media.IEffect> changed) where T : Avalonia.Visual 
   => control._setEx(Avalonia.Visual.EffectProperty!, obs, changed);


 // RenderTransform

/*ValueSetterGenerator*/
public static T RenderTransform<T>(this T control, Avalonia.Media.ITransform value) where T : Avalonia.Visual 
{
    control.RenderTransform = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T RenderTransform<T>(this T control, Func<Avalonia.Media.ITransform> func) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.RenderTransformProperty!, func);

/*SetterFromObservableGenerator*/
public static T RenderTransform<T>(this T control, IObservable<Avalonia.Media.ITransform> obs) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.RenderTransformProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T RenderTransform<T>(this T control, ISubject<Avalonia.Media.ITransform> subject) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.RenderTransformProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T RenderTransform<T>(this T control, IObservable<Avalonia.Media.ITransform> obs, IObserver<Avalonia.Media.ITransform> changed) where T : Avalonia.Visual 
   => control._setEx(Avalonia.Visual.RenderTransformProperty!, obs, changed);


 // RenderTransformOrigin

/*ValueSetterGenerator*/
public static T RenderTransformOrigin<T>(this T control, Avalonia.RelativePoint value) where T : Avalonia.Visual 
{
    control.RenderTransformOrigin = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static T RenderTransformOrigin<T>(this T control, System.Double x = default!, System.Double y = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Visual 
{
    control.RenderTransformOrigin = new Avalonia.RelativePoint(x, y, unit);
    return control;
}
public static T RenderTransformOrigin<T>(this T control, Avalonia.Point point = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Visual 
{
    control.RenderTransformOrigin = new Avalonia.RelativePoint(point, unit);
    return control;
}

/*SetterFromFuncGenerator*/
public static T RenderTransformOrigin<T>(this T control, Func<Avalonia.RelativePoint> func) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.RenderTransformOriginProperty!, func);

/*SetterFromObservableGenerator*/
public static T RenderTransformOrigin<T>(this T control, IObservable<Avalonia.RelativePoint> obs) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.RenderTransformOriginProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T RenderTransformOrigin<T>(this T control, ISubject<Avalonia.RelativePoint> subject) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.RenderTransformOriginProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T RenderTransformOrigin<T>(this T control, IObservable<Avalonia.RelativePoint> obs, IObserver<Avalonia.RelativePoint> changed) where T : Avalonia.Visual 
   => control._setEx(Avalonia.Visual.RenderTransformOriginProperty!, obs, changed);


 // FlowDirection

/*ValueSetterGenerator*/
public static T FlowDirection<T>(this T control, Avalonia.Media.FlowDirection value) where T : Avalonia.Visual 
{
    control.FlowDirection = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FlowDirection<T>(this T control, Func<Avalonia.Media.FlowDirection> func) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.FlowDirectionProperty!, func);

/*SetterFromObservableGenerator*/
public static T FlowDirection<T>(this T control, IObservable<Avalonia.Media.FlowDirection> obs) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.FlowDirectionProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FlowDirection<T>(this T control, ISubject<Avalonia.Media.FlowDirection> subject) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.FlowDirectionProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T FlowDirection<T>(this T control, IObservable<Avalonia.Media.FlowDirection> obs, IObserver<Avalonia.Media.FlowDirection> changed) where T : Avalonia.Visual 
   => control._setEx(Avalonia.Visual.FlowDirectionProperty!, obs, changed);


 // ZIndex

/*ValueSetterGenerator*/
public static T ZIndex<T>(this T control, System.Int32 value) where T : Avalonia.Visual 
{
    control.ZIndex = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ZIndex<T>(this T control, Func<System.Int32> func) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ZIndexProperty!, func);

/*SetterFromObservableGenerator*/
public static T ZIndex<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ZIndexProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ZIndex<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ZIndexProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ZIndex<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Visual 
   => control._setEx(Avalonia.Visual.ZIndexProperty!, obs, changed);



//================= Attached Properties ======================//
 // FlowDirection

/*AttachedPropertyFuncGenerator*/
public static T Visual_FlowDirection<T>(this T control, Func<Avalonia.Media.FlowDirection> getter) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.FlowDirectionProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T Visual_FlowDirection<T>(this T control, IObservable<Avalonia.Media.FlowDirection> obs) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.FlowDirectionProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T Visual_FlowDirection<T>(this T control, ISubject<Avalonia.Media.FlowDirection> subject) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.FlowDirectionProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T Visual_FlowDirection<T>(this T control, Avalonia.Media.FlowDirection value) where T : Avalonia.Visual 
{
    control.SetValue(Avalonia.Visual.FlowDirectionProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T Visual_FlowDirection<T>(this T control, IObservable<Avalonia.Media.FlowDirection> obs, IObserver<Avalonia.Media.FlowDirection> changed) where T : Avalonia.Visual 
   => control._setEx(Avalonia.Visual.FlowDirectionProperty!, obs, changed);



//================= Events ======================//
 // AttachedToVisualTree

/*ActionToEventGenerator*/
public static T OnAttachedToVisualTree<T>(this T control, Action<Avalonia.VisualTreeAttachmentEventArgs> action) where T : Avalonia.Visual  => 
 control._setEvent((System.EventHandler<Avalonia.VisualTreeAttachmentEventArgs>) ((arg0, arg1) => action(arg1)), h => control.AttachedToVisualTree += h);

/*ReactiveEventGenerator*/
public static T RxAttachedToVisualTree<T>(this T control, IObserver<Avalonia.VisualTreeAttachmentEventArgs> observer) where T : Avalonia.Visual  => 
 control._setEvent((System.EventHandler<Avalonia.VisualTreeAttachmentEventArgs>) ((arg0, arg1) => observer.OnNext((arg1))), h => control.AttachedToVisualTree += h);


 // DetachedFromVisualTree

/*ActionToEventGenerator*/
public static T OnDetachedFromVisualTree<T>(this T control, Action<Avalonia.VisualTreeAttachmentEventArgs> action) where T : Avalonia.Visual  => 
 control._setEvent((System.EventHandler<Avalonia.VisualTreeAttachmentEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DetachedFromVisualTree += h);

/*ReactiveEventGenerator*/
public static T RxDetachedFromVisualTree<T>(this T control, IObserver<Avalonia.VisualTreeAttachmentEventArgs> observer) where T : Avalonia.Visual  => 
 control._setEvent((System.EventHandler<Avalonia.VisualTreeAttachmentEventArgs>) ((arg0, arg1) => observer.OnNext((arg1))), h => control.DetachedFromVisualTree += h);



//================= Styles ======================//
 // ClipToBounds

/*ValueStyleSetterGenerator*/
public static Style<T> ClipToBounds<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.ClipToBoundsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ClipToBounds<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.ClipToBoundsProperty, binding);


 // Clip

/*ValueStyleSetterGenerator*/
public static Style<T> Clip<T>(this Style<T> style, Avalonia.Media.Geometry value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.ClipProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Clip<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.ClipProperty, binding);


 // IsVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.IsVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.IsVisibleProperty, binding);


 // Opacity

/*ValueStyleSetterGenerator*/
public static Style<T> Opacity<T>(this Style<T> style, System.Double value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.OpacityProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Opacity<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.OpacityProperty, binding);


 // OpacityMask

/*ValueStyleSetterGenerator*/
public static Style<T> OpacityMask<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.OpacityMaskProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> OpacityMask<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.OpacityMaskProperty, binding);


 // Effect

/*ValueStyleSetterGenerator*/
public static Style<T> Effect<T>(this Style<T> style, Avalonia.Media.IEffect value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.EffectProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Effect<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.EffectProperty, binding);


 // RenderTransform

/*ValueStyleSetterGenerator*/
public static Style<T> RenderTransform<T>(this Style<T> style, Avalonia.Media.ITransform value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.RenderTransformProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RenderTransform<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.RenderTransformProperty, binding);


 // RenderTransformOrigin

/*ValueStyleSetterGenerator*/
public static Style<T> RenderTransformOrigin<T>(this Style<T> style, Avalonia.RelativePoint value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.RenderTransformOriginProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RenderTransformOrigin<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.RenderTransformOriginProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> RenderTransformOrigin<T>(this Style<T> style, System.Double x, System.Double y, Avalonia.RelativeUnit unit) where T : Avalonia.Visual 
   => style._addSetter(Avalonia.Visual.RenderTransformOriginProperty, new Avalonia.RelativePoint(x, y, unit));public static Style<T> RenderTransformOrigin<T>(this Style<T> style, Avalonia.Point point, Avalonia.RelativeUnit unit) where T : Avalonia.Visual 
   => style._addSetter(Avalonia.Visual.RenderTransformOriginProperty, new Avalonia.RelativePoint(point, unit));


 // FlowDirection

/*ValueStyleSetterGenerator*/
public static Style<T> FlowDirection<T>(this Style<T> style, Avalonia.Media.FlowDirection value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.FlowDirectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FlowDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.FlowDirectionProperty, binding);


 // ZIndex

/*ValueStyleSetterGenerator*/
public static Style<T> ZIndex<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.ZIndexProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ZIndex<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.ZIndexProperty, binding);



}

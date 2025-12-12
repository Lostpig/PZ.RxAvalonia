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
public static partial class Popup_MarkupExtensions
{
//================= Properties ======================//
 // WindowManagerAddShadowHint

/*ValueSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
{
    control.WindowManagerAddShadowHint = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty!, func);

/*SetterFromObservableGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty!, subject);


 // Child

/*ValueSetterGenerator*/
public static T Child<T>(this T control, Avalonia.Controls.Control value) where T : Avalonia.Controls.Primitives.Popup 
{
    control.Child = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Child<T>(this T control, Func<Avalonia.Controls.Control> func) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.ChildProperty!, func);

/*SetterFromObservableGenerator*/
public static T Child<T>(this T control, IObservable<Avalonia.Controls.Control> obs) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.ChildProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Child<T>(this T control, ISubject<Avalonia.Controls.Control> subject) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.ChildProperty!, subject);


 // InheritsTransform

/*ValueSetterGenerator*/
public static T InheritsTransform<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
{
    control.InheritsTransform = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T InheritsTransform<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty!, func);

/*SetterFromObservableGenerator*/
public static T InheritsTransform<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T InheritsTransform<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty!, subject);


 // IsOpen

/*ValueSetterGenerator*/
public static T IsOpen<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
{
    control.IsOpen = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsOpen<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.IsOpenProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsOpen<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.IsOpenProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsOpen<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.IsOpenProperty!, subject);


 // PlacementAnchor

/*ValueSetterGenerator*/
public static T PlacementAnchor<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor value) where T : Avalonia.Controls.Primitives.Popup 
{
    control.PlacementAnchor = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PlacementAnchor<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> func) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty!, func);

/*SetterFromObservableGenerator*/
public static T PlacementAnchor<T>(this T control, IObservable<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> obs) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PlacementAnchor<T>(this T control, ISubject<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> subject) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty!, subject);


 // PlacementConstraintAdjustment

/*ValueSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment value) where T : Avalonia.Controls.Primitives.Popup 
{
    control.PlacementConstraintAdjustment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> func) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, IObservable<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> obs) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, ISubject<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> subject) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty!, subject);


 // PlacementGravity

/*ValueSetterGenerator*/
public static T PlacementGravity<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupGravity value) where T : Avalonia.Controls.Primitives.Popup 
{
    control.PlacementGravity = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PlacementGravity<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> func) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty!, func);

/*SetterFromObservableGenerator*/
public static T PlacementGravity<T>(this T control, IObservable<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> obs) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PlacementGravity<T>(this T control, ISubject<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> subject) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty!, subject);


 // Placement

/*ValueSetterGenerator*/
public static T Placement<T>(this T control, Avalonia.Controls.PlacementMode value) where T : Avalonia.Controls.Primitives.Popup 
{
    control.Placement = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Placement<T>(this T control, Func<Avalonia.Controls.PlacementMode> func) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementProperty!, func);

/*SetterFromObservableGenerator*/
public static T Placement<T>(this T control, IObservable<Avalonia.Controls.PlacementMode> obs) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Placement<T>(this T control, ISubject<Avalonia.Controls.PlacementMode> subject) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementProperty!, subject);


 // PlacementRect

/*ValueSetterGenerator*/
public static T PlacementRect<T>(this T control, System.Nullable<Avalonia.Rect> value) where T : Avalonia.Controls.Primitives.Popup 
{
    control.PlacementRect = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PlacementRect<T>(this T control, Func<System.Nullable<Avalonia.Rect>> func) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementRectProperty!, func);

/*SetterFromObservableGenerator*/
public static T PlacementRect<T>(this T control, IObservable<System.Nullable<Avalonia.Rect>> obs) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementRectProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PlacementRect<T>(this T control, ISubject<System.Nullable<Avalonia.Rect>> subject) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementRectProperty!, subject);


 // PlacementTarget

/*ValueSetterGenerator*/
public static T PlacementTarget<T>(this T control, Avalonia.Controls.Control value) where T : Avalonia.Controls.Primitives.Popup 
{
    control.PlacementTarget = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PlacementTarget<T>(this T control, Func<Avalonia.Controls.Control> func) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty!, func);

/*SetterFromObservableGenerator*/
public static T PlacementTarget<T>(this T control, IObservable<Avalonia.Controls.Control> obs) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PlacementTarget<T>(this T control, ISubject<Avalonia.Controls.Control> subject) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty!, subject);


 // CustomPopupPlacementCallback

/*ValueSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback value) where T : Avalonia.Controls.Primitives.Popup 
{
    control.CustomPopupPlacementCallback = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> func) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.CustomPopupPlacementCallbackProperty!, func);

/*SetterFromObservableGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, IObservable<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> obs) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.CustomPopupPlacementCallbackProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, ISubject<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> subject) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.CustomPopupPlacementCallbackProperty!, subject);


 // OverlayDismissEventPassThrough

/*ValueSetterGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
{
    control.OverlayDismissEventPassThrough = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty!, func);

/*SetterFromObservableGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty!, subject);


 // OverlayInputPassThroughElement

/*ValueSetterGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, Avalonia.Input.IInputElement value) where T : Avalonia.Controls.Primitives.Popup 
{
    control.OverlayInputPassThroughElement = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, Func<Avalonia.Input.IInputElement> func) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty!, func);

/*SetterFromObservableGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, IObservable<Avalonia.Input.IInputElement> obs) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, ISubject<Avalonia.Input.IInputElement> subject) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty!, subject);


 // HorizontalOffset

/*ValueSetterGenerator*/
public static T HorizontalOffset<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.Popup 
{
    control.HorizontalOffset = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T HorizontalOffset<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty!, func);

/*SetterFromObservableGenerator*/
public static T HorizontalOffset<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T HorizontalOffset<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty!, subject);


 // IsLightDismissEnabled

/*ValueSetterGenerator*/
public static T IsLightDismissEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
{
    control.IsLightDismissEnabled = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsLightDismissEnabled<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsLightDismissEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsLightDismissEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty!, subject);


 // VerticalOffset

/*ValueSetterGenerator*/
public static T VerticalOffset<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.Popup 
{
    control.VerticalOffset = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T VerticalOffset<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty!, func);

/*SetterFromObservableGenerator*/
public static T VerticalOffset<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T VerticalOffset<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty!, subject);


 // Topmost

/*ValueSetterGenerator*/
public static T Topmost<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
{
    control.Topmost = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Topmost<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.TopmostProperty!, func);

/*SetterFromObservableGenerator*/
public static T Topmost<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.TopmostProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Topmost<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.TopmostProperty!, subject);


 // TakesFocusFromNativeControl

/*ValueSetterGenerator*/
public static T TakesFocusFromNativeControl<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
{
    control.TakesFocusFromNativeControl = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TakesFocusFromNativeControl<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty!, func);

/*SetterFromObservableGenerator*/
public static T TakesFocusFromNativeControl<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TakesFocusFromNativeControl<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty!, subject);


 // ShouldUseOverlayLayer

/*ValueSetterGenerator*/
public static T ShouldUseOverlayLayer<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
{
    control.ShouldUseOverlayLayer = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ShouldUseOverlayLayer<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.ShouldUseOverlayLayerProperty!, func);

/*SetterFromObservableGenerator*/
public static T ShouldUseOverlayLayer<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.ShouldUseOverlayLayerProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ShouldUseOverlayLayer<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.ShouldUseOverlayLayerProperty!, subject);



//================= Attached Properties ======================//
 // TakesFocusFromNativeControl

/*AttachedPropertyFuncGenerator*/
public static T Popup_TakesFocusFromNativeControl<T>(this T control, Func<System.Boolean> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T Popup_TakesFocusFromNativeControl<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T Popup_TakesFocusFromNativeControl<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T Popup_TakesFocusFromNativeControl<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty!, value);
    return control;
}



//================= Events ======================//
 // Closed

/*ActionToEventGenerator*/
public static T OnClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.Popup  => 
 control._setEvent((System.EventHandler<System.EventArgs>) ((arg0, arg1) => action(arg1)), h => control.Closed += h);


 // Opened

/*ActionToEventGenerator*/
public static T OnOpened<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.Popup  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Opened += h);



//================= Styles ======================//
 // WindowManagerAddShadowHint

/*ValueStyleSetterGenerator*/
public static Style<T> WindowManagerAddShadowHint<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> WindowManagerAddShadowHint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty, binding);


 // Child

/*ValueStyleSetterGenerator*/
public static Style<T> Child<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.ChildProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Child<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.ChildProperty, binding);


 // InheritsTransform

/*ValueStyleSetterGenerator*/
public static Style<T> InheritsTransform<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InheritsTransform<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty, binding);


 // IsOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.IsOpenProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.IsOpenProperty, binding);


 // PlacementAnchor

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementAnchor<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementAnchor<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty, binding);


 // PlacementConstraintAdjustment

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementConstraintAdjustment<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementConstraintAdjustment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty, binding);


 // PlacementGravity

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementGravity<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupGravity value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementGravity<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty, binding);


 // Placement

/*ValueStyleSetterGenerator*/
public static Style<T> Placement<T>(this Style<T> style, Avalonia.Controls.PlacementMode value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Placement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementProperty, binding);


 // PlacementRect

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementRect<T>(this Style<T> style, System.Nullable<Avalonia.Rect> value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementRectProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementRect<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementRectProperty, binding);


 // PlacementTarget

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementTarget<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementTarget<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty, binding);


 // CustomPopupPlacementCallback

/*ValueStyleSetterGenerator*/
public static Style<T> CustomPopupPlacementCallback<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.CustomPopupPlacementCallbackProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CustomPopupPlacementCallback<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.CustomPopupPlacementCallbackProperty, binding);


 // OverlayDismissEventPassThrough

/*ValueStyleSetterGenerator*/
public static Style<T> OverlayDismissEventPassThrough<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> OverlayDismissEventPassThrough<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty, binding);


 // OverlayInputPassThroughElement

/*ValueStyleSetterGenerator*/
public static Style<T> OverlayInputPassThroughElement<T>(this Style<T> style, Avalonia.Input.IInputElement value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> OverlayInputPassThroughElement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty, binding);


 // HorizontalOffset

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty, binding);


 // IsLightDismissEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsLightDismissEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsLightDismissEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty, binding);


 // VerticalOffset

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty, binding);


 // Topmost

/*ValueStyleSetterGenerator*/
public static Style<T> Topmost<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.TopmostProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Topmost<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.TopmostProperty, binding);


 // TakesFocusFromNativeControl

/*ValueStyleSetterGenerator*/
public static Style<T> TakesFocusFromNativeControl<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TakesFocusFromNativeControl<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty, binding);


 // ShouldUseOverlayLayer

/*ValueStyleSetterGenerator*/
public static Style<T> ShouldUseOverlayLayer<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.ShouldUseOverlayLayerProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShouldUseOverlayLayer<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.ShouldUseOverlayLayerProperty, binding);



}

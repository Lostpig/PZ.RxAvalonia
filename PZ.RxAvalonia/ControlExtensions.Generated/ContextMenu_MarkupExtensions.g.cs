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
public static partial class ContextMenu_MarkupExtensions
{
//================= Properties ======================//
 // HorizontalOffset

/*ValueSetterGenerator*/
public static T HorizontalOffset<T>(this T control, System.Double value) where T : Avalonia.Controls.ContextMenu 
{
    control.HorizontalOffset = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T HorizontalOffset<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty!, func);

/*SetterFromObservableGenerator*/
public static T HorizontalOffset<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T HorizontalOffset<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T HorizontalOffset<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.ContextMenu 
   => control._setEx(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty!, obs, changed);


 // VerticalOffset

/*ValueSetterGenerator*/
public static T VerticalOffset<T>(this T control, System.Double value) where T : Avalonia.Controls.ContextMenu 
{
    control.VerticalOffset = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T VerticalOffset<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.VerticalOffsetProperty!, func);

/*SetterFromObservableGenerator*/
public static T VerticalOffset<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.VerticalOffsetProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T VerticalOffset<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.VerticalOffsetProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T VerticalOffset<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.ContextMenu 
   => control._setEx(Avalonia.Controls.ContextMenu.VerticalOffsetProperty!, obs, changed);


 // PlacementAnchor

/*ValueSetterGenerator*/
public static T PlacementAnchor<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor value) where T : Avalonia.Controls.ContextMenu 
{
    control.PlacementAnchor = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PlacementAnchor<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> func) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementAnchorProperty!, func);

/*SetterFromObservableGenerator*/
public static T PlacementAnchor<T>(this T control, IObservable<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> obs) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementAnchorProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PlacementAnchor<T>(this T control, ISubject<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> subject) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementAnchorProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T PlacementAnchor<T>(this T control, IObservable<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> obs, IObserver<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> changed) where T : Avalonia.Controls.ContextMenu 
   => control._setEx(Avalonia.Controls.ContextMenu.PlacementAnchorProperty!, obs, changed);


 // PlacementConstraintAdjustment

/*ValueSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment value) where T : Avalonia.Controls.ContextMenu 
{
    control.PlacementConstraintAdjustment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> func) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, IObservable<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> obs) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, ISubject<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> subject) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, IObservable<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> obs, IObserver<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> changed) where T : Avalonia.Controls.ContextMenu 
   => control._setEx(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty!, obs, changed);


 // PlacementGravity

/*ValueSetterGenerator*/
public static T PlacementGravity<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupGravity value) where T : Avalonia.Controls.ContextMenu 
{
    control.PlacementGravity = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PlacementGravity<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> func) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementGravityProperty!, func);

/*SetterFromObservableGenerator*/
public static T PlacementGravity<T>(this T control, IObservable<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> obs) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementGravityProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PlacementGravity<T>(this T control, ISubject<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> subject) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementGravityProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T PlacementGravity<T>(this T control, IObservable<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> obs, IObserver<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> changed) where T : Avalonia.Controls.ContextMenu 
   => control._setEx(Avalonia.Controls.ContextMenu.PlacementGravityProperty!, obs, changed);


 // Placement

/*ValueSetterGenerator*/
public static T Placement<T>(this T control, Avalonia.Controls.PlacementMode value) where T : Avalonia.Controls.ContextMenu 
{
    control.Placement = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Placement<T>(this T control, Func<Avalonia.Controls.PlacementMode> func) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementProperty!, func);

/*SetterFromObservableGenerator*/
public static T Placement<T>(this T control, IObservable<Avalonia.Controls.PlacementMode> obs) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Placement<T>(this T control, ISubject<Avalonia.Controls.PlacementMode> subject) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Placement<T>(this T control, IObservable<Avalonia.Controls.PlacementMode> obs, IObserver<Avalonia.Controls.PlacementMode> changed) where T : Avalonia.Controls.ContextMenu 
   => control._setEx(Avalonia.Controls.ContextMenu.PlacementProperty!, obs, changed);


 // PlacementRect

/*ValueSetterGenerator*/
public static T PlacementRect<T>(this T control, System.Nullable<Avalonia.Rect> value) where T : Avalonia.Controls.ContextMenu 
{
    control.PlacementRect = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PlacementRect<T>(this T control, Func<System.Nullable<Avalonia.Rect>> func) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementRectProperty!, func);

/*SetterFromObservableGenerator*/
public static T PlacementRect<T>(this T control, IObservable<System.Nullable<Avalonia.Rect>> obs) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementRectProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PlacementRect<T>(this T control, ISubject<System.Nullable<Avalonia.Rect>> subject) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementRectProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T PlacementRect<T>(this T control, IObservable<System.Nullable<Avalonia.Rect>> obs, IObserver<System.Nullable<Avalonia.Rect>> changed) where T : Avalonia.Controls.ContextMenu 
   => control._setEx(Avalonia.Controls.ContextMenu.PlacementRectProperty!, obs, changed);


 // WindowManagerAddShadowHint

/*ValueSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ContextMenu 
{
    control.WindowManagerAddShadowHint = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty!, func);

/*SetterFromObservableGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.ContextMenu 
   => control._setEx(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty!, obs, changed);


 // PlacementTarget

/*ValueSetterGenerator*/
public static T PlacementTarget<T>(this T control, Avalonia.Controls.Control value) where T : Avalonia.Controls.ContextMenu 
{
    control.PlacementTarget = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PlacementTarget<T>(this T control, Func<Avalonia.Controls.Control> func) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementTargetProperty!, func);

/*SetterFromObservableGenerator*/
public static T PlacementTarget<T>(this T control, IObservable<Avalonia.Controls.Control> obs) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementTargetProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PlacementTarget<T>(this T control, ISubject<Avalonia.Controls.Control> subject) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementTargetProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T PlacementTarget<T>(this T control, IObservable<Avalonia.Controls.Control> obs, IObserver<Avalonia.Controls.Control> changed) where T : Avalonia.Controls.ContextMenu 
   => control._setEx(Avalonia.Controls.ContextMenu.PlacementTargetProperty!, obs, changed);


 // CustomPopupPlacementCallback

/*ValueSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback value) where T : Avalonia.Controls.ContextMenu 
{
    control.CustomPopupPlacementCallback = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> func) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.CustomPopupPlacementCallbackProperty!, func);

/*SetterFromObservableGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, IObservable<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> obs) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.CustomPopupPlacementCallbackProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, ISubject<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> subject) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.CustomPopupPlacementCallbackProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, IObservable<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> obs, IObserver<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> changed) where T : Avalonia.Controls.ContextMenu 
   => control._setEx(Avalonia.Controls.ContextMenu.CustomPopupPlacementCallbackProperty!, obs, changed);



//================= Events ======================//
 // Opening

/*ActionToEventGenerator*/
public static T OnOpening<T>(this T control, Action<System.ComponentModel.CancelEventArgs> action) where T : Avalonia.Controls.ContextMenu  => 
 control._setEvent((System.ComponentModel.CancelEventHandler) ((arg0, arg1) => action(arg1)), h => control.Opening += h);


 // Closing

/*ActionToEventGenerator*/
public static T OnClosing<T>(this T control, Action<System.ComponentModel.CancelEventArgs> action) where T : Avalonia.Controls.ContextMenu  => 
 control._setEvent((System.ComponentModel.CancelEventHandler) ((arg0, arg1) => action(arg1)), h => control.Closing += h);



//================= Styles ======================//
 // HorizontalOffset

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty, binding);


 // VerticalOffset

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.VerticalOffsetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.VerticalOffsetProperty, binding);


 // PlacementAnchor

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementAnchor<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementAnchorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementAnchor<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementAnchorProperty, binding);


 // PlacementConstraintAdjustment

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementConstraintAdjustment<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementConstraintAdjustment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty, binding);


 // PlacementGravity

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementGravity<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupGravity value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementGravityProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementGravity<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementGravityProperty, binding);


 // Placement

/*ValueStyleSetterGenerator*/
public static Style<T> Placement<T>(this Style<T> style, Avalonia.Controls.PlacementMode value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Placement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementProperty, binding);


 // PlacementRect

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementRect<T>(this Style<T> style, System.Nullable<Avalonia.Rect> value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementRectProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementRect<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementRectProperty, binding);


 // WindowManagerAddShadowHint

/*ValueStyleSetterGenerator*/
public static Style<T> WindowManagerAddShadowHint<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> WindowManagerAddShadowHint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty, binding);


 // PlacementTarget

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementTarget<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementTargetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementTarget<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementTargetProperty, binding);


 // CustomPopupPlacementCallback

/*ValueStyleSetterGenerator*/
public static Style<T> CustomPopupPlacementCallback<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.CustomPopupPlacementCallbackProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CustomPopupPlacementCallback<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.CustomPopupPlacementCallbackProperty, binding);



}

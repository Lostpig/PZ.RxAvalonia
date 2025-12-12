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
public static partial class PopupFlyoutBase_MarkupExtensions
{
//================= Properties ======================//
 // Placement

/*ValueSetterGenerator*/
public static T Placement<T>(this T control, Avalonia.Controls.PlacementMode value) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
{
    control.Placement = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Placement<T>(this T control, Func<Avalonia.Controls.PlacementMode> func) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementProperty!, func);

/*SetterFromObservableGenerator*/
public static T Placement<T>(this T control, IObservable<Avalonia.Controls.PlacementMode> obs) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Placement<T>(this T control, ISubject<Avalonia.Controls.PlacementMode> subject) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementProperty!, subject);


 // HorizontalOffset

/*ValueSetterGenerator*/
public static T HorizontalOffset<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
{
    control.HorizontalOffset = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T HorizontalOffset<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.HorizontalOffsetProperty!, func);

/*SetterFromObservableGenerator*/
public static T HorizontalOffset<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.HorizontalOffsetProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T HorizontalOffset<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.HorizontalOffsetProperty!, subject);


 // VerticalOffset

/*ValueSetterGenerator*/
public static T VerticalOffset<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
{
    control.VerticalOffset = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T VerticalOffset<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.VerticalOffsetProperty!, func);

/*SetterFromObservableGenerator*/
public static T VerticalOffset<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.VerticalOffsetProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T VerticalOffset<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.VerticalOffsetProperty!, subject);


 // PlacementAnchor

/*ValueSetterGenerator*/
public static T PlacementAnchor<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor value) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
{
    control.PlacementAnchor = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PlacementAnchor<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> func) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementAnchorProperty!, func);

/*SetterFromObservableGenerator*/
public static T PlacementAnchor<T>(this T control, IObservable<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> obs) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementAnchorProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PlacementAnchor<T>(this T control, ISubject<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> subject) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementAnchorProperty!, subject);


 // PlacementGravity

/*ValueSetterGenerator*/
public static T PlacementGravity<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupGravity value) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
{
    control.PlacementGravity = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PlacementGravity<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> func) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementGravityProperty!, func);

/*SetterFromObservableGenerator*/
public static T PlacementGravity<T>(this T control, IObservable<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> obs) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementGravityProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PlacementGravity<T>(this T control, ISubject<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> subject) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementGravityProperty!, subject);


 // CustomPopupPlacementCallback

/*ValueSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback value) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
{
    control.CustomPopupPlacementCallback = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> func) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.CustomPopupPlacementCallbackProperty!, func);

/*SetterFromObservableGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, IObservable<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> obs) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.CustomPopupPlacementCallbackProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, ISubject<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> subject) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.CustomPopupPlacementCallbackProperty!, subject);


 // ShowMode

/*ValueSetterGenerator*/
public static T ShowMode<T>(this T control, Avalonia.Controls.FlyoutShowMode value) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
{
    control.ShowMode = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ShowMode<T>(this T control, Func<Avalonia.Controls.FlyoutShowMode> func) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.ShowModeProperty!, func);

/*SetterFromObservableGenerator*/
public static T ShowMode<T>(this T control, IObservable<Avalonia.Controls.FlyoutShowMode> obs) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.ShowModeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ShowMode<T>(this T control, ISubject<Avalonia.Controls.FlyoutShowMode> subject) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.ShowModeProperty!, subject);


 // OverlayDismissEventPassThrough

/*ValueSetterGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
{
    control.OverlayDismissEventPassThrough = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.OverlayDismissEventPassThroughProperty!, func);

/*SetterFromObservableGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.OverlayDismissEventPassThroughProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.OverlayDismissEventPassThroughProperty!, subject);


 // OverlayInputPassThroughElement

/*ValueSetterGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, Avalonia.Input.IInputElement value) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
{
    control.OverlayInputPassThroughElement = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, Func<Avalonia.Input.IInputElement> func) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.OverlayInputPassThroughElementProperty!, func);

/*SetterFromObservableGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, IObservable<Avalonia.Input.IInputElement> obs) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.OverlayInputPassThroughElementProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, ISubject<Avalonia.Input.IInputElement> subject) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.OverlayInputPassThroughElementProperty!, subject);


 // PlacementConstraintAdjustment

/*ValueSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment value) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
{
    control.PlacementConstraintAdjustment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> func) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementConstraintAdjustmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, IObservable<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> obs) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementConstraintAdjustmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, ISubject<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> subject) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementConstraintAdjustmentProperty!, subject);



//================= Events ======================//
 // Closing

/*ActionToEventGenerator*/
public static T OnClosing<T>(this T control, Action<System.ComponentModel.CancelEventArgs> action) where T : Avalonia.Controls.Primitives.PopupFlyoutBase  => 
 control._setEvent((System.EventHandler<System.ComponentModel.CancelEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Closing += h);


 // Opening

/*ActionToEventGenerator*/
public static T OnOpening<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.PopupFlyoutBase  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Opening += h);



}

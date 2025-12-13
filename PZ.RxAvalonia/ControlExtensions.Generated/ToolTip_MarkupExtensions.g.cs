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
public static partial class ToolTip_MarkupExtensions
{
//================= Attached Properties ======================//
 // Tip

/*AttachedPropertyFuncGenerator*/
public static T ToolTip_Tip<T>(this T control, Func<System.Object> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.TipProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T ToolTip_Tip<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.TipProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T ToolTip_Tip<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.TipProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T ToolTip_Tip<T>(this T control, System.Object value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.ToolTip.TipProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T ToolTip_Tip<T>(this T control, IObservable<System.Object> obs, IObserver<System.Object> changed) where T : Avalonia.Controls.Control 
   => control._setEx(Avalonia.Controls.ToolTip.TipProperty!, obs, changed);


 // IsOpen

/*AttachedPropertyFuncGenerator*/
public static T ToolTip_IsOpen<T>(this T control, Func<System.Boolean> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.IsOpenProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T ToolTip_IsOpen<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.IsOpenProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T ToolTip_IsOpen<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.IsOpenProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T ToolTip_IsOpen<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.ToolTip.IsOpenProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T ToolTip_IsOpen<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Control 
   => control._setEx(Avalonia.Controls.ToolTip.IsOpenProperty!, obs, changed);


 // Placement

/*AttachedPropertyFuncGenerator*/
public static T ToolTip_Placement<T>(this T control, Func<Avalonia.Controls.PlacementMode> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.PlacementProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T ToolTip_Placement<T>(this T control, IObservable<Avalonia.Controls.PlacementMode> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.PlacementProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T ToolTip_Placement<T>(this T control, ISubject<Avalonia.Controls.PlacementMode> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.PlacementProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T ToolTip_Placement<T>(this T control, Avalonia.Controls.PlacementMode value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.ToolTip.PlacementProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T ToolTip_Placement<T>(this T control, IObservable<Avalonia.Controls.PlacementMode> obs, IObserver<Avalonia.Controls.PlacementMode> changed) where T : Avalonia.Controls.Control 
   => control._setEx(Avalonia.Controls.ToolTip.PlacementProperty!, obs, changed);


 // HorizontalOffset

/*AttachedPropertyFuncGenerator*/
public static T ToolTip_HorizontalOffset<T>(this T control, Func<System.Double> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.HorizontalOffsetProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T ToolTip_HorizontalOffset<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.HorizontalOffsetProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T ToolTip_HorizontalOffset<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.HorizontalOffsetProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T ToolTip_HorizontalOffset<T>(this T control, System.Double value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.ToolTip.HorizontalOffsetProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T ToolTip_HorizontalOffset<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.Control 
   => control._setEx(Avalonia.Controls.ToolTip.HorizontalOffsetProperty!, obs, changed);


 // VerticalOffset

/*AttachedPropertyFuncGenerator*/
public static T ToolTip_VerticalOffset<T>(this T control, Func<System.Double> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.VerticalOffsetProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T ToolTip_VerticalOffset<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.VerticalOffsetProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T ToolTip_VerticalOffset<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.VerticalOffsetProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T ToolTip_VerticalOffset<T>(this T control, System.Double value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.ToolTip.VerticalOffsetProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T ToolTip_VerticalOffset<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.Control 
   => control._setEx(Avalonia.Controls.ToolTip.VerticalOffsetProperty!, obs, changed);


 // CustomPopupPlacementCallback

/*AttachedPropertyFuncGenerator*/
public static T ToolTip_CustomPopupPlacementCallback<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.CustomPopupPlacementCallbackProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T ToolTip_CustomPopupPlacementCallback<T>(this T control, IObservable<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.CustomPopupPlacementCallbackProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T ToolTip_CustomPopupPlacementCallback<T>(this T control, ISubject<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.CustomPopupPlacementCallbackProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T ToolTip_CustomPopupPlacementCallback<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.ToolTip.CustomPopupPlacementCallbackProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T ToolTip_CustomPopupPlacementCallback<T>(this T control, IObservable<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> obs, IObserver<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> changed) where T : Avalonia.Controls.Control 
   => control._setEx(Avalonia.Controls.ToolTip.CustomPopupPlacementCallbackProperty!, obs, changed);


 // ShowDelay

/*AttachedPropertyFuncGenerator*/
public static T ToolTip_ShowDelay<T>(this T control, Func<System.Int32> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.ShowDelayProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T ToolTip_ShowDelay<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.ShowDelayProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T ToolTip_ShowDelay<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.ShowDelayProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T ToolTip_ShowDelay<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.ToolTip.ShowDelayProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T ToolTip_ShowDelay<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.Control 
   => control._setEx(Avalonia.Controls.ToolTip.ShowDelayProperty!, obs, changed);


 // BetweenShowDelay

/*AttachedPropertyFuncGenerator*/
public static T ToolTip_BetweenShowDelay<T>(this T control, Func<System.Int32> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.BetweenShowDelayProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T ToolTip_BetweenShowDelay<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.BetweenShowDelayProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T ToolTip_BetweenShowDelay<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.BetweenShowDelayProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T ToolTip_BetweenShowDelay<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.ToolTip.BetweenShowDelayProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T ToolTip_BetweenShowDelay<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.Control 
   => control._setEx(Avalonia.Controls.ToolTip.BetweenShowDelayProperty!, obs, changed);


 // ShowOnDisabled

/*AttachedPropertyFuncGenerator*/
public static T ToolTip_ShowOnDisabled<T>(this T control, Func<System.Boolean> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.ShowOnDisabledProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T ToolTip_ShowOnDisabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.ShowOnDisabledProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T ToolTip_ShowOnDisabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.ShowOnDisabledProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T ToolTip_ShowOnDisabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.ToolTip.ShowOnDisabledProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T ToolTip_ShowOnDisabled<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Control 
   => control._setEx(Avalonia.Controls.ToolTip.ShowOnDisabledProperty!, obs, changed);


 // ServiceEnabled

/*AttachedPropertyFuncGenerator*/
public static T ToolTip_ServiceEnabled<T>(this T control, Func<System.Boolean> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.ServiceEnabledProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T ToolTip_ServiceEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.ServiceEnabledProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T ToolTip_ServiceEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.ServiceEnabledProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T ToolTip_ServiceEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.ToolTip.ServiceEnabledProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T ToolTip_ServiceEnabled<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Control 
   => control._setEx(Avalonia.Controls.ToolTip.ServiceEnabledProperty!, obs, changed);



}

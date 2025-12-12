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
public static partial class ScrollViewer_MarkupExtensions
{
//================= Properties ======================//
 // BringIntoViewOnFocusChange

/*ValueSetterGenerator*/
public static T BringIntoViewOnFocusChange<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ScrollViewer 
{
    control.BringIntoViewOnFocusChange = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T BringIntoViewOnFocusChange<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty!, func);

/*SetterFromObservableGenerator*/
public static T BringIntoViewOnFocusChange<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T BringIntoViewOnFocusChange<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty!, subject);


 // Offset

/*ValueSetterGenerator*/
public static T Offset<T>(this T control, Avalonia.Vector value) where T : Avalonia.Controls.ScrollViewer 
{
    control.Offset = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Offset<T>(this T control, Func<Avalonia.Vector> func) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.OffsetProperty!, func);

/*SetterFromObservableGenerator*/
public static T Offset<T>(this T control, IObservable<Avalonia.Vector> obs) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.OffsetProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Offset<T>(this T control, ISubject<Avalonia.Vector> subject) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.OffsetProperty!, subject);


 // HorizontalScrollBarVisibility

/*ValueSetterGenerator*/
public static T HorizontalScrollBarVisibility<T>(this T control, Avalonia.Controls.Primitives.ScrollBarVisibility value) where T : Avalonia.Controls.ScrollViewer 
{
    control.HorizontalScrollBarVisibility = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T HorizontalScrollBarVisibility<T>(this T control, Func<Avalonia.Controls.Primitives.ScrollBarVisibility> func) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty!, func);

/*SetterFromObservableGenerator*/
public static T HorizontalScrollBarVisibility<T>(this T control, IObservable<Avalonia.Controls.Primitives.ScrollBarVisibility> obs) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T HorizontalScrollBarVisibility<T>(this T control, ISubject<Avalonia.Controls.Primitives.ScrollBarVisibility> subject) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty!, subject);


 // HorizontalSnapPointsType

/*ValueSetterGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.ScrollViewer 
{
    control.HorizontalSnapPointsType = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsType> func) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty!, func);

/*SetterFromObservableGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, IObservable<Avalonia.Controls.Primitives.SnapPointsType> obs) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, ISubject<Avalonia.Controls.Primitives.SnapPointsType> subject) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty!, subject);


 // VerticalSnapPointsType

/*ValueSetterGenerator*/
public static T VerticalSnapPointsType<T>(this T control, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.ScrollViewer 
{
    control.VerticalSnapPointsType = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T VerticalSnapPointsType<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsType> func) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty!, func);

/*SetterFromObservableGenerator*/
public static T VerticalSnapPointsType<T>(this T control, IObservable<Avalonia.Controls.Primitives.SnapPointsType> obs) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T VerticalSnapPointsType<T>(this T control, ISubject<Avalonia.Controls.Primitives.SnapPointsType> subject) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty!, subject);


 // HorizontalSnapPointsAlignment

/*ValueSetterGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.ScrollViewer 
{
    control.HorizontalSnapPointsAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsAlignment> func) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, IObservable<Avalonia.Controls.Primitives.SnapPointsAlignment> obs) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, ISubject<Avalonia.Controls.Primitives.SnapPointsAlignment> subject) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty!, subject);


 // VerticalSnapPointsAlignment

/*ValueSetterGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.ScrollViewer 
{
    control.VerticalSnapPointsAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsAlignment> func) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, IObservable<Avalonia.Controls.Primitives.SnapPointsAlignment> obs) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, ISubject<Avalonia.Controls.Primitives.SnapPointsAlignment> subject) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty!, subject);


 // VerticalScrollBarVisibility

/*ValueSetterGenerator*/
public static T VerticalScrollBarVisibility<T>(this T control, Avalonia.Controls.Primitives.ScrollBarVisibility value) where T : Avalonia.Controls.ScrollViewer 
{
    control.VerticalScrollBarVisibility = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T VerticalScrollBarVisibility<T>(this T control, Func<Avalonia.Controls.Primitives.ScrollBarVisibility> func) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty!, func);

/*SetterFromObservableGenerator*/
public static T VerticalScrollBarVisibility<T>(this T control, IObservable<Avalonia.Controls.Primitives.ScrollBarVisibility> obs) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T VerticalScrollBarVisibility<T>(this T control, ISubject<Avalonia.Controls.Primitives.ScrollBarVisibility> subject) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty!, subject);


 // AllowAutoHide

/*ValueSetterGenerator*/
public static T AllowAutoHide<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ScrollViewer 
{
    control.AllowAutoHide = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T AllowAutoHide<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty!, func);

/*SetterFromObservableGenerator*/
public static T AllowAutoHide<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T AllowAutoHide<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty!, subject);


 // IsScrollChainingEnabled

/*ValueSetterGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ScrollViewer 
{
    control.IsScrollChainingEnabled = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty!, subject);


 // IsScrollInertiaEnabled

/*ValueSetterGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ScrollViewer 
{
    control.IsScrollInertiaEnabled = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty!, subject);


 // IsDeferredScrollingEnabled

/*ValueSetterGenerator*/
public static T IsDeferredScrollingEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ScrollViewer 
{
    control.IsDeferredScrollingEnabled = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsDeferredScrollingEnabled<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsDeferredScrollingEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsDeferredScrollingEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty!, subject);



//================= Attached Properties ======================//
 // BringIntoViewOnFocusChange

/*AttachedPropertyFuncGenerator*/
public static T ScrollViewer_BringIntoViewOnFocusChange<T>(this T control, Func<System.Boolean> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T ScrollViewer_BringIntoViewOnFocusChange<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T ScrollViewer_BringIntoViewOnFocusChange<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T ScrollViewer_BringIntoViewOnFocusChange<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty!, value);
    return control;
}


 // HorizontalScrollBarVisibility

/*AttachedPropertyFuncGenerator*/
public static T ScrollViewer_HorizontalScrollBarVisibility<T>(this T control, Func<Avalonia.Controls.Primitives.ScrollBarVisibility> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T ScrollViewer_HorizontalScrollBarVisibility<T>(this T control, IObservable<Avalonia.Controls.Primitives.ScrollBarVisibility> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T ScrollViewer_HorizontalScrollBarVisibility<T>(this T control, ISubject<Avalonia.Controls.Primitives.ScrollBarVisibility> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T ScrollViewer_HorizontalScrollBarVisibility<T>(this T control, Avalonia.Controls.Primitives.ScrollBarVisibility value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty!, value);
    return control;
}


 // HorizontalSnapPointsType

/*AttachedPropertyFuncGenerator*/
public static T ScrollViewer_HorizontalSnapPointsType<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsType> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T ScrollViewer_HorizontalSnapPointsType<T>(this T control, IObservable<Avalonia.Controls.Primitives.SnapPointsType> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T ScrollViewer_HorizontalSnapPointsType<T>(this T control, ISubject<Avalonia.Controls.Primitives.SnapPointsType> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T ScrollViewer_HorizontalSnapPointsType<T>(this T control, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty!, value);
    return control;
}


 // VerticalSnapPointsType

/*AttachedPropertyFuncGenerator*/
public static T ScrollViewer_VerticalSnapPointsType<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsType> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T ScrollViewer_VerticalSnapPointsType<T>(this T control, IObservable<Avalonia.Controls.Primitives.SnapPointsType> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T ScrollViewer_VerticalSnapPointsType<T>(this T control, ISubject<Avalonia.Controls.Primitives.SnapPointsType> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T ScrollViewer_VerticalSnapPointsType<T>(this T control, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty!, value);
    return control;
}


 // HorizontalSnapPointsAlignment

/*AttachedPropertyFuncGenerator*/
public static T ScrollViewer_HorizontalSnapPointsAlignment<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsAlignment> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T ScrollViewer_HorizontalSnapPointsAlignment<T>(this T control, IObservable<Avalonia.Controls.Primitives.SnapPointsAlignment> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T ScrollViewer_HorizontalSnapPointsAlignment<T>(this T control, ISubject<Avalonia.Controls.Primitives.SnapPointsAlignment> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T ScrollViewer_HorizontalSnapPointsAlignment<T>(this T control, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty!, value);
    return control;
}


 // VerticalSnapPointsAlignment

/*AttachedPropertyFuncGenerator*/
public static T ScrollViewer_VerticalSnapPointsAlignment<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsAlignment> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T ScrollViewer_VerticalSnapPointsAlignment<T>(this T control, IObservable<Avalonia.Controls.Primitives.SnapPointsAlignment> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T ScrollViewer_VerticalSnapPointsAlignment<T>(this T control, ISubject<Avalonia.Controls.Primitives.SnapPointsAlignment> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T ScrollViewer_VerticalSnapPointsAlignment<T>(this T control, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty!, value);
    return control;
}


 // VerticalScrollBarVisibility

/*AttachedPropertyFuncGenerator*/
public static T ScrollViewer_VerticalScrollBarVisibility<T>(this T control, Func<Avalonia.Controls.Primitives.ScrollBarVisibility> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T ScrollViewer_VerticalScrollBarVisibility<T>(this T control, IObservable<Avalonia.Controls.Primitives.ScrollBarVisibility> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T ScrollViewer_VerticalScrollBarVisibility<T>(this T control, ISubject<Avalonia.Controls.Primitives.ScrollBarVisibility> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T ScrollViewer_VerticalScrollBarVisibility<T>(this T control, Avalonia.Controls.Primitives.ScrollBarVisibility value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty!, value);
    return control;
}


 // AllowAutoHide

/*AttachedPropertyFuncGenerator*/
public static T ScrollViewer_AllowAutoHide<T>(this T control, Func<System.Boolean> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T ScrollViewer_AllowAutoHide<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T ScrollViewer_AllowAutoHide<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T ScrollViewer_AllowAutoHide<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty!, value);
    return control;
}


 // IsScrollChainingEnabled

/*AttachedPropertyFuncGenerator*/
public static T ScrollViewer_IsScrollChainingEnabled<T>(this T control, Func<System.Boolean> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T ScrollViewer_IsScrollChainingEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T ScrollViewer_IsScrollChainingEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T ScrollViewer_IsScrollChainingEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty!, value);
    return control;
}


 // IsScrollInertiaEnabled

/*AttachedPropertyFuncGenerator*/
public static T ScrollViewer_IsScrollInertiaEnabled<T>(this T control, Func<System.Boolean> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T ScrollViewer_IsScrollInertiaEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T ScrollViewer_IsScrollInertiaEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T ScrollViewer_IsScrollInertiaEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty!, value);
    return control;
}


 // IsDeferredScrollingEnabled

/*AttachedPropertyFuncGenerator*/
public static T ScrollViewer_IsDeferredScrollingEnabled<T>(this T control, Func<System.Boolean> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T ScrollViewer_IsDeferredScrollingEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T ScrollViewer_IsDeferredScrollingEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T ScrollViewer_IsDeferredScrollingEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty!, value);
    return control;
}



//================= Events ======================//
 // ScrollChanged

/*ActionToEventGenerator*/
public static T OnScrollChanged<T>(this T control, Action<Avalonia.Controls.ScrollChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.ScrollViewer 
{
  control.AddHandler(Avalonia.Controls.ScrollViewer.ScrollChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.ScrollViewer.ScrollChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // BringIntoViewOnFocusChange

/*ValueStyleSetterGenerator*/
public static Style<T> BringIntoViewOnFocusChange<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BringIntoViewOnFocusChange<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty, binding);


 // Offset

/*ValueStyleSetterGenerator*/
public static Style<T> Offset<T>(this Style<T> style, Avalonia.Vector value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.OffsetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Offset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.OffsetProperty, binding);


 // HorizontalScrollBarVisibility

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalScrollBarVisibility<T>(this Style<T> style, Avalonia.Controls.Primitives.ScrollBarVisibility value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalScrollBarVisibility<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty, binding);


 // HorizontalSnapPointsType

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsType<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty, binding);


 // VerticalSnapPointsType

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsType<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty, binding);


 // HorizontalSnapPointsAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsAlignment<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty, binding);


 // VerticalSnapPointsAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsAlignment<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty, binding);


 // VerticalScrollBarVisibility

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalScrollBarVisibility<T>(this Style<T> style, Avalonia.Controls.Primitives.ScrollBarVisibility value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalScrollBarVisibility<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty, binding);


 // AllowAutoHide

/*ValueStyleSetterGenerator*/
public static Style<T> AllowAutoHide<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AllowAutoHide<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty, binding);


 // IsScrollChainingEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsScrollChainingEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsScrollChainingEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty, binding);


 // IsScrollInertiaEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsScrollInertiaEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsScrollInertiaEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty, binding);


 // IsDeferredScrollingEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsDeferredScrollingEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDeferredScrollingEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty, binding);



}

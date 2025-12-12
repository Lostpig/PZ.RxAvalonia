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
public static partial class ScrollContentPresenter_MarkupExtensions
{
//================= Properties ======================//
 // CanHorizontallyScroll

/*ValueSetterGenerator*/
public static T CanHorizontallyScroll<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
{
    control.CanHorizontallyScroll = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CanHorizontallyScroll<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.CanHorizontallyScrollProperty!, func);

/*SetterFromObservableGenerator*/
public static T CanHorizontallyScroll<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.CanHorizontallyScrollProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CanHorizontallyScroll<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.CanHorizontallyScrollProperty!, subject);


 // CanVerticallyScroll

/*ValueSetterGenerator*/
public static T CanVerticallyScroll<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
{
    control.CanVerticallyScroll = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CanVerticallyScroll<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.CanVerticallyScrollProperty!, func);

/*SetterFromObservableGenerator*/
public static T CanVerticallyScroll<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.CanVerticallyScrollProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CanVerticallyScroll<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.CanVerticallyScrollProperty!, subject);


 // Offset

/*ValueSetterGenerator*/
public static T Offset<T>(this T control, Avalonia.Vector value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
{
    control.Offset = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Offset<T>(this T control, Func<Avalonia.Vector> func) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.OffsetProperty!, func);

/*SetterFromObservableGenerator*/
public static T Offset<T>(this T control, IObservable<Avalonia.Vector> obs) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.OffsetProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Offset<T>(this T control, ISubject<Avalonia.Vector> subject) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.OffsetProperty!, subject);


 // HorizontalSnapPointsType

/*ValueSetterGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
{
    control.HorizontalSnapPointsType = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsType> func) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsTypeProperty!, func);

/*SetterFromObservableGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, IObservable<Avalonia.Controls.Primitives.SnapPointsType> obs) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsTypeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, ISubject<Avalonia.Controls.Primitives.SnapPointsType> subject) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsTypeProperty!, subject);


 // VerticalSnapPointsType

/*ValueSetterGenerator*/
public static T VerticalSnapPointsType<T>(this T control, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
{
    control.VerticalSnapPointsType = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T VerticalSnapPointsType<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsType> func) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsTypeProperty!, func);

/*SetterFromObservableGenerator*/
public static T VerticalSnapPointsType<T>(this T control, IObservable<Avalonia.Controls.Primitives.SnapPointsType> obs) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsTypeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T VerticalSnapPointsType<T>(this T control, ISubject<Avalonia.Controls.Primitives.SnapPointsType> subject) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsTypeProperty!, subject);


 // HorizontalSnapPointsAlignment

/*ValueSetterGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
{
    control.HorizontalSnapPointsAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsAlignment> func) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, IObservable<Avalonia.Controls.Primitives.SnapPointsAlignment> obs) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, ISubject<Avalonia.Controls.Primitives.SnapPointsAlignment> subject) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty!, subject);


 // VerticalSnapPointsAlignment

/*ValueSetterGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
{
    control.VerticalSnapPointsAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsAlignment> func) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, IObservable<Avalonia.Controls.Primitives.SnapPointsAlignment> obs) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, ISubject<Avalonia.Controls.Primitives.SnapPointsAlignment> subject) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsAlignmentProperty!, subject);


 // IsScrollChainingEnabled

/*ValueSetterGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
{
    control.IsScrollChainingEnabled = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.IsScrollChainingEnabledProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.IsScrollChainingEnabledProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.IsScrollChainingEnabledProperty!, subject);



//================= Styles ======================//
 // CanHorizontallyScroll

/*ValueStyleSetterGenerator*/
public static Style<T> CanHorizontallyScroll<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.CanHorizontallyScrollProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CanHorizontallyScroll<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.CanHorizontallyScrollProperty, binding);


 // CanVerticallyScroll

/*ValueStyleSetterGenerator*/
public static Style<T> CanVerticallyScroll<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.CanVerticallyScrollProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CanVerticallyScroll<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.CanVerticallyScrollProperty, binding);


 // Offset

/*ValueStyleSetterGenerator*/
public static Style<T> Offset<T>(this Style<T> style, Avalonia.Vector value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.OffsetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Offset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.OffsetProperty, binding);


 // HorizontalSnapPointsType

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsType<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsTypeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsTypeProperty, binding);


 // VerticalSnapPointsType

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsType<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsTypeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsTypeProperty, binding);


 // HorizontalSnapPointsAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsAlignment<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, binding);


 // VerticalSnapPointsAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsAlignment<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, binding);


 // IsScrollChainingEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsScrollChainingEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.IsScrollChainingEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsScrollChainingEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.IsScrollChainingEnabledProperty, binding);



}

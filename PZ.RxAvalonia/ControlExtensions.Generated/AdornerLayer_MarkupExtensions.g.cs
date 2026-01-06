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
public static partial class AdornerLayer_MarkupExtensions
{
//================= Properties ======================//
 // DefaultFocusAdorner

/*ValueSetterGenerator*/
public static T DefaultFocusAdorner<T>(this T control, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value) where T : Avalonia.Controls.Primitives.AdornerLayer 
{
    control.DefaultFocusAdorner = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DefaultFocusAdorner<T>(this T control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> func) where T : Avalonia.Controls.Primitives.AdornerLayer 
   => control._set(Avalonia.Controls.Primitives.AdornerLayer.DefaultFocusAdornerProperty!, func);

/*SetterFromObservableGenerator*/
public static T DefaultFocusAdorner<T>(this T control, IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> obs) where T : Avalonia.Controls.Primitives.AdornerLayer 
   => control._set(Avalonia.Controls.Primitives.AdornerLayer.DefaultFocusAdornerProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DefaultFocusAdorner<T>(this T control, ISubject<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> subject) where T : Avalonia.Controls.Primitives.AdornerLayer 
   => control._set(Avalonia.Controls.Primitives.AdornerLayer.DefaultFocusAdornerProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DefaultFocusAdorner<T>(this T control, IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> obs, IObserver<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> changed) where T : Avalonia.Controls.Primitives.AdornerLayer 
   => control._setEx(Avalonia.Controls.Primitives.AdornerLayer.DefaultFocusAdornerProperty!, obs, changed);



//================= Attached Properties ======================//
 // AdornedElement

/*AttachedPropertyFuncGenerator*/
public static T AdornerLayer_AdornedElement<T>(this T control, Func<Avalonia.Visual?> getter) where T : Avalonia.Visual 
   => control._set(Avalonia.Controls.Primitives.AdornerLayer.AdornedElementProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T AdornerLayer_AdornedElement<T>(this T control, IObservable<Avalonia.Visual?> obs) where T : Avalonia.Visual 
   => control._set(Avalonia.Controls.Primitives.AdornerLayer.AdornedElementProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T AdornerLayer_AdornedElement<T>(this T control, ISubject<Avalonia.Visual?> subject) where T : Avalonia.Visual 
   => control._set(Avalonia.Controls.Primitives.AdornerLayer.AdornedElementProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T AdornerLayer_AdornedElement<T>(this T control, Avalonia.Visual? value) where T : Avalonia.Visual 
{
    control.SetValue(Avalonia.Controls.Primitives.AdornerLayer.AdornedElementProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T AdornerLayer_AdornedElement<T>(this T control, IObservable<Avalonia.Visual?> obs, IObserver<Avalonia.Visual?> changed) where T : Avalonia.Visual 
   => control._setEx(Avalonia.Controls.Primitives.AdornerLayer.AdornedElementProperty!, obs, changed);


 // IsClipEnabled

/*AttachedPropertyFuncGenerator*/
public static T AdornerLayer_IsClipEnabled<T>(this T control, Func<System.Boolean> getter) where T : Avalonia.Visual 
   => control._set(Avalonia.Controls.Primitives.AdornerLayer.IsClipEnabledProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T AdornerLayer_IsClipEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Visual 
   => control._set(Avalonia.Controls.Primitives.AdornerLayer.IsClipEnabledProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T AdornerLayer_IsClipEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Visual 
   => control._set(Avalonia.Controls.Primitives.AdornerLayer.IsClipEnabledProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T AdornerLayer_IsClipEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Visual 
{
    control.SetValue(Avalonia.Controls.Primitives.AdornerLayer.IsClipEnabledProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T AdornerLayer_IsClipEnabled<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Visual 
   => control._setEx(Avalonia.Controls.Primitives.AdornerLayer.IsClipEnabledProperty!, obs, changed);


 // Adorner

/*AttachedPropertyFuncGenerator*/
public static T AdornerLayer_Adorner<T>(this T control, Func<Avalonia.Controls.Control?> getter) where T : Avalonia.Visual 
   => control._set(Avalonia.Controls.Primitives.AdornerLayer.AdornerProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T AdornerLayer_Adorner<T>(this T control, IObservable<Avalonia.Controls.Control?> obs) where T : Avalonia.Visual 
   => control._set(Avalonia.Controls.Primitives.AdornerLayer.AdornerProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T AdornerLayer_Adorner<T>(this T control, ISubject<Avalonia.Controls.Control?> subject) where T : Avalonia.Visual 
   => control._set(Avalonia.Controls.Primitives.AdornerLayer.AdornerProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T AdornerLayer_Adorner<T>(this T control, Avalonia.Controls.Control? value) where T : Avalonia.Visual 
{
    control.SetValue(Avalonia.Controls.Primitives.AdornerLayer.AdornerProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T AdornerLayer_Adorner<T>(this T control, IObservable<Avalonia.Controls.Control?> obs, IObserver<Avalonia.Controls.Control?> changed) where T : Avalonia.Visual 
   => control._setEx(Avalonia.Controls.Primitives.AdornerLayer.AdornerProperty!, obs, changed);



//================= Styles ======================//
 // DefaultFocusAdorner

/*ValueStyleSetterGenerator*/
public static Style<T> DefaultFocusAdorner<T>(this Style<T> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value) where T : Avalonia.Controls.Primitives.AdornerLayer 
=> style._addSetter(Avalonia.Controls.Primitives.AdornerLayer.DefaultFocusAdornerProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DefaultFocusAdorner<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.AdornerLayer 
=> style._addSetter(Avalonia.Controls.Primitives.AdornerLayer.DefaultFocusAdornerProperty, binding);



}

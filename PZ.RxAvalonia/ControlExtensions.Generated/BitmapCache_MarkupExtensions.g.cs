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
public static partial class BitmapCache_MarkupExtensions
{
//================= Properties ======================//
 // RenderAtScale

/*ValueSetterGenerator*/
public static T RenderAtScale<T>(this T control, System.Double value) where T : Avalonia.Media.BitmapCache 
{
    control.RenderAtScale = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T RenderAtScale<T>(this T control, Func<System.Double> func) where T : Avalonia.Media.BitmapCache 
   => control._set(Avalonia.Media.BitmapCache.RenderAtScaleProperty!, func);

/*SetterFromObservableGenerator*/
public static T RenderAtScale<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Media.BitmapCache 
   => control._set(Avalonia.Media.BitmapCache.RenderAtScaleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T RenderAtScale<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Media.BitmapCache 
   => control._set(Avalonia.Media.BitmapCache.RenderAtScaleProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T RenderAtScale<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Media.BitmapCache 
   => control._setEx(Avalonia.Media.BitmapCache.RenderAtScaleProperty!, obs, changed);


 // SnapsToDevicePixels

/*ValueSetterGenerator*/
public static T SnapsToDevicePixels<T>(this T control, System.Boolean value) where T : Avalonia.Media.BitmapCache 
{
    control.SnapsToDevicePixels = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SnapsToDevicePixels<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Media.BitmapCache 
   => control._set(Avalonia.Media.BitmapCache.SnapsToDevicePixelsProperty!, func);

/*SetterFromObservableGenerator*/
public static T SnapsToDevicePixels<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Media.BitmapCache 
   => control._set(Avalonia.Media.BitmapCache.SnapsToDevicePixelsProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SnapsToDevicePixels<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Media.BitmapCache 
   => control._set(Avalonia.Media.BitmapCache.SnapsToDevicePixelsProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SnapsToDevicePixels<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Media.BitmapCache 
   => control._setEx(Avalonia.Media.BitmapCache.SnapsToDevicePixelsProperty!, obs, changed);


 // EnableClearType

/*ValueSetterGenerator*/
public static T EnableClearType<T>(this T control, System.Boolean value) where T : Avalonia.Media.BitmapCache 
{
    control.EnableClearType = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T EnableClearType<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Media.BitmapCache 
   => control._set(Avalonia.Media.BitmapCache.EnableClearTypeProperty!, func);

/*SetterFromObservableGenerator*/
public static T EnableClearType<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Media.BitmapCache 
   => control._set(Avalonia.Media.BitmapCache.EnableClearTypeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T EnableClearType<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Media.BitmapCache 
   => control._set(Avalonia.Media.BitmapCache.EnableClearTypeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T EnableClearType<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Media.BitmapCache 
   => control._setEx(Avalonia.Media.BitmapCache.EnableClearTypeProperty!, obs, changed);



//================= Styles ======================//
 // RenderAtScale

/*ValueStyleSetterGenerator*/
public static Style<T> RenderAtScale<T>(this Style<T> style, System.Double value) where T : Avalonia.Media.BitmapCache 
=> style._addSetter(Avalonia.Media.BitmapCache.RenderAtScaleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RenderAtScale<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Media.BitmapCache 
=> style._addSetter(Avalonia.Media.BitmapCache.RenderAtScaleProperty, binding);


 // SnapsToDevicePixels

/*ValueStyleSetterGenerator*/
public static Style<T> SnapsToDevicePixels<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Media.BitmapCache 
=> style._addSetter(Avalonia.Media.BitmapCache.SnapsToDevicePixelsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SnapsToDevicePixels<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Media.BitmapCache 
=> style._addSetter(Avalonia.Media.BitmapCache.SnapsToDevicePixelsProperty, binding);


 // EnableClearType

/*ValueStyleSetterGenerator*/
public static Style<T> EnableClearType<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Media.BitmapCache 
=> style._addSetter(Avalonia.Media.BitmapCache.EnableClearTypeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> EnableClearType<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Media.BitmapCache 
=> style._addSetter(Avalonia.Media.BitmapCache.EnableClearTypeProperty, binding);



}

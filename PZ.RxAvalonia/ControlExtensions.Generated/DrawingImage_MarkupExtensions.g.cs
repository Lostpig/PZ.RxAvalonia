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
public static partial class DrawingImage_MarkupExtensions
{
//================= Properties ======================//
 // Drawing

/*ValueSetterGenerator*/
public static T Drawing<T>(this T control, Avalonia.Media.Drawing? value) where T : Avalonia.Media.DrawingImage 
{
    control.Drawing = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Drawing<T>(this T control, Func<Avalonia.Media.Drawing?> func) where T : Avalonia.Media.DrawingImage 
   => control._set(Avalonia.Media.DrawingImage.DrawingProperty!, func);

/*SetterFromObservableGenerator*/
public static T Drawing<T>(this T control, IObservable<Avalonia.Media.Drawing?> obs) where T : Avalonia.Media.DrawingImage 
   => control._set(Avalonia.Media.DrawingImage.DrawingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Drawing<T>(this T control, ISubject<Avalonia.Media.Drawing?> subject) where T : Avalonia.Media.DrawingImage 
   => control._set(Avalonia.Media.DrawingImage.DrawingProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Drawing<T>(this T control, IObservable<Avalonia.Media.Drawing?> obs, IObserver<Avalonia.Media.Drawing?> changed) where T : Avalonia.Media.DrawingImage 
   => control._setEx(Avalonia.Media.DrawingImage.DrawingProperty!, obs, changed);



//================= Events ======================//
 // Invalidated

/*ActionToEventGenerator*/
public static T OnInvalidated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Media.DrawingImage  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Invalidated += h);

/*ReactiveEventGenerator*/
public static T RxInvalidated<T>(this T control, IObserver<System.EventArgs> observer) where T : Avalonia.Media.DrawingImage  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => observer.OnNext((arg1))), h => control.Invalidated += h);



}

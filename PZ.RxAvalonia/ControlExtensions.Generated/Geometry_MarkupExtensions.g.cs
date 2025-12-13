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
public static partial class Geometry_MarkupExtensions
{
//================= Properties ======================//
 // Transform

/*ValueSetterGenerator*/
public static T Transform<T>(this T control, Avalonia.Media.Transform value) where T : Avalonia.Media.Geometry 
{
    control.Transform = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Transform<T>(this T control, Func<Avalonia.Media.Transform> func) where T : Avalonia.Media.Geometry 
   => control._set(Avalonia.Media.Geometry.TransformProperty!, func);

/*SetterFromObservableGenerator*/
public static T Transform<T>(this T control, IObservable<Avalonia.Media.Transform> obs) where T : Avalonia.Media.Geometry 
   => control._set(Avalonia.Media.Geometry.TransformProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Transform<T>(this T control, ISubject<Avalonia.Media.Transform> subject) where T : Avalonia.Media.Geometry 
   => control._set(Avalonia.Media.Geometry.TransformProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Transform<T>(this T control, IObservable<Avalonia.Media.Transform> obs, IObserver<Avalonia.Media.Transform> changed) where T : Avalonia.Media.Geometry 
   => control._setEx(Avalonia.Media.Geometry.TransformProperty!, obs, changed);



//================= Events ======================//
 // Changed

/*ActionToEventGenerator*/
public static T OnChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Media.Geometry  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Changed += h);



}

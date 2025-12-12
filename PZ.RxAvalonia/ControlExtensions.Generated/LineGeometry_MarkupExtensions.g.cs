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
public static partial class LineGeometry_MarkupExtensions
{
//================= Properties ======================//
 // StartPoint

/*ValueSetterGenerator*/
public static T StartPoint<T>(this T control, Avalonia.Point value) where T : Avalonia.Media.LineGeometry 
{
    control.StartPoint = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T StartPoint<T>(this T control, Func<Avalonia.Point> func) where T : Avalonia.Media.LineGeometry 
   => control._set(Avalonia.Media.LineGeometry.StartPointProperty!, func);

/*SetterFromObservableGenerator*/
public static T StartPoint<T>(this T control, IObservable<Avalonia.Point> obs) where T : Avalonia.Media.LineGeometry 
   => control._set(Avalonia.Media.LineGeometry.StartPointProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T StartPoint<T>(this T control, ISubject<Avalonia.Point> subject) where T : Avalonia.Media.LineGeometry 
   => control._set(Avalonia.Media.LineGeometry.StartPointProperty!, subject);


 // EndPoint

/*ValueSetterGenerator*/
public static T EndPoint<T>(this T control, Avalonia.Point value) where T : Avalonia.Media.LineGeometry 
{
    control.EndPoint = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T EndPoint<T>(this T control, Func<Avalonia.Point> func) where T : Avalonia.Media.LineGeometry 
   => control._set(Avalonia.Media.LineGeometry.EndPointProperty!, func);

/*SetterFromObservableGenerator*/
public static T EndPoint<T>(this T control, IObservable<Avalonia.Point> obs) where T : Avalonia.Media.LineGeometry 
   => control._set(Avalonia.Media.LineGeometry.EndPointProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T EndPoint<T>(this T control, ISubject<Avalonia.Point> subject) where T : Avalonia.Media.LineGeometry 
   => control._set(Avalonia.Media.LineGeometry.EndPointProperty!, subject);



}

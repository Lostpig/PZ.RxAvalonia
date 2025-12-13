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
public static partial class PathSegment_MarkupExtensions
{
//================= Properties ======================//
 // IsStroked

/*ValueSetterGenerator*/
public static T IsStroked<T>(this T control, System.Boolean value) where T : Avalonia.Media.PathSegment 
{
    control.IsStroked = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsStroked<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Media.PathSegment 
   => control._set(Avalonia.Media.PathSegment.IsStrokedProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsStroked<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Media.PathSegment 
   => control._set(Avalonia.Media.PathSegment.IsStrokedProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsStroked<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Media.PathSegment 
   => control._set(Avalonia.Media.PathSegment.IsStrokedProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsStroked<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Media.PathSegment 
   => control._setEx(Avalonia.Media.PathSegment.IsStrokedProperty!, obs, changed);



}

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
public static partial class TransformGroup_MarkupExtensions
{
//================= Properties ======================//
 // Children

/*ValueSetterGenerator*/
public static Avalonia.Media.TransformGroup Children(this Avalonia.Media.TransformGroup control, Avalonia.Media.Transforms value)  
{
    control.Children = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.TransformGroup Children(this Avalonia.Media.TransformGroup control, Func<Avalonia.Media.Transforms> func)  
   => control._set(Avalonia.Media.TransformGroup.ChildrenProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.TransformGroup Children(this Avalonia.Media.TransformGroup control, IObservable<Avalonia.Media.Transforms> obs)  
   => control._set(Avalonia.Media.TransformGroup.ChildrenProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.TransformGroup Children(this Avalonia.Media.TransformGroup control, ISubject<Avalonia.Media.Transforms> subject)  
   => control._set(Avalonia.Media.TransformGroup.ChildrenProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.TransformGroup Children(this Avalonia.Media.TransformGroup control, IObservable<Avalonia.Media.Transforms> obs, IObserver<Avalonia.Media.Transforms> changed)  
   => control._setEx(Avalonia.Media.TransformGroup.ChildrenProperty!, obs, changed);



}

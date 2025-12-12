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
public static partial class GeometryGroup_MarkupExtensions
{
//================= Properties ======================//
 // Children

/*ValueSetterGenerator*/
public static T Children<T>(this T control, Avalonia.Media.GeometryCollection value) where T : Avalonia.Media.GeometryGroup 
{
    control.Children = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Children<T>(this T control, Func<Avalonia.Media.GeometryCollection> func) where T : Avalonia.Media.GeometryGroup 
   => control._set(Avalonia.Media.GeometryGroup.ChildrenProperty!, func);

/*SetterFromObservableGenerator*/
public static T Children<T>(this T control, IObservable<Avalonia.Media.GeometryCollection> obs) where T : Avalonia.Media.GeometryGroup 
   => control._set(Avalonia.Media.GeometryGroup.ChildrenProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Children<T>(this T control, ISubject<Avalonia.Media.GeometryCollection> subject) where T : Avalonia.Media.GeometryGroup 
   => control._set(Avalonia.Media.GeometryGroup.ChildrenProperty!, subject);


 // FillRule

/*ValueSetterGenerator*/
public static T FillRule<T>(this T control, Avalonia.Media.FillRule value) where T : Avalonia.Media.GeometryGroup 
{
    control.FillRule = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FillRule<T>(this T control, Func<Avalonia.Media.FillRule> func) where T : Avalonia.Media.GeometryGroup 
   => control._set(Avalonia.Media.GeometryGroup.FillRuleProperty!, func);

/*SetterFromObservableGenerator*/
public static T FillRule<T>(this T control, IObservable<Avalonia.Media.FillRule> obs) where T : Avalonia.Media.GeometryGroup 
   => control._set(Avalonia.Media.GeometryGroup.FillRuleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FillRule<T>(this T control, ISubject<Avalonia.Media.FillRule> subject) where T : Avalonia.Media.GeometryGroup 
   => control._set(Avalonia.Media.GeometryGroup.FillRuleProperty!, subject);



}

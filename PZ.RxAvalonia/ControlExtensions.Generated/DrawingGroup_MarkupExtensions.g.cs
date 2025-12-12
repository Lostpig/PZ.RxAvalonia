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
public static partial class DrawingGroup_MarkupExtensions
{
//================= Properties ======================//
 // Opacity

/*ValueSetterGenerator*/
public static Avalonia.Media.DrawingGroup Opacity(this Avalonia.Media.DrawingGroup control, System.Double value)  
{
    control.Opacity = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.DrawingGroup Opacity(this Avalonia.Media.DrawingGroup control, Func<System.Double> func)  
   => control._set(Avalonia.Media.DrawingGroup.OpacityProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.DrawingGroup Opacity(this Avalonia.Media.DrawingGroup control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Media.DrawingGroup.OpacityProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.DrawingGroup Opacity(this Avalonia.Media.DrawingGroup control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Media.DrawingGroup.OpacityProperty!, subject);


 // Transform

/*ValueSetterGenerator*/
public static Avalonia.Media.DrawingGroup Transform(this Avalonia.Media.DrawingGroup control, Avalonia.Media.Transform value)  
{
    control.Transform = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.DrawingGroup Transform(this Avalonia.Media.DrawingGroup control, Func<Avalonia.Media.Transform> func)  
   => control._set(Avalonia.Media.DrawingGroup.TransformProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.DrawingGroup Transform(this Avalonia.Media.DrawingGroup control, IObservable<Avalonia.Media.Transform> obs)  
   => control._set(Avalonia.Media.DrawingGroup.TransformProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.DrawingGroup Transform(this Avalonia.Media.DrawingGroup control, ISubject<Avalonia.Media.Transform> subject)  
   => control._set(Avalonia.Media.DrawingGroup.TransformProperty!, subject);


 // ClipGeometry

/*ValueSetterGenerator*/
public static Avalonia.Media.DrawingGroup ClipGeometry(this Avalonia.Media.DrawingGroup control, Avalonia.Media.Geometry value)  
{
    control.ClipGeometry = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.DrawingGroup ClipGeometry(this Avalonia.Media.DrawingGroup control, Func<Avalonia.Media.Geometry> func)  
   => control._set(Avalonia.Media.DrawingGroup.ClipGeometryProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.DrawingGroup ClipGeometry(this Avalonia.Media.DrawingGroup control, IObservable<Avalonia.Media.Geometry> obs)  
   => control._set(Avalonia.Media.DrawingGroup.ClipGeometryProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.DrawingGroup ClipGeometry(this Avalonia.Media.DrawingGroup control, ISubject<Avalonia.Media.Geometry> subject)  
   => control._set(Avalonia.Media.DrawingGroup.ClipGeometryProperty!, subject);


 // OpacityMask

/*ValueSetterGenerator*/
public static Avalonia.Media.DrawingGroup OpacityMask(this Avalonia.Media.DrawingGroup control, Avalonia.Media.IBrush value)  
{
    control.OpacityMask = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.DrawingGroup OpacityMask(this Avalonia.Media.DrawingGroup control, Func<Avalonia.Media.IBrush> func)  
   => control._set(Avalonia.Media.DrawingGroup.OpacityMaskProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.DrawingGroup OpacityMask(this Avalonia.Media.DrawingGroup control, IObservable<Avalonia.Media.IBrush> obs)  
   => control._set(Avalonia.Media.DrawingGroup.OpacityMaskProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.DrawingGroup OpacityMask(this Avalonia.Media.DrawingGroup control, ISubject<Avalonia.Media.IBrush> subject)  
   => control._set(Avalonia.Media.DrawingGroup.OpacityMaskProperty!, subject);


 // Children

/*ValueSetterGenerator*/
public static Avalonia.Media.DrawingGroup Children(this Avalonia.Media.DrawingGroup control, Avalonia.Media.DrawingCollection value)  
{
    control.Children = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.DrawingGroup Children(this Avalonia.Media.DrawingGroup control, Func<Avalonia.Media.DrawingCollection> func)  
   => control._set(Avalonia.Media.DrawingGroup.ChildrenProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.DrawingGroup Children(this Avalonia.Media.DrawingGroup control, IObservable<Avalonia.Media.DrawingCollection> obs)  
   => control._set(Avalonia.Media.DrawingGroup.ChildrenProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.DrawingGroup Children(this Avalonia.Media.DrawingGroup control, ISubject<Avalonia.Media.DrawingCollection> subject)  
   => control._set(Avalonia.Media.DrawingGroup.ChildrenProperty!, subject);



}

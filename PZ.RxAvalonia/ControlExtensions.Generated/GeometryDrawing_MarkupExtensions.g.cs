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
public static partial class GeometryDrawing_MarkupExtensions
{
//================= Properties ======================//
 // Geometry

/*ValueSetterGenerator*/
public static Avalonia.Media.GeometryDrawing Geometry(this Avalonia.Media.GeometryDrawing control, Avalonia.Media.Geometry value)  
{
    control.Geometry = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.GeometryDrawing Geometry(this Avalonia.Media.GeometryDrawing control, Func<Avalonia.Media.Geometry> func)  
   => control._set(Avalonia.Media.GeometryDrawing.GeometryProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.GeometryDrawing Geometry(this Avalonia.Media.GeometryDrawing control, IObservable<Avalonia.Media.Geometry> obs)  
   => control._set(Avalonia.Media.GeometryDrawing.GeometryProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.GeometryDrawing Geometry(this Avalonia.Media.GeometryDrawing control, ISubject<Avalonia.Media.Geometry> subject)  
   => control._set(Avalonia.Media.GeometryDrawing.GeometryProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.GeometryDrawing Geometry(this Avalonia.Media.GeometryDrawing control, IObservable<Avalonia.Media.Geometry> obs, IObserver<Avalonia.Media.Geometry> changed)  
   => control._setEx(Avalonia.Media.GeometryDrawing.GeometryProperty!, obs, changed);


 // Brush

/*ValueSetterGenerator*/
public static Avalonia.Media.GeometryDrawing Brush(this Avalonia.Media.GeometryDrawing control, Avalonia.Media.IBrush value)  
{
    control.Brush = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.GeometryDrawing Brush(this Avalonia.Media.GeometryDrawing control, Func<Avalonia.Media.IBrush> func)  
   => control._set(Avalonia.Media.GeometryDrawing.BrushProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.GeometryDrawing Brush(this Avalonia.Media.GeometryDrawing control, IObservable<Avalonia.Media.IBrush> obs)  
   => control._set(Avalonia.Media.GeometryDrawing.BrushProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.GeometryDrawing Brush(this Avalonia.Media.GeometryDrawing control, ISubject<Avalonia.Media.IBrush> subject)  
   => control._set(Avalonia.Media.GeometryDrawing.BrushProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.GeometryDrawing Brush(this Avalonia.Media.GeometryDrawing control, IObservable<Avalonia.Media.IBrush> obs, IObserver<Avalonia.Media.IBrush> changed)  
   => control._setEx(Avalonia.Media.GeometryDrawing.BrushProperty!, obs, changed);


 // Pen

/*ValueSetterGenerator*/
public static Avalonia.Media.GeometryDrawing Pen(this Avalonia.Media.GeometryDrawing control, Avalonia.Media.IPen value)  
{
    control.Pen = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.GeometryDrawing Pen(this Avalonia.Media.GeometryDrawing control, Func<Avalonia.Media.IPen> func)  
   => control._set(Avalonia.Media.GeometryDrawing.PenProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.GeometryDrawing Pen(this Avalonia.Media.GeometryDrawing control, IObservable<Avalonia.Media.IPen> obs)  
   => control._set(Avalonia.Media.GeometryDrawing.PenProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.GeometryDrawing Pen(this Avalonia.Media.GeometryDrawing control, ISubject<Avalonia.Media.IPen> subject)  
   => control._set(Avalonia.Media.GeometryDrawing.PenProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.GeometryDrawing Pen(this Avalonia.Media.GeometryDrawing control, IObservable<Avalonia.Media.IPen> obs, IObserver<Avalonia.Media.IPen> changed)  
   => control._setEx(Avalonia.Media.GeometryDrawing.PenProperty!, obs, changed);



}

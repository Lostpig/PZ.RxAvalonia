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
public static partial class RadialGradientBrush_MarkupExtensions
{
//================= Properties ======================//
 // Center

/*ValueSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush Center(this Avalonia.Media.RadialGradientBrush control, Avalonia.RelativePoint value)  
{
    control.Center = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Media.RadialGradientBrush Center(this Avalonia.Media.RadialGradientBrush control, System.Double x = default!, System.Double y = default!, Avalonia.RelativeUnit unit = default!)  
{
    control.Center = new Avalonia.RelativePoint(x, y, unit);
    return control;
}
public static Avalonia.Media.RadialGradientBrush Center(this Avalonia.Media.RadialGradientBrush control, Avalonia.Point point = default!, Avalonia.RelativeUnit unit = default!)  
{
    control.Center = new Avalonia.RelativePoint(point, unit);
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.RadialGradientBrush Center(this Avalonia.Media.RadialGradientBrush control, Func<Avalonia.RelativePoint> func)  
   => control._set(Avalonia.Media.RadialGradientBrush.CenterProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.RadialGradientBrush Center(this Avalonia.Media.RadialGradientBrush control, IObservable<Avalonia.RelativePoint> obs)  
   => control._set(Avalonia.Media.RadialGradientBrush.CenterProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.RadialGradientBrush Center(this Avalonia.Media.RadialGradientBrush control, ISubject<Avalonia.RelativePoint> subject)  
   => control._set(Avalonia.Media.RadialGradientBrush.CenterProperty!, subject);


 // GradientOrigin

/*ValueSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush GradientOrigin(this Avalonia.Media.RadialGradientBrush control, Avalonia.RelativePoint value)  
{
    control.GradientOrigin = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Media.RadialGradientBrush GradientOrigin(this Avalonia.Media.RadialGradientBrush control, System.Double x = default!, System.Double y = default!, Avalonia.RelativeUnit unit = default!)  
{
    control.GradientOrigin = new Avalonia.RelativePoint(x, y, unit);
    return control;
}
public static Avalonia.Media.RadialGradientBrush GradientOrigin(this Avalonia.Media.RadialGradientBrush control, Avalonia.Point point = default!, Avalonia.RelativeUnit unit = default!)  
{
    control.GradientOrigin = new Avalonia.RelativePoint(point, unit);
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.RadialGradientBrush GradientOrigin(this Avalonia.Media.RadialGradientBrush control, Func<Avalonia.RelativePoint> func)  
   => control._set(Avalonia.Media.RadialGradientBrush.GradientOriginProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.RadialGradientBrush GradientOrigin(this Avalonia.Media.RadialGradientBrush control, IObservable<Avalonia.RelativePoint> obs)  
   => control._set(Avalonia.Media.RadialGradientBrush.GradientOriginProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.RadialGradientBrush GradientOrigin(this Avalonia.Media.RadialGradientBrush control, ISubject<Avalonia.RelativePoint> subject)  
   => control._set(Avalonia.Media.RadialGradientBrush.GradientOriginProperty!, subject);


 // RadiusX

/*ValueSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush RadiusX(this Avalonia.Media.RadialGradientBrush control, Avalonia.RelativeScalar value)  
{
    control.RadiusX = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.RadialGradientBrush RadiusX(this Avalonia.Media.RadialGradientBrush control, Func<Avalonia.RelativeScalar> func)  
   => control._set(Avalonia.Media.RadialGradientBrush.RadiusXProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.RadialGradientBrush RadiusX(this Avalonia.Media.RadialGradientBrush control, IObservable<Avalonia.RelativeScalar> obs)  
   => control._set(Avalonia.Media.RadialGradientBrush.RadiusXProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.RadialGradientBrush RadiusX(this Avalonia.Media.RadialGradientBrush control, ISubject<Avalonia.RelativeScalar> subject)  
   => control._set(Avalonia.Media.RadialGradientBrush.RadiusXProperty!, subject);


 // RadiusY

/*ValueSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush RadiusY(this Avalonia.Media.RadialGradientBrush control, Avalonia.RelativeScalar value)  
{
    control.RadiusY = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.RadialGradientBrush RadiusY(this Avalonia.Media.RadialGradientBrush control, Func<Avalonia.RelativeScalar> func)  
   => control._set(Avalonia.Media.RadialGradientBrush.RadiusYProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.RadialGradientBrush RadiusY(this Avalonia.Media.RadialGradientBrush control, IObservable<Avalonia.RelativeScalar> obs)  
   => control._set(Avalonia.Media.RadialGradientBrush.RadiusYProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.RadialGradientBrush RadiusY(this Avalonia.Media.RadialGradientBrush control, ISubject<Avalonia.RelativeScalar> subject)  
   => control._set(Avalonia.Media.RadialGradientBrush.RadiusYProperty!, subject);



}

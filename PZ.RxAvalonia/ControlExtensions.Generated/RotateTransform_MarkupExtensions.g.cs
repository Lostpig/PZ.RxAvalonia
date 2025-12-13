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
public static partial class RotateTransform_MarkupExtensions
{
//================= Properties ======================//
 // Angle

/*ValueSetterGenerator*/
public static Avalonia.Media.RotateTransform Angle(this Avalonia.Media.RotateTransform control, System.Double value)  
{
    control.Angle = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.RotateTransform Angle(this Avalonia.Media.RotateTransform control, Func<System.Double> func)  
   => control._set(Avalonia.Media.RotateTransform.AngleProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.RotateTransform Angle(this Avalonia.Media.RotateTransform control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Media.RotateTransform.AngleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.RotateTransform Angle(this Avalonia.Media.RotateTransform control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Media.RotateTransform.AngleProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.RotateTransform Angle(this Avalonia.Media.RotateTransform control, IObservable<System.Double> obs, IObserver<System.Double> changed)  
   => control._setEx(Avalonia.Media.RotateTransform.AngleProperty!, obs, changed);


 // CenterX

/*ValueSetterGenerator*/
public static Avalonia.Media.RotateTransform CenterX(this Avalonia.Media.RotateTransform control, System.Double value)  
{
    control.CenterX = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.RotateTransform CenterX(this Avalonia.Media.RotateTransform control, Func<System.Double> func)  
   => control._set(Avalonia.Media.RotateTransform.CenterXProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.RotateTransform CenterX(this Avalonia.Media.RotateTransform control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Media.RotateTransform.CenterXProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.RotateTransform CenterX(this Avalonia.Media.RotateTransform control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Media.RotateTransform.CenterXProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.RotateTransform CenterX(this Avalonia.Media.RotateTransform control, IObservable<System.Double> obs, IObserver<System.Double> changed)  
   => control._setEx(Avalonia.Media.RotateTransform.CenterXProperty!, obs, changed);


 // CenterY

/*ValueSetterGenerator*/
public static Avalonia.Media.RotateTransform CenterY(this Avalonia.Media.RotateTransform control, System.Double value)  
{
    control.CenterY = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.RotateTransform CenterY(this Avalonia.Media.RotateTransform control, Func<System.Double> func)  
   => control._set(Avalonia.Media.RotateTransform.CenterYProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.RotateTransform CenterY(this Avalonia.Media.RotateTransform control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Media.RotateTransform.CenterYProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.RotateTransform CenterY(this Avalonia.Media.RotateTransform control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Media.RotateTransform.CenterYProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.RotateTransform CenterY(this Avalonia.Media.RotateTransform control, IObservable<System.Double> obs, IObserver<System.Double> changed)  
   => control._setEx(Avalonia.Media.RotateTransform.CenterYProperty!, obs, changed);



}

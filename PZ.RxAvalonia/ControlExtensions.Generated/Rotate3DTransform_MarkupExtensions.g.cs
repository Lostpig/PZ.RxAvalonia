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
public static partial class Rotate3DTransform_MarkupExtensions
{
//================= Properties ======================//
 // AngleX

/*ValueSetterGenerator*/
public static Avalonia.Media.Rotate3DTransform AngleX(this Avalonia.Media.Rotate3DTransform control, System.Double value)  
{
    control.AngleX = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.Rotate3DTransform AngleX(this Avalonia.Media.Rotate3DTransform control, Func<System.Double> func)  
   => control._set(Avalonia.Media.Rotate3DTransform.AngleXProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.Rotate3DTransform AngleX(this Avalonia.Media.Rotate3DTransform control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Media.Rotate3DTransform.AngleXProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.Rotate3DTransform AngleX(this Avalonia.Media.Rotate3DTransform control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Media.Rotate3DTransform.AngleXProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.Rotate3DTransform AngleX(this Avalonia.Media.Rotate3DTransform control, IObservable<System.Double> obs, IObserver<System.Double> changed)  
   => control._setEx(Avalonia.Media.Rotate3DTransform.AngleXProperty!, obs, changed);


 // AngleY

/*ValueSetterGenerator*/
public static Avalonia.Media.Rotate3DTransform AngleY(this Avalonia.Media.Rotate3DTransform control, System.Double value)  
{
    control.AngleY = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.Rotate3DTransform AngleY(this Avalonia.Media.Rotate3DTransform control, Func<System.Double> func)  
   => control._set(Avalonia.Media.Rotate3DTransform.AngleYProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.Rotate3DTransform AngleY(this Avalonia.Media.Rotate3DTransform control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Media.Rotate3DTransform.AngleYProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.Rotate3DTransform AngleY(this Avalonia.Media.Rotate3DTransform control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Media.Rotate3DTransform.AngleYProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.Rotate3DTransform AngleY(this Avalonia.Media.Rotate3DTransform control, IObservable<System.Double> obs, IObserver<System.Double> changed)  
   => control._setEx(Avalonia.Media.Rotate3DTransform.AngleYProperty!, obs, changed);


 // AngleZ

/*ValueSetterGenerator*/
public static Avalonia.Media.Rotate3DTransform AngleZ(this Avalonia.Media.Rotate3DTransform control, System.Double value)  
{
    control.AngleZ = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.Rotate3DTransform AngleZ(this Avalonia.Media.Rotate3DTransform control, Func<System.Double> func)  
   => control._set(Avalonia.Media.Rotate3DTransform.AngleZProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.Rotate3DTransform AngleZ(this Avalonia.Media.Rotate3DTransform control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Media.Rotate3DTransform.AngleZProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.Rotate3DTransform AngleZ(this Avalonia.Media.Rotate3DTransform control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Media.Rotate3DTransform.AngleZProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.Rotate3DTransform AngleZ(this Avalonia.Media.Rotate3DTransform control, IObservable<System.Double> obs, IObserver<System.Double> changed)  
   => control._setEx(Avalonia.Media.Rotate3DTransform.AngleZProperty!, obs, changed);


 // CenterX

/*ValueSetterGenerator*/
public static Avalonia.Media.Rotate3DTransform CenterX(this Avalonia.Media.Rotate3DTransform control, System.Double value)  
{
    control.CenterX = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.Rotate3DTransform CenterX(this Avalonia.Media.Rotate3DTransform control, Func<System.Double> func)  
   => control._set(Avalonia.Media.Rotate3DTransform.CenterXProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.Rotate3DTransform CenterX(this Avalonia.Media.Rotate3DTransform control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Media.Rotate3DTransform.CenterXProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.Rotate3DTransform CenterX(this Avalonia.Media.Rotate3DTransform control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Media.Rotate3DTransform.CenterXProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.Rotate3DTransform CenterX(this Avalonia.Media.Rotate3DTransform control, IObservable<System.Double> obs, IObserver<System.Double> changed)  
   => control._setEx(Avalonia.Media.Rotate3DTransform.CenterXProperty!, obs, changed);


 // CenterY

/*ValueSetterGenerator*/
public static Avalonia.Media.Rotate3DTransform CenterY(this Avalonia.Media.Rotate3DTransform control, System.Double value)  
{
    control.CenterY = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.Rotate3DTransform CenterY(this Avalonia.Media.Rotate3DTransform control, Func<System.Double> func)  
   => control._set(Avalonia.Media.Rotate3DTransform.CenterYProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.Rotate3DTransform CenterY(this Avalonia.Media.Rotate3DTransform control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Media.Rotate3DTransform.CenterYProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.Rotate3DTransform CenterY(this Avalonia.Media.Rotate3DTransform control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Media.Rotate3DTransform.CenterYProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.Rotate3DTransform CenterY(this Avalonia.Media.Rotate3DTransform control, IObservable<System.Double> obs, IObserver<System.Double> changed)  
   => control._setEx(Avalonia.Media.Rotate3DTransform.CenterYProperty!, obs, changed);


 // CenterZ

/*ValueSetterGenerator*/
public static Avalonia.Media.Rotate3DTransform CenterZ(this Avalonia.Media.Rotate3DTransform control, System.Double value)  
{
    control.CenterZ = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.Rotate3DTransform CenterZ(this Avalonia.Media.Rotate3DTransform control, Func<System.Double> func)  
   => control._set(Avalonia.Media.Rotate3DTransform.CenterZProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.Rotate3DTransform CenterZ(this Avalonia.Media.Rotate3DTransform control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Media.Rotate3DTransform.CenterZProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.Rotate3DTransform CenterZ(this Avalonia.Media.Rotate3DTransform control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Media.Rotate3DTransform.CenterZProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.Rotate3DTransform CenterZ(this Avalonia.Media.Rotate3DTransform control, IObservable<System.Double> obs, IObserver<System.Double> changed)  
   => control._setEx(Avalonia.Media.Rotate3DTransform.CenterZProperty!, obs, changed);


 // Depth

/*ValueSetterGenerator*/
public static Avalonia.Media.Rotate3DTransform Depth(this Avalonia.Media.Rotate3DTransform control, System.Double value)  
{
    control.Depth = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.Rotate3DTransform Depth(this Avalonia.Media.Rotate3DTransform control, Func<System.Double> func)  
   => control._set(Avalonia.Media.Rotate3DTransform.DepthProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.Rotate3DTransform Depth(this Avalonia.Media.Rotate3DTransform control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Media.Rotate3DTransform.DepthProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.Rotate3DTransform Depth(this Avalonia.Media.Rotate3DTransform control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Media.Rotate3DTransform.DepthProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.Rotate3DTransform Depth(this Avalonia.Media.Rotate3DTransform control, IObservable<System.Double> obs, IObserver<System.Double> changed)  
   => control._setEx(Avalonia.Media.Rotate3DTransform.DepthProperty!, obs, changed);



}

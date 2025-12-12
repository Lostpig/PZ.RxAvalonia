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
public static partial class SkewTransform_MarkupExtensions
{
//================= Properties ======================//
 // AngleX

/*ValueSetterGenerator*/
public static Avalonia.Media.SkewTransform AngleX(this Avalonia.Media.SkewTransform control, System.Double value)  
{
    control.AngleX = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.SkewTransform AngleX(this Avalonia.Media.SkewTransform control, Func<System.Double> func)  
   => control._set(Avalonia.Media.SkewTransform.AngleXProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.SkewTransform AngleX(this Avalonia.Media.SkewTransform control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Media.SkewTransform.AngleXProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.SkewTransform AngleX(this Avalonia.Media.SkewTransform control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Media.SkewTransform.AngleXProperty!, subject);


 // AngleY

/*ValueSetterGenerator*/
public static Avalonia.Media.SkewTransform AngleY(this Avalonia.Media.SkewTransform control, System.Double value)  
{
    control.AngleY = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.SkewTransform AngleY(this Avalonia.Media.SkewTransform control, Func<System.Double> func)  
   => control._set(Avalonia.Media.SkewTransform.AngleYProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.SkewTransform AngleY(this Avalonia.Media.SkewTransform control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Media.SkewTransform.AngleYProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.SkewTransform AngleY(this Avalonia.Media.SkewTransform control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Media.SkewTransform.AngleYProperty!, subject);



}

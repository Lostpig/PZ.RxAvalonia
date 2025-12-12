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
public static partial class ScaleTransform_MarkupExtensions
{
//================= Properties ======================//
 // ScaleX

/*ValueSetterGenerator*/
public static Avalonia.Media.ScaleTransform ScaleX(this Avalonia.Media.ScaleTransform control, System.Double value)  
{
    control.ScaleX = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.ScaleTransform ScaleX(this Avalonia.Media.ScaleTransform control, Func<System.Double> func)  
   => control._set(Avalonia.Media.ScaleTransform.ScaleXProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.ScaleTransform ScaleX(this Avalonia.Media.ScaleTransform control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Media.ScaleTransform.ScaleXProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.ScaleTransform ScaleX(this Avalonia.Media.ScaleTransform control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Media.ScaleTransform.ScaleXProperty!, subject);


 // ScaleY

/*ValueSetterGenerator*/
public static Avalonia.Media.ScaleTransform ScaleY(this Avalonia.Media.ScaleTransform control, System.Double value)  
{
    control.ScaleY = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.ScaleTransform ScaleY(this Avalonia.Media.ScaleTransform control, Func<System.Double> func)  
   => control._set(Avalonia.Media.ScaleTransform.ScaleYProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.ScaleTransform ScaleY(this Avalonia.Media.ScaleTransform control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Media.ScaleTransform.ScaleYProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.ScaleTransform ScaleY(this Avalonia.Media.ScaleTransform control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Media.ScaleTransform.ScaleYProperty!, subject);



}

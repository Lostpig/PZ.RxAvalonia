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
public static partial class TranslateTransform_MarkupExtensions
{
//================= Properties ======================//
 // X

/*ValueSetterGenerator*/
public static Avalonia.Media.TranslateTransform X(this Avalonia.Media.TranslateTransform control, System.Double value)  
{
    control.X = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.TranslateTransform X(this Avalonia.Media.TranslateTransform control, Func<System.Double> func)  
   => control._set(Avalonia.Media.TranslateTransform.XProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.TranslateTransform X(this Avalonia.Media.TranslateTransform control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Media.TranslateTransform.XProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.TranslateTransform X(this Avalonia.Media.TranslateTransform control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Media.TranslateTransform.XProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.TranslateTransform X(this Avalonia.Media.TranslateTransform control, IObservable<System.Double> obs, IObserver<System.Double> changed)  
   => control._setEx(Avalonia.Media.TranslateTransform.XProperty!, obs, changed);


 // Y

/*ValueSetterGenerator*/
public static Avalonia.Media.TranslateTransform Y(this Avalonia.Media.TranslateTransform control, System.Double value)  
{
    control.Y = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.TranslateTransform Y(this Avalonia.Media.TranslateTransform control, Func<System.Double> func)  
   => control._set(Avalonia.Media.TranslateTransform.YProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.TranslateTransform Y(this Avalonia.Media.TranslateTransform control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Media.TranslateTransform.YProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.TranslateTransform Y(this Avalonia.Media.TranslateTransform control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Media.TranslateTransform.YProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.TranslateTransform Y(this Avalonia.Media.TranslateTransform control, IObservable<System.Double> obs, IObserver<System.Double> changed)  
   => control._setEx(Avalonia.Media.TranslateTransform.YProperty!, obs, changed);



}

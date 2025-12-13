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
public static partial class GradientStop_MarkupExtensions
{
//================= Properties ======================//
 // Offset

/*ValueSetterGenerator*/
public static Avalonia.Media.GradientStop Offset(this Avalonia.Media.GradientStop control, System.Double value)  
{
    control.Offset = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.GradientStop Offset(this Avalonia.Media.GradientStop control, Func<System.Double> func)  
   => control._set(Avalonia.Media.GradientStop.OffsetProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.GradientStop Offset(this Avalonia.Media.GradientStop control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Media.GradientStop.OffsetProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.GradientStop Offset(this Avalonia.Media.GradientStop control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Media.GradientStop.OffsetProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.GradientStop Offset(this Avalonia.Media.GradientStop control, IObservable<System.Double> obs, IObserver<System.Double> changed)  
   => control._setEx(Avalonia.Media.GradientStop.OffsetProperty!, obs, changed);


 // Color

/*ValueSetterGenerator*/
public static Avalonia.Media.GradientStop Color(this Avalonia.Media.GradientStop control, Avalonia.Media.Color value)  
{
    control.Color = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.GradientStop Color(this Avalonia.Media.GradientStop control, Func<Avalonia.Media.Color> func)  
   => control._set(Avalonia.Media.GradientStop.ColorProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.GradientStop Color(this Avalonia.Media.GradientStop control, IObservable<Avalonia.Media.Color> obs)  
   => control._set(Avalonia.Media.GradientStop.ColorProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.GradientStop Color(this Avalonia.Media.GradientStop control, ISubject<Avalonia.Media.Color> subject)  
   => control._set(Avalonia.Media.GradientStop.ColorProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.GradientStop Color(this Avalonia.Media.GradientStop control, IObservable<Avalonia.Media.Color> obs, IObserver<Avalonia.Media.Color> changed)  
   => control._setEx(Avalonia.Media.GradientStop.ColorProperty!, obs, changed);



}

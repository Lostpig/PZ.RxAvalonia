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
public static partial class BlurEffect_MarkupExtensions
{
//================= Properties ======================//
 // Radius

/*ValueSetterGenerator*/
public static Avalonia.Media.BlurEffect Radius(this Avalonia.Media.BlurEffect control, System.Double value)  
{
    control.Radius = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.BlurEffect Radius(this Avalonia.Media.BlurEffect control, Func<System.Double> func)  
   => control._set(Avalonia.Media.BlurEffect.RadiusProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.BlurEffect Radius(this Avalonia.Media.BlurEffect control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Media.BlurEffect.RadiusProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.BlurEffect Radius(this Avalonia.Media.BlurEffect control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Media.BlurEffect.RadiusProperty!, subject);



}

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
public static partial class DropShadowEffect_MarkupExtensions
{
//================= Properties ======================//
 // OffsetX

/*ValueSetterGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetX(this Avalonia.Media.DropShadowEffect control, System.Double value)  
{
    control.OffsetX = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetX(this Avalonia.Media.DropShadowEffect control, Func<System.Double> func)  
   => control._set(Avalonia.Media.DropShadowEffect.OffsetXProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetX(this Avalonia.Media.DropShadowEffect control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Media.DropShadowEffect.OffsetXProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetX(this Avalonia.Media.DropShadowEffect control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Media.DropShadowEffect.OffsetXProperty!, subject);


 // OffsetY

/*ValueSetterGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetY(this Avalonia.Media.DropShadowEffect control, System.Double value)  
{
    control.OffsetY = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetY(this Avalonia.Media.DropShadowEffect control, Func<System.Double> func)  
   => control._set(Avalonia.Media.DropShadowEffect.OffsetYProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetY(this Avalonia.Media.DropShadowEffect control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Media.DropShadowEffect.OffsetYProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetY(this Avalonia.Media.DropShadowEffect control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Media.DropShadowEffect.OffsetYProperty!, subject);



}

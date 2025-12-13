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
public static partial class SolidColorBrush_MarkupExtensions
{
//================= Properties ======================//
 // Color

/*ValueSetterGenerator*/
public static Avalonia.Media.SolidColorBrush Color(this Avalonia.Media.SolidColorBrush control, Avalonia.Media.Color value)  
{
    control.Color = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.SolidColorBrush Color(this Avalonia.Media.SolidColorBrush control, Func<Avalonia.Media.Color> func)  
   => control._set(Avalonia.Media.SolidColorBrush.ColorProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.SolidColorBrush Color(this Avalonia.Media.SolidColorBrush control, IObservable<Avalonia.Media.Color> obs)  
   => control._set(Avalonia.Media.SolidColorBrush.ColorProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.SolidColorBrush Color(this Avalonia.Media.SolidColorBrush control, ISubject<Avalonia.Media.Color> subject)  
   => control._set(Avalonia.Media.SolidColorBrush.ColorProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.SolidColorBrush Color(this Avalonia.Media.SolidColorBrush control, IObservable<Avalonia.Media.Color> obs, IObserver<Avalonia.Media.Color> changed)  
   => control._setEx(Avalonia.Media.SolidColorBrush.ColorProperty!, obs, changed);



}

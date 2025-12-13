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
public static partial class VisualBrush_MarkupExtensions
{
//================= Properties ======================//
 // Visual

/*ValueSetterGenerator*/
public static Avalonia.Media.VisualBrush Visual(this Avalonia.Media.VisualBrush control, Avalonia.Visual value)  
{
    control.Visual = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.VisualBrush Visual(this Avalonia.Media.VisualBrush control, Func<Avalonia.Visual> func)  
   => control._set(Avalonia.Media.VisualBrush.VisualProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.VisualBrush Visual(this Avalonia.Media.VisualBrush control, IObservable<Avalonia.Visual> obs)  
   => control._set(Avalonia.Media.VisualBrush.VisualProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.VisualBrush Visual(this Avalonia.Media.VisualBrush control, ISubject<Avalonia.Visual> subject)  
   => control._set(Avalonia.Media.VisualBrush.VisualProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.VisualBrush Visual(this Avalonia.Media.VisualBrush control, IObservable<Avalonia.Visual> obs, IObserver<Avalonia.Visual> changed)  
   => control._setEx(Avalonia.Media.VisualBrush.VisualProperty!, obs, changed);



}

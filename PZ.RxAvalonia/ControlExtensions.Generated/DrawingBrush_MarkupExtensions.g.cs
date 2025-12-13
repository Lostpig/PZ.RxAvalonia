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
public static partial class DrawingBrush_MarkupExtensions
{
//================= Properties ======================//
 // Drawing

/*ValueSetterGenerator*/
public static Avalonia.Media.DrawingBrush Drawing(this Avalonia.Media.DrawingBrush control, Avalonia.Media.Drawing value)  
{
    control.Drawing = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.DrawingBrush Drawing(this Avalonia.Media.DrawingBrush control, Func<Avalonia.Media.Drawing> func)  
   => control._set(Avalonia.Media.DrawingBrush.DrawingProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.DrawingBrush Drawing(this Avalonia.Media.DrawingBrush control, IObservable<Avalonia.Media.Drawing> obs)  
   => control._set(Avalonia.Media.DrawingBrush.DrawingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.DrawingBrush Drawing(this Avalonia.Media.DrawingBrush control, ISubject<Avalonia.Media.Drawing> subject)  
   => control._set(Avalonia.Media.DrawingBrush.DrawingProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.DrawingBrush Drawing(this Avalonia.Media.DrawingBrush control, IObservable<Avalonia.Media.Drawing> obs, IObserver<Avalonia.Media.Drawing> changed)  
   => control._setEx(Avalonia.Media.DrawingBrush.DrawingProperty!, obs, changed);



}

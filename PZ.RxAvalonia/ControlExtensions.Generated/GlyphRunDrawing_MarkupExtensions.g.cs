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
public static partial class GlyphRunDrawing_MarkupExtensions
{
//================= Properties ======================//
 // Foreground

/*ValueSetterGenerator*/
public static Avalonia.Media.GlyphRunDrawing Foreground(this Avalonia.Media.GlyphRunDrawing control, Avalonia.Media.IBrush value)  
{
    control.Foreground = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.GlyphRunDrawing Foreground(this Avalonia.Media.GlyphRunDrawing control, Func<Avalonia.Media.IBrush> func)  
   => control._set(Avalonia.Media.GlyphRunDrawing.ForegroundProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.GlyphRunDrawing Foreground(this Avalonia.Media.GlyphRunDrawing control, IObservable<Avalonia.Media.IBrush> obs)  
   => control._set(Avalonia.Media.GlyphRunDrawing.ForegroundProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.GlyphRunDrawing Foreground(this Avalonia.Media.GlyphRunDrawing control, ISubject<Avalonia.Media.IBrush> subject)  
   => control._set(Avalonia.Media.GlyphRunDrawing.ForegroundProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.GlyphRunDrawing Foreground(this Avalonia.Media.GlyphRunDrawing control, IObservable<Avalonia.Media.IBrush> obs, IObserver<Avalonia.Media.IBrush> changed)  
   => control._setEx(Avalonia.Media.GlyphRunDrawing.ForegroundProperty!, obs, changed);


 // GlyphRun

/*ValueSetterGenerator*/
public static Avalonia.Media.GlyphRunDrawing GlyphRun(this Avalonia.Media.GlyphRunDrawing control, Avalonia.Media.GlyphRun value)  
{
    control.GlyphRun = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.GlyphRunDrawing GlyphRun(this Avalonia.Media.GlyphRunDrawing control, Func<Avalonia.Media.GlyphRun> func)  
   => control._set(Avalonia.Media.GlyphRunDrawing.GlyphRunProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.GlyphRunDrawing GlyphRun(this Avalonia.Media.GlyphRunDrawing control, IObservable<Avalonia.Media.GlyphRun> obs)  
   => control._set(Avalonia.Media.GlyphRunDrawing.GlyphRunProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.GlyphRunDrawing GlyphRun(this Avalonia.Media.GlyphRunDrawing control, ISubject<Avalonia.Media.GlyphRun> subject)  
   => control._set(Avalonia.Media.GlyphRunDrawing.GlyphRunProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.GlyphRunDrawing GlyphRun(this Avalonia.Media.GlyphRunDrawing control, IObservable<Avalonia.Media.GlyphRun> obs, IObserver<Avalonia.Media.GlyphRun> changed)  
   => control._setEx(Avalonia.Media.GlyphRunDrawing.GlyphRunProperty!, obs, changed);



}

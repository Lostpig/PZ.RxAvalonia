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
public static partial class ImageBrush_MarkupExtensions
{
//================= Properties ======================//
 // Source

/*ValueSetterGenerator*/
public static Avalonia.Media.ImageBrush Source(this Avalonia.Media.ImageBrush control, Avalonia.Media.IImageBrushSource value)  
{
    control.Source = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.ImageBrush Source(this Avalonia.Media.ImageBrush control, Func<Avalonia.Media.IImageBrushSource> func)  
   => control._set(Avalonia.Media.ImageBrush.SourceProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.ImageBrush Source(this Avalonia.Media.ImageBrush control, IObservable<Avalonia.Media.IImageBrushSource> obs)  
   => control._set(Avalonia.Media.ImageBrush.SourceProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.ImageBrush Source(this Avalonia.Media.ImageBrush control, ISubject<Avalonia.Media.IImageBrushSource> subject)  
   => control._set(Avalonia.Media.ImageBrush.SourceProperty!, subject);



}

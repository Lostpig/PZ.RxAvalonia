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
public static partial class ImageDrawing_MarkupExtensions
{
//================= Properties ======================//
 // ImageSource

/*ValueSetterGenerator*/
public static Avalonia.Media.ImageDrawing ImageSource(this Avalonia.Media.ImageDrawing control, Avalonia.Media.IImage value)  
{
    control.ImageSource = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.ImageDrawing ImageSource(this Avalonia.Media.ImageDrawing control, Func<Avalonia.Media.IImage> func)  
   => control._set(Avalonia.Media.ImageDrawing.ImageSourceProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.ImageDrawing ImageSource(this Avalonia.Media.ImageDrawing control, IObservable<Avalonia.Media.IImage> obs)  
   => control._set(Avalonia.Media.ImageDrawing.ImageSourceProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.ImageDrawing ImageSource(this Avalonia.Media.ImageDrawing control, ISubject<Avalonia.Media.IImage> subject)  
   => control._set(Avalonia.Media.ImageDrawing.ImageSourceProperty!, subject);


 // Rect

/*ValueSetterGenerator*/
public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, Avalonia.Rect value)  
{
    control.Rect = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, System.Double x = default!, System.Double y = default!, System.Double width = default!, System.Double height = default!)  
{
    control.Rect = new Avalonia.Rect(x, y, width, height);
    return control;
}
public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, Avalonia.Size size = default!)  
{
    control.Rect = new Avalonia.Rect(size);
    return control;
}
public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, Avalonia.Point position = default!, Avalonia.Size size = default!)  
{
    control.Rect = new Avalonia.Rect(position, size);
    return control;
}
public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, Avalonia.Point topLeft = default!, Avalonia.Point bottomRight = default!)  
{
    control.Rect = new Avalonia.Rect(topLeft, bottomRight);
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, Func<Avalonia.Rect> func)  
   => control._set(Avalonia.Media.ImageDrawing.RectProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, IObservable<Avalonia.Rect> obs)  
   => control._set(Avalonia.Media.ImageDrawing.RectProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, ISubject<Avalonia.Rect> subject)  
   => control._set(Avalonia.Media.ImageDrawing.RectProperty!, subject);



}

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
public static partial class CroppedBitmap_MarkupExtensions
{
//================= Properties ======================//
 // Source

/*ValueSetterGenerator*/
public static T Source<T>(this T control, Avalonia.Media.IImage value) where T : Avalonia.Media.Imaging.CroppedBitmap 
{
    control.Source = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Source<T>(this T control, Func<Avalonia.Media.IImage> func) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(Avalonia.Media.Imaging.CroppedBitmap.SourceProperty!, func);

/*SetterFromObservableGenerator*/
public static T Source<T>(this T control, IObservable<Avalonia.Media.IImage> obs) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(Avalonia.Media.Imaging.CroppedBitmap.SourceProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Source<T>(this T control, ISubject<Avalonia.Media.IImage> subject) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(Avalonia.Media.Imaging.CroppedBitmap.SourceProperty!, subject);


 // SourceRect

/*ValueSetterGenerator*/
public static T SourceRect<T>(this T control, Avalonia.PixelRect value) where T : Avalonia.Media.Imaging.CroppedBitmap 
{
    control.SourceRect = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static T SourceRect<T>(this T control, System.Int32 x = default!, System.Int32 y = default!, System.Int32 width = default!, System.Int32 height = default!) where T : Avalonia.Media.Imaging.CroppedBitmap 
{
    control.SourceRect = new Avalonia.PixelRect(x, y, width, height);
    return control;
}
public static T SourceRect<T>(this T control, Avalonia.PixelSize size = default!) where T : Avalonia.Media.Imaging.CroppedBitmap 
{
    control.SourceRect = new Avalonia.PixelRect(size);
    return control;
}
public static T SourceRect<T>(this T control, Avalonia.PixelPoint position = default!, Avalonia.PixelSize size = default!) where T : Avalonia.Media.Imaging.CroppedBitmap 
{
    control.SourceRect = new Avalonia.PixelRect(position, size);
    return control;
}
public static T SourceRect<T>(this T control, Avalonia.PixelPoint topLeft = default!, Avalonia.PixelPoint bottomRight = default!) where T : Avalonia.Media.Imaging.CroppedBitmap 
{
    control.SourceRect = new Avalonia.PixelRect(topLeft, bottomRight);
    return control;
}

/*SetterFromFuncGenerator*/
public static T SourceRect<T>(this T control, Func<Avalonia.PixelRect> func) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty!, func);

/*SetterFromObservableGenerator*/
public static T SourceRect<T>(this T control, IObservable<Avalonia.PixelRect> obs) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SourceRect<T>(this T control, ISubject<Avalonia.PixelRect> subject) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty!, subject);



//================= Events ======================//
 // Invalidated

/*ActionToEventGenerator*/
public static T OnInvalidated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Media.Imaging.CroppedBitmap  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Invalidated += h);



}

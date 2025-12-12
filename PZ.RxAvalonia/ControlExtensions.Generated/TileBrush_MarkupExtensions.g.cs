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
public static partial class TileBrush_MarkupExtensions
{
//================= Properties ======================//
 // AlignmentX

/*ValueSetterGenerator*/
public static T AlignmentX<T>(this T control, Avalonia.Media.AlignmentX value) where T : Avalonia.Media.TileBrush 
{
    control.AlignmentX = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T AlignmentX<T>(this T control, Func<Avalonia.Media.AlignmentX> func) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.AlignmentXProperty!, func);

/*SetterFromObservableGenerator*/
public static T AlignmentX<T>(this T control, IObservable<Avalonia.Media.AlignmentX> obs) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.AlignmentXProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T AlignmentX<T>(this T control, ISubject<Avalonia.Media.AlignmentX> subject) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.AlignmentXProperty!, subject);


 // AlignmentY

/*ValueSetterGenerator*/
public static T AlignmentY<T>(this T control, Avalonia.Media.AlignmentY value) where T : Avalonia.Media.TileBrush 
{
    control.AlignmentY = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T AlignmentY<T>(this T control, Func<Avalonia.Media.AlignmentY> func) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.AlignmentYProperty!, func);

/*SetterFromObservableGenerator*/
public static T AlignmentY<T>(this T control, IObservable<Avalonia.Media.AlignmentY> obs) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.AlignmentYProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T AlignmentY<T>(this T control, ISubject<Avalonia.Media.AlignmentY> subject) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.AlignmentYProperty!, subject);


 // DestinationRect

/*ValueSetterGenerator*/
public static T DestinationRect<T>(this T control, Avalonia.RelativeRect value) where T : Avalonia.Media.TileBrush 
{
    control.DestinationRect = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static T DestinationRect<T>(this T control, System.Double x = default!, System.Double y = default!, System.Double width = default!, System.Double height = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
{
    control.DestinationRect = new Avalonia.RelativeRect(x, y, width, height, unit);
    return control;
}
public static T DestinationRect<T>(this T control, Avalonia.Rect rect = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
{
    control.DestinationRect = new Avalonia.RelativeRect(rect, unit);
    return control;
}
public static T DestinationRect<T>(this T control, Avalonia.Size size = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
{
    control.DestinationRect = new Avalonia.RelativeRect(size, unit);
    return control;
}
public static T DestinationRect<T>(this T control, Avalonia.Point position = default!, Avalonia.Size size = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
{
    control.DestinationRect = new Avalonia.RelativeRect(position, size, unit);
    return control;
}
public static T DestinationRect<T>(this T control, Avalonia.Point topLeft = default!, Avalonia.Point bottomRight = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
{
    control.DestinationRect = new Avalonia.RelativeRect(topLeft, bottomRight, unit);
    return control;
}

/*SetterFromFuncGenerator*/
public static T DestinationRect<T>(this T control, Func<Avalonia.RelativeRect> func) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.DestinationRectProperty!, func);

/*SetterFromObservableGenerator*/
public static T DestinationRect<T>(this T control, IObservable<Avalonia.RelativeRect> obs) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.DestinationRectProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DestinationRect<T>(this T control, ISubject<Avalonia.RelativeRect> subject) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.DestinationRectProperty!, subject);


 // SourceRect

/*ValueSetterGenerator*/
public static T SourceRect<T>(this T control, Avalonia.RelativeRect value) where T : Avalonia.Media.TileBrush 
{
    control.SourceRect = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static T SourceRect<T>(this T control, System.Double x = default!, System.Double y = default!, System.Double width = default!, System.Double height = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
{
    control.SourceRect = new Avalonia.RelativeRect(x, y, width, height, unit);
    return control;
}
public static T SourceRect<T>(this T control, Avalonia.Rect rect = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
{
    control.SourceRect = new Avalonia.RelativeRect(rect, unit);
    return control;
}
public static T SourceRect<T>(this T control, Avalonia.Size size = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
{
    control.SourceRect = new Avalonia.RelativeRect(size, unit);
    return control;
}
public static T SourceRect<T>(this T control, Avalonia.Point position = default!, Avalonia.Size size = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
{
    control.SourceRect = new Avalonia.RelativeRect(position, size, unit);
    return control;
}
public static T SourceRect<T>(this T control, Avalonia.Point topLeft = default!, Avalonia.Point bottomRight = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
{
    control.SourceRect = new Avalonia.RelativeRect(topLeft, bottomRight, unit);
    return control;
}

/*SetterFromFuncGenerator*/
public static T SourceRect<T>(this T control, Func<Avalonia.RelativeRect> func) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.SourceRectProperty!, func);

/*SetterFromObservableGenerator*/
public static T SourceRect<T>(this T control, IObservable<Avalonia.RelativeRect> obs) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.SourceRectProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SourceRect<T>(this T control, ISubject<Avalonia.RelativeRect> subject) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.SourceRectProperty!, subject);


 // Stretch

/*ValueSetterGenerator*/
public static T Stretch<T>(this T control, Avalonia.Media.Stretch value) where T : Avalonia.Media.TileBrush 
{
    control.Stretch = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Stretch<T>(this T control, Func<Avalonia.Media.Stretch> func) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.StretchProperty!, func);

/*SetterFromObservableGenerator*/
public static T Stretch<T>(this T control, IObservable<Avalonia.Media.Stretch> obs) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.StretchProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Stretch<T>(this T control, ISubject<Avalonia.Media.Stretch> subject) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.StretchProperty!, subject);


 // TileMode

/*ValueSetterGenerator*/
public static T TileMode<T>(this T control, Avalonia.Media.TileMode value) where T : Avalonia.Media.TileBrush 
{
    control.TileMode = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TileMode<T>(this T control, Func<Avalonia.Media.TileMode> func) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.TileModeProperty!, func);

/*SetterFromObservableGenerator*/
public static T TileMode<T>(this T control, IObservable<Avalonia.Media.TileMode> obs) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.TileModeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TileMode<T>(this T control, ISubject<Avalonia.Media.TileMode> subject) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.TileModeProperty!, subject);



}

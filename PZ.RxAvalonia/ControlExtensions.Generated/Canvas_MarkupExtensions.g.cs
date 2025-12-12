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
public static partial class Canvas_MarkupExtensions
{
//================= Attached Properties ======================//
 // Left

/*AttachedPropertyFuncGenerator*/
public static T Canvas_Left<T>(this T control, Func<System.Double> getter) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.Canvas.LeftProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T Canvas_Left<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.Canvas.LeftProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T Canvas_Left<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.Canvas.LeftProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T Canvas_Left<T>(this T control, System.Double value) where T : Avalonia.AvaloniaObject 
{
    control.SetValue(Avalonia.Controls.Canvas.LeftProperty!, value);
    return control;
}


 // Top

/*AttachedPropertyFuncGenerator*/
public static T Canvas_Top<T>(this T control, Func<System.Double> getter) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.Canvas.TopProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T Canvas_Top<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.Canvas.TopProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T Canvas_Top<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.Canvas.TopProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T Canvas_Top<T>(this T control, System.Double value) where T : Avalonia.AvaloniaObject 
{
    control.SetValue(Avalonia.Controls.Canvas.TopProperty!, value);
    return control;
}


 // Right

/*AttachedPropertyFuncGenerator*/
public static T Canvas_Right<T>(this T control, Func<System.Double> getter) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.Canvas.RightProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T Canvas_Right<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.Canvas.RightProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T Canvas_Right<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.Canvas.RightProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T Canvas_Right<T>(this T control, System.Double value) where T : Avalonia.AvaloniaObject 
{
    control.SetValue(Avalonia.Controls.Canvas.RightProperty!, value);
    return control;
}


 // Bottom

/*AttachedPropertyFuncGenerator*/
public static T Canvas_Bottom<T>(this T control, Func<System.Double> getter) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.Canvas.BottomProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T Canvas_Bottom<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.Canvas.BottomProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T Canvas_Bottom<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.Canvas.BottomProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T Canvas_Bottom<T>(this T control, System.Double value) where T : Avalonia.AvaloniaObject 
{
    control.SetValue(Avalonia.Controls.Canvas.BottomProperty!, value);
    return control;
}



}

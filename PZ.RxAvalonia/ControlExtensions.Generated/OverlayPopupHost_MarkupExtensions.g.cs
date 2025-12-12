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
public static partial class OverlayPopupHost_MarkupExtensions
{
//================= Properties ======================//
 // Transform

/*ValueSetterGenerator*/
public static T Transform<T>(this T control, Avalonia.Media.Transform value) where T : Avalonia.Controls.Primitives.OverlayPopupHost 
{
    control.Transform = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Transform<T>(this T control, Func<Avalonia.Media.Transform> func) where T : Avalonia.Controls.Primitives.OverlayPopupHost 
   => control._set(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty!, func);

/*SetterFromObservableGenerator*/
public static T Transform<T>(this T control, IObservable<Avalonia.Media.Transform> obs) where T : Avalonia.Controls.Primitives.OverlayPopupHost 
   => control._set(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Transform<T>(this T control, ISubject<Avalonia.Media.Transform> subject) where T : Avalonia.Controls.Primitives.OverlayPopupHost 
   => control._set(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty!, subject);



//================= Styles ======================//
 // Transform

/*ValueStyleSetterGenerator*/
public static Style<T> Transform<T>(this Style<T> style, Avalonia.Media.Transform value) where T : Avalonia.Controls.Primitives.OverlayPopupHost 
=> style._addSetter(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Transform<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.OverlayPopupHost 
=> style._addSetter(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty, binding);



}

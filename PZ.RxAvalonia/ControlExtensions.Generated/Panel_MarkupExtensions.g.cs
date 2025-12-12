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
public static partial class Panel_MarkupExtensions
{
//================= Properties ======================//
 // Background

/*ValueSetterGenerator*/
public static T Background<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Panel 
{
    control.Background = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Background<T>(this T control, Func<Avalonia.Media.IBrush> func) where T : Avalonia.Controls.Panel 
   => control._set(Avalonia.Controls.Panel.BackgroundProperty!, func);

/*SetterFromObservableGenerator*/
public static T Background<T>(this T control, IObservable<Avalonia.Media.IBrush> obs) where T : Avalonia.Controls.Panel 
   => control._set(Avalonia.Controls.Panel.BackgroundProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Background<T>(this T control, ISubject<Avalonia.Media.IBrush> subject) where T : Avalonia.Controls.Panel 
   => control._set(Avalonia.Controls.Panel.BackgroundProperty!, subject);



//================= Styles ======================//
 // Background

/*ValueStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Panel 
=> style._addSetter(Avalonia.Controls.Panel.BackgroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Panel 
=> style._addSetter(Avalonia.Controls.Panel.BackgroundProperty, binding);



}

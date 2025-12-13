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
public static partial class ReversibleStackPanel_MarkupExtensions
{
//================= Properties ======================//
 // ReverseOrder

/*ValueSetterGenerator*/
public static T ReverseOrder<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ReversibleStackPanel 
{
    control.ReverseOrder = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ReverseOrder<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.ReversibleStackPanel 
   => control._set(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty!, func);

/*SetterFromObservableGenerator*/
public static T ReverseOrder<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.ReversibleStackPanel 
   => control._set(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ReverseOrder<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.ReversibleStackPanel 
   => control._set(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ReverseOrder<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.ReversibleStackPanel 
   => control._setEx(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty!, obs, changed);



//================= Styles ======================//
 // ReverseOrder

/*ValueStyleSetterGenerator*/
public static Style<T> ReverseOrder<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ReversibleStackPanel 
=> style._addSetter(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ReverseOrder<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ReversibleStackPanel 
=> style._addSetter(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty, binding);



}

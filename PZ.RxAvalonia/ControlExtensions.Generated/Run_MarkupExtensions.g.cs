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
public static partial class Run_MarkupExtensions
{
//================= Properties ======================//
 // Text

/*ValueSetterGenerator*/
public static T Text<T>(this T control, System.String? value) where T : Avalonia.Controls.Documents.Run 
{
    control.Text = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Text<T>(this T control, Func<System.String?> func) where T : Avalonia.Controls.Documents.Run 
   => control._set(Avalonia.Controls.Documents.Run.TextProperty!, func);

/*SetterFromObservableGenerator*/
public static T Text<T>(this T control, IObservable<System.String?> obs) where T : Avalonia.Controls.Documents.Run 
   => control._set(Avalonia.Controls.Documents.Run.TextProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Text<T>(this T control, ISubject<System.String?> subject) where T : Avalonia.Controls.Documents.Run 
   => control._set(Avalonia.Controls.Documents.Run.TextProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Text<T>(this T control, IObservable<System.String?> obs, IObserver<System.String?> changed) where T : Avalonia.Controls.Documents.Run 
   => control._setEx(Avalonia.Controls.Documents.Run.TextProperty!, obs, changed);



//================= Styles ======================//
 // Text

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String? value) where T : Avalonia.Controls.Documents.Run 
=> style._addSetter(Avalonia.Controls.Documents.Run.TextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.Run 
=> style._addSetter(Avalonia.Controls.Documents.Run.TextProperty, binding);



}

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
public static partial class Span_MarkupExtensions
{
//================= Properties ======================//
 // Inlines

/*ValueSetterGenerator*/
public static T Inlines<T>(this T control, Avalonia.Controls.Documents.InlineCollection value) where T : Avalonia.Controls.Documents.Span 
{
    control.Inlines = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Inlines<T>(this T control, Func<Avalonia.Controls.Documents.InlineCollection> func) where T : Avalonia.Controls.Documents.Span 
   => control._set(Avalonia.Controls.Documents.Span.InlinesProperty!, func);

/*SetterFromObservableGenerator*/
public static T Inlines<T>(this T control, IObservable<Avalonia.Controls.Documents.InlineCollection> obs) where T : Avalonia.Controls.Documents.Span 
   => control._set(Avalonia.Controls.Documents.Span.InlinesProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Inlines<T>(this T control, ISubject<Avalonia.Controls.Documents.InlineCollection> subject) where T : Avalonia.Controls.Documents.Span 
   => control._set(Avalonia.Controls.Documents.Span.InlinesProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Inlines<T>(this T control, IObservable<Avalonia.Controls.Documents.InlineCollection> obs, IObserver<Avalonia.Controls.Documents.InlineCollection> changed) where T : Avalonia.Controls.Documents.Span 
   => control._setEx(Avalonia.Controls.Documents.Span.InlinesProperty!, obs, changed);



//================= Styles ======================//
 // Inlines

/*ValueStyleSetterGenerator*/
public static Style<T> Inlines<T>(this Style<T> style, Avalonia.Controls.Documents.InlineCollection value) where T : Avalonia.Controls.Documents.Span 
=> style._addSetter(Avalonia.Controls.Documents.Span.InlinesProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Inlines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.Span 
=> style._addSetter(Avalonia.Controls.Documents.Span.InlinesProperty, binding);



}

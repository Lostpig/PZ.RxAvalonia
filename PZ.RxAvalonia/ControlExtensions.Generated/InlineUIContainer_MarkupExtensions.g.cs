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
public static partial class InlineUIContainer_MarkupExtensions
{
//================= Properties ======================//
 // Child

/*ValueSetterGenerator*/
public static T Child<T>(this T control, Avalonia.Controls.Control value) where T : Avalonia.Controls.Documents.InlineUIContainer 
{
    control.Child = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Child<T>(this T control, Func<Avalonia.Controls.Control> func) where T : Avalonia.Controls.Documents.InlineUIContainer 
   => control._set(Avalonia.Controls.Documents.InlineUIContainer.ChildProperty!, func);

/*SetterFromObservableGenerator*/
public static T Child<T>(this T control, IObservable<Avalonia.Controls.Control> obs) where T : Avalonia.Controls.Documents.InlineUIContainer 
   => control._set(Avalonia.Controls.Documents.InlineUIContainer.ChildProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Child<T>(this T control, ISubject<Avalonia.Controls.Control> subject) where T : Avalonia.Controls.Documents.InlineUIContainer 
   => control._set(Avalonia.Controls.Documents.InlineUIContainer.ChildProperty!, subject);



//================= Styles ======================//
 // Child

/*ValueStyleSetterGenerator*/
public static Style<T> Child<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Avalonia.Controls.Documents.InlineUIContainer 
=> style._addSetter(Avalonia.Controls.Documents.InlineUIContainer.ChildProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Child<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.InlineUIContainer 
=> style._addSetter(Avalonia.Controls.Documents.InlineUIContainer.ChildProperty, binding);



}

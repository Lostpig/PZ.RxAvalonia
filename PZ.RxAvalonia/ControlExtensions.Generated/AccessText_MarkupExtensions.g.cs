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
public static partial class AccessText_MarkupExtensions
{
//================= Properties ======================//
 // ShowAccessKey

/*ValueSetterGenerator*/
public static T ShowAccessKey<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.AccessText 
{
    control.ShowAccessKey = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ShowAccessKey<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Primitives.AccessText 
   => control._set(Avalonia.Controls.Primitives.AccessText.ShowAccessKeyProperty!, func);

/*SetterFromObservableGenerator*/
public static T ShowAccessKey<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Primitives.AccessText 
   => control._set(Avalonia.Controls.Primitives.AccessText.ShowAccessKeyProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ShowAccessKey<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Primitives.AccessText 
   => control._set(Avalonia.Controls.Primitives.AccessText.ShowAccessKeyProperty!, subject);



//================= Styles ======================//
 // ShowAccessKey

/*ValueStyleSetterGenerator*/
public static Style<T> ShowAccessKey<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.AccessText 
=> style._addSetter(Avalonia.Controls.Primitives.AccessText.ShowAccessKeyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowAccessKey<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.AccessText 
=> style._addSetter(Avalonia.Controls.Primitives.AccessText.ShowAccessKeyProperty, binding);



}

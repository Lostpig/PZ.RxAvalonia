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
public static partial class HeaderedItemsControl_MarkupExtensions
{
//================= Properties ======================//
 // Header

/*ValueSetterGenerator*/
public static T Header<T>(this T control, System.Object? value) where T : Avalonia.Controls.Primitives.HeaderedItemsControl 
{
    control.Header = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Header<T>(this T control, Func<System.Object?> func) where T : Avalonia.Controls.Primitives.HeaderedItemsControl 
   => control._set(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty!, func);

/*SetterFromObservableGenerator*/
public static T Header<T>(this T control, IObservable<System.Object?> obs) where T : Avalonia.Controls.Primitives.HeaderedItemsControl 
   => control._set(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Header<T>(this T control, ISubject<System.Object?> subject) where T : Avalonia.Controls.Primitives.HeaderedItemsControl 
   => control._set(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Header<T>(this T control, IObservable<System.Object?> obs, IObserver<System.Object?> changed) where T : Avalonia.Controls.Primitives.HeaderedItemsControl 
   => control._setEx(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty!, obs, changed);


 // HeaderTemplate

/*ValueSetterGenerator*/
public static T HeaderTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.Primitives.HeaderedItemsControl 
{
    control.HeaderTemplate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T HeaderTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate?> func) where T : Avalonia.Controls.Primitives.HeaderedItemsControl 
   => control._set(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty!, func);

/*SetterFromObservableGenerator*/
public static T HeaderTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs) where T : Avalonia.Controls.Primitives.HeaderedItemsControl 
   => control._set(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T HeaderTemplate<T>(this T control, ISubject<Avalonia.Controls.Templates.IDataTemplate?> subject) where T : Avalonia.Controls.Primitives.HeaderedItemsControl 
   => control._set(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T HeaderTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs, IObserver<Avalonia.Controls.Templates.IDataTemplate?> changed) where T : Avalonia.Controls.Primitives.HeaderedItemsControl 
   => control._setEx(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty!, obs, changed);



//================= Styles ======================//
 // Header

/*ValueStyleSetterGenerator*/
public static Style<T> Header<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.Primitives.HeaderedItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Header<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.HeaderedItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty, binding);


 // HeaderTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> HeaderTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.Primitives.HeaderedItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HeaderTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.HeaderedItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty, binding);



}

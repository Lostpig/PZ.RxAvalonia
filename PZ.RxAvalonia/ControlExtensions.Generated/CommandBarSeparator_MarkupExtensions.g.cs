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
public static partial class CommandBarSeparator_MarkupExtensions
{
//================= Properties ======================//
 // IsCompact

/*ValueSetterGenerator*/
public static T IsCompact<T>(this T control, System.Boolean value) where T : Avalonia.Controls.CommandBarSeparator 
{
    control.IsCompact = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsCompact<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.CommandBarSeparator 
   => control._set(Avalonia.Controls.CommandBarSeparator.IsCompactProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsCompact<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.CommandBarSeparator 
   => control._set(Avalonia.Controls.CommandBarSeparator.IsCompactProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsCompact<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.CommandBarSeparator 
   => control._set(Avalonia.Controls.CommandBarSeparator.IsCompactProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsCompact<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.CommandBarSeparator 
   => control._setEx(Avalonia.Controls.CommandBarSeparator.IsCompactProperty!, obs, changed);


 // IsInOverflow

/*ValueSetterGenerator*/
public static T IsInOverflow<T>(this T control, System.Boolean value) where T : Avalonia.Controls.CommandBarSeparator 
{
    control.IsInOverflow = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsInOverflow<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.CommandBarSeparator 
   => control._set(Avalonia.Controls.CommandBarSeparator.IsInOverflowProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsInOverflow<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.CommandBarSeparator 
   => control._set(Avalonia.Controls.CommandBarSeparator.IsInOverflowProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsInOverflow<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.CommandBarSeparator 
   => control._set(Avalonia.Controls.CommandBarSeparator.IsInOverflowProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsInOverflow<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.CommandBarSeparator 
   => control._setEx(Avalonia.Controls.CommandBarSeparator.IsInOverflowProperty!, obs, changed);



//================= Styles ======================//
 // IsCompact

/*ValueStyleSetterGenerator*/
public static Style<T> IsCompact<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.CommandBarSeparator 
=> style._addSetter(Avalonia.Controls.CommandBarSeparator.IsCompactProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsCompact<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.CommandBarSeparator 
=> style._addSetter(Avalonia.Controls.CommandBarSeparator.IsCompactProperty, binding);


 // IsInOverflow

/*ValueStyleSetterGenerator*/
public static Style<T> IsInOverflow<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.CommandBarSeparator 
=> style._addSetter(Avalonia.Controls.CommandBarSeparator.IsInOverflowProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsInOverflow<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.CommandBarSeparator 
=> style._addSetter(Avalonia.Controls.CommandBarSeparator.IsInOverflowProperty, binding);



}

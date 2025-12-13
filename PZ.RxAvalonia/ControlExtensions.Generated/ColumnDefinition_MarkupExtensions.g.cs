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
public static partial class ColumnDefinition_MarkupExtensions
{
//================= Properties ======================//
 // MaxWidth

/*ValueSetterGenerator*/
public static T MaxWidth<T>(this T control, System.Double value) where T : Avalonia.Controls.ColumnDefinition 
{
    control.MaxWidth = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MaxWidth<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(Avalonia.Controls.ColumnDefinition.MaxWidthProperty!, func);

/*SetterFromObservableGenerator*/
public static T MaxWidth<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(Avalonia.Controls.ColumnDefinition.MaxWidthProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MaxWidth<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(Avalonia.Controls.ColumnDefinition.MaxWidthProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T MaxWidth<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.ColumnDefinition 
   => control._setEx(Avalonia.Controls.ColumnDefinition.MaxWidthProperty!, obs, changed);


 // MinWidth

/*ValueSetterGenerator*/
public static T MinWidth<T>(this T control, System.Double value) where T : Avalonia.Controls.ColumnDefinition 
{
    control.MinWidth = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MinWidth<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(Avalonia.Controls.ColumnDefinition.MinWidthProperty!, func);

/*SetterFromObservableGenerator*/
public static T MinWidth<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(Avalonia.Controls.ColumnDefinition.MinWidthProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MinWidth<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(Avalonia.Controls.ColumnDefinition.MinWidthProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T MinWidth<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.ColumnDefinition 
   => control._setEx(Avalonia.Controls.ColumnDefinition.MinWidthProperty!, obs, changed);


 // Width

/*ValueSetterGenerator*/
public static T Width<T>(this T control, Avalonia.Controls.GridLength value) where T : Avalonia.Controls.ColumnDefinition 
{
    control.Width = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static T Width<T>(this T control, System.Double value = default!) where T : Avalonia.Controls.ColumnDefinition 
{
    control.Width = new Avalonia.Controls.GridLength(value);
    return control;
}
public static T Width<T>(this T control, System.Double value = default!, Avalonia.Controls.GridUnitType type = default!) where T : Avalonia.Controls.ColumnDefinition 
{
    control.Width = new Avalonia.Controls.GridLength(value, type);
    return control;
}

/*SetterFromFuncGenerator*/
public static T Width<T>(this T control, Func<Avalonia.Controls.GridLength> func) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(Avalonia.Controls.ColumnDefinition.WidthProperty!, func);

/*SetterFromObservableGenerator*/
public static T Width<T>(this T control, IObservable<Avalonia.Controls.GridLength> obs) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(Avalonia.Controls.ColumnDefinition.WidthProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Width<T>(this T control, ISubject<Avalonia.Controls.GridLength> subject) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(Avalonia.Controls.ColumnDefinition.WidthProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Width<T>(this T control, IObservable<Avalonia.Controls.GridLength> obs, IObserver<Avalonia.Controls.GridLength> changed) where T : Avalonia.Controls.ColumnDefinition 
   => control._setEx(Avalonia.Controls.ColumnDefinition.WidthProperty!, obs, changed);



}

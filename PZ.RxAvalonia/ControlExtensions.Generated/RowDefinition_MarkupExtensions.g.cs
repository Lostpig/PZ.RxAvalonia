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
public static partial class RowDefinition_MarkupExtensions
{
//================= Properties ======================//
 // MaxHeight

/*ValueSetterGenerator*/
public static T MaxHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.RowDefinition 
{
    control.MaxHeight = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MaxHeight<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.RowDefinition 
   => control._set(Avalonia.Controls.RowDefinition.MaxHeightProperty!, func);

/*SetterFromObservableGenerator*/
public static T MaxHeight<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.RowDefinition 
   => control._set(Avalonia.Controls.RowDefinition.MaxHeightProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MaxHeight<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.RowDefinition 
   => control._set(Avalonia.Controls.RowDefinition.MaxHeightProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T MaxHeight<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.RowDefinition 
   => control._setEx(Avalonia.Controls.RowDefinition.MaxHeightProperty!, obs, changed);


 // MinHeight

/*ValueSetterGenerator*/
public static T MinHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.RowDefinition 
{
    control.MinHeight = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MinHeight<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.RowDefinition 
   => control._set(Avalonia.Controls.RowDefinition.MinHeightProperty!, func);

/*SetterFromObservableGenerator*/
public static T MinHeight<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.RowDefinition 
   => control._set(Avalonia.Controls.RowDefinition.MinHeightProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MinHeight<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.RowDefinition 
   => control._set(Avalonia.Controls.RowDefinition.MinHeightProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T MinHeight<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.RowDefinition 
   => control._setEx(Avalonia.Controls.RowDefinition.MinHeightProperty!, obs, changed);


 // Height

/*ValueSetterGenerator*/
public static T Height<T>(this T control, Avalonia.Controls.GridLength value) where T : Avalonia.Controls.RowDefinition 
{
    control.Height = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static T Height<T>(this T control, System.Double value = default!) where T : Avalonia.Controls.RowDefinition 
{
    control.Height = new Avalonia.Controls.GridLength(value);
    return control;
}
public static T Height<T>(this T control, System.Double value = default!, Avalonia.Controls.GridUnitType type = default!) where T : Avalonia.Controls.RowDefinition 
{
    control.Height = new Avalonia.Controls.GridLength(value, type);
    return control;
}

/*SetterFromFuncGenerator*/
public static T Height<T>(this T control, Func<Avalonia.Controls.GridLength> func) where T : Avalonia.Controls.RowDefinition 
   => control._set(Avalonia.Controls.RowDefinition.HeightProperty!, func);

/*SetterFromObservableGenerator*/
public static T Height<T>(this T control, IObservable<Avalonia.Controls.GridLength> obs) where T : Avalonia.Controls.RowDefinition 
   => control._set(Avalonia.Controls.RowDefinition.HeightProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Height<T>(this T control, ISubject<Avalonia.Controls.GridLength> subject) where T : Avalonia.Controls.RowDefinition 
   => control._set(Avalonia.Controls.RowDefinition.HeightProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Height<T>(this T control, IObservable<Avalonia.Controls.GridLength> obs, IObserver<Avalonia.Controls.GridLength> changed) where T : Avalonia.Controls.RowDefinition 
   => control._setEx(Avalonia.Controls.RowDefinition.HeightProperty!, obs, changed);



}

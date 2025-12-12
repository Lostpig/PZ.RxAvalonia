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
public static partial class ExperimentalAcrylicBorder_MarkupExtensions
{
//================= Properties ======================//
 // CornerRadius

/*ValueSetterGenerator*/
public static T CornerRadius<T>(this T control, Avalonia.CornerRadius value) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
{
    control.CornerRadius = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static T CornerRadius<T>(this T control, System.Double uniformRadius = default!) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
{
    control.CornerRadius = new Avalonia.CornerRadius(uniformRadius);
    return control;
}
public static T CornerRadius<T>(this T control, System.Double top = default!, System.Double bottom = default!) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
{
    control.CornerRadius = new Avalonia.CornerRadius(top, bottom);
    return control;
}
public static T CornerRadius<T>(this T control, System.Double topLeft = default!, System.Double topRight = default!, System.Double bottomRight = default!, System.Double bottomLeft = default!) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
{
    control.CornerRadius = new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft);
    return control;
}

/*SetterFromFuncGenerator*/
public static T CornerRadius<T>(this T control, Func<Avalonia.CornerRadius> func) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
   => control._set(Avalonia.Controls.ExperimentalAcrylicBorder.CornerRadiusProperty!, func);

/*SetterFromObservableGenerator*/
public static T CornerRadius<T>(this T control, IObservable<Avalonia.CornerRadius> obs) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
   => control._set(Avalonia.Controls.ExperimentalAcrylicBorder.CornerRadiusProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CornerRadius<T>(this T control, ISubject<Avalonia.CornerRadius> subject) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
   => control._set(Avalonia.Controls.ExperimentalAcrylicBorder.CornerRadiusProperty!, subject);


 // Material

/*ValueSetterGenerator*/
public static T Material<T>(this T control, Avalonia.Media.ExperimentalAcrylicMaterial value) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
{
    control.Material = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Material<T>(this T control, Func<Avalonia.Media.ExperimentalAcrylicMaterial> func) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
   => control._set(Avalonia.Controls.ExperimentalAcrylicBorder.MaterialProperty!, func);

/*SetterFromObservableGenerator*/
public static T Material<T>(this T control, IObservable<Avalonia.Media.ExperimentalAcrylicMaterial> obs) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
   => control._set(Avalonia.Controls.ExperimentalAcrylicBorder.MaterialProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Material<T>(this T control, ISubject<Avalonia.Media.ExperimentalAcrylicMaterial> subject) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
   => control._set(Avalonia.Controls.ExperimentalAcrylicBorder.MaterialProperty!, subject);



//================= Styles ======================//
 // CornerRadius

/*ValueStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, Avalonia.CornerRadius value) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
=> style._addSetter(Avalonia.Controls.ExperimentalAcrylicBorder.CornerRadiusProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
=> style._addSetter(Avalonia.Controls.ExperimentalAcrylicBorder.CornerRadiusProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, System.Double uniformRadius) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
   => style._addSetter(Avalonia.Controls.ExperimentalAcrylicBorder.CornerRadiusProperty, new Avalonia.CornerRadius(uniformRadius));public static Style<T> CornerRadius<T>(this Style<T> style, System.Double top, System.Double bottom) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
   => style._addSetter(Avalonia.Controls.ExperimentalAcrylicBorder.CornerRadiusProperty, new Avalonia.CornerRadius(top, bottom));public static Style<T> CornerRadius<T>(this Style<T> style, System.Double topLeft, System.Double topRight, System.Double bottomRight, System.Double bottomLeft) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
   => style._addSetter(Avalonia.Controls.ExperimentalAcrylicBorder.CornerRadiusProperty, new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft));


 // Material

/*ValueStyleSetterGenerator*/
public static Style<T> Material<T>(this Style<T> style, Avalonia.Media.ExperimentalAcrylicMaterial value) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
=> style._addSetter(Avalonia.Controls.ExperimentalAcrylicBorder.MaterialProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Material<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
=> style._addSetter(Avalonia.Controls.ExperimentalAcrylicBorder.MaterialProperty, binding);



}

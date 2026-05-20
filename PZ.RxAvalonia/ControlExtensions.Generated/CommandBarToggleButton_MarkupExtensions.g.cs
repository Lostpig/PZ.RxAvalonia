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
public static partial class CommandBarToggleButton_MarkupExtensions
{
//================= Properties ======================//
 // Label

/*ValueSetterGenerator*/
public static T Label<T>(this T control, System.String? value) where T : Avalonia.Controls.CommandBarToggleButton 
{
    control.Label = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Label<T>(this T control, Func<System.String?> func) where T : Avalonia.Controls.CommandBarToggleButton 
   => control._set(Avalonia.Controls.CommandBarToggleButton.LabelProperty!, func);

/*SetterFromObservableGenerator*/
public static T Label<T>(this T control, IObservable<System.String?> obs) where T : Avalonia.Controls.CommandBarToggleButton 
   => control._set(Avalonia.Controls.CommandBarToggleButton.LabelProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Label<T>(this T control, ISubject<System.String?> subject) where T : Avalonia.Controls.CommandBarToggleButton 
   => control._set(Avalonia.Controls.CommandBarToggleButton.LabelProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Label<T>(this T control, IObservable<System.String?> obs, IObserver<System.String?> changed) where T : Avalonia.Controls.CommandBarToggleButton 
   => control._setEx(Avalonia.Controls.CommandBarToggleButton.LabelProperty!, obs, changed);


 // Icon

/*ValueSetterGenerator*/
public static T Icon<T>(this T control, System.Object? value) where T : Avalonia.Controls.CommandBarToggleButton 
{
    control.Icon = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Icon<T>(this T control, Func<System.Object?> func) where T : Avalonia.Controls.CommandBarToggleButton 
   => control._set(Avalonia.Controls.CommandBarToggleButton.IconProperty!, func);

/*SetterFromObservableGenerator*/
public static T Icon<T>(this T control, IObservable<System.Object?> obs) where T : Avalonia.Controls.CommandBarToggleButton 
   => control._set(Avalonia.Controls.CommandBarToggleButton.IconProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Icon<T>(this T control, ISubject<System.Object?> subject) where T : Avalonia.Controls.CommandBarToggleButton 
   => control._set(Avalonia.Controls.CommandBarToggleButton.IconProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Icon<T>(this T control, IObservable<System.Object?> obs, IObserver<System.Object?> changed) where T : Avalonia.Controls.CommandBarToggleButton 
   => control._setEx(Avalonia.Controls.CommandBarToggleButton.IconProperty!, obs, changed);


 // IsCompact

/*ValueSetterGenerator*/
public static T IsCompact<T>(this T control, System.Boolean value) where T : Avalonia.Controls.CommandBarToggleButton 
{
    control.IsCompact = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsCompact<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.CommandBarToggleButton 
   => control._set(Avalonia.Controls.CommandBarToggleButton.IsCompactProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsCompact<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.CommandBarToggleButton 
   => control._set(Avalonia.Controls.CommandBarToggleButton.IsCompactProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsCompact<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.CommandBarToggleButton 
   => control._set(Avalonia.Controls.CommandBarToggleButton.IsCompactProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsCompact<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.CommandBarToggleButton 
   => control._setEx(Avalonia.Controls.CommandBarToggleButton.IsCompactProperty!, obs, changed);


 // DynamicOverflowOrder

/*ValueSetterGenerator*/
public static T DynamicOverflowOrder<T>(this T control, System.Int32 value) where T : Avalonia.Controls.CommandBarToggleButton 
{
    control.DynamicOverflowOrder = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DynamicOverflowOrder<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.CommandBarToggleButton 
   => control._set(Avalonia.Controls.CommandBarToggleButton.DynamicOverflowOrderProperty!, func);

/*SetterFromObservableGenerator*/
public static T DynamicOverflowOrder<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.CommandBarToggleButton 
   => control._set(Avalonia.Controls.CommandBarToggleButton.DynamicOverflowOrderProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DynamicOverflowOrder<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.CommandBarToggleButton 
   => control._set(Avalonia.Controls.CommandBarToggleButton.DynamicOverflowOrderProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DynamicOverflowOrder<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.CommandBarToggleButton 
   => control._setEx(Avalonia.Controls.CommandBarToggleButton.DynamicOverflowOrderProperty!, obs, changed);


 // LabelPosition

/*ValueSetterGenerator*/
public static T LabelPosition<T>(this T control, Avalonia.Controls.CommandBarDefaultLabelPosition value) where T : Avalonia.Controls.CommandBarToggleButton 
{
    control.LabelPosition = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T LabelPosition<T>(this T control, Func<Avalonia.Controls.CommandBarDefaultLabelPosition> func) where T : Avalonia.Controls.CommandBarToggleButton 
   => control._set(Avalonia.Controls.CommandBarToggleButton.LabelPositionProperty!, func);

/*SetterFromObservableGenerator*/
public static T LabelPosition<T>(this T control, IObservable<Avalonia.Controls.CommandBarDefaultLabelPosition> obs) where T : Avalonia.Controls.CommandBarToggleButton 
   => control._set(Avalonia.Controls.CommandBarToggleButton.LabelPositionProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T LabelPosition<T>(this T control, ISubject<Avalonia.Controls.CommandBarDefaultLabelPosition> subject) where T : Avalonia.Controls.CommandBarToggleButton 
   => control._set(Avalonia.Controls.CommandBarToggleButton.LabelPositionProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T LabelPosition<T>(this T control, IObservable<Avalonia.Controls.CommandBarDefaultLabelPosition> obs, IObserver<Avalonia.Controls.CommandBarDefaultLabelPosition> changed) where T : Avalonia.Controls.CommandBarToggleButton 
   => control._setEx(Avalonia.Controls.CommandBarToggleButton.LabelPositionProperty!, obs, changed);


 // IsInOverflow

/*ValueSetterGenerator*/
public static T IsInOverflow<T>(this T control, System.Boolean value) where T : Avalonia.Controls.CommandBarToggleButton 
{
    control.IsInOverflow = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsInOverflow<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.CommandBarToggleButton 
   => control._set(Avalonia.Controls.CommandBarToggleButton.IsInOverflowProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsInOverflow<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.CommandBarToggleButton 
   => control._set(Avalonia.Controls.CommandBarToggleButton.IsInOverflowProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsInOverflow<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.CommandBarToggleButton 
   => control._set(Avalonia.Controls.CommandBarToggleButton.IsInOverflowProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsInOverflow<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.CommandBarToggleButton 
   => control._setEx(Avalonia.Controls.CommandBarToggleButton.IsInOverflowProperty!, obs, changed);



//================= Styles ======================//
 // Label

/*ValueStyleSetterGenerator*/
public static Style<T> Label<T>(this Style<T> style, System.String? value) where T : Avalonia.Controls.CommandBarToggleButton 
=> style._addSetter(Avalonia.Controls.CommandBarToggleButton.LabelProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Label<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.CommandBarToggleButton 
=> style._addSetter(Avalonia.Controls.CommandBarToggleButton.LabelProperty, binding);


 // Icon

/*ValueStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.CommandBarToggleButton 
=> style._addSetter(Avalonia.Controls.CommandBarToggleButton.IconProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.CommandBarToggleButton 
=> style._addSetter(Avalonia.Controls.CommandBarToggleButton.IconProperty, binding);


 // IsCompact

/*ValueStyleSetterGenerator*/
public static Style<T> IsCompact<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.CommandBarToggleButton 
=> style._addSetter(Avalonia.Controls.CommandBarToggleButton.IsCompactProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsCompact<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.CommandBarToggleButton 
=> style._addSetter(Avalonia.Controls.CommandBarToggleButton.IsCompactProperty, binding);


 // DynamicOverflowOrder

/*ValueStyleSetterGenerator*/
public static Style<T> DynamicOverflowOrder<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.CommandBarToggleButton 
=> style._addSetter(Avalonia.Controls.CommandBarToggleButton.DynamicOverflowOrderProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DynamicOverflowOrder<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.CommandBarToggleButton 
=> style._addSetter(Avalonia.Controls.CommandBarToggleButton.DynamicOverflowOrderProperty, binding);


 // LabelPosition

/*ValueStyleSetterGenerator*/
public static Style<T> LabelPosition<T>(this Style<T> style, Avalonia.Controls.CommandBarDefaultLabelPosition value) where T : Avalonia.Controls.CommandBarToggleButton 
=> style._addSetter(Avalonia.Controls.CommandBarToggleButton.LabelPositionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LabelPosition<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.CommandBarToggleButton 
=> style._addSetter(Avalonia.Controls.CommandBarToggleButton.LabelPositionProperty, binding);


 // IsInOverflow

/*ValueStyleSetterGenerator*/
public static Style<T> IsInOverflow<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.CommandBarToggleButton 
=> style._addSetter(Avalonia.Controls.CommandBarToggleButton.IsInOverflowProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsInOverflow<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.CommandBarToggleButton 
=> style._addSetter(Avalonia.Controls.CommandBarToggleButton.IsInOverflowProperty, binding);



}

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
public static partial class TabItem_MarkupExtensions
{
//================= Properties ======================//
 // IsSelected

/*ValueSetterGenerator*/
public static T IsSelected<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TabItem 
{
    control.IsSelected = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsSelected<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.TabItem 
   => control._set(Avalonia.Controls.TabItem.IsSelectedProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsSelected<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.TabItem 
   => control._set(Avalonia.Controls.TabItem.IsSelectedProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsSelected<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.TabItem 
   => control._set(Avalonia.Controls.TabItem.IsSelectedProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsSelected<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.TabItem 
   => control._setEx(Avalonia.Controls.TabItem.IsSelectedProperty!, obs, changed);


 // Icon

/*ValueSetterGenerator*/
public static T Icon<T>(this T control, System.Object? value) where T : Avalonia.Controls.TabItem 
{
    control.Icon = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Icon<T>(this T control, Func<System.Object?> func) where T : Avalonia.Controls.TabItem 
   => control._set(Avalonia.Controls.TabItem.IconProperty!, func);

/*SetterFromObservableGenerator*/
public static T Icon<T>(this T control, IObservable<System.Object?> obs) where T : Avalonia.Controls.TabItem 
   => control._set(Avalonia.Controls.TabItem.IconProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Icon<T>(this T control, ISubject<System.Object?> subject) where T : Avalonia.Controls.TabItem 
   => control._set(Avalonia.Controls.TabItem.IconProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Icon<T>(this T control, IObservable<System.Object?> obs, IObserver<System.Object?> changed) where T : Avalonia.Controls.TabItem 
   => control._setEx(Avalonia.Controls.TabItem.IconProperty!, obs, changed);


 // IconTemplate

/*ValueSetterGenerator*/
public static T IconTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.TabItem 
{
    control.IconTemplate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IconTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate?> func) where T : Avalonia.Controls.TabItem 
   => control._set(Avalonia.Controls.TabItem.IconTemplateProperty!, func);

/*SetterFromObservableGenerator*/
public static T IconTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs) where T : Avalonia.Controls.TabItem 
   => control._set(Avalonia.Controls.TabItem.IconTemplateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IconTemplate<T>(this T control, ISubject<Avalonia.Controls.Templates.IDataTemplate?> subject) where T : Avalonia.Controls.TabItem 
   => control._set(Avalonia.Controls.TabItem.IconTemplateProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IconTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs, IObserver<Avalonia.Controls.Templates.IDataTemplate?> changed) where T : Avalonia.Controls.TabItem 
   => control._setEx(Avalonia.Controls.TabItem.IconTemplateProperty!, obs, changed);


 // IndicatorTemplate

/*ValueSetterGenerator*/
public static T IndicatorTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.TabItem 
{
    control.IndicatorTemplate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IndicatorTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate?> func) where T : Avalonia.Controls.TabItem 
   => control._set(Avalonia.Controls.TabItem.IndicatorTemplateProperty!, func);

/*SetterFromObservableGenerator*/
public static T IndicatorTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs) where T : Avalonia.Controls.TabItem 
   => control._set(Avalonia.Controls.TabItem.IndicatorTemplateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IndicatorTemplate<T>(this T control, ISubject<Avalonia.Controls.Templates.IDataTemplate?> subject) where T : Avalonia.Controls.TabItem 
   => control._set(Avalonia.Controls.TabItem.IndicatorTemplateProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IndicatorTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs, IObserver<Avalonia.Controls.Templates.IDataTemplate?> changed) where T : Avalonia.Controls.TabItem 
   => control._setEx(Avalonia.Controls.TabItem.IndicatorTemplateProperty!, obs, changed);



//================= Styles ======================//
 // IsSelected

/*ValueStyleSetterGenerator*/
public static Style<T> IsSelected<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TabItem 
=> style._addSetter(Avalonia.Controls.TabItem.IsSelectedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsSelected<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.TabItem 
=> style._addSetter(Avalonia.Controls.TabItem.IsSelectedProperty, binding);


 // Icon

/*ValueStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.TabItem 
=> style._addSetter(Avalonia.Controls.TabItem.IconProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.TabItem 
=> style._addSetter(Avalonia.Controls.TabItem.IconProperty, binding);


 // IconTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> IconTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.TabItem 
=> style._addSetter(Avalonia.Controls.TabItem.IconTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IconTemplate<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.TabItem 
=> style._addSetter(Avalonia.Controls.TabItem.IconTemplateProperty, binding);


 // IndicatorTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> IndicatorTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.TabItem 
=> style._addSetter(Avalonia.Controls.TabItem.IndicatorTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IndicatorTemplate<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.TabItem 
=> style._addSetter(Avalonia.Controls.TabItem.IndicatorTemplateProperty, binding);



}

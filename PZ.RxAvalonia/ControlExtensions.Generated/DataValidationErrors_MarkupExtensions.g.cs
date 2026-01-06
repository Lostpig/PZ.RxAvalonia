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
public static partial class DataValidationErrors_MarkupExtensions
{
//================= Properties ======================//
 // ErrorTemplate

/*ValueSetterGenerator*/
public static T ErrorTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.DataValidationErrors 
{
    control.ErrorTemplate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ErrorTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func) where T : Avalonia.Controls.DataValidationErrors 
   => control._set(Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty!, func);

/*SetterFromObservableGenerator*/
public static T ErrorTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate> obs) where T : Avalonia.Controls.DataValidationErrors 
   => control._set(Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ErrorTemplate<T>(this T control, ISubject<Avalonia.Controls.Templates.IDataTemplate> subject) where T : Avalonia.Controls.DataValidationErrors 
   => control._set(Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ErrorTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate> obs, IObserver<Avalonia.Controls.Templates.IDataTemplate> changed) where T : Avalonia.Controls.DataValidationErrors 
   => control._setEx(Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty!, obs, changed);


 // Owner

/*ValueSetterGenerator*/
public static T Owner<T>(this T control, Avalonia.Controls.Control? value) where T : Avalonia.Controls.DataValidationErrors 
{
    control.Owner = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Owner<T>(this T control, Func<Avalonia.Controls.Control?> func) where T : Avalonia.Controls.DataValidationErrors 
   => control._set(Avalonia.Controls.DataValidationErrors.OwnerProperty!, func);

/*SetterFromObservableGenerator*/
public static T Owner<T>(this T control, IObservable<Avalonia.Controls.Control?> obs) where T : Avalonia.Controls.DataValidationErrors 
   => control._set(Avalonia.Controls.DataValidationErrors.OwnerProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Owner<T>(this T control, ISubject<Avalonia.Controls.Control?> subject) where T : Avalonia.Controls.DataValidationErrors 
   => control._set(Avalonia.Controls.DataValidationErrors.OwnerProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Owner<T>(this T control, IObservable<Avalonia.Controls.Control?> obs, IObserver<Avalonia.Controls.Control?> changed) where T : Avalonia.Controls.DataValidationErrors 
   => control._setEx(Avalonia.Controls.DataValidationErrors.OwnerProperty!, obs, changed);



//================= Attached Properties ======================//
 // Errors

/*AttachedPropertyFuncGenerator*/
public static T DataValidationErrors_Errors<T>(this T control, Func<System.Collections.Generic.IEnumerable<System.Object>> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.DataValidationErrors.ErrorsProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T DataValidationErrors_Errors<T>(this T control, IObservable<System.Collections.Generic.IEnumerable<System.Object>> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.DataValidationErrors.ErrorsProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T DataValidationErrors_Errors<T>(this T control, ISubject<System.Collections.Generic.IEnumerable<System.Object>> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.DataValidationErrors.ErrorsProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T DataValidationErrors_Errors<T>(this T control, System.Collections.Generic.IEnumerable<System.Object> value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.DataValidationErrors.ErrorsProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T DataValidationErrors_Errors<T>(this T control, IObservable<System.Collections.Generic.IEnumerable<System.Object>> obs, IObserver<System.Collections.Generic.IEnumerable<System.Object>> changed) where T : Avalonia.Controls.Control 
   => control._setEx(Avalonia.Controls.DataValidationErrors.ErrorsProperty!, obs, changed);


 // ErrorConverter

/*AttachedPropertyFuncGenerator*/
public static T DataValidationErrors_ErrorConverter<T>(this T control, Func<System.Func<System.Object,System.Object>> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.DataValidationErrors.ErrorConverterProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T DataValidationErrors_ErrorConverter<T>(this T control, IObservable<System.Func<System.Object,System.Object>> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.DataValidationErrors.ErrorConverterProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T DataValidationErrors_ErrorConverter<T>(this T control, ISubject<System.Func<System.Object,System.Object>> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.DataValidationErrors.ErrorConverterProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T DataValidationErrors_ErrorConverter<T>(this T control, System.Func<System.Object,System.Object> value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.DataValidationErrors.ErrorConverterProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T DataValidationErrors_ErrorConverter<T>(this T control, IObservable<System.Func<System.Object,System.Object>> obs, IObserver<System.Func<System.Object,System.Object>> changed) where T : Avalonia.Controls.Control 
   => control._setEx(Avalonia.Controls.DataValidationErrors.ErrorConverterProperty!, obs, changed);



//================= Styles ======================//
 // ErrorTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> ErrorTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.DataValidationErrors 
=> style._addSetter(Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ErrorTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DataValidationErrors 
=> style._addSetter(Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty, binding);



}

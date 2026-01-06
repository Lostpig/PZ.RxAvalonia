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
public static partial class ToggleSwitch_MarkupExtensions
{
//================= Properties ======================//
 // OffContent

/*ValueSetterGenerator*/
public static T OffContent<T>(this T control, System.Object? value) where T : Avalonia.Controls.ToggleSwitch 
{
    control.OffContent = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T OffContent<T>(this T control, Func<System.Object?> func) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.OffContentProperty!, func);

/*SetterFromObservableGenerator*/
public static T OffContent<T>(this T control, IObservable<System.Object?> obs) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.OffContentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T OffContent<T>(this T control, ISubject<System.Object?> subject) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.OffContentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T OffContent<T>(this T control, IObservable<System.Object?> obs, IObserver<System.Object?> changed) where T : Avalonia.Controls.ToggleSwitch 
   => control._setEx(Avalonia.Controls.ToggleSwitch.OffContentProperty!, obs, changed);


 // OffContentTemplate

/*ValueSetterGenerator*/
public static T OffContentTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.ToggleSwitch 
{
    control.OffContentTemplate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T OffContentTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate?> func) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty!, func);

/*SetterFromObservableGenerator*/
public static T OffContentTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T OffContentTemplate<T>(this T control, ISubject<Avalonia.Controls.Templates.IDataTemplate?> subject) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T OffContentTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs, IObserver<Avalonia.Controls.Templates.IDataTemplate?> changed) where T : Avalonia.Controls.ToggleSwitch 
   => control._setEx(Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty!, obs, changed);


 // OnContent

/*ValueSetterGenerator*/
public static T OnContent<T>(this T control, System.Object? value) where T : Avalonia.Controls.ToggleSwitch 
{
    control.OnContent = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T OnContent<T>(this T control, Func<System.Object?> func) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.OnContentProperty!, func);

/*SetterFromObservableGenerator*/
public static T OnContent<T>(this T control, IObservable<System.Object?> obs) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.OnContentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T OnContent<T>(this T control, ISubject<System.Object?> subject) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.OnContentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T OnContent<T>(this T control, IObservable<System.Object?> obs, IObserver<System.Object?> changed) where T : Avalonia.Controls.ToggleSwitch 
   => control._setEx(Avalonia.Controls.ToggleSwitch.OnContentProperty!, obs, changed);


 // OnContentTemplate

/*ValueSetterGenerator*/
public static T OnContentTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.ToggleSwitch 
{
    control.OnContentTemplate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T OnContentTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate?> func) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty!, func);

/*SetterFromObservableGenerator*/
public static T OnContentTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T OnContentTemplate<T>(this T control, ISubject<Avalonia.Controls.Templates.IDataTemplate?> subject) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T OnContentTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs, IObserver<Avalonia.Controls.Templates.IDataTemplate?> changed) where T : Avalonia.Controls.ToggleSwitch 
   => control._setEx(Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty!, obs, changed);


 // KnobTransitions

/*ValueSetterGenerator*/
public static T KnobTransitions<T>(this T control, Avalonia.Animation.Transitions value) where T : Avalonia.Controls.ToggleSwitch 
{
    control.KnobTransitions = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T KnobTransitions<T>(this T control, Func<Avalonia.Animation.Transitions> func) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.KnobTransitionsProperty!, func);

/*SetterFromObservableGenerator*/
public static T KnobTransitions<T>(this T control, IObservable<Avalonia.Animation.Transitions> obs) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.KnobTransitionsProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T KnobTransitions<T>(this T control, ISubject<Avalonia.Animation.Transitions> subject) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.KnobTransitionsProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T KnobTransitions<T>(this T control, IObservable<Avalonia.Animation.Transitions> obs, IObserver<Avalonia.Animation.Transitions> changed) where T : Avalonia.Controls.ToggleSwitch 
   => control._setEx(Avalonia.Controls.ToggleSwitch.KnobTransitionsProperty!, obs, changed);



//================= Styles ======================//
 // OffContent

/*ValueStyleSetterGenerator*/
public static Style<T> OffContent<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OffContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> OffContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OffContentProperty, binding);


 // OffContentTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> OffContentTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> OffContentTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty, binding);


 // OnContent

/*ValueStyleSetterGenerator*/
public static Style<T> OnContent<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OnContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> OnContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OnContentProperty, binding);


 // OnContentTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> OnContentTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> OnContentTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty, binding);


 // KnobTransitions

/*ValueStyleSetterGenerator*/
public static Style<T> KnobTransitions<T>(this Style<T> style, Avalonia.Animation.Transitions value) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.KnobTransitionsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> KnobTransitions<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.KnobTransitionsProperty, binding);



}

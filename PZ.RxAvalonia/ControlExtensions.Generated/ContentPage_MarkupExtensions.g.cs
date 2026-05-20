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
public static partial class ContentPage_MarkupExtensions
{
//================= Properties ======================//
 // Content

/*ValueSetterGenerator*/
public static T Content<T>(this T control, System.Object? value) where T : Avalonia.Controls.ContentPage 
{
    control.Content = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Content<T>(this T control, Func<System.Object?> func) where T : Avalonia.Controls.ContentPage 
   => control._set(Avalonia.Controls.ContentPage.ContentProperty!, func);

/*SetterFromObservableGenerator*/
public static T Content<T>(this T control, IObservable<System.Object?> obs) where T : Avalonia.Controls.ContentPage 
   => control._set(Avalonia.Controls.ContentPage.ContentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Content<T>(this T control, ISubject<System.Object?> subject) where T : Avalonia.Controls.ContentPage 
   => control._set(Avalonia.Controls.ContentPage.ContentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Content<T>(this T control, IObservable<System.Object?> obs, IObserver<System.Object?> changed) where T : Avalonia.Controls.ContentPage 
   => control._setEx(Avalonia.Controls.ContentPage.ContentProperty!, obs, changed);


 // ContentTemplate

/*ValueSetterGenerator*/
public static T ContentTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.ContentPage 
{
    control.ContentTemplate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ContentTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate?> func) where T : Avalonia.Controls.ContentPage 
   => control._set(Avalonia.Controls.ContentPage.ContentTemplateProperty!, func);

/*SetterFromObservableGenerator*/
public static T ContentTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs) where T : Avalonia.Controls.ContentPage 
   => control._set(Avalonia.Controls.ContentPage.ContentTemplateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ContentTemplate<T>(this T control, ISubject<Avalonia.Controls.Templates.IDataTemplate?> subject) where T : Avalonia.Controls.ContentPage 
   => control._set(Avalonia.Controls.ContentPage.ContentTemplateProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ContentTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs, IObserver<Avalonia.Controls.Templates.IDataTemplate?> changed) where T : Avalonia.Controls.ContentPage 
   => control._setEx(Avalonia.Controls.ContentPage.ContentTemplateProperty!, obs, changed);


 // AutomaticallyApplySafeAreaPadding

/*ValueSetterGenerator*/
public static T AutomaticallyApplySafeAreaPadding<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ContentPage 
{
    control.AutomaticallyApplySafeAreaPadding = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T AutomaticallyApplySafeAreaPadding<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.ContentPage 
   => control._set(Avalonia.Controls.ContentPage.AutomaticallyApplySafeAreaPaddingProperty!, func);

/*SetterFromObservableGenerator*/
public static T AutomaticallyApplySafeAreaPadding<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.ContentPage 
   => control._set(Avalonia.Controls.ContentPage.AutomaticallyApplySafeAreaPaddingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T AutomaticallyApplySafeAreaPadding<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.ContentPage 
   => control._set(Avalonia.Controls.ContentPage.AutomaticallyApplySafeAreaPaddingProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T AutomaticallyApplySafeAreaPadding<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.ContentPage 
   => control._setEx(Avalonia.Controls.ContentPage.AutomaticallyApplySafeAreaPaddingProperty!, obs, changed);


 // TopCommandBar

/*ValueSetterGenerator*/
public static T TopCommandBar<T>(this T control, System.Object? value) where T : Avalonia.Controls.ContentPage 
{
    control.TopCommandBar = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TopCommandBar<T>(this T control, Func<System.Object?> func) where T : Avalonia.Controls.ContentPage 
   => control._set(Avalonia.Controls.ContentPage.TopCommandBarProperty!, func);

/*SetterFromObservableGenerator*/
public static T TopCommandBar<T>(this T control, IObservable<System.Object?> obs) where T : Avalonia.Controls.ContentPage 
   => control._set(Avalonia.Controls.ContentPage.TopCommandBarProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TopCommandBar<T>(this T control, ISubject<System.Object?> subject) where T : Avalonia.Controls.ContentPage 
   => control._set(Avalonia.Controls.ContentPage.TopCommandBarProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T TopCommandBar<T>(this T control, IObservable<System.Object?> obs, IObserver<System.Object?> changed) where T : Avalonia.Controls.ContentPage 
   => control._setEx(Avalonia.Controls.ContentPage.TopCommandBarProperty!, obs, changed);


 // BottomCommandBar

/*ValueSetterGenerator*/
public static T BottomCommandBar<T>(this T control, System.Object? value) where T : Avalonia.Controls.ContentPage 
{
    control.BottomCommandBar = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T BottomCommandBar<T>(this T control, Func<System.Object?> func) where T : Avalonia.Controls.ContentPage 
   => control._set(Avalonia.Controls.ContentPage.BottomCommandBarProperty!, func);

/*SetterFromObservableGenerator*/
public static T BottomCommandBar<T>(this T control, IObservable<System.Object?> obs) where T : Avalonia.Controls.ContentPage 
   => control._set(Avalonia.Controls.ContentPage.BottomCommandBarProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T BottomCommandBar<T>(this T control, ISubject<System.Object?> subject) where T : Avalonia.Controls.ContentPage 
   => control._set(Avalonia.Controls.ContentPage.BottomCommandBarProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T BottomCommandBar<T>(this T control, IObservable<System.Object?> obs, IObserver<System.Object?> changed) where T : Avalonia.Controls.ContentPage 
   => control._setEx(Avalonia.Controls.ContentPage.BottomCommandBarProperty!, obs, changed);


 // HorizontalContentAlignment

/*ValueSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.ContentPage 
{
    control.HorizontalContentAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func) where T : Avalonia.Controls.ContentPage 
   => control._set(Avalonia.Controls.ContentPage.HorizontalContentAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T HorizontalContentAlignment<T>(this T control, IObservable<Avalonia.Layout.HorizontalAlignment> obs) where T : Avalonia.Controls.ContentPage 
   => control._set(Avalonia.Controls.ContentPage.HorizontalContentAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T HorizontalContentAlignment<T>(this T control, ISubject<Avalonia.Layout.HorizontalAlignment> subject) where T : Avalonia.Controls.ContentPage 
   => control._set(Avalonia.Controls.ContentPage.HorizontalContentAlignmentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T HorizontalContentAlignment<T>(this T control, IObservable<Avalonia.Layout.HorizontalAlignment> obs, IObserver<Avalonia.Layout.HorizontalAlignment> changed) where T : Avalonia.Controls.ContentPage 
   => control._setEx(Avalonia.Controls.ContentPage.HorizontalContentAlignmentProperty!, obs, changed);


 // VerticalContentAlignment

/*ValueSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.ContentPage 
{
    control.VerticalContentAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func) where T : Avalonia.Controls.ContentPage 
   => control._set(Avalonia.Controls.ContentPage.VerticalContentAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T VerticalContentAlignment<T>(this T control, IObservable<Avalonia.Layout.VerticalAlignment> obs) where T : Avalonia.Controls.ContentPage 
   => control._set(Avalonia.Controls.ContentPage.VerticalContentAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T VerticalContentAlignment<T>(this T control, ISubject<Avalonia.Layout.VerticalAlignment> subject) where T : Avalonia.Controls.ContentPage 
   => control._set(Avalonia.Controls.ContentPage.VerticalContentAlignmentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T VerticalContentAlignment<T>(this T control, IObservable<Avalonia.Layout.VerticalAlignment> obs, IObserver<Avalonia.Layout.VerticalAlignment> changed) where T : Avalonia.Controls.ContentPage 
   => control._setEx(Avalonia.Controls.ContentPage.VerticalContentAlignmentProperty!, obs, changed);



//================= Styles ======================//
 // Content

/*ValueStyleSetterGenerator*/
public static Style<T> Content<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.ContentPage 
=> style._addSetter(Avalonia.Controls.ContentPage.ContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Content<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.ContentPage 
=> style._addSetter(Avalonia.Controls.ContentPage.ContentProperty, binding);


 // ContentTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> ContentTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.ContentPage 
=> style._addSetter(Avalonia.Controls.ContentPage.ContentTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ContentTemplate<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.ContentPage 
=> style._addSetter(Avalonia.Controls.ContentPage.ContentTemplateProperty, binding);


 // AutomaticallyApplySafeAreaPadding

/*ValueStyleSetterGenerator*/
public static Style<T> AutomaticallyApplySafeAreaPadding<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ContentPage 
=> style._addSetter(Avalonia.Controls.ContentPage.AutomaticallyApplySafeAreaPaddingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AutomaticallyApplySafeAreaPadding<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.ContentPage 
=> style._addSetter(Avalonia.Controls.ContentPage.AutomaticallyApplySafeAreaPaddingProperty, binding);


 // TopCommandBar

/*ValueStyleSetterGenerator*/
public static Style<T> TopCommandBar<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.ContentPage 
=> style._addSetter(Avalonia.Controls.ContentPage.TopCommandBarProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TopCommandBar<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.ContentPage 
=> style._addSetter(Avalonia.Controls.ContentPage.TopCommandBarProperty, binding);


 // BottomCommandBar

/*ValueStyleSetterGenerator*/
public static Style<T> BottomCommandBar<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.ContentPage 
=> style._addSetter(Avalonia.Controls.ContentPage.BottomCommandBarProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BottomCommandBar<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.ContentPage 
=> style._addSetter(Avalonia.Controls.ContentPage.BottomCommandBarProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.ContentPage 
=> style._addSetter(Avalonia.Controls.ContentPage.HorizontalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.ContentPage 
=> style._addSetter(Avalonia.Controls.ContentPage.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.ContentPage 
=> style._addSetter(Avalonia.Controls.ContentPage.VerticalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.ContentPage 
=> style._addSetter(Avalonia.Controls.ContentPage.VerticalContentAlignmentProperty, binding);



}

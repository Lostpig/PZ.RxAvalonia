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
public static partial class ComboBox_MarkupExtensions
{
//================= Properties ======================//
 // IsDropDownOpen

/*ValueSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ComboBox 
{
    control.IsDropDownOpen = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsDropDownOpen<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.IsDropDownOpenProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsDropDownOpen<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.IsDropDownOpenProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsDropDownOpen<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.IsDropDownOpenProperty!, subject);


 // IsEditable

/*ValueSetterGenerator*/
public static T IsEditable<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ComboBox 
{
    control.IsEditable = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsEditable<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.IsEditableProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsEditable<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.IsEditableProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsEditable<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.IsEditableProperty!, subject);


 // MaxDropDownHeight

/*ValueSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.ComboBox 
{
    control.MaxDropDownHeight = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MaxDropDownHeight<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty!, func);

/*SetterFromObservableGenerator*/
public static T MaxDropDownHeight<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MaxDropDownHeight<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty!, subject);


 // PlaceholderText

/*ValueSetterGenerator*/
public static T PlaceholderText<T>(this T control, System.String value) where T : Avalonia.Controls.ComboBox 
{
    control.PlaceholderText = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PlaceholderText<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.PlaceholderTextProperty!, func);

/*SetterFromObservableGenerator*/
public static T PlaceholderText<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.PlaceholderTextProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PlaceholderText<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.PlaceholderTextProperty!, subject);


 // PlaceholderForeground

/*ValueSetterGenerator*/
public static T PlaceholderForeground<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.ComboBox 
{
    control.PlaceholderForeground = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PlaceholderForeground<T>(this T control, Func<Avalonia.Media.IBrush> func) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty!, func);

/*SetterFromObservableGenerator*/
public static T PlaceholderForeground<T>(this T control, IObservable<Avalonia.Media.IBrush> obs) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PlaceholderForeground<T>(this T control, ISubject<Avalonia.Media.IBrush> subject) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty!, subject);


 // HorizontalContentAlignment

/*ValueSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.ComboBox 
{
    control.HorizontalContentAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T HorizontalContentAlignment<T>(this T control, IObservable<Avalonia.Layout.HorizontalAlignment> obs) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T HorizontalContentAlignment<T>(this T control, ISubject<Avalonia.Layout.HorizontalAlignment> subject) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty!, subject);


 // VerticalContentAlignment

/*ValueSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.ComboBox 
{
    control.VerticalContentAlignment = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty!, func);

/*SetterFromObservableGenerator*/
public static T VerticalContentAlignment<T>(this T control, IObservable<Avalonia.Layout.VerticalAlignment> obs) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T VerticalContentAlignment<T>(this T control, ISubject<Avalonia.Layout.VerticalAlignment> subject) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty!, subject);


 // Text

/*ValueSetterGenerator*/
public static T Text<T>(this T control, System.String value) where T : Avalonia.Controls.ComboBox 
{
    control.Text = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Text<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.TextProperty!, func);

/*SetterFromObservableGenerator*/
public static T Text<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.TextProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Text<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.TextProperty!, subject);


 // SelectionBoxItemTemplate

/*ValueSetterGenerator*/
public static T SelectionBoxItemTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ComboBox 
{
    control.SelectionBoxItemTemplate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectionBoxItemTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectionBoxItemTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate> obs) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectionBoxItemTemplate<T>(this T control, ISubject<Avalonia.Controls.Templates.IDataTemplate> subject) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty!, subject);



//================= Events ======================//
 // DropDownClosed

/*ActionToEventGenerator*/
public static T OnDropDownClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.ComboBox  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.DropDownClosed += h);


 // DropDownOpened

/*ActionToEventGenerator*/
public static T OnDropDownOpened<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.ComboBox  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.DropDownOpened += h);



//================= Styles ======================//
 // IsDropDownOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsDropDownOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.IsDropDownOpenProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDropDownOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.IsDropDownOpenProperty, binding);


 // IsEditable

/*ValueStyleSetterGenerator*/
public static Style<T> IsEditable<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.IsEditableProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsEditable<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.IsEditableProperty, binding);


 // MaxDropDownHeight

/*ValueStyleSetterGenerator*/
public static Style<T> MaxDropDownHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxDropDownHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty, binding);


 // PlaceholderText

/*ValueStyleSetterGenerator*/
public static Style<T> PlaceholderText<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.PlaceholderTextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlaceholderText<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.PlaceholderTextProperty, binding);


 // PlaceholderForeground

/*ValueStyleSetterGenerator*/
public static Style<T> PlaceholderForeground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlaceholderForeground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty, binding);


 // Text

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.TextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.TextProperty, binding);


 // SelectionBoxItemTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionBoxItemTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionBoxItemTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty, binding);



}

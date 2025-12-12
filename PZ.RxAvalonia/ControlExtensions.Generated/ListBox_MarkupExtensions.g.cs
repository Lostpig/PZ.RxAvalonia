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
public static partial class ListBox_MarkupExtensions
{
//================= Properties ======================//
 // SelectedItems

/*ValueSetterGenerator*/
public static T SelectedItems<T>(this T control, System.Collections.IList value) where T : Avalonia.Controls.ListBox 
{
    control.SelectedItems = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectedItems<T>(this T control, Func<System.Collections.IList> func) where T : Avalonia.Controls.ListBox 
   => control._set(Avalonia.Controls.ListBox.SelectedItemsProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectedItems<T>(this T control, IObservable<System.Collections.IList> obs) where T : Avalonia.Controls.ListBox 
   => control._set(Avalonia.Controls.ListBox.SelectedItemsProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectedItems<T>(this T control, ISubject<System.Collections.IList> subject) where T : Avalonia.Controls.ListBox 
   => control._set(Avalonia.Controls.ListBox.SelectedItemsProperty!, subject);


 // Selection

/*ValueSetterGenerator*/
public static T Selection<T>(this T control, Avalonia.Controls.Selection.ISelectionModel value) where T : Avalonia.Controls.ListBox 
{
    control.Selection = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Selection<T>(this T control, Func<Avalonia.Controls.Selection.ISelectionModel> func) where T : Avalonia.Controls.ListBox 
   => control._set(Avalonia.Controls.ListBox.SelectionProperty!, func);

/*SetterFromObservableGenerator*/
public static T Selection<T>(this T control, IObservable<Avalonia.Controls.Selection.ISelectionModel> obs) where T : Avalonia.Controls.ListBox 
   => control._set(Avalonia.Controls.ListBox.SelectionProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Selection<T>(this T control, ISubject<Avalonia.Controls.Selection.ISelectionModel> subject) where T : Avalonia.Controls.ListBox 
   => control._set(Avalonia.Controls.ListBox.SelectionProperty!, subject);


 // SelectionMode

/*ValueSetterGenerator*/
public static T SelectionMode<T>(this T control, Avalonia.Controls.SelectionMode value) where T : Avalonia.Controls.ListBox 
{
    control.SelectionMode = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectionMode<T>(this T control, Func<Avalonia.Controls.SelectionMode> func) where T : Avalonia.Controls.ListBox 
   => control._set(Avalonia.Controls.ListBox.SelectionModeProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectionMode<T>(this T control, IObservable<Avalonia.Controls.SelectionMode> obs) where T : Avalonia.Controls.ListBox 
   => control._set(Avalonia.Controls.ListBox.SelectionModeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectionMode<T>(this T control, ISubject<Avalonia.Controls.SelectionMode> subject) where T : Avalonia.Controls.ListBox 
   => control._set(Avalonia.Controls.ListBox.SelectionModeProperty!, subject);



//================= Styles ======================//
 // SelectionMode

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionMode<T>(this Style<T> style, Avalonia.Controls.SelectionMode value) where T : Avalonia.Controls.ListBox 
=> style._addSetter(Avalonia.Controls.ListBox.SelectionModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ListBox 
=> style._addSetter(Avalonia.Controls.ListBox.SelectionModeProperty, binding);



}

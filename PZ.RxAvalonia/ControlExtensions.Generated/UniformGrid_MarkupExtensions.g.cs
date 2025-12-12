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
public static partial class UniformGrid_MarkupExtensions
{
//================= Properties ======================//
 // Rows

/*ValueSetterGenerator*/
public static T Rows<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Primitives.UniformGrid 
{
    control.Rows = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Rows<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.RowsProperty!, func);

/*SetterFromObservableGenerator*/
public static T Rows<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.RowsProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Rows<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.RowsProperty!, subject);


 // Columns

/*ValueSetterGenerator*/
public static T Columns<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Primitives.UniformGrid 
{
    control.Columns = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Columns<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty!, func);

/*SetterFromObservableGenerator*/
public static T Columns<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Columns<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty!, subject);


 // FirstColumn

/*ValueSetterGenerator*/
public static T FirstColumn<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Primitives.UniformGrid 
{
    control.FirstColumn = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FirstColumn<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty!, func);

/*SetterFromObservableGenerator*/
public static T FirstColumn<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FirstColumn<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty!, subject);


 // RowSpacing

/*ValueSetterGenerator*/
public static T RowSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.UniformGrid 
{
    control.RowSpacing = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T RowSpacing<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.RowSpacingProperty!, func);

/*SetterFromObservableGenerator*/
public static T RowSpacing<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.RowSpacingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T RowSpacing<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.RowSpacingProperty!, subject);


 // ColumnSpacing

/*ValueSetterGenerator*/
public static T ColumnSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.UniformGrid 
{
    control.ColumnSpacing = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ColumnSpacing<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.ColumnSpacingProperty!, func);

/*SetterFromObservableGenerator*/
public static T ColumnSpacing<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.ColumnSpacingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ColumnSpacing<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.ColumnSpacingProperty!, subject);



//================= Styles ======================//
 // Rows

/*ValueStyleSetterGenerator*/
public static Style<T> Rows<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.RowsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Rows<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.RowsProperty, binding);


 // Columns

/*ValueStyleSetterGenerator*/
public static Style<T> Columns<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Columns<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty, binding);


 // FirstColumn

/*ValueStyleSetterGenerator*/
public static Style<T> FirstColumn<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FirstColumn<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty, binding);


 // RowSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> RowSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.RowSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RowSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.RowSpacingProperty, binding);


 // ColumnSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> ColumnSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.ColumnSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ColumnSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.ColumnSpacingProperty, binding);



}

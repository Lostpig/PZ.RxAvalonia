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
public static partial class Grid_MarkupExtensions
{
//================= Properties ======================//
 // ShowGridLines

/*ValueSetterGenerator*/
public static T ShowGridLines<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Grid 
{
    control.ShowGridLines = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ShowGridLines<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Grid 
   => control._set(Avalonia.Controls.Grid.ShowGridLinesProperty!, func);

/*SetterFromObservableGenerator*/
public static T ShowGridLines<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Grid 
   => control._set(Avalonia.Controls.Grid.ShowGridLinesProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ShowGridLines<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Grid 
   => control._set(Avalonia.Controls.Grid.ShowGridLinesProperty!, subject);


 // RowSpacing

/*ValueSetterGenerator*/
public static T RowSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.Grid 
{
    control.RowSpacing = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T RowSpacing<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Grid 
   => control._set(Avalonia.Controls.Grid.RowSpacingProperty!, func);

/*SetterFromObservableGenerator*/
public static T RowSpacing<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Grid 
   => control._set(Avalonia.Controls.Grid.RowSpacingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T RowSpacing<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Grid 
   => control._set(Avalonia.Controls.Grid.RowSpacingProperty!, subject);


 // ColumnSpacing

/*ValueSetterGenerator*/
public static T ColumnSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.Grid 
{
    control.ColumnSpacing = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ColumnSpacing<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Grid 
   => control._set(Avalonia.Controls.Grid.ColumnSpacingProperty!, func);

/*SetterFromObservableGenerator*/
public static T ColumnSpacing<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Grid 
   => control._set(Avalonia.Controls.Grid.ColumnSpacingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ColumnSpacing<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Grid 
   => control._set(Avalonia.Controls.Grid.ColumnSpacingProperty!, subject);



//================= Attached Properties ======================//
 // Column

/*AttachedPropertyFuncGenerator*/
public static T Grid_Column<T>(this T control, Func<System.Int32> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Grid.ColumnProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T Grid_Column<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Grid.ColumnProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T Grid_Column<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Grid.ColumnProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T Grid_Column<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.Grid.ColumnProperty!, value);
    return control;
}


 // Row

/*AttachedPropertyFuncGenerator*/
public static T Grid_Row<T>(this T control, Func<System.Int32> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Grid.RowProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T Grid_Row<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Grid.RowProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T Grid_Row<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Grid.RowProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T Grid_Row<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.Grid.RowProperty!, value);
    return control;
}


 // ColumnSpan

/*AttachedPropertyFuncGenerator*/
public static T Grid_ColumnSpan<T>(this T control, Func<System.Int32> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Grid.ColumnSpanProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T Grid_ColumnSpan<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Grid.ColumnSpanProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T Grid_ColumnSpan<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Grid.ColumnSpanProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T Grid_ColumnSpan<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.Grid.ColumnSpanProperty!, value);
    return control;
}


 // RowSpan

/*AttachedPropertyFuncGenerator*/
public static T Grid_RowSpan<T>(this T control, Func<System.Int32> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Grid.RowSpanProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T Grid_RowSpan<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Grid.RowSpanProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T Grid_RowSpan<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Grid.RowSpanProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T Grid_RowSpan<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.Grid.RowSpanProperty!, value);
    return control;
}


 // IsSharedSizeScope

/*AttachedPropertyFuncGenerator*/
public static T Grid_IsSharedSizeScope<T>(this T control, Func<System.Boolean> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Grid.IsSharedSizeScopeProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T Grid_IsSharedSizeScope<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Grid.IsSharedSizeScopeProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T Grid_IsSharedSizeScope<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Grid.IsSharedSizeScopeProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T Grid_IsSharedSizeScope<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.Grid.IsSharedSizeScopeProperty!, value);
    return control;
}



//================= Styles ======================//
 // ShowGridLines

/*ValueStyleSetterGenerator*/
public static Style<T> ShowGridLines<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Grid 
=> style._addSetter(Avalonia.Controls.Grid.ShowGridLinesProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowGridLines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Grid 
=> style._addSetter(Avalonia.Controls.Grid.ShowGridLinesProperty, binding);


 // RowSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> RowSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Grid 
=> style._addSetter(Avalonia.Controls.Grid.RowSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RowSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Grid 
=> style._addSetter(Avalonia.Controls.Grid.RowSpacingProperty, binding);


 // ColumnSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> ColumnSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Grid 
=> style._addSetter(Avalonia.Controls.Grid.ColumnSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ColumnSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Grid 
=> style._addSetter(Avalonia.Controls.Grid.ColumnSpacingProperty, binding);



}

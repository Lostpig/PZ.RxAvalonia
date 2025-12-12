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
public static partial class CalendarItem_MarkupExtensions
{
//================= Properties ======================//
 // HeaderBackground

/*ValueSetterGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem HeaderBackground(this Avalonia.Controls.Primitives.CalendarItem control, Avalonia.Media.IBrush value)  
{
    control.HeaderBackground = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem HeaderBackground(this Avalonia.Controls.Primitives.CalendarItem control, Func<Avalonia.Media.IBrush> func)  
   => control._set(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem HeaderBackground(this Avalonia.Controls.Primitives.CalendarItem control, IObservable<Avalonia.Media.IBrush> obs)  
   => control._set(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem HeaderBackground(this Avalonia.Controls.Primitives.CalendarItem control, ISubject<Avalonia.Media.IBrush> subject)  
   => control._set(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty!, subject);


 // DayTitleTemplate

/*ValueSetterGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem DayTitleTemplate(this Avalonia.Controls.Primitives.CalendarItem control, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value)  
{
    control.DayTitleTemplate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem DayTitleTemplate(this Avalonia.Controls.Primitives.CalendarItem control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> func)  
   => control._set(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem DayTitleTemplate(this Avalonia.Controls.Primitives.CalendarItem control, IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> obs)  
   => control._set(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem DayTitleTemplate(this Avalonia.Controls.Primitives.CalendarItem control, ISubject<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> subject)  
   => control._set(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty!, subject);



//================= Styles ======================//
 // HeaderBackground

/*ValueStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.CalendarItem> HeaderBackground(this Style<Avalonia.Controls.Primitives.CalendarItem> style, Avalonia.Media.IBrush value)  
=> style._addSetter(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.CalendarItem> HeaderBackground(this Style<Avalonia.Controls.Primitives.CalendarItem> style, IBinding binding)  
=> style._addSetter(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty, binding);


 // DayTitleTemplate

/*ValueStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.CalendarItem> DayTitleTemplate(this Style<Avalonia.Controls.Primitives.CalendarItem> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value)  
=> style._addSetter(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.CalendarItem> DayTitleTemplate(this Style<Avalonia.Controls.Primitives.CalendarItem> style, IBinding binding)  
=> style._addSetter(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty, binding);



}

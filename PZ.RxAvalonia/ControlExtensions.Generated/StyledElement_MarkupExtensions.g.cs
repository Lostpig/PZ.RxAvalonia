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
public static partial class StyledElement_MarkupExtensions
{
//================= Properties ======================//
 // DataContext

/*ValueSetterGenerator*/
public static T DataContext<T>(this T control, System.Object value) where T : Avalonia.StyledElement 
{
    control.DataContext = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DataContext<T>(this T control, Func<System.Object> func) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.DataContextProperty!, func);

/*SetterFromObservableGenerator*/
public static T DataContext<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.DataContextProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DataContext<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.DataContextProperty!, subject);


 // Name

/*ValueSetterGenerator*/
public static T Name<T>(this T control, System.String value) where T : Avalonia.StyledElement 
{
    control.Name = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Name<T>(this T control, Func<System.String> func) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.NameProperty!, func);

/*SetterFromObservableGenerator*/
public static T Name<T>(this T control, IObservable<System.String> obs) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.NameProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Name<T>(this T control, ISubject<System.String> subject) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.NameProperty!, subject);


 // Theme

/*ValueSetterGenerator*/
public static T Theme<T>(this T control, Avalonia.Styling.ControlTheme value) where T : Avalonia.StyledElement 
{
    control.Theme = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Theme<T>(this T control, Func<Avalonia.Styling.ControlTheme> func) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.ThemeProperty!, func);

/*SetterFromObservableGenerator*/
public static T Theme<T>(this T control, IObservable<Avalonia.Styling.ControlTheme> obs) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.ThemeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Theme<T>(this T control, ISubject<Avalonia.Styling.ControlTheme> subject) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.ThemeProperty!, subject);



//================= Events ======================//
 // AttachedToLogicalTree

/*ActionToEventGenerator*/
public static T OnAttachedToLogicalTree<T>(this T control, Action<Avalonia.LogicalTree.LogicalTreeAttachmentEventArgs> action) where T : Avalonia.StyledElement  => 
 control._setEvent((System.EventHandler<Avalonia.LogicalTree.LogicalTreeAttachmentEventArgs>) ((arg0, arg1) => action(arg1)), h => control.AttachedToLogicalTree += h);


 // DetachedFromLogicalTree

/*ActionToEventGenerator*/
public static T OnDetachedFromLogicalTree<T>(this T control, Action<Avalonia.LogicalTree.LogicalTreeAttachmentEventArgs> action) where T : Avalonia.StyledElement  => 
 control._setEvent((System.EventHandler<Avalonia.LogicalTree.LogicalTreeAttachmentEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DetachedFromLogicalTree += h);


 // DataContextChanged

/*ActionToEventGenerator*/
public static T OnDataContextChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.StyledElement  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.DataContextChanged += h);


 // Initialized

/*ActionToEventGenerator*/
public static T OnInitialized<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.StyledElement  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Initialized += h);


 // ResourcesChanged

/*ActionToEventGenerator*/
public static T OnResourcesChanged<T>(this T control, Action<Avalonia.Controls.ResourcesChangedEventArgs> action) where T : Avalonia.StyledElement  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ResourcesChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ResourcesChanged += h);


 // ActualThemeVariantChanged

/*ActionToEventGenerator*/
public static T OnActualThemeVariantChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.StyledElement  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.ActualThemeVariantChanged += h);



//================= Styles ======================//
 // DataContext

/*ValueStyleSetterGenerator*/
public static Style<T> DataContext<T>(this Style<T> style, System.Object value) where T : Avalonia.StyledElement 
=> style._addSetter(Avalonia.StyledElement.DataContextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DataContext<T>(this Style<T> style, IBinding binding) where T : Avalonia.StyledElement 
=> style._addSetter(Avalonia.StyledElement.DataContextProperty, binding);


 // Theme

/*ValueStyleSetterGenerator*/
public static Style<T> Theme<T>(this Style<T> style, Avalonia.Styling.ControlTheme value) where T : Avalonia.StyledElement 
=> style._addSetter(Avalonia.StyledElement.ThemeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Theme<T>(this Style<T> style, IBinding binding) where T : Avalonia.StyledElement 
=> style._addSetter(Avalonia.StyledElement.ThemeProperty, binding);



}

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
public static partial class SelectableTextBlock_MarkupExtensions
{
//================= Properties ======================//
 // SelectionStart

/*ValueSetterGenerator*/
public static T SelectionStart<T>(this T control, System.Int32 value) where T : Avalonia.Controls.SelectableTextBlock 
{
    control.SelectionStart = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectionStart<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionStartProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectionStart<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionStartProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectionStart<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionStartProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SelectionStart<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.SelectableTextBlock 
   => control._setEx(Avalonia.Controls.SelectableTextBlock.SelectionStartProperty!, obs, changed);


 // SelectionEnd

/*ValueSetterGenerator*/
public static T SelectionEnd<T>(this T control, System.Int32 value) where T : Avalonia.Controls.SelectableTextBlock 
{
    control.SelectionEnd = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectionEnd<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionEndProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectionEnd<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionEndProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectionEnd<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionEndProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SelectionEnd<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.SelectableTextBlock 
   => control._setEx(Avalonia.Controls.SelectableTextBlock.SelectionEndProperty!, obs, changed);


 // SelectionBrush

/*ValueSetterGenerator*/
public static T SelectionBrush<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.SelectableTextBlock 
{
    control.SelectionBrush = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectionBrush<T>(this T control, Func<Avalonia.Media.IBrush?> func) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionBrushProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectionBrush<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionBrushProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectionBrush<T>(this T control, ISubject<Avalonia.Media.IBrush?> subject) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionBrushProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SelectionBrush<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs, IObserver<Avalonia.Media.IBrush?> changed) where T : Avalonia.Controls.SelectableTextBlock 
   => control._setEx(Avalonia.Controls.SelectableTextBlock.SelectionBrushProperty!, obs, changed);


 // SelectionForegroundBrush

/*ValueSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.SelectableTextBlock 
{
    control.SelectionForegroundBrush = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectionForegroundBrush<T>(this T control, Func<Avalonia.Media.IBrush?> func) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionForegroundBrushProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectionForegroundBrush<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionForegroundBrushProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectionForegroundBrush<T>(this T control, ISubject<Avalonia.Media.IBrush?> subject) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionForegroundBrushProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SelectionForegroundBrush<T>(this T control, IObservable<Avalonia.Media.IBrush?> obs, IObserver<Avalonia.Media.IBrush?> changed) where T : Avalonia.Controls.SelectableTextBlock 
   => control._setEx(Avalonia.Controls.SelectableTextBlock.SelectionForegroundBrushProperty!, obs, changed);



//================= Events ======================//
 // CopyingToClipboard

/*ActionToEventGenerator*/
public static T OnCopyingToClipboard<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.SelectableTextBlock 
{
  control.AddHandler(Avalonia.Controls.SelectableTextBlock.CopyingToClipboardEvent, (_, args) => action(args), routes ?? Avalonia.Controls.SelectableTextBlock.CopyingToClipboardEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxCopyingToClipboard<T>(this T control, IObserver<Avalonia.Interactivity.RoutedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.SelectableTextBlock 
{
  control.AddHandler(Avalonia.Controls.SelectableTextBlock.CopyingToClipboardEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.SelectableTextBlock.CopyingToClipboardEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // SelectionStart

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionStart<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.SelectableTextBlock 
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionStartProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionStart<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SelectableTextBlock 
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionStartProperty, binding);


 // SelectionEnd

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionEnd<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.SelectableTextBlock 
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionEndProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionEnd<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SelectableTextBlock 
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionEndProperty, binding);


 // SelectionBrush

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionBrush<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.SelectableTextBlock 
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SelectableTextBlock 
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionBrushProperty, binding);


 // SelectionForegroundBrush

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, Avalonia.Media.IBrush? value) where T : Avalonia.Controls.SelectableTextBlock 
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionForegroundBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SelectableTextBlock 
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionForegroundBrushProperty, binding);



}

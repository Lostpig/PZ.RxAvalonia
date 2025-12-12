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
public static partial class GridSplitter_MarkupExtensions
{
//================= Properties ======================//
 // ResizeDirection

/*ValueSetterGenerator*/
public static T ResizeDirection<T>(this T control, Avalonia.Controls.GridResizeDirection value) where T : Avalonia.Controls.GridSplitter 
{
    control.ResizeDirection = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ResizeDirection<T>(this T control, Func<Avalonia.Controls.GridResizeDirection> func) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ResizeDirectionProperty!, func);

/*SetterFromObservableGenerator*/
public static T ResizeDirection<T>(this T control, IObservable<Avalonia.Controls.GridResizeDirection> obs) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ResizeDirectionProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ResizeDirection<T>(this T control, ISubject<Avalonia.Controls.GridResizeDirection> subject) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ResizeDirectionProperty!, subject);


 // ResizeBehavior

/*ValueSetterGenerator*/
public static T ResizeBehavior<T>(this T control, Avalonia.Controls.GridResizeBehavior value) where T : Avalonia.Controls.GridSplitter 
{
    control.ResizeBehavior = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ResizeBehavior<T>(this T control, Func<Avalonia.Controls.GridResizeBehavior> func) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty!, func);

/*SetterFromObservableGenerator*/
public static T ResizeBehavior<T>(this T control, IObservable<Avalonia.Controls.GridResizeBehavior> obs) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ResizeBehavior<T>(this T control, ISubject<Avalonia.Controls.GridResizeBehavior> subject) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty!, subject);


 // ShowsPreview

/*ValueSetterGenerator*/
public static T ShowsPreview<T>(this T control, System.Boolean value) where T : Avalonia.Controls.GridSplitter 
{
    control.ShowsPreview = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ShowsPreview<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ShowsPreviewProperty!, func);

/*SetterFromObservableGenerator*/
public static T ShowsPreview<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ShowsPreviewProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ShowsPreview<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ShowsPreviewProperty!, subject);


 // KeyboardIncrement

/*ValueSetterGenerator*/
public static T KeyboardIncrement<T>(this T control, System.Double value) where T : Avalonia.Controls.GridSplitter 
{
    control.KeyboardIncrement = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T KeyboardIncrement<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty!, func);

/*SetterFromObservableGenerator*/
public static T KeyboardIncrement<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T KeyboardIncrement<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty!, subject);


 // DragIncrement

/*ValueSetterGenerator*/
public static T DragIncrement<T>(this T control, System.Double value) where T : Avalonia.Controls.GridSplitter 
{
    control.DragIncrement = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DragIncrement<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.DragIncrementProperty!, func);

/*SetterFromObservableGenerator*/
public static T DragIncrement<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.DragIncrementProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DragIncrement<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.DragIncrementProperty!, subject);


 // PreviewContent

/*ValueSetterGenerator*/
public static T PreviewContent<T>(this T control, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value) where T : Avalonia.Controls.GridSplitter 
{
    control.PreviewContent = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PreviewContent<T>(this T control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> func) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.PreviewContentProperty!, func);

/*SetterFromObservableGenerator*/
public static T PreviewContent<T>(this T control, IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> obs) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.PreviewContentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PreviewContent<T>(this T control, ISubject<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> subject) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.PreviewContentProperty!, subject);



//================= Styles ======================//
 // ResizeDirection

/*ValueStyleSetterGenerator*/
public static Style<T> ResizeDirection<T>(this Style<T> style, Avalonia.Controls.GridResizeDirection value) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.ResizeDirectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ResizeDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.ResizeDirectionProperty, binding);


 // ResizeBehavior

/*ValueStyleSetterGenerator*/
public static Style<T> ResizeBehavior<T>(this Style<T> style, Avalonia.Controls.GridResizeBehavior value) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ResizeBehavior<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty, binding);


 // ShowsPreview

/*ValueStyleSetterGenerator*/
public static Style<T> ShowsPreview<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.ShowsPreviewProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowsPreview<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.ShowsPreviewProperty, binding);


 // KeyboardIncrement

/*ValueStyleSetterGenerator*/
public static Style<T> KeyboardIncrement<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> KeyboardIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty, binding);


 // DragIncrement

/*ValueStyleSetterGenerator*/
public static Style<T> DragIncrement<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.DragIncrementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DragIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.DragIncrementProperty, binding);


 // PreviewContent

/*ValueStyleSetterGenerator*/
public static Style<T> PreviewContent<T>(this Style<T> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.PreviewContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PreviewContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.PreviewContentProperty, binding);



}

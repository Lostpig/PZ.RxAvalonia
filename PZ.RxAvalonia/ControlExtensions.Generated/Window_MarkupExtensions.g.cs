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
public static partial class Window_MarkupExtensions
{
//================= Properties ======================//
 // SizeToContent

/*ValueSetterGenerator*/
public static T SizeToContent<T>(this T control, Avalonia.Controls.SizeToContent value) where T : Avalonia.Controls.Window 
{
    control.SizeToContent = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SizeToContent<T>(this T control, Func<Avalonia.Controls.SizeToContent> func) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.SizeToContentProperty!, func);

/*SetterFromObservableGenerator*/
public static T SizeToContent<T>(this T control, IObservable<Avalonia.Controls.SizeToContent> obs) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.SizeToContentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SizeToContent<T>(this T control, ISubject<Avalonia.Controls.SizeToContent> subject) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.SizeToContentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SizeToContent<T>(this T control, IObservable<Avalonia.Controls.SizeToContent> obs, IObserver<Avalonia.Controls.SizeToContent> changed) where T : Avalonia.Controls.Window 
   => control._setEx(Avalonia.Controls.Window.SizeToContentProperty!, obs, changed);


 // ExtendClientAreaToDecorationsHint

/*ValueSetterGenerator*/
public static T ExtendClientAreaToDecorationsHint<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Window 
{
    control.ExtendClientAreaToDecorationsHint = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ExtendClientAreaToDecorationsHint<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty!, func);

/*SetterFromObservableGenerator*/
public static T ExtendClientAreaToDecorationsHint<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ExtendClientAreaToDecorationsHint<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ExtendClientAreaToDecorationsHint<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Window 
   => control._setEx(Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty!, obs, changed);


 // ExtendClientAreaChromeHints

/*ValueSetterGenerator*/
public static T ExtendClientAreaChromeHints<T>(this T control, Avalonia.Platform.ExtendClientAreaChromeHints value) where T : Avalonia.Controls.Window 
{
    control.ExtendClientAreaChromeHints = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ExtendClientAreaChromeHints<T>(this T control, Func<Avalonia.Platform.ExtendClientAreaChromeHints> func) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty!, func);

/*SetterFromObservableGenerator*/
public static T ExtendClientAreaChromeHints<T>(this T control, IObservable<Avalonia.Platform.ExtendClientAreaChromeHints> obs) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ExtendClientAreaChromeHints<T>(this T control, ISubject<Avalonia.Platform.ExtendClientAreaChromeHints> subject) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ExtendClientAreaChromeHints<T>(this T control, IObservable<Avalonia.Platform.ExtendClientAreaChromeHints> obs, IObserver<Avalonia.Platform.ExtendClientAreaChromeHints> changed) where T : Avalonia.Controls.Window 
   => control._setEx(Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty!, obs, changed);


 // ExtendClientAreaTitleBarHeightHint

/*ValueSetterGenerator*/
public static T ExtendClientAreaTitleBarHeightHint<T>(this T control, System.Double value) where T : Avalonia.Controls.Window 
{
    control.ExtendClientAreaTitleBarHeightHint = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ExtendClientAreaTitleBarHeightHint<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty!, func);

/*SetterFromObservableGenerator*/
public static T ExtendClientAreaTitleBarHeightHint<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ExtendClientAreaTitleBarHeightHint<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ExtendClientAreaTitleBarHeightHint<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.Window 
   => control._setEx(Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty!, obs, changed);


 // SystemDecorations

/*ValueSetterGenerator*/
public static T SystemDecorations<T>(this T control, Avalonia.Controls.SystemDecorations value) where T : Avalonia.Controls.Window 
{
    control.SystemDecorations = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SystemDecorations<T>(this T control, Func<Avalonia.Controls.SystemDecorations> func) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.SystemDecorationsProperty!, func);

/*SetterFromObservableGenerator*/
public static T SystemDecorations<T>(this T control, IObservable<Avalonia.Controls.SystemDecorations> obs) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.SystemDecorationsProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SystemDecorations<T>(this T control, ISubject<Avalonia.Controls.SystemDecorations> subject) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.SystemDecorationsProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SystemDecorations<T>(this T control, IObservable<Avalonia.Controls.SystemDecorations> obs, IObserver<Avalonia.Controls.SystemDecorations> changed) where T : Avalonia.Controls.Window 
   => control._setEx(Avalonia.Controls.Window.SystemDecorationsProperty!, obs, changed);


 // ShowActivated

/*ValueSetterGenerator*/
public static T ShowActivated<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Window 
{
    control.ShowActivated = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ShowActivated<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ShowActivatedProperty!, func);

/*SetterFromObservableGenerator*/
public static T ShowActivated<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ShowActivatedProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ShowActivated<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ShowActivatedProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ShowActivated<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Window 
   => control._setEx(Avalonia.Controls.Window.ShowActivatedProperty!, obs, changed);


 // ShowInTaskbar

/*ValueSetterGenerator*/
public static T ShowInTaskbar<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Window 
{
    control.ShowInTaskbar = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ShowInTaskbar<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ShowInTaskbarProperty!, func);

/*SetterFromObservableGenerator*/
public static T ShowInTaskbar<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ShowInTaskbarProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ShowInTaskbar<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ShowInTaskbarProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ShowInTaskbar<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Window 
   => control._setEx(Avalonia.Controls.Window.ShowInTaskbarProperty!, obs, changed);


 // ClosingBehavior

/*ValueSetterGenerator*/
public static T ClosingBehavior<T>(this T control, Avalonia.Controls.WindowClosingBehavior value) where T : Avalonia.Controls.Window 
{
    control.ClosingBehavior = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ClosingBehavior<T>(this T control, Func<Avalonia.Controls.WindowClosingBehavior> func) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ClosingBehaviorProperty!, func);

/*SetterFromObservableGenerator*/
public static T ClosingBehavior<T>(this T control, IObservable<Avalonia.Controls.WindowClosingBehavior> obs) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ClosingBehaviorProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ClosingBehavior<T>(this T control, ISubject<Avalonia.Controls.WindowClosingBehavior> subject) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ClosingBehaviorProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ClosingBehavior<T>(this T control, IObservable<Avalonia.Controls.WindowClosingBehavior> obs, IObserver<Avalonia.Controls.WindowClosingBehavior> changed) where T : Avalonia.Controls.Window 
   => control._setEx(Avalonia.Controls.Window.ClosingBehaviorProperty!, obs, changed);


 // WindowState

/*ValueSetterGenerator*/
public static T WindowState<T>(this T control, Avalonia.Controls.WindowState value) where T : Avalonia.Controls.Window 
{
    control.WindowState = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T WindowState<T>(this T control, Func<Avalonia.Controls.WindowState> func) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.WindowStateProperty!, func);

/*SetterFromObservableGenerator*/
public static T WindowState<T>(this T control, IObservable<Avalonia.Controls.WindowState> obs) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.WindowStateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T WindowState<T>(this T control, ISubject<Avalonia.Controls.WindowState> subject) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.WindowStateProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T WindowState<T>(this T control, IObservable<Avalonia.Controls.WindowState> obs, IObserver<Avalonia.Controls.WindowState> changed) where T : Avalonia.Controls.Window 
   => control._setEx(Avalonia.Controls.Window.WindowStateProperty!, obs, changed);


 // Title

/*ValueSetterGenerator*/
public static T Title<T>(this T control, System.String value) where T : Avalonia.Controls.Window 
{
    control.Title = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Title<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.TitleProperty!, func);

/*SetterFromObservableGenerator*/
public static T Title<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.TitleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Title<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.TitleProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Title<T>(this T control, IObservable<System.String> obs, IObserver<System.String> changed) where T : Avalonia.Controls.Window 
   => control._setEx(Avalonia.Controls.Window.TitleProperty!, obs, changed);


 // Icon

/*ValueSetterGenerator*/
public static T Icon<T>(this T control, Avalonia.Controls.WindowIcon value) where T : Avalonia.Controls.Window 
{
    control.Icon = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Icon<T>(this T control, Func<Avalonia.Controls.WindowIcon> func) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.IconProperty!, func);

/*SetterFromObservableGenerator*/
public static T Icon<T>(this T control, IObservable<Avalonia.Controls.WindowIcon> obs) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.IconProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Icon<T>(this T control, ISubject<Avalonia.Controls.WindowIcon> subject) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.IconProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Icon<T>(this T control, IObservable<Avalonia.Controls.WindowIcon> obs, IObserver<Avalonia.Controls.WindowIcon> changed) where T : Avalonia.Controls.Window 
   => control._setEx(Avalonia.Controls.Window.IconProperty!, obs, changed);


 // WindowStartupLocation

/*ValueSetterGenerator*/
public static T WindowStartupLocation<T>(this T control, Avalonia.Controls.WindowStartupLocation value) where T : Avalonia.Controls.Window 
{
    control.WindowStartupLocation = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T WindowStartupLocation<T>(this T control, Func<Avalonia.Controls.WindowStartupLocation> func) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.WindowStartupLocationProperty!, func);

/*SetterFromObservableGenerator*/
public static T WindowStartupLocation<T>(this T control, IObservable<Avalonia.Controls.WindowStartupLocation> obs) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.WindowStartupLocationProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T WindowStartupLocation<T>(this T control, ISubject<Avalonia.Controls.WindowStartupLocation> subject) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.WindowStartupLocationProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T WindowStartupLocation<T>(this T control, IObservable<Avalonia.Controls.WindowStartupLocation> obs, IObserver<Avalonia.Controls.WindowStartupLocation> changed) where T : Avalonia.Controls.Window 
   => control._setEx(Avalonia.Controls.Window.WindowStartupLocationProperty!, obs, changed);


 // CanResize

/*ValueSetterGenerator*/
public static T CanResize<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Window 
{
    control.CanResize = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CanResize<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanResizeProperty!, func);

/*SetterFromObservableGenerator*/
public static T CanResize<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanResizeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CanResize<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanResizeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T CanResize<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Window 
   => control._setEx(Avalonia.Controls.Window.CanResizeProperty!, obs, changed);


 // CanMinimize

/*ValueSetterGenerator*/
public static T CanMinimize<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Window 
{
    control.CanMinimize = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CanMinimize<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanMinimizeProperty!, func);

/*SetterFromObservableGenerator*/
public static T CanMinimize<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanMinimizeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CanMinimize<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanMinimizeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T CanMinimize<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Window 
   => control._setEx(Avalonia.Controls.Window.CanMinimizeProperty!, obs, changed);


 // CanMaximize

/*ValueSetterGenerator*/
public static T CanMaximize<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Window 
{
    control.CanMaximize = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CanMaximize<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanMaximizeProperty!, func);

/*SetterFromObservableGenerator*/
public static T CanMaximize<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanMaximizeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CanMaximize<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanMaximizeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T CanMaximize<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Window 
   => control._setEx(Avalonia.Controls.Window.CanMaximizeProperty!, obs, changed);



//================= Events ======================//
 // Closing

/*ActionToEventGenerator*/
public static T OnClosing<T>(this T control, Action<Avalonia.Controls.WindowClosingEventArgs> action) where T : Avalonia.Controls.Window  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.WindowClosingEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Closing += h);



//================= Styles ======================//
 // SizeToContent

/*ValueStyleSetterGenerator*/
public static Style<T> SizeToContent<T>(this Style<T> style, Avalonia.Controls.SizeToContent value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.SizeToContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SizeToContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.SizeToContentProperty, binding);


 // ExtendClientAreaToDecorationsHint

/*ValueStyleSetterGenerator*/
public static Style<T> ExtendClientAreaToDecorationsHint<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ExtendClientAreaToDecorationsHint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty, binding);


 // ExtendClientAreaChromeHints

/*ValueStyleSetterGenerator*/
public static Style<T> ExtendClientAreaChromeHints<T>(this Style<T> style, Avalonia.Platform.ExtendClientAreaChromeHints value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ExtendClientAreaChromeHints<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty, binding);


 // ExtendClientAreaTitleBarHeightHint

/*ValueStyleSetterGenerator*/
public static Style<T> ExtendClientAreaTitleBarHeightHint<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ExtendClientAreaTitleBarHeightHint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty, binding);


 // SystemDecorations

/*ValueStyleSetterGenerator*/
public static Style<T> SystemDecorations<T>(this Style<T> style, Avalonia.Controls.SystemDecorations value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.SystemDecorationsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SystemDecorations<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.SystemDecorationsProperty, binding);


 // ShowActivated

/*ValueStyleSetterGenerator*/
public static Style<T> ShowActivated<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ShowActivatedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowActivated<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ShowActivatedProperty, binding);


 // ShowInTaskbar

/*ValueStyleSetterGenerator*/
public static Style<T> ShowInTaskbar<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ShowInTaskbarProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowInTaskbar<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ShowInTaskbarProperty, binding);


 // ClosingBehavior

/*ValueStyleSetterGenerator*/
public static Style<T> ClosingBehavior<T>(this Style<T> style, Avalonia.Controls.WindowClosingBehavior value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ClosingBehaviorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ClosingBehavior<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ClosingBehaviorProperty, binding);


 // WindowState

/*ValueStyleSetterGenerator*/
public static Style<T> WindowState<T>(this Style<T> style, Avalonia.Controls.WindowState value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.WindowStateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> WindowState<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.WindowStateProperty, binding);


 // Title

/*ValueStyleSetterGenerator*/
public static Style<T> Title<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.TitleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Title<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.TitleProperty, binding);


 // Icon

/*ValueStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, Avalonia.Controls.WindowIcon value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.IconProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.IconProperty, binding);


 // WindowStartupLocation

/*ValueStyleSetterGenerator*/
public static Style<T> WindowStartupLocation<T>(this Style<T> style, Avalonia.Controls.WindowStartupLocation value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.WindowStartupLocationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> WindowStartupLocation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.WindowStartupLocationProperty, binding);


 // CanResize

/*ValueStyleSetterGenerator*/
public static Style<T> CanResize<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.CanResizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CanResize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.CanResizeProperty, binding);


 // CanMinimize

/*ValueStyleSetterGenerator*/
public static Style<T> CanMinimize<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.CanMinimizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CanMinimize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.CanMinimizeProperty, binding);


 // CanMaximize

/*ValueStyleSetterGenerator*/
public static Style<T> CanMaximize<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.CanMaximizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CanMaximize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.CanMaximizeProperty, binding);



}

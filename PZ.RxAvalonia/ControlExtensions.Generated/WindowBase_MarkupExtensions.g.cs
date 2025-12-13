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
public static partial class WindowBase_MarkupExtensions
{
//================= Properties ======================//
 // Topmost

/*ValueSetterGenerator*/
public static T Topmost<T>(this T control, System.Boolean value) where T : Avalonia.Controls.WindowBase 
{
    control.Topmost = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Topmost<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.WindowBase 
   => control._set(Avalonia.Controls.WindowBase.TopmostProperty!, func);

/*SetterFromObservableGenerator*/
public static T Topmost<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.WindowBase 
   => control._set(Avalonia.Controls.WindowBase.TopmostProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Topmost<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.WindowBase 
   => control._set(Avalonia.Controls.WindowBase.TopmostProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Topmost<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.WindowBase 
   => control._setEx(Avalonia.Controls.WindowBase.TopmostProperty!, obs, changed);



//================= Events ======================//
 // Activated

/*ActionToEventGenerator*/
public static T OnActivated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.WindowBase  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Activated += h);


 // Deactivated

/*ActionToEventGenerator*/
public static T OnDeactivated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.WindowBase  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Deactivated += h);


 // PositionChanged

/*ActionToEventGenerator*/
public static T OnPositionChanged<T>(this T control, Action<Avalonia.Controls.PixelPointEventArgs> action) where T : Avalonia.Controls.WindowBase  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.PixelPointEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PositionChanged += h);


 // Resized

/*ActionToEventGenerator*/
public static T OnResized<T>(this T control, Action<Avalonia.Controls.WindowResizedEventArgs> action) where T : Avalonia.Controls.WindowBase  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.WindowResizedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Resized += h);



//================= Styles ======================//
 // Topmost

/*ValueStyleSetterGenerator*/
public static Style<T> Topmost<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.WindowBase 
=> style._addSetter(Avalonia.Controls.WindowBase.TopmostProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Topmost<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WindowBase 
=> style._addSetter(Avalonia.Controls.WindowBase.TopmostProperty, binding);



}

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
public static partial class FlyoutBase_MarkupExtensions
{
//================= Attached Properties ======================//
 // AttachedFlyout

/*AttachedPropertyFuncGenerator*/
public static T FlyoutBase_AttachedFlyout<T>(this T control, Func<Avalonia.Controls.Primitives.FlyoutBase> getter) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T FlyoutBase_AttachedFlyout<T>(this T control, IObservable<Avalonia.Controls.Primitives.FlyoutBase> obs) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T FlyoutBase_AttachedFlyout<T>(this T control, ISubject<Avalonia.Controls.Primitives.FlyoutBase> subject) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T FlyoutBase_AttachedFlyout<T>(this T control, Avalonia.Controls.Primitives.FlyoutBase value) where T : Avalonia.Controls.Control 
{
    control.SetValue(Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T FlyoutBase_AttachedFlyout<T>(this T control, IObservable<Avalonia.Controls.Primitives.FlyoutBase> obs, IObserver<Avalonia.Controls.Primitives.FlyoutBase> changed) where T : Avalonia.Controls.Control 
   => control._setEx(Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty!, obs, changed);



//================= Events ======================//
 // Opened

/*ActionToEventGenerator*/
public static T OnOpened<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.FlyoutBase  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Opened += h);


 // Closed

/*ActionToEventGenerator*/
public static T OnClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.FlyoutBase  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Closed += h);



}

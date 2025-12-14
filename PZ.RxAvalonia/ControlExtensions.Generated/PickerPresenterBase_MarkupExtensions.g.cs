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
public static partial class PickerPresenterBase_MarkupExtensions
{
//================= Events ======================//
 // Confirmed

/*ActionToEventGenerator*/
public static T OnConfirmed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.PickerPresenterBase  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Confirmed += h);

/*ReactiveEventGenerator*/
public static T RxConfirmed<T>(this T control, IObserver<System.EventArgs> observer) where T : Avalonia.Controls.Primitives.PickerPresenterBase  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => observer.OnNext((arg1))), h => control.Confirmed += h);


 // Dismissed

/*ActionToEventGenerator*/
public static T OnDismissed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.PickerPresenterBase  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Dismissed += h);

/*ReactiveEventGenerator*/
public static T RxDismissed<T>(this T control, IObserver<System.EventArgs> observer) where T : Avalonia.Controls.Primitives.PickerPresenterBase  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => observer.OnNext((arg1))), h => control.Dismissed += h);



}

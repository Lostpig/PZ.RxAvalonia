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
public static partial class Styles_MarkupExtensions
{
//================= Events ======================//
 // CollectionChanged

/*ActionToEventGenerator*/
public static T OnCollectionChanged<T>(this T control, Action<System.Collections.Specialized.NotifyCollectionChangedEventArgs> action) where T : Avalonia.Styling.Styles  => 
 control._setEvent((System.Collections.Specialized.NotifyCollectionChangedEventHandler) ((arg0, arg1) => action(arg1)), h => control.CollectionChanged += h);

/*ReactiveEventGenerator*/
public static T RxCollectionChanged<T>(this T control, IObserver<System.Collections.Specialized.NotifyCollectionChangedEventArgs> observer) where T : Avalonia.Styling.Styles  => 
 control._setEvent((System.Collections.Specialized.NotifyCollectionChangedEventHandler) ((arg0, arg1) => observer.OnNext((arg1))), h => control.CollectionChanged += h);


 // OwnerChanged

/*ActionToEventGenerator*/
public static T OnOwnerChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Styling.Styles  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.OwnerChanged += h);

/*ReactiveEventGenerator*/
public static T RxOwnerChanged<T>(this T control, IObserver<System.EventArgs> observer) where T : Avalonia.Styling.Styles  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => observer.OnNext((arg1))), h => control.OwnerChanged += h);



}

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
public static partial class SelectingMultiPage_MarkupExtensions
{
//================= Properties ======================//
 // SelectedIndex

/*ValueSetterGenerator*/
public static T SelectedIndex<T>(this T control, System.Int32 value) where T : Avalonia.Controls.SelectingMultiPage 
{
    control.SelectedIndex = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectedIndex<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.SelectingMultiPage 
   => control._set(Avalonia.Controls.SelectingMultiPage.SelectedIndexProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectedIndex<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.SelectingMultiPage 
   => control._set(Avalonia.Controls.SelectingMultiPage.SelectedIndexProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectedIndex<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.SelectingMultiPage 
   => control._set(Avalonia.Controls.SelectingMultiPage.SelectedIndexProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SelectedIndex<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.SelectingMultiPage 
   => control._setEx(Avalonia.Controls.SelectingMultiPage.SelectedIndexProperty!, obs, changed);



//================= Events ======================//
 // SelectionChanged

/*ActionToEventGenerator*/
public static T OnSelectionChanged<T>(this T control, Action<Avalonia.Controls.PageSelectionChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.SelectingMultiPage 
{
  control.AddHandler(Avalonia.Controls.SelectingMultiPage.SelectionChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.SelectingMultiPage.SelectionChangedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxSelectionChanged<T>(this T control, IObserver<Avalonia.Controls.PageSelectionChangedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.SelectingMultiPage 
{
  control.AddHandler(Avalonia.Controls.SelectingMultiPage.SelectionChangedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.SelectingMultiPage.SelectionChangedEvent.RoutingStrategies);
  return control;
}




}

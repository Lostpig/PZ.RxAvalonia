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
public static partial class TreeViewItem_MarkupExtensions
{
//================= Properties ======================//
 // IsExpanded

/*ValueSetterGenerator*/
public static T IsExpanded<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TreeViewItem 
{
    control.IsExpanded = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsExpanded<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.TreeViewItem 
   => control._set(Avalonia.Controls.TreeViewItem.IsExpandedProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsExpanded<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.TreeViewItem 
   => control._set(Avalonia.Controls.TreeViewItem.IsExpandedProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsExpanded<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.TreeViewItem 
   => control._set(Avalonia.Controls.TreeViewItem.IsExpandedProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsExpanded<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.TreeViewItem 
   => control._setEx(Avalonia.Controls.TreeViewItem.IsExpandedProperty!, obs, changed);


 // IsSelected

/*ValueSetterGenerator*/
public static T IsSelected<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TreeViewItem 
{
    control.IsSelected = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsSelected<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.TreeViewItem 
   => control._set(Avalonia.Controls.TreeViewItem.IsSelectedProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsSelected<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.TreeViewItem 
   => control._set(Avalonia.Controls.TreeViewItem.IsSelectedProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsSelected<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.TreeViewItem 
   => control._set(Avalonia.Controls.TreeViewItem.IsSelectedProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsSelected<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.TreeViewItem 
   => control._setEx(Avalonia.Controls.TreeViewItem.IsSelectedProperty!, obs, changed);



//================= Events ======================//
 // Expanded

/*ActionToEventGenerator*/
public static T OnExpanded<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TreeViewItem 
{
  control.AddHandler(Avalonia.Controls.TreeViewItem.ExpandedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TreeViewItem.ExpandedEvent.RoutingStrategies);
  return control;
}



 // Collapsed

/*ActionToEventGenerator*/
public static T OnCollapsed<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TreeViewItem 
{
  control.AddHandler(Avalonia.Controls.TreeViewItem.CollapsedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TreeViewItem.CollapsedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // IsExpanded

/*ValueStyleSetterGenerator*/
public static Style<T> IsExpanded<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TreeViewItem 
=> style._addSetter(Avalonia.Controls.TreeViewItem.IsExpandedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsExpanded<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TreeViewItem 
=> style._addSetter(Avalonia.Controls.TreeViewItem.IsExpandedProperty, binding);


 // IsSelected

/*ValueStyleSetterGenerator*/
public static Style<T> IsSelected<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TreeViewItem 
=> style._addSetter(Avalonia.Controls.TreeViewItem.IsSelectedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsSelected<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TreeViewItem 
=> style._addSetter(Avalonia.Controls.TreeViewItem.IsSelectedProperty, binding);



}

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
public static partial class VirtualizingStackPanel_MarkupExtensions
{
//================= Properties ======================//
 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.VirtualizingStackPanel 
{
    control.Orientation = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(Avalonia.Controls.VirtualizingStackPanel.OrientationProperty!, func);

/*SetterFromObservableGenerator*/
public static T Orientation<T>(this T control, IObservable<Avalonia.Layout.Orientation> obs) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(Avalonia.Controls.VirtualizingStackPanel.OrientationProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Orientation<T>(this T control, ISubject<Avalonia.Layout.Orientation> subject) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(Avalonia.Controls.VirtualizingStackPanel.OrientationProperty!, subject);


 // AreHorizontalSnapPointsRegular

/*ValueSetterGenerator*/
public static T AreHorizontalSnapPointsRegular<T>(this T control, System.Boolean value) where T : Avalonia.Controls.VirtualizingStackPanel 
{
    control.AreHorizontalSnapPointsRegular = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T AreHorizontalSnapPointsRegular<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(Avalonia.Controls.VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty!, func);

/*SetterFromObservableGenerator*/
public static T AreHorizontalSnapPointsRegular<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(Avalonia.Controls.VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T AreHorizontalSnapPointsRegular<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(Avalonia.Controls.VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty!, subject);


 // AreVerticalSnapPointsRegular

/*ValueSetterGenerator*/
public static T AreVerticalSnapPointsRegular<T>(this T control, System.Boolean value) where T : Avalonia.Controls.VirtualizingStackPanel 
{
    control.AreVerticalSnapPointsRegular = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T AreVerticalSnapPointsRegular<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(Avalonia.Controls.VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty!, func);

/*SetterFromObservableGenerator*/
public static T AreVerticalSnapPointsRegular<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(Avalonia.Controls.VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T AreVerticalSnapPointsRegular<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(Avalonia.Controls.VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty!, subject);


 // CacheLength

/*ValueSetterGenerator*/
public static T CacheLength<T>(this T control, System.Double value) where T : Avalonia.Controls.VirtualizingStackPanel 
{
    control.CacheLength = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CacheLength<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(Avalonia.Controls.VirtualizingStackPanel.CacheLengthProperty!, func);

/*SetterFromObservableGenerator*/
public static T CacheLength<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(Avalonia.Controls.VirtualizingStackPanel.CacheLengthProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CacheLength<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(Avalonia.Controls.VirtualizingStackPanel.CacheLengthProperty!, subject);



//================= Events ======================//
 // HorizontalSnapPointsChanged

/*ActionToEventGenerator*/
public static T OnHorizontalSnapPointsChanged<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.VirtualizingStackPanel 
{
  control.AddHandler(Avalonia.Controls.VirtualizingStackPanel.HorizontalSnapPointsChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.VirtualizingStackPanel.HorizontalSnapPointsChangedEvent.RoutingStrategies);
  return control;
}



 // VerticalSnapPointsChanged

/*ActionToEventGenerator*/
public static T OnVerticalSnapPointsChanged<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.VirtualizingStackPanel 
{
  control.AddHandler(Avalonia.Controls.VirtualizingStackPanel.VerticalSnapPointsChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.VirtualizingStackPanel.VerticalSnapPointsChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.VirtualizingStackPanel 
=> style._addSetter(Avalonia.Controls.VirtualizingStackPanel.OrientationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.VirtualizingStackPanel 
=> style._addSetter(Avalonia.Controls.VirtualizingStackPanel.OrientationProperty, binding);


 // AreHorizontalSnapPointsRegular

/*ValueStyleSetterGenerator*/
public static Style<T> AreHorizontalSnapPointsRegular<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.VirtualizingStackPanel 
=> style._addSetter(Avalonia.Controls.VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AreHorizontalSnapPointsRegular<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.VirtualizingStackPanel 
=> style._addSetter(Avalonia.Controls.VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty, binding);


 // AreVerticalSnapPointsRegular

/*ValueStyleSetterGenerator*/
public static Style<T> AreVerticalSnapPointsRegular<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.VirtualizingStackPanel 
=> style._addSetter(Avalonia.Controls.VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AreVerticalSnapPointsRegular<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.VirtualizingStackPanel 
=> style._addSetter(Avalonia.Controls.VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty, binding);


 // CacheLength

/*ValueStyleSetterGenerator*/
public static Style<T> CacheLength<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.VirtualizingStackPanel 
=> style._addSetter(Avalonia.Controls.VirtualizingStackPanel.CacheLengthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CacheLength<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.VirtualizingStackPanel 
=> style._addSetter(Avalonia.Controls.VirtualizingStackPanel.CacheLengthProperty, binding);



}

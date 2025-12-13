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
public static partial class StackPanel_MarkupExtensions
{
//================= Properties ======================//
 // Spacing

/*ValueSetterGenerator*/
public static T Spacing<T>(this T control, System.Double value) where T : Avalonia.Controls.StackPanel 
{
    control.Spacing = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Spacing<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.StackPanel 
   => control._set(Avalonia.Controls.StackPanel.SpacingProperty!, func);

/*SetterFromObservableGenerator*/
public static T Spacing<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.StackPanel 
   => control._set(Avalonia.Controls.StackPanel.SpacingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Spacing<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.StackPanel 
   => control._set(Avalonia.Controls.StackPanel.SpacingProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Spacing<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.StackPanel 
   => control._setEx(Avalonia.Controls.StackPanel.SpacingProperty!, obs, changed);


 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.StackPanel 
{
    control.Orientation = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func) where T : Avalonia.Controls.StackPanel 
   => control._set(Avalonia.Controls.StackPanel.OrientationProperty!, func);

/*SetterFromObservableGenerator*/
public static T Orientation<T>(this T control, IObservable<Avalonia.Layout.Orientation> obs) where T : Avalonia.Controls.StackPanel 
   => control._set(Avalonia.Controls.StackPanel.OrientationProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Orientation<T>(this T control, ISubject<Avalonia.Layout.Orientation> subject) where T : Avalonia.Controls.StackPanel 
   => control._set(Avalonia.Controls.StackPanel.OrientationProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Orientation<T>(this T control, IObservable<Avalonia.Layout.Orientation> obs, IObserver<Avalonia.Layout.Orientation> changed) where T : Avalonia.Controls.StackPanel 
   => control._setEx(Avalonia.Controls.StackPanel.OrientationProperty!, obs, changed);


 // AreHorizontalSnapPointsRegular

/*ValueSetterGenerator*/
public static T AreHorizontalSnapPointsRegular<T>(this T control, System.Boolean value) where T : Avalonia.Controls.StackPanel 
{
    control.AreHorizontalSnapPointsRegular = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T AreHorizontalSnapPointsRegular<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.StackPanel 
   => control._set(Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty!, func);

/*SetterFromObservableGenerator*/
public static T AreHorizontalSnapPointsRegular<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.StackPanel 
   => control._set(Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T AreHorizontalSnapPointsRegular<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.StackPanel 
   => control._set(Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T AreHorizontalSnapPointsRegular<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.StackPanel 
   => control._setEx(Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty!, obs, changed);


 // AreVerticalSnapPointsRegular

/*ValueSetterGenerator*/
public static T AreVerticalSnapPointsRegular<T>(this T control, System.Boolean value) where T : Avalonia.Controls.StackPanel 
{
    control.AreVerticalSnapPointsRegular = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T AreVerticalSnapPointsRegular<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.StackPanel 
   => control._set(Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty!, func);

/*SetterFromObservableGenerator*/
public static T AreVerticalSnapPointsRegular<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.StackPanel 
   => control._set(Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T AreVerticalSnapPointsRegular<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.StackPanel 
   => control._set(Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T AreVerticalSnapPointsRegular<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.StackPanel 
   => control._setEx(Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty!, obs, changed);



//================= Events ======================//
 // HorizontalSnapPointsChanged

/*ActionToEventGenerator*/
public static T OnHorizontalSnapPointsChanged<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.StackPanel 
{
  control.AddHandler(Avalonia.Controls.StackPanel.HorizontalSnapPointsChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.StackPanel.HorizontalSnapPointsChangedEvent.RoutingStrategies);
  return control;
}



 // VerticalSnapPointsChanged

/*ActionToEventGenerator*/
public static T OnVerticalSnapPointsChanged<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.StackPanel 
{
  control.AddHandler(Avalonia.Controls.StackPanel.VerticalSnapPointsChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.StackPanel.VerticalSnapPointsChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // Spacing

/*ValueStyleSetterGenerator*/
public static Style<T> Spacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.StackPanel 
=> style._addSetter(Avalonia.Controls.StackPanel.SpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Spacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.StackPanel 
=> style._addSetter(Avalonia.Controls.StackPanel.SpacingProperty, binding);


 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.StackPanel 
=> style._addSetter(Avalonia.Controls.StackPanel.OrientationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.StackPanel 
=> style._addSetter(Avalonia.Controls.StackPanel.OrientationProperty, binding);


 // AreHorizontalSnapPointsRegular

/*ValueStyleSetterGenerator*/
public static Style<T> AreHorizontalSnapPointsRegular<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.StackPanel 
=> style._addSetter(Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AreHorizontalSnapPointsRegular<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.StackPanel 
=> style._addSetter(Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty, binding);


 // AreVerticalSnapPointsRegular

/*ValueStyleSetterGenerator*/
public static Style<T> AreVerticalSnapPointsRegular<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.StackPanel 
=> style._addSetter(Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AreVerticalSnapPointsRegular<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.StackPanel 
=> style._addSetter(Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty, binding);



}

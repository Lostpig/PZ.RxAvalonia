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
public static partial class SplitView_MarkupExtensions
{
//================= Properties ======================//
 // CompactPaneLength

/*ValueSetterGenerator*/
public static T CompactPaneLength<T>(this T control, System.Double value) where T : Avalonia.Controls.SplitView 
{
    control.CompactPaneLength = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CompactPaneLength<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.CompactPaneLengthProperty!, func);

/*SetterFromObservableGenerator*/
public static T CompactPaneLength<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.CompactPaneLengthProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CompactPaneLength<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.CompactPaneLengthProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T CompactPaneLength<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.SplitView 
   => control._setEx(Avalonia.Controls.SplitView.CompactPaneLengthProperty!, obs, changed);


 // DisplayMode

/*ValueSetterGenerator*/
public static T DisplayMode<T>(this T control, Avalonia.Controls.SplitViewDisplayMode value) where T : Avalonia.Controls.SplitView 
{
    control.DisplayMode = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DisplayMode<T>(this T control, Func<Avalonia.Controls.SplitViewDisplayMode> func) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.DisplayModeProperty!, func);

/*SetterFromObservableGenerator*/
public static T DisplayMode<T>(this T control, IObservable<Avalonia.Controls.SplitViewDisplayMode> obs) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.DisplayModeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DisplayMode<T>(this T control, ISubject<Avalonia.Controls.SplitViewDisplayMode> subject) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.DisplayModeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DisplayMode<T>(this T control, IObservable<Avalonia.Controls.SplitViewDisplayMode> obs, IObserver<Avalonia.Controls.SplitViewDisplayMode> changed) where T : Avalonia.Controls.SplitView 
   => control._setEx(Avalonia.Controls.SplitView.DisplayModeProperty!, obs, changed);


 // IsPaneOpen

/*ValueSetterGenerator*/
public static T IsPaneOpen<T>(this T control, System.Boolean value) where T : Avalonia.Controls.SplitView 
{
    control.IsPaneOpen = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsPaneOpen<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.IsPaneOpenProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsPaneOpen<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.IsPaneOpenProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsPaneOpen<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.IsPaneOpenProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsPaneOpen<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.SplitView 
   => control._setEx(Avalonia.Controls.SplitView.IsPaneOpenProperty!, obs, changed);


 // OpenPaneLength

/*ValueSetterGenerator*/
public static T OpenPaneLength<T>(this T control, System.Double value) where T : Avalonia.Controls.SplitView 
{
    control.OpenPaneLength = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T OpenPaneLength<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.OpenPaneLengthProperty!, func);

/*SetterFromObservableGenerator*/
public static T OpenPaneLength<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.OpenPaneLengthProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T OpenPaneLength<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.OpenPaneLengthProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T OpenPaneLength<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.SplitView 
   => control._setEx(Avalonia.Controls.SplitView.OpenPaneLengthProperty!, obs, changed);


 // PaneBackground

/*ValueSetterGenerator*/
public static T PaneBackground<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.SplitView 
{
    control.PaneBackground = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PaneBackground<T>(this T control, Func<Avalonia.Media.IBrush> func) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneBackgroundProperty!, func);

/*SetterFromObservableGenerator*/
public static T PaneBackground<T>(this T control, IObservable<Avalonia.Media.IBrush> obs) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneBackgroundProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PaneBackground<T>(this T control, ISubject<Avalonia.Media.IBrush> subject) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneBackgroundProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T PaneBackground<T>(this T control, IObservable<Avalonia.Media.IBrush> obs, IObserver<Avalonia.Media.IBrush> changed) where T : Avalonia.Controls.SplitView 
   => control._setEx(Avalonia.Controls.SplitView.PaneBackgroundProperty!, obs, changed);


 // PanePlacement

/*ValueSetterGenerator*/
public static T PanePlacement<T>(this T control, Avalonia.Controls.SplitViewPanePlacement value) where T : Avalonia.Controls.SplitView 
{
    control.PanePlacement = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PanePlacement<T>(this T control, Func<Avalonia.Controls.SplitViewPanePlacement> func) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PanePlacementProperty!, func);

/*SetterFromObservableGenerator*/
public static T PanePlacement<T>(this T control, IObservable<Avalonia.Controls.SplitViewPanePlacement> obs) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PanePlacementProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PanePlacement<T>(this T control, ISubject<Avalonia.Controls.SplitViewPanePlacement> subject) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PanePlacementProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T PanePlacement<T>(this T control, IObservable<Avalonia.Controls.SplitViewPanePlacement> obs, IObserver<Avalonia.Controls.SplitViewPanePlacement> changed) where T : Avalonia.Controls.SplitView 
   => control._setEx(Avalonia.Controls.SplitView.PanePlacementProperty!, obs, changed);


 // Pane

/*ValueSetterGenerator*/
public static T Pane<T>(this T control, System.Object value) where T : Avalonia.Controls.SplitView 
{
    control.Pane = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Pane<T>(this T control, Func<System.Object> func) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneProperty!, func);

/*SetterFromObservableGenerator*/
public static T Pane<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Pane<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Pane<T>(this T control, IObservable<System.Object> obs, IObserver<System.Object> changed) where T : Avalonia.Controls.SplitView 
   => control._setEx(Avalonia.Controls.SplitView.PaneProperty!, obs, changed);


 // PaneTemplate

/*ValueSetterGenerator*/
public static T PaneTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.SplitView 
{
    control.PaneTemplate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PaneTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneTemplateProperty!, func);

/*SetterFromObservableGenerator*/
public static T PaneTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate> obs) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneTemplateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PaneTemplate<T>(this T control, ISubject<Avalonia.Controls.Templates.IDataTemplate> subject) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneTemplateProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T PaneTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate> obs, IObserver<Avalonia.Controls.Templates.IDataTemplate> changed) where T : Avalonia.Controls.SplitView 
   => control._setEx(Avalonia.Controls.SplitView.PaneTemplateProperty!, obs, changed);


 // UseLightDismissOverlayMode

/*ValueSetterGenerator*/
public static T UseLightDismissOverlayMode<T>(this T control, System.Boolean value) where T : Avalonia.Controls.SplitView 
{
    control.UseLightDismissOverlayMode = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T UseLightDismissOverlayMode<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty!, func);

/*SetterFromObservableGenerator*/
public static T UseLightDismissOverlayMode<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T UseLightDismissOverlayMode<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T UseLightDismissOverlayMode<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.SplitView 
   => control._setEx(Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty!, obs, changed);



//================= Events ======================//
 // PaneClosed

/*ActionToEventGenerator*/
public static T OnPaneClosed<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.SplitView 
{
  control.AddHandler(Avalonia.Controls.SplitView.PaneClosedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.SplitView.PaneClosedEvent.RoutingStrategies);
  return control;
}



 // PaneClosing

/*ActionToEventGenerator*/
public static T OnPaneClosing<T>(this T control, Action<Avalonia.Interactivity.CancelRoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.SplitView 
{
  control.AddHandler(Avalonia.Controls.SplitView.PaneClosingEvent, (_, args) => action(args), routes ?? Avalonia.Controls.SplitView.PaneClosingEvent.RoutingStrategies);
  return control;
}



 // PaneOpened

/*ActionToEventGenerator*/
public static T OnPaneOpened<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.SplitView 
{
  control.AddHandler(Avalonia.Controls.SplitView.PaneOpenedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.SplitView.PaneOpenedEvent.RoutingStrategies);
  return control;
}



 // PaneOpening

/*ActionToEventGenerator*/
public static T OnPaneOpening<T>(this T control, Action<Avalonia.Interactivity.CancelRoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.SplitView 
{
  control.AddHandler(Avalonia.Controls.SplitView.PaneOpeningEvent, (_, args) => action(args), routes ?? Avalonia.Controls.SplitView.PaneOpeningEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // CompactPaneLength

/*ValueStyleSetterGenerator*/
public static Style<T> CompactPaneLength<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.CompactPaneLengthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CompactPaneLength<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.CompactPaneLengthProperty, binding);


 // DisplayMode

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayMode<T>(this Style<T> style, Avalonia.Controls.SplitViewDisplayMode value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.DisplayModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.DisplayModeProperty, binding);


 // IsPaneOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsPaneOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.IsPaneOpenProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsPaneOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.IsPaneOpenProperty, binding);


 // OpenPaneLength

/*ValueStyleSetterGenerator*/
public static Style<T> OpenPaneLength<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.OpenPaneLengthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> OpenPaneLength<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.OpenPaneLengthProperty, binding);


 // PaneBackground

/*ValueStyleSetterGenerator*/
public static Style<T> PaneBackground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PaneBackgroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PaneBackground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PaneBackgroundProperty, binding);


 // PanePlacement

/*ValueStyleSetterGenerator*/
public static Style<T> PanePlacement<T>(this Style<T> style, Avalonia.Controls.SplitViewPanePlacement value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PanePlacementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PanePlacement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PanePlacementProperty, binding);


 // Pane

/*ValueStyleSetterGenerator*/
public static Style<T> Pane<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PaneProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Pane<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PaneProperty, binding);


 // PaneTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> PaneTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PaneTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PaneTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PaneTemplateProperty, binding);


 // UseLightDismissOverlayMode

/*ValueStyleSetterGenerator*/
public static Style<T> UseLightDismissOverlayMode<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UseLightDismissOverlayMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty, binding);



}

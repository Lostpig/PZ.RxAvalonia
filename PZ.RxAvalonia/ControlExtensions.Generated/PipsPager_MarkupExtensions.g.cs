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
public static partial class PipsPager_MarkupExtensions
{
//================= Properties ======================//
 // MaxVisiblePips

/*ValueSetterGenerator*/
public static T MaxVisiblePips<T>(this T control, System.Int32 value) where T : Avalonia.Controls.PipsPager 
{
    control.MaxVisiblePips = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MaxVisiblePips<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.PipsPager 
   => control._set(Avalonia.Controls.PipsPager.MaxVisiblePipsProperty!, func);

/*SetterFromObservableGenerator*/
public static T MaxVisiblePips<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.PipsPager 
   => control._set(Avalonia.Controls.PipsPager.MaxVisiblePipsProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MaxVisiblePips<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.PipsPager 
   => control._set(Avalonia.Controls.PipsPager.MaxVisiblePipsProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T MaxVisiblePips<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.PipsPager 
   => control._setEx(Avalonia.Controls.PipsPager.MaxVisiblePipsProperty!, obs, changed);


 // IsNextButtonVisible

/*ValueSetterGenerator*/
public static T IsNextButtonVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.PipsPager 
{
    control.IsNextButtonVisible = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsNextButtonVisible<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.PipsPager 
   => control._set(Avalonia.Controls.PipsPager.IsNextButtonVisibleProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsNextButtonVisible<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.PipsPager 
   => control._set(Avalonia.Controls.PipsPager.IsNextButtonVisibleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsNextButtonVisible<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.PipsPager 
   => control._set(Avalonia.Controls.PipsPager.IsNextButtonVisibleProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsNextButtonVisible<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.PipsPager 
   => control._setEx(Avalonia.Controls.PipsPager.IsNextButtonVisibleProperty!, obs, changed);


 // NumberOfPages

/*ValueSetterGenerator*/
public static T NumberOfPages<T>(this T control, System.Int32 value) where T : Avalonia.Controls.PipsPager 
{
    control.NumberOfPages = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T NumberOfPages<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.PipsPager 
   => control._set(Avalonia.Controls.PipsPager.NumberOfPagesProperty!, func);

/*SetterFromObservableGenerator*/
public static T NumberOfPages<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.PipsPager 
   => control._set(Avalonia.Controls.PipsPager.NumberOfPagesProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T NumberOfPages<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.PipsPager 
   => control._set(Avalonia.Controls.PipsPager.NumberOfPagesProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T NumberOfPages<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.PipsPager 
   => control._setEx(Avalonia.Controls.PipsPager.NumberOfPagesProperty!, obs, changed);


 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.PipsPager 
{
    control.Orientation = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func) where T : Avalonia.Controls.PipsPager 
   => control._set(Avalonia.Controls.PipsPager.OrientationProperty!, func);

/*SetterFromObservableGenerator*/
public static T Orientation<T>(this T control, IObservable<Avalonia.Layout.Orientation> obs) where T : Avalonia.Controls.PipsPager 
   => control._set(Avalonia.Controls.PipsPager.OrientationProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Orientation<T>(this T control, ISubject<Avalonia.Layout.Orientation> subject) where T : Avalonia.Controls.PipsPager 
   => control._set(Avalonia.Controls.PipsPager.OrientationProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Orientation<T>(this T control, IObservable<Avalonia.Layout.Orientation> obs, IObserver<Avalonia.Layout.Orientation> changed) where T : Avalonia.Controls.PipsPager 
   => control._setEx(Avalonia.Controls.PipsPager.OrientationProperty!, obs, changed);


 // IsPreviousButtonVisible

/*ValueSetterGenerator*/
public static T IsPreviousButtonVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.PipsPager 
{
    control.IsPreviousButtonVisible = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsPreviousButtonVisible<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.PipsPager 
   => control._set(Avalonia.Controls.PipsPager.IsPreviousButtonVisibleProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsPreviousButtonVisible<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.PipsPager 
   => control._set(Avalonia.Controls.PipsPager.IsPreviousButtonVisibleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsPreviousButtonVisible<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.PipsPager 
   => control._set(Avalonia.Controls.PipsPager.IsPreviousButtonVisibleProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsPreviousButtonVisible<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.PipsPager 
   => control._setEx(Avalonia.Controls.PipsPager.IsPreviousButtonVisibleProperty!, obs, changed);


 // SelectedPageIndex

/*ValueSetterGenerator*/
public static T SelectedPageIndex<T>(this T control, System.Int32 value) where T : Avalonia.Controls.PipsPager 
{
    control.SelectedPageIndex = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectedPageIndex<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.PipsPager 
   => control._set(Avalonia.Controls.PipsPager.SelectedPageIndexProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectedPageIndex<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.PipsPager 
   => control._set(Avalonia.Controls.PipsPager.SelectedPageIndexProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectedPageIndex<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.PipsPager 
   => control._set(Avalonia.Controls.PipsPager.SelectedPageIndexProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SelectedPageIndex<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.PipsPager 
   => control._setEx(Avalonia.Controls.PipsPager.SelectedPageIndexProperty!, obs, changed);


 // PreviousButtonTheme

/*ValueSetterGenerator*/
public static T PreviousButtonTheme<T>(this T control, Avalonia.Styling.ControlTheme? value) where T : Avalonia.Controls.PipsPager 
{
    control.PreviousButtonTheme = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T PreviousButtonTheme<T>(this T control, Func<Avalonia.Styling.ControlTheme?> func) where T : Avalonia.Controls.PipsPager 
   => control._set(Avalonia.Controls.PipsPager.PreviousButtonThemeProperty!, func);

/*SetterFromObservableGenerator*/
public static T PreviousButtonTheme<T>(this T control, IObservable<Avalonia.Styling.ControlTheme?> obs) where T : Avalonia.Controls.PipsPager 
   => control._set(Avalonia.Controls.PipsPager.PreviousButtonThemeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T PreviousButtonTheme<T>(this T control, ISubject<Avalonia.Styling.ControlTheme?> subject) where T : Avalonia.Controls.PipsPager 
   => control._set(Avalonia.Controls.PipsPager.PreviousButtonThemeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T PreviousButtonTheme<T>(this T control, IObservable<Avalonia.Styling.ControlTheme?> obs, IObserver<Avalonia.Styling.ControlTheme?> changed) where T : Avalonia.Controls.PipsPager 
   => control._setEx(Avalonia.Controls.PipsPager.PreviousButtonThemeProperty!, obs, changed);


 // NextButtonTheme

/*ValueSetterGenerator*/
public static T NextButtonTheme<T>(this T control, Avalonia.Styling.ControlTheme? value) where T : Avalonia.Controls.PipsPager 
{
    control.NextButtonTheme = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T NextButtonTheme<T>(this T control, Func<Avalonia.Styling.ControlTheme?> func) where T : Avalonia.Controls.PipsPager 
   => control._set(Avalonia.Controls.PipsPager.NextButtonThemeProperty!, func);

/*SetterFromObservableGenerator*/
public static T NextButtonTheme<T>(this T control, IObservable<Avalonia.Styling.ControlTheme?> obs) where T : Avalonia.Controls.PipsPager 
   => control._set(Avalonia.Controls.PipsPager.NextButtonThemeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T NextButtonTheme<T>(this T control, ISubject<Avalonia.Styling.ControlTheme?> subject) where T : Avalonia.Controls.PipsPager 
   => control._set(Avalonia.Controls.PipsPager.NextButtonThemeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T NextButtonTheme<T>(this T control, IObservable<Avalonia.Styling.ControlTheme?> obs, IObserver<Avalonia.Styling.ControlTheme?> changed) where T : Avalonia.Controls.PipsPager 
   => control._setEx(Avalonia.Controls.PipsPager.NextButtonThemeProperty!, obs, changed);



//================= Events ======================//
 // SelectedIndexChanged

/*ActionToEventGenerator*/
public static T OnSelectedIndexChanged<T>(this T control, Action<Avalonia.Controls.PipsPagerSelectedIndexChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.PipsPager 
{
  control.AddHandler(Avalonia.Controls.PipsPager.SelectedIndexChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.PipsPager.SelectedIndexChangedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxSelectedIndexChanged<T>(this T control, IObserver<Avalonia.Controls.PipsPagerSelectedIndexChangedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.PipsPager 
{
  control.AddHandler(Avalonia.Controls.PipsPager.SelectedIndexChangedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.PipsPager.SelectedIndexChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // MaxVisiblePips

/*ValueStyleSetterGenerator*/
public static Style<T> MaxVisiblePips<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.PipsPager 
=> style._addSetter(Avalonia.Controls.PipsPager.MaxVisiblePipsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxVisiblePips<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.PipsPager 
=> style._addSetter(Avalonia.Controls.PipsPager.MaxVisiblePipsProperty, binding);


 // IsNextButtonVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsNextButtonVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.PipsPager 
=> style._addSetter(Avalonia.Controls.PipsPager.IsNextButtonVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsNextButtonVisible<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.PipsPager 
=> style._addSetter(Avalonia.Controls.PipsPager.IsNextButtonVisibleProperty, binding);


 // NumberOfPages

/*ValueStyleSetterGenerator*/
public static Style<T> NumberOfPages<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.PipsPager 
=> style._addSetter(Avalonia.Controls.PipsPager.NumberOfPagesProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> NumberOfPages<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.PipsPager 
=> style._addSetter(Avalonia.Controls.PipsPager.NumberOfPagesProperty, binding);


 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.PipsPager 
=> style._addSetter(Avalonia.Controls.PipsPager.OrientationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.PipsPager 
=> style._addSetter(Avalonia.Controls.PipsPager.OrientationProperty, binding);


 // IsPreviousButtonVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsPreviousButtonVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.PipsPager 
=> style._addSetter(Avalonia.Controls.PipsPager.IsPreviousButtonVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsPreviousButtonVisible<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.PipsPager 
=> style._addSetter(Avalonia.Controls.PipsPager.IsPreviousButtonVisibleProperty, binding);


 // SelectedPageIndex

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedPageIndex<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.PipsPager 
=> style._addSetter(Avalonia.Controls.PipsPager.SelectedPageIndexProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedPageIndex<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.PipsPager 
=> style._addSetter(Avalonia.Controls.PipsPager.SelectedPageIndexProperty, binding);


 // PreviousButtonTheme

/*ValueStyleSetterGenerator*/
public static Style<T> PreviousButtonTheme<T>(this Style<T> style, Avalonia.Styling.ControlTheme? value) where T : Avalonia.Controls.PipsPager 
=> style._addSetter(Avalonia.Controls.PipsPager.PreviousButtonThemeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PreviousButtonTheme<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.PipsPager 
=> style._addSetter(Avalonia.Controls.PipsPager.PreviousButtonThemeProperty, binding);


 // NextButtonTheme

/*ValueStyleSetterGenerator*/
public static Style<T> NextButtonTheme<T>(this Style<T> style, Avalonia.Styling.ControlTheme? value) where T : Avalonia.Controls.PipsPager 
=> style._addSetter(Avalonia.Controls.PipsPager.NextButtonThemeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> NextButtonTheme<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.PipsPager 
=> style._addSetter(Avalonia.Controls.PipsPager.NextButtonThemeProperty, binding);



}

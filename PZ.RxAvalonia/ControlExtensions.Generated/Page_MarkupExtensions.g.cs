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
public static partial class Page_MarkupExtensions
{
//================= Properties ======================//
 // SafeAreaPadding

/*ValueSetterGenerator*/
public static T SafeAreaPadding<T>(this T control, Avalonia.Thickness value) where T : Avalonia.Controls.Page 
{
    control.SafeAreaPadding = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static T SafeAreaPadding<T>(this T control, System.Double uniformLength = default!) where T : Avalonia.Controls.Page 
{
    control.SafeAreaPadding = new Avalonia.Thickness(uniformLength);
    return control;
}
public static T SafeAreaPadding<T>(this T control, System.Double horizontal = default!, System.Double vertical = default!) where T : Avalonia.Controls.Page 
{
    control.SafeAreaPadding = new Avalonia.Thickness(horizontal, vertical);
    return control;
}
public static T SafeAreaPadding<T>(this T control, System.Double left = default!, System.Double top = default!, System.Double right = default!, System.Double bottom = default!) where T : Avalonia.Controls.Page 
{
    control.SafeAreaPadding = new Avalonia.Thickness(left, top, right, bottom);
    return control;
}

/*SetterFromFuncGenerator*/
public static T SafeAreaPadding<T>(this T control, Func<Avalonia.Thickness> func) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.Page.SafeAreaPaddingProperty!, func);

/*SetterFromObservableGenerator*/
public static T SafeAreaPadding<T>(this T control, IObservable<Avalonia.Thickness> obs) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.Page.SafeAreaPaddingProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SafeAreaPadding<T>(this T control, ISubject<Avalonia.Thickness> subject) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.Page.SafeAreaPaddingProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SafeAreaPadding<T>(this T control, IObservable<Avalonia.Thickness> obs, IObserver<Avalonia.Thickness> changed) where T : Avalonia.Controls.Page 
   => control._setEx(Avalonia.Controls.Page.SafeAreaPaddingProperty!, obs, changed);


 // Header

/*ValueSetterGenerator*/
public static T Header<T>(this T control, System.Object? value) where T : Avalonia.Controls.Page 
{
    control.Header = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Header<T>(this T control, Func<System.Object?> func) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.Page.HeaderProperty!, func);

/*SetterFromObservableGenerator*/
public static T Header<T>(this T control, IObservable<System.Object?> obs) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.Page.HeaderProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Header<T>(this T control, ISubject<System.Object?> subject) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.Page.HeaderProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Header<T>(this T control, IObservable<System.Object?> obs, IObserver<System.Object?> changed) where T : Avalonia.Controls.Page 
   => control._setEx(Avalonia.Controls.Page.HeaderProperty!, obs, changed);


 // HeaderTemplate

/*ValueSetterGenerator*/
public static T HeaderTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.Page 
{
    control.HeaderTemplate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T HeaderTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate?> func) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.Page.HeaderTemplateProperty!, func);

/*SetterFromObservableGenerator*/
public static T HeaderTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.Page.HeaderTemplateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T HeaderTemplate<T>(this T control, ISubject<Avalonia.Controls.Templates.IDataTemplate?> subject) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.Page.HeaderTemplateProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T HeaderTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs, IObserver<Avalonia.Controls.Templates.IDataTemplate?> changed) where T : Avalonia.Controls.Page 
   => control._setEx(Avalonia.Controls.Page.HeaderTemplateProperty!, obs, changed);


 // Icon

/*ValueSetterGenerator*/
public static T Icon<T>(this T control, System.Object? value) where T : Avalonia.Controls.Page 
{
    control.Icon = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Icon<T>(this T control, Func<System.Object?> func) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.Page.IconProperty!, func);

/*SetterFromObservableGenerator*/
public static T Icon<T>(this T control, IObservable<System.Object?> obs) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.Page.IconProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Icon<T>(this T control, ISubject<System.Object?> subject) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.Page.IconProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Icon<T>(this T control, IObservable<System.Object?> obs, IObserver<System.Object?> changed) where T : Avalonia.Controls.Page 
   => control._setEx(Avalonia.Controls.Page.IconProperty!, obs, changed);


 // IconTemplate

/*ValueSetterGenerator*/
public static T IconTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.Page 
{
    control.IconTemplate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IconTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate?> func) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.Page.IconTemplateProperty!, func);

/*SetterFromObservableGenerator*/
public static T IconTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.Page.IconTemplateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IconTemplate<T>(this T control, ISubject<Avalonia.Controls.Templates.IDataTemplate?> subject) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.Page.IconTemplateProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IconTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate?> obs, IObserver<Avalonia.Controls.Templates.IDataTemplate?> changed) where T : Avalonia.Controls.Page 
   => control._setEx(Avalonia.Controls.Page.IconTemplateProperty!, obs, changed);


 // CurrentPage

/*ValueSetterGenerator*/
public static T CurrentPage<T>(this T control, Avalonia.Controls.Page? value) where T : Avalonia.Controls.Page 
{
    control.CurrentPage = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CurrentPage<T>(this T control, Func<Avalonia.Controls.Page?> func) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.Page.CurrentPageProperty!, func);

/*SetterFromObservableGenerator*/
public static T CurrentPage<T>(this T control, IObservable<Avalonia.Controls.Page?> obs) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.Page.CurrentPageProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CurrentPage<T>(this T control, ISubject<Avalonia.Controls.Page?> subject) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.Page.CurrentPageProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T CurrentPage<T>(this T control, IObservable<Avalonia.Controls.Page?> obs, IObserver<Avalonia.Controls.Page?> changed) where T : Avalonia.Controls.Page 
   => control._setEx(Avalonia.Controls.Page.CurrentPageProperty!, obs, changed);


 // IsInNavigationPage

/*ValueSetterGenerator*/
public static T IsInNavigationPage<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Page 
{
    control.IsInNavigationPage = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsInNavigationPage<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.Page.IsInNavigationPageProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsInNavigationPage<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.Page.IsInNavigationPageProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsInNavigationPage<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.Page.IsInNavigationPageProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsInNavigationPage<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.Page 
   => control._setEx(Avalonia.Controls.Page.IsInNavigationPageProperty!, obs, changed);


 // Navigation

/*ValueSetterGenerator*/
public static T Navigation<T>(this T control, Avalonia.Controls.INavigation? value) where T : Avalonia.Controls.Page 
{
    control.Navigation = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Navigation<T>(this T control, Func<Avalonia.Controls.INavigation?> func) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.Page.NavigationProperty!, func);

/*SetterFromObservableGenerator*/
public static T Navigation<T>(this T control, IObservable<Avalonia.Controls.INavigation?> obs) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.Page.NavigationProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Navigation<T>(this T control, ISubject<Avalonia.Controls.INavigation?> subject) where T : Avalonia.Controls.Page 
   => control._set(Avalonia.Controls.Page.NavigationProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Navigation<T>(this T control, IObservable<Avalonia.Controls.INavigation?> obs, IObserver<Avalonia.Controls.INavigation?> changed) where T : Avalonia.Controls.Page 
   => control._setEx(Avalonia.Controls.Page.NavigationProperty!, obs, changed);



//================= Events ======================//
 // PageNavigationSystemBackButtonPressed

/*ActionToEventGenerator*/
public static T OnPageNavigationSystemBackButtonPressed<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Page 
{
  control.AddHandler(Avalonia.Controls.Page.PageNavigationSystemBackButtonPressedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Page.PageNavigationSystemBackButtonPressedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxPageNavigationSystemBackButtonPressed<T>(this T control, IObserver<Avalonia.Interactivity.RoutedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Page 
{
  control.AddHandler(Avalonia.Controls.Page.PageNavigationSystemBackButtonPressedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.Page.PageNavigationSystemBackButtonPressedEvent.RoutingStrategies);
  return control;
}



 // NavigatedTo

/*ActionToEventGenerator*/
public static T OnNavigatedTo<T>(this T control, Action<Avalonia.Controls.NavigatedToEventArgs> action) where T : Avalonia.Controls.Page  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.NavigatedToEventArgs>) ((arg0, arg1) => action(arg1)), h => control.NavigatedTo += h);

/*ReactiveEventGenerator*/
public static T RxNavigatedTo<T>(this T control, IObserver<Avalonia.Controls.NavigatedToEventArgs> observer) where T : Avalonia.Controls.Page  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.NavigatedToEventArgs>) ((arg0, arg1) => observer.OnNext((arg1))), h => control.NavigatedTo += h);


 // Navigating

/*ActionToEventGenerator*/
public static T OnNavigating<T>(this T control, System.Func<Avalonia.Controls.NavigatingFromEventArgs,System.Threading.Tasks.Task> handler) where T : Avalonia.Controls.Page
{
    control.Navigating += handler;
    return control;
}



 // NavigatedFrom

/*ActionToEventGenerator*/
public static T OnNavigatedFrom<T>(this T control, Action<Avalonia.Controls.NavigatedFromEventArgs> action) where T : Avalonia.Controls.Page  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.NavigatedFromEventArgs>) ((arg0, arg1) => action(arg1)), h => control.NavigatedFrom += h);

/*ReactiveEventGenerator*/
public static T RxNavigatedFrom<T>(this T control, IObserver<Avalonia.Controls.NavigatedFromEventArgs> observer) where T : Avalonia.Controls.Page  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.NavigatedFromEventArgs>) ((arg0, arg1) => observer.OnNext((arg1))), h => control.NavigatedFrom += h);



//================= Styles ======================//
 // SafeAreaPadding

/*ValueStyleSetterGenerator*/
public static Style<T> SafeAreaPadding<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.Page 
=> style._addSetter(Avalonia.Controls.Page.SafeAreaPaddingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SafeAreaPadding<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.Page 
=> style._addSetter(Avalonia.Controls.Page.SafeAreaPaddingProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> SafeAreaPadding<T>(this Style<T> style, System.Double uniformLength) where T : Avalonia.Controls.Page 
   => style._addSetter(Avalonia.Controls.Page.SafeAreaPaddingProperty, new Avalonia.Thickness(uniformLength));public static Style<T> SafeAreaPadding<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Avalonia.Controls.Page 
   => style._addSetter(Avalonia.Controls.Page.SafeAreaPaddingProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> SafeAreaPadding<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Avalonia.Controls.Page 
   => style._addSetter(Avalonia.Controls.Page.SafeAreaPaddingProperty, new Avalonia.Thickness(left, top, right, bottom));


 // Header

/*ValueStyleSetterGenerator*/
public static Style<T> Header<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.Page 
=> style._addSetter(Avalonia.Controls.Page.HeaderProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Header<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.Page 
=> style._addSetter(Avalonia.Controls.Page.HeaderProperty, binding);


 // HeaderTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> HeaderTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.Page 
=> style._addSetter(Avalonia.Controls.Page.HeaderTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HeaderTemplate<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.Page 
=> style._addSetter(Avalonia.Controls.Page.HeaderTemplateProperty, binding);


 // Icon

/*ValueStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, System.Object? value) where T : Avalonia.Controls.Page 
=> style._addSetter(Avalonia.Controls.Page.IconProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.Page 
=> style._addSetter(Avalonia.Controls.Page.IconProperty, binding);


 // IconTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> IconTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate? value) where T : Avalonia.Controls.Page 
=> style._addSetter(Avalonia.Controls.Page.IconTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IconTemplate<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.Page 
=> style._addSetter(Avalonia.Controls.Page.IconTemplateProperty, binding);


 // CurrentPage

/*ValueStyleSetterGenerator*/
public static Style<T> CurrentPage<T>(this Style<T> style, Avalonia.Controls.Page? value) where T : Avalonia.Controls.Page 
=> style._addSetter(Avalonia.Controls.Page.CurrentPageProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CurrentPage<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.Page 
=> style._addSetter(Avalonia.Controls.Page.CurrentPageProperty, binding);


 // IsInNavigationPage

/*ValueStyleSetterGenerator*/
public static Style<T> IsInNavigationPage<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Page 
=> style._addSetter(Avalonia.Controls.Page.IsInNavigationPageProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsInNavigationPage<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.Page 
=> style._addSetter(Avalonia.Controls.Page.IsInNavigationPageProperty, binding);



}

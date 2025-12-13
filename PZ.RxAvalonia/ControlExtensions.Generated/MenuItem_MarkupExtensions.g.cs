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
public static partial class MenuItem_MarkupExtensions
{
//================= Properties ======================//
 // Command

/*ValueSetterGenerator*/
public static T Command<T>(this T control, System.Windows.Input.ICommand value) where T : Avalonia.Controls.MenuItem 
{
    control.Command = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand> func) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.CommandProperty!, func);

/*SetterFromObservableGenerator*/
public static T Command<T>(this T control, IObservable<System.Windows.Input.ICommand> obs) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.CommandProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Command<T>(this T control, ISubject<System.Windows.Input.ICommand> subject) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.CommandProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Command<T>(this T control, IObservable<System.Windows.Input.ICommand> obs, IObserver<System.Windows.Input.ICommand> changed) where T : Avalonia.Controls.MenuItem 
   => control._setEx(Avalonia.Controls.MenuItem.CommandProperty!, obs, changed);


 // HotKey

/*ValueSetterGenerator*/
public static T HotKey<T>(this T control, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.MenuItem 
{
    control.HotKey = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T HotKey<T>(this T control, Func<Avalonia.Input.KeyGesture> func) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.HotKeyProperty!, func);

/*SetterFromObservableGenerator*/
public static T HotKey<T>(this T control, IObservable<Avalonia.Input.KeyGesture> obs) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.HotKeyProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T HotKey<T>(this T control, ISubject<Avalonia.Input.KeyGesture> subject) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.HotKeyProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T HotKey<T>(this T control, IObservable<Avalonia.Input.KeyGesture> obs, IObserver<Avalonia.Input.KeyGesture> changed) where T : Avalonia.Controls.MenuItem 
   => control._setEx(Avalonia.Controls.MenuItem.HotKeyProperty!, obs, changed);


 // CommandParameter

/*ValueSetterGenerator*/
public static T CommandParameter<T>(this T control, System.Object value) where T : Avalonia.Controls.MenuItem 
{
    control.CommandParameter = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CommandParameter<T>(this T control, Func<System.Object> func) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.CommandParameterProperty!, func);

/*SetterFromObservableGenerator*/
public static T CommandParameter<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.CommandParameterProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CommandParameter<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.CommandParameterProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T CommandParameter<T>(this T control, IObservable<System.Object> obs, IObserver<System.Object> changed) where T : Avalonia.Controls.MenuItem 
   => control._setEx(Avalonia.Controls.MenuItem.CommandParameterProperty!, obs, changed);


 // Icon

/*ValueSetterGenerator*/
public static T Icon<T>(this T control, System.Object value) where T : Avalonia.Controls.MenuItem 
{
    control.Icon = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Icon<T>(this T control, Func<System.Object> func) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IconProperty!, func);

/*SetterFromObservableGenerator*/
public static T Icon<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IconProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Icon<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IconProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Icon<T>(this T control, IObservable<System.Object> obs, IObserver<System.Object> changed) where T : Avalonia.Controls.MenuItem 
   => control._setEx(Avalonia.Controls.MenuItem.IconProperty!, obs, changed);


 // InputGesture

/*ValueSetterGenerator*/
public static T InputGesture<T>(this T control, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.MenuItem 
{
    control.InputGesture = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T InputGesture<T>(this T control, Func<Avalonia.Input.KeyGesture> func) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.InputGestureProperty!, func);

/*SetterFromObservableGenerator*/
public static T InputGesture<T>(this T control, IObservable<Avalonia.Input.KeyGesture> obs) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.InputGestureProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T InputGesture<T>(this T control, ISubject<Avalonia.Input.KeyGesture> subject) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.InputGestureProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T InputGesture<T>(this T control, IObservable<Avalonia.Input.KeyGesture> obs, IObserver<Avalonia.Input.KeyGesture> changed) where T : Avalonia.Controls.MenuItem 
   => control._setEx(Avalonia.Controls.MenuItem.InputGestureProperty!, obs, changed);


 // IsSubMenuOpen

/*ValueSetterGenerator*/
public static T IsSubMenuOpen<T>(this T control, System.Boolean value) where T : Avalonia.Controls.MenuItem 
{
    control.IsSubMenuOpen = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsSubMenuOpen<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsSubMenuOpen<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsSubMenuOpen<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsSubMenuOpen<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.MenuItem 
   => control._setEx(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty!, obs, changed);


 // StaysOpenOnClick

/*ValueSetterGenerator*/
public static T StaysOpenOnClick<T>(this T control, System.Boolean value) where T : Avalonia.Controls.MenuItem 
{
    control.StaysOpenOnClick = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T StaysOpenOnClick<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty!, func);

/*SetterFromObservableGenerator*/
public static T StaysOpenOnClick<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T StaysOpenOnClick<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T StaysOpenOnClick<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.MenuItem 
   => control._setEx(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty!, obs, changed);


 // ToggleType

/*ValueSetterGenerator*/
public static T ToggleType<T>(this T control, Avalonia.Controls.MenuItemToggleType value) where T : Avalonia.Controls.MenuItem 
{
    control.ToggleType = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ToggleType<T>(this T control, Func<Avalonia.Controls.MenuItemToggleType> func) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.ToggleTypeProperty!, func);

/*SetterFromObservableGenerator*/
public static T ToggleType<T>(this T control, IObservable<Avalonia.Controls.MenuItemToggleType> obs) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.ToggleTypeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ToggleType<T>(this T control, ISubject<Avalonia.Controls.MenuItemToggleType> subject) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.ToggleTypeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ToggleType<T>(this T control, IObservable<Avalonia.Controls.MenuItemToggleType> obs, IObserver<Avalonia.Controls.MenuItemToggleType> changed) where T : Avalonia.Controls.MenuItem 
   => control._setEx(Avalonia.Controls.MenuItem.ToggleTypeProperty!, obs, changed);


 // IsChecked

/*ValueSetterGenerator*/
public static T IsChecked<T>(this T control, System.Boolean value) where T : Avalonia.Controls.MenuItem 
{
    control.IsChecked = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsChecked<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IsCheckedProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsChecked<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IsCheckedProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsChecked<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IsCheckedProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsChecked<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.MenuItem 
   => control._setEx(Avalonia.Controls.MenuItem.IsCheckedProperty!, obs, changed);


 // GroupName

/*ValueSetterGenerator*/
public static T GroupName<T>(this T control, System.String value) where T : Avalonia.Controls.MenuItem 
{
    control.GroupName = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T GroupName<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.GroupNameProperty!, func);

/*SetterFromObservableGenerator*/
public static T GroupName<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.GroupNameProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T GroupName<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.GroupNameProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T GroupName<T>(this T control, IObservable<System.String> obs, IObserver<System.String> changed) where T : Avalonia.Controls.MenuItem 
   => control._setEx(Avalonia.Controls.MenuItem.GroupNameProperty!, obs, changed);



//================= Events ======================//
 // Click

/*ActionToEventGenerator*/
public static T OnClick<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.MenuItem 
{
  control.AddHandler(Avalonia.Controls.MenuItem.ClickEvent, (_, args) => action(args), routes ?? Avalonia.Controls.MenuItem.ClickEvent.RoutingStrategies);
  return control;
}



 // PointerEnteredItem

/*ActionToEventGenerator*/
public static T OnPointerEnteredItem<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.MenuItem 
{
  control.AddHandler(Avalonia.Controls.MenuItem.PointerEnteredItemEvent, (_, args) => action(args), routes ?? Avalonia.Controls.MenuItem.PointerEnteredItemEvent.RoutingStrategies);
  return control;
}



 // PointerExitedItem

/*ActionToEventGenerator*/
public static T OnPointerExitedItem<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.MenuItem 
{
  control.AddHandler(Avalonia.Controls.MenuItem.PointerExitedItemEvent, (_, args) => action(args), routes ?? Avalonia.Controls.MenuItem.PointerExitedItemEvent.RoutingStrategies);
  return control;
}



 // SubmenuOpened

/*ActionToEventGenerator*/
public static T OnSubmenuOpened<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.MenuItem 
{
  control.AddHandler(Avalonia.Controls.MenuItem.SubmenuOpenedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.MenuItem.SubmenuOpenedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // Command

/*ValueStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, System.Windows.Input.ICommand value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.CommandProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.CommandProperty, binding);


 // HotKey

/*ValueStyleSetterGenerator*/
public static Style<T> HotKey<T>(this Style<T> style, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.HotKeyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HotKey<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.HotKeyProperty, binding);


 // CommandParameter

/*ValueStyleSetterGenerator*/
public static Style<T> CommandParameter<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.CommandParameterProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CommandParameter<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.CommandParameterProperty, binding);


 // Icon

/*ValueStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.IconProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.IconProperty, binding);


 // InputGesture

/*ValueStyleSetterGenerator*/
public static Style<T> InputGesture<T>(this Style<T> style, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.InputGestureProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InputGesture<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.InputGestureProperty, binding);


 // IsSubMenuOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsSubMenuOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsSubMenuOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty, binding);


 // StaysOpenOnClick

/*ValueStyleSetterGenerator*/
public static Style<T> StaysOpenOnClick<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StaysOpenOnClick<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty, binding);


 // ToggleType

/*ValueStyleSetterGenerator*/
public static Style<T> ToggleType<T>(this Style<T> style, Avalonia.Controls.MenuItemToggleType value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.ToggleTypeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ToggleType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.ToggleTypeProperty, binding);


 // IsChecked

/*ValueStyleSetterGenerator*/
public static Style<T> IsChecked<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.IsCheckedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsChecked<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.IsCheckedProperty, binding);


 // GroupName

/*ValueStyleSetterGenerator*/
public static Style<T> GroupName<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.GroupNameProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> GroupName<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.GroupNameProperty, binding);



}

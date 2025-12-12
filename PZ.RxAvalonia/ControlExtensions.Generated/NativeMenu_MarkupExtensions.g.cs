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
public static partial class NativeMenu_MarkupExtensions
{
//================= Attached Properties ======================//
 // Menu

/*AttachedPropertyFuncGenerator*/
public static T NativeMenu_Menu<T>(this T control, Func<Avalonia.Controls.NativeMenu> getter) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.NativeMenu.MenuProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T NativeMenu_Menu<T>(this T control, IObservable<Avalonia.Controls.NativeMenu> obs) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.NativeMenu.MenuProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T NativeMenu_Menu<T>(this T control, ISubject<Avalonia.Controls.NativeMenu> subject) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.NativeMenu.MenuProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T NativeMenu_Menu<T>(this T control, Avalonia.Controls.NativeMenu value) where T : Avalonia.AvaloniaObject 
{
    control.SetValue(Avalonia.Controls.NativeMenu.MenuProperty!, value);
    return control;
}



//================= Events ======================//
 // NeedsUpdate

/*ActionToEventGenerator*/
public static T OnNeedsUpdate<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.NativeMenu  => 
 control._setEvent((System.EventHandler<System.EventArgs>) ((arg0, arg1) => action(arg1)), h => control.NeedsUpdate += h);


 // Opening

/*ActionToEventGenerator*/
public static T OnOpening<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.NativeMenu  => 
 control._setEvent((System.EventHandler<System.EventArgs>) ((arg0, arg1) => action(arg1)), h => control.Opening += h);


 // Closed

/*ActionToEventGenerator*/
public static T OnClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.NativeMenu  => 
 control._setEvent((System.EventHandler<System.EventArgs>) ((arg0, arg1) => action(arg1)), h => control.Closed += h);



}

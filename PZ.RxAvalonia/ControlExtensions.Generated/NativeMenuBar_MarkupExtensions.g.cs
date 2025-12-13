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
public static partial class NativeMenuBar_MarkupExtensions
{
//================= Attached Properties ======================//
 // EnableMenuItemClickForwarding

/*AttachedPropertyFuncGenerator*/
public static T NativeMenuBar_EnableMenuItemClickForwarding<T>(this T control, Func<System.Boolean> getter) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T NativeMenuBar_EnableMenuItemClickForwarding<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T NativeMenuBar_EnableMenuItemClickForwarding<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T NativeMenuBar_EnableMenuItemClickForwarding<T>(this T control, System.Boolean value) where T : Avalonia.Controls.MenuItem 
{
    control.SetValue(Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty!, value);
    return control;
}

/*AttachedPropertyTwoWayGenerator*/
public static T NativeMenuBar_EnableMenuItemClickForwarding<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.MenuItem 
   => control._setEx(Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty!, obs, changed);



}

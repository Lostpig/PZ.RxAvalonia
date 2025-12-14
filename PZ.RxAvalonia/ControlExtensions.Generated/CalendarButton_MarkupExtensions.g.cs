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
public static partial class CalendarButton_MarkupExtensions
{
//================= Events ======================//
 // CalendarLeftMouseButtonDown

/*ActionToEventGenerator*/
public static Avalonia.Controls.Primitives.CalendarButton OnCalendarLeftMouseButtonDown(this Avalonia.Controls.Primitives.CalendarButton control, Action<Avalonia.Input.PointerPressedEventArgs> action)   => 
 control._setEvent((System.EventHandler<Avalonia.Input.PointerPressedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.CalendarLeftMouseButtonDown += h);

/*ReactiveEventGenerator*/
public static Avalonia.Controls.Primitives.CalendarButton RxCalendarLeftMouseButtonDown(this Avalonia.Controls.Primitives.CalendarButton control, IObserver<Avalonia.Input.PointerPressedEventArgs> observer)   => 
 control._setEvent((System.EventHandler<Avalonia.Input.PointerPressedEventArgs>) ((arg0, arg1) => observer.OnNext((arg1))), h => control.CalendarLeftMouseButtonDown += h);


 // CalendarLeftMouseButtonUp

/*ActionToEventGenerator*/
public static Avalonia.Controls.Primitives.CalendarButton OnCalendarLeftMouseButtonUp(this Avalonia.Controls.Primitives.CalendarButton control, Action<Avalonia.Input.PointerReleasedEventArgs> action)   => 
 control._setEvent((System.EventHandler<Avalonia.Input.PointerReleasedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.CalendarLeftMouseButtonUp += h);

/*ReactiveEventGenerator*/
public static Avalonia.Controls.Primitives.CalendarButton RxCalendarLeftMouseButtonUp(this Avalonia.Controls.Primitives.CalendarButton control, IObserver<Avalonia.Input.PointerReleasedEventArgs> observer)   => 
 control._setEvent((System.EventHandler<Avalonia.Input.PointerReleasedEventArgs>) ((arg0, arg1) => observer.OnNext((arg1))), h => control.CalendarLeftMouseButtonUp += h);



}

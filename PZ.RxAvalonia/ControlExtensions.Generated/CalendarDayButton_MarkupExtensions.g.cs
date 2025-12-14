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
public static partial class CalendarDayButton_MarkupExtensions
{
//================= Events ======================//
 // CalendarDayButtonMouseDown

/*ActionToEventGenerator*/
public static Avalonia.Controls.Primitives.CalendarDayButton OnCalendarDayButtonMouseDown(this Avalonia.Controls.Primitives.CalendarDayButton control, Action<Avalonia.Input.PointerPressedEventArgs> action)   => 
 control._setEvent((System.EventHandler<Avalonia.Input.PointerPressedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.CalendarDayButtonMouseDown += h);

/*ReactiveEventGenerator*/
public static Avalonia.Controls.Primitives.CalendarDayButton RxCalendarDayButtonMouseDown(this Avalonia.Controls.Primitives.CalendarDayButton control, IObserver<Avalonia.Input.PointerPressedEventArgs> observer)   => 
 control._setEvent((System.EventHandler<Avalonia.Input.PointerPressedEventArgs>) ((arg0, arg1) => observer.OnNext((arg1))), h => control.CalendarDayButtonMouseDown += h);


 // CalendarDayButtonMouseUp

/*ActionToEventGenerator*/
public static Avalonia.Controls.Primitives.CalendarDayButton OnCalendarDayButtonMouseUp(this Avalonia.Controls.Primitives.CalendarDayButton control, Action<Avalonia.Input.PointerReleasedEventArgs> action)   => 
 control._setEvent((System.EventHandler<Avalonia.Input.PointerReleasedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.CalendarDayButtonMouseUp += h);

/*ReactiveEventGenerator*/
public static Avalonia.Controls.Primitives.CalendarDayButton RxCalendarDayButtonMouseUp(this Avalonia.Controls.Primitives.CalendarDayButton control, IObserver<Avalonia.Input.PointerReleasedEventArgs> observer)   => 
 control._setEvent((System.EventHandler<Avalonia.Input.PointerReleasedEventArgs>) ((arg0, arg1) => observer.OnNext((arg1))), h => control.CalendarDayButtonMouseUp += h);



}

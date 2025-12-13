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
public static partial class DashStyle_MarkupExtensions
{
//================= Properties ======================//
 // Dashes

/*ValueSetterGenerator*/
public static Avalonia.Media.DashStyle Dashes(this Avalonia.Media.DashStyle control, Avalonia.Collections.AvaloniaList<System.Double> value)  
{
    control.Dashes = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.DashStyle Dashes(this Avalonia.Media.DashStyle control, Func<Avalonia.Collections.AvaloniaList<System.Double>> func)  
   => control._set(Avalonia.Media.DashStyle.DashesProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.DashStyle Dashes(this Avalonia.Media.DashStyle control, IObservable<Avalonia.Collections.AvaloniaList<System.Double>> obs)  
   => control._set(Avalonia.Media.DashStyle.DashesProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.DashStyle Dashes(this Avalonia.Media.DashStyle control, ISubject<Avalonia.Collections.AvaloniaList<System.Double>> subject)  
   => control._set(Avalonia.Media.DashStyle.DashesProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.DashStyle Dashes(this Avalonia.Media.DashStyle control, IObservable<Avalonia.Collections.AvaloniaList<System.Double>> obs, IObserver<Avalonia.Collections.AvaloniaList<System.Double>> changed)  
   => control._setEx(Avalonia.Media.DashStyle.DashesProperty!, obs, changed);


 // Offset

/*ValueSetterGenerator*/
public static Avalonia.Media.DashStyle Offset(this Avalonia.Media.DashStyle control, System.Double value)  
{
    control.Offset = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.DashStyle Offset(this Avalonia.Media.DashStyle control, Func<System.Double> func)  
   => control._set(Avalonia.Media.DashStyle.OffsetProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.DashStyle Offset(this Avalonia.Media.DashStyle control, IObservable<System.Double> obs)  
   => control._set(Avalonia.Media.DashStyle.OffsetProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.DashStyle Offset(this Avalonia.Media.DashStyle control, ISubject<System.Double> subject)  
   => control._set(Avalonia.Media.DashStyle.OffsetProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Media.DashStyle Offset(this Avalonia.Media.DashStyle control, IObservable<System.Double> obs, IObserver<System.Double> changed)  
   => control._setEx(Avalonia.Media.DashStyle.OffsetProperty!, obs, changed);



}

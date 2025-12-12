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
public static partial class DefinitionBase_MarkupExtensions
{
//================= Properties ======================//
 // SharedSizeGroup

/*ValueSetterGenerator*/
public static T SharedSizeGroup<T>(this T control, System.String value) where T : Avalonia.Controls.DefinitionBase 
{
    control.SharedSizeGroup = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SharedSizeGroup<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.DefinitionBase 
   => control._set(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty!, func);

/*SetterFromObservableGenerator*/
public static T SharedSizeGroup<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.DefinitionBase 
   => control._set(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SharedSizeGroup<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.DefinitionBase 
   => control._set(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty!, subject);



}

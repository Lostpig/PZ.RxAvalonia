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
public static partial class ManagedFileChooserOverwritePrompt_MarkupExtensions
{
//================= Properties ======================//
 // FileName

/*ValueSetterGenerator*/
public static T FileName<T>(this T control, System.String value) where T : Avalonia.Dialogs.ManagedFileChooserOverwritePrompt 
{
    control.FileName = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FileName<T>(this T control, Func<System.String> func) where T : Avalonia.Dialogs.ManagedFileChooserOverwritePrompt 
   => control._set(Avalonia.Dialogs.ManagedFileChooserOverwritePrompt.FileNameProperty!, func);

/*SetterFromObservableGenerator*/
public static T FileName<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Dialogs.ManagedFileChooserOverwritePrompt 
   => control._set(Avalonia.Dialogs.ManagedFileChooserOverwritePrompt.FileNameProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FileName<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Dialogs.ManagedFileChooserOverwritePrompt 
   => control._set(Avalonia.Dialogs.ManagedFileChooserOverwritePrompt.FileNameProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T FileName<T>(this T control, IObservable<System.String> obs, IObserver<System.String> changed) where T : Avalonia.Dialogs.ManagedFileChooserOverwritePrompt 
   => control._setEx(Avalonia.Dialogs.ManagedFileChooserOverwritePrompt.FileNameProperty!, obs, changed);



}

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
public static partial class RadioButton_MarkupExtensions
{
//================= Properties ======================//
 // GroupName

/*ValueSetterGenerator*/
public static T GroupName<T>(this T control, System.String value) where T : Avalonia.Controls.RadioButton 
{
    control.GroupName = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T GroupName<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.RadioButton 
   => control._set(Avalonia.Controls.RadioButton.GroupNameProperty!, func);

/*SetterFromObservableGenerator*/
public static T GroupName<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.RadioButton 
   => control._set(Avalonia.Controls.RadioButton.GroupNameProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T GroupName<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.RadioButton 
   => control._set(Avalonia.Controls.RadioButton.GroupNameProperty!, subject);



//================= Styles ======================//
 // GroupName

/*ValueStyleSetterGenerator*/
public static Style<T> GroupName<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.RadioButton 
=> style._addSetter(Avalonia.Controls.RadioButton.GroupNameProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> GroupName<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.RadioButton 
=> style._addSetter(Avalonia.Controls.RadioButton.GroupNameProperty, binding);



}

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
public static partial class TabItem_MarkupExtensions
{
//================= Properties ======================//
 // IsSelected

/*ValueSetterGenerator*/
public static T IsSelected<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TabItem 
{
    control.IsSelected = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsSelected<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.TabItem 
   => control._set(Avalonia.Controls.TabItem.IsSelectedProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsSelected<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.TabItem 
   => control._set(Avalonia.Controls.TabItem.IsSelectedProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsSelected<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.TabItem 
   => control._set(Avalonia.Controls.TabItem.IsSelectedProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsSelected<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.TabItem 
   => control._setEx(Avalonia.Controls.TabItem.IsSelectedProperty!, obs, changed);



//================= Styles ======================//
 // IsSelected

/*ValueStyleSetterGenerator*/
public static Style<T> IsSelected<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TabItem 
=> style._addSetter(Avalonia.Controls.TabItem.IsSelectedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsSelected<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TabItem 
=> style._addSetter(Avalonia.Controls.TabItem.IsSelectedProperty, binding);



}

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
public static partial class HyperlinkButton_MarkupExtensions
{
//================= Properties ======================//
 // IsVisited

/*ValueSetterGenerator*/
public static T IsVisited<T>(this T control, System.Boolean value) where T : Avalonia.Controls.HyperlinkButton 
{
    control.IsVisited = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsVisited<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.HyperlinkButton 
   => control._set(Avalonia.Controls.HyperlinkButton.IsVisitedProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsVisited<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.HyperlinkButton 
   => control._set(Avalonia.Controls.HyperlinkButton.IsVisitedProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsVisited<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.HyperlinkButton 
   => control._set(Avalonia.Controls.HyperlinkButton.IsVisitedProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsVisited<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.HyperlinkButton 
   => control._setEx(Avalonia.Controls.HyperlinkButton.IsVisitedProperty!, obs, changed);


 // NavigateUri

/*ValueSetterGenerator*/
public static T NavigateUri<T>(this T control, System.Uri? value) where T : Avalonia.Controls.HyperlinkButton 
{
    control.NavigateUri = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T NavigateUri<T>(this T control, Func<System.Uri?> func) where T : Avalonia.Controls.HyperlinkButton 
   => control._set(Avalonia.Controls.HyperlinkButton.NavigateUriProperty!, func);

/*SetterFromObservableGenerator*/
public static T NavigateUri<T>(this T control, IObservable<System.Uri?> obs) where T : Avalonia.Controls.HyperlinkButton 
   => control._set(Avalonia.Controls.HyperlinkButton.NavigateUriProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T NavigateUri<T>(this T control, ISubject<System.Uri?> subject) where T : Avalonia.Controls.HyperlinkButton 
   => control._set(Avalonia.Controls.HyperlinkButton.NavigateUriProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T NavigateUri<T>(this T control, IObservable<System.Uri?> obs, IObserver<System.Uri?> changed) where T : Avalonia.Controls.HyperlinkButton 
   => control._setEx(Avalonia.Controls.HyperlinkButton.NavigateUriProperty!, obs, changed);



//================= Styles ======================//
 // IsVisited

/*ValueStyleSetterGenerator*/
public static Style<T> IsVisited<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.HyperlinkButton 
=> style._addSetter(Avalonia.Controls.HyperlinkButton.IsVisitedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsVisited<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.HyperlinkButton 
=> style._addSetter(Avalonia.Controls.HyperlinkButton.IsVisitedProperty, binding);


 // NavigateUri

/*ValueStyleSetterGenerator*/
public static Style<T> NavigateUri<T>(this Style<T> style, System.Uri? value) where T : Avalonia.Controls.HyperlinkButton 
=> style._addSetter(Avalonia.Controls.HyperlinkButton.NavigateUriProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> NavigateUri<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.HyperlinkButton 
=> style._addSetter(Avalonia.Controls.HyperlinkButton.NavigateUriProperty, binding);



}

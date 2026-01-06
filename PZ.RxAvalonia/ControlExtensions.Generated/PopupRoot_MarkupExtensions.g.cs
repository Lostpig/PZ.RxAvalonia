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
public static partial class PopupRoot_MarkupExtensions
{
//================= Properties ======================//
 // Transform

/*ValueSetterGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot Transform(this Avalonia.Controls.Primitives.PopupRoot control, Avalonia.Media.Transform? value)  
{
    control.Transform = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot Transform(this Avalonia.Controls.Primitives.PopupRoot control, Func<Avalonia.Media.Transform?> func)  
   => control._set(Avalonia.Controls.Primitives.PopupRoot.TransformProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot Transform(this Avalonia.Controls.Primitives.PopupRoot control, IObservable<Avalonia.Media.Transform?> obs)  
   => control._set(Avalonia.Controls.Primitives.PopupRoot.TransformProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot Transform(this Avalonia.Controls.Primitives.PopupRoot control, ISubject<Avalonia.Media.Transform?> subject)  
   => control._set(Avalonia.Controls.Primitives.PopupRoot.TransformProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot Transform(this Avalonia.Controls.Primitives.PopupRoot control, IObservable<Avalonia.Media.Transform?> obs, IObserver<Avalonia.Media.Transform?> changed)  
   => control._setEx(Avalonia.Controls.Primitives.PopupRoot.TransformProperty!, obs, changed);


 // WindowManagerAddShadowHint

/*ValueSetterGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot WindowManagerAddShadowHint(this Avalonia.Controls.Primitives.PopupRoot control, System.Boolean value)  
{
    control.WindowManagerAddShadowHint = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot WindowManagerAddShadowHint(this Avalonia.Controls.Primitives.PopupRoot control, Func<System.Boolean> func)  
   => control._set(Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot WindowManagerAddShadowHint(this Avalonia.Controls.Primitives.PopupRoot control, IObservable<System.Boolean> obs)  
   => control._set(Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot WindowManagerAddShadowHint(this Avalonia.Controls.Primitives.PopupRoot control, ISubject<System.Boolean> subject)  
   => control._set(Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot WindowManagerAddShadowHint(this Avalonia.Controls.Primitives.PopupRoot control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed)  
   => control._setEx(Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty!, obs, changed);



//================= Styles ======================//
 // Transform

/*ValueStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.PopupRoot> Transform(this Style<Avalonia.Controls.Primitives.PopupRoot> style, Avalonia.Media.Transform? value)  
=> style._addSetter(Avalonia.Controls.Primitives.PopupRoot.TransformProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.PopupRoot> Transform(this Style<Avalonia.Controls.Primitives.PopupRoot> style, IBinding binding)  
=> style._addSetter(Avalonia.Controls.Primitives.PopupRoot.TransformProperty, binding);


 // WindowManagerAddShadowHint

/*ValueStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.PopupRoot> WindowManagerAddShadowHint(this Style<Avalonia.Controls.Primitives.PopupRoot> style, System.Boolean value)  
=> style._addSetter(Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.PopupRoot> WindowManagerAddShadowHint(this Style<Avalonia.Controls.Primitives.PopupRoot> style, IBinding binding)  
=> style._addSetter(Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty, binding);



}

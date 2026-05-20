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
public static partial class WindowDrawnDecorations_MarkupExtensions
{
//================= Properties ======================//
 // Template

/*ValueSetterGenerator*/
public static T Template<T>(this T control, Avalonia.Controls.Chrome.IWindowDrawnDecorationsTemplate? value) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
{
    control.Template = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Template<T>(this T control, Func<Avalonia.Controls.Chrome.IWindowDrawnDecorationsTemplate?> func) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
   => control._set(Avalonia.Controls.Chrome.WindowDrawnDecorations.TemplateProperty!, func);

/*SetterFromObservableGenerator*/
public static T Template<T>(this T control, IObservable<Avalonia.Controls.Chrome.IWindowDrawnDecorationsTemplate?> obs) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
   => control._set(Avalonia.Controls.Chrome.WindowDrawnDecorations.TemplateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Template<T>(this T control, ISubject<Avalonia.Controls.Chrome.IWindowDrawnDecorationsTemplate?> subject) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
   => control._set(Avalonia.Controls.Chrome.WindowDrawnDecorations.TemplateProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Template<T>(this T control, IObservable<Avalonia.Controls.Chrome.IWindowDrawnDecorationsTemplate?> obs, IObserver<Avalonia.Controls.Chrome.IWindowDrawnDecorationsTemplate?> changed) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
   => control._setEx(Avalonia.Controls.Chrome.WindowDrawnDecorations.TemplateProperty!, obs, changed);


 // DefaultTitleBarHeight

/*ValueSetterGenerator*/
public static T DefaultTitleBarHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
{
    control.DefaultTitleBarHeight = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T DefaultTitleBarHeight<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
   => control._set(Avalonia.Controls.Chrome.WindowDrawnDecorations.DefaultTitleBarHeightProperty!, func);

/*SetterFromObservableGenerator*/
public static T DefaultTitleBarHeight<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
   => control._set(Avalonia.Controls.Chrome.WindowDrawnDecorations.DefaultTitleBarHeightProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DefaultTitleBarHeight<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
   => control._set(Avalonia.Controls.Chrome.WindowDrawnDecorations.DefaultTitleBarHeightProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DefaultTitleBarHeight<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
   => control._setEx(Avalonia.Controls.Chrome.WindowDrawnDecorations.DefaultTitleBarHeightProperty!, obs, changed);


 // DefaultFrameThickness

/*ValueSetterGenerator*/
public static T DefaultFrameThickness<T>(this T control, Avalonia.Thickness value) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
{
    control.DefaultFrameThickness = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static T DefaultFrameThickness<T>(this T control, System.Double uniformLength = default!) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
{
    control.DefaultFrameThickness = new Avalonia.Thickness(uniformLength);
    return control;
}
public static T DefaultFrameThickness<T>(this T control, System.Double horizontal = default!, System.Double vertical = default!) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
{
    control.DefaultFrameThickness = new Avalonia.Thickness(horizontal, vertical);
    return control;
}
public static T DefaultFrameThickness<T>(this T control, System.Double left = default!, System.Double top = default!, System.Double right = default!, System.Double bottom = default!) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
{
    control.DefaultFrameThickness = new Avalonia.Thickness(left, top, right, bottom);
    return control;
}

/*SetterFromFuncGenerator*/
public static T DefaultFrameThickness<T>(this T control, Func<Avalonia.Thickness> func) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
   => control._set(Avalonia.Controls.Chrome.WindowDrawnDecorations.DefaultFrameThicknessProperty!, func);

/*SetterFromObservableGenerator*/
public static T DefaultFrameThickness<T>(this T control, IObservable<Avalonia.Thickness> obs) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
   => control._set(Avalonia.Controls.Chrome.WindowDrawnDecorations.DefaultFrameThicknessProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DefaultFrameThickness<T>(this T control, ISubject<Avalonia.Thickness> subject) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
   => control._set(Avalonia.Controls.Chrome.WindowDrawnDecorations.DefaultFrameThicknessProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DefaultFrameThickness<T>(this T control, IObservable<Avalonia.Thickness> obs, IObserver<Avalonia.Thickness> changed) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
   => control._setEx(Avalonia.Controls.Chrome.WindowDrawnDecorations.DefaultFrameThicknessProperty!, obs, changed);


 // DefaultShadowThickness

/*ValueSetterGenerator*/
public static T DefaultShadowThickness<T>(this T control, Avalonia.Thickness value) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
{
    control.DefaultShadowThickness = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static T DefaultShadowThickness<T>(this T control, System.Double uniformLength = default!) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
{
    control.DefaultShadowThickness = new Avalonia.Thickness(uniformLength);
    return control;
}
public static T DefaultShadowThickness<T>(this T control, System.Double horizontal = default!, System.Double vertical = default!) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
{
    control.DefaultShadowThickness = new Avalonia.Thickness(horizontal, vertical);
    return control;
}
public static T DefaultShadowThickness<T>(this T control, System.Double left = default!, System.Double top = default!, System.Double right = default!, System.Double bottom = default!) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
{
    control.DefaultShadowThickness = new Avalonia.Thickness(left, top, right, bottom);
    return control;
}

/*SetterFromFuncGenerator*/
public static T DefaultShadowThickness<T>(this T control, Func<Avalonia.Thickness> func) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
   => control._set(Avalonia.Controls.Chrome.WindowDrawnDecorations.DefaultShadowThicknessProperty!, func);

/*SetterFromObservableGenerator*/
public static T DefaultShadowThickness<T>(this T control, IObservable<Avalonia.Thickness> obs) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
   => control._set(Avalonia.Controls.Chrome.WindowDrawnDecorations.DefaultShadowThicknessProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T DefaultShadowThickness<T>(this T control, ISubject<Avalonia.Thickness> subject) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
   => control._set(Avalonia.Controls.Chrome.WindowDrawnDecorations.DefaultShadowThicknessProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T DefaultShadowThickness<T>(this T control, IObservable<Avalonia.Thickness> obs, IObserver<Avalonia.Thickness> changed) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
   => control._setEx(Avalonia.Controls.Chrome.WindowDrawnDecorations.DefaultShadowThicknessProperty!, obs, changed);


 // Title

/*ValueSetterGenerator*/
public static T Title<T>(this T control, System.String? value) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
{
    control.Title = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Title<T>(this T control, Func<System.String?> func) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
   => control._set(Avalonia.Controls.Chrome.WindowDrawnDecorations.TitleProperty!, func);

/*SetterFromObservableGenerator*/
public static T Title<T>(this T control, IObservable<System.String?> obs) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
   => control._set(Avalonia.Controls.Chrome.WindowDrawnDecorations.TitleProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Title<T>(this T control, ISubject<System.String?> subject) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
   => control._set(Avalonia.Controls.Chrome.WindowDrawnDecorations.TitleProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Title<T>(this T control, IObservable<System.String?> obs, IObserver<System.String?> changed) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
   => control._setEx(Avalonia.Controls.Chrome.WindowDrawnDecorations.TitleProperty!, obs, changed);



//================= Styles ======================//
 // Template

/*ValueStyleSetterGenerator*/
public static Style<T> Template<T>(this Style<T> style, Avalonia.Controls.Chrome.IWindowDrawnDecorationsTemplate? value) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
=> style._addSetter(Avalonia.Controls.Chrome.WindowDrawnDecorations.TemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Template<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
=> style._addSetter(Avalonia.Controls.Chrome.WindowDrawnDecorations.TemplateProperty, binding);


 // DefaultTitleBarHeight

/*ValueStyleSetterGenerator*/
public static Style<T> DefaultTitleBarHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
=> style._addSetter(Avalonia.Controls.Chrome.WindowDrawnDecorations.DefaultTitleBarHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DefaultTitleBarHeight<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
=> style._addSetter(Avalonia.Controls.Chrome.WindowDrawnDecorations.DefaultTitleBarHeightProperty, binding);


 // DefaultFrameThickness

/*ValueStyleSetterGenerator*/
public static Style<T> DefaultFrameThickness<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
=> style._addSetter(Avalonia.Controls.Chrome.WindowDrawnDecorations.DefaultFrameThicknessProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DefaultFrameThickness<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
=> style._addSetter(Avalonia.Controls.Chrome.WindowDrawnDecorations.DefaultFrameThicknessProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> DefaultFrameThickness<T>(this Style<T> style, System.Double uniformLength) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
   => style._addSetter(Avalonia.Controls.Chrome.WindowDrawnDecorations.DefaultFrameThicknessProperty, new Avalonia.Thickness(uniformLength));public static Style<T> DefaultFrameThickness<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
   => style._addSetter(Avalonia.Controls.Chrome.WindowDrawnDecorations.DefaultFrameThicknessProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> DefaultFrameThickness<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
   => style._addSetter(Avalonia.Controls.Chrome.WindowDrawnDecorations.DefaultFrameThicknessProperty, new Avalonia.Thickness(left, top, right, bottom));


 // DefaultShadowThickness

/*ValueStyleSetterGenerator*/
public static Style<T> DefaultShadowThickness<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
=> style._addSetter(Avalonia.Controls.Chrome.WindowDrawnDecorations.DefaultShadowThicknessProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DefaultShadowThickness<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
=> style._addSetter(Avalonia.Controls.Chrome.WindowDrawnDecorations.DefaultShadowThicknessProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> DefaultShadowThickness<T>(this Style<T> style, System.Double uniformLength) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
   => style._addSetter(Avalonia.Controls.Chrome.WindowDrawnDecorations.DefaultShadowThicknessProperty, new Avalonia.Thickness(uniformLength));public static Style<T> DefaultShadowThickness<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
   => style._addSetter(Avalonia.Controls.Chrome.WindowDrawnDecorations.DefaultShadowThicknessProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> DefaultShadowThickness<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
   => style._addSetter(Avalonia.Controls.Chrome.WindowDrawnDecorations.DefaultShadowThicknessProperty, new Avalonia.Thickness(left, top, right, bottom));


 // Title

/*ValueStyleSetterGenerator*/
public static Style<T> Title<T>(this Style<T> style, System.String? value) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
=> style._addSetter(Avalonia.Controls.Chrome.WindowDrawnDecorations.TitleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Title<T>(this Style<T> style, BindingBase binding) where T : Avalonia.Controls.Chrome.WindowDrawnDecorations 
=> style._addSetter(Avalonia.Controls.Chrome.WindowDrawnDecorations.TitleProperty, binding);



}

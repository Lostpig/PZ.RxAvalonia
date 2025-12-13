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
public static partial class ItemsPresenter_MarkupExtensions
{
//================= Properties ======================//
 // ItemsPanel

/*ValueSetterGenerator*/
public static T ItemsPanel<T>(this T control, Avalonia.Controls.ITemplate<Avalonia.Controls.Panel> value) where T : Avalonia.Controls.Presenters.ItemsPresenter 
{
    control.ItemsPanel = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ItemsPanel<T>(this T control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> func) where T : Avalonia.Controls.Presenters.ItemsPresenter 
   => control._set(Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty!, func);

/*SetterFromObservableGenerator*/
public static T ItemsPanel<T>(this T control, IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> obs) where T : Avalonia.Controls.Presenters.ItemsPresenter 
   => control._set(Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ItemsPanel<T>(this T control, ISubject<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> subject) where T : Avalonia.Controls.Presenters.ItemsPresenter 
   => control._set(Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ItemsPanel<T>(this T control, IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> obs, IObserver<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> changed) where T : Avalonia.Controls.Presenters.ItemsPresenter 
   => control._setEx(Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty!, obs, changed);



//================= Styles ======================//
 // ItemsPanel

/*ValueStyleSetterGenerator*/
public static Style<T> ItemsPanel<T>(this Style<T> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Panel> value) where T : Avalonia.Controls.Presenters.ItemsPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemsPanel<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ItemsPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty, binding);



}

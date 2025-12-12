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
public static partial class RelativePanel_MarkupExtensions
{
//================= Attached Properties ======================//
 // Above

/*AttachedPropertyFuncGenerator*/
public static T RelativePanel_Above<T>(this T control, Func<System.Object> getter) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AboveProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T RelativePanel_Above<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AboveProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T RelativePanel_Above<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AboveProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T RelativePanel_Above<T>(this T control, System.Object value) where T : Avalonia.AvaloniaObject 
{
    control.SetValue(Avalonia.Controls.RelativePanel.AboveProperty!, value);
    return control;
}


 // AlignBottomWithPanel

/*AttachedPropertyFuncGenerator*/
public static T RelativePanel_AlignBottomWithPanel<T>(this T control, Func<System.Boolean> getter) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignBottomWithPanelProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T RelativePanel_AlignBottomWithPanel<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignBottomWithPanelProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T RelativePanel_AlignBottomWithPanel<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignBottomWithPanelProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T RelativePanel_AlignBottomWithPanel<T>(this T control, System.Boolean value) where T : Avalonia.AvaloniaObject 
{
    control.SetValue(Avalonia.Controls.RelativePanel.AlignBottomWithPanelProperty!, value);
    return control;
}


 // AlignBottomWith

/*AttachedPropertyFuncGenerator*/
public static T RelativePanel_AlignBottomWith<T>(this T control, Func<System.Object> getter) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignBottomWithProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T RelativePanel_AlignBottomWith<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignBottomWithProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T RelativePanel_AlignBottomWith<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignBottomWithProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T RelativePanel_AlignBottomWith<T>(this T control, System.Object value) where T : Avalonia.AvaloniaObject 
{
    control.SetValue(Avalonia.Controls.RelativePanel.AlignBottomWithProperty!, value);
    return control;
}


 // AlignHorizontalCenterWithPanel

/*AttachedPropertyFuncGenerator*/
public static T RelativePanel_AlignHorizontalCenterWithPanel<T>(this T control, Func<System.Boolean> getter) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignHorizontalCenterWithPanelProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T RelativePanel_AlignHorizontalCenterWithPanel<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignHorizontalCenterWithPanelProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T RelativePanel_AlignHorizontalCenterWithPanel<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignHorizontalCenterWithPanelProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T RelativePanel_AlignHorizontalCenterWithPanel<T>(this T control, System.Boolean value) where T : Avalonia.AvaloniaObject 
{
    control.SetValue(Avalonia.Controls.RelativePanel.AlignHorizontalCenterWithPanelProperty!, value);
    return control;
}


 // AlignHorizontalCenterWith

/*AttachedPropertyFuncGenerator*/
public static T RelativePanel_AlignHorizontalCenterWith<T>(this T control, Func<System.Object> getter) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignHorizontalCenterWithProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T RelativePanel_AlignHorizontalCenterWith<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignHorizontalCenterWithProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T RelativePanel_AlignHorizontalCenterWith<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignHorizontalCenterWithProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T RelativePanel_AlignHorizontalCenterWith<T>(this T control, System.Object value) where T : Avalonia.AvaloniaObject 
{
    control.SetValue(Avalonia.Controls.RelativePanel.AlignHorizontalCenterWithProperty!, value);
    return control;
}


 // AlignLeftWithPanel

/*AttachedPropertyFuncGenerator*/
public static T RelativePanel_AlignLeftWithPanel<T>(this T control, Func<System.Boolean> getter) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignLeftWithPanelProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T RelativePanel_AlignLeftWithPanel<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignLeftWithPanelProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T RelativePanel_AlignLeftWithPanel<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignLeftWithPanelProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T RelativePanel_AlignLeftWithPanel<T>(this T control, System.Boolean value) where T : Avalonia.AvaloniaObject 
{
    control.SetValue(Avalonia.Controls.RelativePanel.AlignLeftWithPanelProperty!, value);
    return control;
}


 // AlignLeftWith

/*AttachedPropertyFuncGenerator*/
public static T RelativePanel_AlignLeftWith<T>(this T control, Func<System.Object> getter) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignLeftWithProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T RelativePanel_AlignLeftWith<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignLeftWithProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T RelativePanel_AlignLeftWith<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignLeftWithProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T RelativePanel_AlignLeftWith<T>(this T control, System.Object value) where T : Avalonia.AvaloniaObject 
{
    control.SetValue(Avalonia.Controls.RelativePanel.AlignLeftWithProperty!, value);
    return control;
}


 // AlignRightWithPanel

/*AttachedPropertyFuncGenerator*/
public static T RelativePanel_AlignRightWithPanel<T>(this T control, Func<System.Boolean> getter) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignRightWithPanelProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T RelativePanel_AlignRightWithPanel<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignRightWithPanelProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T RelativePanel_AlignRightWithPanel<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignRightWithPanelProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T RelativePanel_AlignRightWithPanel<T>(this T control, System.Boolean value) where T : Avalonia.AvaloniaObject 
{
    control.SetValue(Avalonia.Controls.RelativePanel.AlignRightWithPanelProperty!, value);
    return control;
}


 // AlignRightWith

/*AttachedPropertyFuncGenerator*/
public static T RelativePanel_AlignRightWith<T>(this T control, Func<System.Object> getter) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignRightWithProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T RelativePanel_AlignRightWith<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignRightWithProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T RelativePanel_AlignRightWith<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignRightWithProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T RelativePanel_AlignRightWith<T>(this T control, System.Object value) where T : Avalonia.AvaloniaObject 
{
    control.SetValue(Avalonia.Controls.RelativePanel.AlignRightWithProperty!, value);
    return control;
}


 // AlignTopWithPanel

/*AttachedPropertyFuncGenerator*/
public static T RelativePanel_AlignTopWithPanel<T>(this T control, Func<System.Boolean> getter) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignTopWithPanelProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T RelativePanel_AlignTopWithPanel<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignTopWithPanelProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T RelativePanel_AlignTopWithPanel<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignTopWithPanelProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T RelativePanel_AlignTopWithPanel<T>(this T control, System.Boolean value) where T : Avalonia.AvaloniaObject 
{
    control.SetValue(Avalonia.Controls.RelativePanel.AlignTopWithPanelProperty!, value);
    return control;
}


 // AlignTopWith

/*AttachedPropertyFuncGenerator*/
public static T RelativePanel_AlignTopWith<T>(this T control, Func<System.Object> getter) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignTopWithProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T RelativePanel_AlignTopWith<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignTopWithProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T RelativePanel_AlignTopWith<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignTopWithProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T RelativePanel_AlignTopWith<T>(this T control, System.Object value) where T : Avalonia.AvaloniaObject 
{
    control.SetValue(Avalonia.Controls.RelativePanel.AlignTopWithProperty!, value);
    return control;
}


 // AlignVerticalCenterWithPanel

/*AttachedPropertyFuncGenerator*/
public static T RelativePanel_AlignVerticalCenterWithPanel<T>(this T control, Func<System.Boolean> getter) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignVerticalCenterWithPanelProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T RelativePanel_AlignVerticalCenterWithPanel<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignVerticalCenterWithPanelProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T RelativePanel_AlignVerticalCenterWithPanel<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignVerticalCenterWithPanelProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T RelativePanel_AlignVerticalCenterWithPanel<T>(this T control, System.Boolean value) where T : Avalonia.AvaloniaObject 
{
    control.SetValue(Avalonia.Controls.RelativePanel.AlignVerticalCenterWithPanelProperty!, value);
    return control;
}


 // AlignVerticalCenterWith

/*AttachedPropertyFuncGenerator*/
public static T RelativePanel_AlignVerticalCenterWith<T>(this T control, Func<System.Object> getter) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignVerticalCenterWithProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T RelativePanel_AlignVerticalCenterWith<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignVerticalCenterWithProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T RelativePanel_AlignVerticalCenterWith<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.AlignVerticalCenterWithProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T RelativePanel_AlignVerticalCenterWith<T>(this T control, System.Object value) where T : Avalonia.AvaloniaObject 
{
    control.SetValue(Avalonia.Controls.RelativePanel.AlignVerticalCenterWithProperty!, value);
    return control;
}


 // Below

/*AttachedPropertyFuncGenerator*/
public static T RelativePanel_Below<T>(this T control, Func<System.Object> getter) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.BelowProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T RelativePanel_Below<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.BelowProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T RelativePanel_Below<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.BelowProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T RelativePanel_Below<T>(this T control, System.Object value) where T : Avalonia.AvaloniaObject 
{
    control.SetValue(Avalonia.Controls.RelativePanel.BelowProperty!, value);
    return control;
}


 // LeftOf

/*AttachedPropertyFuncGenerator*/
public static T RelativePanel_LeftOf<T>(this T control, Func<System.Object> getter) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.LeftOfProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T RelativePanel_LeftOf<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.LeftOfProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T RelativePanel_LeftOf<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.LeftOfProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T RelativePanel_LeftOf<T>(this T control, System.Object value) where T : Avalonia.AvaloniaObject 
{
    control.SetValue(Avalonia.Controls.RelativePanel.LeftOfProperty!, value);
    return control;
}


 // RightOf

/*AttachedPropertyFuncGenerator*/
public static T RelativePanel_RightOf<T>(this T control, Func<System.Object> getter) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.RightOfProperty!, getter);

/*AttachedPropertyObservableGenerator*/
public static T RelativePanel_RightOf<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.RightOfProperty!, obs);

/*AttachedPropertySubjectGenerator*/
public static T RelativePanel_RightOf<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.RelativePanel.RightOfProperty!, subject);

/*AttachedPropertyValueGenerator*/
public static T RelativePanel_RightOf<T>(this T control, System.Object value) where T : Avalonia.AvaloniaObject 
{
    control.SetValue(Avalonia.Controls.RelativePanel.RightOfProperty!, value);
    return control;
}



}

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
public static partial class AutoCompleteBox_MarkupExtensions
{
//================= Properties ======================//
 // CaretIndex

/*ValueSetterGenerator*/
public static T CaretIndex<T>(this T control, System.Int32 value) where T : Avalonia.Controls.AutoCompleteBox 
{
    control.CaretIndex = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T CaretIndex<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.CaretIndexProperty!, func);

/*SetterFromObservableGenerator*/
public static T CaretIndex<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.CaretIndexProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T CaretIndex<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.CaretIndexProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T CaretIndex<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.AutoCompleteBox 
   => control._setEx(Avalonia.Controls.AutoCompleteBox.CaretIndexProperty!, obs, changed);


 // Watermark

/*ValueSetterGenerator*/
public static T Watermark<T>(this T control, System.String value) where T : Avalonia.Controls.AutoCompleteBox 
{
    control.Watermark = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Watermark<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.WatermarkProperty!, func);

/*SetterFromObservableGenerator*/
public static T Watermark<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.WatermarkProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Watermark<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.WatermarkProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Watermark<T>(this T control, IObservable<System.String> obs, IObserver<System.String> changed) where T : Avalonia.Controls.AutoCompleteBox 
   => control._setEx(Avalonia.Controls.AutoCompleteBox.WatermarkProperty!, obs, changed);


 // MinimumPrefixLength

/*ValueSetterGenerator*/
public static T MinimumPrefixLength<T>(this T control, System.Int32 value) where T : Avalonia.Controls.AutoCompleteBox 
{
    control.MinimumPrefixLength = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MinimumPrefixLength<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty!, func);

/*SetterFromObservableGenerator*/
public static T MinimumPrefixLength<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MinimumPrefixLength<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T MinimumPrefixLength<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.AutoCompleteBox 
   => control._setEx(Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty!, obs, changed);


 // MinimumPopulateDelay

/*ValueSetterGenerator*/
public static T MinimumPopulateDelay<T>(this T control, System.TimeSpan value) where T : Avalonia.Controls.AutoCompleteBox 
{
    control.MinimumPopulateDelay = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MinimumPopulateDelay<T>(this T control, Func<System.TimeSpan> func) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty!, func);

/*SetterFromObservableGenerator*/
public static T MinimumPopulateDelay<T>(this T control, IObservable<System.TimeSpan> obs) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MinimumPopulateDelay<T>(this T control, ISubject<System.TimeSpan> subject) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T MinimumPopulateDelay<T>(this T control, IObservable<System.TimeSpan> obs, IObserver<System.TimeSpan> changed) where T : Avalonia.Controls.AutoCompleteBox 
   => control._setEx(Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty!, obs, changed);


 // MaxDropDownHeight

/*ValueSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.AutoCompleteBox 
{
    control.MaxDropDownHeight = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MaxDropDownHeight<T>(this T control, Func<System.Double> func) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty!, func);

/*SetterFromObservableGenerator*/
public static T MaxDropDownHeight<T>(this T control, IObservable<System.Double> obs) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MaxDropDownHeight<T>(this T control, ISubject<System.Double> subject) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T MaxDropDownHeight<T>(this T control, IObservable<System.Double> obs, IObserver<System.Double> changed) where T : Avalonia.Controls.AutoCompleteBox 
   => control._setEx(Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty!, obs, changed);


 // IsTextCompletionEnabled

/*ValueSetterGenerator*/
public static T IsTextCompletionEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.AutoCompleteBox 
{
    control.IsTextCompletionEnabled = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsTextCompletionEnabled<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsTextCompletionEnabled<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsTextCompletionEnabled<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsTextCompletionEnabled<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.AutoCompleteBox 
   => control._setEx(Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty!, obs, changed);


 // ItemTemplate

/*ValueSetterGenerator*/
public static T ItemTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.AutoCompleteBox 
{
    control.ItemTemplate = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ItemTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty!, func);

/*SetterFromObservableGenerator*/
public static T ItemTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate> obs) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ItemTemplate<T>(this T control, ISubject<Avalonia.Controls.Templates.IDataTemplate> subject) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ItemTemplate<T>(this T control, IObservable<Avalonia.Controls.Templates.IDataTemplate> obs, IObserver<Avalonia.Controls.Templates.IDataTemplate> changed) where T : Avalonia.Controls.AutoCompleteBox 
   => control._setEx(Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty!, obs, changed);


 // ClearSelectionOnLostFocus

/*ValueSetterGenerator*/
public static T ClearSelectionOnLostFocus<T>(this T control, System.Boolean value) where T : Avalonia.Controls.AutoCompleteBox 
{
    control.ClearSelectionOnLostFocus = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ClearSelectionOnLostFocus<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.ClearSelectionOnLostFocusProperty!, func);

/*SetterFromObservableGenerator*/
public static T ClearSelectionOnLostFocus<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.ClearSelectionOnLostFocusProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ClearSelectionOnLostFocus<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.ClearSelectionOnLostFocusProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ClearSelectionOnLostFocus<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.AutoCompleteBox 
   => control._setEx(Avalonia.Controls.AutoCompleteBox.ClearSelectionOnLostFocusProperty!, obs, changed);


 // IsDropDownOpen

/*ValueSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, System.Boolean value) where T : Avalonia.Controls.AutoCompleteBox 
{
    control.IsDropDownOpen = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T IsDropDownOpen<T>(this T control, Func<System.Boolean> func) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty!, func);

/*SetterFromObservableGenerator*/
public static T IsDropDownOpen<T>(this T control, IObservable<System.Boolean> obs) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T IsDropDownOpen<T>(this T control, ISubject<System.Boolean> subject) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T IsDropDownOpen<T>(this T control, IObservable<System.Boolean> obs, IObserver<System.Boolean> changed) where T : Avalonia.Controls.AutoCompleteBox 
   => control._setEx(Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty!, obs, changed);


 // SelectedItem

/*ValueSetterGenerator*/
public static T SelectedItem<T>(this T control, System.Object value) where T : Avalonia.Controls.AutoCompleteBox 
{
    control.SelectedItem = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T SelectedItem<T>(this T control, Func<System.Object> func) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.SelectedItemProperty!, func);

/*SetterFromObservableGenerator*/
public static T SelectedItem<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.SelectedItemProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T SelectedItem<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.SelectedItemProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T SelectedItem<T>(this T control, IObservable<System.Object> obs, IObserver<System.Object> changed) where T : Avalonia.Controls.AutoCompleteBox 
   => control._setEx(Avalonia.Controls.AutoCompleteBox.SelectedItemProperty!, obs, changed);


 // Text

/*ValueSetterGenerator*/
public static T Text<T>(this T control, System.String value) where T : Avalonia.Controls.AutoCompleteBox 
{
    control.Text = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T Text<T>(this T control, Func<System.String> func) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.TextProperty!, func);

/*SetterFromObservableGenerator*/
public static T Text<T>(this T control, IObservable<System.String> obs) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.TextProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T Text<T>(this T control, ISubject<System.String> subject) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.TextProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T Text<T>(this T control, IObservable<System.String> obs, IObserver<System.String> changed) where T : Avalonia.Controls.AutoCompleteBox 
   => control._setEx(Avalonia.Controls.AutoCompleteBox.TextProperty!, obs, changed);


 // FilterMode

/*ValueSetterGenerator*/
public static T FilterMode<T>(this T control, Avalonia.Controls.AutoCompleteFilterMode value) where T : Avalonia.Controls.AutoCompleteBox 
{
    control.FilterMode = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T FilterMode<T>(this T control, Func<Avalonia.Controls.AutoCompleteFilterMode> func) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.FilterModeProperty!, func);

/*SetterFromObservableGenerator*/
public static T FilterMode<T>(this T control, IObservable<Avalonia.Controls.AutoCompleteFilterMode> obs) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.FilterModeProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T FilterMode<T>(this T control, ISubject<Avalonia.Controls.AutoCompleteFilterMode> subject) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.FilterModeProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T FilterMode<T>(this T control, IObservable<Avalonia.Controls.AutoCompleteFilterMode> obs, IObserver<Avalonia.Controls.AutoCompleteFilterMode> changed) where T : Avalonia.Controls.AutoCompleteBox 
   => control._setEx(Avalonia.Controls.AutoCompleteBox.FilterModeProperty!, obs, changed);


 // ItemFilter

/*ValueSetterGenerator*/
public static T ItemFilter<T>(this T control, Avalonia.Controls.AutoCompleteFilterPredicate<System.Object> value) where T : Avalonia.Controls.AutoCompleteBox 
{
    control.ItemFilter = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ItemFilter<T>(this T control, Func<Avalonia.Controls.AutoCompleteFilterPredicate<System.Object>> func) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemFilterProperty!, func);

/*SetterFromObservableGenerator*/
public static T ItemFilter<T>(this T control, IObservable<Avalonia.Controls.AutoCompleteFilterPredicate<System.Object>> obs) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemFilterProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ItemFilter<T>(this T control, ISubject<Avalonia.Controls.AutoCompleteFilterPredicate<System.Object>> subject) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemFilterProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ItemFilter<T>(this T control, IObservable<Avalonia.Controls.AutoCompleteFilterPredicate<System.Object>> obs, IObserver<Avalonia.Controls.AutoCompleteFilterPredicate<System.Object>> changed) where T : Avalonia.Controls.AutoCompleteBox 
   => control._setEx(Avalonia.Controls.AutoCompleteBox.ItemFilterProperty!, obs, changed);


 // TextFilter

/*ValueSetterGenerator*/
public static T TextFilter<T>(this T control, Avalonia.Controls.AutoCompleteFilterPredicate<System.String> value) where T : Avalonia.Controls.AutoCompleteBox 
{
    control.TextFilter = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TextFilter<T>(this T control, Func<Avalonia.Controls.AutoCompleteFilterPredicate<System.String>> func) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.TextFilterProperty!, func);

/*SetterFromObservableGenerator*/
public static T TextFilter<T>(this T control, IObservable<Avalonia.Controls.AutoCompleteFilterPredicate<System.String>> obs) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.TextFilterProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TextFilter<T>(this T control, ISubject<Avalonia.Controls.AutoCompleteFilterPredicate<System.String>> subject) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.TextFilterProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T TextFilter<T>(this T control, IObservable<Avalonia.Controls.AutoCompleteFilterPredicate<System.String>> obs, IObserver<Avalonia.Controls.AutoCompleteFilterPredicate<System.String>> changed) where T : Avalonia.Controls.AutoCompleteBox 
   => control._setEx(Avalonia.Controls.AutoCompleteBox.TextFilterProperty!, obs, changed);


 // ItemSelector

/*ValueSetterGenerator*/
public static T ItemSelector<T>(this T control, Avalonia.Controls.AutoCompleteSelector<System.Object> value) where T : Avalonia.Controls.AutoCompleteBox 
{
    control.ItemSelector = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ItemSelector<T>(this T control, Func<Avalonia.Controls.AutoCompleteSelector<System.Object>> func) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty!, func);

/*SetterFromObservableGenerator*/
public static T ItemSelector<T>(this T control, IObservable<Avalonia.Controls.AutoCompleteSelector<System.Object>> obs) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ItemSelector<T>(this T control, ISubject<Avalonia.Controls.AutoCompleteSelector<System.Object>> subject) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ItemSelector<T>(this T control, IObservable<Avalonia.Controls.AutoCompleteSelector<System.Object>> obs, IObserver<Avalonia.Controls.AutoCompleteSelector<System.Object>> changed) where T : Avalonia.Controls.AutoCompleteBox 
   => control._setEx(Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty!, obs, changed);


 // TextSelector

/*ValueSetterGenerator*/
public static T TextSelector<T>(this T control, Avalonia.Controls.AutoCompleteSelector<System.String> value) where T : Avalonia.Controls.AutoCompleteBox 
{
    control.TextSelector = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T TextSelector<T>(this T control, Func<Avalonia.Controls.AutoCompleteSelector<System.String>> func) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.TextSelectorProperty!, func);

/*SetterFromObservableGenerator*/
public static T TextSelector<T>(this T control, IObservable<Avalonia.Controls.AutoCompleteSelector<System.String>> obs) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.TextSelectorProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T TextSelector<T>(this T control, ISubject<Avalonia.Controls.AutoCompleteSelector<System.String>> subject) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.TextSelectorProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T TextSelector<T>(this T control, IObservable<Avalonia.Controls.AutoCompleteSelector<System.String>> obs, IObserver<Avalonia.Controls.AutoCompleteSelector<System.String>> changed) where T : Avalonia.Controls.AutoCompleteBox 
   => control._setEx(Avalonia.Controls.AutoCompleteBox.TextSelectorProperty!, obs, changed);


 // ItemsSource

/*ValueSetterGenerator*/
public static T ItemsSource<T>(this T control, System.Collections.IEnumerable value) where T : Avalonia.Controls.AutoCompleteBox 
{
    control.ItemsSource = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T ItemsSource<T>(this T control, Func<System.Collections.IEnumerable> func) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemsSourceProperty!, func);

/*SetterFromObservableGenerator*/
public static T ItemsSource<T>(this T control, IObservable<System.Collections.IEnumerable> obs) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemsSourceProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T ItemsSource<T>(this T control, ISubject<System.Collections.IEnumerable> subject) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemsSourceProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T ItemsSource<T>(this T control, IObservable<System.Collections.IEnumerable> obs, IObserver<System.Collections.IEnumerable> changed) where T : Avalonia.Controls.AutoCompleteBox 
   => control._setEx(Avalonia.Controls.AutoCompleteBox.ItemsSourceProperty!, obs, changed);


 // AsyncPopulator

/*ValueSetterGenerator*/
public static T AsyncPopulator<T>(this T control, System.Func<System.String,System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>> value) where T : Avalonia.Controls.AutoCompleteBox 
{
    control.AsyncPopulator = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T AsyncPopulator<T>(this T control, Func<System.Func<System.String,System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>>> func) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty!, func);

/*SetterFromObservableGenerator*/
public static T AsyncPopulator<T>(this T control, IObservable<System.Func<System.String,System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>>> obs) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T AsyncPopulator<T>(this T control, ISubject<System.Func<System.String,System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>>> subject) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T AsyncPopulator<T>(this T control, IObservable<System.Func<System.String,System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>>> obs, IObserver<System.Func<System.String,System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>>> changed) where T : Avalonia.Controls.AutoCompleteBox 
   => control._setEx(Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty!, obs, changed);


 // MaxLength

/*ValueSetterGenerator*/
public static T MaxLength<T>(this T control, System.Int32 value) where T : Avalonia.Controls.AutoCompleteBox 
{
    control.MaxLength = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T MaxLength<T>(this T control, Func<System.Int32> func) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.MaxLengthProperty!, func);

/*SetterFromObservableGenerator*/
public static T MaxLength<T>(this T control, IObservable<System.Int32> obs) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.MaxLengthProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T MaxLength<T>(this T control, ISubject<System.Int32> subject) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.MaxLengthProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T MaxLength<T>(this T control, IObservable<System.Int32> obs, IObserver<System.Int32> changed) where T : Avalonia.Controls.AutoCompleteBox 
   => control._setEx(Avalonia.Controls.AutoCompleteBox.MaxLengthProperty!, obs, changed);


 // InnerLeftContent

/*ValueSetterGenerator*/
public static T InnerLeftContent<T>(this T control, System.Object value) where T : Avalonia.Controls.AutoCompleteBox 
{
    control.InnerLeftContent = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T InnerLeftContent<T>(this T control, Func<System.Object> func) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.InnerLeftContentProperty!, func);

/*SetterFromObservableGenerator*/
public static T InnerLeftContent<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.InnerLeftContentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T InnerLeftContent<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.InnerLeftContentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T InnerLeftContent<T>(this T control, IObservable<System.Object> obs, IObserver<System.Object> changed) where T : Avalonia.Controls.AutoCompleteBox 
   => control._setEx(Avalonia.Controls.AutoCompleteBox.InnerLeftContentProperty!, obs, changed);


 // InnerRightContent

/*ValueSetterGenerator*/
public static T InnerRightContent<T>(this T control, System.Object value) where T : Avalonia.Controls.AutoCompleteBox 
{
    control.InnerRightContent = value!;
    return control;
}

/*SetterFromFuncGenerator*/
public static T InnerRightContent<T>(this T control, Func<System.Object> func) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.InnerRightContentProperty!, func);

/*SetterFromObservableGenerator*/
public static T InnerRightContent<T>(this T control, IObservable<System.Object> obs) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.InnerRightContentProperty!, obs);

/*SetterFromSubjectGenerator*/
public static T InnerRightContent<T>(this T control, ISubject<System.Object> subject) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.InnerRightContentProperty!, subject);

/*SetterFromTwoWayGenerator*/
public static T InnerRightContent<T>(this T control, IObservable<System.Object> obs, IObserver<System.Object> changed) where T : Avalonia.Controls.AutoCompleteBox 
   => control._setEx(Avalonia.Controls.AutoCompleteBox.InnerRightContentProperty!, obs, changed);



//================= Events ======================//
 // TextChanged

/*ActionToEventGenerator*/
public static T OnTextChanged<T>(this T control, Action<Avalonia.Controls.TextChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.AutoCompleteBox 
{
  control.AddHandler(Avalonia.Controls.AutoCompleteBox.TextChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.AutoCompleteBox.TextChangedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxTextChanged<T>(this T control, IObserver<Avalonia.Controls.TextChangedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.AutoCompleteBox 
{
  control.AddHandler(Avalonia.Controls.AutoCompleteBox.TextChangedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.AutoCompleteBox.TextChangedEvent.RoutingStrategies);
  return control;
}



 // Populating

/*ActionToEventGenerator*/
public static T OnPopulating<T>(this T control, Action<Avalonia.Controls.PopulatingEventArgs> action) where T : Avalonia.Controls.AutoCompleteBox  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.PopulatingEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Populating += h);

/*ReactiveEventGenerator*/
public static T RxPopulating<T>(this T control, IObserver<Avalonia.Controls.PopulatingEventArgs> observer) where T : Avalonia.Controls.AutoCompleteBox  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.PopulatingEventArgs>) ((arg0, arg1) => observer.OnNext((arg1))), h => control.Populating += h);


 // Populated

/*ActionToEventGenerator*/
public static T OnPopulated<T>(this T control, Action<Avalonia.Controls.PopulatedEventArgs> action) where T : Avalonia.Controls.AutoCompleteBox  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.PopulatedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Populated += h);

/*ReactiveEventGenerator*/
public static T RxPopulated<T>(this T control, IObserver<Avalonia.Controls.PopulatedEventArgs> observer) where T : Avalonia.Controls.AutoCompleteBox  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.PopulatedEventArgs>) ((arg0, arg1) => observer.OnNext((arg1))), h => control.Populated += h);


 // DropDownOpening

/*ActionToEventGenerator*/
public static T OnDropDownOpening<T>(this T control, Action<System.ComponentModel.CancelEventArgs> action) where T : Avalonia.Controls.AutoCompleteBox  => 
 control._setEvent((System.EventHandler<System.ComponentModel.CancelEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DropDownOpening += h);

/*ReactiveEventGenerator*/
public static T RxDropDownOpening<T>(this T control, IObserver<System.ComponentModel.CancelEventArgs> observer) where T : Avalonia.Controls.AutoCompleteBox  => 
 control._setEvent((System.EventHandler<System.ComponentModel.CancelEventArgs>) ((arg0, arg1) => observer.OnNext((arg1))), h => control.DropDownOpening += h);


 // DropDownOpened

/*ActionToEventGenerator*/
public static T OnDropDownOpened<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.AutoCompleteBox  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.DropDownOpened += h);

/*ReactiveEventGenerator*/
public static T RxDropDownOpened<T>(this T control, IObserver<System.EventArgs> observer) where T : Avalonia.Controls.AutoCompleteBox  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => observer.OnNext((arg1))), h => control.DropDownOpened += h);


 // DropDownClosing

/*ActionToEventGenerator*/
public static T OnDropDownClosing<T>(this T control, Action<System.ComponentModel.CancelEventArgs> action) where T : Avalonia.Controls.AutoCompleteBox  => 
 control._setEvent((System.EventHandler<System.ComponentModel.CancelEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DropDownClosing += h);

/*ReactiveEventGenerator*/
public static T RxDropDownClosing<T>(this T control, IObserver<System.ComponentModel.CancelEventArgs> observer) where T : Avalonia.Controls.AutoCompleteBox  => 
 control._setEvent((System.EventHandler<System.ComponentModel.CancelEventArgs>) ((arg0, arg1) => observer.OnNext((arg1))), h => control.DropDownClosing += h);


 // DropDownClosed

/*ActionToEventGenerator*/
public static T OnDropDownClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.AutoCompleteBox  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.DropDownClosed += h);

/*ReactiveEventGenerator*/
public static T RxDropDownClosed<T>(this T control, IObserver<System.EventArgs> observer) where T : Avalonia.Controls.AutoCompleteBox  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => observer.OnNext((arg1))), h => control.DropDownClosed += h);


 // SelectionChanged

/*ActionToEventGenerator*/
public static T OnSelectionChanged<T>(this T control, Action<Avalonia.Controls.SelectionChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.AutoCompleteBox 
{
  control.AddHandler(Avalonia.Controls.AutoCompleteBox.SelectionChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.AutoCompleteBox.SelectionChangedEvent.RoutingStrategies);
  return control;
}


/*ReactiveEventGenerator*/
public static T RxSelectionChanged<T>(this T control, IObserver<Avalonia.Controls.SelectionChangedEventArgs> observer, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.AutoCompleteBox 
{
  control.AddHandler(Avalonia.Controls.AutoCompleteBox.SelectionChangedEvent, (_, args) => observer.OnNext(args), routes ?? Avalonia.Controls.AutoCompleteBox.SelectionChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // CaretIndex

/*ValueStyleSetterGenerator*/
public static Style<T> CaretIndex<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.CaretIndexProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CaretIndex<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.CaretIndexProperty, binding);


 // Watermark

/*ValueStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.WatermarkProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.WatermarkProperty, binding);


 // MinimumPrefixLength

/*ValueStyleSetterGenerator*/
public static Style<T> MinimumPrefixLength<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinimumPrefixLength<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty, binding);


 // MinimumPopulateDelay

/*ValueStyleSetterGenerator*/
public static Style<T> MinimumPopulateDelay<T>(this Style<T> style, System.TimeSpan value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinimumPopulateDelay<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty, binding);


 // MaxDropDownHeight

/*ValueStyleSetterGenerator*/
public static Style<T> MaxDropDownHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxDropDownHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty, binding);


 // IsTextCompletionEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsTextCompletionEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTextCompletionEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty, binding);


 // ItemTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> ItemTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty, binding);


 // ClearSelectionOnLostFocus

/*ValueStyleSetterGenerator*/
public static Style<T> ClearSelectionOnLostFocus<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ClearSelectionOnLostFocusProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ClearSelectionOnLostFocus<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ClearSelectionOnLostFocusProperty, binding);


 // IsDropDownOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsDropDownOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDropDownOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty, binding);


 // SelectedItem

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedItem<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.SelectedItemProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedItem<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.SelectedItemProperty, binding);


 // Text

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.TextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.TextProperty, binding);


 // FilterMode

/*ValueStyleSetterGenerator*/
public static Style<T> FilterMode<T>(this Style<T> style, Avalonia.Controls.AutoCompleteFilterMode value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.FilterModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FilterMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.FilterModeProperty, binding);


 // ItemFilter

/*ValueStyleSetterGenerator*/
public static Style<T> ItemFilter<T>(this Style<T> style, Avalonia.Controls.AutoCompleteFilterPredicate<System.Object> value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemFilterProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemFilter<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemFilterProperty, binding);


 // TextFilter

/*ValueStyleSetterGenerator*/
public static Style<T> TextFilter<T>(this Style<T> style, Avalonia.Controls.AutoCompleteFilterPredicate<System.String> value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.TextFilterProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextFilter<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.TextFilterProperty, binding);


 // ItemSelector

/*ValueStyleSetterGenerator*/
public static Style<T> ItemSelector<T>(this Style<T> style, Avalonia.Controls.AutoCompleteSelector<System.Object> value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemSelector<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty, binding);


 // TextSelector

/*ValueStyleSetterGenerator*/
public static Style<T> TextSelector<T>(this Style<T> style, Avalonia.Controls.AutoCompleteSelector<System.String> value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.TextSelectorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextSelector<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.TextSelectorProperty, binding);


 // ItemsSource

/*ValueStyleSetterGenerator*/
public static Style<T> ItemsSource<T>(this Style<T> style, System.Collections.IEnumerable value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemsSourceProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemsSource<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemsSourceProperty, binding);


 // AsyncPopulator

/*ValueStyleSetterGenerator*/
public static Style<T> AsyncPopulator<T>(this Style<T> style, System.Func<System.String,System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>> value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AsyncPopulator<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty, binding);


 // MaxLength

/*ValueStyleSetterGenerator*/
public static Style<T> MaxLength<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MaxLengthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxLength<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MaxLengthProperty, binding);


 // InnerLeftContent

/*ValueStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.InnerLeftContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.InnerLeftContentProperty, binding);


 // InnerRightContent

/*ValueStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.InnerRightContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.InnerRightContentProperty, binding);



}

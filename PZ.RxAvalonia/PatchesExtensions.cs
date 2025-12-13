using Avalonia;
using Avalonia.Controls.Primitives;
using Avalonia.Styling;
using PZ.RxAvalonia.Reactive;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Runtime.InteropServices.JavaScript;

namespace PZ.RxAvalonia;

// patch extensions which generator cannot generate
public static class PatchesExtensions
{
    public static TControl _setEx<TControl, TValue>(this TControl control, AvaloniaProperty<TValue> avap, IObservable<TValue> obs, IObserver<TValue> changed)
    where TControl : AvaloniaObject
    {
        var component = ComponentBuildContext.CurrentComponent ?? throw new InvalidOperationException("Current component is not set! ");
        var state = new RxPropertyState<TControl, TValue>(control, obs, changed, null, avap);
        component.AddRxPropertyState(state);

        return control;
    }

    public static TControl SelectedItemEx<TControl, TValue>(this TControl control, ISubject<TValue> subject) 
            where TControl : SelectingItemsControl
    {
        var objSubject = new ObjectSubject<TValue>(subject);
        return control._set(SelectingItemsControl.SelectedItemProperty!, objSubject);
    }
    public static TControl SelectedItemEx<TControl, TValue>(this TControl control, IObservable<TValue> obs)
        where TControl : SelectingItemsControl
    {
        return control._set(SelectingItemsControl.SelectedItemProperty!, obs.Select(x => x is null ? null : (object)x));
    }

    public static T IsCheckedEx<T>(this T control, ISubject<bool> subject) where T : ToggleButton
    {
        var nbSubject = new NullableSubject<bool>(subject);
        return control._set(avap: ToggleButton.IsCheckedProperty!, subject: nbSubject);
    }
    public static T IsCheckedEx<T>(this T control, IObservable<bool> obs) where T : ToggleButton
    {
        return control._set(avap: ToggleButton.IsCheckedProperty!, obs.Select(x => (bool?)x));
    }

    public static T ValueEx<T>(this T control, ISubject<decimal> subject)
        where T : Avalonia.Controls.NumericUpDown
    {
        var nbSubject = new NullableSubject<decimal>(subject);
        return control._set(Avalonia.Controls.NumericUpDown.ValueProperty!, nbSubject);
    }
    public static T ValueEx<T>(this T control, IObservable<decimal> obs)
        where T : Avalonia.Controls.NumericUpDown
    {
        return control._set(Avalonia.Controls.NumericUpDown.ValueProperty!, obs.Select(x => (decimal?)x));
    }
    public static T ValueEx<T>(this T control, ISubject<int> subject)
        where T : Avalonia.Controls.NumericUpDown
    {
        var nbSubject = new NullableSubject<decimal>(
                subject.Select(x => (decimal)x),
                Observer.Create<decimal>(x => subject.OnNext((int)x))
            );
        return control._set(Avalonia.Controls.NumericUpDown.ValueProperty!, nbSubject);
    }
    public static T ValueEx<T>(this T control, ISubject<double> subject)
        where T : Avalonia.Controls.NumericUpDown
    {
        var nbSubject = new NullableSubject<decimal>(
                subject.Select(x => (decimal)x),
                Observer.Create<decimal>(x => subject.OnNext((double)x))
            );
        return control._set(Avalonia.Controls.NumericUpDown.ValueProperty!, nbSubject);
    }
    public static T ValueEx<T>(this T control, ISubject<float> subject)
        where T : Avalonia.Controls.NumericUpDown
    {
        var nbSubject = new NullableSubject<decimal>(
                subject.Select(x => (decimal)x),
                Observer.Create<decimal>(x => subject.OnNext((float)x))
            );
        return control._set(Avalonia.Controls.NumericUpDown.ValueProperty!, nbSubject);
    }
    public static T ValueEx<T>(this T control, ISubject<long> subject)
        where T : Avalonia.Controls.NumericUpDown
    {
        var nbSubject = new NullableSubject<decimal>(
                subject.Select(x => (decimal)x),
                Observer.Create<decimal>(x => subject.OnNext((long)x))
            );
        return control._set(Avalonia.Controls.NumericUpDown.ValueProperty!, nbSubject);
    }
}

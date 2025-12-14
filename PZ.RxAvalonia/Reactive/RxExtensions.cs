using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace PZ.RxAvalonia.Reactive;

public static class RxExtensions
{
    public static void Reducer<T>(this BehaviorSubject<T> subject, Func<T, T> reducer)
    {
        var newValue = reducer(subject.Value);
        subject.OnNext(newValue);
    }

    public static IObservable<T> WhereNotNull<T>(this IObservable<T?> observable) =>
        observable
        .Where(static x => x is not null)
        .Select(static x => x!);

    public static IObservable<string> WhereNotEmpty(this IObservable<string?> observable, bool includeWhiteSpace) =>
        observable
        .Where(x => includeWhiteSpace ? !string.IsNullOrWhiteSpace(x) : !string.IsNullOrEmpty(x))
        .Select(static x => x!);
}

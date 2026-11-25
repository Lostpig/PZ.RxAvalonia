using System.Reactive.Linq;

namespace PZ.RxAvalonia.Shared.Extension;

public static class ReactiveExtension
{
    public static IObservable<Tuple<T?, T?>> PairWithPrevious<T>(this IObservable<T?> source)
    {
        return source.Scan(
            Tuple.Create(default(T), default(T)),
            (acc, current) => Tuple.Create(acc.Item2, current));
    }
}

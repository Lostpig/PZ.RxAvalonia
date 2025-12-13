using System.Reactive.Subjects;

namespace PZ.RxAvalonia.Reactive;

public static class RxExtensions
{
    public static void Reducer<T>(this BehaviorSubject<T> subject, Func<T, T> reducer)
    {
        var newValue = reducer(subject.Value);
        subject.OnNext(newValue);
    }
}

using System.Reactive.Subjects;

namespace PZ.RxAvalonia.Shared;
public class PreviousSubject<T> : IObservable<(T?, T)>, IObserver<T>
{
    private BehaviorSubject<(T?, T)> _inner;
    public PreviousSubject(T initialValue)
    {
        (T?, T) pair = (default, initialValue);
        _inner = new(pair);
    }

    public void OnCompleted() => _inner.OnCompleted();
    public void OnError(Exception error) => _inner.OnError(error);
    public void OnNext(T value)
    {
        var prev = _inner.Value.Item2;
        _inner.OnNext((prev, value));
    }
    public IDisposable Subscribe(IObserver<(T?, T)> observer)
    {
        return _inner.Subscribe(observer);
    }
}


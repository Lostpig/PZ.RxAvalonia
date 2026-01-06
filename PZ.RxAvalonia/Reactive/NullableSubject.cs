using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace PZ.RxAvalonia.Reactive;


public class NullableSubject<T> : ISubject<T?> where T : struct
{
    public T? DefaultValue { get; set; } = default;
    private readonly IObservable<T> _observable;
    private readonly IObserver<T> _observer;
    public NullableSubject(ISubject<T> originSubject)
    {
        _observable = originSubject;
        _observer = originSubject;
    }
    public NullableSubject(IObservable<T> originObs, IObserver<T> originObv)
    {
        _observable = originObs;
        _observer = originObv;
    }

    public void OnCompleted() => _observer.OnCompleted();
    public void OnError(Exception error) => _observer.OnError(error);
    public void OnNext(T? value)
    {
        if (value.HasValue)
        {
            _observer.OnNext(value.Value);
        }
        else
        {
            var t = DefaultValue ?? default(T);
            _observer.OnNext(t);
        }
    }

    public IDisposable Subscribe(IObserver<T?> observer)
    {
        return _observable.Select(x => (T?)x).Subscribe(observer);
    }
}

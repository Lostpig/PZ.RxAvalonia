using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace PZ.RxAvalonia.Reactive;

public class ObjectSubject<T> : ISubject<object>
{
    private readonly ISubject<T> _subject;
    public ObjectSubject(ISubject<T> originSubject)
    {
        _subject = originSubject;
    }

    public void OnCompleted() => _subject.OnCompleted();
    public void OnError(Exception error) => _subject.OnError(error);
    public void OnNext(object value)
    {
        if (value is not null)
        {
            _subject.OnNext((T)value);
        }
        else
        {
            _subject.OnNext(default!);
        }
    }
    public IDisposable Subscribe(IObserver<object> observer)
    {
        var ov = new System.Reactive.AnonymousObserver<T>((value) =>
        {
            observer.OnNext(value!);
        });
        return _subject.Subscribe(ov);
    }
}

public class NullableSubject<T> : ISubject<T?> where T : struct
{
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
            _observer.OnNext(default!);
        }
    }

    public IDisposable Subscribe(IObserver<T?> observer)
    {
        return _observable.Select(x => (T?)x).Subscribe(observer);
    }
}

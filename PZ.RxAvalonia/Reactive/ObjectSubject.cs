using System.Reactive.Subjects;

namespace PZ.RxAvalonia.Reactive;

public class ObjectSubject<T> : ISubject<object?>
{
    private readonly ISubject<T?> _subject;
    public ObjectSubject(ISubject<T?> originSubject)
    {
        _subject = originSubject;
    }

    public void OnCompleted() => _subject.OnCompleted();
    public void OnError(Exception error) => _subject.OnError(error);
    public void OnNext(object? value)
    {
        if (value is T t) _subject.OnNext(t);
        else _subject.OnNext(default);
    }
    public IDisposable Subscribe(IObserver<object?> observer)
    {
        var ov = new System.Reactive.AnonymousObserver<T?>((value) =>
        {
            observer.OnNext(value);
        });
        return _subject.Subscribe(ov);
    }
}

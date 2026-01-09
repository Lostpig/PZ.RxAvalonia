using System.Collections;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace PZ.RxAvalonia.Reactive;

public enum ChangedType
{
    Add, Remove, Insert, ReplaceAll, Order
}
public record ChangedArgs<T>(ChangedType Type, int Index, int Count);
public class ReactiveList<T> : IList<T>, IObservable<ChangedArgs<T>>
{
    private readonly List<T> _items;
    private readonly Subject<ChangedArgs<T>> _subject;
    public IObservable<IEnumerable<T>> Current { get; init; }

    public ReactiveList()
    {
        _items = [];
        _subject = new();

        Current = _subject.Select<ChangedArgs<T>,IEnumerable<T>>(_ => [.. _items]);
    }

    public T this[int index]
    {
        get
        {
            return _items[index];
        }
        set
        {
            _items[index] = value;
        }
    }
    public int Count => _items.Count;
    public bool IsReadOnly => false;

    public void Add(T item)
    {
        _items.Add(item);
        _subject.OnNext(new(ChangedType.Add, 0, 1));
    }
    public void AddRange(IEnumerable<T> collection)
    {
        _items.AddRange(collection);
        _subject.OnNext(new(ChangedType.Add, 0, collection.Count()));
    }
    public void Insert(int index, T item)
    {
        _items.Insert(index, item);
        _subject.OnNext(new(ChangedType.Insert, index, 1));
    }
    public void InsertRange(int index, IEnumerable<T> collection)
    {
        _items.InsertRange(index, collection);
        _subject.OnNext(new(ChangedType.Insert, index, collection.Count()));
    }

    public bool Remove(T item)
    {
        bool removed = _items.Remove(item);
        if (removed)
        {
            _subject.OnNext(new(ChangedType.Remove, 0, 1));
        }
        return removed;
    }
    public void RemoveAt(int index)
    {
        var item = _items[index];
        _items.RemoveAt(index);
        _subject.OnNext(new(ChangedType.Remove, 0, 1));
    }
    public int RemoveAll(Predicate<T> match)
    {
        var count = _items.RemoveAll(match);
        _subject.OnNext(new(ChangedType.Remove, -1, count));

        return count;
    }
    public void RemoveRange(int index, int count)
    {
        var removed = _items[index..(index + count)];
        _items.RemoveRange(index, count);

        _subject.OnNext(new(ChangedType.Remove, index, count));
    }
    public void Clear()
    {
        RemoveRange(0, _items.Count);
    }
    public void ReplaceAll(IEnumerable<T> collection)
    {
        _items.Clear();
        _items.AddRange(collection);
        _subject.OnNext(new(ChangedType.ReplaceAll, 0, collection.Count()));
    }
    public void Sort(Comparison<T> comparison)
    {
        _items.Sort(comparison);
        _subject.OnNext(new(ChangedType.ReplaceAll, 0, _items.Count));
    }

    public bool Contains(T item) => _items.Contains(item);
    public void CopyTo(T[] array, int arrayIndex) => _items.CopyTo(array, arrayIndex);
    public IEnumerator<T> GetEnumerator() => _items.GetEnumerator();
    public int IndexOf(T item) => _items.IndexOf(item);
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IDisposable IObservable<ChangedArgs<T>>.Subscribe(IObserver<ChangedArgs<T>> observer)
    {
        return _subject.Subscribe(observer);
    }
}

using System.Collections;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace PZ.RxAvalonia.Reactive;


public class ReactiveList<T> : IList<T>
{
    public record InsertArgs(int Index, T Item);

    private readonly List<T> _items;
    private readonly Subject<IEnumerable<T>> _add;
    private readonly Subject<IEnumerable<T>> _remove;
    private readonly Subject<InsertArgs> _insert;
    private readonly Subject<IEnumerable<T>> _change;

    public ReactiveList()
    {
        _items = [];
        _add = new();
        _remove = new();
        _insert = new();
        _change = new();

        WhenAdd = _add.AsObservable();
        WhenRemove = _remove.AsObservable();
        WhenInsert = _insert.AsObservable();

        WhenAdd.Subscribe(_ => _change.OnNext([.. _items]));
        WhenRemove.Subscribe(_ => _change.OnNext([.. _items]));
        WhenInsert.Subscribe(_ => _change.OnNext([.. _items]));
        WhenChanged = _change.AsObservable();
    }

    public IObservable<IEnumerable<T>> WhenAdd { get; init; }
    public IObservable<IEnumerable<T>> WhenRemove { get; init; }
    public IObservable<InsertArgs> WhenInsert { get; init; }
    public IObservable<IEnumerable<T>> WhenChanged { get; init; }

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
        _add.OnNext([item]);
    }
    public void AddRange(IEnumerable<T> collection)
    {
        _items.AddRange(collection);
        _add.OnNext([.. collection]);
    }
    public void Insert(int index, T item)
    {
        _items.Insert(index, item);
        _insert.OnNext(new(index, item));
    }
    public bool Remove(T item)
    {
        bool removed = _items.Remove(item);
        if (removed)
        {
            _remove.OnNext([item]);
        }
        return removed;
    }
    public void RemoveAt(int index)
    {
        var item = _items[index];
        _items.RemoveAt(index);
        _remove.OnNext([item]);
    }
    public int RemoveAll(Predicate<T> match)
    {
        var removed = _items.Where(i => match(i));
        var count = _items.RemoveAll(match);
        _remove.OnNext([.. removed]);

        return count;
    }
    public void RemoveRange(int index, int count)
    {
        var removed = _items[index..(index + count)];
        _items.RemoveRange(index, count);

        _remove.OnNext([.. removed]);
    }
    public void Clear()
    {
        RemoveRange(0, _items.Count);
    }

    public bool Contains(T item) => _items.Contains(item);
    public void CopyTo(T[] array, int arrayIndex) => _items.CopyTo(array, arrayIndex);
    public IEnumerator<T> GetEnumerator() => _items.GetEnumerator();
    public int IndexOf(T item) => _items.IndexOf(item);
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

using PZ.RxAvalonia.DataValidations;
using System.Reactive.Subjects;

namespace PZ.RxAvalonia.Shared.Validtions;

public class ThanValidtion<T> : ValidationBase, IDataValidation<T?> where T : struct, IComparable<T>
{
    public static Func<ThanValidtion<T>, string> GlobalMsgGetter { get; set; } = (_) => "This field invalid.";

    public ThanOperation Operation { get; init; }
    public IObservable<T>? ThanObs { get; init; }
    public T Value { get; private set; }
    public ThanValidtion(ThanOperation opt, T value, IObservable<T>? thanObs = null)
    {
        Value = value;
        Operation = opt;
        ThanObs = thanObs;

        ThanObs?.Subscribe(v => Value = v);
    }
    public ThanValidtion(ThanOperation opt, BehaviorSubject<T> sub) : this(opt, sub.Value, sub) { }

    public string ErrorMessage => _msgGetter is not null ? _msgGetter(this) : GlobalMsgGetter(this);

    public bool IsValid(T? v)
    {
        if (!v.HasValue) return false;

        switch (Operation)
        {
            case ThanOperation.Greater: return v.Value.CompareTo(Value) > 0;
            case ThanOperation.GreaterEqual: return v.Value.CompareTo(Value) >= 0;
            case ThanOperation.Less: return v.Value.CompareTo(Value) < 0;
            case ThanOperation.LessEqual: return v.Value.CompareTo(Value) <= 0;
            default: return false;
        }
    }
}


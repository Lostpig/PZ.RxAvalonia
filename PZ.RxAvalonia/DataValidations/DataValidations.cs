namespace PZ.RxAvalonia.DataValidations;

public interface IDataValidation<T>
{
    bool IsValid(T value);
    string ErrorMessage { get; }
}

public abstract class ValidationBase
{
    protected Func<ValidationBase, string>? _msgGetter;
    public void CustomMessage<T>(Func<T, string> messageGetter) where T : ValidationBase
    {
        _msgGetter = (c) =>
        {
            if (c is T t)
            {
                return messageGetter(t);
            }
            throw new InvalidOperationException();
        };
    }
}

public class RequiredValidation : ValidationBase, IDataValidation<string?>
{
    public static Func<RequiredValidation, string> GlobalMsgGetter { get; set; } = (_) => "This field is required.";

    public bool IsValid(string? value)
    {
        return !string.IsNullOrWhiteSpace(value);
    }
    public string ErrorMessage => _msgGetter is not null ? _msgGetter(this) : GlobalMsgGetter(this);
}
public class MaxLengthValidation(uint maxLength) : ValidationBase, IDataValidation<string?>
{
    public static Func<MaxLengthValidation, string> GlobalMsgGetter { get; set; } = (v) => $"This field must be at most {v.MaxLength} characters long.";

    public uint MaxLength { get; init; } = maxLength;
    public bool IsValid(string? value)
    {
        return (value?.Length ?? 0) <= MaxLength;
    }
    public string ErrorMessage => _msgGetter is not null ? _msgGetter(this) : GlobalMsgGetter(this);
}
public class MinLengthValidation(uint minLength) : ValidationBase, IDataValidation<string?>
{
    public static Func<MinLengthValidation, string> GlobalMsgGetter { get; set; } = (v) => $"This field must be at least {v.MinLength} characters long.";
    public uint MinLength { get; } = minLength;
    public bool IsValid(string? value)
    {
        return (value?.Length ?? 0) >= MinLength;
    }
    public string ErrorMessage => _msgGetter is not null ? _msgGetter(this) : GlobalMsgGetter(this);
}
public class MaxValueValidation<T>(T maxValue) : ValidationBase, IDataValidation<T?> where T : struct, IComparable<T>
{
    public static Func<MaxValueValidation<T>, string> GlobalMsgGetter { get; set; } = (v) => $"This field must be at most {v.MaxValue}.";

    public T MaxValue { get; } = maxValue;
    public bool IsValid(T? value)
    {
        if (!value.HasValue) return false;
        return value.Value.CompareTo(MaxValue) <= 0;
    }
    public string ErrorMessage => _msgGetter is not null ? _msgGetter(this) : GlobalMsgGetter(this);
}
public class MinValueValidation<T>(T minValue) : ValidationBase, IDataValidation<T?> where T : struct, IComparable<T>
{
    public static Func<MinValueValidation<T>, string> GlobalMsgGetter { get; set; } = (v) => $"This field must be at least {v.MinValue}.";

    public T MinValue { get; } = minValue;
    public bool IsValid(T? value)
    {
        if (!value.HasValue) return false;
        return value.Value.CompareTo(MinValue) >= 0;
    }
    public string ErrorMessage => _msgGetter is not null ? _msgGetter(this) : GlobalMsgGetter(this);
}

public static class DataValidations
{
    public static RequiredValidation Required() => new();
    public static MaxLengthValidation MaxLength(uint maxLength) => new(maxLength);
    public static MinLengthValidation MinLength(uint minLength) => new(minLength);
    public static MaxValueValidation<T> MaxValue<T>(T maxValue) where T : struct, IComparable<T> => new(maxValue);
    public static MinValueValidation<T> MinValue<T>(T minValue) where T : struct, IComparable<T> => new(minValue);
}

namespace PZ.RxAvalonia.DataValidations;

public interface IDataValidation<T>
{
    bool IsValid(T value);
    string ErrorMessage { get; set; }
}

public class RequiredValidation : IDataValidation<string?>
{
    public bool IsValid(string? value)
    {
        return !string.IsNullOrWhiteSpace(value);
    }
    public string ErrorMessage { get; set; } = "This field is required.";
}
public class MaxLengthValidation(uint maxLength) : IDataValidation<string?>
{
    public uint MaxLength { get; } = maxLength;
    public bool IsValid(string? value)
    {
        return (value?.Length ?? 0) <= MaxLength;
    }
    public string ErrorMessage { get; set; } = $"This field must be at most {maxLength} characters long.";
}
public class MinLengthValidation(uint minLength) : IDataValidation<string?>
{
    public uint MinLength { get; } = minLength;
    public bool IsValid(string? value)
    {
        return (value?.Length ?? 0) >= MinLength;
    }
    public string ErrorMessage { get; set; } = $"This field must be at least {minLength} characters long.";
}
public class MaxValueValidation<T>(T maxValue) : IDataValidation<T?> where T : struct, IComparable<T>
{
    public T MaxValue { get; } = maxValue;
    public bool IsValid(T? value)
    {
        if (!value.HasValue) return false;
        return value.Value.CompareTo(MaxValue) <= 0;
    }
    public string ErrorMessage { get; set; } = $"This field must be at most {maxValue}.";
}
public class MinValueValidation<T>(T minValue) : IDataValidation<T?> where T : struct, IComparable<T>
{
    public T MinValue { get; } = minValue;
    public bool IsValid(T? value)
    {
        if (!value.HasValue) return false;
        return value.Value.CompareTo(MinValue) >= 0;
    }
    public string ErrorMessage { get; set; } = $"This field must be at least {minValue}.";
}


public static class DataValidations
{
    public static RequiredValidation Required() => new();
    public static MaxLengthValidation MaxLength(uint maxLength) => new(maxLength);
    public static MinLengthValidation MinLength(uint minLength) => new(minLength);
    public static MaxValueValidation<T> MaxValue<T>(T maxValue) where T : struct, IComparable<T> => new(maxValue);
    public static MinValueValidation<T> MinValue<T>(T minValue) where T : struct, IComparable<T> => new(minValue);
}

namespace PZ.RxAvalonia.Shared;

public class ApplicationContext
{
    public static ApplicationContext Current { get; private set; }
    static ApplicationContext()
    {
        Current = new ApplicationContext();
    }

    private readonly Dictionary<Type, object> _instances = new Dictionary<Type, object>();
    public void SetInstance<T>(T instance) where T : class
    {
        _instances[typeof(T)] = instance;
    }
    public T GetInstance<T>() where T : class
    {
        var exists = _instances.TryGetValue(typeof(T), out var instance);
        if (!exists)
        {
            throw new InvalidOperationException($"Instance of type {typeof(T).Name} not found in ApplicationContext.");
        }

        return (instance as T)!;
    }
}

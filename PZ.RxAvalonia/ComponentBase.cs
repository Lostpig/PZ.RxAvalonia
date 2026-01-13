using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using Avalonia.Styling;
using Avalonia.Threading;
using PZ.RxAvalonia.DataValidations;
using PZ.RxAvalonia.Helpers;
using PZ.RxAvalonia.Styles;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Threading;

namespace PZ.RxAvalonia;

/// <summary>
/// Defines when a view should be initialized.
/// </summary>
public enum ViewInitializationStrategy
{
    /// <summary>
    /// View is initialized lazily when first accessed (e.g., when Child property is accessed or when attached to visual tree).
    /// </summary>
    Lazy,

    /// <summary>
    /// View is initialized immediately in the constructor.
    /// </summary>
    Immediate
}

[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties | DynamicallyAccessedMemberTypes.NonPublicFields)]
public abstract class ComponentBase: Decorator, IReloadable, IDeclarativeComponent
{
    internal readonly List<RxPropertyState> _rxPropStates = [];
    internal readonly List<FuncPropertyState> _funcPropStates = [];
    internal readonly List<StyleState> _styleStates = [];
    private readonly List<IDisposable> _subscriptions = [];
    internal List<IDeclarativeComponent> DependentViews { get; set; } = [];
    private INameScope? _nameScope;
    protected INameScope Scope => _nameScope ??= new NameScope();
    public bool IsRegisterDataValidation { get; private set; } = false;

    protected abstract Control Build();
    protected virtual StyleGroup? BuildStyles() => null;

    protected ComponentBase(ViewInitializationStrategy initializationStrategy)
    {
        InjectServices();
        OnCreated();
        if (initializationStrategy == ViewInitializationStrategy.Immediate)
        {
            Initialize();
        }
    }
    protected ComponentBase() : this(ViewInitializationStrategy.Immediate) { }

    private bool TryFindResourceFromContext(object key, ThemeVariant? theme, out object? resource)
    {
        foreach(var context in ComponentBuildContext.ComponentStack)
        {
            if (context.Component.TryFindResource(key, theme, out resource))
            {
                return true;
            }
        }

        resource = null;
        return false;
    }
    protected T StaticResource<T>(object key, Func<object?, T> converter, IResourceHost? anchor = null)
    {
        anchor ??= this;
        var theme = Application.Current!.ActualThemeVariant;
        object? resource;


        if (anchor.TryFindResource(key, theme, out resource))
        {
            if (resource is T t) return t;
            return converter(resource);
        }
        if (ComponentBuildContext.CurrentState == ComponentBuildState.StyleBuilding 
            || ComponentBuildContext.CurrentState == ComponentBuildState.ViewBuilding)
        {
            // when building component not attach to visual tree yet
            // try to find resource in parent component context
            if (TryFindResourceFromContext(key, theme, out resource))
            {
                if (resource is T t) return t;
                return converter(resource);
            }
        }
        if (Application.Current!.TryFindResource(key, theme, out resource) && resource != null)
        {
            if (resource is T t) return t;
            return converter(resource);
        }

        return converter(null);
    }
    protected object? StaticResource(object key, IResourceHost? anchor = null)
    {
        return StaticResource<object?>(key, o => o, anchor);
    }
    protected T? StaticResource<T>(object key, IResourceHost? anchor = null)
    {
        var obj = StaticResource(key, anchor);
        return obj is T t ? t : default;
    }
    protected IBrush StaticColor(object key, IResourceHost? anchor = null)
    {
        return StaticResource(key, ResourceHelpers.BrushConverter, anchor);
    }
    protected IObservable<T> DynamicResource<T>(object key, Func<object?, T> converter, IResourceHost? anchor = null) 
    {
        return ResourceHelpers.DynamicResource<T>(key, anchor ?? this, converter);
    }
    protected IObservable<IBrush> DynamicColor(object key, IResourceHost? anchor = null)
    {
        return DynamicResource<IBrush>(key, ResourceHelpers.BrushConverter, anchor);
    }
    protected ComponentValidation RegisterDataValidation()
    {
        var compValid = ComponentValidation.Register(this);
        IsRegisterDataValidation = true;
        return compValid;
    }
    protected bool CheckDataValidation()
    {
        if (IsRegisterDataValidation) 
        {
            var validation = ComponentValidation.Get(this);
            if (validation != null)
            {
                return validation.IsValid();
            }
        }

        return true;
    }

    public event Action? ViewInitialized;
    private bool _isInitialized = false;
    private bool _isInitializing = false;
    protected void Initialize()
    {
        if (_isInitialized || _isInitializing) return;
        _isInitializing = true;

        try
        {
            NameScope.SetNameScope(this, Scope);

            using (var context = new ComponentBuildContext(this))
            {
                context.SetState(ComponentBuildState.StyleBuilding);
                if (BuildStyles() is { } styleGroup)
                {
                    context.SetState(ComponentBuildState.StyleSelectorUpdating);
                    var viewStyles = StyleBuilder.StylesToRange(styleGroup).ToImmutableList();
                    Styles.AddRange(viewStyles);
                }

                context.SetState(ComponentBuildState.ViewBuilding);
                var content = Build();
                Child = content;

                context.SetState(ComponentBuildState.None);
            }

            _isInitialized = true;
            ViewInitialized?.Invoke();
            OnAfterInitialized();
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            Debug.WriteLine(ex.StackTrace);
            throw new ComponentBuildingException($"Build error in {GetType().Name} : {ex.Message}", ex);
        }
        finally
        {
            _isInitializing = false;
        }
    }
    private void EnsureInitialized()
    {
        if (!_isInitialized && !_isInitializing)
        {
            Initialize();
        }
    }

    protected virtual void OnCreated() { }
    protected virtual void OnAfterInitialized() { }
    protected virtual IEnumerable<IDisposable> WhenActivate() { return []; }
    protected virtual void OnStateUpdated() { }

    private bool _isUpdatingState = false;
    public void UpdateState()
    {
        if (Dispatcher.UIThread.CheckAccess())
        {
            // If on UI thread, proceed directly
            PerformStateUpdate();
        }
        else
        {
            // If not on UI thread, dispatch to UI thread
            Dispatcher.UIThread.Post(PerformStateUpdate, DispatcherPriority.Normal);
        }
    }
    private void PerformStateUpdate()
    {
        if (_isUpdatingState) return;

        _isUpdatingState = true;
        try
        {
            foreach (var dependentView in DependentViews.OfType<ComponentBase>())
                dependentView.UpdateState();

            foreach (var funcPropState in _funcPropStates)
                funcPropState.UpdateValue();

            foreach (var styleState in _styleStates)
                styleState.UpdateValue();

            OnStateUpdated();
        }
        finally
        {
            _isUpdatingState = false;
        }
    }

    internal void AddRxPropertyState(RxPropertyState state)
    {
        ArgumentNullException.ThrowIfNull(state);
        if (!_rxPropStates.Contains(state))
            _rxPropStates.Add(state);
    }
    internal void AddFuncPropertyState<TControl>(FuncPropertyState state, TControl dependentControl)
        where TControl : AvaloniaObject
    {
        ArgumentNullException.ThrowIfNull(state);
        if (!_funcPropStates.Contains(state))
            _funcPropStates.Add(state);

        if (dependentControl is ComponentBase targetView)
            AddDependentView(targetView);
    }
    internal void AddStyleState(StyleState state)
    {
        ArgumentNullException.ThrowIfNull(state);
        if (!_styleStates.Contains(state))
            _styleStates.Add(state);
    }
    protected void AddDependentView(ComponentBase view)
    {
        if (!DependentViews.Contains(view))
            DependentViews.Add(view);
    }

    protected override void OnLoaded(RoutedEventArgs e)
    {
        base.OnLoaded(e);
        foreach (var s in _rxPropStates) s.Activate();
        foreach (var s in _styleStates) s.Activate();
        _subscriptions.AddRange(WhenActivate());

        if (IsRegisterDataValidation)
        {
            ComponentValidation.Get(this)?.ActivateAll();
        }
    }
    protected override void OnUnloaded(RoutedEventArgs e)
    {
        base.OnUnloaded(e);
        foreach (var s in _rxPropStates) s.DeActivate();
        foreach (var s in _styleStates) s.DeActivate();
        foreach (var s in _subscriptions) s.Dispose();

        if (IsRegisterDataValidation)
        {
            ComponentValidation.Get(this)?.DeactivateAll();
        }
    }

    [RequiresUnreferencedCode("Method InjectServices is using reflection to iterate through Type hierarchy. That's can not be analyzed statically.")]
    private void InjectServices()
    {
        var componentType = GetType();
        var types = new List<Type>();

        // Walk up the inheritance chain, but stop at object
        for (var type = componentType; type != null && type != typeof(object); type = type.BaseType)
        {
            types.Add(type);
        }

        // Go from base to derived so base properties are injected first
        types.Reverse();

        foreach (var type in types)
        {
            var injectProps = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                .Where(x => x.GetCustomAttribute(typeof(InjectAttribute)) != null)
                .ToArray();

            foreach (var propertyInfo in injectProps)
            {
                var service = GetServiceFromProvider(propertyInfo.PropertyType);

                if (propertyInfo.CanWrite)
                {
                    propertyInfo.SetValue(this, service);
                }
                else
                {
                    if (type.GetField($"<{propertyInfo.Name}>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance) is { } backingField)
                        backingField.SetValue(this, service);
                    else
                        throw new InvalidOperationException($"Can't inject {service?.GetType()} service. Ensure that target property: {type.Name}.{propertyInfo.Name} has public setter or it's an auto-property");
                }
            }
        }
    }

    private static object? GetServiceFromProvider(Type serviceType)
    {
        if (AppBuilderExtensions.ServiceProvider == null)
            throw new InvalidOperationException("Please set Service Provider by calling UseServiceProvider on AppBuilder");

        return AppBuilderExtensions.ServiceProvider.GetService(serviceType);
    }

    #region Hot reload stuff
    private void ClearPropStates()
    {
        foreach (var r in _rxPropStates) r.DeActivate();
        foreach (var s in _styleStates) s.DeActivate();
        foreach (var s in _subscriptions) s.Dispose();

        _rxPropStates.Clear();
        _funcPropStates.Clear();
        _styleStates.Clear();
        _subscriptions.Clear();
    }

    public void Reload()
    {
        Dispatcher.UIThread.InvokeAsync(() =>
        {
            ClearPropStates();
            OnBeforeReload();
            SetValue(ChildProperty, null);
            VisualChildren.Clear();
            _nameScope = null;
            _isInitialized = false;
            _isInitializing = false;

            var oldDataContext = DataContext;
            DataContext = null; // guarantee that OnDataContextChanged is called

            Initialize();
            DataContext = oldDataContext; // set DataContext back
            _subscriptions.AddRange(WhenActivate());

            InvalidateArrange();
            InvalidateMeasure();
            InvalidateVisual();
        });
    }
    protected virtual void OnBeforeReload()
    {
    }

    protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnAttachedToVisualTree(e);
        HotReloadManager.RegisterInstance(this);
        EnsureInitialized();
    }


    protected override void OnDetachedFromVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnDetachedFromVisualTree(e);
        HotReloadManager.UnregisterInstance(this);
    }
    #endregion
}

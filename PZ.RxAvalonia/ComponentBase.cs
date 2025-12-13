using Avalonia;
using Avalonia.Controls;
using Avalonia.Styling;
using Avalonia.Threading;
using System.Collections.Immutable;
using System.Diagnostics;

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

public abstract class ComponentBase: Decorator, IReloadable, IDeclarativeComponent
{
    internal readonly List<RxPropertyState> _rxPropStates = [];
    internal readonly List<FuncPropertyState> _funcPropStates = [];
    internal List<IDeclarativeComponent> DependentViews { get; set; } = [];
    private INameScope? _nameScope;
    protected INameScope Scope => _nameScope ??= new NameScope();

    protected abstract Control Build();
    protected virtual StyleGroup? BuildStyles() => null;

    protected ComponentBase(ViewInitializationStrategy initializationStrategy)
    {
        OnCreated();
        if (initializationStrategy == ViewInitializationStrategy.Immediate)
        {
            Initialize();
        }
    }
    protected ComponentBase() : this(ViewInitializationStrategy.Immediate) { }

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
    internal void AddFuncPropertyState(FuncPropertyState state)
    {
        ArgumentNullException.ThrowIfNull(state);
        if (!_funcPropStates.Contains(state))
            _funcPropStates.Add(state);
    }

    #region Hot reload stuff
    public void Reload()
    {
        Dispatcher.UIThread.InvokeAsync(() =>
        {
            _rxPropStates.Clear();
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

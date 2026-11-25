using System.Reactive.Subjects;
using MIcon = Material.Icons.MaterialIconKind;

namespace PZ.RxAvalonia.Shared;

internal class EmptyPageType { }
public class NavItem(string key, Func<string> pageNameGetter, MIcon icon, Type pageType)
{
    public bool IsSeparator { get; init; } = key == "Separator";
    public string Key { get; init; } = key;
    private readonly Func<string> _getter = pageNameGetter;
    public MIcon Icon { get; init; } = icon;
    public Type PageType { get; init; } = pageType;
    public string PageName => _getter();
    public BehaviorSubject<string> Status { get; init; } = new("");

    public static NavItem Separator { get; } = new("Separator", () => "", MIcon.Block, typeof(EmptyPageType));
}

public class PageRouter
{
    private readonly NavItem[] Pages;
    public readonly BehaviorSubject<NavItem> CurrentPage;

    public PageRouter(IEnumerable<NavItem> pages)
    {
        Pages = [.. pages];
        CurrentPage = new(Pages[0]);
    }

    public NavItem? GetNavItem(string pageName)
    {
        return Pages.FirstOrDefault(p => p.Key == pageName);
    }
    public void RouteTo(NavItem record)
    {
        CurrentPage.OnNext(record);
    }
    public void RouteTo(string pageName)
    {
        var p = GetNavItem(pageName);
        if (p != null)
        {
            RouteTo(p);
        }
    }
}


using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Styling;
namespace PZ.RxAvalonia.Demo;

internal class Resources
{
    public static void AddAppResources(Application app)
    {
        app.Resources.Add("PrimaryColor", new SolidColorBrush(Color.FromArgb(255, 64, 64, 255)));
        app.Resources.Add("SecondryColor", new SolidColorBrush(Color.FromArgb(255, 64, 255, 64)));
        app.Resources.Add("DangerColor", new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)));

        var lightDict = new ResourceDictionary
        {
            { "CardBackground", new SolidColorBrush(Color.FromArgb(255, 255, 33, 33)) }
        };
        var darkDict = new ResourceDictionary
        {
            { "CardBackground", new SolidColorBrush(Color.FromArgb(255, 33, 255, 33)) }
        };

        app.Resources.ThemeDictionaries.Add(ThemeVariant.Light, lightDict);
        app.Resources.ThemeDictionaries.Add(ThemeVariant.Dark, darkDict);
    }
}

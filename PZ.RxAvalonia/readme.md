# PZ.RxAvlonia
*PZ.RxAvlonia* is a project modified from *Avalonia.Markup.Declarative* ( https://github.com/AvaloniaUI/Avalonia.Markup.Declarative ).

Write Avalonia UI with C#

*Avalonia.Markup.Declarative* is the set of base classes and extension methods over Avalonia's controls to define views/markup with C# code instead of XAML.

*PZ.RxAvlonia* uses Rx.Net( https://github.com/dotnet/reactive ) to implement reactive components.

## Installation

Add the `PZ.RxAvlonia` NuGet package to your project

## MVU Pattern implementation

Inspired by Blazor's Components layout. A basic component should look like this:

```C#
public class Component : ComponentBase
{

//styles
    protected override StyleGroup? BuildStyles() =>
    [
        new Style<Button>()
            .Margin(6)
            .Background(Brushes.DarkSalmon),
    ];

//markup part
    protected override object Build() =>
        new StackPanel()
            .Children(
                new TextBlock()
                    .Text(() => Title),
                new TextBlock()
                    .Text(Counter.Select(i => i.ToString())),
                new Button()
                    .Content("Click me")
                    .OnClick(OnButtonClick)
            );
            
//code part

    public string Title { get; set; } = "Hello world";
    public BehaviorSubject<int> Counter { get; init; } = new(1);

    private void OnButtonClick(RoutedEventArgs e)
    {
        Counter.OnNext(Counter.Value + 1);

        Title = "Changed!";
        UpdateState();  // Func property need call `UpdateState` method to update control property 
    }
}
```


## Hot reload support

- ViewBase classes auto-magically supports .NET 6.0+'s `Hot Reload` feature.

- Make sure that your view classes are located in the Assembly that doesn't contain any XAML files, otherwise `Hot Reload` will always throw "need to rebuild" message.

- 2023 note - according to the latest reports, with .net 7.0 and latest avalonia versions there are no conflicts anymore between AXAML files and the `Hot Reload` functionality. So you can mix AXAML with C# Markup in the same project.

- JetBrains Rider has an issue with default .net hot reload behavior while debugging, so you can use following workaround:
  ```C#
  //init app
  AppBuilder.Configure<Application>()
    .UseRiderHotReload() //this line adds watcher that checks, if Views were changed during debugging session
    .SetupWithLifetime(lifetime);
  ```

## External libraries support

By default *Avalonia.Markup.Declarative* contains only extension from Avalonia Framework controls and also has source generator, that adds Extensions from sources of your project. 
But sometimes you need to use third-party controls from Nuget Packages. For that cases you need to use AvaloniaExtensionGenerator tool ( https://www.nuget.org/packages/AvaloniaExtensionGenerator/ ).

## Installation
```
dotnet tool install --global PZ.AvaloniaExtensionGenerator
```

## Usage

tool should be run from the folder where **.csproj** file is located 
```
cd c:\your\project\
```

call the command
```
pz-avalonia-amd-gen
```

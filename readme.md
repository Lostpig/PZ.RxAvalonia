# PZ.Common
Common solution for PZ projects

### PZ.RxAvaloniaGenerator
Avalonia extension generator for PZ.RxAvalonia

### PZ.LanauageJsonCreator
Create localization json file by language.json
```json
{
  "languages": [
    {
      "value": "zh-CN",
      "name": "中文"
    },
    {
      "value": "en",
      "name": "English"
    }
  ],
  "default": "zh-CN",
  "fields": [
    "Name",
    "Version",
    "Title"
  ]
}
```

### PZ.LocalizationGenerator
PZ.Localization class generator
Read language.json file to generator

### PZ.RxAvalonia
Modified from *Avalonia.Markup.Declarative* ( https://github.com/AvaloniaUI/Avalonia.Markup.Declarative ).
Write Avalonia UI with C#
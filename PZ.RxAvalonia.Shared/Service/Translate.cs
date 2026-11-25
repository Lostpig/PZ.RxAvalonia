using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PZ.RxAvalonia.Shared.Service;

public record LanguageItem(string Name, string Value)
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = Name;

    [JsonPropertyName("value")]
    public string Value { get; set; } = Value;
}
public record LocalizationNameSpace
{
    [JsonPropertyName("namespace")]
    public string NameSpace { get; set; } = string.Empty;

    [JsonPropertyName("fields")]
    public List<string> Fields { get; set; } = [];
}
public record LanguageJson
{
    [JsonPropertyName("languages")]
    public List<LanguageItem> Languages { get; set; } = [];

    [JsonPropertyName("namespaces")]
    public List<LocalizationNameSpace> Namespaces { get; set; } = [];

    [JsonPropertyName("default")]
    public string DefaultLanguage { get; set; } = string.Empty;
}

public record FieldsJson
{
    [JsonPropertyName("namespaces")]
    public List<FieldsJsonNameSpace> Namespaces { get; set; } = [];
}
public record FieldsJsonNameSpace
{
    [JsonPropertyName("namespace")]
    public string NameSpace { get; set; } = string.Empty;
    [JsonPropertyName("fields")]
    public Dictionary<string, string> Fields { get; set; } = [];
}
public interface ILanguageUpdater
{
    void Update(FieldsJson langFields);
}

public class TranslateService
{
    private readonly List<LanguageItem> _languages = [];
    public IReadOnlyList<LanguageItem> Languages => _languages;
    public string Default { get; private set; } = "zh-CN";
    public LanguageItem? Current { get; private set; }
    private readonly BroadcastService _broadcast;
    private readonly ExceptionService _exception;
    private readonly ILanguageUpdater _updater;
    private static readonly Dictionary<string, string> BaseFields = [];

    public TranslateService(ILanguageUpdater updater, ExceptionService exceptionService, BroadcastService broadcastService)
    {
        _updater = updater;
        _broadcast = broadcastService;
        _exception = exceptionService;

        try
        {
            string rootPath = AppDomain.CurrentDomain.BaseDirectory;
            string langFilePath = Path.Join(rootPath, "Localization", "languages.json");

            var langText = File.ReadAllText(langFilePath);
            var langJson = JsonSerializer.Deserialize<LanguageJson>(langText) ?? throw new Exception("languages.json deserialize failed");
            _languages.Clear();
            _languages.AddRange(langJson.Languages);

            Default = langJson.DefaultLanguage;
        }
        catch (Exception ex)
        {
            _exception.CatchException(ex);
        }
    }

    public void ChangeLanguage(string lang)
    {
        if (Current?.Value == lang) return;
        var langItem = _languages.FirstOrDefault(x => x.Value == lang);

        if (langItem != null)
        {
            Current = langItem;
            LoadLanguage(langItem);
            _broadcast.Publish(BroadcastEvent.LanguageChanged);
        }
        else
        {
            _exception.CatchException(new Exception($"Language {lang} not found!"));
        }
    }
    private void LoadLanguage(LanguageItem lang)
    {
        string rootPath = AppDomain.CurrentDomain.BaseDirectory;
        string langPath = Path.Join(rootPath, "Localization", $"{lang.Value}.json");

        string langJson = File.ReadAllText(langPath, Encoding.UTF8);
        FieldsJson? langFields = JsonSerializer.Deserialize<FieldsJson>(langJson);
        if (langFields != null)
        {
            BaseFields.Clear();
            if (langFields.Namespaces.FirstOrDefault(ns => ns.NameSpace == "Base") is FieldsJsonNameSpace fns)
            {
                foreach (var k in fns.Fields) BaseFields.Add(k.Key, k.Value);
            }
            _updater.Update(langFields);
        }
        else
        {
            _updater.Update(new());
            throw new Exception("Language file load error: language map is null");
        }
    }

    public static string GetBaseField(string key)
    {
        return BaseFields.TryGetValue(key, out string? value1) ? value1 : key;
    }
}

using System.Text.Json.Serialization;

namespace LanguageGenerator
{
    internal record LanguageItem(string Name, string Value)
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = Name;

        [JsonPropertyName("value")]
        public string Value { get; set; } = Value;
    }
    internal record LocalizationNameSpace
    {
        [JsonPropertyName("namespace")]
        public string NameSpace { get; set; } = string.Empty;

        [JsonPropertyName("fields")]
        public List<string> Fields { get; set; } = [];
    }
    internal record LanguageJson
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
}

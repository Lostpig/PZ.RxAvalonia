// See https://aka.ms/new-console-template for more information

using LanguageGenerator;
using System.Text;
using System.Text.Json;
using System.Text.Unicode;

string? languageFile = null;

foreach (var arg in args)
{
    if (arg.StartsWith("--languageFile="))
    {
        languageFile = arg.Substring("--languageFile=".Length);
    }
}

if (languageFile == null)
{
    languageFile = Path.Join(AppDomain.CurrentDomain.BaseDirectory, "languages.json");
}

FileInfo language = new(languageFile);
if (!language.Exists)
{
    Console.WriteLine("Language file not found!");
    goto end;
}

string dirPath = Path.GetDirectoryName(languageFile)!;
JsonSerializerOptions options = new()
{
    WriteIndented = true,
    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(UnicodeRanges.All)
};

try
{
    var langText = File.ReadAllText(languageFile);
    var langJson = JsonSerializer.Deserialize<LanguageJson>(langText) ?? throw new Exception("Language file deserialize failed");

    foreach (var lang in langJson.Languages)
    {
        GeneratorLanguage(lang, langJson.Namespaces);

        Console.WriteLine($"Language {lang.Name} generated.");
    }

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine($"Generate complete!");
    Console.ForegroundColor = ConsoleColor.Gray;
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}\n{ex.StackTrace}");
}

end:
Console.WriteLine("Press any key to exit...");
Console.ReadKey();


void GeneratorLanguage(LanguageItem item, List<LocalizationNameSpace> nss)
{
    var path = Path.Join(dirPath, $"{item.Value}.json");

    FieldsJson? oldJson = null;
    if (File.Exists(path))
    {
        string langJson = File.ReadAllText(path, Encoding.UTF8);
        oldJson = JsonSerializer.Deserialize<FieldsJson>(langJson);
    }

    FieldsJson fjson = new();
    foreach (var ns in nss)
    {
        var fns = new FieldsJsonNameSpace
        {
            NameSpace = ns.NameSpace
        };
        var oldDict = oldJson?.Namespaces.FirstOrDefault(n => n.NameSpace == ns.NameSpace)?.Fields;
        foreach (var k in ns.Fields)
        {
            string? v = null;
            oldDict?.TryGetValue(k, out v);
            fns.Fields.Add(k, v ?? $"_MISS_{k}");
        }

        fjson.Namespaces.Add(fns);
    }

    string json = JsonSerializer.Serialize(fjson, options);
    File.WriteAllText(path, json, Encoding.UTF8);
}
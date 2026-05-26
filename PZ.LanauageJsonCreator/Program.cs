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
        GeneratorItem(lang, langJson.Fields);

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


void GeneratorItem(LanguageItem item, List<string> fields)
{
    var path = Path.Join(dirPath, $"{item.Value}.json");

    Dictionary<string, string>? oldDict = null;
    if (File.Exists(path))
    {
        string langJson = File.ReadAllText(path, Encoding.UTF8);
        oldDict = JsonSerializer.Deserialize<Dictionary<string, string>>(langJson);
    }

    oldDict ??= [];

    Dictionary<string, string> dest = [];
    foreach (var field in fields)
    {
        if (!oldDict.TryGetValue(field, out string? value))
        {
            dest.Add(field, $"_MISSING_{field}");
        }
        else
        {
            dest.Add(field, value);
        }
    }

    string json = JsonSerializer.Serialize(dest, options);
    File.WriteAllText(path, json, Encoding.UTF8);
}
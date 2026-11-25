using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using PZ.LocalizationGenerator.Helpers;
using System.Text;

namespace PZ.LocalizationGenerator;

[Generator(LanguageNames.CSharp)]
public class LocalizationGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        // Debugger.Launch();
        IncrementalValuesProvider<AdditionalText> textFiles = context.AdditionalTextsProvider.Where(static file => file.Path.EndsWith("languages.json"));

        context.RegisterSourceOutput(textFiles, (spc, tfs) =>
        {
            if (Path.GetFileNameWithoutExtension(tfs.Path) != "languages") return;

            var jsonText = (tfs.GetText()?.ToString()) ?? throw new Exception("cannot read languages.json file.");
            var languagesJson = Helpers.LocalizationHelper.DeserializeLanguage(jsonText);
            if (languagesJson == null)
            {
                throw new ArgumentException("Language json cannot load!");
            }

            var sourceText = GetLocalizeDictSource(languagesJson);
            spc.AddSource("LocalizeDict.g.cs", sourceText);
        });
    }

    private static SourceText GetLocalizeDictSource(LanguageJson languagesJson)
    {
        var sourceText = SyntaxFactory
            .NamespaceDeclaration(SyntaxFactory.ParseName("PZ.Localization"))
            .AddUsings(
                SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Collections.Generic")),
                SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Diagnostics")),
                SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("PZ.RxAvalonia.Shared.Service"))
            )
            .AddMembers(CreateLocalizationNS(languagesJson.NSList))
            .AddMembers(CreateUpdaterClass(languagesJson.NSList))
            .NormalizeWhitespace()
            .GetText(Encoding.UTF8);

        return sourceText;
    }

    private static MemberDeclarationSyntax[] CreateLocalizationNS(List<LocalizationNameSpace> locNs)
    {
        return locNs
            .Select(item => SyntaxFactory.ClassDeclaration(item.NameSpace)
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.StaticKeyword))
                .AddMembers(CreateFieldProterties(item.Fields))
            ).ToArray();
    }
    private static MemberDeclarationSyntax[] CreateFieldProterties(List<string> fields)
    {
        return fields.Select(field =>
            SyntaxFactory.PropertyDeclaration(SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.StringKeyword)), field)
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.StaticKeyword))
                .WithAccessorList(
                    SyntaxFactory.AccessorList(
                        SyntaxFactory.List(
                            [
                                SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                                    .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
                                SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                                    .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))
                            ]
                        )
                    )
                )
        ).ToArray();
    }

    private static MemberDeclarationSyntax CreateUpdaterClass(List<LocalizationNameSpace> locNs)
    {
        return SyntaxFactory.ClassDeclaration("Updater")
                .AddBaseListTypes(SyntaxFactory.SimpleBaseType(SyntaxFactory.ParseTypeName("ILanguageUpdater")))
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                .AddMembers(locNs.Select(CreateUpdateMethod).ToArray())
                .AddMembers(CreateCommonUpdateMethod(locNs));
    }
    private static MemberDeclarationSyntax CreateUpdateMethod(LocalizationNameSpace item)
    {
        var fieldsCode = item.Fields.Select(f => $"{item.NameSpace}.{f} = getText(\"{f}\");");

        var code = $@"
            public void Update{item.NameSpace}(Dictionary<string, string>? dict)
            {{
                {string.Join("\r\n", fieldsCode)}
                
                string getText(string key)
                {{
                    if (dict != null && dict.ContainsKey(key))
                    {{
                        return dict[key];
                    }}
                    return key;
                }}
            }}
        ";

        return SyntaxFactory.ParseMemberDeclaration(code)!;
    }
    private static MemberDeclarationSyntax CreateCommonUpdateMethod(List<LocalizationNameSpace> items)
    {
        var itemsCode = items.Select(i => $@"Update{i.NameSpace}(langFields.Namespaces.FirstOrDefault(ns => ns.NameSpace == ""{i.NameSpace}"")?.Fields);");

        var code = $@"
            public void Update(FieldsJson langFields)
            {{
                {string.Join("\r\n", itemsCode)}
            }}
        ";

        return SyntaxFactory.ParseMemberDeclaration(code)!;
    }
}

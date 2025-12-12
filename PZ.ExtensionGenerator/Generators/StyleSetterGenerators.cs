using PZ.ExtensionGenerator.ExtensionInfos;

namespace PZ.ExtensionGenerator.Generators;

public class BindingStyleSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info)
    {
        if (info.ValueType.Name == "IBinding")
            return $"//Skipped {info.ExtensionName} because already exist in value setters";

        //direct type access
        var extensionText =
            $"public static Style<{info.ReturnType}> {info.ExtensionName}{info.GenericArg}(this Style<{info.ReturnType}> style, IBinding binding) {info.GenericConstraint} {Environment.NewLine}"
            + $"=> style._addSetter({info.ControlTypeName}.{info.MemberName}Property, binding);";

        return extensionText;
    }
}

public class ValueOverloadsStyleSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info)
    {
        var extensionText = "";
        // overloads for primitive types like margin
        if (!info.ValueType.Module.ScopeName.StartsWith("System")
            && info.ValueType.IsValueType
            && info.ValueType.GetConstructors().Length > 1)
        {
            foreach (var constructor in info.ValueType.GetConstructors())
            {
                var ps = constructor.GetParameters();
                var argDefs = string.Join(", ", ps.Select(x => $"{x.ParameterType.FullName} {x.Name}"));
                var argVals = string.Join(", ", ps.Select(x => x.Name)); ;

                extensionText += $"public static Style<{info.ReturnType}> {info.ExtensionName}{info.GenericArg}(this Style<{info.ReturnType}> style, {argDefs}) {info.GenericConstraint} {Environment.NewLine}" +
                                 $"   => style._addSetter({info.ControlTypeName}.{info.MemberName}Property, new {info.ValueTypeSource}({argVals}));";
            }
        }
        return extensionText;
    }
}

public class ValueStyleSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info)
    {
        //    public static Style<TElement> Background<TElement>(this Style<TElement> style, Brush brush) where TElement : TemplatedControl =>
        //        AddSetter(style, new Setter(TemplatedControl.BackgroundProperty, brush));

        //direct type access
        var extensionText =
            $"public static Style<{info.ReturnType}> {info.ExtensionName}{info.GenericArg}(this Style<{info.ReturnType}> style, {info.ValueTypeSource} value) {info.GenericConstraint} {Environment.NewLine}"
            + $"=> style._addSetter({info.ControlTypeName}.{info.MemberName}Property!, value!);";

        return extensionText;
    }
}
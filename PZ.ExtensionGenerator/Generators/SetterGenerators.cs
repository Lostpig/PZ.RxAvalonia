using PZ.ExtensionGenerator.ExtensionInfos;

namespace PZ.ExtensionGenerator.Generators;

public class SetterFromFuncGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info) =>
        $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, Func<{info.ValueTypeSource}> func) {info.GenericConstraint} {Environment.NewLine}" +
        $"   => control._set({info.ControlTypeName}.{info.FieldInfo.Name}!, func);";
}
public class SetterFromObservableGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info) =>
        $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, IObservable<{info.ValueTypeSource}> obs) {info.GenericConstraint} {Environment.NewLine}" +
        $"   => control._set({info.ControlTypeName}.{info.FieldInfo.Name}!, obs);";
}
public class SetterFromSubjectGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info) =>
        $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, ISubject<{info.ValueTypeSource}> subject) {info.GenericConstraint} {Environment.NewLine}" +
        $"   => control._set({info.ControlTypeName}.{info.FieldInfo.Name}!, subject);";
}
public class SetterFromTwoWayGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info) =>
        $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, IObservable<{info.ValueTypeSource}> obs, IObserver<{info.ValueTypeSource}> changed) {info.GenericConstraint} {Environment.NewLine}" +
        $"   => control._setEx({info.ControlTypeName}.{info.FieldInfo.Name}!, obs, changed);";
}

public class ValueOverloadsSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string GetExtension(PropertyExtensionInfo info)
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
                var argDefs = string.Join(", ", ps.Select(x => $"{x.ParameterType.FullName} {x.Name} = default!"));
                var argVals = string.Join(", ", ps.Select(x => x.Name)); ;

                extensionText += Environment.NewLine +
                                 $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, {argDefs}) {info.GenericConstraint} {Environment.NewLine}" +
                                 $"{{{Environment.NewLine}" +
                                 $"    control.{info.MemberName} = new {info.ValueTypeSource}({argVals});{Environment.NewLine}" +
                                 $"    return control;{Environment.NewLine}" +
                                 $"}}";
            }
        }
        return extensionText;
    }
}

public class ValueSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info) =>
        $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, {info.ValueTypeSource} value) {info.GenericConstraint} {Environment.NewLine}" +
        $"{{{Environment.NewLine}" +
        $"    control.{info.MemberName} = value!;{Environment.NewLine}" +
        $"    return control;{Environment.NewLine}" +
        $"}}";
}
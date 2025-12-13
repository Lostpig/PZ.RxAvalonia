using PZ.ExtensionGenerator.ExtensionInfos;

namespace PZ.ExtensionGenerator.Generators;

public class AttachedPropertyFuncGenerator : ExtensionGeneratorBase<AttachedPropertyExtensionInfo>
{
    protected override string? GetExtension(AttachedPropertyExtensionInfo info)
    {
        return 
            $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, Func<{info.ValueTypeSource}> getter)" +
            $" where T : {info.AttachedPropertyHostTypeName} {Environment.NewLine}" +
            $"   => control._set({info.ControlTypeName}.{info.FieldInfo.Name}!, getter);";
    }
}
public class AttachedPropertyObservableGenerator : ExtensionGeneratorBase<AttachedPropertyExtensionInfo>
{
    protected override string? GetExtension(AttachedPropertyExtensionInfo info)
    {
        return
            $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, IObservable<{info.ValueTypeSource}> obs)" +
            $" where T : {info.AttachedPropertyHostTypeName} {Environment.NewLine}" +
            $"   => control._set({info.ControlTypeName}.{info.FieldInfo.Name}!, obs);";
    }
}
public class AttachedPropertyTwoWayGenerator : ExtensionGeneratorBase<AttachedPropertyExtensionInfo>
{
    protected override string? GetExtension(AttachedPropertyExtensionInfo info)
    {
        return
            $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, IObservable<{info.ValueTypeSource}> obs, IObserver<{info.ValueTypeSource}> changed)" +
            $" where T : {info.AttachedPropertyHostTypeName} {Environment.NewLine}" +
            $"   => control._setEx({info.ControlTypeName}.{info.FieldInfo.Name}!, obs, changed);";
    }
}
public class AttachedPropertySubjectGenerator : ExtensionGeneratorBase<AttachedPropertyExtensionInfo>
{
    protected override string? GetExtension(AttachedPropertyExtensionInfo info)
    {
        return
            $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, ISubject<{info.ValueTypeSource}> subject)" +
            $" where T : {info.AttachedPropertyHostTypeName} {Environment.NewLine}" +
            $"   => control._set({info.ControlTypeName}.{info.FieldInfo.Name}!, subject);";
    }
}
public class AttachedPropertyValueGenerator : ExtensionGeneratorBase<AttachedPropertyExtensionInfo>
{
    protected override string? GetExtension(AttachedPropertyExtensionInfo info)
    {
        return
            $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, {info.ValueTypeSource} value)" +
            $" where T : {info.AttachedPropertyHostTypeName} {Environment.NewLine}" +
            $"{{{Environment.NewLine}" +
            $"    control.SetValue({info.ControlTypeName}.{info.FieldInfo.Name}!, value);{Environment.NewLine}" +
            $"    return control;{Environment.NewLine}" +
            $"}}";
    }
}

using System.Diagnostics;
using System.Reflection;

namespace PZ.ExtensionGenerator.ExtensionInfos;

public class PropertyExtensionInfo : IMemberExtensionInfo
{
    public FieldInfo FieldInfo { get; }
    public Type ControlType { get; }
    public string ControlTypeName { get; }
    public string ExtensionName { get; protected set; }
    public string MemberName { get; }
    public Type ValueType { get; }
    public string ValueTypeSource { get; }
    public bool IsGeneric { get; }
    public bool IsAttachedProperty { get; set; }
    public string ReturnType { get; set; }
    public string GenericConstraint { get; set; } = "";
    public string GenericArg { get; set; } = "";

    private bool FindNullableAttribute()
    {
        if (ValueType.IsGenericType) return false;

        foreach (var attr in FieldInfo.CustomAttributes)
        {
            if (attr.AttributeType.FullName == "System.Runtime.CompilerServices.NullableAttribute")
            {
                var param = attr.ConstructorArguments.FirstOrDefault();
                if (param.ArgumentType.Name != "Byte[]") return false;

                var strs = param.ToString();
                // Console.WriteLine($"=====================[{strs}]");
                var digits = strs[13..^1].Split(',');
                if (digits.Length > 0)
                {
                    var n = int.Parse(digits.Last());
                    return n == 2;
                }
            }
        }
        return false;
    }

    public PropertyExtensionInfo(FieldInfo field)
    {
        FieldInfo = field;
        ControlType = field.DeclaringType ?? throw new NullReferenceException("Control type can not be NULL");
        ExtensionName = field.Name.Replace("Property", "");
        MemberName = field.Name.Replace("Property", "");
        ValueType = field.FieldType.GetGenericArguments().Last();
        ControlTypeName = ControlType.GetTypeDeclarationSourceCode();

        if (FindNullableAttribute())
        {
            // is nullable reference type
            ValueTypeSource = ValueType.GetTypeDeclarationSourceCode() + "?";

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Field: {field.Name} is nullable reference!");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        else
        {
            ValueTypeSource = ValueType.GetTypeDeclarationSourceCode();
        }


        IsAttachedProperty = field.FieldType.Name.StartsWith("AttachedProperty");
        IsGeneric = !field.DeclaringType.IsSealed;

        ReturnType = ControlTypeName;
        if (IsGeneric)
        {
            ReturnType = "T";
            GenericConstraint = $"where T : {ControlTypeName}";
            GenericArg = "<T>";
        }
    }

    public static IMemberExtensionInfo Create(FieldInfo fieldInfo)
    {
        return new PropertyExtensionInfo(fieldInfo);
    }
}
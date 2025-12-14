using PZ.ExtensionGenerator.ExtensionInfos;

namespace PZ.ExtensionGenerator.Generators;

public class ActionToEventGenerator : ExtensionGeneratorBase<EventExtensionInfo>
{
    protected override string? GetExtension(EventExtensionInfo @event)
    {
        var eventHandler = @event.EventHandler;
        var eventParameterTypes = @event.EventParameterTypes;
        var argsString = $"Action<{string.Join(", ", eventParameterTypes)}> action";

        // Generate the lambda parameter names (arg0, arg1, etc.)
        var lambdaParameters = string.Join(", ", eventParameterTypes.Select((type, index) => $"arg{index}"));

        // Generate the action call string
        var actionCallStr = $"action({lambdaParameters})";

        // If the delegate has more than one parameter, split them into individual arguments
        if (@event.HasMultipleParameters)
        {
            lambdaParameters = string.Join(", ", eventParameterTypes.Select((type, index) => $"arg{index}"));
        }
        else if (@event.HasSingleParameter)
        {
            lambdaParameters = "arg0";
        }
        else
        {
            lambdaParameters = "args";
        }

        if (@event.HasStandardSignature)
        {
            argsString = $"Action<{string.Join(", ", eventParameterTypes.Skip(1))}> action";
            actionCallStr = actionCallStr.Replace("arg0, ", "");
        }

        var eventName = @event.EventName;
        var extensionName = "On" + eventName;

        var extensionBody =
            $" => {Environment.NewLine} control._setEvent(({eventHandler}) (({lambdaParameters}) => {actionCallStr}), h => control.{eventName} += h);";

        if (@event.IsRoutedEvent)
        {
            argsString += ", Avalonia.Interactivity.RoutingStrategies? routes = null";

            extensionBody = Environment.NewLine + "{" + Environment.NewLine +
                            $"  control.AddHandler({@event.ControlTypeName}.{@eventName}Event, (_, args) => action(args), routes ?? {@event.ControlTypeName}.{@eventName}Event.RoutingStrategies);" + Environment.NewLine +
                            "  return control;" + Environment.NewLine +
                            "}" + Environment.NewLine;
        }


        var extensionText =
            (@event.IsObsolete ? "[Obsolete]" : "")
            + $"public static {@event.ReturnType} {extensionName}{@event.GenericArg}"
            + $"(this {@event.ReturnType} control, {argsString}) {@event.GenericConstraint} "
            + extensionBody;

        return extensionText;
    }

}

public class ReactiveEventGenerator : ExtensionGeneratorBase<EventExtensionInfo>
{
    private string CreateParametersNames (List<string> paramTypes)
    {
        if (paramTypes.Count > 1)
        {
            return "(" + string.Join(", ", paramTypes.Select((type, index) => $"arg{index}")) + ")";
        }
        else if (paramTypes.Count == 1)
        {
            return "arg0";
        }
        else
        {
            return "";
        }
    }
    private string CreateParametersTypes(List<string> paramTypes)
    {
        if (paramTypes.Count > 1)
        {
            return "(" + string.Join(", ", paramTypes) + ")";
        }
        else if (paramTypes.Count == 1)
        {
            return paramTypes[0];
        }
        else
        {
            return "";
        }
    }

    protected override string? GetExtension(EventExtensionInfo @event)
    {
        var eventHandler = @event.EventHandler;
        var eventParameterTypes = @event.EventParameterTypes;
        var argsString = $"IObserver<{CreateParametersTypes(eventParameterTypes)}> observer";

        // Generate the lambda parameter names (arg0, arg1, etc.)
        var lambdaParameters = "";
        // If the delegate has more than one parameter, split them into individual arguments
        if (@event.HasMultipleParameters)
        {
            lambdaParameters = string.Join(", ", eventParameterTypes.Select((type, index) => $"arg{index}"));
        }
        else if (@event.HasSingleParameter)
        {
            lambdaParameters = "arg0";
        }
        else
        {
            lambdaParameters = "args";
        }
        // Generate the action call string
        var actionCallStr = $"observer.OnNext({CreateParametersNames(eventParameterTypes)})";

        if (@event.HasStandardSignature)
        {
            argsString = $"IObserver<{CreateParametersTypes(eventParameterTypes.Skip(1).ToList())}> observer";
            actionCallStr = actionCallStr.Replace("arg0, ", "");
        }

        var eventName = @event.EventName;
        var extensionName = "Rx" + eventName;

        var extensionBody =
            $" => {Environment.NewLine} control._setEvent(({eventHandler}) (({lambdaParameters}) => {actionCallStr}), h => control.{eventName} += h);";

        if (@event.IsRoutedEvent)
        {
            argsString += ", Avalonia.Interactivity.RoutingStrategies? routes = null";

            extensionBody = Environment.NewLine + "{" + Environment.NewLine +
                            $"  control.AddHandler({@event.ControlTypeName}.{@eventName}Event, (_, args) => observer.OnNext(args), routes ?? {@event.ControlTypeName}.{@eventName}Event.RoutingStrategies);" + Environment.NewLine +
                            "  return control;" + Environment.NewLine +
                            "}" + Environment.NewLine;
        }


        var extensionText =
            (@event.IsObsolete ? "[Obsolete]" : "")
            + $"public static {@event.ReturnType} {extensionName}{@event.GenericArg}"
            + $"(this {@event.ReturnType} control, {argsString}) {@event.GenericConstraint} "
            + extensionBody;

        return extensionText;
    }

}


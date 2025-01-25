using CodeGenerator.Lib.Activator;
using CodeGenerator.Lib.Shared.Extensions;
using CodeGenerator.Lib.Shared.Generator.Factory;

internal class Program
{
    public static void Main(string[] args)
    {
        if (args?.Length == 0)
            throw new ArgumentNullException(nameof(args));

        switch (args[0].ToLower())
        {
            case "i":
                GeneratorFactory.Generate(CodeType.Interface, GetInterfaceParams());
                break;
            case "im":
                GeneratorFactory.Generate(CodeType.Implementation, GetImplementationParams());
                break;
            case "c":
                GeneratorFactory.Generate(CodeType.Controller, GetControllerParams());
                break;
            default:
                throw new Exception($"Invalid argument: {args[0]}");
        }
    }

    private static InterfaceParams GetInterfaceParams()
    {
        var settings = JsonConverter.LoadJsonSettings();
        
        if (settings == null)
            return null;

        return InterfaceParams.Create(
            path: settings.InterfaceParameters.Path,
            namespaceName: settings.InterfaceParameters.NamespaceName,
            entityName: settings.InterfaceParameters.EntityName
        );
    }
    
    private static ImplementationParams GetImplementationParams()
    {
        var settings = JsonConverter.LoadJsonSettings();
        
        if (settings == null)
            return null;

        return ImplementationParams.Create(
            path: settings.ImplementationParameters.Path,
            namespaceName: settings.ImplementationParameters.NamespaceName,
            contextName: settings.ImplementationParameters.ContextName,
            entityName: settings.ImplementationParameters.EntityName
        );
    }
    
    private static ControllerParams GetControllerParams()
    {
        var settings = JsonConverter.LoadJsonSettings();
        
        if (settings == null)
            return null;

        return ControllerParams.Create(
            path: settings.ControllerParameters.Path,
            namespaceName: settings.ControllerParameters.NamespaceName,
            entityName: settings.ControllerParameters.EntityName
        );
    }
}
using System.Reflection;
using CodeGenerator.Lib.Shared.Extensions;

namespace CodeGenerator.Lib.Shared.Generator;

public static class CoreGenerator
{
    private const string IRepository = "../../../../../CodeGenerator.Lib.Shared/Templates/IRepository.t";
    private const string Repository = "../../../../../CodeGenerator.Lib.Shared/Templates/Repository.t";
    private const string Controller = "../../../../../CodeGenerator.Lib.Shared/Templates/Controller.t";

    public static void GenerateInterface(InterfaceParams parameters)
    {
        if (parameters == null)
            throw new ArgumentNullException(nameof(parameters));
        
        string? assembly = typeof(CoreGenerator).GetTypeInfo().Assembly.Location;
        string file = $"I{parameters.EntityName}Repository.cs";
        string fullPath = CoreGenerator.CreatePathTemplate(parameters.Path, file);

        if (File.Exists(fullPath))
        {
            string template = File.ReadAllText(Path.GetFullPath(Path.Combine(assembly, IRepository)));
            var parsedContent = Parser.ParseVariables(template, new Dictionary<string, string>()
            {
                { "{{Namespace}}", parameters.NamespaceName },
                { "{{EntityName}}", parameters.EntityName }
            });

            File.WriteAllText(fullPath, parsedContent);
        }
    }

    public static void GenerateImplementation(ImplementationParams parameters)
    {
        if (parameters == null)
            throw new ArgumentNullException(nameof(parameters));
        
        string? assembly = typeof(CoreGenerator).GetTypeInfo().Assembly.Location;
        string file = $"{parameters.EntityName}Repository.cs";
        string fullPath = CoreGenerator.CreatePathTemplate(parameters.Path, file);

        if (File.Exists(fullPath))
        {
            string template = File.ReadAllText(Path.GetFullPath(Path.Combine(assembly, Repository)));
            var parsedContent = Parser.ParseVariables(template, new Dictionary<string, string>()
            {
                { "{{Namespace}}", parameters.NamespaceName },
                { "{{Context}}", parameters.ContextName },
                { "{{EntityName}}", parameters.EntityName }
            });

            File.WriteAllText(fullPath, parsedContent);
        }
    }
    
    public static void GenerateController(ControllerParams parameters)
    {
        if (parameters == null)
            throw new ArgumentNullException(nameof(parameters));
        
        string? assembly = typeof(CoreGenerator).GetTypeInfo().Assembly.Location;
        string file = $"{parameters.EntityName}Controller.cs";
        string fullPath = CoreGenerator.CreatePathTemplate(parameters.Path, file);

        if (File.Exists(fullPath))
        {
            string template = File.ReadAllText(Path.GetFullPath(Path.Combine(assembly, Controller)));
            var parsedContent = Parser.ParseVariables(template, new Dictionary<string, string>()
            {
                { "{{Namespace}}", parameters.NamespaceName },
                { "{{EntityName}}", parameters.EntityName }
            });

            File.WriteAllText(fullPath, parsedContent);
        }
    }

    private static string CreatePathTemplate(string path, string fileName)
    {
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
        
        if (!File.Exists(fileName))
            File.Create(Path.Combine(path, fileName)).Dispose();
        
        return Path.Combine(path, fileName);
    }
}
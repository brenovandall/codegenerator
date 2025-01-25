namespace CodeGenerator.Lib.Shared.Extensions;

public class ImplementationParams
{
    public string Path { get; private set; }
    public string NamespaceName { get; private set; }
    public string ContextName { get; private set; }
    public string EntityName { get; private set; }

    protected ImplementationParams()
    {
    }

    public static ImplementationParams Create(string path, string namespaceName, string contextName, string entityName)
    {
        ArgumentNullException.ThrowIfNullOrWhiteSpace(path);
        ArgumentNullException.ThrowIfNullOrWhiteSpace(namespaceName);
        ArgumentNullException.ThrowIfNullOrWhiteSpace(contextName);
        ArgumentNullException.ThrowIfNullOrWhiteSpace(entityName);

        return new ImplementationParams
        {
            Path = path,
            NamespaceName = namespaceName,
            ContextName = contextName,
            EntityName = entityName
        };
    }
}
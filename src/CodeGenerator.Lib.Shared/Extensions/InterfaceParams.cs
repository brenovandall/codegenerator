namespace CodeGenerator.Lib.Shared.Extensions;

public class InterfaceParams
{
    public string Path { get; private set; }
    public string NamespaceName { get; private set; }
    public string EntityName { get; private set; }

    protected InterfaceParams()
    {
    }

    public static InterfaceParams Create(string path, string namespaceName, string entityName)
    {
        ArgumentNullException.ThrowIfNullOrWhiteSpace(path);
        ArgumentNullException.ThrowIfNullOrWhiteSpace(namespaceName);
        ArgumentNullException.ThrowIfNullOrWhiteSpace(entityName);

        return new InterfaceParams
        {
            Path = path,
            NamespaceName = namespaceName,
            EntityName = entityName
        };
    }
}
namespace CodeGenerator.Lib.Shared.Extensions;

public class ControllerParams
{
    public string Path { get; private set; }
    public string NamespaceName { get; private set; }
    public string EntityName { get; private set; }

    protected ControllerParams()
    {
    }
    
    public static ControllerParams Create(string path, string namespaceName, string entityName)
    {
        ArgumentNullException.ThrowIfNullOrWhiteSpace(path);
        ArgumentNullException.ThrowIfNullOrWhiteSpace(namespaceName);
        ArgumentNullException.ThrowIfNullOrWhiteSpace(entityName);

        return new ControllerParams
        {
            Path = path,
            NamespaceName = namespaceName,
            EntityName = entityName
        };
    }
}
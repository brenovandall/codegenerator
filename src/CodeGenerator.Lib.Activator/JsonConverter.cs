using System.Reflection;
using Newtonsoft.Json;

namespace CodeGenerator.Lib.Activator;

public class JsonConverter
{
    public static SettingsObject? LoadJsonSettings()
    {
        string? assembly = typeof(JsonConverter).GetTypeInfo().Assembly.Location;
        using var r = new StreamReader(Path.GetFullPath(Path.Combine(assembly, "../../../../settings.json")));
        var json = r.ReadToEnd();
        return JsonConvert.DeserializeObject<SettingsObject>(json);
    }
}

public class SettingsObject
{
    public InterfaceParameters InterfaceParameters { get; set; }
    public ImplementationParameters ImplementationParameters { get; set; }
    public ControllerParameters ControllerParameters { get; set; }
}

public class InterfaceParameters
{
    public string Path { get; set; }
    public string NamespaceName { get; set; }
    public string EntityName { get; set; }
}

public class ImplementationParameters
{
    public string Path { get; set; }
    public string NamespaceName { get; set; }
    public string ContextName { get; set; }
    public string EntityName { get; set; }
}

public class ControllerParameters
{
    public string Path { get; set; }
    public string NamespaceName { get; set; }
    public string EntityName { get; set; }
}
namespace CodeGenerator.Lib.Shared.Generator;

public static class Parser
{
    public static string ParseVariables(string file, Dictionary<string, string> variables)
    {
        if (variables?.Count == 0)
            return null;

        foreach (var variable in variables)
        {
            file = file.Replace(variable.Key, variable.Value);
        }

        return file;
    }
}
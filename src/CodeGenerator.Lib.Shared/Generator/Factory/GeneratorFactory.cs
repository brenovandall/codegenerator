using CodeGenerator.Lib.Shared.Extensions;

namespace CodeGenerator.Lib.Shared.Generator.Factory;

public static class GeneratorFactory
{
    public static void Generate(CodeType codeType, dynamic parameters)
    {
        switch (codeType)
        {
            case CodeType.Interface:
                CoreGenerator.GenerateInterface(parameters as InterfaceParams);
                break;
            case CodeType.Implementation:
                CoreGenerator.GenerateImplementation(parameters as ImplementationParams);
                break;
            case CodeType.Controller:
                CoreGenerator.GenerateController(parameters as ControllerParams);
                break;
            default:
                throw new Exception("Invalid argument.");
        }
    }
}
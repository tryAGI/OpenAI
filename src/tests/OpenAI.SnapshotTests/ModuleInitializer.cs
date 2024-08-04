using System.Runtime.CompilerServices;
using VerifyTests;

namespace OpenAI.SnapshotTests;

public static class ModuleInitializer
{
    [ModuleInitializer]
    public static void Initialize()
    {
        VerifySourceGenerators.Initialize();
    }
}
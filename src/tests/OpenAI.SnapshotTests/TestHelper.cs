using H.Generators.Tests.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using OpenAI.Generators;

namespace OpenAI.SnapshotTests;

public static class TestHelper
{
    public static async Task CheckSourceAsync(
        this VerifyBase verifier,
        string source,
        CancellationToken cancellationToken = default)
    {
        var referenceAssemblies = LatestReferenceAssemblies.Net80;
        var references = await referenceAssemblies.ResolveAsync(null, cancellationToken);
        references = references
            .Add(MetadataReference.CreateFromFile(typeof(OpenAI.OpenAiToolsAttribute).Assembly.Location));

        var compilation = (Compilation)CSharpCompilation.Create(
            assemblyName: "Tests",
            syntaxTrees: new[]
            {
                CSharpSyntaxTree.ParseText(source, cancellationToken: cancellationToken),
            },
            references: references,
            options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
        var driver = CSharpGeneratorDriver
            .Create(new OpenAiToolsGenerator())
            .RunGeneratorsAndUpdateCompilation(compilation, out compilation, out _, cancellationToken);
        var diagnostics = compilation.GetDiagnostics(cancellationToken);

        await Task.WhenAll(
            verifier
                .Verify(diagnostics)
                //.AutoVerify()
                .UseDirectory("Snapshots")
                .UseTextForParameters("Diagnostics"),
            verifier
                .Verify(driver)
                //.AutoVerify()
                .UseDirectory("Snapshots"));
    }
}
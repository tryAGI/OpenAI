using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Testing;
using VerifyMSTest;

namespace H.Generators.IntegrationTests;

public static class TestHelper
{
    public static async Task CheckSourceAsync(
        this VerifyBase verifier,
        string source,
        CancellationToken cancellationToken = default)
    {
        var referenceAssemblies = ReferenceAssemblies.Net.Net60
            .AddPackages(ImmutableArray.Create(new PackageIdentity("tryAGI.OpenAI", "0.9.0")));
        var references = await referenceAssemblies.ResolveAsync(null, cancellationToken);
        references = references
            .Add(MetadataReference.CreateFromFile(typeof(tryAGI.OpenAI.OpenAiFunctionsAttribute).Assembly.Location));

        var compilation = (Compilation)CSharpCompilation.Create(
            assemblyName: "Tests",
            syntaxTrees: new[]
            {
                CSharpSyntaxTree.ParseText(source, cancellationToken: cancellationToken),
            },
            references: references,
            options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
        var driver = CSharpGeneratorDriver
            .Create(new OpenAiFunctionsGenerator())
            .RunGeneratorsAndUpdateCompilation(compilation, out compilation, out _, cancellationToken);
        var diagnostics = compilation.GetDiagnostics(cancellationToken);

        await Task.WhenAll(
            verifier
                .Verify(diagnostics)
                .UseDirectory("Snapshots")
                .UseTextForParameters("Diagnostics"),
            verifier
                .Verify(driver)
                .UseDirectory("Snapshots"));
    }
}
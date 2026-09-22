#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record EnvironmentPackagesParamOptionSet(
    Option<global::System.Collections.Generic.IList<string>?> Python,
                     Option<global::System.Collections.Generic.IList<string>?> System,
                     Option<global::System.Collections.Generic.IList<string>?> Npm)
{
    public static EnvironmentPackagesParamOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new EnvironmentPackagesParamOptionSet(
                        Python: new Option<global::System.Collections.Generic.IList<string>?>($"--{normalizedPrefix}python")
                {
                    Description = @"Python packages to install. Defaults to an empty list.",
                },
                System: new Option<global::System.Collections.Generic.IList<string>?>($"--{normalizedPrefix}system")
                {
                    Description = @"System packages to install. Defaults to an empty list.",
                },
                Npm: new Option<global::System.Collections.Generic.IList<string>?>($"--{normalizedPrefix}npm")
                {
                    Description = @"npm packages to install globally. Defaults to an empty list.",
                }
        );
    }
}
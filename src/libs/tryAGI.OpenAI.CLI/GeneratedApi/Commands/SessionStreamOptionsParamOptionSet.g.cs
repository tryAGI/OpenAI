#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record SessionStreamOptionsParamOptionSet(
    Option<bool?> IncludeObfuscation)
{
    public static SessionStreamOptionsParamOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new SessionStreamOptionsParamOptionSet(
                        IncludeObfuscation: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}include-obfuscation", description: @"Whether to include obfuscation padding in events on this connection. Defaults to `true`.")
        );
    }
}
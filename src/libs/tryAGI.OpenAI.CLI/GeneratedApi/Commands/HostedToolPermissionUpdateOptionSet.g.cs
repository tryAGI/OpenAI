#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record HostedToolPermissionUpdateOptionSet(
    Option<bool> Enabled)
{
    public static HostedToolPermissionUpdateOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new HostedToolPermissionUpdateOptionSet(
                        Enabled: new Option<bool>($"--{normalizedPrefix}enabled")
                {
                    Description = @"Whether to enable the hosted tool for the project.",
                    Required = true,
                }
        );
    }
}
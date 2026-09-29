#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record DesktopParamOptionSet(
    Option<bool> Enabled)
{
    public static DesktopParamOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new DesktopParamOptionSet(
                        Enabled: new Option<bool>($"--{normalizedPrefix}enabled")
                {
                    Description = @"Whether to provision the desktop and its browser proxy.",
                    Required = true,
                }
        );
    }
}
#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record SvgParamOptionSet(
    Option<string?> Model)
{
    public static SvgParamOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new SvgParamOptionSet(
                        Model: new Option<string?>($"--{normalizedPrefix}model")
                {
                    Description = @"",
                }
        );
    }
}
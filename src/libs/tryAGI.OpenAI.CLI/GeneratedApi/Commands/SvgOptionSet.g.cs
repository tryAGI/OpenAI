#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record SvgOptionSet(
    Option<string> Model)
{
    public static SvgOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new SvgOptionSet(
                        Model: new Option<string>($"--{normalizedPrefix}model")
                {
                    Description = @"Model used to author the SVG. Required when SVG model selection is enabled.",
                    Required = true,
                }
        );
    }
}
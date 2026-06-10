#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record PromptVariant1OptionSet(
    Option<string> Id,
                     Option<string?> Version)
{
    public static PromptVariant1OptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new PromptVariant1OptionSet(
                        Id: new Option<string>($"--{normalizedPrefix}id")
                {
                    Description = @"The unique identifier of the prompt template to use.",
                    Required = true,
                },
                Version: new Option<string?>($"--{normalizedPrefix}version")
                {
                    Description = @"",
                }
        );
    }
}
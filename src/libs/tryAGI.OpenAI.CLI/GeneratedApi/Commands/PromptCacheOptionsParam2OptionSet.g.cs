#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record PromptCacheOptionsParam2OptionSet(
    Option<global::tryAGI.OpenAI.PromptCacheTtlParam?> Ttl)
{
    public static PromptCacheOptionsParam2OptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new PromptCacheOptionsParam2OptionSet(
                        Ttl: new Option<global::tryAGI.OpenAI.PromptCacheTtlParam?>($"--{normalizedPrefix}ttl")
                {
                    Description = @"Minimum lifetime for new prompt cache entries. Defaults to 30 minutes.",
                }
        );
    }
}
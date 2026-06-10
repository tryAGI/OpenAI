#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record FileExpirationAfterOptionSet(
    Option<global::tryAGI.OpenAI.FileExpirationAfterAnchor> Anchor,
                     Option<long> Seconds)
{
    public static FileExpirationAfterOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new FileExpirationAfterOptionSet(
                        Anchor: new Option<global::tryAGI.OpenAI.FileExpirationAfterAnchor>($"--{normalizedPrefix}anchor")
                {
                    Description = @"Anchor timestamp after which the expiration policy applies. Supported anchors: `created_at`.",
                },
                Seconds: new Option<long>($"--{normalizedPrefix}seconds")
                {
                    Description = @"The number of seconds after the anchor time that the file will expire. Must be between 3600 (1 hour) and 2592000 (30 days).",
                    Required = true,
                }
        );
    }
}
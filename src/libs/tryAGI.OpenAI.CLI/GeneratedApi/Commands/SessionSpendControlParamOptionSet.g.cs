#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record SessionSpendControlParamOptionSet(
    Option<long?> Limit)
{
    public static SessionSpendControlParamOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new SessionSpendControlParamOptionSet(
                        Limit: new Option<long?>($"--{normalizedPrefix}limit")
                {
                    Description = @"Positive USD cents, or null to remove the limit.",
                }
        );
    }
}
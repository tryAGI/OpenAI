#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record MultiAgentConfigCurrentParamOptionSet(
    Option<bool> Enabled,
                     Option<long?> MaxConcurrentSubagents)
{
    public static MultiAgentConfigCurrentParamOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new MultiAgentConfigCurrentParamOptionSet(
                        Enabled: new Option<bool>($"--{normalizedPrefix}enabled")
                {
                    Description = @"Whether subagent tools are enabled.",
                    Required = true,
                },
                MaxConcurrentSubagents: new Option<long?>($"--{normalizedPrefix}max-concurrent-subagents")
                {
                    Description = @"Maximum number of subagents that may run concurrently. Defaults to 6.",
                }
        );
    }
}
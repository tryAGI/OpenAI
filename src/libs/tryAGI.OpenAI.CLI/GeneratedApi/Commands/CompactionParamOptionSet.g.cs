#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record CompactionParamOptionSet(
    Option<bool?> Async)
{
    public static CompactionParamOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new CompactionParamOptionSet(
                        Async: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}async", description: @"Whether to compact context in the background. Omission or null defaults to false. Set to true to enable background compaction. Background compaction may increase token usage.")
        );
    }
}
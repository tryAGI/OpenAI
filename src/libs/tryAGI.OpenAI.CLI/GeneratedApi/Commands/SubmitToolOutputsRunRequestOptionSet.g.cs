#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record SubmitToolOutputsRunRequestOptionSet(
    Option<bool?> Stream)
{
    public static SubmitToolOutputsRunRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new SubmitToolOutputsRunRequestOptionSet(
                        Stream: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}stream", description: @"")
        );
    }
}
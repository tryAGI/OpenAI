#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record SessionAgentConfigParamOptionSet(
    Option<string?> Model,
                     Option<string?> Instructions)
{
    public static SessionAgentConfigParamOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new SessionAgentConfigParamOptionSet(
                        Model: new Option<string?>($"--{normalizedPrefix}model")
                {
                    Description = @"The model to use for the agent. The requested model name is preserved.",
                },
                Instructions: new Option<string?>($"--{normalizedPrefix}instructions")
                {
                    Description = @"Additional instructions appended to the agent's default base instructions. Omit to leave unchanged.",
                }
        );
    }
}
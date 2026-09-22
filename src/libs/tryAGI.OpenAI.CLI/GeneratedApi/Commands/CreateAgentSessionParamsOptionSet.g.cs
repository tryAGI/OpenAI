#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record CreateAgentSessionParamsOptionSet(
    Option<string?> AgentId,
                     Option<global::System.Collections.Generic.IList<string>?> VaultIds,
                     Option<bool?> Stream)
{
    public static CreateAgentSessionParamsOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new CreateAgentSessionParamsOptionSet(
                        AgentId: new Option<string?>($"--{normalizedPrefix}agent-id")
                {
                    Description = @"The ID of a saved reusable agent. Omit `agent` to use its configuration unchanged.",
                },
                VaultIds: new Option<global::System.Collections.Generic.IList<string>?>($"--{normalizedPrefix}vault-ids")
                {
                    Description = @"The IDs of vaults made available to the session.",
                },
                Stream: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}stream", description: @"Whether to stream session events as server-sent events. Defaults to `false`.")
        );
    }
}
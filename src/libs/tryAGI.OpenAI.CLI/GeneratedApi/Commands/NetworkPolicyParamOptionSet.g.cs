#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record NetworkPolicyParamOptionSet(
    Option<global::tryAGI.OpenAI.NetworkAccessParam> Access,
                     Option<global::System.Collections.Generic.IList<string>?> AllowedDomains)
{
    public static NetworkPolicyParamOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new NetworkPolicyParamOptionSet(
                        Access: new Option<global::tryAGI.OpenAI.NetworkAccessParam>($"--{normalizedPrefix}access")
                {
                    Description = @"The environment's network access mode.",
                    Required = true,
                },
                AllowedDomains: new Option<global::System.Collections.Generic.IList<string>?>($"--{normalizedPrefix}allowed-domains")
                {
                    Description = @"Domains the environment may access when network access is restricted.",
                }
        );
    }
}
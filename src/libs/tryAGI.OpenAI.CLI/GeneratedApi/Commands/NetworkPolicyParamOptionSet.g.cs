#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record NetworkPolicyParamOptionSet(
    Option<global::tryAGI.OpenAI.NetworkAccessParam> Access,
                     Option<global::System.Collections.Generic.IList<string>?> AllowedDomains,
                     Option<global::System.Collections.Generic.IList<string>?> BlockedDomains)
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
                },
                BlockedDomains: new Option<global::System.Collections.Generic.IList<string>?>($"--{normalizedPrefix}blocked-domains")
                {
                    Description = @"Domains blocked for both executor and browser when access is restricted. A nonempty list requires `access: restricted` and cannot be combined with nonempty `allowed_domains`. Wildcard domains are not supported.",
                }
        );
    }
}
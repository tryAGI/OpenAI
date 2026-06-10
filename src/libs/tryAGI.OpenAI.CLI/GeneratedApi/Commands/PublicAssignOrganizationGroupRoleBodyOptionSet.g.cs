#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record PublicAssignOrganizationGroupRoleBodyOptionSet(
    Option<string> RoleId)
{
    public static PublicAssignOrganizationGroupRoleBodyOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new PublicAssignOrganizationGroupRoleBodyOptionSet(
                        RoleId: new Option<string>($"--{normalizedPrefix}role-id")
                {
                    Description = @"Identifier of the role to assign.",
                    Required = true,
                }
        );
    }
}
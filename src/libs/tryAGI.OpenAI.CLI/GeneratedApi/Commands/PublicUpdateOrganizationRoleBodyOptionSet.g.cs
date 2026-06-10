#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record PublicUpdateOrganizationRoleBodyOptionSet(
    Option<string?> DescriptionOption,
                     Option<string?> RoleName)
{
    public static PublicUpdateOrganizationRoleBodyOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new PublicUpdateOrganizationRoleBodyOptionSet(
                        DescriptionOption: new Option<string?>($"--{normalizedPrefix}description")
                {
                    Description = @"New description for the role.",
                },
                RoleName: new Option<string?>($"--{normalizedPrefix}role-name")
                {
                    Description = @"New name for the role.",
                }
        );
    }
}
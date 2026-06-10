#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record PublicCreateOrganizationRoleBodyOptionSet(
    Option<string> RoleName,
                     Option<global::System.Collections.Generic.IList<string>> Permissions,
                     Option<string?> DescriptionOption)
{
    public static PublicCreateOrganizationRoleBodyOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new PublicCreateOrganizationRoleBodyOptionSet(
                        RoleName: new Option<string>($"--{normalizedPrefix}role-name")
                {
                    Description = @"Unique name for the role.",
                    Required = true,
                },
                Permissions: new Option<global::System.Collections.Generic.IList<string>>($"--{normalizedPrefix}permissions")
                {
                    Description = @"Permissions to grant to the role.",
                    Required = true,
                },
                DescriptionOption: new Option<string?>($"--{normalizedPrefix}description")
                {
                    Description = @"Optional description of the role.",
                }
        );
    }
}
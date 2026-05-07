#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class RolesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"roles", @"Roles endpoint commands.");
                         command.Subcommands.Add(RolesCreateOrganizationRoleCommandApiCommand.Create());
                         command.Subcommands.Add(RolesCreateProjectRoleCommandApiCommand.Create());
                         command.Subcommands.Add(RolesDeleteOrganizationRoleCommandApiCommand.Create());
                         command.Subcommands.Add(RolesDeleteProjectRoleCommandApiCommand.Create());
                         command.Subcommands.Add(RolesListOrganizationRolesCommandApiCommand.Create());
                         command.Subcommands.Add(RolesListProjectRolesCommandApiCommand.Create());
                         command.Subcommands.Add(RolesUpdateOrganizationRoleCommandApiCommand.Create());
                         command.Subcommands.Add(RolesUpdateProjectRoleCommandApiCommand.Create());
        return command;
    }
}
#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class RolesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"roles", @"Roles endpoint commands.");
                         command.Subcommands.Add(RolesCreateProjectRoleCommandApiCommand.Create());
                         command.Subcommands.Add(RolesCreateRoleCommandApiCommand.Create());
                         command.Subcommands.Add(RolesDeleteProjectRoleCommandApiCommand.Create());
                         command.Subcommands.Add(RolesDeleteRoleCommandApiCommand.Create());
                         command.Subcommands.Add(RolesListProjectRolesCommandApiCommand.Create());
                         command.Subcommands.Add(RolesListRolesCommandApiCommand.Create());
                         command.Subcommands.Add(RolesRetrieveProjectRoleCommandApiCommand.Create());
                         command.Subcommands.Add(RolesRetrieveRoleCommandApiCommand.Create());
                         command.Subcommands.Add(RolesUpdateProjectRoleCommandApiCommand.Create());
                         command.Subcommands.Add(RolesUpdateRoleCommandApiCommand.Create());
        return command;
    }
}
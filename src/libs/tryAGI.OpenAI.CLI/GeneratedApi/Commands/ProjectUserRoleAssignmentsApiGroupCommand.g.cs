#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ProjectUserRoleAssignmentsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"project-user-role-assignments", @"Project user role assignments endpoint commands.");
                         command.Subcommands.Add(ProjectUserRoleAssignmentsAssignProjectRoleToUserCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectUserRoleAssignmentsListProjectUserRoleAssignmentsCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectUserRoleAssignmentsRetrieveProjectUserRoleCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectUserRoleAssignmentsUnassignProjectRoleFromUserCommandApiCommand.Create());
        return command;
    }
}
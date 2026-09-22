#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ProjectUserRoleAssignmentsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"project-user-role-assignments", @"Project user role assignments endpoint commands.");
                         command.Subcommands.Add(ProjectUserRoleAssignmentsAssignProjectUserRoleCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectUserRoleAssignmentsListProjectUserRoleAssignmentsCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectUserRoleAssignmentsRetrieveProjectUserRoleCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectUserRoleAssignmentsUnassignProjectUserRoleCommandApiCommand.Create());
        return command;
    }
}
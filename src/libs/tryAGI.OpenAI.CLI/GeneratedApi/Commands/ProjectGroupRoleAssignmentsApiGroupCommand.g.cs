#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ProjectGroupRoleAssignmentsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"project-group-role-assignments", @"Project group role assignments endpoint commands.");
                         command.Subcommands.Add(ProjectGroupRoleAssignmentsAssignProjectGroupRoleCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectGroupRoleAssignmentsListProjectGroupRoleAssignmentsCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectGroupRoleAssignmentsRetrieveProjectGroupRoleCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectGroupRoleAssignmentsUnassignProjectGroupRoleCommandApiCommand.Create());
        return command;
    }
}
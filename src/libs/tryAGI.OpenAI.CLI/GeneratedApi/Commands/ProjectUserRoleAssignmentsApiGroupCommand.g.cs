#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class ProjectUserRoleAssignmentsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"project-user-role-assignments", @"Project user role assignments endpoint commands.");
                         command.Subcommands.Add(ProjectUserRoleAssignmentsAssignProjectUserRoleCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectUserRoleAssignmentsListProjectUserRoleAssignmentsCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectUserRoleAssignmentsRetrieveProjectUserRoleCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectUserRoleAssignmentsUnassignProjectUserRoleCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}
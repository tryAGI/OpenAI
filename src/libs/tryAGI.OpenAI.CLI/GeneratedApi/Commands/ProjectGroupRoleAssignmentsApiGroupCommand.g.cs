#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class ProjectGroupRoleAssignmentsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"project-group-role-assignments", @"Project group role assignments endpoint commands.");
                         command.Subcommands.Add(ProjectGroupRoleAssignmentsAssignProjectGroupRoleCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectGroupRoleAssignmentsListProjectGroupRoleAssignmentsCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectGroupRoleAssignmentsRetrieveProjectGroupRoleCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectGroupRoleAssignmentsUnassignProjectGroupRoleCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}
#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class GroupOrganizationRoleAssignmentsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"group-organization-role-assignments", @"Group organization role assignments endpoint commands.");
                         command.Subcommands.Add(GroupOrganizationRoleAssignmentsAssignGroupRoleCommandApiCommand.Create());
                         command.Subcommands.Add(GroupOrganizationRoleAssignmentsListGroupRoleAssignmentsCommandApiCommand.Create());
                         command.Subcommands.Add(GroupOrganizationRoleAssignmentsRetrieveGroupRoleCommandApiCommand.Create());
                         command.Subcommands.Add(GroupOrganizationRoleAssignmentsUnassignGroupRoleCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}
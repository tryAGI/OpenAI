#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class GroupOrganizationRoleAssignmentsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"group-organization-role-assignments", @"Group organization role assignments endpoint commands.");
                         command.Subcommands.Add(GroupOrganizationRoleAssignmentsAssignGroupRoleCommandApiCommand.Create());
                         command.Subcommands.Add(GroupOrganizationRoleAssignmentsListGroupRoleAssignmentsCommandApiCommand.Create());
                         command.Subcommands.Add(GroupOrganizationRoleAssignmentsRetrieveGroupRoleCommandApiCommand.Create());
                         command.Subcommands.Add(GroupOrganizationRoleAssignmentsUnassignGroupRoleCommandApiCommand.Create());
        return command;
    }
}
#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class GroupOrganizationRoleAssignmentsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"group-organization-role-assignments", @"Group organization role assignments endpoint commands.");
                         command.Subcommands.Add(GroupOrganizationRoleAssignmentsAssignOrganizationRoleToGroupCommandApiCommand.Create());
                         command.Subcommands.Add(GroupOrganizationRoleAssignmentsListGroupOrganizationRoleAssignmentsCommandApiCommand.Create());
                         command.Subcommands.Add(GroupOrganizationRoleAssignmentsRetrieveGroupOrganizationRoleCommandApiCommand.Create());
                         command.Subcommands.Add(GroupOrganizationRoleAssignmentsUnassignOrganizationRoleFromGroupCommandApiCommand.Create());
        return command;
    }
}
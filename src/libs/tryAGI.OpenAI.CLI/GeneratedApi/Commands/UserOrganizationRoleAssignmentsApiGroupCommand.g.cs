#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class UserOrganizationRoleAssignmentsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"user-organization-role-assignments", @"User organization role assignments endpoint commands.");
                         command.Subcommands.Add(UserOrganizationRoleAssignmentsAssignOrganizationRoleToUserCommandApiCommand.Create());
                         command.Subcommands.Add(UserOrganizationRoleAssignmentsListUserOrganizationRoleAssignmentsCommandApiCommand.Create());
                         command.Subcommands.Add(UserOrganizationRoleAssignmentsUnassignOrganizationRoleFromUserCommandApiCommand.Create());
        return command;
    }
}
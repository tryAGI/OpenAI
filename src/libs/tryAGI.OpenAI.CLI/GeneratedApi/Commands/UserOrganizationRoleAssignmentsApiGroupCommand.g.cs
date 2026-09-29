#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class UserOrganizationRoleAssignmentsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"user-organization-role-assignments", @"User organization role assignments endpoint commands.");
                         command.Subcommands.Add(UserOrganizationRoleAssignmentsAssignUserRoleCommandApiCommand.Create());
                         command.Subcommands.Add(UserOrganizationRoleAssignmentsListUserRoleAssignmentsCommandApiCommand.Create());
                         command.Subcommands.Add(UserOrganizationRoleAssignmentsRetrieveUserRoleCommandApiCommand.Create());
                         command.Subcommands.Add(UserOrganizationRoleAssignmentsUnassignUserRoleCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}
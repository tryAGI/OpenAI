#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class GroupUsersApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"group-users", @"Group users endpoint commands.");
                         command.Subcommands.Add(GroupUsersAddGroupUserCommandApiCommand.Create());
                         command.Subcommands.Add(GroupUsersListGroupUsersCommandApiCommand.Create());
                         command.Subcommands.Add(GroupUsersRemoveGroupUserCommandApiCommand.Create());
        return command;
    }
}
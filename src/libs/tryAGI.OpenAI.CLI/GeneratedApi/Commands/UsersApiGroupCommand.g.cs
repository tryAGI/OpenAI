#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class UsersApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"users", @"Users endpoint commands.");
                         command.Subcommands.Add(UsersDeleteUserCommandApiCommand.Create());
                         command.Subcommands.Add(UsersListUsersCommandApiCommand.Create());
                         command.Subcommands.Add(UsersModifyUserCommandApiCommand.Create());
                         command.Subcommands.Add(UsersRetrieveUserCommandApiCommand.Create());
        return command;
    }
}
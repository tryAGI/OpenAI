#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class UsersApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"users", @"Users endpoint commands.");
                         command.Subcommands.Add(UsersDeleteUserCommandApiCommand.Create());
                         command.Subcommands.Add(UsersListUsersCommandApiCommand.Create());
                         command.Subcommands.Add(UsersModifyUserCommandApiCommand.Create());
                         command.Subcommands.Add(UsersRetrieveUserCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}
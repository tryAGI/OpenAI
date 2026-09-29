#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class GroupsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"groups", @"Groups endpoint commands.");
                         command.Subcommands.Add(GroupsCreateGroupCommandApiCommand.Create());
                         command.Subcommands.Add(GroupsDeleteGroupCommandApiCommand.Create());
                         command.Subcommands.Add(GroupsListGroupsCommandApiCommand.Create());
                         command.Subcommands.Add(GroupsRetrieveGroupCommandApiCommand.Create());
                         command.Subcommands.Add(GroupsUpdateGroupCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}
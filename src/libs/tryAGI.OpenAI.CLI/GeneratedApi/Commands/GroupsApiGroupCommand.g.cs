#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class GroupsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"groups", @"Groups endpoint commands.");
                         command.Subcommands.Add(GroupsCreateGroupCommandApiCommand.Create());
                         command.Subcommands.Add(GroupsDeleteGroupCommandApiCommand.Create());
                         command.Subcommands.Add(GroupsListGroupsCommandApiCommand.Create());
                         command.Subcommands.Add(GroupsRetrieveGroupCommandApiCommand.Create());
                         command.Subcommands.Add(GroupsUpdateGroupCommandApiCommand.Create());
        return command;
    }
}
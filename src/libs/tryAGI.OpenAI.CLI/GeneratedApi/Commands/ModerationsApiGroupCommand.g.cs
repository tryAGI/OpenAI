#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ModerationsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"moderations", @"Moderations endpoint commands.");
                         command.Subcommands.Add(ModerationsCreateModerationCommandApiCommand.Create());
        return command;
    }
}
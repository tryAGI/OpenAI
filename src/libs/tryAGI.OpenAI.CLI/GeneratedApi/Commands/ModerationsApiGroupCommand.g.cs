#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class ModerationsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"moderations", @"Moderations endpoint commands.");
                         command.Subcommands.Add(ModerationsCreateModerationCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}
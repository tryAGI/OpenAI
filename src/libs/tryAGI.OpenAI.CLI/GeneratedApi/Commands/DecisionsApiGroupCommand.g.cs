#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class DecisionsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"decisions", @"Decisions endpoint commands.");
                         command.Subcommands.Add(DecisionsCreateDecisionCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}
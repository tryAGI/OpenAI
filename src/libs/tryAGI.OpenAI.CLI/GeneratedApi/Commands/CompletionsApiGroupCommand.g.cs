#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class CompletionsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"completions", @"Completions endpoint commands.");
                         command.Subcommands.Add(CompletionsCreateCompletionCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}
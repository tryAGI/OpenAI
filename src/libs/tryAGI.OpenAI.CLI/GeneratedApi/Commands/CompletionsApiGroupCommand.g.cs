#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class CompletionsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"completions", @"Completions endpoint commands.");
                         command.Subcommands.Add(CompletionsCreateCompletionCommandApiCommand.Create());
        return command;
    }
}
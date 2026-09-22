#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class EvalsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"evals", @"Evals endpoint commands.");
                         command.Subcommands.Add(EvalsCancelEvalRunCommandApiCommand.Create());
                         command.Subcommands.Add(EvalsCreateEvalCommandApiCommand.Create());
                         command.Subcommands.Add(EvalsCreateEvalRunCommandApiCommand.Create());
                         command.Subcommands.Add(EvalsDeleteEvalCommandApiCommand.Create());
                         command.Subcommands.Add(EvalsDeleteEvalRunCommandApiCommand.Create());
                         command.Subcommands.Add(EvalsGetEvalCommandApiCommand.Create());
                         command.Subcommands.Add(EvalsGetEvalRunCommandApiCommand.Create());
                         command.Subcommands.Add(EvalsGetEvalRunOutputItemCommandApiCommand.Create());
                         command.Subcommands.Add(EvalsGetEvalRunOutputItemsCommandApiCommand.Create());
                         command.Subcommands.Add(EvalsGetEvalRunsCommandApiCommand.Create());
                         command.Subcommands.Add(EvalsListEvalsCommandApiCommand.Create());
                         command.Subcommands.Add(EvalsUpdateEvalCommandApiCommand.Create());
        return command;
    }
}
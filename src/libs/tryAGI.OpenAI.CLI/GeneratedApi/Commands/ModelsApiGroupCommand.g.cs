#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ModelsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"models", @"Models endpoint commands.");
                         command.Subcommands.Add(ModelsDeleteAFineTunedModelCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsListModelsCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsRetrieveModelCommandApiCommand.Create());
        return command;
    }
}
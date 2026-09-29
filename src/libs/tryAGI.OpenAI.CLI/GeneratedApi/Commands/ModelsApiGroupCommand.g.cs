#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class ModelsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"models", @"Models endpoint commands.");
                         command.Subcommands.Add(ModelsDeleteModelCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsListModelsCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsRetrieveModelCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}
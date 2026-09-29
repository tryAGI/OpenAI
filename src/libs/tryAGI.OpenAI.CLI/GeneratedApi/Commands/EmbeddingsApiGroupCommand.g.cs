#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class EmbeddingsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"embeddings", @"Embeddings endpoint commands.");
                         command.Subcommands.Add(EmbeddingsCreateEmbeddingCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}
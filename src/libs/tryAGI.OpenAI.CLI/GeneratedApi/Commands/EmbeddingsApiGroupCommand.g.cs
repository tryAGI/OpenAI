#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class EmbeddingsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"embeddings", @"Embeddings endpoint commands.");
                         command.Subcommands.Add(EmbeddingsCreateEmbeddingsCommandApiCommand.Create());
        return command;
    }
}
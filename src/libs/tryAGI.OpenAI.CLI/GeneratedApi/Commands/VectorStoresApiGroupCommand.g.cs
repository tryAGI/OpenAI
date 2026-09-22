#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class VectorStoresApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"vector-stores", @"Vector stores endpoint commands.");
                         command.Subcommands.Add(VectorStoresCancelVectorStoreFileBatchCommandApiCommand.Create());
                         command.Subcommands.Add(VectorStoresCreateVectorStoreCommandApiCommand.Create());
                         command.Subcommands.Add(VectorStoresCreateVectorStoreFileCommandApiCommand.Create());
                         command.Subcommands.Add(VectorStoresCreateVectorStoreFileBatchCommandApiCommand.Create());
                         command.Subcommands.Add(VectorStoresDeleteVectorStoreCommandApiCommand.Create());
                         command.Subcommands.Add(VectorStoresDeleteVectorStoreFileCommandApiCommand.Create());
                         command.Subcommands.Add(VectorStoresGetVectorStoreCommandApiCommand.Create());
                         command.Subcommands.Add(VectorStoresGetVectorStoreFileCommandApiCommand.Create());
                         command.Subcommands.Add(VectorStoresGetVectorStoreFileBatchCommandApiCommand.Create());
                         command.Subcommands.Add(VectorStoresListFilesInVectorStoreBatchCommandApiCommand.Create());
                         command.Subcommands.Add(VectorStoresListVectorStoreFilesCommandApiCommand.Create());
                         command.Subcommands.Add(VectorStoresListVectorStoresCommandApiCommand.Create());
                         command.Subcommands.Add(VectorStoresModifyVectorStoreCommandApiCommand.Create());
                         command.Subcommands.Add(VectorStoresRetrieveVectorStoreFileContentCommandApiCommand.Create());
                         command.Subcommands.Add(VectorStoresSearchVectorStoreCommandApiCommand.Create());
                         command.Subcommands.Add(VectorStoresUpdateVectorStoreFileAttributesCommandApiCommand.Create());
        return command;
    }
}
#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class BatchApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"batch", @"Batch endpoint commands.");
                         command.Subcommands.Add(BatchCancelBatchCommandApiCommand.Create());
                         command.Subcommands.Add(BatchCreateBatchCommandApiCommand.Create());
                         command.Subcommands.Add(BatchListBatchesCommandApiCommand.Create());
                         command.Subcommands.Add(BatchRetrieveBatchCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}
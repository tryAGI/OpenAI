#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class VectorStoresCancelVectorStoreFileBatchCommandApiCommand
{
    private static Argument<string> VectorStoreId { get; } = new(
        name: @"vector-store-id")
    {
        Description = @"The ID of the vector store that the file batch belongs to.",
    };

    private static Argument<string> BatchId { get; } = new(
        name: @"batch-id")
    {
        Description = @"The ID of the file batch to cancel.",
    };

    public static Command Create()
    {
        var command = new Command(@"cancel-vector-store-file-batch", @"Cancel a vector store file batch. This attempts to cancel the processing of files in this batch as soon as possible.");
                        command.Arguments.Add(VectorStoreId);
                        command.Arguments.Add(BatchId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var vectorStoreId = parseResult.GetRequiredValue(VectorStoreId);
                        var batchId = parseResult.GetRequiredValue(BatchId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.VectorStores.CancelVectorStoreFileBatchAsync(
                                    vectorStoreId: vectorStoreId,
                                    batchId: batchId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteJsonAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}
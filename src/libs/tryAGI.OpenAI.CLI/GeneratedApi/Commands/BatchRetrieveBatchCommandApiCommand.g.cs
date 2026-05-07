#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class BatchRetrieveBatchCommandApiCommand
{
    private static Argument<string> BatchId { get; } = new(
        name: @"batch-id")
    {
        Description = @"The ID of the batch to retrieve.",
    };

    public static Command Create()
    {
        var command = new Command(@"retrieve-batch", @"Retrieves a batch.");
                        command.Arguments.Add(BatchId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var batchId = parseResult.GetRequiredValue(BatchId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Batch.RetrieveBatchAsync(
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
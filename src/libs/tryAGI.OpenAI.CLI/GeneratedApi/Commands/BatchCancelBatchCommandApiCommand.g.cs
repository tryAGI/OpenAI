#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class BatchCancelBatchCommandApiCommand
{
    private static Argument<string> BatchId { get; } = new(
        name: @"batch-id")
    {
        Description = @"The ID of the batch to cancel.",
    };

    public static Command Create()
    {
        var command = new Command(@"cancel-batch", @"Cancels an in-progress batch. The batch will be in status `cancelling` for up to 10 minutes, before changing to `cancelled`, where it will have partial results (if any) available in the output file.");
                        command.Arguments.Add(BatchId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var batchId = parseResult.GetRequiredValue(BatchId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Batch.CancelBatchAsync(
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
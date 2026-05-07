#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class VectorStoresRetrieveVectorStoreCommandApiCommand
{
    private static Argument<string> VectorStoreId { get; } = new(
        name: @"vector-store-id")
    {
        Description = @"The ID of the vector store to retrieve.",
    };

    public static Command Create()
    {
        var command = new Command(@"retrieve-vector-store", @"Retrieves a vector store.");
                        command.Arguments.Add(VectorStoreId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var vectorStoreId = parseResult.GetRequiredValue(VectorStoreId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.VectorStores.RetrieveVectorStoreAsync(
                                    vectorStoreId: vectorStoreId,
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
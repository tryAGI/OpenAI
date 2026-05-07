#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class VectorStoresRetrieveVectorStoreFileContentCommandApiCommand
{
    private static Argument<string> VectorStoreId { get; } = new(
        name: @"vector-store-id")
    {
        Description = @"The ID of the vector store.",
    };

    private static Argument<string> FileId { get; } = new(
        name: @"file-id")
    {
        Description = @"The ID of the file within the vector store.",
    };

    public static Command Create()
    {
        var command = new Command(@"retrieve-vector-store-file-content", @"Retrieve the parsed contents of a vector store file.");
                        command.Arguments.Add(VectorStoreId);
                        command.Arguments.Add(FileId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var vectorStoreId = parseResult.GetRequiredValue(VectorStoreId);
                        var fileId = parseResult.GetRequiredValue(FileId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.VectorStores.RetrieveVectorStoreFileContentAsync(
                                    vectorStoreId: vectorStoreId,
                                    fileId: fileId,
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
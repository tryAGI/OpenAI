#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class RetrieveAdminApiKeyCommandApiCommand
{
    private static Argument<string> KeyId { get; } = new(
        name: @"key-id")
    {
        Description = @"The ID of the API key.",
    };

    public static Command Create()
    {
        var command = new Command(@"retrieve-admin-api-key", @"Retrieve a single organization API key
Get details for a specific organization API key by its ID.");
                        command.Arguments.Add(KeyId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var keyId = parseResult.GetRequiredValue(KeyId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.RetrieveAdminApiKeyAsync(
                                    keyId: keyId,
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
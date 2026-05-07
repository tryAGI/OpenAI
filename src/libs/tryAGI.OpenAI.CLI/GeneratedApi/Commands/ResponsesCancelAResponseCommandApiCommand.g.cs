#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ResponsesCancelAResponseCommandApiCommand
{
    private static Argument<string> ResponseId { get; } = new(
        name: @"response-id")
    {
        Description = @"The ID of the response to cancel.",
    };

    public static Command Create()
    {
        var command = new Command(@"cancel-aresponse", @"Cancels a model response with the given ID. Only responses created with
the `background` parameter set to `true` can be cancelled.
[Learn more](/docs/guides/background).
");
                        command.Arguments.Add(ResponseId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var responseId = parseResult.GetRequiredValue(ResponseId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Responses.CancelAResponseAsync(
                                    responseId: responseId,
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
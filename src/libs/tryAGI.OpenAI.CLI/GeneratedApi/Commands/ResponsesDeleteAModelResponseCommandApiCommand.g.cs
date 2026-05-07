#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ResponsesDeleteAModelResponseCommandApiCommand
{
    private static Argument<string> ResponseId { get; } = new(
        name: @"response-id")
    {
        Description = @"The ID of the response to delete.",
    };

    public static Command Create()
    {
        var command = new Command(@"delete-amodel-response", @"Deletes a model response with the given ID.
");
                        command.Arguments.Add(ResponseId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var responseId = parseResult.GetRequiredValue(ResponseId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                await client.Responses.DeleteAModelResponseAsync(
                                    responseId: responseId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}
#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class ResponsesDeleteAModelResponse2CommandApiCommand
{
    private static Argument<string> ResponseId { get; } = new(
        name: @"response-id")
    {
        Description = @"The ID of the response to delete.",
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaDeleteResponseOpenaiBetaItem>?> OpenaiBeta { get; } = new(
        name: @"--openai-beta")
    {
        Description = @"Optional beta features to enable for this request.",
    };

    public static Command Create()
    {
        var command = new Command(@"delete-amodel-response2", @"Deletes a model response with the given ID.
");
                        command.Arguments.Add(ResponseId);
                        command.Options.Add(OpenaiBeta);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var responseId = parseResult.GetRequiredValue(ResponseId);
                        var openaiBeta = parseResult.GetValue(OpenaiBeta);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Responses.DeleteAModelResponse2Async(
                                    responseId: responseId,
                                    openaiBeta: openaiBeta,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}
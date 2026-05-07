#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ResponsesGetAModelResponseCommandApiCommand
{
    private static Argument<string> ResponseId { get; } = new(
        name: @"response-id")
    {
        Description = @"The ID of the response to retrieve.",
    };    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.IncludeEnum>?> Include { get; } = new(
        name: @"--include")
    {
        Description = @"Additional fields to include in the response. See the `include`
parameter for Response creation above for more information.
",
    };

    private static Option<bool?> Stream { get; } = new(
        name: @"--stream")
    {
        Description = @"If set to true, the model response data will be streamed to the client
as it is generated using [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format).
See the [Streaming section below](/docs/api-reference/responses-streaming)
for more information.
",
    };

    private static Option<int?> StartingAfter { get; } = new(
        name: @"--starting-after")
    {
        Description = @"The sequence number of the event after which to start streaming.
",
    };

    private static Option<bool?> IncludeObfuscation { get; } = new(
        name: @"--include-obfuscation")
    {
        Description = @"When true, stream obfuscation will be enabled. Stream obfuscation adds
random characters to an `obfuscation` field on streaming delta events
to normalize payload sizes as a mitigation to certain side-channel
attacks. These obfuscation fields are included by default, but add a
small amount of overhead to the data stream. You can set
`include_obfuscation` to false to optimize for bandwidth if you trust
the network links between your application and the OpenAI API.
",
    };

    public static Command Create()
    {
        var command = new Command(@"get-amodel-response", @"Retrieves a model response with the given ID.
");
                        command.Arguments.Add(ResponseId);
                        command.Options.Add(Include);
                        command.Options.Add(Stream);
                        command.Options.Add(StartingAfter);
                        command.Options.Add(IncludeObfuscation);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var responseId = parseResult.GetRequiredValue(ResponseId);
                        var include = parseResult.GetValue(Include);
                        var stream = parseResult.GetValue(Stream);
                        var startingAfter = parseResult.GetValue(StartingAfter);
                        var includeObfuscation = parseResult.GetValue(IncludeObfuscation);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Responses.GetAModelResponseAsync(
                                    responseId: responseId,
                                    include: include,
                                    stream: stream,
                                    startingAfter: startingAfter,
                                    includeObfuscation: includeObfuscation,
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
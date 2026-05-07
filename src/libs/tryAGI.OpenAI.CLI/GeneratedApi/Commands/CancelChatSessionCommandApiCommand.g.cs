#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class CancelChatSessionCommandApiCommand
{
    private static Argument<string> SessionId { get; } = new(
        name: @"session-id")
    {
        Description = @"Unique identifier for the ChatKit session to cancel.",
    };

    public static Command Create()
    {
        var command = new Command(@"cancel-chat-session", @"Cancel an active ChatKit session and return its most recent metadata.

Cancelling prevents new requests from using the issued client secret.");
                        command.Arguments.Add(SessionId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var sessionId = parseResult.GetRequiredValue(SessionId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.CancelChatSessionAsync(
                                    sessionId: sessionId,
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
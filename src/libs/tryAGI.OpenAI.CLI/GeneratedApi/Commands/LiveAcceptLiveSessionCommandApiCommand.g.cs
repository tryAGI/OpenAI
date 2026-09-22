#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class LiveAcceptLiveSessionCommandApiCommand
{
    private static Argument<string> SessionId { get; } = new(
        name: @"session-id")
    {
        Description = @"Opaque Live session identifier from the creation response or incoming-call webhook. Preserve the returned value unchanged, including its prefix.",
    };

    private static Option<global::tryAGI.OpenAI.LiveCallAcceptSession> Session { get; } = new(
        name: @"--session")
    {
        Description = @"Model and startup configuration for the Live session that answers the incoming SIP call.",
        Required = true,
    };

    public static Command Create()
    {
        var command = new Command(@"accept-live-session", @"Accept call
Accept an incoming SIP call. Supply session with type live, the model, and startup configuration. Before accepting calls, follow the [Live prompting guide](https://developers.openai.com/api/docs/guides/live-prompting) to write frontend conversation instructions and a separate backend prompt. SIP media format is negotiated; omit audio.format.");
                        command.Arguments.Add(SessionId);
                        command.Options.Add(Session);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var sessionId = parseResult.GetRequiredValue(SessionId);
                        var session = parseResult.GetRequiredValue(Session);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Live.AcceptLiveSessionAsync(
                                    sessionId: sessionId,
                                    session: session,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}
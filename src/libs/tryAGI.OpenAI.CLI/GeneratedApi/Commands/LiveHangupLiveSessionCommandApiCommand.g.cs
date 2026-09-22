#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class LiveHangupLiveSessionCommandApiCommand
{
    private static Argument<string> SessionId { get; } = new(
        name: @"session-id")
    {
        Description = @"Opaque Live session identifier from the creation response or incoming-call webhook. Preserve the returned value unchanged, including its prefix.",
    };

    public static Command Create()
    {
        var command = new Command(@"hangup-live-session", @"Hang up session
End a SIP call identified by session_id.");
                        command.Arguments.Add(SessionId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var sessionId = parseResult.GetRequiredValue(SessionId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Live.HangupLiveSessionAsync(
                                    sessionId: sessionId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}
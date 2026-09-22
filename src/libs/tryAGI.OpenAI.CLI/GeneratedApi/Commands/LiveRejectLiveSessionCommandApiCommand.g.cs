#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class LiveRejectLiveSessionCommandApiCommand
{
    private static Argument<string> SessionId { get; } = new(
        name: @"session-id")
    {
        Description = @"Opaque Live session identifier from the creation response or incoming-call webhook. Preserve the returned value unchanged, including its prefix.",
    };

    private static Option<int> StatusCode { get; } = new(
        name: @"--status-code")
    {
        Description = @"SIP rejection status sent to the caller. This field is required.",
        Required = true,
    };

    public static Command Create()
    {
        var command = new Command(@"reject-live-session", @"Reject call
Reject an incoming SIP call. Send a required SIP rejection status_code between 300 and 699.");
                        command.Arguments.Add(SessionId);
                        command.Options.Add(StatusCode);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var sessionId = parseResult.GetRequiredValue(SessionId);
                        var statusCode = parseResult.GetRequiredValue(StatusCode);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Live.RejectLiveSessionAsync(
                                    sessionId: sessionId,
                                    statusCode: statusCode,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}
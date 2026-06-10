#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class RealtimeHangUpCallCommandApiCommand
{
    private static Argument<string> CallId { get; } = new(
        name: @"call-id")
    {
        Description = @"The identifier for the call. For SIP calls, use the value provided in the
[`realtime.call.incoming`](/docs/api-reference/webhook-events/realtime/call/incoming)
webhook. For WebRTC sessions, reuse the call ID returned in the `Location`
header when creating the call with
[`POST /v1/realtime/calls`](/docs/api-reference/realtime/create-call).",
    };

    public static Command Create()
    {
        var command = new Command(@"hang-up-call", @"End an active Realtime API call, whether it was initiated over SIP or
WebRTC.");
                        command.Arguments.Add(CallId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var callId = parseResult.GetRequiredValue(CallId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Realtime.HangUpCallAsync(
                                    callId: callId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}
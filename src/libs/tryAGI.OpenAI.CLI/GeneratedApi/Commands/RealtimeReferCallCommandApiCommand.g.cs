#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class RealtimeReferCallCommandApiCommand
{
    private static Argument<string> CallId { get; } = new(
        name: @"call-id")
    {
        Description = @"The identifier for the call provided in the
[`realtime.call.incoming`](/docs/api-reference/webhook-events/realtime/call/incoming)
webhook.",
    };

    private static Option<string> TargetUri { get; } = new(
        name: @"--target-uri")
    {
        Description = @"URI that should appear in the SIP Refer-To header. Supports values like
`tel:+14155550123` or `sip:agent@example.com`.",
        Required = true,
    };

    public static Command Create()
    {
        var command = new Command(@"refer-call", @"Transfer an active SIP call to a new destination using the SIP REFER verb.");
                        command.Arguments.Add(CallId);
                        command.Options.Add(TargetUri);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var callId = parseResult.GetRequiredValue(CallId);
                        var targetUri = parseResult.GetRequiredValue(TargetUri);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Realtime.ReferCallAsync(
                                    callId: callId,
                                    targetUri: targetUri,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}
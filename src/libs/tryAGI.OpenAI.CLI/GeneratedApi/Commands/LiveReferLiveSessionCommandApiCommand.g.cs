#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class LiveReferLiveSessionCommandApiCommand
{
    private static Argument<string> SessionId { get; } = new(
        name: @"session-id")
    {
        Description = @"Opaque Live session identifier from the creation response or incoming-call webhook. Preserve the returned value unchanged, including its prefix.",
    };

    private static Option<string> TargetUri { get; } = new(
        name: @"--target-uri")
    {
        Description = @"Nonblank URI for the SIP Refer-To header, such as tel:+14155550123 or sip:agent@example.com.",
        Required = true,
    };

    public static Command Create()
    {
        var command = new Command(@"refer-live-session", @"Transfer call
Transfer a SIP call to another destination. Supply a nonblank target_uri for the SIP Refer-To header.");
                        command.Arguments.Add(SessionId);
                        command.Options.Add(TargetUri);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var sessionId = parseResult.GetRequiredValue(SessionId);
                        var targetUri = parseResult.GetRequiredValue(TargetUri);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Live.ReferLiveSessionAsync(
                                    sessionId: sessionId,
                                    targetUri: targetUri,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}
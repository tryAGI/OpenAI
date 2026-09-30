#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class LiveCreateLiveCommandApiCommand
{
    private static Option<global::tryAGI.OpenAI.LiveMediaSessionCreateParams> Session { get; } = new(
        name: @"--session")
    {
        Description = @"Startup configuration for the Live session.",
        Required = true,
    };

    private static Option<global::tryAGI.OpenAI.Transport> Transport { get; } = new(
        name: @"--transport")
    {
        Description = @"WebRTC transport with an SDP offer, or SIP transport with a destination and per-call trunk credentials.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.LiveSessionCreateResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.LiveSessionCreateResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-live", @"Create session
Create a Live WebRTC session or place an outbound SIP call. Start with the
[Live prompting guide](https://developers.openai.com/api/docs/guides/live-prompting) for session configuration
and [Telephony and SIP](https://developers.openai.com/api/docs/guides/voice-sip?api=live#place-an-outbound-call)
for trunk setup and call monitoring.

Set transport.type to `webrtc` and supply an SDP offer, or set it to `sip`
and supply an E.164 destination and trunk credentials. Outbound SIP calling
must be enabled for your organization.
Ringing is limited to 3 minutes and connected calls to 2 hours; these limits
are not configurable in the request.

Returns `201 Created` after session initialization. WebRTC responses include an
SDP answer. SIP responses do not wait for the callee to answer. Attach a
sideband connection using session.id to monitor SIP call progress.

Each SIP request creates a new call. If a request times out or the connection
fails, retry with caution: the original request may have succeeded, and a
retry can place another call.");
                        command.Options.Add(Session);
                        command.Options.Add(Transport);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var session = parseResult.GetRequiredValue(Session);
                        var transport = parseResult.GetRequiredValue(Transport);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Live.CreateLiveAsync(
                                    session: session,
                                    transport: transport,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}
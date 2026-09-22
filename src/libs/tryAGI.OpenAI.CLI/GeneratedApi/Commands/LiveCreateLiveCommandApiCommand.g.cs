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
    private static readonly LiveWebRTCTransportOptionSet TransportOptions = LiveWebRTCTransportOptionSet.Create(@"transport");

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.LiveCreateResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.LiveCreateResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-live", @"Create session
Create a Live WebRTC session. Start with the [Live prompting guide](https://developers.openai.com/api/docs/guides/live-prompting).");
                        command.Options.Add(Session);                        command.Options.Add(TransportOptions.Type);
                        command.Options.Add(TransportOptions.Sdp);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var session = parseResult.GetRequiredValue(Session);
	                        var transportType = parseResult.GetValue(TransportOptions.Type);
                        var transportSdp = parseResult.GetValue(TransportOptions.Sdp);
                        var __TransportSpecified = CliRuntime.WasSpecified(parseResult, TransportOptions.Type) || CliRuntime.WasSpecified(parseResult, TransportOptions.Sdp);
                        var transport =
                            __TransportSpecified || false
                                ? new global::tryAGI.OpenAI.LiveWebRTCTransport
                                {
	                                Type = transportType,
                                Sdp = transportSdp!,

                                }
                                : null;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Live.CreateLiveAsync(
                                    session: session,
                                    transport: transport!,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}
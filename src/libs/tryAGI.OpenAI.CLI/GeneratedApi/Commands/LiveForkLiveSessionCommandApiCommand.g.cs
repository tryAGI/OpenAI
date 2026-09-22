#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class LiveForkLiveSessionCommandApiCommand
{
    private static Argument<string> SessionId { get; } = new(
        name: @"session-id")
    {
        Description = @"The ID of the stored Live session to fork.",
    };

    private static Option<global::tryAGI.OpenAI.LiveMediaSessionForkParams?> Session { get; } = new(
        name: @"--session")
    {
        Description = @"Optional configuration overrides for the new Live session. Omit this object or send an empty object to inherit the stored session's settings.",
    };
    private static readonly LiveWebRTCTransportOptionSet TransportOptions = LiveWebRTCTransportOptionSet.Create(@"transport");
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

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
        var command = new Command(@"fork-live-session", @"Fork session
Fork a stored Live session onto a new WebRTC connection.");
                        command.Arguments.Add(SessionId);
                        command.Options.Add(Session);                        command.Options.Add(TransportOptions.Type);
                        command.Options.Add(TransportOptions.Sdp);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.LiveForkRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var sessionId = parseResult.GetRequiredValue(SessionId);
                        var session = CliRuntime.WasSpecified(parseResult, Session) ? parseResult.GetValue(Session) : (__requestBase is { } __SessionBaseValue ? __SessionBaseValue.Session : default);

                        var __TransportBase = __requestBase is { } __TransportBaseValue ? __TransportBaseValue.Transport : default;                        var transportType = CliRuntime.WasSpecified(parseResult, TransportOptions.Type) ? parseResult.GetValue(TransportOptions.Type) : (__TransportBase is { } __TransporttypeBaseValue ? __TransporttypeBaseValue.Type : default);
                        var transportSdp = parseResult.GetValue(TransportOptions.Sdp);
                        var __TransportSpecified = CliRuntime.WasSpecified(parseResult, TransportOptions.Type) || CliRuntime.WasSpecified(parseResult, TransportOptions.Sdp);
                        var transport =
                            __TransportSpecified || __TransportBase is not null
                                ? new global::tryAGI.OpenAI.LiveWebRTCTransport
                                {
	                                Type = transportType,
                                Sdp = transportSdp!,

                                }
                                : __TransportBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Live.ForkLiveSessionAsync(
                                    sessionId: sessionId,
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
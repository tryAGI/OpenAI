#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class RealtimeCreateTranscriptionSessionCommandApiCommand
{
    private static Option<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestTurnDetection?> TurnDetection { get; } = new(
        name: @"--turn-detection")
    {
        Description = @"Configuration for turn detection. Can be set to `null` to turn off. Server VAD means that the model will detect the start and end of speech based on audio volume and respond at the end of user speech.
",
    };

    private static Option<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReduction?> InputAudioNoiseReduction { get; } = new(
        name: @"--input-audio-noise-reduction")
    {
        Description = @"Configuration for input audio noise reduction. This can be set to `null` to turn off.
Noise reduction filters audio added to the input audio buffer before it is sent to VAD and the model.
Filtering the audio can improve VAD and turn detection accuracy (reducing false positives) and model performance by improving perception of the input audio.
",
    };

    private static Option<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestInputAudioFormat?> InputAudioFormat { get; } = new(
        name: @"--input-audio-format")
    {
        Description = @"The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.
For `pcm16`, input audio must be 16-bit PCM at a 24kHz sample rate,
single channel (mono), and little-endian byte order.
",
    };

    private static Option<global::tryAGI.OpenAI.AudioTranscription?> InputAudioTranscription { get; } = new(
        name: @"--input-audio-transcription")
    {
        Description = @"Configuration for input audio transcription. The client can optionally set the language and prompt for transcription, these offer additional guidance to the transcription service.
",
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestIncludeItem>?> Include { get; } = new(
        name: @"--include")
    {
        Description = @"The set of items to include in the transcription. Current available items are:
`item.input_audio_transcription.logprobs`
",
    };
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-transcription-session", @"Create an ephemeral API token for use in client-side applications with the
Realtime API specifically for realtime transcriptions.
Can be configured with the same session parameters as the `transcription_session.update` client event.

It responds with a session object, plus a `client_secret` key which contains
a usable ephemeral API token that can be used to authenticate browser clients
for the Realtime API.

Returns the created Realtime transcription session object, plus an ephemeral key.
");
                        command.Options.Add(TurnDetection);
                        command.Options.Add(InputAudioNoiseReduction);
                        command.Options.Add(InputAudioFormat);
                        command.Options.Add(InputAudioTranscription);
                        command.Options.Add(Include);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var turnDetection = CliRuntime.WasSpecified(parseResult, TurnDetection) ? parseResult.GetValue(TurnDetection) : __requestBase is not null ? __requestBase.TurnDetection : default;
                        var inputAudioNoiseReduction = CliRuntime.WasSpecified(parseResult, InputAudioNoiseReduction) ? parseResult.GetValue(InputAudioNoiseReduction) : __requestBase is not null ? __requestBase.InputAudioNoiseReduction : default;
                        var inputAudioFormat = CliRuntime.WasSpecified(parseResult, InputAudioFormat) ? parseResult.GetValue(InputAudioFormat) : __requestBase is not null ? __requestBase.InputAudioFormat : default;
                        var inputAudioTranscription = CliRuntime.WasSpecified(parseResult, InputAudioTranscription) ? parseResult.GetValue(InputAudioTranscription) : __requestBase is not null ? __requestBase.InputAudioTranscription : default;
                        var include = CliRuntime.WasSpecified(parseResult, Include) ? parseResult.GetValue(Include) : __requestBase is not null ? __requestBase.Include : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Realtime.CreateTranscriptionSessionAsync(
                                    turnDetection: turnDetection,
                                    inputAudioNoiseReduction: inputAudioNoiseReduction,
                                    inputAudioFormat: inputAudioFormat,
                                    inputAudioTranscription: inputAudioTranscription,
                                    include: include,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                        @"Modalities",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}
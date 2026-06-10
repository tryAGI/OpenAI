#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class AudioCreateSpeechCommandApiCommand
{
    private static Option<global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateSpeechRequestModel?>> Model { get; } = new(
        name: @"--model")
    {
        Description = @"One of the available [TTS models](/docs/models#tts): `tts-1`, `tts-1-hd`, `gpt-4o-mini-tts`, or `gpt-4o-mini-tts-2025-12-15`.
",
        Required = true,
    };

    private static Option<string> Input { get; } = new(
        name: @"--input")
    {
        Description = @"The text to generate audio for. The maximum length is 4096 characters.",
        Required = true,
    };

    private static Option<string?> Instructions { get; } = new(
        name: @"--instructions")
    {
        Description = @"Control the voice of your generated audio with additional instructions. Does not work with `tts-1` or `tts-1-hd`.",
    };

    private static Option<global::tryAGI.OpenAI.VoiceIdsOrCustomVoice> Voice { get; } = new(
        name: @"--voice")
    {
        Description = @"The voice to use when generating the audio. Supported built-in voices are `alloy`, `ash`, `ballad`, `coral`, `echo`, `fable`, `onyx`, `nova`, `sage`, `shimmer`, `verse`, `marin`, and `cedar`. You may also provide a custom voice object with an `id`, for example `{ ""id"": ""voice_1234"" }`. Previews of the voices are available in the [Text to speech guide](/docs/guides/text-to-speech#voice-options).",
        Required = true,
    };

    private static Option<global::tryAGI.OpenAI.CreateSpeechRequestResponseFormat?> ResponseFormat { get; } = new(
        name: @"--response-format")
    {
        Description = @"The format to audio in. Supported formats are `mp3`, `opus`, `aac`, `flac`, `wav`, and `pcm`.",
    };

    private static Option<double?> Speed { get; } = new(
        name: @"--speed")
    {
        Description = @"The speed of the generated audio. Select a value from `0.25` to `4.0`. `1.0` is the default.",
    };

    private static Option<global::tryAGI.OpenAI.CreateSpeechRequestStreamFormat?> StreamFormat { get; } = new(
        name: @"--stream-format")
    {
        Description = @"The format to stream the audio in. Supported formats are `sse` and `audio`. `sse` is not supported for `tts-1` or `tts-1-hd`.",
    };
      private static Option<string?> Input { get; } = new("--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new("--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new("--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

    public static Command Create()
    {
        var command = new Command(@"create-speech", @"Generates audio from the input text.

Returns the audio file content, or a stream of audio events.
");
                        command.Options.Add(Model);
                        command.Options.Add(Input);
                        command.Options.Add(Instructions);
                        command.Options.Add(Voice);
                        command.Options.Add(ResponseFormat);
                        command.Options.Add(Speed);
                        command.Options.Add(StreamFormat);
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
                  result.AddError("Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.CreateSpeechRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var model = parseResult.GetRequiredValue(Model);
                        var input = parseResult.GetRequiredValue(Input);
                        var instructions = parseResult.GetValue(Instructions) ?? __requestBase?.Instructions;
                        var voice = parseResult.GetRequiredValue(Voice);
                        var responseFormat = parseResult.GetValue(ResponseFormat) ?? __requestBase?.ResponseFormat;
                        var speed = parseResult.GetValue(Speed) ?? __requestBase?.Speed;
                        var streamFormat = parseResult.GetValue(StreamFormat) ?? __requestBase?.StreamFormat;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = client.Audio.CreateSpeechAsync(
                                    model: model,
                                    input: input,
                                    instructions: instructions,
                                    voice: voice,
                                    responseFormat: responseFormat,
                                    speed: speed,
                                    streamFormat: streamFormat,
                                    cancellationToken: cancellationToken);

                                await foreach (var item in response.WithCancellation(cancellationToken).ConfigureAwait(false))
                                {
                                    await CliRuntime.WriteResponseLineAsync(
                                        parseResult,
                                        item,
                                        global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                        cancellationToken: cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}
#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class AudioCreateSpeechAsEventStreamCommandApiCommand
{
    private static Option<global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateSpeechRequestModel?>> Model { get; } = new(
        name: @"--model")
    {
        Description = @"One of the available [TTS models](/docs/models#tts): `tts-1`, `tts-1-hd`, `gpt-4o-mini-tts`, or `gpt-4o-mini-tts-2025-12-15`.
",
        Required = true,
    };

    private static Option<global::tryAGI.OpenAI.VoiceIdsOrCustomVoice> Voice { get; } = new(
        name: @"--voice")
    {
        Description = @"The voice to use when generating the audio. Supported built-in voices are `alloy`, `ash`, `ballad`, `coral`, `echo`, `fable`, `onyx`, `nova`, `sage`, `shimmer`, `verse`, `marin`, and `cedar`. You may also provide a custom voice object with an `id`, for example `{ ""id"": ""voice_1234"" }`. Previews of the voices are available in the [Text to speech guide](/docs/guides/text-to-speech#voice-options).",
        Required = true,
    };
    private static readonly CreateSpeechRequestOptionSet CreateSpeechRequestOptionSetOptions = CreateSpeechRequestOptionSet.Create();
      private static Option<string?> RequestInput { get; } = new(@"--request-input")
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

    public static Command Create()
    {
        var command = new Command(@"create-speech-as-event-stream", @"Generates audio from the input text.

Returns the audio file content, or a stream of audio events.
");
                        command.Options.Add(Model);
                        command.Options.Add(Voice);                        command.Options.Add(CreateSpeechRequestOptionSetOptions.InputOption);
                        command.Options.Add(CreateSpeechRequestOptionSetOptions.Instructions);
                        command.Options.Add(CreateSpeechRequestOptionSetOptions.ResponseFormat);
                        command.Options.Add(CreateSpeechRequestOptionSetOptions.Speed);
                        command.Options.Add(CreateSpeechRequestOptionSetOptions.StreamFormat);
          command.Options.Add(RequestInput);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(RequestInput) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --request-input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.CreateSpeechRequest>(
                            parseResult,
                            RequestInput,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var model = parseResult.GetRequiredValue(Model);
                        var voice = parseResult.GetRequiredValue(Voice);                        var input = parseResult.GetRequiredValue(CreateSpeechRequestOptionSetOptions.InputOption);
                        var instructions = CliRuntime.WasSpecified(parseResult, CreateSpeechRequestOptionSetOptions.Instructions) ? parseResult.GetValue(CreateSpeechRequestOptionSetOptions.Instructions) : (__requestBase is { } __InstructionsBaseValue ? __InstructionsBaseValue.Instructions : default);
                        var responseFormat = CliRuntime.WasSpecified(parseResult, CreateSpeechRequestOptionSetOptions.ResponseFormat) ? parseResult.GetValue(CreateSpeechRequestOptionSetOptions.ResponseFormat) : (__requestBase is { } __ResponseFormatBaseValue ? __ResponseFormatBaseValue.ResponseFormat : default);
                        var speed = CliRuntime.WasSpecified(parseResult, CreateSpeechRequestOptionSetOptions.Speed) ? parseResult.GetValue(CreateSpeechRequestOptionSetOptions.Speed) : (__requestBase is { } __SpeedBaseValue ? __SpeedBaseValue.Speed : default);
                        var streamFormat = CliRuntime.WasSpecified(parseResult, CreateSpeechRequestOptionSetOptions.StreamFormat) ? parseResult.GetValue(CreateSpeechRequestOptionSetOptions.StreamFormat) : (__requestBase is { } __StreamFormatBaseValue ? __StreamFormatBaseValue.StreamFormat : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = client.Audio.CreateSpeechAsEventStreamAsync(
                                    model: model,
                                    voice: voice,
                                    input: input,
                                    instructions: instructions,
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
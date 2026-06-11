#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class AudioCreateTranscriptionCommandApiCommand
{
    private static Option<byte[]> File { get; } = new(
        name: @"--file")
    {
        Description = @"The audio file object (not file name) to transcribe, in one of these formats: flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, or webm.
",
        Required = true,
    };

    private static Option<global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateTranscriptionRequestModel?>> Model { get; } = new(
        name: @"--model")
    {
        Description = @"ID of the model to use. The options are `gpt-4o-transcribe`, `gpt-4o-mini-transcribe`, `gpt-4o-mini-transcribe-2025-12-15`, `whisper-1` (which is powered by our open source Whisper V2 model), and `gpt-4o-transcribe-diarize`.
",
        Required = true,
    };

    private static Option<global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.CreateTranscriptionRequestChunkingStrategyVariant1?, global::tryAGI.OpenAI.VadConfig>?> ChunkingStrategy { get; } = new(
        name: @"--chunking-strategy")
    {
        Description = @"",
    };
    private static readonly CreateTranscriptionRequestOptionSet CreateTranscriptionRequestOptionSetOptions = CreateTranscriptionRequestOptionSet.Create();
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateTranscriptionResponseJson, global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJson, global::tryAGI.OpenAI.CreateTranscriptionResponseVerboseJson> value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateTranscriptionResponseJson, global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJson, global::tryAGI.OpenAI.CreateTranscriptionResponseVerboseJson> value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-transcription", @"Transcribes audio into the input language.

Returns a transcription object in `json`, `diarized_json`, or `verbose_json`
format, or a stream of transcript events.
");
                        command.Options.Add(File);
                        command.Options.Add(Model);
                        command.Options.Add(ChunkingStrategy);                        command.Options.Add(CreateTranscriptionRequestOptionSetOptions.Filename);
                        command.Options.Add(CreateTranscriptionRequestOptionSetOptions.Language);
                        command.Options.Add(CreateTranscriptionRequestOptionSetOptions.Prompt);
                        command.Options.Add(CreateTranscriptionRequestOptionSetOptions.ResponseFormat);
                        command.Options.Add(CreateTranscriptionRequestOptionSetOptions.Temperature);
                        command.Options.Add(CreateTranscriptionRequestOptionSetOptions.Include);
                        command.Options.Add(CreateTranscriptionRequestOptionSetOptions.TimestampGranularities);
                        command.Options.Add(CreateTranscriptionRequestOptionSetOptions.KnownSpeakerNames);
                        command.Options.Add(CreateTranscriptionRequestOptionSetOptions.KnownSpeakerReferences);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.CreateTranscriptionRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var file = parseResult.GetRequiredValue(File);
                        var model = parseResult.GetRequiredValue(Model);
                        var chunkingStrategy = CliRuntime.WasSpecified(parseResult, ChunkingStrategy) ? parseResult.GetValue(ChunkingStrategy) : __requestBase is not null ? __requestBase.ChunkingStrategy : default;                        var filename = parseResult.GetRequiredValue(CreateTranscriptionRequestOptionSetOptions.Filename);
                        var language = CliRuntime.WasSpecified(parseResult, CreateTranscriptionRequestOptionSetOptions.Language) ? parseResult.GetValue(CreateTranscriptionRequestOptionSetOptions.Language) : __requestBase is not null ? __requestBase.Language : default;
                        var prompt = CliRuntime.WasSpecified(parseResult, CreateTranscriptionRequestOptionSetOptions.Prompt) ? parseResult.GetValue(CreateTranscriptionRequestOptionSetOptions.Prompt) : __requestBase is not null ? __requestBase.Prompt : default;
                        var responseFormat = CliRuntime.WasSpecified(parseResult, CreateTranscriptionRequestOptionSetOptions.ResponseFormat) ? parseResult.GetValue(CreateTranscriptionRequestOptionSetOptions.ResponseFormat) : __requestBase is not null ? __requestBase.ResponseFormat : default;
                        var temperature = CliRuntime.WasSpecified(parseResult, CreateTranscriptionRequestOptionSetOptions.Temperature) ? parseResult.GetValue(CreateTranscriptionRequestOptionSetOptions.Temperature) : __requestBase is not null ? __requestBase.Temperature : default;
                        var include = CliRuntime.WasSpecified(parseResult, CreateTranscriptionRequestOptionSetOptions.Include) ? parseResult.GetValue(CreateTranscriptionRequestOptionSetOptions.Include) : __requestBase is not null ? __requestBase.Include : default;
                        var timestampGranularities = CliRuntime.WasSpecified(parseResult, CreateTranscriptionRequestOptionSetOptions.TimestampGranularities) ? parseResult.GetValue(CreateTranscriptionRequestOptionSetOptions.TimestampGranularities) : __requestBase is not null ? __requestBase.TimestampGranularities : default;
                        var knownSpeakerNames = CliRuntime.WasSpecified(parseResult, CreateTranscriptionRequestOptionSetOptions.KnownSpeakerNames) ? parseResult.GetValue(CreateTranscriptionRequestOptionSetOptions.KnownSpeakerNames) : __requestBase is not null ? __requestBase.KnownSpeakerNames : default;
                        var knownSpeakerReferences = CliRuntime.WasSpecified(parseResult, CreateTranscriptionRequestOptionSetOptions.KnownSpeakerReferences) ? parseResult.GetValue(CreateTranscriptionRequestOptionSetOptions.KnownSpeakerReferences) : __requestBase is not null ? __requestBase.KnownSpeakerReferences : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Audio.CreateTranscriptionAsync(
                                    file: file,
                                    model: model,
                                    chunkingStrategy: chunkingStrategy,
                                    filename: filename,
                                    language: language,
                                    prompt: prompt,
                                    responseFormat: responseFormat,
                                    temperature: temperature,
                                    include: include,
                                    timestampGranularities: timestampGranularities,
                                    knownSpeakerNames: knownSpeakerNames,
                                    knownSpeakerReferences: knownSpeakerReferences,
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
#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class AudioCreateTranslationCommandApiCommand
{
    private static Option<byte[]> File { get; } = new(
        name: @"--file")
    {
        Description = @"The audio file object (not file name) translate, in one of these formats: flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, or webm.
",
        Required = true,
    };

    private static Option<string> Filename { get; } = new(
        name: @"--filename")
    {
        Description = @"The audio file object (not file name) translate, in one of these formats: flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, or webm.
",
        Required = true,
    };

    private static Option<global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateTranslationRequestModel?>> Model { get; } = new(
        name: @"--model")
    {
        Description = @"ID of the model to use. Only `whisper-1` (which is powered by our open source Whisper V2 model) is currently available.
",
        Required = true,
    };

    private static Option<string?> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"An optional text to guide the model's style or continue a previous audio segment. The [prompt](/docs/guides/speech-to-text#prompting) should be in English.
",
    };

    private static Option<global::tryAGI.OpenAI.CreateTranslationRequestResponseFormat?> ResponseFormat { get; } = new(
        name: @"--response-format")
    {
        Description = @"The format of the output, in one of these options: `json`, `text`, `srt`, `verbose_json`, or `vtt`.
",
    };

    private static Option<double?> Temperature { get; } = new(
        name: @"--temperature")
    {
        Description = @"The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateTranslationResponseJson, global::tryAGI.OpenAI.CreateTranslationResponseVerboseJson> value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateTranslationResponseJson, global::tryAGI.OpenAI.CreateTranslationResponseVerboseJson> value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-translation", @"Translates audio into English.");
                        command.Options.Add(File);
                        command.Options.Add(Filename);
                        command.Options.Add(Model);
                        command.Options.Add(Prompt);
                        command.Options.Add(ResponseFormat);
                        command.Options.Add(Temperature);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.CreateTranslationRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var file = parseResult.GetRequiredValue(File);
                        var filename = parseResult.GetRequiredValue(Filename);
                        var model = parseResult.GetRequiredValue(Model);
                        var prompt = CliRuntime.WasSpecified(parseResult, Prompt) ? parseResult.GetValue(Prompt) : (__requestBase is { } __PromptBaseValue ? __PromptBaseValue.Prompt : default);
                        var responseFormat = CliRuntime.WasSpecified(parseResult, ResponseFormat) ? parseResult.GetValue(ResponseFormat) : (__requestBase is { } __ResponseFormatBaseValue ? __ResponseFormatBaseValue.ResponseFormat : default);
                        var temperature = CliRuntime.WasSpecified(parseResult, Temperature) ? parseResult.GetValue(Temperature) : (__requestBase is { } __TemperatureBaseValue ? __TemperatureBaseValue.Temperature : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Audio.CreateTranslationAsync(
                                    file: file,
                                    filename: filename,
                                    model: model,
                                    prompt: prompt,
                                    responseFormat: responseFormat,
                                    temperature: temperature,
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
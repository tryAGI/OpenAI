#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class VideosCreateVideoCommandApiCommand
{
    private static Option<global::tryAGI.OpenAI.VideoModel?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"The video generation model to use (allowed values: sora-2, sora-2-pro). Defaults to `sora-2`.",
    };

    private static Option<string> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"Text prompt that describes the video to generate.",
        Required = true,
    };

    private static Option<global::tryAGI.OpenAI.OneOf<byte[], global::tryAGI.OpenAI.ImageRefParam2>?> InputReference { get; } = new(
        name: @"--input-reference")
    {
        Description = @"",
    };

    private static Option<global::tryAGI.OpenAI.VideoSeconds?> Seconds { get; } = new(
        name: @"--seconds")
    {
        Description = @"Clip duration in seconds (allowed values: 4, 8, 12). Defaults to 4 seconds.",
    };

    private static Option<global::tryAGI.OpenAI.VideoSize?> Size { get; } = new(
        name: @"--size")
    {
        Description = @"Output resolution formatted as width x height (allowed values: 720x1280, 1280x720, 1024x1792, 1792x1024). Defaults to 720x1280.",
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.VideoResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.VideoResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-video", @"Create a new video generation job from a prompt and optional reference assets.");
                        command.Options.Add(Model);
                        command.Options.Add(Prompt);
                        command.Options.Add(InputReference);
                        command.Options.Add(Seconds);
                        command.Options.Add(Size);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.CreateVideoMultipartBody>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : __requestBase is not null ? __requestBase.Model : default;
                        var prompt = parseResult.GetRequiredValue(Prompt);
                        var inputReference = CliRuntime.WasSpecified(parseResult, InputReference) ? parseResult.GetValue(InputReference) : __requestBase is not null ? __requestBase.InputReference : default;
                        var seconds = CliRuntime.WasSpecified(parseResult, Seconds) ? parseResult.GetValue(Seconds) : __requestBase is not null ? __requestBase.Seconds : default;
                        var size = CliRuntime.WasSpecified(parseResult, Size) ? parseResult.GetValue(Size) : __requestBase is not null ? __requestBase.Size : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Videos.CreateVideoAsync(
                                    model: model,
                                    prompt: prompt,
                                    inputReference: inputReference,
                                    seconds: seconds,
                                    size: size,
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
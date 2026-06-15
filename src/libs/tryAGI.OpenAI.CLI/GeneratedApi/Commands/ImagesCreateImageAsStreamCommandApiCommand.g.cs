#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class ImagesCreateImageAsStreamCommandApiCommand
{
    private static Option<global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageRequestModel?>?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"The model to use for image generation. One of `dall-e-2`, `dall-e-3`, or a GPT image model (`gpt-image-1`, `gpt-image-1-mini`, `gpt-image-1.5`). Defaults to `dall-e-2` unless a parameter specific to the GPT image models is used.",
    };

    private static Option<global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageRequestSize?>?> Size { get; } = new(
        name: @"--size")
    {
        Description = @"The size of the generated images. For `gpt-image-2` and `gpt-image-2-2026-04-21`, arbitrary resolutions are supported as `WIDTHxHEIGHT` strings, for example `1536x864`. Width and height must both be divisible by 16 and the requested aspect ratio must be between 1:3 and 3:1. Resolutions above `2560x1440` are experimental, and the maximum supported resolution is `3840x2160`. The requested size must also satisfy the model's current pixel and edge limits. The standard sizes `1024x1024`, `1536x1024`, and `1024x1536` are supported by the GPT image models; `auto` is supported for models that allow automatic sizing. For `dall-e-2`, use one of `256x256`, `512x512`, or `1024x1024`. For `dall-e-3`, use one of `1024x1024`, `1792x1024`, or `1024x1792`.",
    };
    private static readonly CreateImageRequestOptionSet CreateImageRequestOptionSetOptions = CreateImageRequestOptionSet.Create();
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

    public static Command Create()
    {
        var command = new Command(@"create-image-as-stream", @"Creates an image given a prompt. [Learn more](/docs/guides/images).
");
                        command.Options.Add(Model);
                        command.Options.Add(Size);                        command.Options.Add(CreateImageRequestOptionSetOptions.Prompt);
                        command.Options.Add(CreateImageRequestOptionSetOptions.N);
                        command.Options.Add(CreateImageRequestOptionSetOptions.Quality);
                        command.Options.Add(CreateImageRequestOptionSetOptions.ResponseFormat);
                        command.Options.Add(CreateImageRequestOptionSetOptions.OutputFormat);
                        command.Options.Add(CreateImageRequestOptionSetOptions.OutputCompression);
                        command.Options.Add(CreateImageRequestOptionSetOptions.PartialImages);
                        command.Options.Add(CreateImageRequestOptionSetOptions.Moderation);
                        command.Options.Add(CreateImageRequestOptionSetOptions.Background);
                        command.Options.Add(CreateImageRequestOptionSetOptions.Style);
                        command.Options.Add(CreateImageRequestOptionSetOptions.User);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.CreateImageRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : (__requestBase is { } __ModelBaseValue ? __ModelBaseValue.Model : default);
                        var size = CliRuntime.WasSpecified(parseResult, Size) ? parseResult.GetValue(Size) : (__requestBase is { } __SizeBaseValue ? __SizeBaseValue.Size : default);                        var prompt = parseResult.GetRequiredValue(CreateImageRequestOptionSetOptions.Prompt);
                        var n = CliRuntime.WasSpecified(parseResult, CreateImageRequestOptionSetOptions.N) ? parseResult.GetValue(CreateImageRequestOptionSetOptions.N) : (__requestBase is { } __NBaseValue ? __NBaseValue.N : default);
                        var quality = CliRuntime.WasSpecified(parseResult, CreateImageRequestOptionSetOptions.Quality) ? parseResult.GetValue(CreateImageRequestOptionSetOptions.Quality) : (__requestBase is { } __QualityBaseValue ? __QualityBaseValue.Quality : default);
                        var responseFormat = CliRuntime.WasSpecified(parseResult, CreateImageRequestOptionSetOptions.ResponseFormat) ? parseResult.GetValue(CreateImageRequestOptionSetOptions.ResponseFormat) : (__requestBase is { } __ResponseFormatBaseValue ? __ResponseFormatBaseValue.ResponseFormat : default);
                        var outputFormat = CliRuntime.WasSpecified(parseResult, CreateImageRequestOptionSetOptions.OutputFormat) ? parseResult.GetValue(CreateImageRequestOptionSetOptions.OutputFormat) : (__requestBase is { } __OutputFormatBaseValue ? __OutputFormatBaseValue.OutputFormat : default);
                        var outputCompression = CliRuntime.WasSpecified(parseResult, CreateImageRequestOptionSetOptions.OutputCompression) ? parseResult.GetValue(CreateImageRequestOptionSetOptions.OutputCompression) : (__requestBase is { } __OutputCompressionBaseValue ? __OutputCompressionBaseValue.OutputCompression : default);
                        var partialImages = CliRuntime.WasSpecified(parseResult, CreateImageRequestOptionSetOptions.PartialImages) ? parseResult.GetValue(CreateImageRequestOptionSetOptions.PartialImages) : (__requestBase is { } __PartialImagesBaseValue ? __PartialImagesBaseValue.PartialImages : default);
                        var moderation = CliRuntime.WasSpecified(parseResult, CreateImageRequestOptionSetOptions.Moderation) ? parseResult.GetValue(CreateImageRequestOptionSetOptions.Moderation) : (__requestBase is { } __ModerationBaseValue ? __ModerationBaseValue.Moderation : default);
                        var background = CliRuntime.WasSpecified(parseResult, CreateImageRequestOptionSetOptions.Background) ? parseResult.GetValue(CreateImageRequestOptionSetOptions.Background) : (__requestBase is { } __BackgroundBaseValue ? __BackgroundBaseValue.Background : default);
                        var style = CliRuntime.WasSpecified(parseResult, CreateImageRequestOptionSetOptions.Style) ? parseResult.GetValue(CreateImageRequestOptionSetOptions.Style) : (__requestBase is { } __StyleBaseValue ? __StyleBaseValue.Style : default);
                        var user = CliRuntime.WasSpecified(parseResult, CreateImageRequestOptionSetOptions.User) ? parseResult.GetValue(CreateImageRequestOptionSetOptions.User) : (__requestBase is { } __UserBaseValue ? __UserBaseValue.User : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = client.Images.CreateImageAsStreamAsync(
                                    model: model,
                                    size: size,
                                    prompt: prompt,
                                    n: n,
                                    quality: quality,
                                    responseFormat: responseFormat,
                                    outputFormat: outputFormat,
                                    outputCompression: outputCompression,
                                    partialImages: partialImages,
                                    moderation: moderation,
                                    background: background,
                                    style: style,
                                    user: user,
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
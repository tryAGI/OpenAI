#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class ImagesCreateImageEditCommandApiCommand
{
    private static Option<global::tryAGI.OpenAI.AnyOf<byte[], global::System.Collections.Generic.IList<byte[]>>> Image { get; } = new(
        name: @"--image")
    {
        Description = @"The image(s) to edit. Must be a supported image file or an array of images.

For the GPT image models (`gpt-image-1`, `gpt-image-1-mini`, and `gpt-image-1.5`), each image should be a `png`, `webp`, or `jpg`
file less than 50MB. You can provide up to 16 images.
`chatgpt-image-latest` follows the same input constraints as GPT image models.

For `dall-e-2`, you can only provide one image, and it should be a square
`png` file less than 4MB.
",
        Required = true,
    };

    private static Option<byte[]?> Mask { get; } = new(
        name: @"--mask")
    {
        Description = @"An additional image whose fully transparent areas (e.g. where alpha is zero) indicate where `image` should be edited. If there are multiple images provided, the mask will be applied on the first image. Must be a valid PNG file, less than 4MB, and have the same dimensions as `image`.",
    };

    private static Option<global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageEditRequestModel?>?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"The model to use for image generation. Defaults to `gpt-image-1.5`.",
    };

    private static Option<global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageEditRequestSize?>?> Size { get; } = new(
        name: @"--size")
    {
        Description = @"The size of the generated images. For `gpt-image-2` and `gpt-image-2-2026-04-21`, arbitrary resolutions are supported as `WIDTHxHEIGHT` strings, for example `1536x864`. Width and height must both be divisible by 16 and the requested aspect ratio must be between 1:3 and 3:1. Resolutions above `2560x1440` are experimental, and the maximum supported resolution is `3840x2160`. The requested size must also satisfy the model's current pixel and edge limits. The standard sizes `1024x1024`, `1536x1024`, and `1024x1536` are supported by the GPT image models; `auto` is supported for models that allow automatic sizing. For `dall-e-2`, use one of `256x256`, `512x512`, or `1024x1024`. For `dall-e-3`, use one of `1024x1024`, `1792x1024`, or `1024x1792`.",
    };

    private static Option<global::tryAGI.OpenAI.InputFidelity?> InputFidelity { get; } = new(
        name: @"--input-fidelity")
    {
        Description = @"",
    };
    private static readonly CreateImageEditRequestOptionSet CreateImageEditRequestOptionSetOptions = CreateImageEditRequestOptionSet.Create();
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.ImagesResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.ImagesResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-image-edit", @"Creates an edited or extended image given one or more source images and a prompt. This endpoint supports GPT Image models (`gpt-image-1.5`, `gpt-image-1`, `gpt-image-1-mini`, and `chatgpt-image-latest`) and `dall-e-2`.
You can call this endpoint with either:

- `multipart/form-data`: use binary uploads via `image` (and optional `mask`).
- `application/json`: use `images` (and optional `mask`) as references with either `image_url` or `file_id`.

Note that JSON requests use `images` (array) instead of the multipart `image` field.
");
                        command.Options.Add(Image);
                        command.Options.Add(Mask);
                        command.Options.Add(Model);
                        command.Options.Add(Size);
                        command.Options.Add(InputFidelity);                        command.Options.Add(CreateImageEditRequestOptionSetOptions.Prompt);
                        command.Options.Add(CreateImageEditRequestOptionSetOptions.Maskname);
                        command.Options.Add(CreateImageEditRequestOptionSetOptions.Background);
                        command.Options.Add(CreateImageEditRequestOptionSetOptions.N);
                        command.Options.Add(CreateImageEditRequestOptionSetOptions.ResponseFormat);
                        command.Options.Add(CreateImageEditRequestOptionSetOptions.OutputFormat);
                        command.Options.Add(CreateImageEditRequestOptionSetOptions.OutputCompression);
                        command.Options.Add(CreateImageEditRequestOptionSetOptions.User);
                        command.Options.Add(CreateImageEditRequestOptionSetOptions.Stream);
                        command.Options.Add(CreateImageEditRequestOptionSetOptions.PartialImages);
                        command.Options.Add(CreateImageEditRequestOptionSetOptions.Quality);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.CreateImageEditRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var image = parseResult.GetRequiredValue(Image);
                        var mask = parseResult.GetValue(Mask) ?? __requestBase?.Mask;
                        var model = parseResult.GetValue(Model) ?? __requestBase?.Model;
                        var size = parseResult.GetValue(Size) ?? __requestBase?.Size;
                        var inputFidelity = parseResult.GetValue(InputFidelity) ?? __requestBase?.InputFidelity;                        var prompt = parseResult.GetRequiredValue(CreateImageEditRequestOptionSetOptions.Prompt);
                        var maskname = parseResult.GetValue(CreateImageEditRequestOptionSetOptions.Maskname) ?? __requestBase?.Maskname;
                        var background = parseResult.GetValue(CreateImageEditRequestOptionSetOptions.Background) ?? __requestBase?.Background;
                        var n = parseResult.GetValue(CreateImageEditRequestOptionSetOptions.N) ?? __requestBase?.N;
                        var responseFormat = parseResult.GetValue(CreateImageEditRequestOptionSetOptions.ResponseFormat) ?? __requestBase?.ResponseFormat;
                        var outputFormat = parseResult.GetValue(CreateImageEditRequestOptionSetOptions.OutputFormat) ?? __requestBase?.OutputFormat;
                        var outputCompression = parseResult.GetValue(CreateImageEditRequestOptionSetOptions.OutputCompression) ?? __requestBase?.OutputCompression;
                        var user = parseResult.GetValue(CreateImageEditRequestOptionSetOptions.User) ?? __requestBase?.User;
                        var stream = parseResult.GetValue(CreateImageEditRequestOptionSetOptions.Stream) ?? __requestBase?.Stream;
                        var partialImages = parseResult.GetValue(CreateImageEditRequestOptionSetOptions.PartialImages) ?? __requestBase?.PartialImages;
                        var quality = parseResult.GetValue(CreateImageEditRequestOptionSetOptions.Quality) ?? __requestBase?.Quality;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Images.CreateImageEditAsync(
                                    image: image,
                                    mask: mask,
                                    model: model,
                                    size: size,
                                    inputFidelity: inputFidelity,
                                    prompt: prompt,
                                    maskname: maskname,
                                    background: background,
                                    n: n,
                                    responseFormat: responseFormat,
                                    outputFormat: outputFormat,
                                    outputCompression: outputCompression,
                                    user: user,
                                    stream: stream,
                                    partialImages: partialImages,
                                    quality: quality,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                        @"Data",
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
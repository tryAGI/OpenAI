#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class ImagesCreateImageEditAsStreamCommandApiCommand
{
    private static Option<global::tryAGI.OpenAI.AnyOf<byte[], global::System.Collections.Generic.IList<byte[]>>> Image { get; } = new(
        name: @"--image")
    {
        Description = @"The image(s) to edit. Must be a supported image file or an array of images.

For the GPT image models (`gpt-image-1`, `gpt-image-1-mini`, `gpt-image-1.5`,
`gpt-image-2`, `gpt-image-2-2026-04-21`, `gpt-image-2.5-sunburst`,
`gpt-image-2.5-sunburst-2026-09-08`, `gpt-image-2.5-flare`, and
`gpt-image-2.5-flare-2026-09-08`), each image should be a `png`, `webp`, or `jpg`
file less than 50MB. You can provide up to 16 images. `chatgpt-image-latest`
follows the same input constraints as GPT image models.
",
        Required = true,
    };

    private static Option<byte[]?> Mask { get; } = new(
        name: @"--mask")
    {
        Description = @"An additional image whose fully transparent areas (e.g. where alpha is zero) indicate where `image` should be edited. If there are multiple images provided, the mask will be applied on the first image. Must be a valid PNG file, less than 4MB, and have the same dimensions as `image`.",
    };

    private static Option<global::tryAGI.OpenAI.CreateImageEditRequestBackground?> Background { get; } = new(
        name: @"--background")
    {
        Description = @"Set the background of the generated image(s). This parameter is only supported for
the GPT image models. Must be one of `transparent`, `opaque`, or `auto` (default
value). When `auto` is used, the model will automatically determine the best
background for the image.

`gpt-image-2.5-sunburst` and `gpt-image-2.5-flare`, including their `2026-09-08`
snapshots, support `opaque` and `transparent` backgrounds. Transparent backgrounds
are available for supported GPT Image models. For `gpt-image-2` and
`gpt-image-2-2026-04-21`, this support is in preview. When using `transparent`,
set the output format to `png` or `webp`.
",
    };

    private static Option<global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageEditRequestModel?>> Model { get; } = new(
        name: @"--model")
    {
        Description = @"The GPT image model to use for image editing (`gpt-image-1`, `gpt-image-1-mini`, `gpt-image-1.5`, `gpt-image-2`, `gpt-image-2-2026-04-21`, `gpt-image-2.5-sunburst`, `gpt-image-2.5-sunburst-2026-09-08`, `gpt-image-2.5-flare`, `gpt-image-2.5-flare-2026-09-08`, or `chatgpt-image-latest`).",
        Required = true,
    };

    private static Option<global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageEditRequestSize?>?> Size { get; } = new(
        name: @"--size")
    {
        Description = @"The size of the generated images. Defaults to `auto`. For `gpt-image-2`, `gpt-image-2-2026-04-21`, `gpt-image-2.5-sunburst`, `gpt-image-2.5-sunburst-2026-09-08`, `gpt-image-2.5-flare`, and `gpt-image-2.5-flare-2026-09-08`, arbitrary resolutions are supported as `WIDTHxHEIGHT` strings, for example `1536x864`. Width and height must both be divisible by 16 and the requested aspect ratio must be between 1:3 and 3:1. Resolutions above `2560x1440` are experimental, and the maximum supported resolution is `3840x2160`. The requested size must also satisfy the model's current pixel and edge limits. The standard sizes `1024x1024`, `1536x1024`, and `1024x1536` are supported by the GPT image models; `auto` is supported for models that allow automatic sizing.",
    };

    private static Option<global::tryAGI.OpenAI.CreateImageEditRequestOutputFormat?> OutputFormat { get; } = new(
        name: @"--output-format")
    {
        Description = @"The format in which the generated images are returned. This parameter is
only supported for the GPT image models. Must be one of `png`, `jpeg`, or `webp`.
The default value is `png`.
",
    };

    private static Option<global::tryAGI.OpenAI.InputFidelity?> InputFidelity { get; } = new(
        name: @"--input-fidelity")
    {
        Description = @"",
    };

    private static Option<global::tryAGI.OpenAI.CreateImageEditRequestQuality?> Quality { get; } = new(
        name: @"--quality")
    {
        Description = @"The quality of the image that will be generated for GPT image models. The GPT image models support `low`, `medium`, and `high`. `gpt-image-2.5-sunburst` and `gpt-image-2.5-flare`, including their `2026-09-08` snapshots, also support `xhigh` and `max`. Defaults to `auto`.
",
    };
    private static readonly CreateImageEditRequestOptionSet CreateImageEditRequestOptionSetOptions = CreateImageEditRequestOptionSet.Create();
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

    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-image-edit-as-stream", @"Create image edit
Creates an edited or extended image given one or more source images and a prompt. This endpoint supports GPT Image models.");
                        command.Options.Add(Image);
                        command.Options.Add(Mask);
                        command.Options.Add(Background);
                        command.Options.Add(Model);
                        command.Options.Add(Size);
                        command.Options.Add(OutputFormat);
                        command.Options.Add(InputFidelity);
                        command.Options.Add(Quality);                        command.Options.Add(CreateImageEditRequestOptionSetOptions.Prompt);
                        command.Options.Add(CreateImageEditRequestOptionSetOptions.Maskname);
                        command.Options.Add(CreateImageEditRequestOptionSetOptions.N);
                        command.Options.Add(CreateImageEditRequestOptionSetOptions.OutputCompression);
                        command.Options.Add(CreateImageEditRequestOptionSetOptions.User);
                        command.Options.Add(CreateImageEditRequestOptionSetOptions.PartialImages);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.CreateImageEditRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var image = parseResult.GetRequiredValue(Image);
                        var mask = CliRuntime.WasSpecified(parseResult, Mask) ? parseResult.GetValue(Mask) : (__requestBase is { } __MaskBaseValue ? __MaskBaseValue.Mask : default);
                        var background = CliRuntime.WasSpecified(parseResult, Background) ? parseResult.GetValue(Background) : (__requestBase is { } __BackgroundBaseValue ? __BackgroundBaseValue.Background : default);
                        var model = parseResult.GetRequiredValue(Model);
                        var size = CliRuntime.WasSpecified(parseResult, Size) ? parseResult.GetValue(Size) : (__requestBase is { } __SizeBaseValue ? __SizeBaseValue.Size : default);
                        var outputFormat = CliRuntime.WasSpecified(parseResult, OutputFormat) ? parseResult.GetValue(OutputFormat) : (__requestBase is { } __OutputFormatBaseValue ? __OutputFormatBaseValue.OutputFormat : default);
                        var inputFidelity = CliRuntime.WasSpecified(parseResult, InputFidelity) ? parseResult.GetValue(InputFidelity) : (__requestBase is { } __InputFidelityBaseValue ? __InputFidelityBaseValue.InputFidelity : default);
                        var quality = CliRuntime.WasSpecified(parseResult, Quality) ? parseResult.GetValue(Quality) : (__requestBase is { } __QualityBaseValue ? __QualityBaseValue.Quality : default);                        var prompt = parseResult.GetRequiredValue(CreateImageEditRequestOptionSetOptions.Prompt);
                        var maskname = CliRuntime.WasSpecified(parseResult, CreateImageEditRequestOptionSetOptions.Maskname) ? parseResult.GetValue(CreateImageEditRequestOptionSetOptions.Maskname) : (__requestBase is { } __MasknameBaseValue ? __MasknameBaseValue.Maskname : default);
                        var n = CliRuntime.WasSpecified(parseResult, CreateImageEditRequestOptionSetOptions.N) ? parseResult.GetValue(CreateImageEditRequestOptionSetOptions.N) : (__requestBase is { } __NBaseValue ? __NBaseValue.N : default);
                        var outputCompression = CliRuntime.WasSpecified(parseResult, CreateImageEditRequestOptionSetOptions.OutputCompression) ? parseResult.GetValue(CreateImageEditRequestOptionSetOptions.OutputCompression) : (__requestBase is { } __OutputCompressionBaseValue ? __OutputCompressionBaseValue.OutputCompression : default);
                        var user = CliRuntime.WasSpecified(parseResult, CreateImageEditRequestOptionSetOptions.User) ? parseResult.GetValue(CreateImageEditRequestOptionSetOptions.User) : (__requestBase is { } __UserBaseValue ? __UserBaseValue.User : default);
                        var partialImages = CliRuntime.WasSpecified(parseResult, CreateImageEditRequestOptionSetOptions.PartialImages) ? parseResult.GetValue(CreateImageEditRequestOptionSetOptions.PartialImages) : (__requestBase is { } __PartialImagesBaseValue ? __PartialImagesBaseValue.PartialImages : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = client.Images.CreateImageEditAsStreamAsync(
                                    image: image,
                                    mask: mask,
                                    background: background,
                                    model: model,
                                    size: size,
                                    outputFormat: outputFormat,
                                    inputFidelity: inputFidelity,
                                    quality: quality,
                                    prompt: prompt,
                                    maskname: maskname,
                                    n: n,
                                    outputCompression: outputCompression,
                                    user: user,
                                    partialImages: partialImages,
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
        CustomizeCommand(ref command);
        return command;
    }
}
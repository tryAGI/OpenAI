#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class ImagesCreateImageVariationCommandApiCommand
{
    private static Option<byte[]> Image { get; } = new(
        name: @"--image")
    {
        Description = @"The image to use as the basis for the variation(s). Must be a valid PNG file, less than 4MB, and square.",
        Required = true,
    };

    private static Option<string> Imagename { get; } = new(
        name: @"--imagename")
    {
        Description = @"The image to use as the basis for the variation(s). Must be a valid PNG file, less than 4MB, and square.",
        Required = true,
    };

    private static Option<global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageVariationRequestModel?>?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"The model to use for image generation. Only `dall-e-2` is supported at this time.",
    };

    private static Option<int?> N { get; } = new(
        name: @"--n")
    {
        Description = @"The number of images to generate. Must be between 1 and 10.",
    };

    private static Option<global::tryAGI.OpenAI.CreateImageVariationRequestResponseFormat?> ResponseFormat { get; } = new(
        name: @"--response-format")
    {
        Description = @"The format in which the generated images are returned. Must be one of `url` or `b64_json`. URLs are only valid for 60 minutes after the image has been generated.",
    };

    private static Option<global::tryAGI.OpenAI.CreateImageVariationRequestSize?> Size { get; } = new(
        name: @"--size")
    {
        Description = @"The size of the generated images. Must be one of `256x256`, `512x512`, or `1024x1024`.",
    };

    private static Option<string?> User { get; } = new(
        name: @"--user")
    {
        Description = @"A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices#end-user-ids).
",
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
        var command = new Command(@"create-image-variation", @"Creates a variation of a given image. This endpoint only supports `dall-e-2`.");
                        command.Options.Add(Image);
                        command.Options.Add(Imagename);
                        command.Options.Add(Model);
                        command.Options.Add(N);
                        command.Options.Add(ResponseFormat);
                        command.Options.Add(Size);
                        command.Options.Add(User);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.CreateImageVariationRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var image = parseResult.GetRequiredValue(Image);
                        var imagename = parseResult.GetRequiredValue(Imagename);
                        var model = parseResult.GetValue(Model) ?? __requestBase?.Model;
                        var n = parseResult.GetValue(N) ?? __requestBase?.N;
                        var responseFormat = parseResult.GetValue(ResponseFormat) ?? __requestBase?.ResponseFormat;
                        var size = parseResult.GetValue(Size) ?? __requestBase?.Size;
                        var user = parseResult.GetValue(User) ?? __requestBase?.User;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Images.CreateImageVariationAsync(
                                    image: image,
                                    imagename: imagename,
                                    model: model,
                                    n: n,
                                    responseFormat: responseFormat,
                                    size: size,
                                    user: user,
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
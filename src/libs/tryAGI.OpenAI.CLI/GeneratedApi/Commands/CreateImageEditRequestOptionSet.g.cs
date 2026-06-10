#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record CreateImageEditRequestOptionSet(
    Option<string> Prompt,
                     Option<string?> Maskname,
                     Option<global::tryAGI.OpenAI.CreateImageEditRequestBackground?> Background,
                     Option<int?> N,
                     Option<global::tryAGI.OpenAI.CreateImageEditRequestResponseFormat?> ResponseFormat,
                     Option<global::tryAGI.OpenAI.CreateImageEditRequestOutputFormat?> OutputFormat,
                     Option<int?> OutputCompression,
                     Option<string?> User,
                     Option<bool?> Stream,
                     Option<int?> PartialImages,
                     Option<global::tryAGI.OpenAI.CreateImageEditRequestQuality?> Quality)
{
    public static CreateImageEditRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new CreateImageEditRequestOptionSet(
                        Prompt: new Option<string>($"--{normalizedPrefix}prompt")
                {
                    Description = @"A text description of the desired image(s). The maximum length is 1000 characters for `dall-e-2`, and 32000 characters for the GPT image models.",
                    Required = true,
                },
                Maskname: new Option<string?>($"--{normalizedPrefix}maskname")
                {
                    Description = @"An additional image whose fully transparent areas (e.g. where alpha is zero) indicate where `image` should be edited. If there are multiple images provided, the mask will be applied on the first image. Must be a valid PNG file, less than 4MB, and have the same dimensions as `image`.",
                },
                Background: new Option<global::tryAGI.OpenAI.CreateImageEditRequestBackground?>($"--{normalizedPrefix}background")
                {
                    Description = @"Allows to set transparency for the background of the generated image(s).
This parameter is only supported for the GPT image models. Must be one of
`transparent`, `opaque` or `auto` (default value). When `auto` is used, the
model will automatically determine the best background for the image.

If `transparent`, the output format needs to support transparency, so it
should be set to either `png` (default value) or `webp`.
",
                },
                N: new Option<int?>($"--{normalizedPrefix}n")
                {
                    Description = @"The number of images to generate. Must be between 1 and 10.",
                },
                ResponseFormat: new Option<global::tryAGI.OpenAI.CreateImageEditRequestResponseFormat?>($"--{normalizedPrefix}response-format")
                {
                    Description = @"The format in which the generated images are returned. Must be one of `url` or `b64_json`. URLs are only valid for 60 minutes after the image has been generated. This parameter is only supported for `dall-e-2` (default is `url` for `dall-e-2`), as GPT image models always return base64-encoded images.",
                },
                OutputFormat: new Option<global::tryAGI.OpenAI.CreateImageEditRequestOutputFormat?>($"--{normalizedPrefix}output-format")
                {
                    Description = @"The format in which the generated images are returned. This parameter is
only supported for the GPT image models. Must be one of `png`, `jpeg`, or `webp`.
The default value is `png`.
",
                },
                OutputCompression: new Option<int?>($"--{normalizedPrefix}output-compression")
                {
                    Description = @"The compression level (0-100%) for the generated images. This parameter
is only supported for the GPT image models with the `webp` or `jpeg` output
formats, and defaults to 100.
",
                },
                User: new Option<string?>($"--{normalizedPrefix}user")
                {
                    Description = @"A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices#end-user-ids).
",
                },
                Stream: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}stream", description: @"Edit the image in streaming mode. Defaults to `false`. See the
[Image generation guide](/docs/guides/image-generation) for more information.
"),
                PartialImages: new Option<int?>($"--{normalizedPrefix}partial-images")
                {
                    Description = @"",
                },
                Quality: new Option<global::tryAGI.OpenAI.CreateImageEditRequestQuality?>($"--{normalizedPrefix}quality")
                {
                    Description = @"The quality of the image that will be generated for GPT image models. Defaults to `auto`.
",
                }
        );
    }
}
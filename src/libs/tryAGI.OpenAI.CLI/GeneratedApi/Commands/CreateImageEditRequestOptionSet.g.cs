#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record CreateImageEditRequestOptionSet(
    Option<string> Prompt,
                     Option<string?> Maskname,
                     Option<int?> N,
                     Option<global::tryAGI.OpenAI.CreateImageEditRequestResponseFormat?> ResponseFormat,
                     Option<int?> OutputCompression,
                     Option<string?> User,
                     Option<bool?> Stream,
                     Option<int?> PartialImages)
{
    public static CreateImageEditRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new CreateImageEditRequestOptionSet(
                        Prompt: new Option<string>($"--{normalizedPrefix}prompt")
                {
                    Description = @"A text description of the desired image(s). The maximum length is 32000 characters for the GPT image models.",
                    Required = true,
                },
                Maskname: new Option<string?>($"--{normalizedPrefix}maskname")
                {
                    Description = @"An additional image whose fully transparent areas (e.g. where alpha is zero) indicate where `image` should be edited. If there are multiple images provided, the mask will be applied on the first image. Must be a valid PNG file, less than 4MB, and have the same dimensions as `image`.",
                },
                N: new Option<int?>($"--{normalizedPrefix}n")
                {
                    Description = @"The number of images to generate. Must be between 1 and 10.",
                },
                ResponseFormat: new Option<global::tryAGI.OpenAI.CreateImageEditRequestResponseFormat?>($"--{normalizedPrefix}response-format")
                {
                    Description = @"Legacy response format parameter for retired image models. Unsupported for GPT image models, which always return base64-encoded images.",
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
                    Description = @"A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](https://developers.openai.com/api/docs/guides/safety-best-practices#implement-safety-identifiers).
",
                },
                Stream: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}stream", description: @"Edit the image in streaming mode. Defaults to `false`. See the
[Image generation guide](https://developers.openai.com/api/docs/guides/image-generation) for more information.
"),
                PartialImages: new Option<int?>($"--{normalizedPrefix}partial-images")
                {
                    Description = @"",
                }
        );
    }
}
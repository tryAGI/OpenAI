#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record CreateImageEditRequestOptionSet(
    Option<int?> FrameCount,
                     Option<int?> FrameDurationMs,
                     Option<global::tryAGI.OpenAI.Complexity?> Complexity,
                     Option<string> Prompt,
                     Option<string?> Maskname,
                     Option<string?> Markupname,
                     Option<int?> N,
                     Option<global::tryAGI.OpenAI.CreateImageEditRequestResponseFormat?> ResponseFormat,
                     Option<int?> OutputCompression,
                     Option<string?> SafetyIdentifier,
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
                        FrameCount: new Option<int?>($"--{normalizedPrefix}frame-count")
                {
                    Description = @"Number of frames for GIF output. Accepts integers from 2 through 16. Defaults to 9 when omitted. Only supported with output_format=gif. The requested size must satisfy the selected model's GIF size limits. GIF output does not support streaming, partial images, masks, or custom output compression. Requires access to the GIF preview for the selected model.",
                },
                FrameDurationMs: new Option<int?>($"--{normalizedPrefix}frame-duration-ms")
                {
                    Description = @"Requested delay per GIF frame, in milliseconds. Defaults to 200 when omitted. GIF output rounds to the nearest 10 ms and caps the encoded delay at 655,350 ms per frame. Only supported with output_format=gif.",
                },
                Complexity: new Option<global::tryAGI.OpenAI.Complexity?>($"--{normalizedPrefix}complexity")
                {
                    Description = @"Computation spent planning the image, independently of rendering quality. Uses the image model's configured default when omitted. For SVG output, controls the reference image, independently of the SVG author's reasoning.",
                },
                Prompt: new Option<string>($"--{normalizedPrefix}prompt")
                {
                    Description = @"A text description of the desired image(s). The maximum length is 32000 characters for the GPT image models.",
                    Required = true,
                },
                Maskname: new Option<string?>($"--{normalizedPrefix}maskname")
                {
                    Description = @"An additional image whose fully transparent areas (e.g. where alpha is zero) indicate where `image` should be edited. If there are multiple images provided, the mask will be applied on the first image. Must be a valid PNG file, less than 4MB, and have the same dimensions as `image`.",
                },
                Markupname: new Option<string?>($"--{normalizedPrefix}markupname")
                {
                    Description = @"A transparent PNG overlaid on the first image to guide the edit. Must match that image's dimensions after orientation and contain transparent pixels. Supports GPT Image 2.5. Cannot be combined with mask.",
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
                SafetyIdentifier: new Option<string?>($"--{normalizedPrefix}safety-identifier")
                {
                    Description = @"A stable identifier for an end user in your organization, used for safety monitoring and abuse detection. Hash a username or email address to avoid sending identifying information. A non-empty value takes precedence over the deprecated `user` parameter. If omitted, null, or empty, the API uses `user` when available. [Learn more](https://developers.openai.com/api/docs/guides/safety-best-practices#implement-safety-identifiers).",
                },
                User: new Option<string?>($"--{normalizedPrefix}user")
                {
                    Description = @"Deprecated: use `safety_identifier` instead. This parameter remains accepted for backward compatibility and is used when `safety_identifier` is omitted, null, or empty. [Learn more](https://developers.openai.com/api/docs/guides/safety-best-practices#implement-safety-identifiers).",
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
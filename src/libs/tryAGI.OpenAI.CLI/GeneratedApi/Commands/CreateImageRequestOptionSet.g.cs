#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record CreateImageRequestOptionSet(
    Option<string> Prompt,
                     Option<int?> N,
                     Option<global::tryAGI.OpenAI.CreateImageRequestResponseFormat?> ResponseFormat,
                     Option<int?> OutputCompression,
                     Option<bool?> Stream,
                     Option<int?> PartialImages,
                     Option<global::tryAGI.OpenAI.CreateImageRequestStyle?> Style,
                     Option<string?> SafetyIdentifier,
                     Option<string?> User)
{
    public static CreateImageRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new CreateImageRequestOptionSet(
                        Prompt: new Option<string>($"--{normalizedPrefix}prompt")
                {
                    Description = @"A text description of the desired image(s). The maximum length is 32000 characters.",
                    Required = true,
                },
                N: new Option<int?>($"--{normalizedPrefix}n")
                {
                    Description = @"The number of images to generate. Must be between 1 and 10.",
                },
                ResponseFormat: new Option<global::tryAGI.OpenAI.CreateImageRequestResponseFormat?>($"--{normalizedPrefix}response-format")
                {
                    Description = @"Legacy response format parameter for retired image models. Unsupported for GPT image models, which always return base64-encoded images.",
                },
                OutputCompression: new Option<int?>($"--{normalizedPrefix}output-compression")
                {
                    Description = @"The compression level (0-100%) for the generated images. This parameter is only supported for the GPT image models with the `webp` or `jpeg` output formats, and defaults to 100.",
                },
                Stream: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}stream", description: @"Generate the image in streaming mode. Defaults to `false`. See the
[Image generation guide](https://developers.openai.com/api/docs/guides/image-generation) for more information.
This parameter is only supported for the GPT image models.
"),
                PartialImages: new Option<int?>($"--{normalizedPrefix}partial-images")
                {
                    Description = @"",
                },
                Style: new Option<global::tryAGI.OpenAI.CreateImageRequestStyle?>($"--{normalizedPrefix}style")
                {
                    Description = @"Legacy style parameter for retired image models. Unsupported for GPT image models; describe the desired style in the prompt instead.",
                },
                SafetyIdentifier: new Option<string?>($"--{normalizedPrefix}safety-identifier")
                {
                    Description = @"A stable identifier for an end user in your organization, used for safety monitoring and abuse detection. Hash a username or email address to avoid sending identifying information. A non-empty value takes precedence over the deprecated `user` parameter. If omitted, null, or empty, the API uses `user` when available. [Learn more](https://developers.openai.com/api/docs/guides/safety-best-practices#implement-safety-identifiers).",
                },
                User: new Option<string?>($"--{normalizedPrefix}user")
                {
                    Description = @"Deprecated: use `safety_identifier` instead. This parameter remains accepted for backward compatibility and is used when `safety_identifier` is omitted, null, or empty. [Learn more](https://developers.openai.com/api/docs/guides/safety-best-practices#implement-safety-identifiers).",
                }
        );
    }
}
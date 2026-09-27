#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record CreateTranslationRequestOptionSet(
    Option<string> Filename,
                     Option<string?> Prompt,
                     Option<global::tryAGI.OpenAI.CreateTranslationRequestResponseFormat?> ResponseFormat,
                     Option<double?> Temperature)
{
    public static CreateTranslationRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new CreateTranslationRequestOptionSet(
                        Filename: new Option<string>($"--{normalizedPrefix}filename")
                {
                    Description = @"The audio file object (not file name) translate, in one of these formats: flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, or webm. The request must include enough format metadata for the file to be identified. We recommend an extension-bearing filename and an appropriate content type.
",
                    Required = true,
                },
                Prompt: new Option<string?>($"--{normalizedPrefix}prompt")
                {
                    Description = @"An optional text to guide the model's style or continue a previous audio segment. The [prompt](https://developers.openai.com/api/docs/guides/speech-to-text#prompting) should be in English.
",
                },
                ResponseFormat: new Option<global::tryAGI.OpenAI.CreateTranslationRequestResponseFormat?>($"--{normalizedPrefix}response-format")
                {
                    Description = @"The format of the output, in one of these options: `json`, `text`, `srt`, `verbose_json`, or `vtt`.
",
                },
                Temperature: new Option<double?>($"--{normalizedPrefix}temperature")
                {
                    Description = @"The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.
",
                }
        );
    }
}
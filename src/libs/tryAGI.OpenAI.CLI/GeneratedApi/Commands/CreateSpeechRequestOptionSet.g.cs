#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record CreateSpeechRequestOptionSet(
    Option<string> InputOption,
                     Option<string?> Instructions,
                     Option<global::tryAGI.OpenAI.CreateSpeechRequestResponseFormat?> ResponseFormat,
                     Option<double?> Speed,
                     Option<global::tryAGI.OpenAI.CreateSpeechRequestStreamFormat?> StreamFormat)
{
    public static CreateSpeechRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new CreateSpeechRequestOptionSet(
                        InputOption: new Option<string>($"--{normalizedPrefix}input")
                {
                    Description = @"The text to generate audio for. The maximum length is 4096 characters.",
                    Required = true,
                },
                Instructions: new Option<string?>($"--{normalizedPrefix}instructions")
                {
                    Description = @"Control the voice of your generated audio with additional instructions. Does not work with `tts-1` or `tts-1-hd`.",
                },
                ResponseFormat: new Option<global::tryAGI.OpenAI.CreateSpeechRequestResponseFormat?>($"--{normalizedPrefix}response-format")
                {
                    Description = @"The format to audio in. Supported formats are `mp3`, `opus`, `aac`, `flac`, `wav`, and `pcm`.",
                },
                Speed: new Option<double?>($"--{normalizedPrefix}speed")
                {
                    Description = @"The speed of the generated audio. Select a value from `0.25` to `4.0`. `1.0` is the default.",
                },
                StreamFormat: new Option<global::tryAGI.OpenAI.CreateSpeechRequestStreamFormat?>($"--{normalizedPrefix}stream-format")
                {
                    Description = @"The format to stream the audio in. Supported formats are `sse` and `audio`. `sse` is not supported for `tts-1` or `tts-1-hd`.",
                }
        );
    }
}
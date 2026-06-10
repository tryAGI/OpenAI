#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record CreateTranscriptionRequestOptionSet(
    Option<string> Filename,
                     Option<string?> Language,
                     Option<string?> Prompt,
                     Option<global::tryAGI.OpenAI.AudioResponseFormat?> ResponseFormat,
                     Option<double?> Temperature,
                     Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionInclude>?> Include,
                     Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie>?> TimestampGranularities,
                     Option<bool?> Stream,
                     Option<global::System.Collections.Generic.IList<string>?> KnownSpeakerNames,
                     Option<global::System.Collections.Generic.IList<string>?> KnownSpeakerReferences)
{
    public static CreateTranscriptionRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new CreateTranscriptionRequestOptionSet(
                        Filename: new Option<string>($"--{normalizedPrefix}filename")
                {
                    Description = @"The audio file object (not file name) to transcribe, in one of these formats: flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, or webm.
",
                    Required = true,
                },
                Language: new Option<string?>($"--{normalizedPrefix}language")
                {
                    Description = @"The language of the input audio. Supplying the input language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) (e.g. `en`) format will improve accuracy and latency.
",
                },
                Prompt: new Option<string?>($"--{normalizedPrefix}prompt")
                {
                    Description = @"An optional text to guide the model's style or continue a previous audio segment. The [prompt](/docs/guides/speech-to-text#prompting) should match the audio language. This field is not supported when using `gpt-4o-transcribe-diarize`.
",
                },
                ResponseFormat: new Option<global::tryAGI.OpenAI.AudioResponseFormat?>($"--{normalizedPrefix}response-format")
                {
                    Description = @"The format of the output, in one of these options: `json`, `text`, `srt`, `verbose_json`, `vtt`, or `diarized_json`. For `gpt-4o-transcribe` and `gpt-4o-mini-transcribe`, the only supported format is `json`. For `gpt-4o-transcribe-diarize`, the supported formats are `json`, `text`, and `diarized_json`, with `diarized_json` required to receive speaker annotations.
",
                },
                Temperature: new Option<double?>($"--{normalizedPrefix}temperature")
                {
                    Description = @"The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.
",
                },
                Include: new Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionInclude>?>($"--{normalizedPrefix}include")
                {
                    Description = @"Additional information to include in the transcription response.
`logprobs` will return the log probabilities of the tokens in the
response to understand the model's confidence in the transcription.
`logprobs` only works with response_format set to `json` and only with
the models `gpt-4o-transcribe`, `gpt-4o-mini-transcribe`, and `gpt-4o-mini-transcribe-2025-12-15`. This field is not supported when using `gpt-4o-transcribe-diarize`.
",
                },
                TimestampGranularities: new Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie>?>($"--{normalizedPrefix}timestamp-granularities")
                {
                    Description = @"The timestamp granularities to populate for this transcription. `response_format` must be set `verbose_json` to use timestamp granularities. Either or both of these options are supported: `word`, or `segment`. Note: There is no additional latency for segment timestamps, but generating word timestamps incurs additional latency.
This option is not available for `gpt-4o-transcribe-diarize`.
",
                },
                Stream: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}stream", description: @""),
                KnownSpeakerNames: new Option<global::System.Collections.Generic.IList<string>?>($"--{normalizedPrefix}known-speaker-names")
                {
                    Description = @"Optional list of speaker names that correspond to the audio samples provided in `known_speaker_references[]`. Each entry should be a short identifier (for example `customer` or `agent`). Up to 4 speakers are supported.
",
                },
                KnownSpeakerReferences: new Option<global::System.Collections.Generic.IList<string>?>($"--{normalizedPrefix}known-speaker-references")
                {
                    Description = @"Optional list of audio samples (as [data URLs](https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/Data_URLs)) that contain known speaker references matching `known_speaker_names[]`. Each sample must be between 2 and 10 seconds, and can use any of the same input audio formats supported by `file`.
",
                }
        );
    }
}
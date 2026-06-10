#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class AudioCreateVoiceCommandApiCommand
{
    private static Argument<string> NameOption { get; } = new(
        name: @"name")
    {
        Description = @"The name of the new voice.",
    };

    private static Option<byte[]> AudioSample { get; } = new(
        name: @"--audio-sample")
    {
        Description = @"The sample audio recording file. Maximum size is 10 MiB.

Supported MIME types:
`audio/mpeg`, `audio/wav`, `audio/x-wav`, `audio/ogg`, `audio/aac`, `audio/flac`, `audio/webm`, `audio/mp4`.
",
        Required = true,
    };

    private static Option<string> AudioSamplename { get; } = new(
        name: @"--audio-samplename")
    {
        Description = @"The sample audio recording file. Maximum size is 10 MiB.

Supported MIME types:
`audio/mpeg`, `audio/wav`, `audio/x-wav`, `audio/ogg`, `audio/aac`, `audio/flac`, `audio/webm`, `audio/mp4`.
",
        Required = true,
    };

    private static Option<string> Consent { get; } = new(
        name: @"--consent")
    {
        Description = @"The consent recording ID (for example, `cons_1234`).",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.VoiceResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.VoiceResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-voice", @"Creates a custom voice.
Create a custom voice you can use for audio output (for example, in Text-to-Speech and the Realtime API). This requires an audio sample and a previously uploaded consent recording.

See the [custom voices guide](/docs/guides/text-to-speech#custom-voices) for requirements and best practices. Custom voices are limited to eligible customers.
");
                        command.Arguments.Add(NameOption);
                        command.Options.Add(AudioSample);
                        command.Options.Add(AudioSamplename);
                        command.Options.Add(Consent);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var name = parseResult.GetRequiredValue(NameOption);
                        var audioSample = parseResult.GetRequiredValue(AudioSample);
                        var audioSamplename = parseResult.GetRequiredValue(AudioSamplename);
                        var consent = parseResult.GetRequiredValue(Consent);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Audio.CreateVoiceAsync(
                                    name: name,
                                    audioSample: audioSample,
                                    audioSamplename: audioSamplename,
                                    consent: consent,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}
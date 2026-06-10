#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class AudioCreateVoiceConsentCommandApiCommand
{
    private static Argument<string> NameOption { get; } = new(
        name: @"name")
    {
        Description = @"The label to use for this consent recording.",
    };

    private static Option<byte[]> Recording { get; } = new(
        name: @"--recording")
    {
        Description = @"The consent audio recording file. Maximum size is 10 MiB.

Supported MIME types:
`audio/mpeg`, `audio/wav`, `audio/x-wav`, `audio/ogg`, `audio/aac`, `audio/flac`, `audio/webm`, `audio/mp4`.
",
        Required = true,
    };

    private static Option<string> Recordingname { get; } = new(
        name: @"--recordingname")
    {
        Description = @"The consent audio recording file. Maximum size is 10 MiB.

Supported MIME types:
`audio/mpeg`, `audio/wav`, `audio/x-wav`, `audio/ogg`, `audio/aac`, `audio/flac`, `audio/webm`, `audio/mp4`.
",
        Required = true,
    };

    private static Option<string> Language { get; } = new(
        name: @"--language")
    {
        Description = @"The BCP 47 language tag for the consent phrase (for example, `en-US`).",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.VoiceConsentResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.VoiceConsentResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-voice-consent", @"Upload a voice consent recording.
Upload a consent recording that authorizes creation of a custom voice.

See the [custom voices guide](/docs/guides/text-to-speech#custom-voices) for requirements and best practices. Custom voices are limited to eligible customers.
");
                        command.Arguments.Add(NameOption);
                        command.Options.Add(Recording);
                        command.Options.Add(Recordingname);
                        command.Options.Add(Language);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var name = parseResult.GetRequiredValue(NameOption);
                        var recording = parseResult.GetRequiredValue(Recording);
                        var recordingname = parseResult.GetRequiredValue(Recordingname);
                        var language = parseResult.GetRequiredValue(Language);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Audio.CreateVoiceConsentAsync(
                                    name: name,
                                    recording: recording,
                                    recordingname: recordingname,
                                    language: language,
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
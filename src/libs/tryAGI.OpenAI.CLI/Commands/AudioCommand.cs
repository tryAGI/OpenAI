using System.CommandLine;

namespace tryAGI.OpenAI.Cli.Commands;

internal static class AudioCommand
{
    public static Command Create()
    {
        var cmd = new Command("audio", "Text-to-speech and speech-to-text.");
        cmd.Subcommands.Add(CreateSpeechCommand());
        cmd.Subcommands.Add(CreateTranscribeCommand());
        return cmd;
    }

    private static Command CreateSpeechCommand()
    {
        var inputArg = new Argument<string>("text")
        {
            Description = "Text to synthesize. Pass `-` for stdin or a file path.",
        };
        var outputOpt = new Option<string>("--save-to")
        {
            DefaultValueFactory = _ => "speech.mp3",
            Description = "File path to write the audio to.",
        };
        var modelOpt = new Option<string>("--model")
        {
            DefaultValueFactory = _ => "gpt-4o-mini-tts",
            Description = "TTS model id.",
        };
        var voiceOpt = new Option<string>("--voice")
        {
            DefaultValueFactory = _ => "alloy",
            Description = "Voice id: alloy | ash | ballad | coral | echo | sage | shimmer | verse | fable | onyx | nova.",
        };
        var formatOpt = new Option<string>("--format")
        {
            DefaultValueFactory = _ => "mp3",
            Description = "Audio response format: mp3 | opus | aac | flac | wav | pcm.",
        };
        var speedOpt = new Option<double?>("--speed")
        {
            Description = "Playback speed multiplier (0.25 – 4.0).",
        };

        var cmd = new Command("speech", "Synthesize speech from text (streaming).");
        cmd.Arguments.Add(inputArg);
        cmd.Options.Add(outputOpt);
        cmd.Options.Add(modelOpt);
        cmd.Options.Add(voiceOpt);
        cmd.Options.Add(formatOpt);
        cmd.Options.Add(speedOpt);

        cmd.SetAction(CliRuntime.Wrap(async (parseResult, cancellationToken) =>
        {
            using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

            var rawText = CliRuntime.GetRequiredArgument(parseResult, inputArg);
            var text = await CliRuntime.ReadInputOrFileAsync(rawText, cancellationToken).ConfigureAwait(false);
            var output = parseResult.GetValue(outputOpt) ?? "speech.mp3";
            var modelValue = parseResult.GetValue(modelOpt) ?? "gpt-4o-mini-tts";
            var voiceValue = parseResult.GetValue(voiceOpt) ?? "alloy";
            var formatValue = parseResult.GetValue(formatOpt) ?? "mp3";
            var speed = parseResult.GetValue(speedOpt);

            var model = CreateSpeechRequestModelExtensions.ToEnum(modelValue);
            var voice = VoiceIdsSharedEnumExtensions.ToEnum(voiceValue)
                ?? throw new CliException($"Unknown voice `{voiceValue}`.");
            var format = CreateSpeechRequestResponseFormatExtensions.ToEnum(formatValue)
                ?? throw new CliException($"Unknown audio format `{formatValue}`.");

            var directory = Path.GetDirectoryName(output);
            if (!string.IsNullOrWhiteSpace(directory))
            {
                Directory.CreateDirectory(directory);
            }

            using var fileStream = File.Create(output);
            await foreach (var streamEvent in client.Audio.CreateSpeechAsync(
                model: model,
                input: text,
                voice: (VoiceIdsShared)voice,
                responseFormat: format,
                speed: speed,
                streamFormat: CreateSpeechRequestStreamFormat.Sse,
                cancellationToken: cancellationToken).ConfigureAwait(false))
            {
                if (streamEvent.SpeechAudioDelta is { } delta && !string.IsNullOrEmpty(delta.Audio))
                {
                    var chunk = Convert.FromBase64String(delta.Audio);
                    await fileStream.WriteAsync(chunk, cancellationToken).ConfigureAwait(false);
                }
            }

            var bytes = new FileInfo(output).Length;
            await Console.Out.WriteLineAsync($"wrote {bytes} bytes to {output}").ConfigureAwait(false);
        }));

        return cmd;
    }

    private static Command CreateTranscribeCommand()
    {
        var fileArg = new Argument<string>("audio-file")
        {
            Description = "Path to an audio file (mp3, wav, m4a, flac, webm, mp4, mpeg, mpga, oga, ogg).",
        };
        var modelOpt = new Option<string>("--model")
        {
            DefaultValueFactory = _ => "whisper-1",
            Description = "Transcription model id (e.g. `whisper-1`, `gpt-4o-transcribe`).",
        };
        var languageOpt = new Option<string?>("--language")
        {
            Description = "ISO-639-1 language hint (e.g. `en`, `es`).",
        };
        var promptOpt = new Option<string?>("--prompt")
        {
            Description = "Optional style/phrase hint.",
        };

        var cmd = new Command("transcribe", "Transcribe an audio file to text.");
        cmd.Arguments.Add(fileArg);
        cmd.Options.Add(modelOpt);
        cmd.Options.Add(languageOpt);
        cmd.Options.Add(promptOpt);

        cmd.SetAction(CliRuntime.Wrap(async (parseResult, cancellationToken) =>
        {
            using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

            var filePath = CliRuntime.GetRequiredArgument(parseResult, fileArg);
            if (!File.Exists(filePath))
            {
                throw new CliException($"Audio file not found: {filePath}");
            }

            var modelValue = parseResult.GetValue(modelOpt) ?? "whisper-1";
            var language = parseResult.GetValue(languageOpt);
            var prompt = parseResult.GetValue(promptOpt);

            var fileBytes = await File.ReadAllBytesAsync(filePath, cancellationToken).ConfigureAwait(false);

            var response = await client.Audio.CreateTranscriptionAsync(
                file: fileBytes,
                filename: Path.GetFileName(filePath),
                model: CreateTranscriptionRequestModelExtensions.ToEnum(modelValue),
                language: language,
                prompt: prompt,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var text = response.Value1?.Text
                ?? response.Value2?.Text
                ?? response.Value3?.Text
                ?? string.Empty;
            await CliRuntime.WriteOutputAsync(parseResult, text, response, cancellationToken).ConfigureAwait(false);
        }));

        return cmd;
    }
}

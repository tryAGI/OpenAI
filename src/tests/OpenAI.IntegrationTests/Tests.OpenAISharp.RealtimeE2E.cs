using System.Text;
using tryAGI.OpenAI.OpenAISharp;
using tryAGI.OpenAI.OpenAISharp.Realtime;

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task OpenAISharp_Realtime_SessionUpdate_And_ResponseCreate()
    {
        var apiKey = RequireManualOpenAISharpRealtimeE2E();
        var model = Environment.GetEnvironmentVariable("OPENAI_REALTIME_MODEL") ?? OpenAIRealtimeModelIds.GptRealtime2;

        using var client = OpenAIClient.Create(apiKey);
        using var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(40));
        var cancellationToken = cancellationTokenSource.Token;

        await using var session = await client.Realtime.ConnectAsync(
            new OpenAIRealtimeConnectOptions { Model = model },
            cancellationToken);

        var created = await WaitForOpenAISharpEventTypeAsync(session, "session.created", cancellationToken);
        created.Should().NotBeNull("Should receive session.created from OpenAI Realtime API.");

        await session.SendSessionUpdateAsync(new OpenAIRealtimeSessionUpdate
        {
            Type = OpenAIRealtimeSessionTypes.Realtime,
            Model = model,
            Instructions = "Respond briefly for E2E test.",
            OutputModalities = ["text"],
            Reasoning = CreateOpenAISharpReasoningIfSupported(model),
        }, cancellationToken);

        var updated = await WaitForOpenAISharpEventTypeAsync(session, "session.updated", cancellationToken);
        updated.Should().NotBeNull("Should receive session.updated after session.update.");

        await session.SendConversationItemCreateAsync(new OpenAIRealtimeConversationItem
        {
            Type = "message",
            Role = "user",
            Content =
            [
                new OpenAIRealtimeInputTextContent { Text = "Say hello." }
            ]
        }, cancellationToken);

        await session.SendResponseCreateAsync(new OpenAIRealtimeResponse
        {
            OutputModalities = ["text"],
            Reasoning = CreateOpenAISharpReasoningIfSupported(model),
        }, cancellationToken);

        var responseDone = await WaitForOpenAISharpEventTypesAsync(
            session,
            ["response.done", "response.output_text.done"],
            cancellationToken);

        responseDone.Should().NotBeNull("Should receive response completion from OpenAI Realtime API.");
    }

    [TestMethod]
    public async Task OpenAISharp_Realtime_InputAudioBufferCommit_ReceivesCommittedEvent()
    {
        var apiKey = RequireManualOpenAISharpRealtimeE2E();
        var model = Environment.GetEnvironmentVariable("OPENAI_REALTIME_MODEL") ?? OpenAIRealtimeModelIds.GptRealtime2;

        using var client = OpenAIClient.Create(apiKey);
        using var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(30));
        var cancellationToken = cancellationTokenSource.Token;

        await using var session = await client.Realtime.ConnectAsync(
            new OpenAIRealtimeConnectOptions { Model = model },
            cancellationToken);

        var created = await WaitForOpenAISharpEventTypeAsync(session, "session.created", cancellationToken);
        created.Should().NotBeNull("Should receive session.created from OpenAI Realtime API.");

        var update = new OpenAIRealtimeSessionUpdate
        {
            Type = OpenAIRealtimeSessionTypes.Realtime,
            Model = model,
            OutputModalities = ["text"],
            Audio = new OpenAIRealtimeAudioConfig
            {
                Input = new OpenAIRealtimeInputAudioConfig
                {
                    Format = OpenAIRealtimeAudioFormat.Pcm(),
                    TurnDetection = null,
                },
            },
            Reasoning = CreateOpenAISharpReasoningIfSupported(model),
        };

        await session.SendSessionUpdateAsync(update, cancellationToken);

        var updated = await WaitForOpenAISharpEventTypeAsync(session, "session.updated", cancellationToken);
        updated.Should().NotBeNull("Should receive session.updated before sending audio.");

        var (speechSamples, sampleRate, channels) = LoadOpenAISharpSpeechSamples();
        sampleRate.Should().Be(24000, "Speech fixture should be 24 kHz PCM16.");
        channels.Should().Be(1, "Speech fixture should be mono PCM16.");

        const int chunkDurationMs = 100;
        var chunkSamples = sampleRate * chunkDurationMs / 1000;

        await SendOpenAISharpAudioChunksAsync(session, speechSamples, chunkSamples, cancellationToken);
        await session.CommitInputAudioAsync(cancellationToken);

        var committed = await WaitForOpenAISharpEventTypeAsync(session, "input_audio_buffer.committed", cancellationToken);
        committed.Should().NotBeNull("Should receive input_audio_buffer.committed after input_audio_buffer.commit.");
    }

    [TestMethod]
    public async Task OpenAISharp_Realtime_InputAudioBufferCommit_StreamsChunks_ReceivesSpeechEvents()
    {
        var apiKey = RequireManualOpenAISharpRealtimeE2E();
        var model = Environment.GetEnvironmentVariable("OPENAI_REALTIME_MODEL") ?? OpenAIRealtimeModelIds.GptRealtime2;

        using var client = OpenAIClient.Create(apiKey);
        using var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(45));
        var cancellationToken = cancellationTokenSource.Token;

        await using var session = await client.Realtime.ConnectAsync(
            new OpenAIRealtimeConnectOptions { Model = model },
            cancellationToken);

        var created = await WaitForOpenAISharpEventTypeAsync(session, "session.created", cancellationToken);
        created.Should().NotBeNull("Should receive session.created from OpenAI Realtime API.");

        await session.SendSessionUpdateAsync(new OpenAIRealtimeSessionUpdate
        {
            Type = OpenAIRealtimeSessionTypes.Realtime,
            Model = model,
            OutputModalities = ["text"],
            Audio = new OpenAIRealtimeAudioConfig
            {
                Input = new OpenAIRealtimeInputAudioConfig
                {
                    Format = OpenAIRealtimeAudioFormat.Pcm(),
                    TurnDetection = new OpenAIRealtimeTurnDetection
                    {
                        Type = "server_vad",
                        Threshold = 0.1,
                        SilenceDurationMs = 200,
                        PrefixPaddingMs = 0,
                        CreateResponse = false
                    },
                },
            },
            Reasoning = CreateOpenAISharpReasoningIfSupported(model),
        }, cancellationToken);

        var updated = await WaitForOpenAISharpEventTypeAsync(session, "session.updated", cancellationToken);
        updated.Should().NotBeNull("Should receive session.updated before sending audio.");

        var (speechSamples, sampleRate, channels) = LoadOpenAISharpSpeechSamples();
        sampleRate.Should().Be(24000, "Speech fixture should be 24 kHz PCM16.");
        channels.Should().Be(1, "Speech fixture should be mono PCM16.");

        const int chunkDurationMs = 100;
        var chunkSamples = sampleRate * chunkDurationMs / 1000;
        var silenceSamples = GenerateOpenAISharpSilence(sampleRate, durationSeconds: 0.5);

        await SendOpenAISharpAudioChunksAsync(session, speechSamples, chunkSamples, cancellationToken);
        await SendOpenAISharpAudioChunksAsync(session, silenceSamples, chunkSamples, cancellationToken);

        var expected = new[]
        {
            "input_audio_buffer.speech_started",
            "input_audio_buffer.speech_stopped"
        };

        var seen = await WaitForAllOpenAISharpEventTypesAsync(session, expected, cancellationToken);

        foreach (var expectedType in expected)
        {
            seen.Should().ContainKey(expectedType, $"Should receive {expectedType} after streaming audio chunks.");
        }
    }

    [TestMethod]
    public async Task OpenAISharp_Realtime2_TranslationSession_ConnectsAndAcceptsSessionUpdate()
    {
        var apiKey = RequireManualOpenAISharpRealtimeE2E();
        var model = Environment.GetEnvironmentVariable("OPENAI_REALTIME_TRANSLATION_MODEL") ?? OpenAIRealtimeModelIds.GptRealtimeTranslate;

        using var client = OpenAIClient.Create(apiKey);
        using var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(40));
        var cancellationToken = cancellationTokenSource.Token;

        await using var session = await client.Realtime.ConnectAsync(
            new OpenAIRealtimeConnectOptions
            {
                Model = model,
                SessionKind = OpenAIRealtimeSessionKind.Translation,
            },
            cancellationToken);

        var created = await WaitForOpenAISharpEventTypeAsync(session, "session.created", cancellationToken);
        created.Should().NotBeNull("Should receive session.created from OpenAI Realtime translation API.");

        await session.SendSessionUpdateAsync(new OpenAIRealtimeSessionUpdate
        {
            Audio = new OpenAIRealtimeAudioConfig
            {
                Output = new OpenAIRealtimeOutputAudioConfig
                {
                    Language = "en",
                },
            },
        }, cancellationToken);

        var updated = await WaitForOpenAISharpEventTypeAsync(session, "session.updated", cancellationToken);
        updated.Should().NotBeNull("Should receive session.updated after configuring translation audio.");
    }

    [TestMethod]
    public async Task OpenAISharp_RealtimeWhisper_TranscriptionSession_StreamsTranscript()
    {
        var apiKey = RequireManualOpenAISharpRealtimeE2E();
        var model = Environment.GetEnvironmentVariable("OPENAI_REALTIME_TRANSCRIPTION_MODEL") ?? OpenAIRealtimeModelIds.GptRealtimeWhisper;

        using var client = OpenAIClient.Create(apiKey);
        using var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(50));
        var cancellationToken = cancellationTokenSource.Token;

        await using var session = await client.Realtime.ConnectAsync(
            new OpenAIRealtimeConnectOptions
            {
                Model = model,
                SessionKind = OpenAIRealtimeSessionKind.Transcription,
            },
            cancellationToken);

        await session.SendSessionUpdateAsync(new OpenAIRealtimeSessionUpdate
        {
            Type = OpenAIRealtimeSessionTypes.Transcription,
            Audio = new OpenAIRealtimeAudioConfig
            {
                Input = new OpenAIRealtimeInputAudioConfig
                {
                    Format = OpenAIRealtimeAudioFormat.Pcm(),
                    Transcription = new OpenAIRealtimeInputAudioTranscription
                    {
                        Model = model,
                        Language = "ru",
                    },
                },
            },
        }, cancellationToken);

        var updated = await WaitForOpenAISharpEventTypesAsync(
            session,
            ["session.updated", "transcription_session.updated"],
            cancellationToken);
        updated.Should().NotBeNull("Should receive session.updated before sending transcription audio.");

        var (speechSamples, sampleRate, channels) = LoadOpenAISharpSpeechSamples();
        sampleRate.Should().Be(24000, "Speech fixture should be 24 kHz PCM16.");
        channels.Should().Be(1, "Speech fixture should be mono PCM16.");

        const int chunkDurationMs = 100;
        var chunkSamples = sampleRate * chunkDurationMs / 1000;
        var silenceSamples = GenerateOpenAISharpSilence(sampleRate, durationSeconds: 0.7);

        await SendOpenAISharpAudioChunksAsync(session, speechSamples, chunkSamples, cancellationToken);
        await SendOpenAISharpAudioChunksAsync(session, silenceSamples, chunkSamples, cancellationToken);
        await session.CommitInputAudioAsync(cancellationToken);

        var transcript = await WaitForOpenAISharpEventTypesAsync(
            session,
            ["conversation.item.input_audio_transcription.delta", "conversation.item.input_audio_transcription.completed"],
            cancellationToken);

        transcript.Should().NotBeNull("Should receive realtime-whisper transcription output with a real OpenAI API key.");
    }

    private static string RequireManualOpenAISharpRealtimeE2E()
    {
        if (!IsEnabled(Environment.GetEnvironmentVariable("OPENAI_REALTIME_E2E")))
        {
            throw new AssertInconclusiveException("Set OPENAI_REALTIME_E2E=true to run OpenAISharp realtime E2E tests.");
        }

        return Environment.GetEnvironmentVariable("OPENAI_API_KEY") is { Length: > 0 } apiKey
            ? apiKey
            : throw new AssertInconclusiveException("OPENAI_API_KEY environment variable is not found.");

        static bool IsEnabled(string? value)
        {
            return value is not null &&
                   (value.Equals("1", StringComparison.OrdinalIgnoreCase) ||
                    value.Equals("true", StringComparison.OrdinalIgnoreCase) ||
                    value.Equals("yes", StringComparison.OrdinalIgnoreCase));
        }
    }

    private static OpenAIRealtimeReasoning? CreateOpenAISharpReasoningIfSupported(string model)
    {
        return model.StartsWith(OpenAIRealtimeModelIds.GptRealtime2, StringComparison.OrdinalIgnoreCase)
            ? new OpenAIRealtimeReasoning { Effort = "low" }
            : null;
    }

    private static Task<OpenAIRealtimeEvent?> WaitForOpenAISharpEventTypeAsync(
        OpenAIRealtimeSession session,
        string eventType,
        CancellationToken cancellationToken)
    {
        return WaitForOpenAISharpEventTypesAsync(session, [eventType], cancellationToken);
    }

    private static async Task<OpenAIRealtimeEvent?> WaitForOpenAISharpEventTypesAsync(
        OpenAIRealtimeSession session,
        IReadOnlyCollection<string> eventTypes,
        CancellationToken cancellationToken)
    {
        var deadline = DateTime.UtcNow.AddSeconds(20);

        while (DateTime.UtcNow < deadline)
        {
            var evt = await session.ReceiveEventAsync(cancellationToken);
            if (evt == null)
            {
                return null;
            }

            if (evt is OpenAIRealtimeErrorEvent error)
            {
                throw new InvalidOperationException($"OpenAI error: {error.Error.Type} - {error.Error.Message}");
            }

            if (eventTypes.Contains(evt.Type))
            {
                return evt;
            }
        }

        return null;
    }

    private static async Task<IReadOnlyDictionary<string, OpenAIRealtimeEvent>> WaitForAllOpenAISharpEventTypesAsync(
        OpenAIRealtimeSession session,
        IReadOnlyCollection<string> eventTypes,
        CancellationToken cancellationToken)
    {
        var deadline = DateTime.UtcNow.AddSeconds(25);
        var seen = new Dictionary<string, OpenAIRealtimeEvent>(StringComparer.Ordinal);

        while (DateTime.UtcNow < deadline && seen.Count < eventTypes.Count)
        {
            var evt = await session.ReceiveEventAsync(cancellationToken);
            if (evt == null)
            {
                break;
            }

            if (evt is OpenAIRealtimeErrorEvent error)
            {
                throw new InvalidOperationException($"OpenAI error: {error.Error.Type} - {error.Error.Message}");
            }

            if (eventTypes.Contains(evt.Type) && !seen.ContainsKey(evt.Type))
            {
                seen[evt.Type] = evt;
            }
        }

        return seen;
    }

    private static async Task SendOpenAISharpAudioChunksAsync(
        OpenAIRealtimeSession session,
        short[] samples,
        int chunkSamples,
        CancellationToken cancellationToken)
    {
        if (chunkSamples <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(chunkSamples));
        }

        for (var offset = 0; offset < samples.Length; offset += chunkSamples)
        {
            var count = Math.Min(chunkSamples, samples.Length - offset);
            await session.SendInputAudioAsync(samples.AsSpan(offset, count), cancellationToken);
        }
    }

    private static short[] GenerateOpenAISharpSilence(int sampleRate, double durationSeconds)
    {
        var sampleCount = (int)(sampleRate * durationSeconds);
        return new short[sampleCount];
    }

    private static (short[] Samples, int SampleRate, int Channels) LoadOpenAISharpSpeechSamples()
    {
        var path = Path.Combine(AppContext.BaseDirectory, "Resources", "hello-in-russian-24k-pcm16.wav");
        File.Exists(path).Should().BeTrue($"Speech fixture should exist at {path}");

        var wavBytes = File.ReadAllBytes(path);
        return ReadOpenAISharpWavPcm16(wavBytes);
    }

    private static (short[] Samples, int SampleRate, int Channels) ReadOpenAISharpWavPcm16(ReadOnlySpan<byte> data)
    {
        using var memoryStream = new MemoryStream(data.ToArray(), writable: false);
        using var binaryReader = new BinaryReader(memoryStream, Encoding.UTF8, leaveOpen: true);

        var riff = new string(binaryReader.ReadChars(4));
        if (riff != "RIFF")
        {
            throw new InvalidDataException("Not RIFF");
        }

        binaryReader.ReadInt32();
        var wave = new string(binaryReader.ReadChars(4));
        if (wave != "WAVE")
        {
            throw new InvalidDataException("Not WAVE");
        }

        ushort audioFormat = 1;
        ushort channels = 1;
        int sampleRate = 16000;
        ushort bitsPerSample = 16;

        while (memoryStream.Position < memoryStream.Length)
        {
            if (memoryStream.Length - memoryStream.Position < 8)
            {
                break;
            }

            var chunkId = new string(binaryReader.ReadChars(4));
            var size = binaryReader.ReadInt32();
            var next = memoryStream.Position + size;

            if (chunkId == "fmt ")
            {
                if (size < 16)
                {
                    throw new InvalidDataException("Bad fmt chunk");
                }

                audioFormat = binaryReader.ReadUInt16();
                channels = binaryReader.ReadUInt16();
                sampleRate = binaryReader.ReadInt32();
                binaryReader.ReadInt32();
                binaryReader.ReadUInt16();
                bitsPerSample = binaryReader.ReadUInt16();

                if (next > memoryStream.Position)
                {
                    binaryReader.ReadBytes((int)(next - memoryStream.Position));
                }
            }
            else if (chunkId == "data")
            {
                if (audioFormat != 1 || bitsPerSample != 16)
                {
                    throw new InvalidDataException("Expected PCM16");
                }

                var dataSize = size == 0 ? (int)(memoryStream.Length - memoryStream.Position) : size;
                var dataBytes = binaryReader.ReadBytes(dataSize);
                var samples = new short[dataBytes.Length / 2];
                Buffer.BlockCopy(dataBytes, 0, samples, 0, dataBytes.Length);
                return (samples, sampleRate, channels);
            }
            else if (size > 0)
            {
                binaryReader.ReadBytes(size);
            }
        }

        throw new InvalidDataException("WAV data chunk not found");
    }
}

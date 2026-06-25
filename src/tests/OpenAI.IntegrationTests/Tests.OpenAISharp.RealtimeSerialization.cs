using System.Text.Json;
using tryAGI.OpenAI.OpenAISharp;

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void OpenAISharp_Serialize_InputAudioAppend_UsesBase64AndType()
    {
        var audio = new byte[] { 0x01, 0x02, 0x03, 0x04 };
        var message = new OpenAIRealtimeInputAudioBufferAppendEvent
        {
            Audio = Convert.ToBase64String(audio)
        };

        var json = JsonSerializer.Serialize<OpenAIRealtimeClientEvent>(message, OpenAIJsonSerializer.Default);
        using var doc = JsonDocument.Parse(json);

        doc.RootElement.GetProperty("type").GetString().Should().Be("input_audio_buffer.append");
        doc.RootElement.GetProperty("audio").GetString().Should().Be(Convert.ToBase64String(audio));
    }

    [TestMethod]
    public void OpenAISharp_Serialize_InputAudioCommit_OnlySendsType()
    {
        var message = new OpenAIRealtimeInputAudioBufferCommitEvent();

        var json = JsonSerializer.Serialize<OpenAIRealtimeClientEvent>(message, OpenAIJsonSerializer.Default);
        using var doc = JsonDocument.Parse(json);

        doc.RootElement.GetProperty("type").GetString().Should().Be("input_audio_buffer.commit");
        doc.RootElement.EnumerateObject().Should().ContainSingle();
    }

    [TestMethod]
    public void OpenAISharp_Serialize_SessionUpdate_WrapsSessionPayload()
    {
        var session = new OpenAIRealtimeSessionUpdate { Instructions = "Hello" };
        var message = new OpenAIRealtimeSessionUpdateEvent { Session = session };

        var json = JsonSerializer.Serialize<OpenAIRealtimeClientEvent>(message, OpenAIJsonSerializer.Default);
        using var doc = JsonDocument.Parse(json);

        doc.RootElement.GetProperty("type").GetString().Should().Be("session.update");
        doc.RootElement.GetProperty("session").GetProperty("instructions").GetString().Should().Be("Hello");
    }

    [TestMethod]
    public void OpenAISharp_Serialize_SessionUpdate_GaRealtime2Shape_UsesNestedAudioAndOutputModalities()
    {
        var session = new OpenAIRealtimeSessionUpdate
        {
            Type = OpenAIRealtimeSessionTypes.Realtime,
            Model = OpenAIRealtimeModelIds.GptRealtime2,
            Instructions = "Be brief.",
            OutputModalities = ["audio"],
            Audio = new OpenAIRealtimeAudioConfig
            {
                Input = new OpenAIRealtimeInputAudioConfig
                {
                    Format = OpenAIRealtimeAudioFormat.Pcm(),
                    TurnDetection = new OpenAIRealtimeTurnDetection
                    {
                        Type = "semantic_vad",
                        Eagerness = "auto",
                        CreateResponse = true,
                    },
                    NoiseReduction = new OpenAIRealtimeNoiseReduction { Type = "near_field" },
                },
                Output = new OpenAIRealtimeOutputAudioConfig
                {
                    Format = OpenAIRealtimeAudioFormat.Pcm(),
                    Voice = "marin",
                    Speed = 1.05,
                },
            },
            Reasoning = new OpenAIRealtimeReasoning { Effort = "low" },
        };
        var message = new OpenAIRealtimeSessionUpdateEvent { Session = session };

        var json = JsonSerializer.Serialize<OpenAIRealtimeClientEvent>(message, OpenAIJsonSerializer.Default);
        using var doc = JsonDocument.Parse(json);

        var root = doc.RootElement;
        root.GetProperty("type").GetString().Should().Be("session.update");
        var sessionElement = root.GetProperty("session");
        sessionElement.GetProperty("type").GetString().Should().Be("realtime");
        sessionElement.GetProperty("model").GetString().Should().Be("gpt-realtime-2");
        sessionElement.GetProperty("output_modalities")[0].GetString().Should().Be("audio");
        sessionElement.TryGetProperty("modalities", out _).Should().BeFalse();
        sessionElement.GetProperty("audio").GetProperty("input").GetProperty("format").GetProperty("type").GetString().Should().Be("audio/pcm");
        sessionElement.GetProperty("audio").GetProperty("input").GetProperty("format").GetProperty("rate").GetInt32().Should().Be(24000);
        sessionElement.GetProperty("audio").GetProperty("input").GetProperty("turn_detection").GetProperty("type").GetString().Should().Be("semantic_vad");
        sessionElement.GetProperty("audio").GetProperty("output").GetProperty("voice").GetString().Should().Be("marin");
        sessionElement.GetProperty("reasoning").GetProperty("effort").GetString().Should().Be("low");
    }

    [TestMethod]
    public void OpenAISharp_Serialize_ResponseCreate_GaShape_SupportsToolChoiceAndReasoning()
    {
        var message = new OpenAIRealtimeResponseCreateEvent
        {
            Response = new OpenAIRealtimeResponse
            {
                OutputModalities = ["text"],
                Reasoning = new OpenAIRealtimeReasoning { Effort = "medium" },
                ToolChoice = OpenAIRealtimeToolChoice.Function("lookup_order"),
            }
        };

        var json = JsonSerializer.Serialize<OpenAIRealtimeClientEvent>(message, OpenAIJsonSerializer.Default);
        using var doc = JsonDocument.Parse(json);

        var response = doc.RootElement.GetProperty("response");
        response.GetProperty("output_modalities")[0].GetString().Should().Be("text");
        response.GetProperty("reasoning").GetProperty("effort").GetString().Should().Be("medium");
        response.GetProperty("tool_choice").GetProperty("type").GetString().Should().Be("function");
        response.GetProperty("tool_choice").GetProperty("name").GetString().Should().Be("lookup_order");
        response.TryGetProperty("modalities", out _).Should().BeFalse();
    }

    [TestMethod]
    public void OpenAISharp_Serialize_SessionUpdate_TurnDetectionNull_WritesNull()
    {
        var session = new OpenAIRealtimeSessionUpdate
        {
            Instructions = "Hello",
            TurnDetection = null
        };
        var message = new OpenAIRealtimeSessionUpdateEvent { Session = session };

        var json = JsonSerializer.Serialize<OpenAIRealtimeClientEvent>(message, OpenAIJsonSerializer.Default);
        using var doc = JsonDocument.Parse(json);

        var sessionElement = doc.RootElement.GetProperty("session");
        sessionElement.TryGetProperty("turn_detection", out var turnDetection).Should().BeTrue();
        turnDetection.ValueKind.Should().Be(JsonValueKind.Null);
    }

    [TestMethod]
    public void OpenAISharp_Serialize_SessionUpdate_InputAudioTranscriptionNull_WritesNull()
    {
        var session = new OpenAIRealtimeSessionUpdate
        {
            Instructions = "Hello",
            InputAudioTranscription = null
        };
        var message = new OpenAIRealtimeSessionUpdateEvent { Session = session };

        var json = JsonSerializer.Serialize<OpenAIRealtimeClientEvent>(message, OpenAIJsonSerializer.Default);
        using var doc = JsonDocument.Parse(json);

        var sessionElement = doc.RootElement.GetProperty("session");
        sessionElement.TryGetProperty("input_audio_transcription", out var transcription).Should().BeTrue();
        transcription.ValueKind.Should().Be(JsonValueKind.Null);
    }

    [TestMethod]
    public void OpenAISharp_Serialize_SessionUpdate_UnsetOptional_IsOmitted()
    {
        var session = new OpenAIRealtimeSessionUpdate { Instructions = "Hello" };
        var message = new OpenAIRealtimeSessionUpdateEvent { Session = session };

        var json = JsonSerializer.Serialize<OpenAIRealtimeClientEvent>(message, OpenAIJsonSerializer.Default);
        using var doc = JsonDocument.Parse(json);

        var sessionElement = doc.RootElement.GetProperty("session");
        sessionElement.TryGetProperty("turn_detection", out _).Should().BeFalse();
    }

    [TestMethod]
    public void OpenAISharp_Serialize_TranscriptionSessionUpdate_InputAudioTranscriptionNull_WritesNull()
    {
        var session = new OpenAIRealtimeTranscriptionSessionUpdate
        {
            InputAudioTranscription = null
        };
        var message = new OpenAIRealtimeTranscriptionSessionUpdateEvent { Session = session };

        var json = JsonSerializer.Serialize<OpenAIRealtimeClientEvent>(message, OpenAIJsonSerializer.Default);
        using var doc = JsonDocument.Parse(json);

        var sessionElement = doc.RootElement.GetProperty("session");
        sessionElement.TryGetProperty("input_audio_transcription", out var transcription).Should().BeTrue();
        transcription.ValueKind.Should().Be(JsonValueKind.Null);
    }

    [TestMethod]
    public void OpenAISharp_Serialize_SessionUpdate_GaTranscriptionShape_UsesTranscriptionType()
    {
        var session = new OpenAIRealtimeSessionUpdate
        {
            Type = OpenAIRealtimeSessionTypes.Transcription,
            Audio = new OpenAIRealtimeAudioConfig
            {
                Input = new OpenAIRealtimeInputAudioConfig
                {
                    Format = OpenAIRealtimeAudioFormat.Pcm(),
                    Transcription = new OpenAIRealtimeInputAudioTranscription
                    {
                        Model = OpenAIRealtimeModelIds.GptRealtimeWhisper,
                        Language = "en",
                    },
                    TurnDetection = new OpenAIRealtimeTurnDetection { Type = "server_vad" },
                }
            },
            Include = ["item.input_audio_transcription.logprobs"],
        };
        var message = new OpenAIRealtimeSessionUpdateEvent { Session = session };

        var json = JsonSerializer.Serialize<OpenAIRealtimeClientEvent>(message, OpenAIJsonSerializer.Default);
        using var doc = JsonDocument.Parse(json);

        var sessionElement = doc.RootElement.GetProperty("session");
        sessionElement.GetProperty("type").GetString().Should().Be("transcription");
        sessionElement.GetProperty("audio").GetProperty("input").GetProperty("transcription").GetProperty("model").GetString().Should().Be("gpt-realtime-whisper");
        sessionElement.GetProperty("include")[0].GetString().Should().Be("item.input_audio_transcription.logprobs");
    }

    [TestMethod]
    public void OpenAISharp_Serialize_TranslationInputAudioAppend_UsesSessionInputAudioEventType()
    {
        var audio = new byte[] { 0x05, 0x06, 0x07 };
        var message = new OpenAIRealtimeSessionInputAudioBufferAppendEvent
        {
            Audio = Convert.ToBase64String(audio)
        };

        var json = JsonSerializer.Serialize<OpenAIRealtimeClientEvent>(message, OpenAIJsonSerializer.Default);
        using var doc = JsonDocument.Parse(json);

        doc.RootElement.GetProperty("type").GetString().Should().Be("session.input_audio_buffer.append");
        doc.RootElement.GetProperty("audio").GetString().Should().Be(Convert.ToBase64String(audio));
    }

    [TestMethod]
    public void OpenAISharp_Serialize_McpTool_IncludesRealtimeToolFields()
    {
        var tool = new OpenAIRealtimeTool
        {
            Type = "mcp",
            Name = "linear",
            ServerLabel = "linear",
            ServerUrl = "https://mcp.example.test",
            AllowedTools = ["get_issue"],
            RequireApproval = "always",
            Headers = new Dictionary<string, string> { ["Authorization"] = "Bearer token" },
        };

        var json = JsonSerializer.Serialize(tool, OpenAIJsonSerializer.Default);
        using var doc = JsonDocument.Parse(json);

        var root = doc.RootElement;
        root.GetProperty("type").GetString().Should().Be("mcp");
        root.GetProperty("server_label").GetString().Should().Be("linear");
        root.GetProperty("server_url").GetString().Should().Be("https://mcp.example.test");
        root.GetProperty("allowed_tools")[0].GetString().Should().Be("get_issue");
        root.GetProperty("require_approval").GetString().Should().Be("always");
        root.GetProperty("headers").GetProperty("Authorization").GetString().Should().Be("Bearer token");
    }

    [TestMethod]
    public void OpenAISharp_Deserialize_ClientEvent_UsesPolymorphicTypeDiscriminator()
    {
        var json = """
        {
          "type": "session.update",
          "session": {
            "instructions": "Hello"
          }
        }
        """;

        var evt = JsonSerializer.Deserialize<OpenAIRealtimeClientEvent>(json, OpenAIJsonSerializer.Default);
        var update = evt.Should().BeOfType<OpenAIRealtimeSessionUpdateEvent>().Subject;

        update.Session.Instructions.HasValue.Should().BeTrue();
        update.Session.Instructions.Value.Should().Be("Hello");
    }
}

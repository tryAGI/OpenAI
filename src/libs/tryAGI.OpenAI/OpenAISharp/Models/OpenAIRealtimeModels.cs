using System.Text.Json;
using System.Text.Json.Serialization;

namespace tryAGI.OpenAI.OpenAISharp;

public sealed class OpenAIRealtimeSessionUpdate
{
    [JsonPropertyName("type")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Type { get; init; }

    [JsonPropertyName("model")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Model { get; init; }

    [JsonPropertyName("audio")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimeAudioConfig? Audio { get; init; }

    [JsonPropertyName("output_modalities")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string[]? OutputModalities { get; init; }

    [JsonPropertyName("instructions")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> Instructions { get; init; }

    [JsonPropertyName("input_audio_format")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> InputAudioFormat { get; init; }

    [JsonPropertyName("output_audio_format")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> OutputAudioFormat { get; init; }

    [JsonPropertyName("modalities")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string[]?> Modalities { get; init; }

    [JsonPropertyName("voice")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> Voice { get; init; }

    [JsonPropertyName("temperature")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<double?> Temperature { get; init; }

    [JsonPropertyName("max_output_tokens")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<int?> MaxOutputTokens { get; init; }

    [JsonPropertyName("input_audio_transcription")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<OpenAIRealtimeInputAudioTranscription?> InputAudioTranscription { get; init; }

    [JsonPropertyName("turn_detection")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<OpenAIRealtimeTurnDetection?> TurnDetection { get; init; }

    [JsonPropertyName("tools")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<OpenAIRealtimeTool[]?> Tools { get; init; }

    [JsonPropertyName("tool_choice")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> ToolChoice { get; init; }

    [JsonPropertyName("input_audio_noise_reduction")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<OpenAIRealtimeNoiseReduction?> InputAudioNoiseReduction { get; init; }

    [JsonPropertyName("include")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string[]? Include { get; init; }

    [JsonPropertyName("prompt")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimePrompt? Prompt { get; init; }

    [JsonPropertyName("reasoning")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimeReasoning? Reasoning { get; init; }

    [JsonPropertyName("tracing")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimeTracingConfig? Tracing { get; init; }

    [JsonPropertyName("truncation")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimeTruncation? Truncation { get; init; }
}

public sealed class OpenAIRealtimeTool
{
    [JsonPropertyName("type")]
    public string Type { get; init; } = "function";

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("description")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Description { get; init; }

    [JsonPropertyName("parameters")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public JsonElement? Parameters { get; init; }

    [JsonPropertyName("server_label")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ServerLabel { get; init; }

    [JsonPropertyName("server_url")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ServerUrl { get; init; }

    [JsonPropertyName("allowed_tools")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string[]? AllowedTools { get; init; }

    [JsonPropertyName("require_approval")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? RequireApproval { get; init; }

    [JsonPropertyName("headers")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IReadOnlyDictionary<string, string>? Headers { get; init; }
}

public sealed class OpenAIRealtimeInputAudioTranscription
{
    [JsonPropertyName("model")]
    public string? Model { get; init; }

    [JsonPropertyName("language")]
    public string? Language { get; init; }

    [JsonPropertyName("prompt")]
    public string? Prompt { get; init; }
}

public sealed class OpenAIRealtimeTurnDetection
{
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    [JsonPropertyName("threshold")]
    public double? Threshold { get; init; }

    [JsonPropertyName("silence_duration_ms")]
    public int? SilenceDurationMs { get; init; }

    [JsonPropertyName("prefix_padding_ms")]
    public int? PrefixPaddingMs { get; init; }

    [JsonPropertyName("create_response")]
    public bool? CreateResponse { get; init; }

    [JsonPropertyName("interrupt_response")]
    public bool? InterruptResponse { get; init; }

    [JsonPropertyName("idle_timeout_ms")]
    public int? IdleTimeoutMs { get; init; }

    [JsonPropertyName("eagerness")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Eagerness { get; init; }
}

public sealed class OpenAIRealtimeTranscriptionSessionUpdate
{
    [JsonPropertyName("type")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Type { get; init; }

    [JsonPropertyName("audio")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimeTranscriptionAudioConfig? Audio { get; init; }

    [JsonPropertyName("input_audio_format")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> InputAudioFormat { get; init; }

    [JsonPropertyName("input_audio_transcription")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<OpenAIRealtimeInputAudioTranscription?> InputAudioTranscription { get; init; }

    [JsonPropertyName("turn_detection")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<OpenAIRealtimeTurnDetection?> TurnDetection { get; init; }

    [JsonPropertyName("input_audio_noise_reduction")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<OpenAIRealtimeNoiseReduction?> InputAudioNoiseReduction { get; init; }

    [JsonPropertyName("include")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string[]?> Include { get; init; }
}

public sealed class OpenAIRealtimeNoiseReduction
{
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}

public sealed class OpenAIRealtimeResponse
{
    [JsonPropertyName("audio")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimeAudioConfig? Audio { get; init; }

    [JsonPropertyName("conversation")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Conversation { get; init; }

    [JsonPropertyName("input")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IReadOnlyList<OpenAIRealtimeConversationItem>? Input { get; init; }

    [JsonPropertyName("metadata")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IReadOnlyDictionary<string, string>? Metadata { get; init; }

    [JsonPropertyName("output_modalities")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string[]? OutputModalities { get; init; }

    [JsonPropertyName("modalities")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string[]?> Modalities { get; init; }

    [JsonPropertyName("instructions")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> Instructions { get; init; }

    [JsonPropertyName("voice")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> Voice { get; init; }

    [JsonPropertyName("output_audio_format")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> OutputAudioFormat { get; init; }

    [JsonPropertyName("temperature")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<double?> Temperature { get; init; }

    [JsonPropertyName("max_output_tokens")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<int?> MaxOutputTokens { get; init; }

    [JsonPropertyName("prompt")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimePrompt? Prompt { get; init; }

    [JsonPropertyName("reasoning")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimeReasoning? Reasoning { get; init; }

    [JsonPropertyName("tools")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<OpenAIRealtimeTool[]?> Tools { get; init; }

    [JsonPropertyName("tool_choice")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimeToolChoice? ToolChoice { get; init; }
}

public sealed class OpenAIRealtimeConversationItem
{
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("role")]
    public string? Role { get; init; }

    [JsonPropertyName("content")]
    public IReadOnlyList<OpenAIRealtimeContent>? Content { get; init; }

    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("status")]
    public string? Status { get; init; }

    [JsonPropertyName("call_id")]
    public string? CallId { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("arguments")]
    public string? Arguments { get; init; }

    [JsonPropertyName("output")]
    public string? Output { get; init; }

    [JsonPropertyName("approval_request_id")]
    public string? ApprovalRequestId { get; init; }

    [JsonPropertyName("approve")]
    public bool? Approve { get; init; }

    [JsonPropertyName("reason")]
    public string? Reason { get; init; }
}

[JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
[JsonDerivedType(typeof(OpenAIRealtimeInputTextContent), typeDiscriminator: "input_text")]
[JsonDerivedType(typeof(OpenAIRealtimeInputImageContent), typeDiscriminator: "input_image")]
[JsonDerivedType(typeof(OpenAIRealtimeInputAudioContent), typeDiscriminator: "input_audio")]
public abstract class OpenAIRealtimeContent
{
}

public sealed class OpenAIRealtimeInputTextContent : OpenAIRealtimeContent
{
    [JsonPropertyName("text")]
    public required string Text { get; init; }
}

public sealed class OpenAIRealtimeInputImageContent : OpenAIRealtimeContent
{
    [JsonPropertyName("image_url")]
    public required OpenAIRealtimeImageUrl ImageUrl { get; init; }
}

public sealed class OpenAIRealtimeInputAudioContent : OpenAIRealtimeContent
{
    [JsonPropertyName("audio")]
    public required string Audio { get; init; }
}

public sealed class OpenAIRealtimeImageUrl
{
    [JsonPropertyName("url")]
    public required string Url { get; init; }

    [JsonPropertyName("detail")]
    public string? Detail { get; init; }
}

public static class OpenAIRealtimeSessionTypes
{
    public const string Realtime = "realtime";
    public const string Transcription = "transcription";
}

public static class OpenAIRealtimeModelIds
{
    public const string GptRealtime2 = "gpt-realtime-2";
    public const string GptRealtimeTranslate = "gpt-realtime-translate";
    public const string GptRealtimeWhisper = "gpt-realtime-whisper";
    public const string GptRealtime15 = "gpt-realtime-1.5";
    public const string GptRealtime = "gpt-realtime";
    public const string GptRealtimeMini = "gpt-realtime-mini";
}

public static class OpenAIRealtimeAudioMimeTypes
{
    public const string Pcm = "audio/pcm";
    public const string Pcmu = "audio/pcmu";
    public const string Pcma = "audio/pcma";
}

public sealed class OpenAIRealtimeAudioConfig
{
    [JsonPropertyName("input")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimeInputAudioConfig? Input { get; init; }

    [JsonPropertyName("output")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimeOutputAudioConfig? Output { get; init; }
}

public sealed class OpenAIRealtimeTranscriptionAudioConfig
{
    [JsonPropertyName("input")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimeInputAudioConfig? Input { get; init; }
}

public sealed class OpenAIRealtimeInputAudioConfig
{
    [JsonPropertyName("format")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimeAudioFormat? Format { get; init; }

    [JsonPropertyName("noise_reduction")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<OpenAIRealtimeNoiseReduction?> NoiseReduction { get; init; }

    [JsonPropertyName("transcription")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<OpenAIRealtimeInputAudioTranscription?> Transcription { get; init; }

    [JsonPropertyName("turn_detection")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<OpenAIRealtimeTurnDetection?> TurnDetection { get; init; }
}

public sealed class OpenAIRealtimeOutputAudioConfig
{
    [JsonPropertyName("format")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimeAudioFormat? Format { get; init; }

    [JsonPropertyName("voice")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Voice { get; init; }

    [JsonPropertyName("speed")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Speed { get; init; }

    [JsonPropertyName("language")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Language { get; init; }
}

public sealed class OpenAIRealtimeAudioFormat
{
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("rate")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? Rate { get; init; }

    public static OpenAIRealtimeAudioFormat Pcm(int rate = 24000) => new()
    {
        Type = OpenAIRealtimeAudioMimeTypes.Pcm,
        Rate = rate
    };

    public static OpenAIRealtimeAudioFormat Pcmu() => new()
    {
        Type = OpenAIRealtimeAudioMimeTypes.Pcmu
    };

    public static OpenAIRealtimeAudioFormat Pcma() => new()
    {
        Type = OpenAIRealtimeAudioMimeTypes.Pcma
    };
}

public sealed class OpenAIRealtimePrompt
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("version")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Version { get; init; }

    [JsonPropertyName("variables")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public JsonElement? Variables { get; init; }
}

public sealed class OpenAIRealtimeReasoning
{
    [JsonPropertyName("effort")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Effort { get; init; }
}

public sealed class OpenAIRealtimeTracingConfig
{
    [JsonPropertyName("workflow_name")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? WorkflowName { get; init; }

    [JsonPropertyName("group_id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? GroupId { get; init; }

    [JsonPropertyName("metadata")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IReadOnlyDictionary<string, string>? Metadata { get; init; }
}

public sealed class OpenAIRealtimeTruncation
{
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    [JsonPropertyName("retention_ratio")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? RetentionRatio { get; init; }
}

[JsonConverter(typeof(OpenAIRealtimeToolChoiceJsonConverter))]
public readonly record struct OpenAIRealtimeToolChoice
{
    public OpenAIRealtimeToolChoice(string mode)
    {
        Mode = mode;
        Type = null;
        Name = null;
        ServerLabel = null;
    }

    public OpenAIRealtimeToolChoice(string type, string name, string? serverLabel = null)
    {
        Mode = null;
        Type = type;
        Name = name;
        ServerLabel = serverLabel;
    }

    public string? Mode { get; }
    public string? Type { get; }
    public string? Name { get; }
    public string? ServerLabel { get; }

    public static OpenAIRealtimeToolChoice Auto => new("auto");
    public static OpenAIRealtimeToolChoice None => new("none");
    public static OpenAIRealtimeToolChoice Required => new("required");
    public static OpenAIRealtimeToolChoice Function(string name) => new("function", name);
    public static OpenAIRealtimeToolChoice Mcp(string serverLabel, string name) => new("mcp", name, serverLabel);
    public static OpenAIRealtimeToolChoice FromString(string mode) => new(mode);

    public static implicit operator OpenAIRealtimeToolChoice(string mode) => new(mode);
}

internal sealed class OpenAIRealtimeToolChoiceJsonConverter : JsonConverter<OpenAIRealtimeToolChoice>
{
    public override OpenAIRealtimeToolChoice Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            return new OpenAIRealtimeToolChoice(reader.GetString() ?? string.Empty);
        }

        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        return new OpenAIRealtimeToolChoice(
            root.TryGetProperty("type", out var type) ? type.GetString() ?? string.Empty : string.Empty,
            root.TryGetProperty("name", out var name) ? name.GetString() ?? string.Empty : string.Empty,
            root.TryGetProperty("server_label", out var serverLabel) ? serverLabel.GetString() : null);
    }

    public override void Write(
        Utf8JsonWriter writer,
        OpenAIRealtimeToolChoice value,
        JsonSerializerOptions options)
    {
        if (!string.IsNullOrWhiteSpace(value.Mode))
        {
            writer.WriteStringValue(value.Mode);
            return;
        }

        writer.WriteStartObject();
        writer.WriteString("type", value.Type);
        writer.WriteString("name", value.Name);
        if (!string.IsNullOrWhiteSpace(value.ServerLabel))
        {
            writer.WriteString("server_label", value.ServerLabel);
        }

        writer.WriteEndObject();
    }
}

using System.Text.Json;
using System.Text.Json.Serialization;

namespace tryAGI.OpenAI.OpenAISharp;

/// <inheritdoc />
public sealed class OpenAIRealtimeSessionUpdate
{
    /// <inheritdoc />
    [JsonPropertyName("type")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Type { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("model")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Model { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("audio")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimeAudioConfig? Audio { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("output_modalities")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string[]? OutputModalities { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("instructions")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public OpenAIOptional<string?> Instructions { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("input_audio_format")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public OpenAIOptional<string?> InputAudioFormat { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("output_audio_format")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public OpenAIOptional<string?> OutputAudioFormat { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("modalities")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public OpenAIOptional<string[]?> Modalities { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("voice")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public OpenAIOptional<string?> Voice { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("temperature")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public OpenAIOptional<double?> Temperature { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("max_output_tokens")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public OpenAIOptional<int?> MaxOutputTokens { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("input_audio_transcription")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public OpenAIOptional<OpenAIRealtimeInputAudioTranscription?> InputAudioTranscription { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("turn_detection")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public OpenAIOptional<OpenAIRealtimeTurnDetection?> TurnDetection { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("tools")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public OpenAIOptional<OpenAIRealtimeTool[]?> Tools { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("tool_choice")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public OpenAIOptional<string?> ToolChoice { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("input_audio_noise_reduction")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public OpenAIOptional<OpenAIRealtimeNoiseReduction?> InputAudioNoiseReduction { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("include")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string[]? Include { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("prompt")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimePrompt? Prompt { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("reasoning")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimeReasoning? Reasoning { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("tracing")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimeTracingConfig? Tracing { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("truncation")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimeTruncation? Truncation { get; init; }
}

/// <inheritdoc />
public sealed class OpenAIRealtimeTool
{
    /// <inheritdoc />
    [JsonPropertyName("type")]
    public string Type { get; init; } = "function";

    /// <inheritdoc />
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("description")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Description { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("parameters")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public JsonElement? Parameters { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("server_label")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ServerLabel { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("server_url")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Uri? ServerUrl { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("allowed_tools")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string[]? AllowedTools { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("require_approval")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? RequireApproval { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("headers")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IReadOnlyDictionary<string, string>? Headers { get; init; }
}

/// <inheritdoc />
public sealed class OpenAIRealtimeInputAudioTranscription
{
    /// <inheritdoc />
    [JsonPropertyName("model")]
    public string? Model { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("language")]
    public string? Language { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("prompt")]
    public string? Prompt { get; init; }
}

/// <inheritdoc />
public sealed class OpenAIRealtimeTurnDetection
{
    /// <inheritdoc />
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("threshold")]
    public double? Threshold { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("silence_duration_ms")]
    public int? SilenceDurationMs { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("prefix_padding_ms")]
    public int? PrefixPaddingMs { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("create_response")]
    public bool? CreateResponse { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("interrupt_response")]
    public bool? InterruptResponse { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("idle_timeout_ms")]
    public int? IdleTimeoutMs { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("eagerness")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Eagerness { get; init; }
}

/// <inheritdoc />
public sealed class OpenAIRealtimeTranscriptionSessionUpdate
{
    /// <inheritdoc />
    [JsonPropertyName("type")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Type { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("audio")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimeTranscriptionAudioConfig? Audio { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("input_audio_format")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public OpenAIOptional<string?> InputAudioFormat { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("input_audio_transcription")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public OpenAIOptional<OpenAIRealtimeInputAudioTranscription?> InputAudioTranscription { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("turn_detection")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public OpenAIOptional<OpenAIRealtimeTurnDetection?> TurnDetection { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("input_audio_noise_reduction")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public OpenAIOptional<OpenAIRealtimeNoiseReduction?> InputAudioNoiseReduction { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("include")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public OpenAIOptional<string[]?> Include { get; init; }
}

/// <inheritdoc />
public sealed class OpenAIRealtimeNoiseReduction
{
    /// <inheritdoc />
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}

/// <inheritdoc />
public sealed class OpenAIRealtimeResponse
{
    /// <inheritdoc />
    [JsonPropertyName("audio")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimeAudioConfig? Audio { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("conversation")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Conversation { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("input")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IReadOnlyList<OpenAIRealtimeConversationItem>? Input { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("metadata")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IReadOnlyDictionary<string, string>? Metadata { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("output_modalities")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string[]? OutputModalities { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("modalities")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public OpenAIOptional<string[]?> Modalities { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("instructions")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public OpenAIOptional<string?> Instructions { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("voice")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public OpenAIOptional<string?> Voice { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("output_audio_format")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public OpenAIOptional<string?> OutputAudioFormat { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("temperature")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public OpenAIOptional<double?> Temperature { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("max_output_tokens")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public OpenAIOptional<int?> MaxOutputTokens { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("prompt")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimePrompt? Prompt { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("reasoning")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimeReasoning? Reasoning { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("tools")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public OpenAIOptional<OpenAIRealtimeTool[]?> Tools { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("tool_choice")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimeToolChoice? ToolChoice { get; init; }
}

/// <inheritdoc />
public sealed class OpenAIRealtimeConversationItem
{
    /// <inheritdoc />
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("role")]
    public string? Role { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("content")]
    public IReadOnlyList<OpenAIRealtimeContent>? Content { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("call_id")]
    public string? CallId { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("arguments")]
    public string? Arguments { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("output")]
    public string? Output { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("approval_request_id")]
    public string? ApprovalRequestId { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("approve")]
    public bool? Approve { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }
}

/// <inheritdoc />
[JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
[JsonDerivedType(typeof(OpenAIRealtimeInputTextContent), typeDiscriminator: "input_text")]
[JsonDerivedType(typeof(OpenAIRealtimeInputImageContent), typeDiscriminator: "input_image")]
[JsonDerivedType(typeof(OpenAIRealtimeInputAudioContent), typeDiscriminator: "input_audio")]
public abstract class OpenAIRealtimeContent
{
}

/// <inheritdoc />
public sealed class OpenAIRealtimeInputTextContent : OpenAIRealtimeContent
{
    /// <inheritdoc />
    [JsonPropertyName("text")]
    public required string Text { get; init; }
}

/// <inheritdoc />
public sealed class OpenAIRealtimeInputImageContent : OpenAIRealtimeContent
{
    /// <inheritdoc />
    [JsonPropertyName("image_url")]
    public required OpenAIRealtimeImageUrl ImageUrl { get; init; }
}

/// <inheritdoc />
public sealed class OpenAIRealtimeInputAudioContent : OpenAIRealtimeContent
{
    /// <inheritdoc />
    [JsonPropertyName("audio")]
    public required string Audio { get; init; }
}

/// <inheritdoc />
public sealed class OpenAIRealtimeImageUrl
{
    /// <inheritdoc />
    [JsonPropertyName("url")]
    public required Uri Url { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("detail")]
    public string? Detail { get; init; }
}

/// <inheritdoc />
public static class OpenAIRealtimeSessionTypes
{
    /// <inheritdoc />
    public const string Realtime = "realtime";
    /// <inheritdoc />
    public const string Transcription = "transcription";
}

/// <inheritdoc />
public static class OpenAIRealtimeModelIds
{
    /// <inheritdoc />
    public const string GptRealtime2 = "gpt-realtime-2";
    /// <inheritdoc />
    public const string GptRealtimeTranslate = "gpt-realtime-translate";
    /// <inheritdoc />
    public const string GptRealtimeWhisper = "gpt-realtime-whisper";
    /// <inheritdoc />
    public const string GptRealtime15 = "gpt-realtime-1.5";
    /// <inheritdoc />
    public const string GptRealtime = "gpt-realtime";
    /// <inheritdoc />
    public const string GptRealtimeMini = "gpt-realtime-mini";
}

/// <inheritdoc />
public static class OpenAIRealtimeAudioMimeTypes
{
    /// <inheritdoc />
    public const string Pcm = "audio/pcm";
    /// <inheritdoc />
    public const string Pcmu = "audio/pcmu";
    /// <inheritdoc />
    public const string Pcma = "audio/pcma";
}

/// <inheritdoc />
public sealed class OpenAIRealtimeAudioConfig
{
    /// <inheritdoc />
    [JsonPropertyName("input")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimeInputAudioConfig? Input { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("output")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimeOutputAudioConfig? Output { get; init; }
}

/// <inheritdoc />
public sealed class OpenAIRealtimeTranscriptionAudioConfig
{
    /// <inheritdoc />
    [JsonPropertyName("input")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimeInputAudioConfig? Input { get; init; }
}

/// <inheritdoc />
public sealed class OpenAIRealtimeInputAudioConfig
{
    /// <inheritdoc />
    [JsonPropertyName("format")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimeAudioFormat? Format { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("noise_reduction")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public OpenAIOptional<OpenAIRealtimeNoiseReduction?> NoiseReduction { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("transcription")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public OpenAIOptional<OpenAIRealtimeInputAudioTranscription?> Transcription { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("turn_detection")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public OpenAIOptional<OpenAIRealtimeTurnDetection?> TurnDetection { get; init; }
}

/// <inheritdoc />
public sealed class OpenAIRealtimeOutputAudioConfig
{
    /// <inheritdoc />
    [JsonPropertyName("format")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAIRealtimeAudioFormat? Format { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("voice")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Voice { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("speed")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Speed { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("language")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Language { get; init; }
}

/// <inheritdoc />
public sealed class OpenAIRealtimeAudioFormat
{
    /// <inheritdoc />
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("rate")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? Rate { get; init; }

    /// <inheritdoc />
    public static OpenAIRealtimeAudioFormat Pcm(int rate = 24000) => new()
    {
        Type = OpenAIRealtimeAudioMimeTypes.Pcm,
        Rate = rate
    };

    /// <inheritdoc />
    public static OpenAIRealtimeAudioFormat Pcmu() => new()
    {
        Type = OpenAIRealtimeAudioMimeTypes.Pcmu
    };

    /// <inheritdoc />
    public static OpenAIRealtimeAudioFormat Pcma() => new()
    {
        Type = OpenAIRealtimeAudioMimeTypes.Pcma
    };
}

/// <inheritdoc />
public sealed class OpenAIRealtimePrompt
{
    /// <inheritdoc />
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("version")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Version { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("variables")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public JsonElement? Variables { get; init; }
}

/// <inheritdoc />
public sealed class OpenAIRealtimeReasoning
{
    /// <inheritdoc />
    [JsonPropertyName("effort")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Effort { get; init; }
}

/// <inheritdoc />
public sealed class OpenAIRealtimeTracingConfig
{
    /// <inheritdoc />
    [JsonPropertyName("workflow_name")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? WorkflowName { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("group_id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? GroupId { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("metadata")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IReadOnlyDictionary<string, string>? Metadata { get; init; }
}

/// <inheritdoc />
public sealed class OpenAIRealtimeTruncation
{
    /// <inheritdoc />
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("retention_ratio")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? RetentionRatio { get; init; }
}

/// <inheritdoc />
[JsonConverter(typeof(OpenAIRealtimeToolChoiceJsonConverter))]
public readonly record struct OpenAIRealtimeToolChoice
{
    /// <inheritdoc />
    public OpenAIRealtimeToolChoice(string mode)
    {
        Mode = mode;
        Type = null;
        Name = null;
        ServerLabel = null;
    }

    /// <inheritdoc />
    public OpenAIRealtimeToolChoice(string type, string name, string? serverLabel = null)
    {
        Mode = null;
        Type = type;
        Name = name;
        ServerLabel = serverLabel;
    }

    /// <inheritdoc />
    public string? Mode { get; }
    /// <inheritdoc />
    public string? Type { get; }
    /// <inheritdoc />
    public string? Name { get; }
    /// <inheritdoc />
    public string? ServerLabel { get; }

    /// <inheritdoc />
    public static OpenAIRealtimeToolChoice Auto => new("auto");
    /// <inheritdoc />
    public static OpenAIRealtimeToolChoice None => new("none");
    /// <inheritdoc />
    public static OpenAIRealtimeToolChoice Required => new("required");
    /// <inheritdoc />
    public static OpenAIRealtimeToolChoice Function(string name) => new("function", name);
    /// <inheritdoc />
    public static OpenAIRealtimeToolChoice Mcp(string serverLabel, string name) => new("mcp", name, serverLabel);
    /// <inheritdoc />
    public static OpenAIRealtimeToolChoice FromString(string mode) => new(mode);

    /// <inheritdoc />
    public static implicit operator OpenAIRealtimeToolChoice(string mode) => new(mode);
}

internal sealed class OpenAIRealtimeToolChoiceJsonConverter : JsonConverter<OpenAIRealtimeToolChoice>
{
    /// <inheritdoc />
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

    /// <inheritdoc />
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

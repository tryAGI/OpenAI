using System.Text.Json;

namespace tryAGI.OpenAI.OpenAISharp;

/// <summary>
/// Enum for all known OpenAI Realtime server event types.
/// Enables typed switch/pattern matching instead of string comparisons.
/// </summary>
public enum RealtimeServerEventType
{
    /// <inheritdoc />
    Unknown,
    /// <inheritdoc />
    Error,
    /// <inheritdoc />
    SessionCreated,
    /// <inheritdoc />
    SessionUpdated,
    /// <inheritdoc />
    ResponseCreated,
    /// <inheritdoc />
    ResponseDone,
    /// <inheritdoc />
    ResponseAudioDelta,
    /// <inheritdoc />
    ResponseAudioDone,
    /// <inheritdoc />
    ResponseAudioTranscriptDelta,
    /// <inheritdoc />
    ResponseAudioTranscriptDone,
    /// <inheritdoc />
    ResponseOutputAudioDelta,
    /// <inheritdoc />
    ResponseOutputAudioDone,
    /// <inheritdoc />
    ResponseOutputAudioTranscriptDelta,
    /// <inheritdoc />
    ResponseOutputAudioTranscriptDone,
    /// <inheritdoc />
    ResponseOutputTextDelta,
    /// <inheritdoc />
    ResponseOutputTextDone,
    /// <inheritdoc />
    ResponseContentPartAdded,
    /// <inheritdoc />
    ResponseContentPartDone,
    /// <inheritdoc />
    ResponseTextDelta,
    /// <inheritdoc />
    ResponseTextDone,
    /// <inheritdoc />
    ResponseFunctionCallArgumentsDelta,
    /// <inheritdoc />
    ResponseFunctionCallArgumentsDone,
    /// <inheritdoc />
    ResponseOutputItemAdded,
    /// <inheritdoc />
    ResponseOutputItemDone,
    /// <inheritdoc />
    ConversationCreated,
    /// <inheritdoc />
    ConversationItemAdded,
    /// <inheritdoc />
    ConversationItemDone,
    /// <inheritdoc />
    ConversationItemCreated,
    /// <inheritdoc />
    ConversationItemDeleted,
    /// <inheritdoc />
    ConversationItemTruncated,
    /// <inheritdoc />
    ConversationItemInputAudioTranscriptionDelta,
    /// <inheritdoc />
    ConversationItemInputAudioTranscriptionCompleted,
    /// <inheritdoc />
    ConversationItemInputAudioTranscriptionFailed,
    /// <inheritdoc />
    InputAudioBufferSpeechStarted,
    /// <inheritdoc />
    InputAudioBufferSpeechStopped,
    /// <inheritdoc />
    InputAudioBufferCommitted,
    /// <inheritdoc />
    InputAudioBufferCleared,
    /// <inheritdoc />
    InputAudioBufferTimeoutTriggered,
    /// <inheritdoc />
    OutputAudioBufferCleared,
    /// <inheritdoc />
    SessionInputAudioBufferCommitted,
    /// <inheritdoc />
    SessionInputTranscriptDelta,
    /// <inheritdoc />
    SessionOutputAudioDelta,
    /// <inheritdoc />
    SessionOutputTranscriptDelta,
    /// <inheritdoc />
    RateLimitsUpdated,
}

/// <summary>
/// Base type for realtime events received from OpenAI.
/// </summary>
public abstract record OpenAIRealtimeEvent
{
    /// <inheritdoc />
    public string Type { get; init; } = string.Empty;
    /// <inheritdoc />
    public RealtimeServerEventType EventType { get; init; }
    /// <inheritdoc />
    public string RawJson { get; init; } = string.Empty;
    /// <inheritdoc />
    public string? EventId { get; init; }
}

/// <inheritdoc />
public sealed record OpenAIRealtimeErrorEvent : OpenAIRealtimeEvent
{
    /// <inheritdoc />
    public required OpenAIRealtimeError Error { get; init; }
}

/// <inheritdoc />
public sealed record OpenAIRealtimeSessionEvent : OpenAIRealtimeEvent
{
    /// <inheritdoc />
    public required JsonElement Session { get; init; }
}

/// <inheritdoc />
public sealed record OpenAIRealtimeResponseEvent : OpenAIRealtimeEvent
{
    /// <inheritdoc />
    public required JsonElement Response { get; init; }
}

/// <inheritdoc />
public sealed record OpenAIRealtimeConversationItemEvent : OpenAIRealtimeEvent
{
    /// <inheritdoc />
    public required JsonElement Item { get; init; }
}

/// <inheritdoc />
public sealed record OpenAIRealtimeConversationEvent : OpenAIRealtimeEvent
{
    /// <inheritdoc />
    public required JsonElement Conversation { get; init; }
}

/// <inheritdoc />
public sealed record OpenAIRealtimeContentPartEvent : OpenAIRealtimeEvent
{
    /// <inheritdoc />
    public required JsonElement Part { get; init; }
}

/// <inheritdoc />
public sealed record OpenAIRealtimeRateLimitsEvent : OpenAIRealtimeEvent
{
    /// <inheritdoc />
    public required JsonElement RateLimits { get; init; }
}

/// <inheritdoc />
public sealed record OpenAIRealtimeUnknownEvent : OpenAIRealtimeEvent;

/// <summary>
/// response.audio.delta - carries decoded audio bytes.
/// </summary>
public sealed record OpenAIRealtimeAudioDeltaEvent : OpenAIRealtimeEvent
{
    /// <inheritdoc />
    public required byte[] AudioBytes { get; init; }
    /// <inheritdoc />
    public string? ItemId { get; init; }
    /// <inheritdoc />
    public int? OutputIndex { get; init; }
    /// <inheritdoc />
    public int? ContentIndex { get; init; }
}

/// <summary>
/// response.function_call_arguments.delta - carries incremental function call arguments.
/// </summary>
public sealed record OpenAIRealtimeFunctionCallArgsDeltaEvent : OpenAIRealtimeEvent
{
    /// <inheritdoc />
    public required string ItemId { get; init; }
    /// <inheritdoc />
    public required string CallId { get; init; }
    /// <inheritdoc />
    public required string Delta { get; init; }
}

/// <summary>
/// response.function_call_arguments.done - carries the complete function call arguments.
/// </summary>
public sealed record OpenAIRealtimeFunctionCallArgsDoneEvent : OpenAIRealtimeEvent
{
    /// <inheritdoc />
    public required string ItemId { get; init; }
    /// <inheritdoc />
    public required string CallId { get; init; }
    /// <inheritdoc />
    public required string Arguments { get; init; }
}

/// <summary>
/// response.output_text.delta, response.output_audio_transcript.delta, and translation transcript deltas.
/// </summary>
public sealed record OpenAIRealtimeTextDeltaEvent : OpenAIRealtimeEvent
{
    /// <inheritdoc />
    public required string Delta { get; init; }
    /// <inheritdoc />
    public string? ResponseId { get; init; }
    /// <inheritdoc />
    public string? ItemId { get; init; }
    /// <inheritdoc />
    public int? OutputIndex { get; init; }
    /// <inheritdoc />
    public int? ContentIndex { get; init; }
}

/// <summary>
/// response.output_item.done - carries the full item JSON.
/// </summary>
public sealed record OpenAIRealtimeOutputItemDoneEvent : OpenAIRealtimeEvent
{
    /// <inheritdoc />
    public required JsonElement Item { get; init; }
}

/// <summary>
/// input_audio_buffer.speech_started - user started speaking.
/// </summary>
public sealed record OpenAIRealtimeSpeechStartedEvent : OpenAIRealtimeEvent
{
    /// <inheritdoc />
    public int? AudioStartMs { get; init; }
}

/// <summary>
/// input_audio_buffer.speech_stopped - user stopped speaking.
/// </summary>
public sealed record OpenAIRealtimeSpeechStoppedEvent : OpenAIRealtimeEvent
{
    /// <inheritdoc />
    public int? AudioEndMs { get; init; }
}

/// <summary>
/// conversation.item.input_audio_transcription.completed - transcription of user audio.
/// </summary>
public sealed record OpenAIRealtimeTranscriptionCompletedEvent : OpenAIRealtimeEvent
{
    /// <inheritdoc />
    public string? ItemId { get; init; }
    /// <inheritdoc />
    public int? ContentIndex { get; init; }
    /// <inheritdoc />
    public string? Transcript { get; init; }
    /// <inheritdoc />
    public string? Speaker { get; init; }
}

/// <summary>
/// conversation.item.input_audio_transcription.delta - incremental transcription of user audio.
/// </summary>
public sealed record OpenAIRealtimeTranscriptionDeltaEvent : OpenAIRealtimeEvent
{
    /// <inheritdoc />
    public string? ItemId { get; init; }
    /// <inheritdoc />
    public int? ContentIndex { get; init; }
    /// <inheritdoc />
    public required string Delta { get; init; }
    /// <inheritdoc />
    public JsonElement? Logprobs { get; init; }
}

/// <inheritdoc />
public sealed record OpenAIRealtimeError(string? Type, string? Code, string? Message, string? Param);

/// <inheritdoc />
public static class OpenAIRealtimeEventParser
{
    private static readonly Dictionary<string, RealtimeServerEventType> EventTypeMap = new(StringComparer.Ordinal)
    {
        ["error"] = RealtimeServerEventType.Error,
        ["session.created"] = RealtimeServerEventType.SessionCreated,
        ["session.updated"] = RealtimeServerEventType.SessionUpdated,
        ["response.created"] = RealtimeServerEventType.ResponseCreated,
        ["response.done"] = RealtimeServerEventType.ResponseDone,
        ["response.audio.delta"] = RealtimeServerEventType.ResponseAudioDelta,
        ["response.audio.done"] = RealtimeServerEventType.ResponseAudioDone,
        ["response.audio_transcript.delta"] = RealtimeServerEventType.ResponseAudioTranscriptDelta,
        ["response.audio_transcript.done"] = RealtimeServerEventType.ResponseAudioTranscriptDone,
        ["response.output_audio.delta"] = RealtimeServerEventType.ResponseOutputAudioDelta,
        ["response.output_audio.done"] = RealtimeServerEventType.ResponseOutputAudioDone,
        ["response.output_audio_transcript.delta"] = RealtimeServerEventType.ResponseOutputAudioTranscriptDelta,
        ["response.output_audio_transcript.done"] = RealtimeServerEventType.ResponseOutputAudioTranscriptDone,
        ["response.output_text.delta"] = RealtimeServerEventType.ResponseOutputTextDelta,
        ["response.output_text.done"] = RealtimeServerEventType.ResponseOutputTextDone,
        ["response.content_part.added"] = RealtimeServerEventType.ResponseContentPartAdded,
        ["response.content_part.done"] = RealtimeServerEventType.ResponseContentPartDone,
        ["response.text.delta"] = RealtimeServerEventType.ResponseTextDelta,
        ["response.text.done"] = RealtimeServerEventType.ResponseTextDone,
        ["response.function_call_arguments.delta"] = RealtimeServerEventType.ResponseFunctionCallArgumentsDelta,
        ["response.function_call_arguments.done"] = RealtimeServerEventType.ResponseFunctionCallArgumentsDone,
        ["response.output_item.added"] = RealtimeServerEventType.ResponseOutputItemAdded,
        ["response.output_item.done"] = RealtimeServerEventType.ResponseOutputItemDone,
        ["conversation.created"] = RealtimeServerEventType.ConversationCreated,
        ["conversation.item.added"] = RealtimeServerEventType.ConversationItemAdded,
        ["conversation.item.done"] = RealtimeServerEventType.ConversationItemDone,
        ["conversation.item.created"] = RealtimeServerEventType.ConversationItemCreated,
        ["conversation.item.deleted"] = RealtimeServerEventType.ConversationItemDeleted,
        ["conversation.item.truncated"] = RealtimeServerEventType.ConversationItemTruncated,
        ["conversation.item.input_audio_transcription.delta"] = RealtimeServerEventType.ConversationItemInputAudioTranscriptionDelta,
        ["conversation.item.input_audio_transcription.completed"] = RealtimeServerEventType.ConversationItemInputAudioTranscriptionCompleted,
        ["conversation.item.input_audio_transcription.failed"] = RealtimeServerEventType.ConversationItemInputAudioTranscriptionFailed,
        ["input_audio_buffer.speech_started"] = RealtimeServerEventType.InputAudioBufferSpeechStarted,
        ["input_audio_buffer.speech_stopped"] = RealtimeServerEventType.InputAudioBufferSpeechStopped,
        ["input_audio_buffer.committed"] = RealtimeServerEventType.InputAudioBufferCommitted,
        ["input_audio_buffer.cleared"] = RealtimeServerEventType.InputAudioBufferCleared,
        ["input_audio_buffer.timeout_triggered"] = RealtimeServerEventType.InputAudioBufferTimeoutTriggered,
        ["output_audio_buffer.cleared"] = RealtimeServerEventType.OutputAudioBufferCleared,
        ["session.input_audio_buffer.committed"] = RealtimeServerEventType.SessionInputAudioBufferCommitted,
        ["session.input_transcript.delta"] = RealtimeServerEventType.SessionInputTranscriptDelta,
        ["session.output_audio.delta"] = RealtimeServerEventType.SessionOutputAudioDelta,
        ["session.output_transcript.delta"] = RealtimeServerEventType.SessionOutputTranscriptDelta,
        ["rate_limits.updated"] = RealtimeServerEventType.RateLimitsUpdated,
    };

    /// <summary>
    /// All server event type strings the parser recognizes. Useful for build-time
    /// guards that assert every known event type is either handled or explicitly
    /// listed as intentionally ignored by downstream code.
    /// </summary>
    public static IReadOnlyCollection<string> KnownEventTypes => EventTypeMap.Keys;

    /// <inheritdoc />
    public static OpenAIRealtimeEvent Parse(string json)
    {
        using var doc = JsonDocument.Parse(json);
        var root = doc.RootElement;

        var type = GetString(root, "type") ?? "unknown";
        var eventId = GetString(root, "event_id");
        var eventType = EventTypeMap.GetValueOrDefault(type, RealtimeServerEventType.Unknown);

        // Create typed subtypes based on the event type string
        return eventType switch
        {
            RealtimeServerEventType.Error => ParseError(root, type, eventType, eventId, json),
            RealtimeServerEventType.ResponseAudioDelta or
            RealtimeServerEventType.ResponseOutputAudioDelta or
            RealtimeServerEventType.SessionOutputAudioDelta => ParseAudioDelta(root, type, eventType, eventId, json),
            RealtimeServerEventType.ResponseTextDelta or
            RealtimeServerEventType.ResponseOutputTextDelta or
            RealtimeServerEventType.ResponseAudioTranscriptDelta or
            RealtimeServerEventType.ResponseOutputAudioTranscriptDelta or
            RealtimeServerEventType.SessionInputTranscriptDelta or
            RealtimeServerEventType.SessionOutputTranscriptDelta => ParseTextDelta(root, type, eventType, eventId, json),
            RealtimeServerEventType.ResponseFunctionCallArgumentsDelta => ParseFunctionCallArgsDelta(root, type, eventType, eventId, json),
            RealtimeServerEventType.ResponseFunctionCallArgumentsDone => ParseFunctionCallArgsDone(root, type, eventType, eventId, json),
            RealtimeServerEventType.ResponseOutputItemDone => ParseOutputItemDone(root, type, eventType, eventId, json),
            RealtimeServerEventType.InputAudioBufferSpeechStarted => ParseSpeechStarted(root, type, eventType, eventId, json),
            RealtimeServerEventType.InputAudioBufferSpeechStopped => ParseSpeechStopped(root, type, eventType, eventId, json),
            RealtimeServerEventType.ConversationItemInputAudioTranscriptionDelta => ParseTranscriptionDelta(root, type, eventType, eventId, json),
            RealtimeServerEventType.ConversationItemInputAudioTranscriptionCompleted => ParseTranscriptionCompleted(root, type, eventType, eventId, json),
            _ => ParseGeneric(root, type, eventType, eventId, json),
        };
    }

    private static OpenAIRealtimeErrorEvent ParseError(JsonElement root, string type, RealtimeServerEventType eventType, string? eventId, string json)
    {
        var error = new OpenAIRealtimeError(null, null, null, null);
        if (root.TryGetProperty("error", out var errorElement))
        {
            error = new OpenAIRealtimeError(
                Type: GetString(errorElement, "type"),
                Code: GetString(errorElement, "code"),
                Message: GetString(errorElement, "message"),
                Param: GetString(errorElement, "param"));
        }

        return new OpenAIRealtimeErrorEvent
        {
            Type = type,
            EventType = eventType,
            RawJson = json,
            EventId = eventId,
            Error = error
        };
    }

    private static OpenAIRealtimeAudioDeltaEvent ParseAudioDelta(JsonElement root, string type, RealtimeServerEventType eventType, string? eventId, string json)
    {
        byte[] audioBytes = [];
        if (root.TryGetProperty("delta", out var deltaProp) && deltaProp.ValueKind == JsonValueKind.String)
        {
            var base64 = deltaProp.GetString();
            if (!string.IsNullOrEmpty(base64))
            {
                audioBytes = Convert.FromBase64String(base64);
            }
        }

        string? itemId = GetString(root, "item_id");
        int? outputIndex = root.TryGetProperty("output_index", out var oi) && oi.ValueKind == JsonValueKind.Number ? oi.GetInt32() : null;
        int? contentIndex = root.TryGetProperty("content_index", out var ci) && ci.ValueKind == JsonValueKind.Number ? ci.GetInt32() : null;

        return new OpenAIRealtimeAudioDeltaEvent
        {
            Type = type,
            EventType = eventType,
            RawJson = json,
            EventId = eventId,
            AudioBytes = audioBytes,
            ItemId = itemId,
            OutputIndex = outputIndex,
            ContentIndex = contentIndex,
        };
    }

    private static OpenAIRealtimeFunctionCallArgsDeltaEvent ParseFunctionCallArgsDelta(JsonElement root, string type, RealtimeServerEventType eventType, string? eventId, string json)
    {
        return new OpenAIRealtimeFunctionCallArgsDeltaEvent
        {
            Type = type,
            EventType = eventType,
            RawJson = json,
            EventId = eventId,
            ItemId = GetString(root, "item_id") ?? string.Empty,
            CallId = GetString(root, "call_id") ?? string.Empty,
            Delta = GetString(root, "delta") ?? string.Empty,
        };
    }

    private static OpenAIRealtimeFunctionCallArgsDoneEvent ParseFunctionCallArgsDone(JsonElement root, string type, RealtimeServerEventType eventType, string? eventId, string json)
    {
        return new OpenAIRealtimeFunctionCallArgsDoneEvent
        {
            Type = type,
            EventType = eventType,
            RawJson = json,
            EventId = eventId,
            ItemId = GetString(root, "item_id") ?? string.Empty,
            CallId = GetString(root, "call_id") ?? string.Empty,
            Arguments = GetString(root, "arguments") ?? string.Empty,
        };
    }

    private static OpenAIRealtimeTextDeltaEvent ParseTextDelta(JsonElement root, string type, RealtimeServerEventType eventType, string? eventId, string json)
    {
        return new OpenAIRealtimeTextDeltaEvent
        {
            Type = type,
            EventType = eventType,
            RawJson = json,
            EventId = eventId,
            Delta = GetString(root, "delta") ?? string.Empty,
            ResponseId = GetString(root, "response_id"),
            ItemId = GetString(root, "item_id"),
            OutputIndex = GetInt(root, "output_index"),
            ContentIndex = GetInt(root, "content_index"),
        };
    }

    private static OpenAIRealtimeOutputItemDoneEvent ParseOutputItemDone(JsonElement root, string type, RealtimeServerEventType eventType, string? eventId, string json)
    {
        var item = root.TryGetProperty("item", out var itemElement) ? itemElement.Clone() : default;

        return new OpenAIRealtimeOutputItemDoneEvent
        {
            Type = type,
            EventType = eventType,
            RawJson = json,
            EventId = eventId,
            Item = item,
        };
    }

    private static OpenAIRealtimeSpeechStartedEvent ParseSpeechStarted(JsonElement root, string type, RealtimeServerEventType eventType, string? eventId, string json)
    {
        int? audioStartMs = root.TryGetProperty("audio_start_ms", out var asm) && asm.ValueKind == JsonValueKind.Number
            ? asm.GetInt32()
            : null;

        return new OpenAIRealtimeSpeechStartedEvent
        {
            Type = type,
            EventType = eventType,
            RawJson = json,
            EventId = eventId,
            AudioStartMs = audioStartMs,
        };
    }

    private static OpenAIRealtimeSpeechStoppedEvent ParseSpeechStopped(JsonElement root, string type, RealtimeServerEventType eventType, string? eventId, string json)
    {
        int? audioEndMs = root.TryGetProperty("audio_end_ms", out var aem) && aem.ValueKind == JsonValueKind.Number
            ? aem.GetInt32()
            : null;

        return new OpenAIRealtimeSpeechStoppedEvent
        {
            Type = type,
            EventType = eventType,
            RawJson = json,
            EventId = eventId,
            AudioEndMs = audioEndMs,
        };
    }

    private static OpenAIRealtimeTranscriptionCompletedEvent ParseTranscriptionCompleted(JsonElement root, string type, RealtimeServerEventType eventType, string? eventId, string json)
    {
        return new OpenAIRealtimeTranscriptionCompletedEvent
        {
            Type = type,
            EventType = eventType,
            RawJson = json,
            EventId = eventId,
            ItemId = GetString(root, "item_id"),
            ContentIndex = GetInt(root, "content_index"),
            Transcript = GetString(root, "transcript"),
            Speaker = GetString(root, "speaker"),
        };
    }

    private static OpenAIRealtimeTranscriptionDeltaEvent ParseTranscriptionDelta(JsonElement root, string type, RealtimeServerEventType eventType, string? eventId, string json)
    {
        return new OpenAIRealtimeTranscriptionDeltaEvent
        {
            Type = type,
            EventType = eventType,
            RawJson = json,
            EventId = eventId,
            ItemId = GetString(root, "item_id"),
            ContentIndex = GetInt(root, "content_index"),
            Delta = GetString(root, "delta") ?? string.Empty,
            Logprobs = root.TryGetProperty("logprobs", out var logprobs) ? logprobs.Clone() : null,
        };
    }

    private static OpenAIRealtimeEvent ParseGeneric(JsonElement root, string type, RealtimeServerEventType eventType, string? eventId, string json)
    {
        if (root.TryGetProperty("session", out var sessionElement))
        {
            return new OpenAIRealtimeSessionEvent
            {
                Type = type,
                EventType = eventType,
                RawJson = json,
                EventId = eventId,
                Session = sessionElement.Clone()
            };
        }

        if (root.TryGetProperty("response", out var responseElement))
        {
            return new OpenAIRealtimeResponseEvent
            {
                Type = type,
                EventType = eventType,
                RawJson = json,
                EventId = eventId,
                Response = responseElement.Clone()
            };
        }

        if (root.TryGetProperty("item", out var itemElement))
        {
            return new OpenAIRealtimeConversationItemEvent
            {
                Type = type,
                EventType = eventType,
                RawJson = json,
                EventId = eventId,
                Item = itemElement.Clone()
            };
        }

        if (root.TryGetProperty("part", out var partElement))
        {
            return new OpenAIRealtimeContentPartEvent
            {
                Type = type,
                EventType = eventType,
                RawJson = json,
                EventId = eventId,
                Part = partElement.Clone()
            };
        }

        if (root.TryGetProperty("conversation", out var conversationElement))
        {
            return new OpenAIRealtimeConversationEvent
            {
                Type = type,
                EventType = eventType,
                RawJson = json,
                EventId = eventId,
                Conversation = conversationElement.Clone()
            };
        }

        if (root.TryGetProperty("rate_limits", out var rateLimitsElement))
        {
            return new OpenAIRealtimeRateLimitsEvent
            {
                Type = type,
                EventType = eventType,
                RawJson = json,
                EventId = eventId,
                RateLimits = rateLimitsElement.Clone()
            };
        }

        return new OpenAIRealtimeUnknownEvent
        {
            Type = type,
            EventType = eventType,
            RawJson = json,
            EventId = eventId
        };
    }

    private static string? GetString(JsonElement element, string name)
    {
        return element.TryGetProperty(name, out var property) && property.ValueKind == JsonValueKind.String
            ? property.GetString()
            : null;
    }

    private static int? GetInt(JsonElement element, string name)
    {
        return element.TryGetProperty(name, out var property) && property.ValueKind == JsonValueKind.Number
            ? property.GetInt32()
            : null;
    }
}

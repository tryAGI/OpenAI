using System.Text.Json.Serialization;

namespace tryAGI.OpenAI.OpenAISharp;

/// <summary>
/// Base type for client-sent realtime events.
/// <para>
/// <b>IMPORTANT:</b> Always serialize via the base type (<c>OpenAIRealtimeClientEvent</c>)
/// to include the polymorphic <c>"type"</c> discriminator in the JSON output.
/// Serializing via a concrete derived type's <c>JsonTypeInfo&lt;T&gt;</c> will skip the
/// discriminator, producing invalid payloads that the OpenAI API rejects.
/// Use <see cref="tryAGI.OpenAI.OpenAISharp.Realtime.OpenAIRealtimeSession.SendEventAsync"/> or the
/// typed helpers (e.g., <c>SendConversationItemDeleteAsync</c>) which route through
/// the base-class serializer automatically.
/// </para>
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
[JsonDerivedType(typeof(OpenAIRealtimeSessionUpdateEvent), typeDiscriminator: "session.update")]
[JsonDerivedType(typeof(OpenAIRealtimeResponseCreateEvent), typeDiscriminator: "response.create")]
[JsonDerivedType(typeof(OpenAIRealtimeResponseCancelEvent), typeDiscriminator: "response.cancel")]
[JsonDerivedType(typeof(OpenAIRealtimeConversationItemCreateEvent), typeDiscriminator: "conversation.item.create")]
[JsonDerivedType(typeof(OpenAIRealtimeConversationItemDeleteEvent), typeDiscriminator: "conversation.item.delete")]
[JsonDerivedType(typeof(OpenAIRealtimeConversationItemTruncateEvent), typeDiscriminator: "conversation.item.truncate")]
[JsonDerivedType(typeof(OpenAIRealtimeInputAudioBufferAppendEvent), typeDiscriminator: "input_audio_buffer.append")]
[JsonDerivedType(typeof(OpenAIRealtimeInputAudioBufferCommitEvent), typeDiscriminator: "input_audio_buffer.commit")]
[JsonDerivedType(typeof(OpenAIRealtimeInputAudioBufferClearEvent), typeDiscriminator: "input_audio_buffer.clear")]
[JsonDerivedType(typeof(OpenAIRealtimeOutputAudioBufferClearEvent), typeDiscriminator: "output_audio_buffer.clear")]
[JsonDerivedType(typeof(OpenAIRealtimeSessionInputAudioBufferAppendEvent), typeDiscriminator: "session.input_audio_buffer.append")]
[JsonDerivedType(typeof(OpenAIRealtimeTranscriptionSessionUpdateEvent), typeDiscriminator: "transcription_session.update")]
public abstract record OpenAIRealtimeClientEvent
{
    /// <inheritdoc />
    [JsonPropertyName("event_id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? EventId { get; init; }
}

/// <inheritdoc />
public sealed record OpenAIRealtimeSessionUpdateEvent : OpenAIRealtimeClientEvent
{
    /// <inheritdoc />
    [JsonPropertyName("session")]
    public required OpenAIRealtimeSessionUpdate Session { get; init; }
}

/// <inheritdoc />
public sealed record OpenAIRealtimeResponseCreateEvent : OpenAIRealtimeClientEvent
{
    /// <inheritdoc />
    [JsonPropertyName("response")]
    public required OpenAIRealtimeResponse Response { get; init; }
}

/// <inheritdoc />
public sealed record OpenAIRealtimeResponseCancelEvent : OpenAIRealtimeClientEvent
{
    /// <inheritdoc />
    [JsonPropertyName("response_id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResponseId { get; init; }
}

/// <inheritdoc />
public sealed record OpenAIRealtimeConversationItemCreateEvent : OpenAIRealtimeClientEvent
{
    /// <inheritdoc />
    [JsonPropertyName("item")]
    public required OpenAIRealtimeConversationItem Item { get; init; }
}

/// <inheritdoc />
public sealed record OpenAIRealtimeConversationItemDeleteEvent : OpenAIRealtimeClientEvent
{
    /// <inheritdoc />
    [JsonPropertyName("item_id")]
    public required string ItemId { get; init; }
}

/// <inheritdoc />
public sealed record OpenAIRealtimeConversationItemTruncateEvent : OpenAIRealtimeClientEvent
{
    /// <inheritdoc />
    [JsonPropertyName("item_id")]
    public required string ItemId { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("content_index")]
    public int? ContentIndex { get; init; }

    /// <inheritdoc />
    [JsonPropertyName("audio_end_ms")]
    public int? AudioEndMs { get; init; }
}

/// <inheritdoc />
public sealed record OpenAIRealtimeInputAudioBufferAppendEvent : OpenAIRealtimeClientEvent
{
    /// <inheritdoc />
    [JsonPropertyName("audio")]
    public required string Audio { get; init; }
}

/// <inheritdoc />
public sealed record OpenAIRealtimeInputAudioBufferCommitEvent : OpenAIRealtimeClientEvent
{
}

/// <inheritdoc />
public sealed record OpenAIRealtimeInputAudioBufferClearEvent : OpenAIRealtimeClientEvent
{
}

/// <inheritdoc />
public sealed record OpenAIRealtimeOutputAudioBufferClearEvent : OpenAIRealtimeClientEvent
{
}

/// <inheritdoc />
public sealed record OpenAIRealtimeSessionInputAudioBufferAppendEvent : OpenAIRealtimeClientEvent
{
    /// <inheritdoc />
    [JsonPropertyName("audio")]
    public required string Audio { get; init; }
}

/// <inheritdoc />
public sealed record OpenAIRealtimeTranscriptionSessionUpdateEvent : OpenAIRealtimeClientEvent
{
    /// <inheritdoc />
    [JsonPropertyName("session")]
    public required OpenAIRealtimeTranscriptionSessionUpdate Session { get; init; }
}

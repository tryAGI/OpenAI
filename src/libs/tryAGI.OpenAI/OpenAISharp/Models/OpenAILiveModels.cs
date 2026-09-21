using System.Text.Json;
using System.Text.Json.Serialization;

namespace tryAGI.OpenAI.OpenAISharp;

/// <summary>
/// Base type for events accepted by the GPT-Live primary WebSocket.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
[JsonDerivedType(typeof(OpenAILiveSessionStartEvent), "session.start")]
[JsonDerivedType(typeof(OpenAILiveInputAudioAppendEvent), "session.input_audio.append")]
[JsonDerivedType(typeof(OpenAILiveInstructionsAppendEvent), "session.instructions.append")]
[JsonDerivedType(typeof(OpenAILiveSessionUpdateEvent), "session.update")]
[JsonDerivedType(typeof(OpenAILiveResponseInputItemCreateEvent), "response.input_item.create")]
[JsonDerivedType(typeof(OpenAILiveResponseCreateEvent), "response.create")]
[JsonDerivedType(typeof(OpenAILiveSessionCloseEvent), "session.close")]
public abstract record OpenAILiveClientEvent
{
    /// <summary>Optional client event identifier used for acknowledgement correlation.</summary>
    [JsonPropertyName("event_id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? EventId { get; init; }
}

/// <summary>Starts a GPT-Live primary WebSocket session.</summary>
public sealed record OpenAILiveSessionStartEvent : OpenAILiveClientEvent
{
    /// <summary>Initial immutable and delegating session configuration.</summary>
    [JsonPropertyName("session")]
    public required OpenAILiveSessionConfiguration Session { get; init; }
}

/// <summary>Appends audio to the active GPT-Live session.</summary>
public sealed record OpenAILiveInputAudioAppendEvent : OpenAILiveClientEvent
{
    /// <summary>Base64-encoded audio matching the startup audio format.</summary>
    [JsonPropertyName("audio")]
    public required string Audio { get; init; }
}

/// <summary>Adds instructions or text context while the Live session is running.</summary>
public sealed record OpenAILiveInstructionsAppendEvent : OpenAILiveClientEvent
{
    /// <summary>Text context to append.</summary>
    [JsonPropertyName("content")]
    public required string Content { get; init; }

    /// <summary>Optional delegation to associate with the appended context.</summary>
    [JsonPropertyName("delegation_id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DelegationId { get; init; }
}

/// <summary>Updates mutable delegation settings for an active Live session.</summary>
public sealed record OpenAILiveSessionUpdateEvent : OpenAILiveClientEvent
{
    /// <summary>Mutable session settings.</summary>
    [JsonPropertyName("session")]
    public required OpenAILiveSessionUpdate Session { get; init; }
}

/// <summary>Adds an input item to the delegated Responses conversation.</summary>
public sealed record OpenAILiveResponseInputItemCreateEvent : OpenAILiveClientEvent
{
    /// <summary>A Responses API input item.</summary>
    [JsonPropertyName("item")]
    public required JsonElement Item { get; init; }

    /// <summary>Delegation receiving the item, when more than one is active.</summary>
    [JsonPropertyName("delegation_id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DelegationId { get; init; }
}

/// <summary>Requests or continues a delegated Responses response.</summary>
public sealed record OpenAILiveResponseCreateEvent : OpenAILiveClientEvent
{
    /// <summary>Delegation receiving the request.</summary>
    [JsonPropertyName("delegation_id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DelegationId { get; init; }
}

/// <summary>Requests graceful closure of the Live session.</summary>
public sealed record OpenAILiveSessionCloseEvent : OpenAILiveClientEvent;

/// <summary>Startup configuration for a GPT-Live primary WebSocket.</summary>
public sealed record OpenAILiveSessionConfiguration
{
    /// <summary>The Live model. Currently <c>gpt-live-1</c>.</summary>
    [JsonPropertyName("model")]
    public string Model { get; init; } = "gpt-live-1";

    /// <summary>Frontend conversation instructions.</summary>
    [JsonPropertyName("instructions")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Instructions { get; init; }

    /// <summary>Primary WebSocket audio configuration.</summary>
    [JsonPropertyName("audio")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAILiveAudioConfiguration? Audio { get; init; }

    /// <summary>Whether delegated work is owned by the client or Responses API.</summary>
    [JsonPropertyName("delegation")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAILiveDelegation? Delegation { get; init; }

    /// <summary>Whether the session may later be forked or downloaded.</summary>
    [JsonPropertyName("store")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? Store { get; init; }
}

/// <summary>Settings that may change after startup.</summary>
public sealed record OpenAILiveSessionUpdate
{
    /// <summary>Updated delegation settings.</summary>
    [JsonPropertyName("delegation")]
    public required OpenAILiveDelegation Delegation { get; init; }
}

/// <summary>Audio settings for a primary Live WebSocket.</summary>
public sealed record OpenAILiveAudioConfiguration
{
    /// <summary>Input and output media format.</summary>
    [JsonPropertyName("format")]
    public OpenAILiveAudioFormat Format { get; init; } = new();

    /// <summary>Output voice configuration.</summary>
    [JsonPropertyName("output")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAILiveAudioOutputConfiguration? Output { get; init; }
}

/// <summary>PCM media format negotiated by the primary WebSocket.</summary>
public sealed record OpenAILiveAudioFormat
{
    /// <summary>MIME-style format discriminator.</summary>
    [JsonPropertyName("type")]
    public string Type { get; init; } = "audio/pcm";

    /// <summary>Sample rate in Hz.</summary>
    [JsonPropertyName("rate")]
    public int Rate { get; init; } = 24_000;
}

/// <summary>GPT-Live output voice settings.</summary>
public sealed record OpenAILiveAudioOutputConfiguration
{
    /// <summary>Voice name, for example <c>marin</c>.</summary>
    [JsonPropertyName("voice")]
    public required string Voice { get; init; }
}

/// <summary>Delegation mode for work that requires additional intelligence or tools.</summary>
public sealed record OpenAILiveDelegation
{
    /// <summary><c>client</c> or <c>responses</c>.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    /// <summary>Responses backend settings when <see cref="Type"/> is <c>responses</c>.</summary>
    [JsonPropertyName("responses")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAILiveResponsesDelegationSettings? Responses { get; init; }

    /// <summary>Creates client-owned delegation for an application tool runtime.</summary>
    public static OpenAILiveDelegation Client() => new() { Type = "client" };

    /// <summary>Creates server-owned delegation to a Responses model.</summary>
    public static OpenAILiveDelegation ToResponses(OpenAILiveResponsesDelegationSettings settings) =>
        new() { Type = "responses", Responses = settings };
}

/// <summary>Responses model, reasoning, prompt, and tools used by GPT-Live delegations.</summary>
public sealed record OpenAILiveResponsesDelegationSettings
{
    /// <summary>Backend Responses model, for example <c>gpt-6-astra</c>.</summary>
    [JsonPropertyName("model")]
    public required string Model { get; init; }

    /// <summary>Backend task and permission instructions.</summary>
    [JsonPropertyName("instructions")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Instructions { get; init; }

    /// <summary>Maximum tokens generated by a delegated response.</summary>
    [JsonPropertyName("max_output_tokens")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? MaxOutputTokens { get; init; }

    /// <summary>Reasoning effort used by the backend model.</summary>
    [JsonPropertyName("reasoning")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OpenAILiveReasoningConfiguration? Reasoning { get; init; }

    /// <summary>Responses API tools exposed by the selected Advantage mode.</summary>
    [JsonPropertyName("tools")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public JsonElement[]? Tools { get; init; }

    /// <summary>Whether backend tool calls may run in parallel.</summary>
    [JsonPropertyName("parallel_tool_calls")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? ParallelToolCalls { get; init; }
}

/// <summary>Reasoning settings for delegated Responses work.</summary>
public sealed record OpenAILiveReasoningConfiguration
{
    /// <summary>Reasoning effort supported by the selected Responses model.</summary>
    [JsonPropertyName("effort")]
    public required string Effort { get; init; }
}

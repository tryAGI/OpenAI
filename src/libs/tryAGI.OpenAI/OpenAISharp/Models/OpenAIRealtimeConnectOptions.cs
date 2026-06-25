namespace tryAGI.OpenAI.OpenAISharp;

/// <summary>
/// Options for opening a realtime WebSocket session.
/// </summary>
public sealed record OpenAIRealtimeConnectOptions
{
    /// <summary>
    /// Realtime model ID to connect with.
    /// </summary>
    public required string Model { get; init; }

    /// <summary>
    /// Realtime endpoint kind. Translation sessions use a dedicated WebSocket path.
    /// </summary>
    public OpenAIRealtimeSessionKind SessionKind { get; init; } = OpenAIRealtimeSessionKind.Realtime;

    /// <summary>
    /// Optional API key override (falls back to OpenAIConfig.ApiKey).
    /// </summary>
    public string? ApiKey { get; init; }

    /// <summary>
    /// Optional organization ID override.
    /// </summary>
    public string? OrganizationId { get; init; }

    /// <summary>
    /// Optional project ID override.
    /// </summary>
    public string? ProjectId { get; init; }

    /// <summary>
    /// Optional stable, privacy-preserving end-user identifier for OpenAI safety systems.
    /// </summary>
    public string? SafetyIdentifier { get; init; }

    /// <summary>
    /// Use WebSocket subprotocol authentication (browser-friendly).
    /// </summary>
    public bool UseSubprotocolAuthentication { get; init; }

    /// <summary>
    /// Override whether to send the OpenAI-Beta header.
    /// </summary>
    public bool? UseBetaHeader { get; init; }

    /// <summary>
    /// Override OpenAI-Beta header value.
    /// </summary>
    public string? BetaHeaderValue { get; init; }

    /// <summary>
    /// Additional headers to include in the WebSocket request.
    /// </summary>
    public IReadOnlyDictionary<string, string>? AdditionalHeaders { get; init; }

    /// <summary>
    /// Additional subprotocols to include in the WebSocket request.
    /// </summary>
    public IReadOnlyList<string>? AdditionalSubProtocols { get; init; }
}

/// <inheritdoc />
public enum OpenAIRealtimeSessionKind
{
    /// <inheritdoc />
    Realtime,
    /// <inheritdoc />
    Transcription,
    /// <inheritdoc />
    Translation,
}

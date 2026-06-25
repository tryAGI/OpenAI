using System.Text.Json;

namespace tryAGI.OpenAI.OpenAISharp;

/// <summary>
/// Configuration options for OpenAI client.
/// </summary>
public record OpenAIConfig
{
    /// <summary>
    /// API key for OpenAI authentication. Optional when passing a key in connect options.
    /// </summary>
    public string? ApiKey { get; init; }

    /// <summary>
    /// Base WebSocket URL for OpenAI Realtime API.
    /// </summary>
    public string BaseUrl { get; init; } = "wss://api.openai.com/v1/realtime";

    /// <summary>
    /// Optional OpenAI organization ID.
    /// </summary>
    public string? OrganizationId { get; init; }

    /// <summary>
    /// Optional OpenAI project ID.
    /// </summary>
    public string? ProjectId { get; init; }

    /// <summary>
    /// Optional stable, privacy-preserving end-user identifier for OpenAI safety systems.
    /// </summary>
    public string? SafetyIdentifier { get; init; }

    /// <summary>
    /// Timeout for establishing the WebSocket connection.
    /// </summary>
    public TimeSpan ConnectTimeout { get; init; } = TimeSpan.FromSeconds(30);

    /// <summary>
    /// Keep-alive interval for the WebSocket connection.
    /// </summary>
    public TimeSpan KeepAliveInterval { get; init; } = TimeSpan.FromSeconds(20);

    /// <summary>
    /// Whether to send the OpenAI-Beta header for realtime connections.
    /// </summary>
    public bool UseBetaHeader { get; init; }

    /// <summary>
    /// Value to send in the OpenAI-Beta header.
    /// </summary>
    public string BetaHeaderValue { get; init; } = "realtime=v1";

    /// <summary>
    /// JSON options used for serialization.
    /// </summary>
    public JsonSerializerOptions JsonSerializerOptions { get; init; } = OpenAIJsonSerializer.Default;

    /// <summary>
    /// Creates a configuration from just an API key.
    /// </summary>
    public static OpenAIConfig FromApiKey(string apiKey) => new() { ApiKey = apiKey };
}

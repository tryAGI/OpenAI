using System.Text.Json;

namespace tryAGI.OpenAI.OpenAISharp;

/// <summary>
/// Shared JSON serialization settings for OpenAI realtime payloads.
/// </summary>
public static class OpenAIJsonSerializer
{
    /// <inheritdoc />
    public static readonly JsonSerializerOptions Default = new(JsonContext.Default.Options);
}

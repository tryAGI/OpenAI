
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a MCPListToolsFailed message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed DeserializeMCPListToolsFailedMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed)(global::System.Text.Json.JsonSerializer.Deserialize(json, typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed),
                JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_F1F962AFD0A18C73.Default)
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}
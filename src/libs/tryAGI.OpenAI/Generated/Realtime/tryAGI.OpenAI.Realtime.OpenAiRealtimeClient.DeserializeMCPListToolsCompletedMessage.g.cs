
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a MCPListToolsCompleted message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted DeserializeMCPListToolsCompletedMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted)(global::System.Text.Json.JsonSerializer.Deserialize(json, typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted),
                JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_8B967D591F5FCC82.Default)
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}
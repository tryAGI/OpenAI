
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a MCPListToolsInProgress message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress DeserializeMCPListToolsInProgressMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress)(global::System.Text.Json.JsonSerializer.Deserialize(json, typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress),
                JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_E20D52BA773465D0.Default)
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}
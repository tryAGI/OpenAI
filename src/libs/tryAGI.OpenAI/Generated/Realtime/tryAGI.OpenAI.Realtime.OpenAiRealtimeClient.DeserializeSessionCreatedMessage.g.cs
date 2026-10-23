
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a SessionCreated message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated DeserializeSessionCreatedMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated)(global::System.Text.Json.JsonSerializer.Deserialize(json,
                (JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_BD93E3896391F8E9.Default).Options.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated)))
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}

#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a SessionUpdated message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated DeserializeSessionUpdatedMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated)(global::System.Text.Json.JsonSerializer.Deserialize(json,
                (JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_67FAF903E6DE09B1.Default).Options.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated)))
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}
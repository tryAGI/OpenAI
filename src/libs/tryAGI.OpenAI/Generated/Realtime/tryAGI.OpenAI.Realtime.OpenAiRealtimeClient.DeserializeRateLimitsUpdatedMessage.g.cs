
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a RateLimitsUpdated message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated DeserializeRateLimitsUpdatedMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated)(global::System.Text.Json.JsonSerializer.Deserialize(json, typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated),
                JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_9FBF5A7E8D8A91DB.Default)
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}
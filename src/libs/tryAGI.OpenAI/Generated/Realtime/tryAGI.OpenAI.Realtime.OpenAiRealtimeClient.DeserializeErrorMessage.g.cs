
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a Error message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventError DeserializeErrorMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventError)(global::System.Text.Json.JsonSerializer.Deserialize(json,
                (JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_B70E0BF82550B936.Default).Options.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventError)))
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}
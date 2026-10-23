
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a ResponseTextDelta message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta DeserializeResponseTextDeltaMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta)(global::System.Text.Json.JsonSerializer.Deserialize(json,
                (JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_0C8896CD8BAD5439.Default).Options.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta)))
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}
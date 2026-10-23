
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a ResponseAudioDelta message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta DeserializeResponseAudioDeltaMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta)(global::System.Text.Json.JsonSerializer.Deserialize(json, typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta),
                JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_40BDEEBE723E7E80.Default)
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}
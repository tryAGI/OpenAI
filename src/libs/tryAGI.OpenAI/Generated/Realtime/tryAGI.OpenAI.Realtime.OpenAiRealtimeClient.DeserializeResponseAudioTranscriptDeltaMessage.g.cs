
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a ResponseAudioTranscriptDelta message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta DeserializeResponseAudioTranscriptDeltaMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta)(global::System.Text.Json.JsonSerializer.Deserialize(json, typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta),
                JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_215CB9A3822065CA.Default)
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}
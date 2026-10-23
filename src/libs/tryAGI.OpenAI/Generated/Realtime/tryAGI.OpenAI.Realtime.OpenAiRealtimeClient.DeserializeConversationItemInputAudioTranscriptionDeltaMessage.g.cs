
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a ConversationItemInputAudioTranscriptionDelta message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta DeserializeConversationItemInputAudioTranscriptionDeltaMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta)(global::System.Text.Json.JsonSerializer.Deserialize(json, typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta),
                JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_1E58A41FD32D64D2.Default)
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}
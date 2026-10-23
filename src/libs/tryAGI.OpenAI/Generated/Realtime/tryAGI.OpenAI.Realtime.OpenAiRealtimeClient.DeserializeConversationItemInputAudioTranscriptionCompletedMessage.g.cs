
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a ConversationItemInputAudioTranscriptionCompleted message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted DeserializeConversationItemInputAudioTranscriptionCompletedMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted)(global::System.Text.Json.JsonSerializer.Deserialize(json, typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted),
                JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_165CBBDEE7E5EB82.Default)
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}
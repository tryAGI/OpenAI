
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a TranscriptionSessionUpdated message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventTranscriptionSessionUpdated DeserializeTranscriptionSessionUpdatedMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventTranscriptionSessionUpdated)(global::System.Text.Json.JsonSerializer.Deserialize(json,
                (JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_593B6E7350DF80AD.Default).Options.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventTranscriptionSessionUpdated)))
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}
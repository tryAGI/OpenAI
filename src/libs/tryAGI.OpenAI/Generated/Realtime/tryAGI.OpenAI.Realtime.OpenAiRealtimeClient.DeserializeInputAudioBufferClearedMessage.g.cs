
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a InputAudioBufferCleared message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared DeserializeInputAudioBufferClearedMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared)(global::System.Text.Json.JsonSerializer.Deserialize(json,
                (JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_8883EB913E64722C.Default).Options.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared)))
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}
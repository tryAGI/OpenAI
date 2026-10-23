
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a OutputAudioBufferStarted message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted DeserializeOutputAudioBufferStartedMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted)(global::System.Text.Json.JsonSerializer.Deserialize(json,
                (JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_2101BB5D0164CD90.Default).Options.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted)))
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}
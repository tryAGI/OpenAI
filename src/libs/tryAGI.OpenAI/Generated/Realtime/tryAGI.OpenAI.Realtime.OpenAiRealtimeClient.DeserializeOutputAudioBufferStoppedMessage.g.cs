
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a OutputAudioBufferStopped message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped DeserializeOutputAudioBufferStoppedMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped)(global::System.Text.Json.JsonSerializer.Deserialize(json, typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped),
                JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_4ED336FD18C4F16F.Default)
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}
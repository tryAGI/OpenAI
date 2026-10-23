
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a InputAudioBufferSpeechStopped message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped DeserializeInputAudioBufferSpeechStoppedMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped)(global::System.Text.Json.JsonSerializer.Deserialize(json, typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped),
                JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_2ACEBA1D5C0472C9.Default)
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}
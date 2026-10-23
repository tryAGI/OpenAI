
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a InputAudioBufferSpeechStarted message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted DeserializeInputAudioBufferSpeechStartedMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted)(global::System.Text.Json.JsonSerializer.Deserialize(json,
                (JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_A7FDE851BACBE732.Default).Options.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted)))
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}
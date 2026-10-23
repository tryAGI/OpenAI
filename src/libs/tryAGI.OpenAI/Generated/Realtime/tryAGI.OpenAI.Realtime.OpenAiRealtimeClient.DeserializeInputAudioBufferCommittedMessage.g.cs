
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a InputAudioBufferCommitted message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted DeserializeInputAudioBufferCommittedMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted)(global::System.Text.Json.JsonSerializer.Deserialize(json,
                (JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_126E0E3D9AAF008E.Default).Options.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted)))
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}

#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a ResponseContentPartAdded message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded DeserializeResponseContentPartAddedMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded)(global::System.Text.Json.JsonSerializer.Deserialize(json, typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded),
                JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_A8321422D74656DB.Default)
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}
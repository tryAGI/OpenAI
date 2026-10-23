
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a ResponseMCPCallCompleted message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted DeserializeResponseMCPCallCompletedMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted)(global::System.Text.Json.JsonSerializer.Deserialize(json, typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted),
                JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_0BC4AB4A5453AB8D.Default)
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}
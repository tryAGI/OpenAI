
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a ResponseMCPCallFailed message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed DeserializeResponseMCPCallFailedMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed)(global::System.Text.Json.JsonSerializer.Deserialize(json, typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed),
                JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_70697170439828A5.Default)
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}
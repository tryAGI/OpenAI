
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a ResponseMCPCallArgumentsDelta message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta DeserializeResponseMCPCallArgumentsDeltaMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta)(global::System.Text.Json.JsonSerializer.Deserialize(json,
                (JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_FE3C8FE4CFEFC9CF.Default).Options.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta)))
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}

#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a ResponseMCPCallArgumentsDone message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone DeserializeResponseMCPCallArgumentsDoneMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone)(global::System.Text.Json.JsonSerializer.Deserialize(json, typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone),
                JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_84CB4AA7C699D95E.Default)
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}

#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a ResponseMCPCallInProgress message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress DeserializeResponseMCPCallInProgressMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress)(global::System.Text.Json.JsonSerializer.Deserialize(json, typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress),
                JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_57AE34A872DDB81E.Default)
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}
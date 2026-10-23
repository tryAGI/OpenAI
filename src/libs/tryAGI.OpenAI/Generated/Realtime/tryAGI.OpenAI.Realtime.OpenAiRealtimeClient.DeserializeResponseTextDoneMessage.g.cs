
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a ResponseTextDone message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone DeserializeResponseTextDoneMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone)(global::System.Text.Json.JsonSerializer.Deserialize(json, typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone),
                JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_2330E0345CD909AF.Default)
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}
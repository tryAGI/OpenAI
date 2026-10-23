
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a ResponseOutputItemDone message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone DeserializeResponseOutputItemDoneMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone)(global::System.Text.Json.JsonSerializer.Deserialize(json, typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone),
                JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_09B6EE738E879C96.Default)
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}
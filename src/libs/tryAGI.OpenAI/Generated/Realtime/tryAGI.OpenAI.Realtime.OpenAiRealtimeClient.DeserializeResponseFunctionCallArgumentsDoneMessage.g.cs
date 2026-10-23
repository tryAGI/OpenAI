
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a ResponseFunctionCallArgumentsDone message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone DeserializeResponseFunctionCallArgumentsDoneMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone)(global::System.Text.Json.JsonSerializer.Deserialize(json, typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone),
                JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_830C6AE0484A633E.Default)
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}
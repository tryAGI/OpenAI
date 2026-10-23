
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a ConversationItemDone message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone DeserializeConversationItemDoneMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone)(global::System.Text.Json.JsonSerializer.Deserialize(json, typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone),
                JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_8E797DBD19D322DB.Default)
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}
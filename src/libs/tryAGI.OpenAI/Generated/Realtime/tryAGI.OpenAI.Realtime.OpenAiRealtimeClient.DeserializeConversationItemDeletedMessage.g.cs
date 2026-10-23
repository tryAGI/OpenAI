
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a ConversationItemDeleted message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted DeserializeConversationItemDeletedMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted)(global::System.Text.Json.JsonSerializer.Deserialize(json, typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted),
                JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_89370F7CFA555FE6.Default)
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}
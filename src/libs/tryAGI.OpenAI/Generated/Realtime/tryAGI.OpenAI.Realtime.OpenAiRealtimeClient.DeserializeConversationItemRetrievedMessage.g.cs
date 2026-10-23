
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a ConversationItemRetrieved message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved DeserializeConversationItemRetrievedMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved)(global::System.Text.Json.JsonSerializer.Deserialize(json, typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved),
                JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_C40E4982AAC7C1EA.Default)
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}
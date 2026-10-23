
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>Deserializes a ResponseOutputItemAdded message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded DeserializeResponseOutputItemAddedMessage(string json) =>
            (global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded)(global::System.Text.Json.JsonSerializer.Deserialize(json,
                (JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_41B65AEBFC794D78.Default).Options.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded)))
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}
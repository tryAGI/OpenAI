
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// Returned when a new Response is created. The first event of response creation,<br/>
    /// where the response is in an initial state of `in_progress`.
    /// </summary>
    public sealed partial class RealtimeServerEventResponseCreated
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type, must be `response.created`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseCreatedTypeJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreatedType Type { get; set; }

        /// <summary>
        /// The response resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.Realtime.RealtimeResponse Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseCreated" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="response">
        /// The response resource.
        /// </param>
        /// <param name="type">
        /// The event type, must be `response.created`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeServerEventResponseCreated(
            string eventId,
            global::tryAGI.OpenAI.Realtime.RealtimeResponse response,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreatedType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseCreated" /> class.
        /// </summary>
        public RealtimeServerEventResponseCreated()
        {
        }
    }
}
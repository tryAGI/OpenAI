
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// Returned when a session is updated.
    /// </summary>
    public sealed partial class SessionUpdatedPayload
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.SessionUpdatedPayloadTypeJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.SessionUpdatedPayloadType Type { get; set; }

        /// <summary>
        /// Realtime session configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        public global::tryAGI.OpenAI.Realtime.Session? Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionUpdatedPayload" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="session">
        /// Realtime session configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionUpdatedPayload(
            string eventId,
            global::tryAGI.OpenAI.Realtime.SessionUpdatedPayloadType type,
            global::tryAGI.OpenAI.Realtime.Session? session)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
            this.Session = session;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionUpdatedPayload" /> class.
        /// </summary>
        public SessionUpdatedPayload()
        {
        }
    }
}
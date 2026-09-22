
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when a Live session update is accepted. Contains the resolved session configuration after the update.<br/>
    /// Example: {"type":"session.updated","event_id":"evt_updated_001","client_event_id":"evt_update_001","session":{"id":"live_def456","model":"gpt-live-1","status":"active","expires_at":1788555600,"instructions":"Help the caller plan a restaurant reservation. Confirm details before booking.","input":[],"audio":{"format":{"type":"audio/pcm","rate":24000},"output":{"voice":"marin"}},"delegation":{"type":"responses","responses":{"model":"gpt-6-astra","instructions":"Check restaurant availability. Ask before confirming a booking.","max_output_tokens":1024,"tools":[]}}}}
    /// </summary>
    public sealed partial class LiveSessionUpdated
    {
        /// <summary>
        /// The event type, always `session.updated`.<br/>
        /// Default Value: session.updated
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveSessionUpdatedType.SessionUpdated</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveSessionUpdatedTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveSessionUpdatedType Type { get; set; } = global::tryAGI.OpenAI.LiveSessionUpdatedType.SessionUpdated;

        /// <summary>
        /// The unique ID of the Live server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event_id of the client command associated with this server event, when supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_event_id")]
        public string? ClientEventId { get; set; }

        /// <summary>
        /// The resolved Live session configuration and server-assigned session metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.LiveSessionResourceParam Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionUpdated" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the Live server event.
        /// </param>
        /// <param name="session">
        /// The resolved Live session configuration and server-assigned session metadata.
        /// </param>
        /// <param name="clientEventId">
        /// The event_id of the client command associated with this server event, when supplied.
        /// </param>
        /// <param name="type">
        /// The event type, always `session.updated`.<br/>
        /// Default Value: session.updated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSessionUpdated(
            string eventId,
            global::tryAGI.OpenAI.LiveSessionResourceParam session,
            string? clientEventId,
            global::tryAGI.OpenAI.LiveSessionUpdatedType type = global::tryAGI.OpenAI.LiveSessionUpdatedType.SessionUpdated)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ClientEventId = clientEventId;
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionUpdated" /> class.
        /// </summary>
        public LiveSessionUpdated()
        {
        }

    }
}
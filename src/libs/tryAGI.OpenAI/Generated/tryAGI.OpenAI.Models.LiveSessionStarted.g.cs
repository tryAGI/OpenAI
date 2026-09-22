
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when a Live session has started. Contains the resolved session configuration, including server defaults.<br/>
    /// Example: {"type":"session.started","event_id":"evt_started_001","client_event_id":"evt_start_001","session":{"id":"live_abc123","model":"gpt-live-1","status":"active","expires_at":1788555600,"instructions":"Help the caller plan a restaurant reservation. Confirm details before booking.","input":[],"audio":{"format":{"type":"audio/pcm","rate":24000},"output":{"voice":"marin"}},"delegation":{"type":"client"}}}
    /// </summary>
    public sealed partial class LiveSessionStarted
    {
        /// <summary>
        /// The event type, always `session.started`.<br/>
        /// Default Value: session.started
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveSessionStartedType.SessionStarted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveSessionStartedTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveSessionStartedType Type { get; set; } = global::tryAGI.OpenAI.LiveSessionStartedType.SessionStarted;

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
        /// Initializes a new instance of the <see cref="LiveSessionStarted" /> class.
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
        /// The event type, always `session.started`.<br/>
        /// Default Value: session.started
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSessionStarted(
            string eventId,
            global::tryAGI.OpenAI.LiveSessionResourceParam session,
            string? clientEventId,
            global::tryAGI.OpenAI.LiveSessionStartedType type = global::tryAGI.OpenAI.LiveSessionStartedType.SessionStarted)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ClientEventId = clientEventId;
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionStarted" /> class.
        /// </summary>
        public LiveSessionStarted()
        {
        }

    }
}
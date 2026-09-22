
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Start a Live session on a primary WebSocket. Send this event before other commands and wait for `session.started`.<br/>
    /// Example: {"type":"session.start","event_id":"evt_start_001","session":{"model":"gpt-live-1","instructions":"Help the caller plan a restaurant reservation. Confirm details before booking.","audio":{"format":{"type":"audio/pcm","rate":24000},"output":{"voice":"marin"}},"delegation":{"type":"client"}}}
    /// </summary>
    public sealed partial class LiveSessionStartEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The Live client event type. Always `session.start`.<br/>
        /// Default Value: session.start
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveSessionStartEventType.SessionStart</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveSessionStartEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveSessionStartEventType Type { get; set; } = global::tryAGI.OpenAI.LiveSessionStartEventType.SessionStart;

        /// <summary>
        /// Initial configuration for a primary WebSocket. Send session.start first and wait for session.started before application commands. WebRTC creation already starts the session; do not send this event again on its data channel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.LiveSessionCreateParams Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionStartEvent" /> class.
        /// </summary>
        /// <param name="session">
        /// Initial configuration for a primary WebSocket. Send session.start first and wait for session.started before application commands. WebRTC creation already starts the session; do not send this event again on its data channel.
        /// </param>
        /// <param name="eventId"></param>
        /// <param name="type">
        /// The Live client event type. Always `session.start`.<br/>
        /// Default Value: session.start
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSessionStartEvent(
            global::tryAGI.OpenAI.LiveSessionCreateParams session,
            string? eventId,
            global::tryAGI.OpenAI.LiveSessionStartEventType type = global::tryAGI.OpenAI.LiveSessionStartEventType.SessionStart)
        {
            this.EventId = eventId;
            this.Type = type;
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionStartEvent" /> class.
        /// </summary>
        public LiveSessionStartEvent()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveSessionStartEvent"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveSessionStartEvent FromSession(global::tryAGI.OpenAI.LiveSessionCreateParams session)
        {
            return new LiveSessionStartEvent
            {
                Session = session,
            };
        }

    }
}
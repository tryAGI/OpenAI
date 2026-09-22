
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Start a Live session after connecting to a stored session’s fork WebSocket. Send an empty `session` object to use the stored configuration.<br/>
    /// Example: {"type":"session.start","session":{}}
    /// </summary>
    public sealed partial class LiveForkSessionStartEvent
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
        /// <default>global::tryAGI.OpenAI.LiveForkSessionStartEventType.SessionStart</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveForkSessionStartEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveForkSessionStartEventType Type { get; set; } = global::tryAGI.OpenAI.LiveForkSessionStartEventType.SessionStart;

        /// <summary>
        /// Overrides for a stored session after connecting to the fork WebSocket. An empty object inherits the stored configuration; do not supply a new model. audio.format applies only to the new WebSocket connection. client overrides are only supported for WebRTC forks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.LiveForkSessionConfigParam Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveForkSessionStartEvent" /> class.
        /// </summary>
        /// <param name="session">
        /// Overrides for a stored session after connecting to the fork WebSocket. An empty object inherits the stored configuration; do not supply a new model. audio.format applies only to the new WebSocket connection. client overrides are only supported for WebRTC forks.
        /// </param>
        /// <param name="eventId"></param>
        /// <param name="type">
        /// The Live client event type. Always `session.start`.<br/>
        /// Default Value: session.start
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveForkSessionStartEvent(
            global::tryAGI.OpenAI.LiveForkSessionConfigParam session,
            string? eventId,
            global::tryAGI.OpenAI.LiveForkSessionStartEventType type = global::tryAGI.OpenAI.LiveForkSessionStartEventType.SessionStart)
        {
            this.EventId = eventId;
            this.Type = type;
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveForkSessionStartEvent" /> class.
        /// </summary>
        public LiveForkSessionStartEvent()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveForkSessionStartEvent"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveForkSessionStartEvent FromSession(global::tryAGI.OpenAI.LiveForkSessionConfigParam session)
        {
            return new LiveForkSessionStartEvent
            {
                Session = session,
            };
        }

    }
}
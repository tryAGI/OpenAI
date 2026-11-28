
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Sent when speech wakes inference and it is ready for audio in a Live WebRTC session. This occurs on the first wake and after each later wake. Delivered to the sideband and, when permitted by its event settings, the data channel.<br/>
    /// Example: {"type":"session.resumed","event_id":"evt_resumed_001"}
    /// </summary>
    public sealed partial class LiveSessionResumed
    {
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
        /// Default Value: session.resumed
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveSessionResumedType.SessionResumed</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveSessionResumedTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveSessionResumedType Type { get; set; } = global::tryAGI.OpenAI.LiveSessionResumedType.SessionResumed;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionResumed" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the Live server event.
        /// </param>
        /// <param name="clientEventId">
        /// The event_id of the client command associated with this server event, when supplied.
        /// </param>
        /// <param name="type">
        /// Default Value: session.resumed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSessionResumed(
            string eventId,
            string? clientEventId,
            global::tryAGI.OpenAI.LiveSessionResumedType type = global::tryAGI.OpenAI.LiveSessionResumedType.SessionResumed)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ClientEventId = clientEventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionResumed" /> class.
        /// </summary>
        public LiveSessionResumed()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveSessionResumed"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveSessionResumed FromEventId(string eventId)
        {
            return new LiveSessionResumed
            {
                EventId = eventId,
            };
        }

    }
}
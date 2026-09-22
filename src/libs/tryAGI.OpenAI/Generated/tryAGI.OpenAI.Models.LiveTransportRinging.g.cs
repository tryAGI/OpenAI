
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The outbound SIP provider leg is ringing or providing early media. Delivered only to sideband observers.<br/>
    /// Example: {"type":"transport.ringing","event_id":"event_call_1","session_id":"live_u0_123"}
    /// </summary>
    public sealed partial class LiveTransportRinging
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The canonical Live session ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// Default Value: transport.ringing
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveTransportRingingType.TransportRinging</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveTransportRingingTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveTransportRingingType Type { get; set; } = global::tryAGI.OpenAI.LiveTransportRingingType.TransportRinging;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveTransportRinging" /> class.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="sessionId">
        /// The canonical Live session ID.
        /// </param>
        /// <param name="type">
        /// Default Value: transport.ringing
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveTransportRinging(
            string eventId,
            string sessionId,
            global::tryAGI.OpenAI.LiveTransportRingingType type = global::tryAGI.OpenAI.LiveTransportRingingType.TransportRinging)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveTransportRinging" /> class.
        /// </summary>
        public LiveTransportRinging()
        {
        }

    }
}
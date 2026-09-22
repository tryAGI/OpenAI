
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The outbound SIP provider leg answered and media is established. Delivered only to sideband observers.<br/>
    /// Example: {"type":"transport.answered","event_id":"event_call_2","session_id":"live_u0_123"}
    /// </summary>
    public sealed partial class LiveTransportAnswered
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
        /// Default Value: transport.answered
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveTransportAnsweredType.TransportAnswered</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveTransportAnsweredTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveTransportAnsweredType Type { get; set; } = global::tryAGI.OpenAI.LiveTransportAnsweredType.TransportAnswered;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveTransportAnswered" /> class.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="sessionId">
        /// The canonical Live session ID.
        /// </param>
        /// <param name="type">
        /// Default Value: transport.answered
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveTransportAnswered(
            string eventId,
            string sessionId,
            global::tryAGI.OpenAI.LiveTransportAnsweredType type = global::tryAGI.OpenAI.LiveTransportAnsweredType.TransportAnswered)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveTransportAnswered" /> class.
        /// </summary>
        public LiveTransportAnswered()
        {
        }

    }
}

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Sent when the idle timeout pauses inference in a Live WebRTC session. The WebRTC connection, sideband, and session ID persist. Delivered to the sideband and, when permitted by its event settings, the data channel.<br/>
    /// Example: {"type":"session.paused","event_id":"evt_paused_001"}
    /// </summary>
    public sealed partial class LiveSessionPaused
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
        /// Default Value: session.paused
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveSessionPausedType.SessionPaused</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveSessionPausedTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveSessionPausedType Type { get; set; } = global::tryAGI.OpenAI.LiveSessionPausedType.SessionPaused;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionPaused" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the Live server event.
        /// </param>
        /// <param name="clientEventId">
        /// The event_id of the client command associated with this server event, when supplied.
        /// </param>
        /// <param name="type">
        /// Default Value: session.paused
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSessionPaused(
            string eventId,
            string? clientEventId,
            global::tryAGI.OpenAI.LiveSessionPausedType type = global::tryAGI.OpenAI.LiveSessionPausedType.SessionPaused)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ClientEventId = clientEventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionPaused" /> class.
        /// </summary>
        public LiveSessionPaused()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveSessionPaused"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveSessionPaused FromEventId(string eventId)
        {
            return new LiveSessionPaused
            {
                EventId = eventId,
            };
        }

    }
}
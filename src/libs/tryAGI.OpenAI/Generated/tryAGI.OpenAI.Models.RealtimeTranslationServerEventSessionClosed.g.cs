
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when a realtime translation session is closed.
    /// </summary>
    public sealed partial class RealtimeTranslationServerEventSessionClosed
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type, must be `session.closed`.
        /// </summary>
        /// <default>"session.closed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "session.closed";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationServerEventSessionClosed" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `session.closed`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranslationServerEventSessionClosed(
            string eventId,
            string type = "session.closed")
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationServerEventSessionClosed" /> class.
        /// </summary>
        public RealtimeTranslationServerEventSessionClosed()
        {
        }

        /// <summary>
        /// Creates a new <see cref="RealtimeTranslationServerEventSessionClosed"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static RealtimeTranslationServerEventSessionClosed FromEventId(string eventId)
        {
            return new RealtimeTranslationServerEventSessionClosed
            {
                EventId = eventId,
            };
        }

    }
}
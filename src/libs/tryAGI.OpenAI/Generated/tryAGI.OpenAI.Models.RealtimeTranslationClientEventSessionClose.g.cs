
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Gracefully close the realtime translation session. The server flushes pending<br/>
    /// input audio and emits any remaining translated output before closing the<br/>
    /// session.
    /// </summary>
    public sealed partial class RealtimeTranslationClientEventSessionClose
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be `session.close`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationClientEventSessionCloseTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionCloseType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationClientEventSessionClose" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `session.close`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranslationClientEventSessionClose(
            string? eventId,
            global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionCloseType type)
        {
            this.EventId = eventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationClientEventSessionClose" /> class.
        /// </summary>
        public RealtimeTranslationClientEventSessionClose()
        {
        }

    }
}
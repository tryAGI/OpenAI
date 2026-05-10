
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when optional source-language transcript text is available. This event<br/>
    /// is emitted only when `audio.input.transcription` is configured.<br/>
    /// Transcript deltas are append-only text fragments. Clients should not insert<br/>
    /// unconditional spaces between deltas.
    /// </summary>
    public sealed partial class RealtimeTranslationServerEventSessionInputTranscriptDelta
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type, must be `session.input_transcript.delta`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationServerEventSessionInputTranscriptDeltaTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDeltaType Type { get; set; }

        /// <summary>
        /// Append-only source-language transcript text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Delta { get; set; }

        /// <summary>
        /// Timing metadata for stream alignment, derived from the translation frame<br/>
        /// when available. It advances in 200 ms increments, but multiple transcript<br/>
        /// deltas may share the same `elapsed_ms`. Treat it as alignment metadata,<br/>
        /// not a unique transcript-delta identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elapsed_ms")]
        public int? ElapsedMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationServerEventSessionInputTranscriptDelta" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="delta">
        /// Append-only source-language transcript text.
        /// </param>
        /// <param name="type">
        /// The event type, must be `session.input_transcript.delta`.
        /// </param>
        /// <param name="elapsedMs">
        /// Timing metadata for stream alignment, derived from the translation frame<br/>
        /// when available. It advances in 200 ms increments, but multiple transcript<br/>
        /// deltas may share the same `elapsed_ms`. Treat it as alignment metadata,<br/>
        /// not a unique transcript-delta identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranslationServerEventSessionInputTranscriptDelta(
            string eventId,
            string delta,
            global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDeltaType type,
            int? elapsedMs)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.ElapsedMs = elapsedMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationServerEventSessionInputTranscriptDelta" /> class.
        /// </summary>
        public RealtimeTranslationServerEventSessionInputTranscriptDelta()
        {
        }

    }
}
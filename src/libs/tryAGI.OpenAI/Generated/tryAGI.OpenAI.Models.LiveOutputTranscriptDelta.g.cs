
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A transcript fragment for assistant output audio in the Live session. Accumulate fragments in delivery order; these events do not define complete turns or include a transcript-done event.<br/>
    /// Example: {"type":"session.output_transcript.delta","event_id":"evt_output_transcript_001","delta":"Would you like me to reserve that table?","start_ms":5400,"end_ms":7200}
    /// </summary>
    public sealed partial class LiveOutputTranscriptDelta
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
        /// The start of this event on the Live session timeline, in milliseconds from the beginning of the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartMs { get; set; }

        /// <summary>
        /// The end of this event on the Live session timeline, in milliseconds from the beginning of the session. For appended context, this can equal start_ms.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndMs { get; set; }

        /// <summary>
        /// The transcript text fragment for the audio in this time range. Append fragments in delivery order to build the transcript.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Delta { get; set; }

        /// <summary>
        /// The event type, always `session.output_transcript.delta`.<br/>
        /// Default Value: session.output_transcript.delta
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveOutputTranscriptDeltaType.SessionOutputTranscriptDelta</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveOutputTranscriptDeltaTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveOutputTranscriptDeltaType Type { get; set; } = global::tryAGI.OpenAI.LiveOutputTranscriptDeltaType.SessionOutputTranscriptDelta;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveOutputTranscriptDelta" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the Live server event.
        /// </param>
        /// <param name="startMs">
        /// The start of this event on the Live session timeline, in milliseconds from the beginning of the session.
        /// </param>
        /// <param name="endMs">
        /// The end of this event on the Live session timeline, in milliseconds from the beginning of the session. For appended context, this can equal start_ms.
        /// </param>
        /// <param name="delta">
        /// The transcript text fragment for the audio in this time range. Append fragments in delivery order to build the transcript.
        /// </param>
        /// <param name="clientEventId">
        /// The event_id of the client command associated with this server event, when supplied.
        /// </param>
        /// <param name="type">
        /// The event type, always `session.output_transcript.delta`.<br/>
        /// Default Value: session.output_transcript.delta
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveOutputTranscriptDelta(
            string eventId,
            int startMs,
            int endMs,
            string delta,
            string? clientEventId,
            global::tryAGI.OpenAI.LiveOutputTranscriptDeltaType type = global::tryAGI.OpenAI.LiveOutputTranscriptDeltaType.SessionOutputTranscriptDelta)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ClientEventId = clientEventId;
            this.StartMs = startMs;
            this.EndMs = endMs;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveOutputTranscriptDelta" /> class.
        /// </summary>
        public LiveOutputTranscriptDelta()
        {
        }

    }
}
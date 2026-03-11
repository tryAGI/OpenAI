
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when a diarized transcription returns a completed segment with speaker information. Only emitted when you [create a transcription](/docs/api-reference/audio/create-transcription) with `stream` set to `true` and `response_format` set to `diarized_json`.
    /// </summary>
    public sealed partial class TranscriptTextSegmentEvent
    {
        /// <summary>
        /// The type of the event. Always `transcript.text.segment`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.TranscriptTextSegmentEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.TranscriptTextSegmentEventType Type { get; set; }

        /// <summary>
        /// Unique identifier for the segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Start timestamp of the segment in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public float Start { get; set; } = default!;

        /// <summary>
        /// End timestamp of the segment in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public float End { get; set; } = default!;

        /// <summary>
        /// Transcript text for this segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Speaker label for this segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Speaker { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptTextSegmentEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `transcript.text.segment`.
        /// </param>
        /// <param name="id">
        /// Unique identifier for the segment.
        /// </param>
        /// <param name="start">
        /// Start timestamp of the segment in seconds.
        /// </param>
        /// <param name="end">
        /// End timestamp of the segment in seconds.
        /// </param>
        /// <param name="text">
        /// Transcript text for this segment.
        /// </param>
        /// <param name="speaker">
        /// Speaker label for this segment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptTextSegmentEvent(
            string id,
            float start,
            float end,
            string text,
            string speaker,
            global::tryAGI.OpenAI.TranscriptTextSegmentEventType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Start = start;
            this.End = end;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Speaker = speaker ?? throw new global::System.ArgumentNullException(nameof(speaker));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptTextSegmentEvent" /> class.
        /// </summary>
        public TranscriptTextSegmentEvent()
        {
        }
    }
}
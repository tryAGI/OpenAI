
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A segment of diarized transcript text with speaker metadata.
    /// </summary>
    public sealed partial class TranscriptionDiarizedSegment
    {
        /// <summary>
        /// The type of the segment. Always `transcript.text.segment`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.TranscriptionDiarizedSegmentTypeJsonConverter))]
        public global::tryAGI.OpenAI.TranscriptionDiarizedSegmentType Type { get; set; }

        /// <summary>
        /// Unique identifier for the segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Start timestamp of the segment in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Start { get; set; }

        /// <summary>
        /// End timestamp of the segment in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float End { get; set; }

        /// <summary>
        /// Transcript text for this segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Speaker label for this segment. When known speakers are provided, the label matches `known_speaker_names[]`. Otherwise speakers are labeled sequentially using capital letters (`A`, `B`, ...).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Speaker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionDiarizedSegment" /> class.
        /// </summary>
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
        /// Speaker label for this segment. When known speakers are provided, the label matches `known_speaker_names[]`. Otherwise speakers are labeled sequentially using capital letters (`A`, `B`, ...).
        /// </param>
        /// <param name="type">
        /// The type of the segment. Always `transcript.text.segment`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionDiarizedSegment(
            string id,
            float start,
            float end,
            string text,
            string speaker,
            global::tryAGI.OpenAI.TranscriptionDiarizedSegmentType type)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Start = start;
            this.End = end;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Speaker = speaker ?? throw new global::System.ArgumentNullException(nameof(speaker));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionDiarizedSegment" /> class.
        /// </summary>
        public TranscriptionDiarizedSegment()
        {
        }
    }
}
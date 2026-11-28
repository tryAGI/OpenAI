
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when there is an additional text delta. This is also the first event emitted when the transcription starts. Only emitted when you [create a transcription](https://developers.openai.com/api/reference/resources/audio/subresources/transcriptions/methods/create) with the `Stream` parameter set to `true`.
    /// </summary>
    public sealed partial class TranscriptTextDeltaEvent
    {
        /// <summary>
        /// The type of the event. Always `transcript.text.delta`.
        /// </summary>
        /// <default>"transcript.text.delta"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "transcript.text.delta";

        /// <summary>
        /// The text delta that was additionally transcribed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Delta { get; set; }

        /// <summary>
        /// The log probabilities of the delta. Only included if you [create a transcription](https://developers.openai.com/api/reference/resources/audio/subresources/transcriptions/methods/create) with the `include[]` parameter set to `logprobs`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptTextDeltaEventLogprob>? Logprobs { get; set; }

        /// <summary>
        /// Identifier of the diarized segment that this delta belongs to. Only present when using `gpt-4o-transcribe-diarize`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment_id")]
        public string? SegmentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptTextDeltaEvent" /> class.
        /// </summary>
        /// <param name="delta">
        /// The text delta that was additionally transcribed.
        /// </param>
        /// <param name="logprobs">
        /// The log probabilities of the delta. Only included if you [create a transcription](https://developers.openai.com/api/reference/resources/audio/subresources/transcriptions/methods/create) with the `include[]` parameter set to `logprobs`.
        /// </param>
        /// <param name="segmentId">
        /// Identifier of the diarized segment that this delta belongs to. Only present when using `gpt-4o-transcribe-diarize`.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `transcript.text.delta`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptTextDeltaEvent(
            string delta,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptTextDeltaEventLogprob>? logprobs,
            string? segmentId,
            string type = "transcript.text.delta")
        {
            this.Type = type;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.Logprobs = logprobs;
            this.SegmentId = segmentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptTextDeltaEvent" /> class.
        /// </summary>
        public TranscriptTextDeltaEvent()
        {
        }

        /// <summary>
        /// Creates a new <see cref="TranscriptTextDeltaEvent"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static TranscriptTextDeltaEvent FromDelta(string delta)
        {
            return new TranscriptTextDeltaEvent
            {
                Delta = delta,
            };
        }

    }
}
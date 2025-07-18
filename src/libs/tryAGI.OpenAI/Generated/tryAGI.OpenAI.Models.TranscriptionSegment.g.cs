
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptionSegment
    {
        /// <summary>
        /// Average logprob of the segment. If the value is lower than -1, consider the logprobs failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_logprob")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float AvgLogprob { get; set; }

        /// <summary>
        /// Compression ratio of the segment. If the value is greater than 2.4, consider the compression failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compression_ratio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float CompressionRatio { get; set; }

        /// <summary>
        /// End time of the segment in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float End { get; set; }

        /// <summary>
        /// Unique identifier of the segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Probability of no speech in the segment. If the value is higher than 1.0 and the `avg_logprob` is below -1, consider this segment silent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("no_speech_prob")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float NoSpeechProb { get; set; }

        /// <summary>
        /// Seek offset of the segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seek")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Seek { get; set; }

        /// <summary>
        /// Start time of the segment in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Start { get; set; }

        /// <summary>
        /// Temperature parameter used for generating the segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Temperature { get; set; }

        /// <summary>
        /// Text content of the segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Array of token IDs for the text content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Tokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionSegment" /> class.
        /// </summary>
        /// <param name="avgLogprob">
        /// Average logprob of the segment. If the value is lower than -1, consider the logprobs failed.
        /// </param>
        /// <param name="compressionRatio">
        /// Compression ratio of the segment. If the value is greater than 2.4, consider the compression failed.
        /// </param>
        /// <param name="end">
        /// End time of the segment in seconds.
        /// </param>
        /// <param name="id">
        /// Unique identifier of the segment.
        /// </param>
        /// <param name="noSpeechProb">
        /// Probability of no speech in the segment. If the value is higher than 1.0 and the `avg_logprob` is below -1, consider this segment silent.
        /// </param>
        /// <param name="seek">
        /// Seek offset of the segment.
        /// </param>
        /// <param name="start">
        /// Start time of the segment in seconds.
        /// </param>
        /// <param name="temperature">
        /// Temperature parameter used for generating the segment.
        /// </param>
        /// <param name="text">
        /// Text content of the segment.
        /// </param>
        /// <param name="tokens">
        /// Array of token IDs for the text content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionSegment(
            float avgLogprob,
            float compressionRatio,
            float end,
            int id,
            float noSpeechProb,
            int seek,
            float start,
            float temperature,
            string text,
            global::System.Collections.Generic.IList<int> tokens)
        {
            this.AvgLogprob = avgLogprob;
            this.CompressionRatio = compressionRatio;
            this.End = end;
            this.Id = id;
            this.NoSpeechProb = noSpeechProb;
            this.Seek = seek;
            this.Start = start;
            this.Temperature = temperature;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Tokens = tokens ?? throw new global::System.ArgumentNullException(nameof(tokens));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionSegment" /> class.
        /// </summary>
        public TranscriptionSegment()
        {
        }
    }
}
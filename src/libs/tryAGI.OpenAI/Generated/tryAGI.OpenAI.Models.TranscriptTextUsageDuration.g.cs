
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Usage statistics for models billed by audio input duration.
    /// </summary>
    public sealed partial class TranscriptTextUsageDuration
    {
        /// <summary>
        /// Duration of the input audio in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Seconds { get; set; }

        /// <summary>
        /// The type of the usage object. Always `duration` for this variant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.TranscriptTextUsageDurationTypeJsonConverter))]
        public global::tryAGI.OpenAI.TranscriptTextUsageDurationType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptTextUsageDuration" /> class.
        /// </summary>
        /// <param name="seconds">
        /// Duration of the input audio in seconds.
        /// </param>
        /// <param name="type">
        /// The type of the usage object. Always `duration` for this variant.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptTextUsageDuration(
            double seconds,
            global::tryAGI.OpenAI.TranscriptTextUsageDurationType type)
        {
            this.Seconds = seconds;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptTextUsageDuration" /> class.
        /// </summary>
        public TranscriptTextUsageDuration()
        {
        }
    }
}

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The completed summary part.
    /// </summary>
    public sealed partial class ResponseReasoningSummaryPartDoneEventPart
    {
        /// <summary>
        /// The text of the summary part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The type of the summary part. Always `summary_text`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartDoneEventPartTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventPartType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseReasoningSummaryPartDoneEventPart" /> class.
        /// </summary>
        /// <param name="text">
        /// The text of the summary part.
        /// </param>
        /// <param name="type">
        /// The type of the summary part. Always `summary_text`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseReasoningSummaryPartDoneEventPart(
            string text,
            global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventPartType type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseReasoningSummaryPartDoneEventPart" /> class.
        /// </summary>
        public ResponseReasoningSummaryPartDoneEventPart()
        {
        }
    }
}
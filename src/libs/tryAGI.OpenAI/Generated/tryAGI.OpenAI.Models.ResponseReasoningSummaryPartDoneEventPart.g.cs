
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The completed summary part.
    /// </summary>
    public sealed partial class ResponseReasoningSummaryPartDoneEventPart
    {
        /// <summary>
        /// The type of the summary part. Always `summary_text`.
        /// </summary>
        /// <default>"summary_text"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "summary_text";

        /// <summary>
        /// The text of the summary part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

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
            string type = "summary_text")
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseReasoningSummaryPartDoneEventPart" /> class.
        /// </summary>
        public ResponseReasoningSummaryPartDoneEventPart()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ResponseReasoningSummaryPartDoneEventPart"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ResponseReasoningSummaryPartDoneEventPart FromText(string text)
        {
            return new ResponseReasoningSummaryPartDoneEventPart
            {
                Text = text,
            };
        }

    }
}
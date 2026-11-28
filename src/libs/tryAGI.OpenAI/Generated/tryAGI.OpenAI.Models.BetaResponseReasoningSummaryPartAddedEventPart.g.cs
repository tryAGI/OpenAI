
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The summary part that was added.
    /// </summary>
    public sealed partial class BetaResponseReasoningSummaryPartAddedEventPart
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
        /// Initializes a new instance of the <see cref="BetaResponseReasoningSummaryPartAddedEventPart" /> class.
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
        public BetaResponseReasoningSummaryPartAddedEventPart(
            string text,
            string type = "summary_text")
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseReasoningSummaryPartAddedEventPart" /> class.
        /// </summary>
        public BetaResponseReasoningSummaryPartAddedEventPart()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaResponseReasoningSummaryPartAddedEventPart"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaResponseReasoningSummaryPartAddedEventPart FromText(string text)
        {
            return new BetaResponseReasoningSummaryPartAddedEventPart
            {
                Text = text,
            };
        }

    }
}

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when a reasoning summary text is completed.
    /// </summary>
    public sealed partial class ResponseReasoningSummaryTextDoneEvent
    {
        /// <summary>
        /// The type of the event. Always `response.reasoning_summary_text.done`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryTextDoneEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEventType Type { get; set; }

        /// <summary>
        /// The ID of the item this summary text is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the output item this summary text is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The index of the summary part within the reasoning summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SummaryIndex { get; set; }

        /// <summary>
        /// The full text of the completed reasoning summary.
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
        /// Initializes a new instance of the <see cref="ResponseReasoningSummaryTextDoneEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.reasoning_summary_text.done`.
        /// </param>
        /// <param name="itemId">
        /// The ID of the item this summary text is associated with.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item this summary text is associated with.
        /// </param>
        /// <param name="summaryIndex">
        /// The index of the summary part within the reasoning summary.
        /// </param>
        /// <param name="text">
        /// The full text of the completed reasoning summary.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseReasoningSummaryTextDoneEvent(
            string itemId,
            int outputIndex,
            int summaryIndex,
            string text,
            global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.SummaryIndex = summaryIndex;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseReasoningSummaryTextDoneEvent" /> class.
        /// </summary>
        public ResponseReasoningSummaryTextDoneEvent()
        {
        }
    }
}
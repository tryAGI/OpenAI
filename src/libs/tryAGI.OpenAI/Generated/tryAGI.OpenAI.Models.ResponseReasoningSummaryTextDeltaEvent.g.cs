
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when a delta is added to a reasoning summary text.
    /// </summary>
    public sealed partial class ResponseReasoningSummaryTextDeltaEvent
    {
        /// <summary>
        /// The text delta that was added to the summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Delta { get; set; }

        /// <summary>
        /// The ID of the item this summary text delta is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the output item this summary text delta is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// The index of the summary part within the reasoning summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SummaryIndex { get; set; }

        /// <summary>
        /// The type of the event. Always `response.reasoning_summary_text.delta`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryTextDeltaEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseReasoningSummaryTextDeltaEvent" /> class.
        /// </summary>
        /// <param name="delta">
        /// The text delta that was added to the summary.
        /// </param>
        /// <param name="itemId">
        /// The ID of the item this summary text delta is associated with.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item this summary text delta is associated with.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        /// <param name="summaryIndex">
        /// The index of the summary part within the reasoning summary.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `response.reasoning_summary_text.delta`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseReasoningSummaryTextDeltaEvent(
            string delta,
            string itemId,
            int outputIndex,
            int sequenceNumber,
            int summaryIndex,
            global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEventType type)
        {
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.SequenceNumber = sequenceNumber;
            this.SummaryIndex = summaryIndex;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseReasoningSummaryTextDeltaEvent" /> class.
        /// </summary>
        public ResponseReasoningSummaryTextDeltaEvent()
        {
        }
    }
}
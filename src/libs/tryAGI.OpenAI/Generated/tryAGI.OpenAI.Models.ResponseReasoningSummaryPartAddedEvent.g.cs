
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when a new reasoning summary part is added.
    /// </summary>
    public sealed partial class ResponseReasoningSummaryPartAddedEvent
    {
        /// <summary>
        /// The ID of the item this summary part is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the output item this summary part is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The summary part that was added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("part")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventPart Part { get; set; }

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
        /// The type of the event. Always `response.reasoning_summary_part.added`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartAddedEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseReasoningSummaryPartAddedEvent" /> class.
        /// </summary>
        /// <param name="itemId">
        /// The ID of the item this summary part is associated with.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item this summary part is associated with.
        /// </param>
        /// <param name="part">
        /// The summary part that was added.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        /// <param name="summaryIndex">
        /// The index of the summary part within the reasoning summary.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `response.reasoning_summary_part.added`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseReasoningSummaryPartAddedEvent(
            string itemId,
            int outputIndex,
            global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventPart part,
            int sequenceNumber,
            int summaryIndex,
            global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.Part = part ?? throw new global::System.ArgumentNullException(nameof(part));
            this.SequenceNumber = sequenceNumber;
            this.SummaryIndex = summaryIndex;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseReasoningSummaryPartAddedEvent" /> class.
        /// </summary>
        public ResponseReasoningSummaryPartAddedEvent()
        {
        }
    }
}
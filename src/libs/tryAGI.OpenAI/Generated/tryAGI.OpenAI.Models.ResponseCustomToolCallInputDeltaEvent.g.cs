
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Event representing a delta (partial update) to the input of a custom tool call.
    /// </summary>
    public sealed partial class ResponseCustomToolCallInputDeltaEvent
    {
        /// <summary>
        /// The incremental input data (delta) for the custom tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Delta { get; set; }

        /// <summary>
        /// Unique identifier for the API item associated with this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the output this delta applies to.
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
        /// The event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseCustomToolCallInputDeltaEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCustomToolCallInputDeltaEvent" /> class.
        /// </summary>
        /// <param name="delta">
        /// The incremental input data (delta) for the custom tool call.
        /// </param>
        /// <param name="itemId">
        /// Unique identifier for the API item associated with this event.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output this delta applies to.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        /// <param name="type">
        /// The event type identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseCustomToolCallInputDeltaEvent(
            string delta,
            string itemId,
            int outputIndex,
            int sequenceNumber,
            global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEventType type)
        {
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCustomToolCallInputDeltaEvent" /> class.
        /// </summary>
        public ResponseCustomToolCallInputDeltaEvent()
        {
        }
    }
}

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Event representing a delta (partial update) to the input of a custom tool call.
    /// </summary>
    public sealed partial class ResponseCustomToolCallInputDeltaEvent
    {
        /// <summary>
        /// The event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseCustomToolCallInputDeltaEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEventType Type { get; set; }

        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int SequenceNumber { get; set; } = default!;

        /// <summary>
        /// The index of the output this delta applies to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the API item associated with this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The incremental input data (delta) for the custom tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Delta { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCustomToolCallInputDeltaEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The event type identifier.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output this delta applies to.
        /// </param>
        /// <param name="itemId">
        /// Unique identifier for the API item associated with this event.
        /// </param>
        /// <param name="delta">
        /// The incremental input data (delta) for the custom tool call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseCustomToolCallInputDeltaEvent(
            int sequenceNumber,
            int outputIndex,
            string itemId,
            string delta,
            global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEventType type)
        {
            this.SequenceNumber = sequenceNumber;
            this.OutputIndex = outputIndex;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
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
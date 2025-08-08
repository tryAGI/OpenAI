
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Event indicating that input for a custom tool call is complete.
    /// </summary>
    public sealed partial class ResponseCustomToolCallInputDoneEvent
    {
        /// <summary>
        /// The complete input data for the custom tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// Unique identifier for the API item associated with this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the output this event applies to.
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseCustomToolCallInputDoneEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCustomToolCallInputDoneEvent" /> class.
        /// </summary>
        /// <param name="input">
        /// The complete input data for the custom tool call.
        /// </param>
        /// <param name="itemId">
        /// Unique identifier for the API item associated with this event.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output this event applies to.
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
        public ResponseCustomToolCallInputDoneEvent(
            string input,
            string itemId,
            int outputIndex,
            int sequenceNumber,
            global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEventType type)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCustomToolCallInputDoneEvent" /> class.
        /// </summary>
        public ResponseCustomToolCallInputDoneEvent()
        {
        }
    }
}
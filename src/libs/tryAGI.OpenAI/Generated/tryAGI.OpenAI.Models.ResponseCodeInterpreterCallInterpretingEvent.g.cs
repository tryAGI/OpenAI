
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when the code interpreter is actively interpreting the code snippet.
    /// </summary>
    public sealed partial class ResponseCodeInterpreterCallInterpretingEvent
    {
        /// <summary>
        /// The type of the event. Always `response.code_interpreter_call.interpreting`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallInterpretingEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEventType Type { get; set; }

        /// <summary>
        /// The index of the output item in the response for which the code interpreter is interpreting code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The unique identifier of the code interpreter tool call item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The sequence number of this event, used to order streaming events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCodeInterpreterCallInterpretingEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.code_interpreter_call.interpreting`.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the response for which the code interpreter is interpreting code.
        /// </param>
        /// <param name="itemId">
        /// The unique identifier of the code interpreter tool call item.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event, used to order streaming events.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseCodeInterpreterCallInterpretingEvent(
            int outputIndex,
            string itemId,
            int sequenceNumber,
            global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEventType type)
        {
            this.OutputIndex = outputIndex;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCodeInterpreterCallInterpretingEvent" /> class.
        /// </summary>
        public ResponseCodeInterpreterCallInterpretingEvent()
        {
        }
    }
}
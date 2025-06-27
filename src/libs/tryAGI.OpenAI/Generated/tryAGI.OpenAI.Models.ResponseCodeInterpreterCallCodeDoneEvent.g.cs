
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when the code snippet is finalized by the code interpreter.
    /// </summary>
    public sealed partial class ResponseCodeInterpreterCallCodeDoneEvent
    {
        /// <summary>
        /// The final code snippet output by the code interpreter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// The unique identifier of the code interpreter tool call item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the output item in the response for which the code is finalized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The sequence number of this event, used to order streaming events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// The type of the event. Always `response.code_interpreter_call_code.done`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallCodeDoneEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCodeInterpreterCallCodeDoneEvent" /> class.
        /// </summary>
        /// <param name="code">
        /// The final code snippet output by the code interpreter.
        /// </param>
        /// <param name="itemId">
        /// The unique identifier of the code interpreter tool call item.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the response for which the code is finalized.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event, used to order streaming events.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `response.code_interpreter_call_code.done`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseCodeInterpreterCallCodeDoneEvent(
            string code,
            string itemId,
            int outputIndex,
            int sequenceNumber,
            global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEventType type)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCodeInterpreterCallCodeDoneEvent" /> class.
        /// </summary>
        public ResponseCodeInterpreterCallCodeDoneEvent()
        {
        }
    }
}
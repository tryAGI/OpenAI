
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when the arguments for an MCP tool call are finalized.
    /// </summary>
    public sealed partial class ResponseMCPCallArgumentsDoneEvent
    {
        /// <summary>
        /// The type of the event. Always 'response.mcp_call_arguments.done'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallArgumentsDoneEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEventType Type { get; set; }

        /// <summary>
        /// The index of the output item in the response's output array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The unique identifier of the MCP tool call item being processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// A JSON string containing the finalized arguments for the MCP tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Arguments { get; set; } = default!;

        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int SequenceNumber { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseMCPCallArgumentsDoneEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always 'response.mcp_call_arguments.done'.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the response's output array.
        /// </param>
        /// <param name="itemId">
        /// The unique identifier of the MCP tool call item being processed.
        /// </param>
        /// <param name="arguments">
        /// A JSON string containing the finalized arguments for the MCP tool call.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseMCPCallArgumentsDoneEvent(
            int outputIndex,
            string itemId,
            string arguments,
            int sequenceNumber,
            global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEventType type)
        {
            this.OutputIndex = outputIndex;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseMCPCallArgumentsDoneEvent" /> class.
        /// </summary>
        public ResponseMCPCallArgumentsDoneEvent()
        {
        }
    }
}

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when there is a delta (partial update) to the arguments of an MCP tool call.
    /// </summary>
    public sealed partial class BetaResponseMCPCallArgumentsDeltaEvent
    {
        /// <summary>
        /// The agent that owns this multi-agent streaming event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTag? Agent { get; set; }

        /// <summary>
        /// The type of the event. Always 'response.mcp_call_arguments.delta'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPCallArgumentsDeltaEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEventType Type { get; set; }

        /// <summary>
        /// The index of the output item in the response's output array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The unique identifier of the MCP tool call item being processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// A JSON string containing the partial update to the arguments for the MCP tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Delta { get; set; }

        /// <summary>
        /// The sequence number of this event.
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
        /// Initializes a new instance of the <see cref="BetaResponseMCPCallArgumentsDeltaEvent" /> class.
        /// </summary>
        /// <param name="outputIndex">
        /// The index of the output item in the response's output array.
        /// </param>
        /// <param name="itemId">
        /// The unique identifier of the MCP tool call item being processed.
        /// </param>
        /// <param name="delta">
        /// A JSON string containing the partial update to the arguments for the MCP tool call.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        /// <param name="agent">
        /// The agent that owns this multi-agent streaming event.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always 'response.mcp_call_arguments.delta'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseMCPCallArgumentsDeltaEvent(
            int outputIndex,
            string itemId,
            string delta,
            int sequenceNumber,
            global::tryAGI.OpenAI.BetaAgentTag? agent,
            global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEventType type)
        {
            this.Agent = agent;
            this.Type = type;
            this.OutputIndex = outputIndex;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.SequenceNumber = sequenceNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseMCPCallArgumentsDeltaEvent" /> class.
        /// </summary>
        public BetaResponseMCPCallArgumentsDeltaEvent()
        {
        }

    }
}

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when the system is in the process of retrieving the list of available MCP tools.
    /// </summary>
    public sealed partial class BetaResponseMCPListToolsInProgressEvent
    {
        /// <summary>
        /// The agent that owns this multi-agent streaming event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTag? Agent { get; set; }

        /// <summary>
        /// The type of the event. Always 'response.mcp_list_tools.in_progress'.
        /// </summary>
        /// <default>"response.mcp_list_tools.in_progress"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "response.mcp_list_tools.in_progress";

        /// <summary>
        /// The ID of the MCP tool call item that is being processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the output item that is being processed.
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseMCPListToolsInProgressEvent" /> class.
        /// </summary>
        /// <param name="itemId">
        /// The ID of the MCP tool call item that is being processed.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that is being processed.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        /// <param name="agent">
        /// The agent that owns this multi-agent streaming event.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always 'response.mcp_list_tools.in_progress'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseMCPListToolsInProgressEvent(
            string itemId,
            int outputIndex,
            int sequenceNumber,
            global::tryAGI.OpenAI.BetaAgentTag? agent,
            string type = "response.mcp_list_tools.in_progress")
        {
            this.Agent = agent;
            this.Type = type;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.SequenceNumber = sequenceNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseMCPListToolsInProgressEvent" /> class.
        /// </summary>
        public BetaResponseMCPListToolsInProgressEvent()
        {
        }

    }
}
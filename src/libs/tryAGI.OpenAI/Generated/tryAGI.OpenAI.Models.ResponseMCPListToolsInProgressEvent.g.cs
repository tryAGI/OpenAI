
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when the system is in the process of retrieving the list of available MCP tools.
    /// </summary>
    public sealed partial class ResponseMCPListToolsInProgressEvent
    {
        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// The type of the event. Always 'response.mcp_list_tools.in_progress'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseMCPListToolsInProgressEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseMCPListToolsInProgressEvent" /> class.
        /// </summary>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always 'response.mcp_list_tools.in_progress'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseMCPListToolsInProgressEvent(
            int sequenceNumber,
            global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEventType type)
        {
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseMCPListToolsInProgressEvent" /> class.
        /// </summary>
        public ResponseMCPListToolsInProgressEvent()
        {
        }
    }
}
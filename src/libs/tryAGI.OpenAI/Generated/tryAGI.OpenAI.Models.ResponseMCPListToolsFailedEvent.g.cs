
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when the attempt to list available MCP tools has failed.
    /// </summary>
    public sealed partial class ResponseMCPListToolsFailedEvent
    {
        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// The type of the event. Always 'response.mcp_list_tools.failed'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseMCPListToolsFailedEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseMCPListToolsFailedEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseMCPListToolsFailedEvent" /> class.
        /// </summary>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always 'response.mcp_list_tools.failed'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseMCPListToolsFailedEvent(
            int sequenceNumber,
            global::tryAGI.OpenAI.ResponseMCPListToolsFailedEventType type)
        {
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseMCPListToolsFailedEvent" /> class.
        /// </summary>
        public ResponseMCPListToolsFailedEvent()
        {
        }
    }
}
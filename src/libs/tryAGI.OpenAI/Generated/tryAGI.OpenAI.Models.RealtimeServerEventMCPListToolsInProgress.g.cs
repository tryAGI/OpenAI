
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when listing MCP tools is in progress for an item.
    /// </summary>
    public sealed partial class RealtimeServerEventMCPListToolsInProgress
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The ID of the MCP list tools item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The event type, must be `mcp_list_tools.in_progress`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventMCPListToolsInProgressTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgressType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventMCPListToolsInProgress" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="itemId">
        /// The ID of the MCP list tools item.
        /// </param>
        /// <param name="type">
        /// The event type, must be `mcp_list_tools.in_progress`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeServerEventMCPListToolsInProgress(
            string eventId,
            string itemId,
            global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgressType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventMCPListToolsInProgress" /> class.
        /// </summary>
        public RealtimeServerEventMCPListToolsInProgress()
        {
        }
    }
}
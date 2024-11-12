
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Send this event when you want to remove any item from the conversation history.
    /// </summary>
    public sealed partial class RealtimeConversationItemDelete
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.<br/>
        /// Example: event_901
        /// </summary>
        /// <example>event_901</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "conversation.item.delete".<br/>
        /// Example: conversation.item.delete
        /// </summary>
        /// <example>conversation.item.delete</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.RealtimeConversationItemDeleteTypeJsonConverter))]
        public global::OpenAI.RealtimeConversationItemDeleteType? Type { get; set; }

        /// <summary>
        /// The ID of the item to delete.<br/>
        /// Example: msg_003
        /// </summary>
        /// <example>msg_003</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemDelete" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.<br/>
        /// Example: event_901
        /// </param>
        /// <param name="type">
        /// The event type, must be "conversation.item.delete".<br/>
        /// Example: conversation.item.delete
        /// </param>
        /// <param name="itemId">
        /// The ID of the item to delete.<br/>
        /// Example: msg_003
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeConversationItemDelete(
            string? eventId,
            global::OpenAI.RealtimeConversationItemDeleteType? type,
            string? itemId)
        {
            this.EventId = eventId;
            this.Type = type;
            this.ItemId = itemId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemDelete" /> class.
        /// </summary>
        public RealtimeConversationItemDelete()
        {
        }
    }
}
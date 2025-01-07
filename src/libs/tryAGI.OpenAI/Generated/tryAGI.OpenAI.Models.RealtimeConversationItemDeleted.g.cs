
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when an item in the conversation is deleted.
    /// </summary>
    public sealed partial class RealtimeConversationItemDeleted
    {
        /// <summary>
        /// The unique ID of the server event.<br/>
        /// Example: event_2728
        /// </summary>
        /// <example>event_2728</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "conversation.item.deleted".<br/>
        /// Example: conversation.item.deleted
        /// </summary>
        /// <example>conversation.item.deleted</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemDeletedTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeConversationItemDeletedType? Type { get; set; }

        /// <summary>
        /// The ID of the item that was deleted.<br/>
        /// Example: msg_005
        /// </summary>
        /// <example>msg_005</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemDeleted" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.<br/>
        /// Example: event_2728
        /// </param>
        /// <param name="type">
        /// The event type, must be "conversation.item.deleted".<br/>
        /// Example: conversation.item.deleted
        /// </param>
        /// <param name="itemId">
        /// The ID of the item that was deleted.<br/>
        /// Example: msg_005
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeConversationItemDeleted(
            string? eventId,
            global::tryAGI.OpenAI.RealtimeConversationItemDeletedType? type,
            string? itemId)
        {
            this.EventId = eventId;
            this.Type = type;
            this.ItemId = itemId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemDeleted" /> class.
        /// </summary>
        public RealtimeConversationItemDeleted()
        {
        }
    }
}
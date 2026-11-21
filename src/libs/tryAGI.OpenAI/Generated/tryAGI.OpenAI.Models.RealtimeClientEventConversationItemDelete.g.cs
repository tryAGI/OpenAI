
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Send this event when you want to remove any item from the conversation <br/>
    /// history. The server will respond with a `conversation.item.deleted` event, <br/>
    /// unless the item does not exist in the conversation history, in which case the <br/>
    /// server will respond with an error.
    /// </summary>
    public sealed partial class RealtimeClientEventConversationItemDelete
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be `conversation.item.delete`.
        /// </summary>
        /// <default>"conversation.item.delete"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "conversation.item.delete";

        /// <summary>
        /// The ID of the item to delete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventConversationItemDelete" /> class.
        /// </summary>
        /// <param name="itemId">
        /// The ID of the item to delete.
        /// </param>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `conversation.item.delete`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeClientEventConversationItemDelete(
            string itemId,
            string? eventId,
            string type = "conversation.item.delete")
        {
            this.EventId = eventId;
            this.Type = type;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventConversationItemDelete" /> class.
        /// </summary>
        public RealtimeClientEventConversationItemDelete()
        {
        }

        /// <summary>
        /// Creates a new <see cref="RealtimeClientEventConversationItemDelete"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static RealtimeClientEventConversationItemDelete FromItemId(string itemId)
        {
            return new RealtimeClientEventConversationItemDelete
            {
                ItemId = itemId,
            };
        }

    }
}
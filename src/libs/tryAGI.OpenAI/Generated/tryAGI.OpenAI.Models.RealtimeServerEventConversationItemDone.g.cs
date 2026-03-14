
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when a conversation item is finalized.<br/>
    /// The event will include the full content of the Item except for audio data, which can be retrieved separately with a `conversation.item.retrieve` event if needed.
    /// </summary>
    public sealed partial class RealtimeServerEventConversationItemDone
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type, must be `conversation.item.done`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemDoneTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemDoneType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_item_id")]
        public string? PreviousItemId { get; set; }

        /// <summary>
        /// A single item within a Realtime conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RealtimeConversationItem Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationItemDone" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `conversation.item.done`.
        /// </param>
        /// <param name="previousItemId"></param>
        /// <param name="item">
        /// A single item within a Realtime conversation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeServerEventConversationItemDone(
            string eventId,
            global::tryAGI.OpenAI.RealtimeConversationItem item,
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemDoneType type,
            string? previousItemId)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Item = item;
            this.Type = type;
            this.PreviousItemId = previousItemId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationItemDone" /> class.
        /// </summary>
        public RealtimeServerEventConversationItemDone()
        {
        }
    }
}
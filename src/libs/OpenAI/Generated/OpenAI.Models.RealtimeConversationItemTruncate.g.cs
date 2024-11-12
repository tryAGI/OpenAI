
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Send this event when you want to truncate a previous assistant message’s audio.
    /// </summary>
    public sealed partial class RealtimeConversationItemTruncate
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.<br/>
        /// Example: event_678
        /// </summary>
        /// <example>event_678</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "conversation.item.truncate".<br/>
        /// Example: conversation.item.truncate
        /// </summary>
        /// <example>conversation.item.truncate</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.RealtimeConversationItemTruncateTypeJsonConverter))]
        public global::OpenAI.RealtimeConversationItemTruncateType? Type { get; set; }

        /// <summary>
        /// The ID of the assistant message item to truncate.<br/>
        /// Example: msg_002
        /// </summary>
        /// <example>msg_002</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// The index of the content part to truncate.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        public int? ContentIndex { get; set; }

        /// <summary>
        /// Inclusive duration up to which audio is truncated, in milliseconds.<br/>
        /// Example: 1500
        /// </summary>
        /// <example>1500</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_end_ms")]
        public int? AudioEndMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemTruncate" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.<br/>
        /// Example: event_678
        /// </param>
        /// <param name="type">
        /// The event type, must be "conversation.item.truncate".<br/>
        /// Example: conversation.item.truncate
        /// </param>
        /// <param name="itemId">
        /// The ID of the assistant message item to truncate.<br/>
        /// Example: msg_002
        /// </param>
        /// <param name="contentIndex">
        /// The index of the content part to truncate.<br/>
        /// Example: 0
        /// </param>
        /// <param name="audioEndMs">
        /// Inclusive duration up to which audio is truncated, in milliseconds.<br/>
        /// Example: 1500
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeConversationItemTruncate(
            string? eventId,
            global::OpenAI.RealtimeConversationItemTruncateType? type,
            string? itemId,
            int? contentIndex,
            int? audioEndMs)
        {
            this.EventId = eventId;
            this.Type = type;
            this.ItemId = itemId;
            this.ContentIndex = contentIndex;
            this.AudioEndMs = audioEndMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemTruncate" /> class.
        /// </summary>
        public RealtimeConversationItemTruncate()
        {
        }
    }
}
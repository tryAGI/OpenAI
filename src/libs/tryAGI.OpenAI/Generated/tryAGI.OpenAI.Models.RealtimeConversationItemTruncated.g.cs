
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when an earlier assistant audio message item is truncated by the client.
    /// </summary>
    public sealed partial class RealtimeConversationItemTruncated
    {
        /// <summary>
        /// The unique ID of the server event.<br/>
        /// Example: event_2526
        /// </summary>
        /// <example>event_2526</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "conversation.item.truncated".<br/>
        /// Example: conversation.item.truncated
        /// </summary>
        /// <example>conversation.item.truncated</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemTruncatedTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeConversationItemTruncatedType? Type { get; set; }

        /// <summary>
        /// The ID of the assistant message item that was truncated.<br/>
        /// Example: msg_004
        /// </summary>
        /// <example>msg_004</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// The index of the content part that was truncated.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        public int? ContentIndex { get; set; }

        /// <summary>
        /// The duration up to which the audio was truncated, in milliseconds.<br/>
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
        /// Initializes a new instance of the <see cref="RealtimeConversationItemTruncated" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.<br/>
        /// Example: event_2526
        /// </param>
        /// <param name="type">
        /// The event type, must be "conversation.item.truncated".<br/>
        /// Example: conversation.item.truncated
        /// </param>
        /// <param name="itemId">
        /// The ID of the assistant message item that was truncated.<br/>
        /// Example: msg_004
        /// </param>
        /// <param name="contentIndex">
        /// The index of the content part that was truncated.<br/>
        /// Example: 0
        /// </param>
        /// <param name="audioEndMs">
        /// The duration up to which the audio was truncated, in milliseconds.<br/>
        /// Example: 1500
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeConversationItemTruncated(
            string? eventId,
            global::tryAGI.OpenAI.RealtimeConversationItemTruncatedType? type,
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
        /// Initializes a new instance of the <see cref="RealtimeConversationItemTruncated" /> class.
        /// </summary>
        public RealtimeConversationItemTruncated()
        {
        }
    }
}
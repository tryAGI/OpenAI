
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Returned when a conversation item is created.
    /// </summary>
    public sealed partial class RealtimeConversationItemCreated
    {
        /// <summary>
        /// The unique ID of the server event.<br/>
        /// Example: event_1920
        /// </summary>
        /// <example>event_1920</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "conversation.item.created".<br/>
        /// Example: conversation.item.created
        /// </summary>
        /// <example>conversation.item.created</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.RealtimeConversationItemCreatedTypeJsonConverter))]
        public global::OpenAI.RealtimeConversationItemCreatedType? Type { get; set; }

        /// <summary>
        /// The ID of the preceding item.<br/>
        /// Example: msg_002
        /// </summary>
        /// <example>msg_002</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_item_id")]
        public string? PreviousItemId { get; set; }

        /// <summary>
        /// A realtime Item is of three types: message, function_call, or function_call_output.<br/>
        /// A message item can contain text or audio.<br/>
        /// A function_call item indicates a model's desire to call a function, which is the only tool supported for now<br/>
        /// A function_call_output item indicates a function response.<br/>
        /// The client may add and remove message and function_call_output Items using conversation.item.create and conversation.item.delete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        public global::OpenAI.RealtimeConversationItem? Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemCreated" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.<br/>
        /// Example: event_1920
        /// </param>
        /// <param name="type">
        /// The event type, must be "conversation.item.created".<br/>
        /// Example: conversation.item.created
        /// </param>
        /// <param name="previousItemId">
        /// The ID of the preceding item.<br/>
        /// Example: msg_002
        /// </param>
        /// <param name="item">
        /// A realtime Item is of three types: message, function_call, or function_call_output.<br/>
        /// A message item can contain text or audio.<br/>
        /// A function_call item indicates a model's desire to call a function, which is the only tool supported for now<br/>
        /// A function_call_output item indicates a function response.<br/>
        /// The client may add and remove message and function_call_output Items using conversation.item.create and conversation.item.delete.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeConversationItemCreated(
            string? eventId,
            global::OpenAI.RealtimeConversationItemCreatedType? type,
            string? previousItemId,
            global::OpenAI.RealtimeConversationItem? item)
        {
            this.EventId = eventId;
            this.Type = type;
            this.PreviousItemId = previousItemId;
            this.Item = item;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemCreated" /> class.
        /// </summary>
        public RealtimeConversationItemCreated()
        {
        }
    }
}

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Add a new Item to the Conversation's context, including messages, function <br/>
    /// calls, and function call responses. This event can be used both to populate a <br/>
    /// "history" of the conversation and to add new items mid-stream, but has the <br/>
    /// current limitation that it cannot populate assistant audio messages.<br/>
    /// If successful, the server will respond with a `conversation.item.created` <br/>
    /// event, otherwise an `error` event will be sent.
    /// </summary>
    public sealed partial class RealtimeClientEventConversationItemCreate
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be `conversation.item.create`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventConversationItemCreateTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreateType Type { get; set; }

        /// <summary>
        /// The ID of the preceding item after which the new item will be inserted. <br/>
        /// If not set, the new item will be appended to the end of the conversation.<br/>
        /// If set to `root`, the new item will be added to the beginning of the conversation.<br/>
        /// If set to an existing ID, it allows an item to be inserted mid-conversation. If the<br/>
        /// ID cannot be found, an error will be returned and the item will not be added.
        /// </summary>
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RealtimeConversationItem Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventConversationItemCreate" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `conversation.item.create`.
        /// </param>
        /// <param name="previousItemId">
        /// The ID of the preceding item after which the new item will be inserted. <br/>
        /// If not set, the new item will be appended to the end of the conversation.<br/>
        /// If set to `root`, the new item will be added to the beginning of the conversation.<br/>
        /// If set to an existing ID, it allows an item to be inserted mid-conversation. If the<br/>
        /// ID cannot be found, an error will be returned and the item will not be added.
        /// </param>
        /// <param name="item">
        /// A realtime Item is of three types: message, function_call, or function_call_output.<br/>
        /// A message item can contain text or audio.<br/>
        /// A function_call item indicates a model's desire to call a function, which is the only tool supported for now<br/>
        /// A function_call_output item indicates a function response.<br/>
        /// The client may add and remove message and function_call_output Items using conversation.item.create and conversation.item.delete.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeClientEventConversationItemCreate(
            global::tryAGI.OpenAI.RealtimeConversationItem item,
            string? eventId,
            global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreateType type,
            string? previousItemId)
        {
            this.Item = item ?? throw new global::System.ArgumentNullException(nameof(item));
            this.EventId = eventId;
            this.Type = type;
            this.PreviousItemId = previousItemId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventConversationItemCreate" /> class.
        /// </summary>
        public RealtimeClientEventConversationItemCreate()
        {
        }
    }
}
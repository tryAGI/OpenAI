
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when a conversation item is created. There are several scenarios that produce this event:<br/>
    ///   - The server is generating a Response, which if successful will produce<br/>
    ///     either one or two Items, which will be of type `message`<br/>
    ///     (role `assistant`) or type `function_call`.<br/>
    ///   - The input audio buffer has been committed, either by the client or the<br/>
    ///     server (in `server_vad` mode). The server will take the content of the<br/>
    ///     input audio buffer and add it to a new user message Item.<br/>
    ///   - The client has sent a `conversation.item.create` event to add a new Item<br/>
    ///     to the Conversation.
    /// </summary>
    public sealed partial class RealtimeServerEventConversationItemCreated
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

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
        /// The ID of the preceding item in the Conversation context, allows the<br/>
        /// client to understand the order of the conversation. Can be `null` if the<br/>
        /// item has no predecessor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_item_id")]
        public string? PreviousItemId { get; set; }

        /// <summary>
        /// The event type, must be `conversation.item.created`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemCreatedTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreatedType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationItemCreated" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="item">
        /// A realtime Item is of three types: message, function_call, or function_call_output.<br/>
        /// A message item can contain text or audio.<br/>
        /// A function_call item indicates a model's desire to call a function, which is the only tool supported for now<br/>
        /// A function_call_output item indicates a function response.<br/>
        /// The client may add and remove message and function_call_output Items using conversation.item.create and conversation.item.delete.
        /// </param>
        /// <param name="previousItemId">
        /// The ID of the preceding item in the Conversation context, allows the<br/>
        /// client to understand the order of the conversation. Can be `null` if the<br/>
        /// item has no predecessor.
        /// </param>
        /// <param name="type">
        /// The event type, must be `conversation.item.created`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeServerEventConversationItemCreated(
            string eventId,
            global::tryAGI.OpenAI.RealtimeConversationItem item,
            string? previousItemId,
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreatedType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Item = item ?? throw new global::System.ArgumentNullException(nameof(item));
            this.PreviousItemId = previousItemId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationItemCreated" /> class.
        /// </summary>
        public RealtimeServerEventConversationItemCreated()
        {
        }
    }
}
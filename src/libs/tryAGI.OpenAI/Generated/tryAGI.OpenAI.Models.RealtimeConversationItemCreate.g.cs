
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Send this event when adding an item to the conversation.
    /// </summary>
    public sealed partial class RealtimeConversationItemCreate
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.<br/>
        /// Example: event_345
        /// </summary>
        /// <example>event_345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "conversation.item.create".<br/>
        /// Example: conversation.item.create
        /// </summary>
        /// <example>conversation.item.create</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemCreateTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeConversationItemCreateType? Type { get; set; }

        /// <summary>
        /// The ID of the preceding item after which the new item will be inserted.
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
        public global::tryAGI.OpenAI.RealtimeConversationItem? Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemCreate" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.<br/>
        /// Example: event_345
        /// </param>
        /// <param name="type">
        /// The event type, must be "conversation.item.create".<br/>
        /// Example: conversation.item.create
        /// </param>
        /// <param name="previousItemId">
        /// The ID of the preceding item after which the new item will be inserted.
        /// </param>
        /// <param name="item">
        /// A realtime Item is of three types: message, function_call, or function_call_output.<br/>
        /// A message item can contain text or audio.<br/>
        /// A function_call item indicates a model's desire to call a function, which is the only tool supported for now<br/>
        /// A function_call_output item indicates a function response.<br/>
        /// The client may add and remove message and function_call_output Items using conversation.item.create and conversation.item.delete.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeConversationItemCreate(
            string? eventId,
            global::tryAGI.OpenAI.RealtimeConversationItemCreateType? type,
            string? previousItemId,
            global::tryAGI.OpenAI.RealtimeConversationItem? item)
        {
            this.EventId = eventId;
            this.Type = type;
            this.PreviousItemId = previousItemId;
            this.Item = item;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemCreate" /> class.
        /// </summary>
        public RealtimeConversationItemCreate()
        {
        }
    }
}
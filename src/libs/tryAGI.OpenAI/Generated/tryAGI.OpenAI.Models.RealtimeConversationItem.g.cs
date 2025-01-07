
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A realtime Item is of three types: message, function_call, or function_call_output.<br/>
    /// A message item can contain text or audio.<br/>
    /// A function_call item indicates a model's desire to call a function, which is the only tool supported for now<br/>
    /// A function_call_output item indicates a function response.<br/>
    /// The client may add and remove message and function_call_output Items using conversation.item.create and conversation.item.delete.
    /// </summary>
    public sealed partial class RealtimeConversationItem
    {
        /// <summary>
        /// The unique ID of the item.<br/>
        /// Example: msg_003
        /// </summary>
        /// <example>msg_003</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The object type, must be "realtime.item".<br/>
        /// Example: realtime.item
        /// </summary>
        /// <example>realtime.item</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemObjectJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeConversationItemObject? Object { get; set; }

        /// <summary>
        /// The type of the item.<br/>
        /// Example: message
        /// </summary>
        /// <example>message</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeConversationItemType? Type { get; set; }

        /// <summary>
        /// The status of the item.<br/>
        /// Example: completed
        /// </summary>
        /// <example>completed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemStatusJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeConversationItemStatus? Status { get; set; }

        /// <summary>
        /// The role of the message sender.<br/>
        /// Example: user
        /// </summary>
        /// <example>user</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemRoleJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeConversationItemRole? Role { get; set; }

        /// <summary>
        /// The content of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemContentItem>? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the item.<br/>
        /// Example: msg_003
        /// </param>
        /// <param name="object">
        /// The object type, must be "realtime.item".<br/>
        /// Example: realtime.item
        /// </param>
        /// <param name="type">
        /// The type of the item.<br/>
        /// Example: message
        /// </param>
        /// <param name="status">
        /// The status of the item.<br/>
        /// Example: completed
        /// </param>
        /// <param name="role">
        /// The role of the message sender.<br/>
        /// Example: user
        /// </param>
        /// <param name="content">
        /// The content of the message.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeConversationItem(
            string? id,
            global::tryAGI.OpenAI.RealtimeConversationItemObject? @object,
            global::tryAGI.OpenAI.RealtimeConversationItemType? type,
            global::tryAGI.OpenAI.RealtimeConversationItemStatus? status,
            global::tryAGI.OpenAI.RealtimeConversationItemRole? role,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemContentItem>? content)
        {
            this.Id = id;
            this.Object = @object;
            this.Type = type;
            this.Status = status;
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItem" /> class.
        /// </summary>
        public RealtimeConversationItem()
        {
        }
    }
}
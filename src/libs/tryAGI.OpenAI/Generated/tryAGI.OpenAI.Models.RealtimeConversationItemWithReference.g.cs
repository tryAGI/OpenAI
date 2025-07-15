
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item to add to the conversation.
    /// </summary>
    public sealed partial class RealtimeConversationItemWithReference
    {
        /// <summary>
        /// The arguments of the function call (for `function_call` items).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        /// The ID of the function call (for `function_call` and <br/>
        /// `function_call_output` items). If passed on a `function_call_output` <br/>
        /// item, the server will check that a `function_call` item with the same <br/>
        /// ID exists in the conversation history.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        public string? CallId { get; set; }

        /// <summary>
        /// The content of the message, applicable for `message` items. <br/>
        /// - Message items of role `system` support only `input_text` content<br/>
        /// - Message items of role `user` support `input_text` and `input_audio` <br/>
        ///   content<br/>
        /// - Message items of role `assistant` support `text` content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceContentItem>? Content { get; set; }

        /// <summary>
        /// For an item of type (`message` | `function_call` | `function_call_output`)<br/>
        /// this field allows the client to assign the unique ID of the item. It is<br/>
        /// not required because the server will generate one if not provided.<br/>
        /// For an item of type `item_reference`, this field is required and is a<br/>
        /// reference to any item that has previously existed in the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the function being called (for `function_call` items).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Identifier for the API object being returned - always `realtime.item`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemWithReferenceObjectJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceObject? Object { get; set; }

        /// <summary>
        /// The output of the function call (for `function_call_output` items).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public string? Output { get; set; }

        /// <summary>
        /// The role of the message sender (`user`, `assistant`, `system`), only <br/>
        /// applicable for `message` items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemWithReferenceRoleJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceRole? Role { get; set; }

        /// <summary>
        /// The status of the item (`completed`, `incomplete`, `in_progress`). These have no effect <br/>
        /// on the conversation, but are accepted for consistency with the <br/>
        /// `conversation.item.created` event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemWithReferenceStatusJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceStatus? Status { get; set; }

        /// <summary>
        /// The type of the item (`message`, `function_call`, `function_call_output`, `item_reference`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemWithReferenceTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemWithReference" /> class.
        /// </summary>
        /// <param name="arguments">
        /// The arguments of the function call (for `function_call` items).
        /// </param>
        /// <param name="callId">
        /// The ID of the function call (for `function_call` and <br/>
        /// `function_call_output` items). If passed on a `function_call_output` <br/>
        /// item, the server will check that a `function_call` item with the same <br/>
        /// ID exists in the conversation history.
        /// </param>
        /// <param name="content">
        /// The content of the message, applicable for `message` items. <br/>
        /// - Message items of role `system` support only `input_text` content<br/>
        /// - Message items of role `user` support `input_text` and `input_audio` <br/>
        ///   content<br/>
        /// - Message items of role `assistant` support `text` content.
        /// </param>
        /// <param name="id">
        /// For an item of type (`message` | `function_call` | `function_call_output`)<br/>
        /// this field allows the client to assign the unique ID of the item. It is<br/>
        /// not required because the server will generate one if not provided.<br/>
        /// For an item of type `item_reference`, this field is required and is a<br/>
        /// reference to any item that has previously existed in the conversation.
        /// </param>
        /// <param name="name">
        /// The name of the function being called (for `function_call` items).
        /// </param>
        /// <param name="object">
        /// Identifier for the API object being returned - always `realtime.item`.
        /// </param>
        /// <param name="output">
        /// The output of the function call (for `function_call_output` items).
        /// </param>
        /// <param name="role">
        /// The role of the message sender (`user`, `assistant`, `system`), only <br/>
        /// applicable for `message` items.
        /// </param>
        /// <param name="status">
        /// The status of the item (`completed`, `incomplete`, `in_progress`). These have no effect <br/>
        /// on the conversation, but are accepted for consistency with the <br/>
        /// `conversation.item.created` event.
        /// </param>
        /// <param name="type">
        /// The type of the item (`message`, `function_call`, `function_call_output`, `item_reference`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeConversationItemWithReference(
            string? arguments,
            string? callId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceContentItem>? content,
            string? id,
            string? name,
            global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceObject? @object,
            string? output,
            global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceRole? role,
            global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceStatus? status,
            global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceType? type)
        {
            this.Arguments = arguments;
            this.CallId = callId;
            this.Content = content;
            this.Id = id;
            this.Name = name;
            this.Object = @object;
            this.Output = output;
            this.Role = role;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemWithReference" /> class.
        /// </summary>
        public RealtimeConversationItemWithReference()
        {
        }
    }
}
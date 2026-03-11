
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Assistant-authored message within a thread.
    /// </summary>
    public sealed partial class AssistantMessageItem
    {
        /// <summary>
        /// Identifier of the thread item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Type discriminator that is always `chatkit.thread_item`.<br/>
        /// Default Value: chatkit.thread_item
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AssistantMessageItemObject.ChatkitThreadItem</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AssistantMessageItemObjectJsonConverter))]
        public global::tryAGI.OpenAI.AssistantMessageItemObject Object { get; set; } = global::tryAGI.OpenAI.AssistantMessageItemObject.ChatkitThreadItem;

        /// <summary>
        /// Unix timestamp (in seconds) for when the item was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// Identifier of the parent thread.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ThreadId { get; set; } = default!;

        /// <summary>
        /// Type discriminator that is always `chatkit.assistant_message`.<br/>
        /// Default Value: chatkit.assistant_message
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AssistantMessageItemType.ChatkitAssistantMessage</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AssistantMessageItemTypeJsonConverter))]
        public global::tryAGI.OpenAI.AssistantMessageItemType Type { get; set; } = global::tryAGI.OpenAI.AssistantMessageItemType.ChatkitAssistantMessage;

        /// <summary>
        /// Ordered assistant response segments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseOutputText> Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of the thread item.
        /// </param>
        /// <param name="object">
        /// Type discriminator that is always `chatkit.thread_item`.<br/>
        /// Default Value: chatkit.thread_item
        /// </param>
        /// <param name="createdAt">
        /// Unix timestamp (in seconds) for when the item was created.
        /// </param>
        /// <param name="threadId">
        /// Identifier of the parent thread.
        /// </param>
        /// <param name="type">
        /// Type discriminator that is always `chatkit.assistant_message`.<br/>
        /// Default Value: chatkit.assistant_message
        /// </param>
        /// <param name="content">
        /// Ordered assistant response segments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantMessageItem(
            string id,
            global::System.DateTimeOffset createdAt,
            string threadId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseOutputText> content,
            global::tryAGI.OpenAI.AssistantMessageItemObject @object = global::tryAGI.OpenAI.AssistantMessageItemObject.ChatkitThreadItem,
            global::tryAGI.OpenAI.AssistantMessageItemType type = global::tryAGI.OpenAI.AssistantMessageItemType.ChatkitAssistantMessage)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.ThreadId = threadId ?? throw new global::System.ArgumentNullException(nameof(threadId));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Object = @object;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageItem" /> class.
        /// </summary>
        public AssistantMessageItem()
        {
        }
    }
}

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// User-authored messages within a thread.
    /// </summary>
    public sealed partial class UserMessageItem
    {
        /// <summary>
        /// Identifier of the thread item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Type discriminator that is always `chatkit.thread_item`.<br/>
        /// Default Value: chatkit.thread_item
        /// </summary>
        /// <default>global::tryAGI.OpenAI.UserMessageItemObject.ChatkitThreadItem</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UserMessageItemObjectJsonConverter))]
        public global::tryAGI.OpenAI.UserMessageItemObject Object { get; set; } = global::tryAGI.OpenAI.UserMessageItemObject.ChatkitThreadItem;

        /// <summary>
        /// Unix timestamp (in seconds) for when the item was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Identifier of the parent thread.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ThreadId { get; set; }

        /// <summary>
        /// Default Value: chatkit.user_message
        /// </summary>
        /// <default>global::tryAGI.OpenAI.UserMessageItemType.ChatkitUserMessage</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UserMessageItemTypeJsonConverter))]
        public global::tryAGI.OpenAI.UserMessageItemType Type { get; set; } = global::tryAGI.OpenAI.UserMessageItemType.ChatkitUserMessage;

        /// <summary>
        /// Ordered content elements supplied by the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem4> Content { get; set; }

        /// <summary>
        /// Attachments associated with the user message. Defaults to an empty list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Attachment> Attachments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inference_options")]
        public global::tryAGI.OpenAI.InferenceOptions? InferenceOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMessageItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of the thread item.
        /// </param>
        /// <param name="createdAt">
        /// Unix timestamp (in seconds) for when the item was created.
        /// </param>
        /// <param name="threadId">
        /// Identifier of the parent thread.
        /// </param>
        /// <param name="content">
        /// Ordered content elements supplied by the user.
        /// </param>
        /// <param name="attachments">
        /// Attachments associated with the user message. Defaults to an empty list.
        /// </param>
        /// <param name="inferenceOptions"></param>
        /// <param name="object">
        /// Type discriminator that is always `chatkit.thread_item`.<br/>
        /// Default Value: chatkit.thread_item
        /// </param>
        /// <param name="type">
        /// Default Value: chatkit.user_message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserMessageItem(
            string id,
            global::System.DateTimeOffset createdAt,
            string threadId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem4> content,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Attachment> attachments,
            global::tryAGI.OpenAI.InferenceOptions? inferenceOptions,
            global::tryAGI.OpenAI.UserMessageItemObject @object = global::tryAGI.OpenAI.UserMessageItemObject.ChatkitThreadItem,
            global::tryAGI.OpenAI.UserMessageItemType type = global::tryAGI.OpenAI.UserMessageItemType.ChatkitUserMessage)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.CreatedAt = createdAt;
            this.ThreadId = threadId ?? throw new global::System.ArgumentNullException(nameof(threadId));
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Attachments = attachments ?? throw new global::System.ArgumentNullException(nameof(attachments));
            this.InferenceOptions = inferenceOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMessageItem" /> class.
        /// </summary>
        public UserMessageItem()
        {
        }
    }
}
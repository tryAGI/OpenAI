
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionMessageListDataItem
    {
        /// <summary>
        /// If a content parts array was provided, this is an array of `text` and `image_url` parts.<br/>
        /// Otherwise, null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_parts")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText, global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage>>? ContentParts { get; set; }

        /// <summary>
        /// The identifier of the chat message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageListDataItem" /> class.
        /// </summary>
        /// <param name="contentParts">
        /// If a content parts array was provided, this is an array of `text` and `image_url` parts.<br/>
        /// Otherwise, null.
        /// </param>
        /// <param name="id">
        /// The identifier of the chat message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionMessageListDataItem(
            string id,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText, global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage>>? contentParts)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ContentParts = contentParts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageListDataItem" /> class.
        /// </summary>
        public ChatCompletionMessageListDataItem()
        {
        }
    }
}

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequestToolMessage
    {
        /// <summary>
        /// The role of the messages author, in this case `tool`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.ChatCompletionRequestToolMessageRoleJsonConverter))]
        public global::OpenAI.ChatCompletionRequestToolMessageRole Role { get; set; }

        /// <summary>
        /// The contents of the tool message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.OneOfJsonConverterFactory2))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionRequestToolMessageContentPart>> Content { get; set; }

        /// <summary>
        /// Tool call that this message is responding to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestToolMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the messages author, in this case `tool`.
        /// </param>
        /// <param name="content">
        /// The contents of the tool message.
        /// </param>
        /// <param name="toolCallId">
        /// Tool call that this message is responding to.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatCompletionRequestToolMessage(
            global::OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionRequestToolMessageContentPart>> content,
            string toolCallId,
            global::OpenAI.ChatCompletionRequestToolMessageRole role)
        {
            this.Content = content;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestToolMessage" /> class.
        /// </summary>
        public ChatCompletionRequestToolMessage()
        {
        }
    }
}
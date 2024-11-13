
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequestUserMessage
    {
        /// <summary>
        /// The contents of the user message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionRequestUserMessageContentPart>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionRequestUserMessageContentPart>> Content { get; set; }

        /// <summary>
        /// The role of the messages author, in this case `user`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.ChatCompletionRequestUserMessageRoleJsonConverter))]
        public global::OpenAI.ChatCompletionRequestUserMessageRole Role { get; set; }

        /// <summary>
        /// An optional name for the participant. Provides the model information to differentiate between participants of the same role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestUserMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The contents of the user message.
        /// </param>
        /// <param name="role">
        /// The role of the messages author, in this case `user`.
        /// </param>
        /// <param name="name">
        /// An optional name for the participant. Provides the model information to differentiate between participants of the same role.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatCompletionRequestUserMessage(
            global::OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionRequestUserMessageContentPart>> content,
            global::OpenAI.ChatCompletionRequestUserMessageRole role,
            string? name)
        {
            this.Content = content;
            this.Role = role;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestUserMessage" /> class.
        /// </summary>
        public ChatCompletionRequestUserMessage()
        {
        }
    }
}
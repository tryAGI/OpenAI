
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Developer-provided instructions that the model should follow, regardless of<br/>
    /// messages sent by the user. With o1 models and newer, `developer` messages<br/>
    /// replace the previous `system` messages.
    /// </summary>
    public sealed partial class ChatCompletionRequestDeveloperMessage
    {
        /// <summary>
        /// The contents of the developer message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionRequestMessageContentPartText>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionRequestMessageContentPartText>> Content { get; set; }

        /// <summary>
        /// The role of the messages author, in this case `developer`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.ChatCompletionRequestDeveloperMessageRoleJsonConverter))]
        public global::OpenAI.ChatCompletionRequestDeveloperMessageRole Role { get; set; }

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
        /// Initializes a new instance of the <see cref="ChatCompletionRequestDeveloperMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The contents of the developer message.
        /// </param>
        /// <param name="role">
        /// The role of the messages author, in this case `developer`.
        /// </param>
        /// <param name="name">
        /// An optional name for the participant. Provides the model information to differentiate between participants of the same role.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatCompletionRequestDeveloperMessage(
            global::OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionRequestMessageContentPartText>> content,
            global::OpenAI.ChatCompletionRequestDeveloperMessageRole role,
            string? name)
        {
            this.Content = content;
            this.Role = role;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestDeveloperMessage" /> class.
        /// </summary>
        public ChatCompletionRequestDeveloperMessage()
        {
        }
    }
}
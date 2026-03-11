
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A message to or from the model.
    /// </summary>
    public sealed partial class Message
    {
        /// <summary>
        /// The type of the message. Always set to `message`.<br/>
        /// Default Value: message
        /// </summary>
        /// <default>global::tryAGI.OpenAI.MessageType.Message</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.MessageTypeJsonConverter))]
        public global::tryAGI.OpenAI.MessageType Type { get; set; } = global::tryAGI.OpenAI.MessageType.Message;

        /// <summary>
        /// The unique ID of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The status of item. One of `in_progress`, `completed`, or `incomplete`. Populated when items are returned via API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.MessageStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.MessageStatus Status { get; set; }

        /// <summary>
        /// The role of the message. One of `unknown`, `user`, `assistant`, `system`, `critic`, `discriminator`, `developer`, or `tool`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.MessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.MessageRole Role { get; set; }

        /// <summary>
        /// The content of the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem3> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the message. Always set to `message`.<br/>
        /// Default Value: message
        /// </param>
        /// <param name="id">
        /// The unique ID of the message.
        /// </param>
        /// <param name="status">
        /// The status of item. One of `in_progress`, `completed`, or `incomplete`. Populated when items are returned via API.
        /// </param>
        /// <param name="role">
        /// The role of the message. One of `unknown`, `user`, `assistant`, `system`, `critic`, `discriminator`, `developer`, or `tool`.
        /// </param>
        /// <param name="content">
        /// The content of the message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Message(
            string id,
            global::tryAGI.OpenAI.MessageStatus status,
            global::tryAGI.OpenAI.MessageRole role,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem3> content,
            global::tryAGI.OpenAI.MessageType type = global::tryAGI.OpenAI.MessageType.Message)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        public Message()
        {
        }
    }
}
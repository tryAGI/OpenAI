
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An output message from the model.
    /// </summary>
    public sealed partial class OutputMessage
    {
        /// <summary>
        /// The content of the output message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputMessageContent> Content { get; set; }

        /// <summary>
        /// The unique ID of the output message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The role of the output message. Always `assistant`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OutputMessageRoleJsonConverter))]
        public global::tryAGI.OpenAI.OutputMessageRole Role { get; set; }

        /// <summary>
        /// The status of the message input. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when input items are returned via API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OutputMessageStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OutputMessageStatus Status { get; set; }

        /// <summary>
        /// The type of the output message. Always `message`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OutputMessageTypeJsonConverter))]
        public global::tryAGI.OpenAI.OutputMessageType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The content of the output message.
        /// </param>
        /// <param name="id">
        /// The unique ID of the output message.
        /// </param>
        /// <param name="role">
        /// The role of the output message. Always `assistant`.
        /// </param>
        /// <param name="status">
        /// The status of the message input. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when input items are returned via API.
        /// </param>
        /// <param name="type">
        /// The type of the output message. Always `message`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputMessage(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputMessageContent> content,
            string id,
            global::tryAGI.OpenAI.OutputMessageStatus status,
            global::tryAGI.OpenAI.OutputMessageRole role,
            global::tryAGI.OpenAI.OutputMessageType type)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Role = role;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputMessage" /> class.
        /// </summary>
        public OutputMessage()
        {
        }
    }
}
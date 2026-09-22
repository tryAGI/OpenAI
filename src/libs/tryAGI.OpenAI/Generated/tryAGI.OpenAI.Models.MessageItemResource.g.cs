
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A user or assistant message recorded in a session.
    /// </summary>
    public sealed partial class MessageItemResource
    {
        /// <summary>
        /// The item type. Always `message`.<br/>
        /// Default Value: message
        /// </summary>
        /// <default>global::tryAGI.OpenAI.MessageItemResourceType.Message</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.MessageItemResourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.MessageItemResourceType Type { get; set; } = global::tryAGI.OpenAI.MessageItemResourceType.Message;

        /// <summary>
        /// The ID of this item, or null for legacy user messages whose ID was not recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The ID of the turn that contains this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TurnId { get; set; }

        /// <summary>
        /// The role of the message author.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionMessageRoleResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.SessionMessageRoleResource Role { get; set; }

        /// <summary>
        /// The content of the message. User messages contain input text or images; assistant messages contain output text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MessageContentResource> Content { get; set; }

        /// <summary>
        /// The status of the message. User messages are always `completed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OutputItemStatusResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OutputItemStatusResource Status { get; set; }

        /// <summary>
        /// The phase of an assistant message. Null for user messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phase")]
        public global::tryAGI.OpenAI.MessagePhaseResource? Phase { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageItemResource" /> class.
        /// </summary>
        /// <param name="turnId">
        /// The ID of the turn that contains this item.
        /// </param>
        /// <param name="role">
        /// The role of the message author.
        /// </param>
        /// <param name="content">
        /// The content of the message. User messages contain input text or images; assistant messages contain output text.
        /// </param>
        /// <param name="status">
        /// The status of the message. User messages are always `completed`.
        /// </param>
        /// <param name="id">
        /// The ID of this item, or null for legacy user messages whose ID was not recorded.
        /// </param>
        /// <param name="phase">
        /// The phase of an assistant message. Null for user messages.
        /// </param>
        /// <param name="type">
        /// The item type. Always `message`.<br/>
        /// Default Value: message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageItemResource(
            string turnId,
            global::tryAGI.OpenAI.SessionMessageRoleResource role,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MessageContentResource> content,
            global::tryAGI.OpenAI.OutputItemStatusResource status,
            string? id,
            global::tryAGI.OpenAI.MessagePhaseResource? phase,
            global::tryAGI.OpenAI.MessageItemResourceType type = global::tryAGI.OpenAI.MessageItemResourceType.Message)
        {
            this.Type = type;
            this.Id = id;
            this.TurnId = turnId ?? throw new global::System.ArgumentNullException(nameof(turnId));
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Status = status;
            this.Phase = phase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageItemResource" /> class.
        /// </summary>
        public MessageItemResource()
        {
        }

    }
}
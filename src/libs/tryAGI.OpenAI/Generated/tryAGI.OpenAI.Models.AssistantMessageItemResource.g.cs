
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An assistant message produced by the agent.
    /// </summary>
    public sealed partial class AssistantMessageItemResource
    {
        /// <summary>
        /// The item type. Always `message`.<br/>
        /// Default Value: message
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AssistantMessageItemResourceType.Message</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AssistantMessageItemResourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.AssistantMessageItemResourceType Type { get; set; } = global::tryAGI.OpenAI.AssistantMessageItemResourceType.Message;

        /// <summary>
        /// The ID of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The ID of the turn that contains this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TurnId { get; set; }

        /// <summary>
        /// The role of the message author. Always `assistant`.<br/>
        /// Default Value: assistant
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AssistantMessageItemResourceRole.Assistant</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AssistantMessageItemResourceRoleJsonConverter))]
        public global::tryAGI.OpenAI.AssistantMessageItemResourceRole Role { get; set; } = global::tryAGI.OpenAI.AssistantMessageItemResourceRole.Assistant;

        /// <summary>
        /// The status of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OutputItemStatusResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OutputItemStatusResource Status { get; set; }

        /// <summary>
        /// The content of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputTextResource> Content { get; set; }

        /// <summary>
        /// The phase of the assistant message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phase")]
        public global::tryAGI.OpenAI.MessagePhaseResource? Phase { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageItemResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the message.
        /// </param>
        /// <param name="turnId">
        /// The ID of the turn that contains this item.
        /// </param>
        /// <param name="status">
        /// The status of the message.
        /// </param>
        /// <param name="content">
        /// The content of the message.
        /// </param>
        /// <param name="phase">
        /// The phase of the assistant message.
        /// </param>
        /// <param name="type">
        /// The item type. Always `message`.<br/>
        /// Default Value: message
        /// </param>
        /// <param name="role">
        /// The role of the message author. Always `assistant`.<br/>
        /// Default Value: assistant
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantMessageItemResource(
            string id,
            string turnId,
            global::tryAGI.OpenAI.OutputItemStatusResource status,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputTextResource> content,
            global::tryAGI.OpenAI.MessagePhaseResource? phase,
            global::tryAGI.OpenAI.AssistantMessageItemResourceType type = global::tryAGI.OpenAI.AssistantMessageItemResourceType.Message,
            global::tryAGI.OpenAI.AssistantMessageItemResourceRole role = global::tryAGI.OpenAI.AssistantMessageItemResourceRole.Assistant)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TurnId = turnId ?? throw new global::System.ArgumentNullException(nameof(turnId));
            this.Role = role;
            this.Status = status;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Phase = phase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageItemResource" /> class.
        /// </summary>
        public AssistantMessageItemResource()
        {
        }

    }
}
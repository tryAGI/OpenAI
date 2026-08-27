
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A message to or from the model.
    /// </summary>
    public sealed partial class BetaMessage
    {
        /// <summary>
        /// The agent that produced this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTag? Agent { get; set; }

        /// <summary>
        /// The type of the message. Always set to `message`.<br/>
        /// Default Value: message
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaMessageType.Message</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaMessageTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaMessageType Type { get; set; } = global::tryAGI.OpenAI.BetaMessageType.Message;

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaMessageStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaMessageStatus Status { get; set; }

        /// <summary>
        /// The role of the message. One of `unknown`, `user`, `assistant`, `system`, `critic`, `discriminator`, `developer`, or `tool`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaMessageRole Role { get; set; }

        /// <summary>
        /// The content of the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem7> Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phase")]
        public global::tryAGI.OpenAI.BetaMessagePhase22? Phase { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessage" /> class.
        /// </summary>
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
        /// <param name="agent">
        /// The agent that produced this item.
        /// </param>
        /// <param name="phase"></param>
        /// <param name="type">
        /// The type of the message. Always set to `message`.<br/>
        /// Default Value: message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMessage(
            string id,
            global::tryAGI.OpenAI.BetaMessageStatus status,
            global::tryAGI.OpenAI.BetaMessageRole role,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem7> content,
            global::tryAGI.OpenAI.BetaAgentTag? agent,
            global::tryAGI.OpenAI.BetaMessagePhase22? phase,
            global::tryAGI.OpenAI.BetaMessageType type = global::tryAGI.OpenAI.BetaMessageType.Message)
        {
            this.Agent = agent;
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Phase = phase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessage" /> class.
        /// </summary>
        public BetaMessage()
        {
        }

    }
}
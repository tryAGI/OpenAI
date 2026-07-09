
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A message input to the model with a role indicating instruction following<br/>
    /// hierarchy. Instructions given with the `developer` or `system` role take<br/>
    /// precedence over instructions given with the `user` role.
    /// </summary>
    public sealed partial class BetaInputMessage
    {
        /// <summary>
        /// The agent that produced this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTag? Agent { get; set; }

        /// <summary>
        /// The type of the message input. Always set to `message`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaInputMessageTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaInputMessageType? Type { get; set; }

        /// <summary>
        /// The role of the message input. One of `user`, `system`, or `developer`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaInputMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaInputMessageRole Role { get; set; }

        /// <summary>
        /// The status of item. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when items are returned via API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaInputMessageStatusJsonConverter))]
        public global::tryAGI.OpenAI.BetaInputMessageStatus? Status { get; set; }

        /// <summary>
        /// A list of one or many input items to the model, containing different content <br/>
        /// types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputContent> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInputMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the message input. One of `user`, `system`, or `developer`.
        /// </param>
        /// <param name="content">
        /// A list of one or many input items to the model, containing different content <br/>
        /// types.
        /// </param>
        /// <param name="agent">
        /// The agent that produced this item.
        /// </param>
        /// <param name="type">
        /// The type of the message input. Always set to `message`.
        /// </param>
        /// <param name="status">
        /// The status of item. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when items are returned via API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaInputMessage(
            global::tryAGI.OpenAI.BetaInputMessageRole role,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputContent> content,
            global::tryAGI.OpenAI.BetaAgentTag? agent,
            global::tryAGI.OpenAI.BetaInputMessageType? type,
            global::tryAGI.OpenAI.BetaInputMessageStatus? status)
        {
            this.Agent = agent;
            this.Type = type;
            this.Role = role;
            this.Status = status;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInputMessage" /> class.
        /// </summary>
        public BetaInputMessage()
        {
        }

    }
}
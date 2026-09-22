
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A message exchanged between agent threads.
    /// </summary>
    public sealed partial class AgentMessageItemResource
    {
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
        /// The item type. Always `agent_message`.<br/>
        /// Default Value: agent_message
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AgentMessageItemResourceType.AgentMessage</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AgentMessageItemResourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.AgentMessageItemResourceType Type { get; set; } = global::tryAGI.OpenAI.AgentMessageItemResourceType.AgentMessage;

        /// <summary>
        /// The ID or name of the sending agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender_agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SenderAgentId { get; set; }

        /// <summary>
        /// The ID or name of the receiving agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipient_agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RecipientAgentId { get; set; }

        /// <summary>
        /// The content exchanged between the agents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentContentResource> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMessageItemResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the message.
        /// </param>
        /// <param name="turnId">
        /// The ID of the turn that contains this item.
        /// </param>
        /// <param name="senderAgentId">
        /// The ID or name of the sending agent.
        /// </param>
        /// <param name="recipientAgentId">
        /// The ID or name of the receiving agent.
        /// </param>
        /// <param name="content">
        /// The content exchanged between the agents.
        /// </param>
        /// <param name="type">
        /// The item type. Always `agent_message`.<br/>
        /// Default Value: agent_message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentMessageItemResource(
            string id,
            string turnId,
            string senderAgentId,
            string recipientAgentId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentContentResource> content,
            global::tryAGI.OpenAI.AgentMessageItemResourceType type = global::tryAGI.OpenAI.AgentMessageItemResourceType.AgentMessage)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TurnId = turnId ?? throw new global::System.ArgumentNullException(nameof(turnId));
            this.Type = type;
            this.SenderAgentId = senderAgentId ?? throw new global::System.ArgumentNullException(nameof(senderAgentId));
            this.RecipientAgentId = recipientAgentId ?? throw new global::System.ArgumentNullException(nameof(recipientAgentId));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMessageItemResource" /> class.
        /// </summary>
        public AgentMessageItemResource()
        {
        }

    }
}
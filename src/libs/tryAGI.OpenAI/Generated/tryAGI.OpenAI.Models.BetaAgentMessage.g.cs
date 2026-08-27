
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaAgentMessage
    {
        /// <summary>
        /// The agent that produced this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTag? Agent { get; set; }

        /// <summary>
        /// The type of the item. Always `agent_message`.<br/>
        /// Default Value: agent_message
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaAgentMessageType.AgentMessage</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaAgentMessageTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaAgentMessageType Type { get; set; } = global::tryAGI.OpenAI.BetaAgentMessageType.AgentMessage;

        /// <summary>
        /// The unique ID of the agent message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The sending agent identity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Author { get; set; }

        /// <summary>
        /// The destination agent identity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipient")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Recipient { get; set; }

        /// <summary>
        /// Encrypted content sent between agents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem6> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAgentMessage" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the agent message.
        /// </param>
        /// <param name="author">
        /// The sending agent identity.
        /// </param>
        /// <param name="recipient">
        /// The destination agent identity.
        /// </param>
        /// <param name="content">
        /// Encrypted content sent between agents.
        /// </param>
        /// <param name="agent">
        /// The agent that produced this item.
        /// </param>
        /// <param name="type">
        /// The type of the item. Always `agent_message`.<br/>
        /// Default Value: agent_message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAgentMessage(
            string id,
            string author,
            string recipient,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem6> content,
            global::tryAGI.OpenAI.BetaAgentTag? agent,
            global::tryAGI.OpenAI.BetaAgentMessageType type = global::tryAGI.OpenAI.BetaAgentMessageType.AgentMessage)
        {
            this.Agent = agent;
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.Recipient = recipient ?? throw new global::System.ArgumentNullException(nameof(recipient));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAgentMessage" /> class.
        /// </summary>
        public BetaAgentMessage()
        {
        }

    }
}
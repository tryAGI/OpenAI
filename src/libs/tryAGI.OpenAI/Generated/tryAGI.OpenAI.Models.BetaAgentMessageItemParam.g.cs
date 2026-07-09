
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A message routed between agents.
    /// </summary>
    public sealed partial class BetaAgentMessageItemParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTagParam? Agent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The item type. Always `agent_message`.<br/>
        /// Default Value: agent_message
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaAgentMessageItemParamType.AgentMessage</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaAgentMessageItemParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaAgentMessageItemParamType Type { get; set; } = global::tryAGI.OpenAI.BetaAgentMessageItemParamType.AgentMessage;

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
        /// Plaintext, image, or encrypted content sent between agents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem5> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAgentMessageItemParam" /> class.
        /// </summary>
        /// <param name="author">
        /// The sending agent identity.
        /// </param>
        /// <param name="recipient">
        /// The destination agent identity.
        /// </param>
        /// <param name="content">
        /// Plaintext, image, or encrypted content sent between agents.
        /// </param>
        /// <param name="agent"></param>
        /// <param name="id"></param>
        /// <param name="type">
        /// The item type. Always `agent_message`.<br/>
        /// Default Value: agent_message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAgentMessageItemParam(
            string author,
            string recipient,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem5> content,
            global::tryAGI.OpenAI.BetaAgentTagParam? agent,
            string? id,
            global::tryAGI.OpenAI.BetaAgentMessageItemParamType type = global::tryAGI.OpenAI.BetaAgentMessageItemParamType.AgentMessage)
        {
            this.Agent = agent;
            this.Id = id;
            this.Type = type;
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.Recipient = recipient ?? throw new global::System.ArgumentNullException(nameof(recipient));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAgentMessageItemParam" /> class.
        /// </summary>
        public BetaAgentMessageItemParam()
        {
        }

    }
}
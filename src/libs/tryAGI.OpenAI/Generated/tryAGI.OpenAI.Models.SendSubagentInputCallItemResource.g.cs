
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A request to send input to another agent.
    /// </summary>
    public sealed partial class SendSubagentInputCallItemResource
    {
        /// <summary>
        /// The item type. Always `send_subagent_input_call`.<br/>
        /// Default Value: send_subagent_input_call
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SendSubagentInputCallItemResourceType.SendSubagentInputCall</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SendSubagentInputCallItemResourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.SendSubagentInputCallItemResourceType Type { get; set; } = global::tryAGI.OpenAI.SendSubagentInputCallItemResourceType.SendSubagentInputCall;

        /// <summary>
        /// The ID of the tool call item.
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
        /// The status of the tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FunctionCallStatusResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.FunctionCallStatusResource Status { get; set; }

        /// <summary>
        /// The ID of the agent sending the input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender_agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SenderAgentId { get; set; }

        /// <summary>
        /// The ID of the agent receiving the input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipient_agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RecipientAgentId { get; set; }

        /// <summary>
        /// The input sent to the receiving agent.
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
        /// Initializes a new instance of the <see cref="SendSubagentInputCallItemResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the tool call item.
        /// </param>
        /// <param name="turnId">
        /// The ID of the turn that contains this item.
        /// </param>
        /// <param name="status">
        /// The status of the tool call.
        /// </param>
        /// <param name="senderAgentId">
        /// The ID of the agent sending the input.
        /// </param>
        /// <param name="recipientAgentId">
        /// The ID of the agent receiving the input.
        /// </param>
        /// <param name="content">
        /// The input sent to the receiving agent.
        /// </param>
        /// <param name="type">
        /// The item type. Always `send_subagent_input_call`.<br/>
        /// Default Value: send_subagent_input_call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SendSubagentInputCallItemResource(
            string id,
            string turnId,
            global::tryAGI.OpenAI.FunctionCallStatusResource status,
            string senderAgentId,
            string recipientAgentId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentContentResource> content,
            global::tryAGI.OpenAI.SendSubagentInputCallItemResourceType type = global::tryAGI.OpenAI.SendSubagentInputCallItemResourceType.SendSubagentInputCall)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TurnId = turnId ?? throw new global::System.ArgumentNullException(nameof(turnId));
            this.Status = status;
            this.SenderAgentId = senderAgentId ?? throw new global::System.ArgumentNullException(nameof(senderAgentId));
            this.RecipientAgentId = recipientAgentId ?? throw new global::System.ArgumentNullException(nameof(recipientAgentId));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendSubagentInputCallItemResource" /> class.
        /// </summary>
        public SendSubagentInputCallItemResource()
        {
        }

    }
}
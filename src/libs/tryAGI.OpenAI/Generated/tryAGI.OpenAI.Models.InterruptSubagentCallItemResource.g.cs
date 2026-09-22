
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A request to interrupt a subagent's current turn. The subagent remains available.
    /// </summary>
    public sealed partial class InterruptSubagentCallItemResource
    {
        /// <summary>
        /// The item type. Always `interrupt_subagent_call`.<br/>
        /// Default Value: interrupt_subagent_call
        /// </summary>
        /// <default>global::tryAGI.OpenAI.InterruptSubagentCallItemResourceType.InterruptSubagentCall</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InterruptSubagentCallItemResourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.InterruptSubagentCallItemResourceType Type { get; set; } = global::tryAGI.OpenAI.InterruptSubagentCallItemResourceType.InterruptSubagentCall;

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
        /// The ID of the agent requesting the interrupt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender_agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SenderAgentId { get; set; }

        /// <summary>
        /// The ID of the agent to interrupt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipient_agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RecipientAgentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InterruptSubagentCallItemResource" /> class.
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
        /// The ID of the agent requesting the interrupt.
        /// </param>
        /// <param name="recipientAgentId">
        /// The ID of the agent to interrupt.
        /// </param>
        /// <param name="type">
        /// The item type. Always `interrupt_subagent_call`.<br/>
        /// Default Value: interrupt_subagent_call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InterruptSubagentCallItemResource(
            string id,
            string turnId,
            global::tryAGI.OpenAI.FunctionCallStatusResource status,
            string senderAgentId,
            string recipientAgentId,
            global::tryAGI.OpenAI.InterruptSubagentCallItemResourceType type = global::tryAGI.OpenAI.InterruptSubagentCallItemResourceType.InterruptSubagentCall)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TurnId = turnId ?? throw new global::System.ArgumentNullException(nameof(turnId));
            this.Status = status;
            this.SenderAgentId = senderAgentId ?? throw new global::System.ArgumentNullException(nameof(senderAgentId));
            this.RecipientAgentId = recipientAgentId ?? throw new global::System.ArgumentNullException(nameof(recipientAgentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InterruptSubagentCallItemResource" /> class.
        /// </summary>
        public InterruptSubagentCallItemResource()
        {
        }

    }
}
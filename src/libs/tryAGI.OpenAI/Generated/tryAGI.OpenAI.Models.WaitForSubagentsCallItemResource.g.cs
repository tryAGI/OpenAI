
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A request to wait for one or more subagents.
    /// </summary>
    public sealed partial class WaitForSubagentsCallItemResource
    {
        /// <summary>
        /// The item type. Always `wait_for_subagents_call`.<br/>
        /// Default Value: wait_for_subagents_call
        /// </summary>
        /// <default>global::tryAGI.OpenAI.WaitForSubagentsCallItemResourceType.WaitForSubagentsCall</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WaitForSubagentsCallItemResourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.WaitForSubagentsCallItemResourceType Type { get; set; } = global::tryAGI.OpenAI.WaitForSubagentsCallItemResourceType.WaitForSubagentsCall;

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
        /// The ID of the agent waiting for results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender_agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SenderAgentId { get; set; }

        /// <summary>
        /// The IDs of the agents to wait for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipient_agent_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RecipientAgentIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WaitForSubagentsCallItemResource" /> class.
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
        /// The ID of the agent waiting for results.
        /// </param>
        /// <param name="recipientAgentIds">
        /// The IDs of the agents to wait for.
        /// </param>
        /// <param name="type">
        /// The item type. Always `wait_for_subagents_call`.<br/>
        /// Default Value: wait_for_subagents_call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WaitForSubagentsCallItemResource(
            string id,
            string turnId,
            global::tryAGI.OpenAI.FunctionCallStatusResource status,
            string senderAgentId,
            global::System.Collections.Generic.IList<string> recipientAgentIds,
            global::tryAGI.OpenAI.WaitForSubagentsCallItemResourceType type = global::tryAGI.OpenAI.WaitForSubagentsCallItemResourceType.WaitForSubagentsCall)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TurnId = turnId ?? throw new global::System.ArgumentNullException(nameof(turnId));
            this.Status = status;
            this.SenderAgentId = senderAgentId ?? throw new global::System.ArgumentNullException(nameof(senderAgentId));
            this.RecipientAgentIds = recipientAgentIds ?? throw new global::System.ArgumentNullException(nameof(recipientAgentIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WaitForSubagentsCallItemResource" /> class.
        /// </summary>
        public WaitForSubagentsCallItemResource()
        {
        }

    }
}
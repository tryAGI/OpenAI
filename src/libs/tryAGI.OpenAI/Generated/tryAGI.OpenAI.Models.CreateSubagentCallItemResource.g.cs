
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A request to spawn a subagent.
    /// </summary>
    public sealed partial class CreateSubagentCallItemResource
    {
        /// <summary>
        /// The item type. Always `create_subagent_call`.<br/>
        /// Default Value: create_subagent_call
        /// </summary>
        /// <default>global::tryAGI.OpenAI.CreateSubagentCallItemResourceType.CreateSubagentCall</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateSubagentCallItemResourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.CreateSubagentCallItemResourceType Type { get; set; } = global::tryAGI.OpenAI.CreateSubagentCallItemResourceType.CreateSubagentCall;

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
        /// The ID of the agent that requested the subagent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The task given to the spawned agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentContentResource> Content { get; set; }

        /// <summary>
        /// The model requested for the spawned agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The reasoning effort requested for the spawned agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        public string? ReasoningEffort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubagentCallItemResource" /> class.
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
        /// <param name="agentId">
        /// The ID of the agent that requested the subagent.
        /// </param>
        /// <param name="content">
        /// The task given to the spawned agent.
        /// </param>
        /// <param name="model">
        /// The model requested for the spawned agent.
        /// </param>
        /// <param name="reasoningEffort">
        /// The reasoning effort requested for the spawned agent.
        /// </param>
        /// <param name="type">
        /// The item type. Always `create_subagent_call`.<br/>
        /// Default Value: create_subagent_call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSubagentCallItemResource(
            string id,
            string turnId,
            global::tryAGI.OpenAI.FunctionCallStatusResource status,
            string agentId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentContentResource> content,
            string? model,
            string? reasoningEffort,
            global::tryAGI.OpenAI.CreateSubagentCallItemResourceType type = global::tryAGI.OpenAI.CreateSubagentCallItemResourceType.CreateSubagentCall)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TurnId = turnId ?? throw new global::System.ArgumentNullException(nameof(turnId));
            this.Status = status;
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Model = model;
            this.ReasoningEffort = reasoningEffort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubagentCallItemResource" /> class.
        /// </summary>
        public CreateSubagentCallItemResource()
        {
        }

    }
}
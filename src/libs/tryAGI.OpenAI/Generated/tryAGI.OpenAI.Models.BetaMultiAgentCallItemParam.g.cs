
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaMultiAgentCallItemParam
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
        /// The unique ID linking this call to its output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// The item type. Always `multi_agent_call`.<br/>
        /// Default Value: multi_agent_call
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaMultiAgentCallItemParamType.MultiAgentCall</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentCallItemParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaMultiAgentCallItemParamType Type { get; set; } = global::tryAGI.OpenAI.BetaMultiAgentCallItemParamType.MultiAgentCall;

        /// <summary>
        /// The multi-agent action that was executed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentAction1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaMultiAgentAction1 Action { get; set; }

        /// <summary>
        /// The action arguments as a JSON string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMultiAgentCallItemParam" /> class.
        /// </summary>
        /// <param name="callId">
        /// The unique ID linking this call to its output.
        /// </param>
        /// <param name="action">
        /// The multi-agent action that was executed.
        /// </param>
        /// <param name="arguments">
        /// The action arguments as a JSON string.
        /// </param>
        /// <param name="agent"></param>
        /// <param name="id"></param>
        /// <param name="type">
        /// The item type. Always `multi_agent_call`.<br/>
        /// Default Value: multi_agent_call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMultiAgentCallItemParam(
            string callId,
            global::tryAGI.OpenAI.BetaMultiAgentAction1 action,
            string arguments,
            global::tryAGI.OpenAI.BetaAgentTagParam? agent,
            string? id,
            global::tryAGI.OpenAI.BetaMultiAgentCallItemParamType type = global::tryAGI.OpenAI.BetaMultiAgentCallItemParamType.MultiAgentCall)
        {
            this.Agent = agent;
            this.Id = id;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Type = type;
            this.Action = action;
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMultiAgentCallItemParam" /> class.
        /// </summary>
        public BetaMultiAgentCallItemParam()
        {
        }

    }
}

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaMultiAgentCall
    {
        /// <summary>
        /// The agent that produced this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTag? Agent { get; set; }

        /// <summary>
        /// The type of the multi-agent call. Always `multi_agent_call`.<br/>
        /// Default Value: multi_agent_call
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaMultiAgentCallType.MultiAgentCall</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentCallTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaMultiAgentCallType Type { get; set; } = global::tryAGI.OpenAI.BetaMultiAgentCallType.MultiAgentCall;

        /// <summary>
        /// The unique ID of the multi-agent call item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The unique ID linking this call to its output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// The multi-agent action to execute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaMultiAgentAction Action { get; set; }

        /// <summary>
        /// The JSON string of arguments generated for the action.
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
        /// Initializes a new instance of the <see cref="BetaMultiAgentCall" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the multi-agent call item.
        /// </param>
        /// <param name="callId">
        /// The unique ID linking this call to its output.
        /// </param>
        /// <param name="action">
        /// The multi-agent action to execute.
        /// </param>
        /// <param name="arguments">
        /// The JSON string of arguments generated for the action.
        /// </param>
        /// <param name="agent">
        /// The agent that produced this item.
        /// </param>
        /// <param name="type">
        /// The type of the multi-agent call. Always `multi_agent_call`.<br/>
        /// Default Value: multi_agent_call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMultiAgentCall(
            string id,
            string callId,
            global::tryAGI.OpenAI.BetaMultiAgentAction action,
            string arguments,
            global::tryAGI.OpenAI.BetaAgentTag? agent,
            global::tryAGI.OpenAI.BetaMultiAgentCallType type = global::tryAGI.OpenAI.BetaMultiAgentCallType.MultiAgentCall)
        {
            this.Agent = agent;
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Action = action;
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMultiAgentCall" /> class.
        /// </summary>
        public BetaMultiAgentCall()
        {
        }

    }
}
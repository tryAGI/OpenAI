
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaMultiAgentCallOutputItemParam
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
        /// The unique ID of the multi-agent call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// The item type. Always `multi_agent_call_output`.<br/>
        /// Default Value: multi_agent_call_output
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParamType.MultiAgentCallOutput</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentCallOutputItemParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParamType Type { get; set; } = global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParamType.MultiAgentCallOutput;

        /// <summary>
        /// The multi-agent action that produced this result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentAction1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaMultiAgentAction1 Action { get; set; }

        /// <summary>
        /// Text output returned by the multi-agent action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputTextContentParam> Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMultiAgentCallOutputItemParam" /> class.
        /// </summary>
        /// <param name="callId">
        /// The unique ID of the multi-agent call.
        /// </param>
        /// <param name="action">
        /// The multi-agent action that produced this result.
        /// </param>
        /// <param name="output">
        /// Text output returned by the multi-agent action.
        /// </param>
        /// <param name="agent"></param>
        /// <param name="id"></param>
        /// <param name="type">
        /// The item type. Always `multi_agent_call_output`.<br/>
        /// Default Value: multi_agent_call_output
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMultiAgentCallOutputItemParam(
            string callId,
            global::tryAGI.OpenAI.BetaMultiAgentAction1 action,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputTextContentParam> output,
            global::tryAGI.OpenAI.BetaAgentTagParam? agent,
            string? id,
            global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParamType type = global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParamType.MultiAgentCallOutput)
        {
            this.Agent = agent;
            this.Id = id;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Type = type;
            this.Action = action;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMultiAgentCallOutputItemParam" /> class.
        /// </summary>
        public BetaMultiAgentCallOutputItemParam()
        {
        }

    }
}
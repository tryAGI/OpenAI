
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaMultiAgentCallOutput
    {
        /// <summary>
        /// The agent that produced this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTag? Agent { get; set; }

        /// <summary>
        /// The type of the multi-agent result. Always `multi_agent_call_output`.<br/>
        /// Default Value: multi_agent_call_output
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaMultiAgentCallOutputType.MultiAgentCallOutput</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentCallOutputTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaMultiAgentCallOutputType Type { get; set; } = global::tryAGI.OpenAI.BetaMultiAgentCallOutputType.MultiAgentCallOutput;

        /// <summary>
        /// The unique ID of the multi-agent call output item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The unique ID of the multi-agent call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// The multi-agent action that produced this result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaMultiAgentAction Action { get; set; }

        /// <summary>
        /// Text output returned by the multi-agent action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputTextContent> Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMultiAgentCallOutput" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the multi-agent call output item.
        /// </param>
        /// <param name="callId">
        /// The unique ID of the multi-agent call.
        /// </param>
        /// <param name="action">
        /// The multi-agent action that produced this result.
        /// </param>
        /// <param name="output">
        /// Text output returned by the multi-agent action.
        /// </param>
        /// <param name="agent">
        /// The agent that produced this item.
        /// </param>
        /// <param name="type">
        /// The type of the multi-agent result. Always `multi_agent_call_output`.<br/>
        /// Default Value: multi_agent_call_output
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMultiAgentCallOutput(
            string id,
            string callId,
            global::tryAGI.OpenAI.BetaMultiAgentAction action,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputTextContent> output,
            global::tryAGI.OpenAI.BetaAgentTag? agent,
            global::tryAGI.OpenAI.BetaMultiAgentCallOutputType type = global::tryAGI.OpenAI.BetaMultiAgentCallOutputType.MultiAgentCallOutput)
        {
            this.Agent = agent;
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Action = action;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMultiAgentCallOutput" /> class.
        /// </summary>
        public BetaMultiAgentCallOutput()
        {
        }

    }
}
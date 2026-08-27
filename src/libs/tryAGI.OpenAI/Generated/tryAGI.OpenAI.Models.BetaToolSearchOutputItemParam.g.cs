
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaToolSearchOutputItemParam
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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        public string? CallId { get; set; }

        /// <summary>
        /// The item type. Always `tool_search_output`.<br/>
        /// Default Value: tool_search_output
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaToolSearchOutputItemParamType.ToolSearchOutput</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaToolSearchOutputItemParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaToolSearchOutputItemParamType Type { get; set; } = global::tryAGI.OpenAI.BetaToolSearchOutputItemParamType.ToolSearchOutput;

        /// <summary>
        /// Whether tool search was executed by the server or by the client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaToolSearchExecutionTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaToolSearchExecutionType? Execution { get; set; }

        /// <summary>
        /// The loaded tool definitions returned by the tool search output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaTool> Tools { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::tryAGI.OpenAI.BetaFunctionCallItemStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaToolSearchOutputItemParam" /> class.
        /// </summary>
        /// <param name="tools">
        /// The loaded tool definitions returned by the tool search output.
        /// </param>
        /// <param name="agent"></param>
        /// <param name="id"></param>
        /// <param name="callId"></param>
        /// <param name="execution">
        /// Whether tool search was executed by the server or by the client.
        /// </param>
        /// <param name="status"></param>
        /// <param name="type">
        /// The item type. Always `tool_search_output`.<br/>
        /// Default Value: tool_search_output
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaToolSearchOutputItemParam(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaTool> tools,
            global::tryAGI.OpenAI.BetaAgentTagParam? agent,
            string? id,
            string? callId,
            global::tryAGI.OpenAI.BetaToolSearchExecutionType? execution,
            global::tryAGI.OpenAI.BetaFunctionCallItemStatus? status,
            global::tryAGI.OpenAI.BetaToolSearchOutputItemParamType type = global::tryAGI.OpenAI.BetaToolSearchOutputItemParamType.ToolSearchOutput)
        {
            this.Agent = agent;
            this.Id = id;
            this.CallId = callId;
            this.Type = type;
            this.Execution = execution;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaToolSearchOutputItemParam" /> class.
        /// </summary>
        public BetaToolSearchOutputItemParam()
        {
        }

    }
}
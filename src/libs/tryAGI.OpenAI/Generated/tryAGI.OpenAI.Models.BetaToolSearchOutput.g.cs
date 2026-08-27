
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaToolSearchOutput
    {
        /// <summary>
        /// The agent that produced this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTag? Agent { get; set; }

        /// <summary>
        /// The type of the item. Always `tool_search_output`.<br/>
        /// Default Value: tool_search_output
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaToolSearchOutputType.ToolSearchOutput</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaToolSearchOutputTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaToolSearchOutputType Type { get; set; } = global::tryAGI.OpenAI.BetaToolSearchOutputType.ToolSearchOutput;

        /// <summary>
        /// The unique ID of the tool search output item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        public string? CallId { get; set; }

        /// <summary>
        /// Whether tool search was executed by the server or by the client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaToolSearchExecutionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaToolSearchExecutionType Execution { get; set; }

        /// <summary>
        /// The loaded tool definitions returned by tool search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaTool> Tools { get; set; }

        /// <summary>
        /// The status of the tool search output item that was recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaFunctionCallOutputStatusEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaFunctionCallOutputStatusEnum Status { get; set; }

        /// <summary>
        /// The identifier of the actor that created the item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaToolSearchOutput" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the tool search output item.
        /// </param>
        /// <param name="execution">
        /// Whether tool search was executed by the server or by the client.
        /// </param>
        /// <param name="tools">
        /// The loaded tool definitions returned by tool search.
        /// </param>
        /// <param name="status">
        /// The status of the tool search output item that was recorded.
        /// </param>
        /// <param name="agent">
        /// The agent that produced this item.
        /// </param>
        /// <param name="callId"></param>
        /// <param name="createdBy">
        /// The identifier of the actor that created the item.
        /// </param>
        /// <param name="type">
        /// The type of the item. Always `tool_search_output`.<br/>
        /// Default Value: tool_search_output
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaToolSearchOutput(
            string id,
            global::tryAGI.OpenAI.BetaToolSearchExecutionType execution,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaTool> tools,
            global::tryAGI.OpenAI.BetaFunctionCallOutputStatusEnum status,
            global::tryAGI.OpenAI.BetaAgentTag? agent,
            string? callId,
            string? createdBy,
            global::tryAGI.OpenAI.BetaToolSearchOutputType type = global::tryAGI.OpenAI.BetaToolSearchOutputType.ToolSearchOutput)
        {
            this.Agent = agent;
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CallId = callId;
            this.Execution = execution;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Status = status;
            this.CreatedBy = createdBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaToolSearchOutput" /> class.
        /// </summary>
        public BetaToolSearchOutput()
        {
        }

    }
}
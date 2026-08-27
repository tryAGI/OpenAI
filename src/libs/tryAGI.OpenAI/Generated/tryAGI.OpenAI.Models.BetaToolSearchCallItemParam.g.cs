
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaToolSearchCallItemParam
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
        /// The item type. Always `tool_search_call`.<br/>
        /// Default Value: tool_search_call
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaToolSearchCallItemParamType.ToolSearchCall</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaToolSearchCallItemParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaToolSearchCallItemParamType Type { get; set; } = global::tryAGI.OpenAI.BetaToolSearchCallItemParamType.ToolSearchCall;

        /// <summary>
        /// Whether tool search was executed by the server or by the client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaToolSearchExecutionTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaToolSearchExecutionType? Execution { get; set; }

        /// <summary>
        /// The arguments supplied to the tool search call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaEmptyModelParam Arguments { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaToolSearchCallItemParam" /> class.
        /// </summary>
        /// <param name="arguments">
        /// The arguments supplied to the tool search call.
        /// </param>
        /// <param name="agent"></param>
        /// <param name="id"></param>
        /// <param name="callId"></param>
        /// <param name="execution">
        /// Whether tool search was executed by the server or by the client.
        /// </param>
        /// <param name="status"></param>
        /// <param name="type">
        /// The item type. Always `tool_search_call`.<br/>
        /// Default Value: tool_search_call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaToolSearchCallItemParam(
            global::tryAGI.OpenAI.BetaEmptyModelParam arguments,
            global::tryAGI.OpenAI.BetaAgentTagParam? agent,
            string? id,
            string? callId,
            global::tryAGI.OpenAI.BetaToolSearchExecutionType? execution,
            global::tryAGI.OpenAI.BetaFunctionCallItemStatus? status,
            global::tryAGI.OpenAI.BetaToolSearchCallItemParamType type = global::tryAGI.OpenAI.BetaToolSearchCallItemParamType.ToolSearchCall)
        {
            this.Agent = agent;
            this.Id = id;
            this.CallId = callId;
            this.Type = type;
            this.Execution = execution;
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaToolSearchCallItemParam" /> class.
        /// </summary>
        public BetaToolSearchCallItemParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaToolSearchCallItemParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaToolSearchCallItemParam FromArguments(global::tryAGI.OpenAI.BetaEmptyModelParam arguments)
        {
            return new BetaToolSearchCallItemParam
            {
                Arguments = arguments,
            };
        }

    }
}
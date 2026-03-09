
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolSearchCallItemParam
    {
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
        /// <default>global::tryAGI.OpenAI.ToolSearchCallItemParamType.ToolSearchCall</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ToolSearchCallItemParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.ToolSearchCallItemParamType Type { get; set; } = global::tryAGI.OpenAI.ToolSearchCallItemParamType.ToolSearchCall;

        /// <summary>
        /// Whether tool search was executed by the server or by the client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ToolSearchExecutionTypeJsonConverter))]
        public global::tryAGI.OpenAI.ToolSearchExecutionType? Execution { get; set; }

        /// <summary>
        /// The arguments supplied to the tool search call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Arguments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::tryAGI.OpenAI.FunctionCallItemStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearchCallItemParam" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="callId"></param>
        /// <param name="type">
        /// The item type. Always `tool_search_call`.<br/>
        /// Default Value: tool_search_call
        /// </param>
        /// <param name="execution">
        /// Whether tool search was executed by the server or by the client.
        /// </param>
        /// <param name="arguments">
        /// The arguments supplied to the tool search call.
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolSearchCallItemParam(
            object arguments,
            string? id,
            string? callId,
            global::tryAGI.OpenAI.ToolSearchExecutionType? execution,
            global::tryAGI.OpenAI.FunctionCallItemStatus? status,
            global::tryAGI.OpenAI.ToolSearchCallItemParamType type = global::tryAGI.OpenAI.ToolSearchCallItemParamType.ToolSearchCall)
        {
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Id = id;
            this.CallId = callId;
            this.Type = type;
            this.Execution = execution;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearchCallItemParam" /> class.
        /// </summary>
        public ToolSearchCallItemParam()
        {
        }
    }
}
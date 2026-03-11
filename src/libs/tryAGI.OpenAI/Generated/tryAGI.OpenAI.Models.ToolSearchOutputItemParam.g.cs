
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolSearchOutputItemParam
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
        /// The item type. Always `tool_search_output`.<br/>
        /// Default Value: tool_search_output
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ToolSearchOutputItemParamType.ToolSearchOutput</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ToolSearchOutputItemParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.ToolSearchOutputItemParamType Type { get; set; } = global::tryAGI.OpenAI.ToolSearchOutputItemParamType.ToolSearchOutput;

        /// <summary>
        /// Whether tool search was executed by the server or by the client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ToolSearchExecutionTypeJsonConverter))]
        public global::tryAGI.OpenAI.ToolSearchExecutionType? Execution { get; set; }

        /// <summary>
        /// The loaded tool definitions returned by the tool search output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Tool> Tools { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ToolSearchOutputItemParam" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="callId"></param>
        /// <param name="type">
        /// The item type. Always `tool_search_output`.<br/>
        /// Default Value: tool_search_output
        /// </param>
        /// <param name="execution">
        /// Whether tool search was executed by the server or by the client.
        /// </param>
        /// <param name="tools">
        /// The loaded tool definitions returned by the tool search output.
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolSearchOutputItemParam(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Tool> tools,
            string? id,
            string? callId,
            global::tryAGI.OpenAI.ToolSearchExecutionType? execution,
            global::tryAGI.OpenAI.FunctionCallItemStatus? status,
            global::tryAGI.OpenAI.ToolSearchOutputItemParamType type = global::tryAGI.OpenAI.ToolSearchOutputItemParamType.ToolSearchOutput)
        {
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Id = id;
            this.CallId = callId;
            this.Type = type;
            this.Execution = execution;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearchOutputItemParam" /> class.
        /// </summary>
        public ToolSearchOutputItemParam()
        {
        }
    }
}
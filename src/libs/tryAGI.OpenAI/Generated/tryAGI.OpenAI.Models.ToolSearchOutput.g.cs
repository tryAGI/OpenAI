
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolSearchOutput
    {
        /// <summary>
        /// The type of the item. Always `tool_search_output`.<br/>
        /// Default Value: tool_search_output
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ToolSearchOutputType.ToolSearchOutput</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ToolSearchOutputTypeJsonConverter))]
        public global::tryAGI.OpenAI.ToolSearchOutputType Type { get; set; } = global::tryAGI.OpenAI.ToolSearchOutputType.ToolSearchOutput;

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ToolSearchExecutionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ToolSearchExecutionType Execution { get; set; }

        /// <summary>
        /// The loaded tool definitions returned by tool search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Tool> Tools { get; set; }

        /// <summary>
        /// The status of the tool search output item that was recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FunctionCallOutputStatusEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.FunctionCallOutputStatusEnum Status { get; set; }

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
        /// Initializes a new instance of the <see cref="ToolSearchOutput" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the item. Always `tool_search_output`.<br/>
        /// Default Value: tool_search_output
        /// </param>
        /// <param name="id">
        /// The unique ID of the tool search output item.
        /// </param>
        /// <param name="callId"></param>
        /// <param name="execution">
        /// Whether tool search was executed by the server or by the client.
        /// </param>
        /// <param name="tools">
        /// The loaded tool definitions returned by tool search.
        /// </param>
        /// <param name="status">
        /// The status of the tool search output item that was recorded.
        /// </param>
        /// <param name="createdBy">
        /// The identifier of the actor that created the item.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolSearchOutput(
            string id,
            global::tryAGI.OpenAI.ToolSearchExecutionType execution,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Tool> tools,
            global::tryAGI.OpenAI.FunctionCallOutputStatusEnum status,
            string? callId,
            string? createdBy,
            global::tryAGI.OpenAI.ToolSearchOutputType type = global::tryAGI.OpenAI.ToolSearchOutputType.ToolSearchOutput)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Execution = execution;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Status = status;
            this.Type = type;
            this.CallId = callId;
            this.CreatedBy = createdBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearchOutput" /> class.
        /// </summary>
        public ToolSearchOutput()
        {
        }
    }
}
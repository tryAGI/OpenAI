
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Hosted or BYOT tool search configuration for deferred tools.
    /// </summary>
    public sealed partial class ToolSearchToolParam
    {
        /// <summary>
        /// The type of the tool. Always `tool_search`.<br/>
        /// Default Value: tool_search
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ToolSearchToolParamType.ToolSearch</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ToolSearchToolParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.ToolSearchToolParamType Type { get; set; } = global::tryAGI.OpenAI.ToolSearchToolParamType.ToolSearch;

        /// <summary>
        /// Whether tool search is executed by the server or by the client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ToolSearchExecutionTypeJsonConverter))]
        public global::tryAGI.OpenAI.ToolSearchExecutionType? Execution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearchToolParam" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the tool. Always `tool_search`.<br/>
        /// Default Value: tool_search
        /// </param>
        /// <param name="execution">
        /// Whether tool search is executed by the server or by the client.
        /// </param>
        /// <param name="description"></param>
        /// <param name="parameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolSearchToolParam(
            global::tryAGI.OpenAI.ToolSearchExecutionType? execution,
            string? description,
            object? parameters,
            global::tryAGI.OpenAI.ToolSearchToolParamType type = global::tryAGI.OpenAI.ToolSearchToolParamType.ToolSearch)
        {
            this.Type = type;
            this.Execution = execution;
            this.Description = description;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearchToolParam" /> class.
        /// </summary>
        public ToolSearchToolParam()
        {
        }
    }
}
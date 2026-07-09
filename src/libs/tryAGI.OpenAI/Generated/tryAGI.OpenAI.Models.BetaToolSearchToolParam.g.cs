
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Hosted or BYOT tool search configuration for deferred tools.
    /// </summary>
    public sealed partial class BetaToolSearchToolParam
    {
        /// <summary>
        /// The type of the tool. Always `tool_search`.<br/>
        /// Default Value: tool_search
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaToolSearchToolParamType.ToolSearch</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaToolSearchToolParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaToolSearchToolParamType Type { get; set; } = global::tryAGI.OpenAI.BetaToolSearchToolParamType.ToolSearch;

        /// <summary>
        /// Whether tool search is executed by the server or by the client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaToolSearchExecutionTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaToolSearchExecutionType? Execution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::tryAGI.OpenAI.BetaEmptyModelParam? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaToolSearchToolParam" /> class.
        /// </summary>
        /// <param name="execution">
        /// Whether tool search is executed by the server or by the client.
        /// </param>
        /// <param name="description"></param>
        /// <param name="parameters"></param>
        /// <param name="type">
        /// The type of the tool. Always `tool_search`.<br/>
        /// Default Value: tool_search
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaToolSearchToolParam(
            global::tryAGI.OpenAI.BetaToolSearchExecutionType? execution,
            string? description,
            global::tryAGI.OpenAI.BetaEmptyModelParam? parameters,
            global::tryAGI.OpenAI.BetaToolSearchToolParamType type = global::tryAGI.OpenAI.BetaToolSearchToolParamType.ToolSearch)
        {
            this.Type = type;
            this.Execution = execution;
            this.Description = description;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaToolSearchToolParam" /> class.
        /// </summary>
        public BetaToolSearchToolParam()
        {
        }

    }
}
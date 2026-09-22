
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MCPToolExecutionError
    {
        /// <summary>
        /// Default Value: mcp_tool_execution_error
        /// </summary>
        /// <default>global::tryAGI.OpenAI.MCPToolExecutionErrorType.McpToolExecutionError</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.MCPToolExecutionErrorTypeJsonConverter))]
        public global::tryAGI.OpenAI.MCPToolExecutionErrorType Type { get; set; } = global::tryAGI.OpenAI.MCPToolExecutionErrorType.McpToolExecutionError;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolExecutionError" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="type">
        /// Default Value: mcp_tool_execution_error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPToolExecutionError(
            object content,
            global::tryAGI.OpenAI.MCPToolExecutionErrorType type = global::tryAGI.OpenAI.MCPToolExecutionErrorType.McpToolExecutionError)
        {
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolExecutionError" /> class.
        /// </summary>
        public MCPToolExecutionError()
        {
        }

        /// <summary>
        /// Creates a new <see cref="MCPToolExecutionError"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static MCPToolExecutionError FromContent(object content)
        {
            return new MCPToolExecutionError
            {
                Content = content,
            };
        }

    }
}
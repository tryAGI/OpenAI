
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaMCPToolExecutionError
    {
        /// <summary>
        /// Default Value: mcp_tool_execution_error
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaMCPToolExecutionErrorType.McpToolExecutionError</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaMCPToolExecutionErrorTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaMCPToolExecutionErrorType Type { get; set; } = global::tryAGI.OpenAI.BetaMCPToolExecutionErrorType.McpToolExecutionError;

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
        /// Initializes a new instance of the <see cref="BetaMCPToolExecutionError" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="type">
        /// Default Value: mcp_tool_execution_error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMCPToolExecutionError(
            object content,
            global::tryAGI.OpenAI.BetaMCPToolExecutionErrorType type = global::tryAGI.OpenAI.BetaMCPToolExecutionErrorType.McpToolExecutionError)
        {
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMCPToolExecutionError" /> class.
        /// </summary>
        public BetaMCPToolExecutionError()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaMCPToolExecutionError"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaMCPToolExecutionError FromContent(object content)
        {
            return new BetaMCPToolExecutionError
            {
                Content = content,
            };
        }

    }
}
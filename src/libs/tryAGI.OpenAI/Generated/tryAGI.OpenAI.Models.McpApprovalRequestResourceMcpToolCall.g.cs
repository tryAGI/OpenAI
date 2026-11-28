
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class McpApprovalRequestResourceMcpToolCall
    {
        /// <summary>
        /// The type of the object. Always `mcp_tool_call`.<br/>
        /// Default Value: mcp_tool_call
        /// </summary>
        /// <default>global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCallType.McpToolCall</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.McpApprovalRequestResourceMcpToolCallTypeJsonConverter))]
        public global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCallType Type { get; set; } = global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCallType.McpToolCall;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerLabel { get; set; }

        /// <summary>
        /// The tool name, or null when CCA does not provide it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The tool arguments as JSON, or null when CCA does not provide them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public object? Arguments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpApprovalRequestResourceMcpToolCall" /> class.
        /// </summary>
        /// <param name="serverLabel"></param>
        /// <param name="message"></param>
        /// <param name="name">
        /// The tool name, or null when CCA does not provide it.
        /// </param>
        /// <param name="arguments">
        /// The tool arguments as JSON, or null when CCA does not provide them.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `mcp_tool_call`.<br/>
        /// Default Value: mcp_tool_call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpApprovalRequestResourceMcpToolCall(
            string serverLabel,
            string message,
            string? name,
            object? arguments,
            global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCallType type = global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCallType.McpToolCall)
        {
            this.Type = type;
            this.ServerLabel = serverLabel ?? throw new global::System.ArgumentNullException(nameof(serverLabel));
            this.Name = name;
            this.Arguments = arguments;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpApprovalRequestResourceMcpToolCall" /> class.
        /// </summary>
        public McpApprovalRequestResourceMcpToolCall()
        {
        }

    }
}
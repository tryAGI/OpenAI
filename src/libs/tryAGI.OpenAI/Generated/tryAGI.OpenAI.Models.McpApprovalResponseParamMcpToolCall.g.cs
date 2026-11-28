
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class McpApprovalResponseParamMcpToolCall
    {
        /// <summary>
        /// The type of the object. Always `mcp_tool_call`.<br/>
        /// Default Value: mcp_tool_call
        /// </summary>
        /// <default>global::tryAGI.OpenAI.McpApprovalResponseParamMcpToolCallType.McpToolCall</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.McpApprovalResponseParamMcpToolCallTypeJsonConverter))]
        public global::tryAGI.OpenAI.McpApprovalResponseParamMcpToolCallType Type { get; set; } = global::tryAGI.OpenAI.McpApprovalResponseParamMcpToolCallType.McpToolCall;

        /// <summary>
        /// Cancel dismisses this request without cancelling the session or turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decision")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.McpApprovalDecisionParamJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.McpApprovalDecisionParam Decision { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpApprovalResponseParamMcpToolCall" /> class.
        /// </summary>
        /// <param name="decision">
        /// Cancel dismisses this request without cancelling the session or turn.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `mcp_tool_call`.<br/>
        /// Default Value: mcp_tool_call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpApprovalResponseParamMcpToolCall(
            global::tryAGI.OpenAI.McpApprovalDecisionParam decision,
            global::tryAGI.OpenAI.McpApprovalResponseParamMcpToolCallType type = global::tryAGI.OpenAI.McpApprovalResponseParamMcpToolCallType.McpToolCall)
        {
            this.Type = type;
            this.Decision = decision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpApprovalResponseParamMcpToolCall" /> class.
        /// </summary>
        public McpApprovalResponseParamMcpToolCall()
        {
        }

        /// <summary>
        /// Creates a new <see cref="McpApprovalResponseParamMcpToolCall"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static McpApprovalResponseParamMcpToolCall FromDecision(global::tryAGI.OpenAI.McpApprovalDecisionParam decision)
        {
            return new McpApprovalResponseParamMcpToolCall
            {
                Decision = decision,
            };
        }

    }
}
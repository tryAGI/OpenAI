
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Responds to a pending MCP tool-call approval request.
    /// </summary>
    public sealed partial class SessionInputParamAgentSessionInputMcpApprovalRequestResult
    {
        /// <summary>
        /// The type of the object. Always `agent.session.input.mcp_approval_request_result`.<br/>
        /// Default Value: agent.session.input.mcp_approval_request_result
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMcpApprovalRequestResultType.AgentSessionInputMcpApprovalRequestResult</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionInputParamAgentSessionInputMcpApprovalRequestResultTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMcpApprovalRequestResultType Type { get; set; } = global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMcpApprovalRequestResultType.AgentSessionInputMcpApprovalRequestResult;

        /// <summary>
        /// The opaque approval ID from the required action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// The user's decision for a pending MCP tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.McpApprovalResponseParamMcpToolCall Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionInputParamAgentSessionInputMcpApprovalRequestResult" /> class.
        /// </summary>
        /// <param name="requestId">
        /// The opaque approval ID from the required action.
        /// </param>
        /// <param name="response">
        /// The user's decision for a pending MCP tool call.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `agent.session.input.mcp_approval_request_result`.<br/>
        /// Default Value: agent.session.input.mcp_approval_request_result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionInputParamAgentSessionInputMcpApprovalRequestResult(
            string requestId,
            global::tryAGI.OpenAI.McpApprovalResponseParamMcpToolCall response,
            global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMcpApprovalRequestResultType type = global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMcpApprovalRequestResultType.AgentSessionInputMcpApprovalRequestResult)
        {
            this.Type = type;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionInputParamAgentSessionInputMcpApprovalRequestResult" /> class.
        /// </summary>
        public SessionInputParamAgentSessionInputMcpApprovalRequestResult()
        {
        }

    }
}
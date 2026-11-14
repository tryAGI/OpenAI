
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Respond to an MCP tool-call approval request.
    /// </summary>
    public sealed partial class SessionRequiredActionResourceMcpApprovalRequest
    {
        /// <summary>
        /// The type of the object. Always `mcp_approval_request`.<br/>
        /// Default Value: mcp_approval_request
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionRequiredActionResourceMcpApprovalRequestType.McpApprovalRequest</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionRequiredActionResourceMcpApprovalRequestTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionRequiredActionResourceMcpApprovalRequestType Type { get; set; } = global::tryAGI.OpenAI.SessionRequiredActionResourceMcpApprovalRequestType.McpApprovalRequest;

        /// <summary>
        /// The turn that requested approval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TurnId { get; set; }

        /// <summary>
        /// The opaque approval ID to echo when responding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Information for presenting an MCP approval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCall Request { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionRequiredActionResourceMcpApprovalRequest" /> class.
        /// </summary>
        /// <param name="turnId">
        /// The turn that requested approval.
        /// </param>
        /// <param name="requestId">
        /// The opaque approval ID to echo when responding.
        /// </param>
        /// <param name="request">
        /// Information for presenting an MCP approval.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `mcp_approval_request`.<br/>
        /// Default Value: mcp_approval_request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionRequiredActionResourceMcpApprovalRequest(
            string turnId,
            string requestId,
            global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCall request,
            global::tryAGI.OpenAI.SessionRequiredActionResourceMcpApprovalRequestType type = global::tryAGI.OpenAI.SessionRequiredActionResourceMcpApprovalRequestType.McpApprovalRequest)
        {
            this.Type = type;
            this.TurnId = turnId ?? throw new global::System.ArgumentNullException(nameof(turnId));
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionRequiredActionResourceMcpApprovalRequest" /> class.
        /// </summary>
        public SessionRequiredActionResourceMcpApprovalRequest()
        {
        }

    }
}
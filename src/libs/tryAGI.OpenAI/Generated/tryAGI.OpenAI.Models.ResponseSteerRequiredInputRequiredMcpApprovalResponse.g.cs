
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Supply `approve` using the MCP approval response input schema. An<br/>
    /// optional `reason` can be supplied when denying the request. The original<br/>
    /// approval request identifies the tool and server.
    /// </summary>
    public sealed partial class ResponseSteerRequiredInputRequiredMcpApprovalResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseSteerRequiredInputRequiredMcpApprovalResponseTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponseType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approval_request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApprovalRequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSteerRequiredInputRequiredMcpApprovalResponse" /> class.
        /// </summary>
        /// <param name="approvalRequestId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseSteerRequiredInputRequiredMcpApprovalResponse(
            string approvalRequestId,
            global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponseType type)
        {
            this.Type = type;
            this.ApprovalRequestId = approvalRequestId ?? throw new global::System.ArgumentNullException(nameof(approvalRequestId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSteerRequiredInputRequiredMcpApprovalResponse" /> class.
        /// </summary>
        public ResponseSteerRequiredInputRequiredMcpApprovalResponse()
        {
        }

    }
}

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Supply `approve` using the MCP approval response input schema. An<br/>
    /// optional `reason` can be supplied when denying the request. The original<br/>
    /// approval request identifies the tool and server.
    /// </summary>
    public sealed partial class BetaResponseSteerRequiredInputRequiredMcpApprovalResponse
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"mcp_approval_response"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "mcp_approval_response";

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
        /// Initializes a new instance of the <see cref="BetaResponseSteerRequiredInputRequiredMcpApprovalResponse" /> class.
        /// </summary>
        /// <param name="approvalRequestId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseSteerRequiredInputRequiredMcpApprovalResponse(
            string approvalRequestId,
            string type = "mcp_approval_response")
        {
            this.Type = type;
            this.ApprovalRequestId = approvalRequestId ?? throw new global::System.ArgumentNullException(nameof(approvalRequestId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseSteerRequiredInputRequiredMcpApprovalResponse" /> class.
        /// </summary>
        public BetaResponseSteerRequiredInputRequiredMcpApprovalResponse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaResponseSteerRequiredInputRequiredMcpApprovalResponse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaResponseSteerRequiredInputRequiredMcpApprovalResponse FromApprovalRequestId(string approvalRequestId)
        {
            return new BetaResponseSteerRequiredInputRequiredMcpApprovalResponse
            {
                ApprovalRequestId = approvalRequestId,
            };
        }

    }
}
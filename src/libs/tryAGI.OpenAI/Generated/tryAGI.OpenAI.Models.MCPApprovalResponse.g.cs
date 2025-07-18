
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A response to an MCP approval request.
    /// </summary>
    public sealed partial class MCPApprovalResponse
    {
        /// <summary>
        /// The ID of the approval request being answered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approval_request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApprovalRequestId { get; set; }

        /// <summary>
        /// Whether the request was approved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approve")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Approve { get; set; }

        /// <summary>
        /// The unique ID of the approval response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Optional reason for the decision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// The type of the item. Always `mcp_approval_response`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.MCPApprovalResponseTypeJsonConverter))]
        public global::tryAGI.OpenAI.MCPApprovalResponseType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPApprovalResponse" /> class.
        /// </summary>
        /// <param name="approvalRequestId">
        /// The ID of the approval request being answered.
        /// </param>
        /// <param name="approve">
        /// Whether the request was approved.
        /// </param>
        /// <param name="id">
        /// The unique ID of the approval response
        /// </param>
        /// <param name="reason">
        /// Optional reason for the decision.
        /// </param>
        /// <param name="type">
        /// The type of the item. Always `mcp_approval_response`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPApprovalResponse(
            string approvalRequestId,
            bool approve,
            string? id,
            string? reason,
            global::tryAGI.OpenAI.MCPApprovalResponseType type)
        {
            this.ApprovalRequestId = approvalRequestId ?? throw new global::System.ArgumentNullException(nameof(approvalRequestId));
            this.Approve = approve;
            this.Id = id;
            this.Reason = reason;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPApprovalResponse" /> class.
        /// </summary>
        public MCPApprovalResponse()
        {
        }
    }
}

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A Realtime item responding to an MCP approval request.
    /// </summary>
    public sealed partial class RealtimeMCPApprovalResponse
    {
        /// <summary>
        /// The type of the item. Always `mcp_approval_response`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeMCPApprovalResponseTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeMCPApprovalResponseType Type { get; set; }

        /// <summary>
        /// The unique ID of the approval response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The ID of the approval request being answered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approval_request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ApprovalRequestId { get; set; } = default!;

        /// <summary>
        /// Whether the request was approved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approve")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool Approve { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeMCPApprovalResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the item. Always `mcp_approval_response`.
        /// </param>
        /// <param name="id">
        /// The unique ID of the approval response.
        /// </param>
        /// <param name="approvalRequestId">
        /// The ID of the approval request being answered.
        /// </param>
        /// <param name="approve">
        /// Whether the request was approved.
        /// </param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeMCPApprovalResponse(
            string id,
            string approvalRequestId,
            bool approve,
            global::tryAGI.OpenAI.RealtimeMCPApprovalResponseType type,
            string? reason)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ApprovalRequestId = approvalRequestId ?? throw new global::System.ArgumentNullException(nameof(approvalRequestId));
            this.Approve = approve;
            this.Type = type;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeMCPApprovalResponse" /> class.
        /// </summary>
        public RealtimeMCPApprovalResponse()
        {
        }
    }
}
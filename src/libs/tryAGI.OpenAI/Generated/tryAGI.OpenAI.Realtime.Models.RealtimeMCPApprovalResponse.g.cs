
#nullable enable

namespace tryAGI.OpenAI.Realtime
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeMCPApprovalResponseTypeJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalResponseType Type { get; set; }

        /// <summary>
        /// The unique ID of the approval response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

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
        /// <param name="id">
        /// The unique ID of the approval response.
        /// </param>
        /// <param name="approvalRequestId">
        /// The ID of the approval request being answered.
        /// </param>
        /// <param name="approve">
        /// Whether the request was approved.
        /// </param>
        /// <param name="type">
        /// The type of the item. Always `mcp_approval_response`.
        /// </param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeMCPApprovalResponse(
            string id,
            string approvalRequestId,
            bool approve,
            global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalResponseType type,
            string? reason)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ApprovalRequestId = approvalRequestId ?? throw new global::System.ArgumentNullException(nameof(approvalRequestId));
            this.Approve = approve;
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
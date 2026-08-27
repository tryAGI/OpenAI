
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A response to an MCP approval request.
    /// </summary>
    public sealed partial class BetaMCPApprovalResponse
    {
        /// <summary>
        /// The agent that produced this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTag? Agent { get; set; }

        /// <summary>
        /// The type of the item. Always `mcp_approval_response`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaMCPApprovalResponseTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaMCPApprovalResponseType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaMCPApprovalResponse" /> class.
        /// </summary>
        /// <param name="approvalRequestId">
        /// The ID of the approval request being answered.
        /// </param>
        /// <param name="approve">
        /// Whether the request was approved.
        /// </param>
        /// <param name="agent">
        /// The agent that produced this item.
        /// </param>
        /// <param name="type">
        /// The type of the item. Always `mcp_approval_response`.
        /// </param>
        /// <param name="id"></param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMCPApprovalResponse(
            string approvalRequestId,
            bool approve,
            global::tryAGI.OpenAI.BetaAgentTag? agent,
            global::tryAGI.OpenAI.BetaMCPApprovalResponseType type,
            string? id,
            string? reason)
        {
            this.Agent = agent;
            this.Type = type;
            this.Id = id;
            this.ApprovalRequestId = approvalRequestId ?? throw new global::System.ArgumentNullException(nameof(approvalRequestId));
            this.Approve = approve;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMCPApprovalResponse" /> class.
        /// </summary>
        public BetaMCPApprovalResponse()
        {
        }

    }
}
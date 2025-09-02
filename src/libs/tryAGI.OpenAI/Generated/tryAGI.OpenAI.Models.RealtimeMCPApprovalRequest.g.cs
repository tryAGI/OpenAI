
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A Realtime item requesting human approval of a tool invocation.
    /// </summary>
    public sealed partial class RealtimeMCPApprovalRequest
    {
        /// <summary>
        /// A JSON string of arguments for the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arguments { get; set; }

        /// <summary>
        /// The unique ID of the approval request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the tool to run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The label of the MCP server making the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerLabel { get; set; }

        /// <summary>
        /// The type of the item. Always `mcp_approval_request`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeMCPApprovalRequestTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeMCPApprovalRequestType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeMCPApprovalRequest" /> class.
        /// </summary>
        /// <param name="arguments">
        /// A JSON string of arguments for the tool.
        /// </param>
        /// <param name="id">
        /// The unique ID of the approval request.
        /// </param>
        /// <param name="name">
        /// The name of the tool to run.
        /// </param>
        /// <param name="serverLabel">
        /// The label of the MCP server making the request.
        /// </param>
        /// <param name="type">
        /// The type of the item. Always `mcp_approval_request`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeMCPApprovalRequest(
            string arguments,
            string id,
            string name,
            string serverLabel,
            global::tryAGI.OpenAI.RealtimeMCPApprovalRequestType type)
        {
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ServerLabel = serverLabel ?? throw new global::System.ArgumentNullException(nameof(serverLabel));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeMCPApprovalRequest" /> class.
        /// </summary>
        public RealtimeMCPApprovalRequest()
        {
        }
    }
}
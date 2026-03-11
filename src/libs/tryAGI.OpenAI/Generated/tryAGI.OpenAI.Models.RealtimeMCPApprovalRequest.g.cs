
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A Realtime item requesting human approval of a tool invocation.
    /// </summary>
    public sealed partial class RealtimeMCPApprovalRequest
    {
        /// <summary>
        /// The type of the item. Always `mcp_approval_request`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeMCPApprovalRequestTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeMCPApprovalRequestType Type { get; set; }

        /// <summary>
        /// The unique ID of the approval request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The label of the MCP server making the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ServerLabel { get; set; } = default!;

        /// <summary>
        /// The name of the tool to run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A JSON string of arguments for the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Arguments { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeMCPApprovalRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the item. Always `mcp_approval_request`.
        /// </param>
        /// <param name="id">
        /// The unique ID of the approval request.
        /// </param>
        /// <param name="serverLabel">
        /// The label of the MCP server making the request.
        /// </param>
        /// <param name="name">
        /// The name of the tool to run.
        /// </param>
        /// <param name="arguments">
        /// A JSON string of arguments for the tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeMCPApprovalRequest(
            string id,
            string serverLabel,
            string name,
            string arguments,
            global::tryAGI.OpenAI.RealtimeMCPApprovalRequestType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ServerLabel = serverLabel ?? throw new global::System.ArgumentNullException(nameof(serverLabel));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
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
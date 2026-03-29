
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A Realtime item representing an invocation of a tool on an MCP server.
    /// </summary>
    public sealed partial class RealtimeMCPToolCall
    {
        /// <summary>
        /// The type of the item. Always `mcp_call`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeMCPToolCallTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeMCPToolCallType Type { get; set; }

        /// <summary>
        /// The unique ID of the tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The label of the MCP server running the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerLabel { get; set; }

        /// <summary>
        /// The name of the tool that was run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A JSON string of the arguments passed to the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arguments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approval_request_id")]
        public string? ApprovalRequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public string? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeMCPProtocolError, global::tryAGI.OpenAI.RealtimeMCPToolExecutionError, global::tryAGI.OpenAI.RealtimeMCPHTTPError>? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeMCPToolCall" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the tool call.
        /// </param>
        /// <param name="serverLabel">
        /// The label of the MCP server running the tool.
        /// </param>
        /// <param name="name">
        /// The name of the tool that was run.
        /// </param>
        /// <param name="arguments">
        /// A JSON string of the arguments passed to the tool.
        /// </param>
        /// <param name="type">
        /// The type of the item. Always `mcp_call`.
        /// </param>
        /// <param name="approvalRequestId"></param>
        /// <param name="output"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeMCPToolCall(
            string id,
            string serverLabel,
            string name,
            string arguments,
            global::tryAGI.OpenAI.RealtimeMCPToolCallType type,
            string? approvalRequestId,
            string? output,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeMCPProtocolError, global::tryAGI.OpenAI.RealtimeMCPToolExecutionError, global::tryAGI.OpenAI.RealtimeMCPHTTPError>? error)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ServerLabel = serverLabel ?? throw new global::System.ArgumentNullException(nameof(serverLabel));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.ApprovalRequestId = approvalRequestId;
            this.Output = output;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeMCPToolCall" /> class.
        /// </summary>
        public RealtimeMCPToolCall()
        {
        }
    }
}
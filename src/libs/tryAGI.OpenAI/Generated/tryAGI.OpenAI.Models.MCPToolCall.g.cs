
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An invocation of a tool on an MCP server.
    /// </summary>
    public sealed partial class MCPToolCall
    {
        /// <summary>
        /// The type of the item. Always `mcp_call`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.MCPToolCallTypeJsonConverter))]
        public global::tryAGI.OpenAI.MCPToolCallType Type { get; set; }

        /// <summary>
        /// The unique ID of the tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The label of the MCP server running the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ServerLabel { get; set; } = default!;

        /// <summary>
        /// The name of the tool that was run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A JSON string of the arguments passed to the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Arguments { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public string? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The status of the tool call. One of `in_progress`, `completed`, `incomplete`, `calling`, or `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.MCPToolCallStatusJsonConverter))]
        public global::tryAGI.OpenAI.MCPToolCallStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approval_request_id")]
        public string? ApprovalRequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolCall" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the item. Always `mcp_call`.
        /// </param>
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
        /// <param name="output"></param>
        /// <param name="error"></param>
        /// <param name="status">
        /// The status of the tool call. One of `in_progress`, `completed`, `incomplete`, `calling`, or `failed`.
        /// </param>
        /// <param name="approvalRequestId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPToolCall(
            string id,
            string serverLabel,
            string name,
            string arguments,
            global::tryAGI.OpenAI.MCPToolCallType type,
            string? output,
            string? error,
            global::tryAGI.OpenAI.MCPToolCallStatus? status,
            string? approvalRequestId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ServerLabel = serverLabel ?? throw new global::System.ArgumentNullException(nameof(serverLabel));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Type = type;
            this.Output = output;
            this.Error = error;
            this.Status = status;
            this.ApprovalRequestId = approvalRequestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolCall" /> class.
        /// </summary>
        public MCPToolCall()
        {
        }
    }
}

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An invocation of a tool on an MCP server.
    /// </summary>
    public sealed partial class MCPToolCall
    {
        /// <summary>
        /// A JSON string of the arguments passed to the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arguments { get; set; }

        /// <summary>
        /// The error from the tool call, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The unique ID of the tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the tool that was run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The output from the tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public string? Output { get; set; }

        /// <summary>
        /// The label of the MCP server running the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerLabel { get; set; }

        /// <summary>
        /// The type of the item. Always `mcp_call`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.MCPToolCallTypeJsonConverter))]
        public global::tryAGI.OpenAI.MCPToolCallType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolCall" /> class.
        /// </summary>
        /// <param name="arguments">
        /// A JSON string of the arguments passed to the tool.
        /// </param>
        /// <param name="error">
        /// The error from the tool call, if any.
        /// </param>
        /// <param name="id">
        /// The unique ID of the tool call.
        /// </param>
        /// <param name="name">
        /// The name of the tool that was run.
        /// </param>
        /// <param name="output">
        /// The output from the tool call.
        /// </param>
        /// <param name="serverLabel">
        /// The label of the MCP server running the tool.
        /// </param>
        /// <param name="type">
        /// The type of the item. Always `mcp_call`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPToolCall(
            string arguments,
            string id,
            string name,
            string serverLabel,
            string? error,
            string? output,
            global::tryAGI.OpenAI.MCPToolCallType type)
        {
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ServerLabel = serverLabel ?? throw new global::System.ArgumentNullException(nameof(serverLabel));
            this.Error = error;
            this.Output = output;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolCall" /> class.
        /// </summary>
        public MCPToolCall()
        {
        }
    }
}
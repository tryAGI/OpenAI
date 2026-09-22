
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Tools provided by a remote MCP server.
    /// </summary>
    public sealed partial class AgentToolResourceMcp
    {
        /// <summary>
        /// The type of the object. Always `mcp`.<br/>
        /// Default Value: mcp
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AgentToolResourceMcpType.Mcp</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AgentToolResourceMcpTypeJsonConverter))]
        public global::tryAGI.OpenAI.AgentToolResourceMcpType Type { get; set; } = global::tryAGI.OpenAI.AgentToolResourceMcpType.Mcp;

        /// <summary>
        /// A label used to identify the MCP server in tool calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerLabel { get; set; }

        /// <summary>
        /// The attached vault credential selected for this MCP server, if any. Optional when exactly one attached credential matches the server URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential_id")]
        public string? CredentialId { get; set; }

        /// <summary>
        /// The transport used to connect to the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.McpTransportResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.McpTransportResource Transport { get; set; }

        /// <summary>
        /// Metadata included with requests to this MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object RequestMetadata { get; set; }

        /// <summary>
        /// The MCP tools the agent may call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_tools")]
        public global::System.Collections.Generic.IList<string>? AllowedTools { get; set; }

        /// <summary>
        /// Whether this MCP server must initialize before the first turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Required { get; set; }

        /// <summary>
        /// Where outbound MCP HTTP connections originate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.McpConnectionOriginResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.McpConnectionOriginResource ConnectionOrigin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolResourceMcp" /> class.
        /// </summary>
        /// <param name="serverLabel">
        /// A label used to identify the MCP server in tool calls.
        /// </param>
        /// <param name="transport">
        /// The transport used to connect to the MCP server.
        /// </param>
        /// <param name="requestMetadata">
        /// Metadata included with requests to this MCP server.
        /// </param>
        /// <param name="required">
        /// Whether this MCP server must initialize before the first turn.
        /// </param>
        /// <param name="connectionOrigin">
        /// Where outbound MCP HTTP connections originate.
        /// </param>
        /// <param name="credentialId">
        /// The attached vault credential selected for this MCP server, if any. Optional when exactly one attached credential matches the server URL.
        /// </param>
        /// <param name="allowedTools">
        /// The MCP tools the agent may call.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `mcp`.<br/>
        /// Default Value: mcp
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentToolResourceMcp(
            string serverLabel,
            global::tryAGI.OpenAI.McpTransportResource transport,
            object requestMetadata,
            bool required,
            global::tryAGI.OpenAI.McpConnectionOriginResource connectionOrigin,
            string? credentialId,
            global::System.Collections.Generic.IList<string>? allowedTools,
            global::tryAGI.OpenAI.AgentToolResourceMcpType type = global::tryAGI.OpenAI.AgentToolResourceMcpType.Mcp)
        {
            this.Type = type;
            this.ServerLabel = serverLabel ?? throw new global::System.ArgumentNullException(nameof(serverLabel));
            this.CredentialId = credentialId;
            this.Transport = transport;
            this.RequestMetadata = requestMetadata ?? throw new global::System.ArgumentNullException(nameof(requestMetadata));
            this.AllowedTools = allowedTools;
            this.Required = required;
            this.ConnectionOrigin = connectionOrigin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolResourceMcp" /> class.
        /// </summary>
        public AgentToolResourceMcp()
        {
        }

    }
}
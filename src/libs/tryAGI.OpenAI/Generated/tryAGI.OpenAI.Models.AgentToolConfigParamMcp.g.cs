
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Tools provided by a remote MCP server.
    /// </summary>
    public sealed partial class AgentToolConfigParamMcp
    {
        /// <summary>
        /// The type of the object. Always `mcp`.<br/>
        /// Default Value: mcp
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AgentToolConfigParamMcpType.Mcp</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamMcpTypeJsonConverter))]
        public global::tryAGI.OpenAI.AgentToolConfigParamMcpType Type { get; set; } = global::tryAGI.OpenAI.AgentToolConfigParamMcpType.Mcp;

        /// <summary>
        /// A label used to identify the MCP server in tool calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerLabel { get; set; }

        /// <summary>
        /// The attached vault credential used to authenticate this MCP server. Optional when exactly one attached credential matches the server URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential_id")]
        public string? CredentialId { get; set; }

        /// <summary>
        /// The transport used to connect to the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.McpTransportConfigParamJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.McpTransportConfigParam Transport { get; set; }

        /// <summary>
        /// Metadata included with requests to this MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_metadata")]
        public object? RequestMetadata { get; set; }

        /// <summary>
        /// The MCP tools the agent may call. All server tools are allowed when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_tools")]
        public global::System.Collections.Generic.IList<string>? AllowedTools { get; set; }

        /// <summary>
        /// Whether this MCP server must initialize before the first turn. Defaults to `false`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Selects where outbound MCP HTTP connections originate. Omitted or `service` uses the Managed Agents service network; `environment` uses the session's selected environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_origin")]
        public global::tryAGI.OpenAI.McpConnectionOriginParam? ConnectionOrigin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolConfigParamMcp" /> class.
        /// </summary>
        /// <param name="serverLabel">
        /// A label used to identify the MCP server in tool calls.
        /// </param>
        /// <param name="transport">
        /// The transport used to connect to the MCP server.
        /// </param>
        /// <param name="credentialId">
        /// The attached vault credential used to authenticate this MCP server. Optional when exactly one attached credential matches the server URL.
        /// </param>
        /// <param name="requestMetadata">
        /// Metadata included with requests to this MCP server.
        /// </param>
        /// <param name="allowedTools">
        /// The MCP tools the agent may call. All server tools are allowed when omitted.
        /// </param>
        /// <param name="required">
        /// Whether this MCP server must initialize before the first turn. Defaults to `false`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="connectionOrigin">
        /// Selects where outbound MCP HTTP connections originate. Omitted or `service` uses the Managed Agents service network; `environment` uses the session's selected environment.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `mcp`.<br/>
        /// Default Value: mcp
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentToolConfigParamMcp(
            string serverLabel,
            global::tryAGI.OpenAI.McpTransportConfigParam transport,
            string? credentialId,
            object? requestMetadata,
            global::System.Collections.Generic.IList<string>? allowedTools,
            bool? required,
            global::tryAGI.OpenAI.McpConnectionOriginParam? connectionOrigin,
            global::tryAGI.OpenAI.AgentToolConfigParamMcpType type = global::tryAGI.OpenAI.AgentToolConfigParamMcpType.Mcp)
        {
            this.Type = type;
            this.ServerLabel = serverLabel ?? throw new global::System.ArgumentNullException(nameof(serverLabel));
            this.CredentialId = credentialId;
            this.Transport = transport;
            this.RequestMetadata = requestMetadata;
            this.AllowedTools = allowedTools;
            this.Required = required;
            this.ConnectionOrigin = connectionOrigin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolConfigParamMcp" /> class.
        /// </summary>
        public AgentToolConfigParamMcp()
        {
        }

    }
}
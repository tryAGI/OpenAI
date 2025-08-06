
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Give the model access to additional tools via remote Model Context Protocol <br/>
    /// (MCP) servers. [Learn more about MCP](https://platform.openai.com/docs/guides/tools-remote-mcp).
    /// </summary>
    public sealed partial class MCPTool
    {
        /// <summary>
        /// List of allowed tool names or a filter object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_tools")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.MCPToolAllowedTools>))]
        public global::tryAGI.OpenAI.AnyOf<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.MCPToolAllowedTools>? AllowedTools { get; set; }

        /// <summary>
        /// Optional HTTP headers to send to the MCP server. Use for authentication<br/>
        /// or other purposes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Specify which of the MCP server's tools require approval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_approval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.MCPToolRequireApprovalEnum, global::tryAGI.OpenAI.MCPToolRequireApprovalEnum2?>))]
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.MCPToolRequireApprovalEnum, global::tryAGI.OpenAI.MCPToolRequireApprovalEnum2?>? RequireApproval { get; set; }

        /// <summary>
        /// Optional description of the MCP server, used to provide more context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_description")]
        public string? ServerDescription { get; set; }

        /// <summary>
        /// A label for this MCP server, used to identify it in tool calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerLabel { get; set; }

        /// <summary>
        /// The URL for the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerUrl { get; set; }

        /// <summary>
        /// The type of the MCP tool. Always `mcp`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.MCPToolTypeJsonConverter))]
        public global::tryAGI.OpenAI.MCPToolType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPTool" /> class.
        /// </summary>
        /// <param name="allowedTools">
        /// List of allowed tool names or a filter object.
        /// </param>
        /// <param name="headers">
        /// Optional HTTP headers to send to the MCP server. Use for authentication<br/>
        /// or other purposes.
        /// </param>
        /// <param name="requireApproval">
        /// Specify which of the MCP server's tools require approval.
        /// </param>
        /// <param name="serverDescription">
        /// Optional description of the MCP server, used to provide more context.
        /// </param>
        /// <param name="serverLabel">
        /// A label for this MCP server, used to identify it in tool calls.
        /// </param>
        /// <param name="serverUrl">
        /// The URL for the MCP server.
        /// </param>
        /// <param name="type">
        /// The type of the MCP tool. Always `mcp`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPTool(
            string serverLabel,
            string serverUrl,
            global::tryAGI.OpenAI.AnyOf<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.MCPToolAllowedTools>? allowedTools,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.MCPToolRequireApprovalEnum, global::tryAGI.OpenAI.MCPToolRequireApprovalEnum2?>? requireApproval,
            string? serverDescription,
            global::tryAGI.OpenAI.MCPToolType type)
        {
            this.ServerLabel = serverLabel ?? throw new global::System.ArgumentNullException(nameof(serverLabel));
            this.ServerUrl = serverUrl ?? throw new global::System.ArgumentNullException(nameof(serverUrl));
            this.AllowedTools = allowedTools;
            this.Headers = headers;
            this.RequireApproval = requireApproval;
            this.ServerDescription = serverDescription;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPTool" /> class.
        /// </summary>
        public MCPTool()
        {
        }
    }
}
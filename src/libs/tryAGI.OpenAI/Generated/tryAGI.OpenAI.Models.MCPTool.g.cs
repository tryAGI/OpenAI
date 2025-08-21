
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.MCPToolFilter>))]
        public global::tryAGI.OpenAI.AnyOf<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.MCPToolFilter>? AllowedTools { get; set; }

        /// <summary>
        /// An OAuth access token that can be used with a remote MCP server, either <br/>
        /// with a custom MCP server URL or a service connector. Your application<br/>
        /// must handle the OAuth authorization flow and provide the token here.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorization")]
        public string? Authorization { get; set; }

        /// <summary>
        /// Identifier for service connectors, like those available in ChatGPT. One of<br/>
        /// `server_url` or `connector_id` must be provided. Learn more about service<br/>
        /// connectors [here](https://platform.openai.com/docs/guides/tools-remote-mcp#connectors).<br/>
        /// Currently supported `connector_id` values are:<br/>
        /// - Dropbox: `connector_dropbox`<br/>
        /// - Gmail: `connector_gmail`<br/>
        /// - Google Calendar: `connector_googlecalendar`<br/>
        /// - Google Drive: `connector_googledrive`<br/>
        /// - Microsoft Teams: `connector_microsoftteams`<br/>
        /// - Outlook Calendar: `connector_outlookcalendar`<br/>
        /// - Outlook Email: `connector_outlookemail`<br/>
        /// - SharePoint: `connector_sharepoint`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.MCPToolConnectorIdJsonConverter))]
        public global::tryAGI.OpenAI.MCPToolConnectorId? ConnectorId { get; set; }

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
        /// The URL for the MCP server. One of `server_url` or `connector_id` must be <br/>
        /// provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_url")]
        public string? ServerUrl { get; set; }

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
        /// <param name="authorization">
        /// An OAuth access token that can be used with a remote MCP server, either <br/>
        /// with a custom MCP server URL or a service connector. Your application<br/>
        /// must handle the OAuth authorization flow and provide the token here.
        /// </param>
        /// <param name="connectorId">
        /// Identifier for service connectors, like those available in ChatGPT. One of<br/>
        /// `server_url` or `connector_id` must be provided. Learn more about service<br/>
        /// connectors [here](https://platform.openai.com/docs/guides/tools-remote-mcp#connectors).<br/>
        /// Currently supported `connector_id` values are:<br/>
        /// - Dropbox: `connector_dropbox`<br/>
        /// - Gmail: `connector_gmail`<br/>
        /// - Google Calendar: `connector_googlecalendar`<br/>
        /// - Google Drive: `connector_googledrive`<br/>
        /// - Microsoft Teams: `connector_microsoftteams`<br/>
        /// - Outlook Calendar: `connector_outlookcalendar`<br/>
        /// - Outlook Email: `connector_outlookemail`<br/>
        /// - SharePoint: `connector_sharepoint`
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
        /// The URL for the MCP server. One of `server_url` or `connector_id` must be <br/>
        /// provided.
        /// </param>
        /// <param name="type">
        /// The type of the MCP tool. Always `mcp`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPTool(
            string serverLabel,
            global::tryAGI.OpenAI.AnyOf<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.MCPToolFilter>? allowedTools,
            string? authorization,
            global::tryAGI.OpenAI.MCPToolConnectorId? connectorId,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.MCPToolRequireApprovalEnum, global::tryAGI.OpenAI.MCPToolRequireApprovalEnum2?>? requireApproval,
            string? serverDescription,
            string? serverUrl,
            global::tryAGI.OpenAI.MCPToolType type)
        {
            this.ServerLabel = serverLabel ?? throw new global::System.ArgumentNullException(nameof(serverLabel));
            this.AllowedTools = allowedTools;
            this.Authorization = authorization;
            this.ConnectorId = connectorId;
            this.Headers = headers;
            this.RequireApproval = requireApproval;
            this.ServerDescription = serverDescription;
            this.ServerUrl = serverUrl;
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
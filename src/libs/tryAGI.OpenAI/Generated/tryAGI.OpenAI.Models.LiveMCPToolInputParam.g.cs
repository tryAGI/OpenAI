
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveMCPToolInputParam
    {
        /// <summary>
        /// Default Value: mcp
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveMCPToolInputParamType.Mcp</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveMCPToolInputParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveMCPToolInputParamType Type { get; set; } = global::tryAGI.OpenAI.LiveMCPToolInputParamType.Mcp;

        /// <summary>
        /// A label used to identify the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        public string? ServerLabel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_url")]
        public string? ServerUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_description")]
        public string? ServerDescription { get; set; }

        /// <summary>
        /// This value is omitted from returned Live session data.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorization")]
        public string? Authorization { get; set; }

        /// <summary>
        /// This value is omitted from returned Live session data.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_tools")]
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.LiveMCPToolFilterParam>? AllowedTools { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_approval")]
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveMCPRequireApprovalFilterParam, global::tryAGI.OpenAI.LiveMCPRequireApprovalApiEnum?>? RequireApproval { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector_id")]
        public string? ConnectorId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tunnel_id")]
        public string? TunnelId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_callers")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveCallableToolAllowedCaller>? AllowedCallers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defer_loading")]
        public bool? DeferLoading { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveMCPToolInputParam" /> class.
        /// </summary>
        /// <param name="serverLabel">
        /// A label used to identify the MCP server.
        /// </param>
        /// <param name="serverUrl"></param>
        /// <param name="serverDescription"></param>
        /// <param name="authorization">
        /// This value is omitted from returned Live session data.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="headers">
        /// This value is omitted from returned Live session data.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="allowedTools"></param>
        /// <param name="requireApproval"></param>
        /// <param name="connectorId"></param>
        /// <param name="tunnelId"></param>
        /// <param name="allowedCallers"></param>
        /// <param name="deferLoading"></param>
        /// <param name="type">
        /// Default Value: mcp
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveMCPToolInputParam(
            string? serverLabel,
            string? serverUrl,
            string? serverDescription,
            string? authorization,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.LiveMCPToolFilterParam>? allowedTools,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveMCPRequireApprovalFilterParam, global::tryAGI.OpenAI.LiveMCPRequireApprovalApiEnum?>? requireApproval,
            string? connectorId,
            string? tunnelId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveCallableToolAllowedCaller>? allowedCallers,
            bool? deferLoading,
            global::tryAGI.OpenAI.LiveMCPToolInputParamType type = global::tryAGI.OpenAI.LiveMCPToolInputParamType.Mcp)
        {
            this.Type = type;
            this.ServerLabel = serverLabel;
            this.ServerUrl = serverUrl;
            this.ServerDescription = serverDescription;
            this.Authorization = authorization;
            this.Headers = headers;
            this.AllowedTools = allowedTools;
            this.RequireApproval = requireApproval;
            this.ConnectorId = connectorId;
            this.TunnelId = tunnelId;
            this.AllowedCallers = allowedCallers;
            this.DeferLoading = deferLoading;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveMCPToolInputParam" /> class.
        /// </summary>
        public LiveMCPToolInputParam()
        {
        }

    }
}
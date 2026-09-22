
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An OAuth credential for an HTTPS MCP destination.
    /// </summary>
    public sealed partial class CreateVaultCredentialAuthParamMcpOauth
    {
        /// <summary>
        /// The type of the object. Always `mcp_oauth`.<br/>
        /// Default Value: mcp_oauth
        /// </summary>
        /// <default>global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauthType.McpOauth</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateVaultCredentialAuthParamMcpOauthTypeJsonConverter))]
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauthType Type { get; set; } = global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauthType.McpOauth;

        /// <summary>
        /// The HTTPS MCP server URL authorized by this credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpServerUrl { get; set; }

        /// <summary>
        /// A write-only OAuth access token; never returned by credential resources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessToken { get; set; }

        /// <summary>
        /// When the OAuth access token expires, as an RFC 3339 timestamp, if known.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public string? ExpiresAt { get; set; }

        /// <summary>
        /// Optional refresh configuration for an HTTPS OAuth token endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh")]
        public global::tryAGI.OpenAI.CreateMcpOauthRefreshParam? Refresh { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVaultCredentialAuthParamMcpOauth" /> class.
        /// </summary>
        /// <param name="mcpServerUrl">
        /// The HTTPS MCP server URL authorized by this credential.
        /// </param>
        /// <param name="accessToken">
        /// A write-only OAuth access token; never returned by credential resources.
        /// </param>
        /// <param name="expiresAt">
        /// When the OAuth access token expires, as an RFC 3339 timestamp, if known.
        /// </param>
        /// <param name="refresh">
        /// Optional refresh configuration for an HTTPS OAuth token endpoint.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `mcp_oauth`.<br/>
        /// Default Value: mcp_oauth
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVaultCredentialAuthParamMcpOauth(
            string mcpServerUrl,
            string accessToken,
            string? expiresAt,
            global::tryAGI.OpenAI.CreateMcpOauthRefreshParam? refresh,
            global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauthType type = global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauthType.McpOauth)
        {
            this.Type = type;
            this.McpServerUrl = mcpServerUrl ?? throw new global::System.ArgumentNullException(nameof(mcpServerUrl));
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
            this.ExpiresAt = expiresAt;
            this.Refresh = refresh;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVaultCredentialAuthParamMcpOauth" /> class.
        /// </summary>
        public CreateVaultCredentialAuthParamMcpOauth()
        {
        }

    }
}
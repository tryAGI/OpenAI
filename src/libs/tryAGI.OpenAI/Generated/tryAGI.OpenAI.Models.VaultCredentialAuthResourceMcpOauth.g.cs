
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Public metadata for an OAuth credential; tokens and client secrets are never returned.
    /// </summary>
    public sealed partial class VaultCredentialAuthResourceMcpOauth
    {
        /// <summary>
        /// The type of the object. Always `mcp_oauth`.<br/>
        /// Default Value: mcp_oauth
        /// </summary>
        /// <default>global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauthType.McpOauth</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VaultCredentialAuthResourceMcpOauthTypeJsonConverter))]
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauthType Type { get; set; } = global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauthType.McpOauth;

        /// <summary>
        /// The HTTPS MCP server URL authorized by this credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpServerUrl { get; set; }

        /// <summary>
        /// When the OAuth access token expires, as an RFC 3339 timestamp, if known.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public string? ExpiresAt { get; set; }

        /// <summary>
        /// Public refresh metadata without refresh tokens or OAuth client secrets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh")]
        public global::tryAGI.OpenAI.McpOauthRefreshResource? Refresh { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultCredentialAuthResourceMcpOauth" /> class.
        /// </summary>
        /// <param name="mcpServerUrl">
        /// The HTTPS MCP server URL authorized by this credential.
        /// </param>
        /// <param name="expiresAt">
        /// When the OAuth access token expires, as an RFC 3339 timestamp, if known.
        /// </param>
        /// <param name="refresh">
        /// Public refresh metadata without refresh tokens or OAuth client secrets.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `mcp_oauth`.<br/>
        /// Default Value: mcp_oauth
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultCredentialAuthResourceMcpOauth(
            string mcpServerUrl,
            string? expiresAt,
            global::tryAGI.OpenAI.McpOauthRefreshResource? refresh,
            global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauthType type = global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauthType.McpOauth)
        {
            this.Type = type;
            this.McpServerUrl = mcpServerUrl ?? throw new global::System.ArgumentNullException(nameof(mcpServerUrl));
            this.ExpiresAt = expiresAt;
            this.Refresh = refresh;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultCredentialAuthResourceMcpOauth" /> class.
        /// </summary>
        public VaultCredentialAuthResourceMcpOauth()
        {
        }

        /// <summary>
        /// Creates a new <see cref="VaultCredentialAuthResourceMcpOauth"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static VaultCredentialAuthResourceMcpOauth FromMcpServerUrl(string mcpServerUrl)
        {
            return new VaultCredentialAuthResourceMcpOauth
            {
                McpServerUrl = mcpServerUrl,
            };
        }

    }
}

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Rotate an OAuth credential for an HTTPS MCP destination.
    /// </summary>
    public sealed partial class RotateVaultCredentialAuthParamMcpOauth
    {
        /// <summary>
        /// The type of the object. Always `mcp_oauth`.<br/>
        /// Default Value: mcp_oauth
        /// </summary>
        /// <default>global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauthType.McpOauth</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RotateVaultCredentialAuthParamMcpOauthTypeJsonConverter))]
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauthType Type { get; set; } = global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauthType.McpOauth;

        /// <summary>
        /// A write-only replacement OAuth access token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public string? AccessToken { get; set; }

        /// <summary>
        /// The replacement expiry as an RFC 3339 timestamp, or `null` to clear it. Omitting this field preserves the expiry unless a new access token is supplied, in which case the expiry is cleared.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public string? ExpiresAt { get; set; }

        /// <summary>
        /// Optional write-only refresh-token and client-secret updates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh")]
        public global::tryAGI.OpenAI.RotateMcpOauthRefreshParam? Refresh { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateVaultCredentialAuthParamMcpOauth" /> class.
        /// </summary>
        /// <param name="accessToken">
        /// A write-only replacement OAuth access token.
        /// </param>
        /// <param name="expiresAt">
        /// The replacement expiry as an RFC 3339 timestamp, or `null` to clear it. Omitting this field preserves the expiry unless a new access token is supplied, in which case the expiry is cleared.
        /// </param>
        /// <param name="refresh">
        /// Optional write-only refresh-token and client-secret updates.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `mcp_oauth`.<br/>
        /// Default Value: mcp_oauth
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RotateVaultCredentialAuthParamMcpOauth(
            string? accessToken,
            string? expiresAt,
            global::tryAGI.OpenAI.RotateMcpOauthRefreshParam? refresh,
            global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauthType type = global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauthType.McpOauth)
        {
            this.Type = type;
            this.AccessToken = accessToken;
            this.ExpiresAt = expiresAt;
            this.Refresh = refresh;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateVaultCredentialAuthParamMcpOauth" /> class.
        /// </summary>
        public RotateVaultCredentialAuthParamMcpOauth()
        {
        }

    }
}
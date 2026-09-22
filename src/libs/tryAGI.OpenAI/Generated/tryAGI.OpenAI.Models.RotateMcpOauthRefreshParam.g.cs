
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Updates to an MCP credential's existing OAuth refresh configuration.
    /// </summary>
    public sealed partial class RotateMcpOauthRefreshParam
    {
        /// <summary>
        /// The replacement refresh token. Omit or pass `null` to keep the stored token. This secret is never returned in resources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
        public string? RefreshToken { get; set; }

        /// <summary>
        /// Replacement space-separated OAuth scopes for refresh requests. Omit to keep the scopes, or pass `null` to stop sending a scope parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// Client-secret updates for the existing token endpoint authentication method.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_endpoint_auth")]
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParam? TokenEndpointAuth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateMcpOauthRefreshParam" /> class.
        /// </summary>
        /// <param name="refreshToken">
        /// The replacement refresh token. Omit or pass `null` to keep the stored token. This secret is never returned in resources.
        /// </param>
        /// <param name="scope">
        /// Replacement space-separated OAuth scopes for refresh requests. Omit to keep the scopes, or pass `null` to stop sending a scope parameter.
        /// </param>
        /// <param name="tokenEndpointAuth">
        /// Client-secret updates for the existing token endpoint authentication method.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RotateMcpOauthRefreshParam(
            string? refreshToken,
            string? scope,
            global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParam? tokenEndpointAuth)
        {
            this.RefreshToken = refreshToken;
            this.Scope = scope;
            this.TokenEndpointAuth = tokenEndpointAuth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateMcpOauthRefreshParam" /> class.
        /// </summary>
        public RotateMcpOauthRefreshParam()
        {
        }

    }
}
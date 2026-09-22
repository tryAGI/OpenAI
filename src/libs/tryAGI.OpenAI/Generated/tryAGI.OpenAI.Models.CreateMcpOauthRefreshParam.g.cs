
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration for refreshing the access token of an MCP OAuth credential.
    /// </summary>
    public sealed partial class CreateMcpOauthRefreshParam
    {
        /// <summary>
        /// The HTTPS OAuth token endpoint used to exchange the refresh token for a new access token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenEndpoint { get; set; }

        /// <summary>
        /// The OAuth client ID used when requesting a new access token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// The resource URI to send to the OAuth token endpoint during refresh, if required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        public string? Resource { get; set; }

        /// <summary>
        /// Space-separated OAuth scopes to request during refresh, if required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// The refresh token to store. This secret is never returned in credential resources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RefreshToken { get; set; }

        /// <summary>
        /// How the OAuth client authenticates to the token endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_endpoint_auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateMcpOauthTokenEndpointAuthParamJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParam TokenEndpointAuth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMcpOauthRefreshParam" /> class.
        /// </summary>
        /// <param name="tokenEndpoint">
        /// The HTTPS OAuth token endpoint used to exchange the refresh token for a new access token.
        /// </param>
        /// <param name="clientId">
        /// The OAuth client ID used when requesting a new access token.
        /// </param>
        /// <param name="refreshToken">
        /// The refresh token to store. This secret is never returned in credential resources.
        /// </param>
        /// <param name="tokenEndpointAuth">
        /// How the OAuth client authenticates to the token endpoint.
        /// </param>
        /// <param name="resource">
        /// The resource URI to send to the OAuth token endpoint during refresh, if required.
        /// </param>
        /// <param name="scope">
        /// Space-separated OAuth scopes to request during refresh, if required.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateMcpOauthRefreshParam(
            string tokenEndpoint,
            string clientId,
            string refreshToken,
            global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParam tokenEndpointAuth,
            string? resource,
            string? scope)
        {
            this.TokenEndpoint = tokenEndpoint ?? throw new global::System.ArgumentNullException(nameof(tokenEndpoint));
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.Resource = resource;
            this.Scope = scope;
            this.RefreshToken = refreshToken ?? throw new global::System.ArgumentNullException(nameof(refreshToken));
            this.TokenEndpointAuth = tokenEndpointAuth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMcpOauthRefreshParam" /> class.
        /// </summary>
        public CreateMcpOauthRefreshParam()
        {
        }

    }
}
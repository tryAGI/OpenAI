
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration used to refresh an MCP OAuth access token, excluding secret values.
    /// </summary>
    public sealed partial class McpOauthRefreshResource
    {
        /// <summary>
        /// The HTTPS OAuth token endpoint used for refresh.
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
        /// The resource URI sent to the OAuth token endpoint during refresh, if configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        public string? Resource { get; set; }

        /// <summary>
        /// Space-separated OAuth scopes requested during refresh, if configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// How the OAuth client authenticates to the token endpoint, excluding its client secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_endpoint_auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.McpOauthTokenEndpointAuthResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResource TokenEndpointAuth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpOauthRefreshResource" /> class.
        /// </summary>
        /// <param name="tokenEndpoint">
        /// The HTTPS OAuth token endpoint used for refresh.
        /// </param>
        /// <param name="clientId">
        /// The OAuth client ID used when requesting a new access token.
        /// </param>
        /// <param name="tokenEndpointAuth">
        /// How the OAuth client authenticates to the token endpoint, excluding its client secret.
        /// </param>
        /// <param name="resource">
        /// The resource URI sent to the OAuth token endpoint during refresh, if configured.
        /// </param>
        /// <param name="scope">
        /// Space-separated OAuth scopes requested during refresh, if configured.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpOauthRefreshResource(
            string tokenEndpoint,
            string clientId,
            global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResource tokenEndpointAuth,
            string? resource,
            string? scope)
        {
            this.TokenEndpoint = tokenEndpoint ?? throw new global::System.ArgumentNullException(nameof(tokenEndpoint));
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.Resource = resource;
            this.Scope = scope;
            this.TokenEndpointAuth = tokenEndpointAuth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpOauthRefreshResource" /> class.
        /// </summary>
        public McpOauthRefreshResource()
        {
        }

    }
}
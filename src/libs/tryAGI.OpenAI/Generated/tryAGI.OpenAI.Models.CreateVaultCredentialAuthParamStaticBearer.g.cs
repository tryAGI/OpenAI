
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A bearer token for an MCP server, without automatic OAuth refresh.
    /// </summary>
    public sealed partial class CreateVaultCredentialAuthParamStaticBearer
    {
        /// <summary>
        /// The type of the object. Always `static_bearer`.<br/>
        /// Default Value: static_bearer
        /// </summary>
        /// <default>global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearerType.StaticBearer</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateVaultCredentialAuthParamStaticBearerTypeJsonConverter))]
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearerType Type { get; set; } = global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearerType.StaticBearer;

        /// <summary>
        /// The HTTPS MCP server URL authorized by this credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpServerUrl { get; set; }

        /// <summary>
        /// The bearer token to store. This secret is never returned in credential resources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVaultCredentialAuthParamStaticBearer" /> class.
        /// </summary>
        /// <param name="mcpServerUrl">
        /// The HTTPS MCP server URL authorized by this credential.
        /// </param>
        /// <param name="token">
        /// The bearer token to store. This secret is never returned in credential resources.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `static_bearer`.<br/>
        /// Default Value: static_bearer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVaultCredentialAuthParamStaticBearer(
            string mcpServerUrl,
            string token,
            global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearerType type = global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearerType.StaticBearer)
        {
            this.Type = type;
            this.McpServerUrl = mcpServerUrl ?? throw new global::System.ArgumentNullException(nameof(mcpServerUrl));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVaultCredentialAuthParamStaticBearer" /> class.
        /// </summary>
        public CreateVaultCredentialAuthParamStaticBearer()
        {
        }

    }
}
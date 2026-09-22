
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Metadata for a bearer-token credential, without automatic OAuth refresh.
    /// </summary>
    public sealed partial class VaultCredentialAuthResourceStaticBearer
    {
        /// <summary>
        /// The type of the object. Always `static_bearer`.<br/>
        /// Default Value: static_bearer
        /// </summary>
        /// <default>global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearerType.StaticBearer</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VaultCredentialAuthResourceStaticBearerTypeJsonConverter))]
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearerType Type { get; set; } = global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearerType.StaticBearer;

        /// <summary>
        /// The HTTPS MCP server URL authorized by this credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpServerUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultCredentialAuthResourceStaticBearer" /> class.
        /// </summary>
        /// <param name="mcpServerUrl">
        /// The HTTPS MCP server URL authorized by this credential.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `static_bearer`.<br/>
        /// Default Value: static_bearer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultCredentialAuthResourceStaticBearer(
            string mcpServerUrl,
            global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearerType type = global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearerType.StaticBearer)
        {
            this.Type = type;
            this.McpServerUrl = mcpServerUrl ?? throw new global::System.ArgumentNullException(nameof(mcpServerUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultCredentialAuthResourceStaticBearer" /> class.
        /// </summary>
        public VaultCredentialAuthResourceStaticBearer()
        {
        }

        /// <summary>
        /// Creates a new <see cref="VaultCredentialAuthResourceStaticBearer"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static VaultCredentialAuthResourceStaticBearer FromMcpServerUrl(string mcpServerUrl)
        {
            return new VaultCredentialAuthResourceStaticBearer
            {
                McpServerUrl = mcpServerUrl,
            };
        }

    }
}
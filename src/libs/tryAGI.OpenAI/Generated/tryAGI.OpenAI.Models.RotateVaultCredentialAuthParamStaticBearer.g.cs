
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Replace the bearer token for the credential's MCP server.
    /// </summary>
    public sealed partial class RotateVaultCredentialAuthParamStaticBearer
    {
        /// <summary>
        /// The type of the object. Always `static_bearer`.<br/>
        /// Default Value: static_bearer
        /// </summary>
        /// <default>global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearerType.StaticBearer</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RotateVaultCredentialAuthParamStaticBearerTypeJsonConverter))]
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearerType Type { get; set; } = global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearerType.StaticBearer;

        /// <summary>
        /// The replacement bearer token. This secret is never returned in credential resources.
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
        /// Initializes a new instance of the <see cref="RotateVaultCredentialAuthParamStaticBearer" /> class.
        /// </summary>
        /// <param name="token">
        /// The replacement bearer token. This secret is never returned in credential resources.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `static_bearer`.<br/>
        /// Default Value: static_bearer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RotateVaultCredentialAuthParamStaticBearer(
            string token,
            global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearerType type = global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearerType.StaticBearer)
        {
            this.Type = type;
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateVaultCredentialAuthParamStaticBearer" /> class.
        /// </summary>
        public RotateVaultCredentialAuthParamStaticBearer()
        {
        }

        /// <summary>
        /// Creates a new <see cref="RotateVaultCredentialAuthParamStaticBearer"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static RotateVaultCredentialAuthParamStaticBearer FromToken(string token)
        {
            return new RotateVaultCredentialAuthParamStaticBearer
            {
                Token = token,
            };
        }

    }
}

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Updates credentials sent using HTTP Basic authentication.
    /// </summary>
    public sealed partial class RotateMcpOauthTokenEndpointAuthParamClientSecretBasic
    {
        /// <summary>
        /// The type of the object. Always `client_secret_basic`.<br/>
        /// Default Value: client_secret_basic
        /// </summary>
        /// <default>global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType.ClientSecretBasic</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RotateMcpOauthTokenEndpointAuthParamClientSecretBasicTypeJsonConverter))]
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType Type { get; set; } = global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType.ClientSecretBasic;

        /// <summary>
        /// The replacement OAuth client secret. Omit or pass `null` to keep the stored secret. This secret is never returned in resources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateMcpOauthTokenEndpointAuthParamClientSecretBasic" /> class.
        /// </summary>
        /// <param name="clientSecret">
        /// The replacement OAuth client secret. Omit or pass `null` to keep the stored secret. This secret is never returned in resources.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `client_secret_basic`.<br/>
        /// Default Value: client_secret_basic
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RotateMcpOauthTokenEndpointAuthParamClientSecretBasic(
            string? clientSecret,
            global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType type = global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType.ClientSecretBasic)
        {
            this.Type = type;
            this.ClientSecret = clientSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateMcpOauthTokenEndpointAuthParamClientSecretBasic" /> class.
        /// </summary>
        public RotateMcpOauthTokenEndpointAuthParamClientSecretBasic()
        {
        }

    }
}
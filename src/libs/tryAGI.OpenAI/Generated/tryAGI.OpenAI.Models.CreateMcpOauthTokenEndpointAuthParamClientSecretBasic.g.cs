
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Sends the client ID and secret using HTTP Basic authentication.
    /// </summary>
    public sealed partial class CreateMcpOauthTokenEndpointAuthParamClientSecretBasic
    {
        /// <summary>
        /// The type of the object. Always `client_secret_basic`.<br/>
        /// Default Value: client_secret_basic
        /// </summary>
        /// <default>global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasicType.ClientSecretBasic</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateMcpOauthTokenEndpointAuthParamClientSecretBasicTypeJsonConverter))]
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasicType Type { get; set; } = global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasicType.ClientSecretBasic;

        /// <summary>
        /// The OAuth client secret to store. Never returned in credential resources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMcpOauthTokenEndpointAuthParamClientSecretBasic" /> class.
        /// </summary>
        /// <param name="clientSecret">
        /// The OAuth client secret to store. Never returned in credential resources.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `client_secret_basic`.<br/>
        /// Default Value: client_secret_basic
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateMcpOauthTokenEndpointAuthParamClientSecretBasic(
            string clientSecret,
            global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasicType type = global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasicType.ClientSecretBasic)
        {
            this.Type = type;
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMcpOauthTokenEndpointAuthParamClientSecretBasic" /> class.
        /// </summary>
        public CreateMcpOauthTokenEndpointAuthParamClientSecretBasic()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateMcpOauthTokenEndpointAuthParamClientSecretBasic"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateMcpOauthTokenEndpointAuthParamClientSecretBasic FromClientSecret(string clientSecret)
        {
            return new CreateMcpOauthTokenEndpointAuthParamClientSecretBasic
            {
                ClientSecret = clientSecret,
            };
        }

    }
}
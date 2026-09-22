
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Sends the client ID and secret in the token request body.
    /// </summary>
    public sealed partial class CreateMcpOauthTokenEndpointAuthParamClientSecretPost
    {
        /// <summary>
        /// The type of the object. Always `client_secret_post`.<br/>
        /// Default Value: client_secret_post
        /// </summary>
        /// <default>global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPostType.ClientSecretPost</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateMcpOauthTokenEndpointAuthParamClientSecretPostTypeJsonConverter))]
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPostType Type { get; set; } = global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPostType.ClientSecretPost;

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
        /// Initializes a new instance of the <see cref="CreateMcpOauthTokenEndpointAuthParamClientSecretPost" /> class.
        /// </summary>
        /// <param name="clientSecret">
        /// The OAuth client secret to store. Never returned in credential resources.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `client_secret_post`.<br/>
        /// Default Value: client_secret_post
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateMcpOauthTokenEndpointAuthParamClientSecretPost(
            string clientSecret,
            global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPostType type = global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPostType.ClientSecretPost)
        {
            this.Type = type;
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMcpOauthTokenEndpointAuthParamClientSecretPost" /> class.
        /// </summary>
        public CreateMcpOauthTokenEndpointAuthParamClientSecretPost()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateMcpOauthTokenEndpointAuthParamClientSecretPost"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateMcpOauthTokenEndpointAuthParamClientSecretPost FromClientSecret(string clientSecret)
        {
            return new CreateMcpOauthTokenEndpointAuthParamClientSecretPost
            {
                ClientSecret = clientSecret,
            };
        }

    }
}
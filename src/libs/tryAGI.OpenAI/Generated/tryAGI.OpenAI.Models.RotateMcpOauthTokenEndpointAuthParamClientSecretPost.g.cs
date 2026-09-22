
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Updates credentials sent in the token request body.
    /// </summary>
    public sealed partial class RotateMcpOauthTokenEndpointAuthParamClientSecretPost
    {
        /// <summary>
        /// The type of the object. Always `client_secret_post`.<br/>
        /// Default Value: client_secret_post
        /// </summary>
        /// <default>global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPostType.ClientSecretPost</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RotateMcpOauthTokenEndpointAuthParamClientSecretPostTypeJsonConverter))]
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPostType Type { get; set; } = global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPostType.ClientSecretPost;

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
        /// Initializes a new instance of the <see cref="RotateMcpOauthTokenEndpointAuthParamClientSecretPost" /> class.
        /// </summary>
        /// <param name="clientSecret">
        /// The replacement OAuth client secret. Omit or pass `null` to keep the stored secret. This secret is never returned in resources.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `client_secret_post`.<br/>
        /// Default Value: client_secret_post
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RotateMcpOauthTokenEndpointAuthParamClientSecretPost(
            string? clientSecret,
            global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPostType type = global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPostType.ClientSecretPost)
        {
            this.Type = type;
            this.ClientSecret = clientSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateMcpOauthTokenEndpointAuthParamClientSecretPost" /> class.
        /// </summary>
        public RotateMcpOauthTokenEndpointAuthParamClientSecretPost()
        {
        }

    }
}
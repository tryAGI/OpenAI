
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Sends the client ID and secret in the token request body.
    /// </summary>
    public sealed partial class McpOauthTokenEndpointAuthResourceClientSecretPost
    {
        /// <summary>
        /// The type of the object. Always `client_secret_post`.<br/>
        /// Default Value: client_secret_post
        /// </summary>
        /// <default>global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPostType.ClientSecretPost</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.McpOauthTokenEndpointAuthResourceClientSecretPostTypeJsonConverter))]
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPostType Type { get; set; } = global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPostType.ClientSecretPost;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpOauthTokenEndpointAuthResourceClientSecretPost" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the object. Always `client_secret_post`.<br/>
        /// Default Value: client_secret_post
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpOauthTokenEndpointAuthResourceClientSecretPost(
            global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPostType type = global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPostType.ClientSecretPost)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpOauthTokenEndpointAuthResourceClientSecretPost" /> class.
        /// </summary>
        public McpOauthTokenEndpointAuthResourceClientSecretPost()
        {
        }

    }
}

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Sends the client ID and secret using HTTP Basic authentication.
    /// </summary>
    public sealed partial class McpOauthTokenEndpointAuthResourceClientSecretBasic
    {
        /// <summary>
        /// The type of the object. Always `client_secret_basic`.<br/>
        /// Default Value: client_secret_basic
        /// </summary>
        /// <default>global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasicType.ClientSecretBasic</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.McpOauthTokenEndpointAuthResourceClientSecretBasicTypeJsonConverter))]
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasicType Type { get; set; } = global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasicType.ClientSecretBasic;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpOauthTokenEndpointAuthResourceClientSecretBasic" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the object. Always `client_secret_basic`.<br/>
        /// Default Value: client_secret_basic
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpOauthTokenEndpointAuthResourceClientSecretBasic(
            global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasicType type = global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasicType.ClientSecretBasic)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpOauthTokenEndpointAuthResourceClientSecretBasic" /> class.
        /// </summary>
        public McpOauthTokenEndpointAuthResourceClientSecretBasic()
        {
        }

    }
}
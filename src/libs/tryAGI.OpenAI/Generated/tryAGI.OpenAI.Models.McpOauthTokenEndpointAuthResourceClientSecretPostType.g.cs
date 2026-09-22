
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `client_secret_post`.<br/>
    /// Default Value: client_secret_post
    /// </summary>
    public enum McpOauthTokenEndpointAuthResourceClientSecretPostType
    {
        /// <summary>
        ///
        /// </summary>
        ClientSecretPost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpOauthTokenEndpointAuthResourceClientSecretPostTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpOauthTokenEndpointAuthResourceClientSecretPostType value)
        {
            return value switch
            {
                McpOauthTokenEndpointAuthResourceClientSecretPostType.ClientSecretPost => "client_secret_post",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpOauthTokenEndpointAuthResourceClientSecretPostType? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_post" => McpOauthTokenEndpointAuthResourceClientSecretPostType.ClientSecretPost,
                _ => null,
            };
        }
    }
}
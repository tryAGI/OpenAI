
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `client_secret_post`.<br/>
    /// Default Value: client_secret_post
    /// </summary>
    public enum CreateMcpOauthTokenEndpointAuthParamClientSecretPostType
    {
        /// <summary>
        ///
        /// </summary>
        ClientSecretPost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateMcpOauthTokenEndpointAuthParamClientSecretPostTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMcpOauthTokenEndpointAuthParamClientSecretPostType value)
        {
            return value switch
            {
                CreateMcpOauthTokenEndpointAuthParamClientSecretPostType.ClientSecretPost => "client_secret_post",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMcpOauthTokenEndpointAuthParamClientSecretPostType? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_post" => CreateMcpOauthTokenEndpointAuthParamClientSecretPostType.ClientSecretPost,
                _ => null,
            };
        }
    }
}
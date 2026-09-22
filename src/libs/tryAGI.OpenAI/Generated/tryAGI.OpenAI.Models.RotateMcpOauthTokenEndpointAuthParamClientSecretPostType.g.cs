
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `client_secret_post`.<br/>
    /// Default Value: client_secret_post
    /// </summary>
    public enum RotateMcpOauthTokenEndpointAuthParamClientSecretPostType
    {
        /// <summary>
        ///
        /// </summary>
        ClientSecretPost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RotateMcpOauthTokenEndpointAuthParamClientSecretPostTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RotateMcpOauthTokenEndpointAuthParamClientSecretPostType value)
        {
            return value switch
            {
                RotateMcpOauthTokenEndpointAuthParamClientSecretPostType.ClientSecretPost => "client_secret_post",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RotateMcpOauthTokenEndpointAuthParamClientSecretPostType? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_post" => RotateMcpOauthTokenEndpointAuthParamClientSecretPostType.ClientSecretPost,
                _ => null,
            };
        }
    }
}
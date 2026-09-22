
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum McpOauthTokenEndpointAuthResourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        ClientSecretBasic,
        /// <summary>
        ///
        /// </summary>
        ClientSecretPost,
        /// <summary>
        ///
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpOauthTokenEndpointAuthResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpOauthTokenEndpointAuthResourceDiscriminatorType value)
        {
            return value switch
            {
                McpOauthTokenEndpointAuthResourceDiscriminatorType.ClientSecretBasic => "client_secret_basic",
                McpOauthTokenEndpointAuthResourceDiscriminatorType.ClientSecretPost => "client_secret_post",
                McpOauthTokenEndpointAuthResourceDiscriminatorType.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpOauthTokenEndpointAuthResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_basic" => McpOauthTokenEndpointAuthResourceDiscriminatorType.ClientSecretBasic,
                "client_secret_post" => McpOauthTokenEndpointAuthResourceDiscriminatorType.ClientSecretPost,
                "none" => McpOauthTokenEndpointAuthResourceDiscriminatorType.None,
                _ => null,
            };
        }
    }
}
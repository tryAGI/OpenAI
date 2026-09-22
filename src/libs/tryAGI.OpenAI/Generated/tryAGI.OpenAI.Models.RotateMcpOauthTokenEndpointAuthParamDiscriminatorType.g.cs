
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum RotateMcpOauthTokenEndpointAuthParamDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        ClientSecretBasic,
        /// <summary>
        ///
        /// </summary>
        ClientSecretPost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RotateMcpOauthTokenEndpointAuthParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RotateMcpOauthTokenEndpointAuthParamDiscriminatorType value)
        {
            return value switch
            {
                RotateMcpOauthTokenEndpointAuthParamDiscriminatorType.ClientSecretBasic => "client_secret_basic",
                RotateMcpOauthTokenEndpointAuthParamDiscriminatorType.ClientSecretPost => "client_secret_post",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RotateMcpOauthTokenEndpointAuthParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_basic" => RotateMcpOauthTokenEndpointAuthParamDiscriminatorType.ClientSecretBasic,
                "client_secret_post" => RotateMcpOauthTokenEndpointAuthParamDiscriminatorType.ClientSecretPost,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `client_secret_basic`.<br/>
    /// Default Value: client_secret_basic
    /// </summary>
    public enum RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType
    {
        /// <summary>
        ///
        /// </summary>
        ClientSecretBasic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RotateMcpOauthTokenEndpointAuthParamClientSecretBasicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType value)
        {
            return value switch
            {
                RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType.ClientSecretBasic => "client_secret_basic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_basic" => RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType.ClientSecretBasic,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateMcpOauthTokenEndpointAuthParamDiscriminatorType
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
    public static class CreateMcpOauthTokenEndpointAuthParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMcpOauthTokenEndpointAuthParamDiscriminatorType value)
        {
            return value switch
            {
                CreateMcpOauthTokenEndpointAuthParamDiscriminatorType.ClientSecretBasic => "client_secret_basic",
                CreateMcpOauthTokenEndpointAuthParamDiscriminatorType.ClientSecretPost => "client_secret_post",
                CreateMcpOauthTokenEndpointAuthParamDiscriminatorType.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMcpOauthTokenEndpointAuthParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_basic" => CreateMcpOauthTokenEndpointAuthParamDiscriminatorType.ClientSecretBasic,
                "client_secret_post" => CreateMcpOauthTokenEndpointAuthParamDiscriminatorType.ClientSecretPost,
                "none" => CreateMcpOauthTokenEndpointAuthParamDiscriminatorType.None,
                _ => null,
            };
        }
    }
}
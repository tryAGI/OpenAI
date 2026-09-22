
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `mcp_oauth`.<br/>
    /// Default Value: mcp_oauth
    /// </summary>
    public enum RotateVaultCredentialAuthParamMcpOauthType
    {
        /// <summary>
        ///
        /// </summary>
        McpOauth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RotateVaultCredentialAuthParamMcpOauthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RotateVaultCredentialAuthParamMcpOauthType value)
        {
            return value switch
            {
                RotateVaultCredentialAuthParamMcpOauthType.McpOauth => "mcp_oauth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RotateVaultCredentialAuthParamMcpOauthType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_oauth" => RotateVaultCredentialAuthParamMcpOauthType.McpOauth,
                _ => null,
            };
        }
    }
}